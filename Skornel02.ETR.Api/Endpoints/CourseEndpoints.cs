using System.Security.Claims;

using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

using Skornel02.ETR.Api.Entities;
using Skornel02.ETR.Api.Mappers;
using Skornel02.ETR.Api.Services;
using Skornel02.ETR.Common.Dtos;
using Skornel02.ETR.Common.Enums;

namespace Skornel02.ETR.Api.Endpoints;

public static class CourseEndpointsExtension
{
    public static void MapCourseEndpoints(this WebApplication app)
    {
        app.MapGet("/api/courses", async (
            ClaimsPrincipal principal,
            ETRContext context,
            [FromQuery] bool teachedByMe = false,
            [FromQuery] bool attendedByMe = false
            ) =>
        {
            if (!teachedByMe && !attendedByMe)
            {
                var courses = await context.Database.SqlQuery<CourseDto>($"""
                    SELECT
                        c.CourseCode,
                        Semester AS 'CourseSemester',
                        Hours,
                        Credits,
                        cm.Name AS CourseName,
                        cm.Type AS CourseType,
                        ClassRoomAddress,
                        ClassRoomRoomName AS ClassRoomNumber,
                        cr.Name AS 'ClassRoomName'
                    FROM Courses c
                        INNER JOIN CourseMetadatas cm ON cm.CourseCode = c.CourseCode
                        INNER JOIN ClassRooms cr ON cr.Address = c.ClassRoomAddress 
                            AND cr.RoomNumber = c.ClassRoomRoomName
                """).ToListAsync();

                return Results.Ok(courses);
            }
            else
            {
                var username = principal.ToETR().Username;

                var courses = await context.Database.SqlQuery<CourseDto>($"""
                    SELECT
                        c.CourseCode,
                        Semester AS 'CourseSemester',
                        Hours,
                        Credits,
                        cm.Name AS CourseName,
                        cm.Type AS CourseType,
                        ClassRoomAddress,
                        ClassRoomRoomName AS ClassRoomNumber,
                        cr.Name AS 'ClassRoomName'
                    FROM Courses c
                        INNER JOIN CourseMetadatas cm ON cm.CourseCode = c.CourseCode
                        INNER JOIN ClassRooms cr ON cr.Address = c.ClassRoomAddress 
                            AND cr.RoomNumber = c.ClassRoomRoomName
                        INNER JOIN CourseAttendances ca ON ca.CourseCode = c.CourseCode 
                            AND ca.CourseSemester = c.Semester
                    WHERE 
                        ({!teachedByMe} OR 
                            (ca.AttendanceType = {AttendanceType.Organizer} AND ca.Username = {username}))
                        AND ({!attendedByMe} OR
                            (ca.AttendanceType = {AttendanceType.Participant} AND ca.Username = {username}))
                """).ToListAsync();

                return Results.Ok(courses);
            }
        })
            .WithTags("Courses")
            .RequireAuthorization();

        app.MapGet("/api/courses/{code}", async ([FromRoute] string code, ETRContext context) =>
        {
            var metadatas = await context.Database.SqlQuery<CourseMetadataResponseDto>($"""
                SELECT Name, Type FROM CourseMetadatas
                    WHERE CourseCode = {code}
                    LIMIT 1
                """).ToListAsync();

            return metadatas.FirstOrDefault();
        })
            .WithTags("Courses")
            .RequireAuthorization();

        app.MapPost("/api/courses", async (
            ClaimsPrincipal principal,
            [FromBody] CourseCreationDto dto,
            ETRContext context
        ) =>
        {
            var session = principal.ToETR();
            var username = session.Username;
            var userRoles = await context.RolesFromUserAsync(username);

            if (!userRoles.Contains(RoleType.Teacher))
                return Results.Forbid();

            var coursesInThatRoom = await context.Database.SqlQuery<CourseDto>($"""
                SELECT
                    c.CourseCode,
                    Semester AS 'CourseSemester',
                    Hours,
                    Credits,
                    cm.Name AS CourseName,
                    cm.Type AS CourseType,
                    ClassRoomAddress,
                    ClassRoomRoomName AS ClassRoomNumber,
                    cr.Name AS 'ClassRoomName'
                FROM Courses c
                    INNER JOIN CourseMetadatas cm ON cm.CourseCode = c.CourseCode
                    INNER JOIN ClassRooms cr ON cr.Address = c.ClassRoomAddress 
                        AND cr.RoomNumber = c.ClassRoomRoomName
                WHERE c.ClassRoomAddress = {dto.ClassRoomAddress} AND c.ClassRoomRoomName = {dto.ClassRoomNumber}
            """).ToListAsync();

            if (coursesInThatRoom.Count != 0)
            {
                var courseInThatRoom = coursesInThatRoom.First();
                return Results.BadRequest($"Ebben a teremben már van kurzus! ({courseInThatRoom.CourseCode} - {courseInThatRoom.CourseSemester})".ToError());
            }

            var metadatas = await context.Database.SqlQuery<CourseMetadataResponseDto>($"""
                SELECT Name, Type FROM CourseMetadatas
                    WHERE CourseCode = {dto.CourseCode}
                    LIMIT 1
                """).ToListAsync();

            if (metadatas.Count == 0)
            {
                var metadata = dto.ToMetadata();
                await context.CourseMetadatas.AddAsync(metadata);
            }

            var course = dto.ToCourse();
            await context.Courses.AddAsync(course);

            var attendance = new CourseAttendance()
            {
                AttendanceType = AttendanceType.Organizer,
                Course = course,
                Username = username,
            };
            await context.CourseAttendances.AddAsync(attendance);

            try
            {
                await context.SaveChangesAsync();

                return Results.Created();
            }
            catch (DbUpdateException ex)
            {
                return Results.BadRequest($"Adatbázis hiba történt! {ex?.InnerException?.Message}".ToError());
            }
        })
            .WithTags("Courses")
            .RequireAuthorization();

        app.MapDelete("/api/courses", async (
            ClaimsPrincipal principal,
            [FromQuery] string code,
            [FromQuery] string semester,
            ETRContext context) =>
        {
            var session = principal.ToETR();
            var username = session.Username;
            var userRoles = await context.RolesFromUserAsync(username);

            if (!userRoles.Contains(RoleType.Teacher))
                return Results.Forbid();

            var exams = await context.Database.SqlQuery<ExamDto>($"""
                SELECT
                    e.CourseCode,
                    e.CourseSemester,
                    e.Start,
                    e.End,
                    e.ExamType,
                    ClassRoomAddress,
                    ClassRoomRoomName AS ClassRoomNumber,
                    cr.Name AS 'ClassRoomName'
                FROM Exams e
                    INNER JOIN ClassRooms cr ON cr.Address = e.ClassRoomAddress 
                        AND cr.RoomNumber = e.ClassRoomRoomName
                WHERE e.CourseCode = {code} AND e.CourseSemester = {semester}
                """).ToListAsync();

            if (exams.Count != 0)
            {
                return Results.BadRequest("Ez a kurzus nem törölhető, mert van hozzá vizsga!".ToError());
            }

            await context.Courses
                .Where(course => course.CourseCode == code && course.Semester == semester)
                .ExecuteDeleteAsync();

            return Results.NoContent();
        })
            .WithTags("Courses")
            .RequireAuthorization();

        app.MapPost("/api/course-teach", async (
            ClaimsPrincipal principal,
            [FromQuery] string code,
            [FromQuery] string semester,
            ETRContext context) =>
        {
            var session = principal.ToETR();
            var username = session.Username;
            var userRoles = await context.RolesFromUserAsync(username);

            if (!userRoles.Contains(RoleType.Teacher))
                return Results.Forbid();

            var attendances = await context.GetCourseAttendanceAsync(username, code, semester);
            if (attendances.Count != 0)
                return Results.BadRequest("Ez a kurzus már szerepel a tanított kurzusaid között!".ToError());

            var attendance = new CourseAttendance()
            {
                AttendanceType = AttendanceType.Organizer,
                CourseCode = code,
                CourseSemester = semester,
                Username = username,
            };

            await context.CourseAttendances.AddAsync(attendance);
            await context.SaveChangesAsync();

            return Results.NoContent();
        })
            .WithTags("Courses")
            .RequireAuthorization();

        app.MapDelete("/api/course-teach", async (
            ClaimsPrincipal principal,
            [FromQuery] string code,
            [FromQuery] string semester,
            ETRContext context) =>
        {
            var session = principal.ToETR();
            var username = session.Username;
            var userRoles = await context.RolesFromUserAsync(username);

            if (!userRoles.Contains(RoleType.Teacher))
                return Results.Forbid();

            var attendances = await context.GetCourseAttendanceAsync(username, code, semester);
            if (attendances.Count == 0)
                return Results.BadRequest("Ez a kurzus nem szerepel az általad tanított kurzusok között!".ToError());

            await context.CourseAttendances
                .Where(ca => ca.Username == username && ca.CourseCode == code && ca.CourseSemester == semester)
                .ExecuteDeleteAsync();

            return Results.NoContent();
        })
            .WithTags("Courses")
            .RequireAuthorization();

        app.MapPost("/api/course-learn", async (
            ClaimsPrincipal principal,
            [FromQuery] string code,
            [FromQuery] string semester,
            ETRContext context) =>
        {
            var session = principal.ToETR();
            var username = session.Username;
            var userRoles = await context.RolesFromUserAsync(username);

            if (!userRoles.Contains(RoleType.Student))
                return Results.Forbid();

            var attendances = await context.GetCourseAttendanceAsync(username, code, semester);
            if (attendances.Count != 0)
                return Results.BadRequest("Ez a kurzus már szerepel a kurzusaid között!".ToError());

            var attendance = new CourseAttendance()
            {
                AttendanceType = AttendanceType.Participant,
                CourseCode = code,
                CourseSemester = semester,
                Username = username,
            };

            await context.CourseAttendances.AddAsync(attendance);
            await context.SaveChangesAsync();

            return Results.NoContent();
        })
            .WithTags("Courses")
            .RequireAuthorization();

        app.MapDelete("/api/course-learn", async (
            ClaimsPrincipal principal,
            [FromQuery] string code,
            [FromQuery] string semester,
            ETRContext context) =>
        {
            var session = principal.ToETR();
            var username = session.Username;
            var userRoles = await context.RolesFromUserAsync(username);

            if (!userRoles.Contains(RoleType.Student))
                return Results.Forbid();

            var attendances = await context.GetCourseAttendanceAsync(username, code, semester);
            if (attendances.Count == 0)
                return Results.BadRequest("Ez a kurzus nem szerepel a kurzusaid között!".ToError());

            await context.CourseAttendances
                .Where(ca => ca.Username == username && ca.CourseCode == code && ca.CourseSemester == semester)
                .ExecuteDeleteAsync();

            return Results.NoContent();
        })
            .WithTags("Courses")
            .RequireAuthorization();
    }
}