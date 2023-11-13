using System.Security.Claims;

using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

using Skornel02.ETR.Api.Entities;
using Skornel02.ETR.Api.Mappers;
using Skornel02.ETR.Api.Services;
using Skornel02.ETR.Common.Dtos;
using Skornel02.ETR.Common.Enums;

namespace Skornel02.ETR.Api.Endpoints;

public static class ExamEndpointsExtension
{
    public static void MapExamEndpoints(this WebApplication app)
    {
        app.MapGet("/api/exams", async (
            ClaimsPrincipal principal,
            ETRContext context,
            [FromQuery] bool teachedByMe = false,
            [FromQuery] bool attendedByMe = false
            ) =>
        {
            if (!teachedByMe && !attendedByMe)
            {
                var courses = await context.Database.SqlQuery<ExamDto>($"""
                    SELECT
                        e.CourseCode,
                        e.CourseSemester,
                        e.Start,
                        e.End,
                        e.ExamType,]
                        ClassRoomAddress,
                        ClassRoomRoomName AS ClassRoomNumber,
                        cr.Name AS 'ClassRoomName'
                    FROM Exams e
                        INNER JOIN ClassRooms cr ON cr.Address = e.ClassRoomAddress 
                            AND cr.RoomNumber = e.ClassRoomRoomName
                """).ToListAsync();

                return Results.Ok(courses);
            }
            else
            {
                var username = principal.ToETR().Username;

                var courses = await context.Database.SqlQuery<CourseDto>($"""
                    SELECT
                        e.CourseCode,
                        e.CourseSemester,
                        e.Start,
                        e.End,
                        e.ExamType,]
                        ClassRoomAddress,
                        ClassRoomRoomName AS ClassRoomNumber,
                        cr.Name AS 'ClassRoomName'
                    FROM Exams e
                        INNER JOIN ClassRooms cr ON cr.Address = e.ClassRoomAddress 
                            AND cr.RoomNumber = e.ClassRoomRoomName
                        INNER JOIN ExamAttendances ea ON ea.CourseCode = e.CourseCode 
                            AND ea.CourseSemester = e.CourseSemester
                    WHERE 
                        ({!teachedByMe} OR 
                            (ea.AttendanceType = {AttendanceType.Organizer} AND ea.Username = {username}))
                        AND ({!attendedByMe} OR
                            (ea.AttendanceType = {AttendanceType.Participant} AND ea.Username = {username}))
                """).ToListAsync();

                return Results.Ok(courses);
            }
        })
            .WithTags("Exams")
            .RequireAuthorization();

        // app.MapPost("/api/courses", async (
        //     ClaimsPrincipal principal,
        //     [FromBody] CourseCreationDto dto,
        //     ETRContext context
        // ) =>
        // {
        //     var session = principal.ToETR();
        //     var username = session.Username;
        //     var userRoles = await context.RolesFromUserAsync(username);

        //     if (!userRoles.Contains(RoleType.Teacher))
        //         return Results.Forbid();

        //     var metadatas = await context.Database.SqlQuery<CourseMetadataResponseDto>($"""
        //         SELECT Name, Type FROM CourseMetadatas
        //             WHERE CourseCode = {dto.CourseCode}
        //             LIMIT 1
        //         """).ToListAsync();

        //     if (metadatas.Count == 0)
        //     {
        //         var metadata = dto.ToMetadata();
        //         await context.CourseMetadatas.AddAsync(metadata);
        //     }

        //     var course = dto.ToCourse();
        //     await context.Courses.AddAsync(course);

        //     var attendance = new CourseAttendance()
        //     {
        //         AttendanceType = AttendanceType.Organizer,
        //         Course = course,
        //         Username = username,
        //     };
        //     await context.CourseAttendances.AddAsync(attendance);

        //     try
        //     {
        //         await context.SaveChangesAsync();

        //         return Results.Created();
        //     }
        //     catch (DbUpdateException ex)
        //     {
        //         return Results.BadRequest($"Adatbázis hiba történt! {ex?.InnerException?.Message}".ToError());
        //     }
        // })
        //     .WithTags("Exams")
        //     .RequireAuthorization();

        app.MapPost("/api/exams-teach", async (
            ClaimsPrincipal principal,
            [FromQuery] string code,
            [FromQuery] string semester,
            [FromQuery] DateTimeOffset start,
            ETRContext context) =>
        {
            var session = principal.ToETR();
            var username = session.Username;
            var userRoles = await context.RolesFromUserAsync(username);

            if (!userRoles.Contains(RoleType.Teacher))
                return Results.Forbid();

            var attendances = await context.GetExamAttendanceAsync(username, code, semester, start);
            if (attendances.Count != 0)
                return Results.BadRequest("Ez a vizsga már szerepel a tanított szervezett vizsgák között!".ToError());

            var attendance = new ExamAttendance()
            {
                AttendanceType = AttendanceType.Organizer,
                CourseCode = code,
                CourseSemester = semester,
                CourseStart = start,
                Username = username,
            };

            await context.ExamAttendances.AddAsync(attendance);
            await context.SaveChangesAsync();

            return Results.NoContent();
        })
            .WithTags("Exams")
            .RequireAuthorization();

        app.MapDelete("/api/exams-teach", async (
            ClaimsPrincipal principal,
            [FromQuery] string code,
            [FromQuery] string semester,
            [FromQuery] DateTimeOffset start,
            ETRContext context) =>
        {
            var session = principal.ToETR();
            var username = session.Username;
            var userRoles = await context.RolesFromUserAsync(username);

            if (!userRoles.Contains(RoleType.Teacher))
                return Results.Forbid();

            var attendances = await context.GetExamAttendanceAsync(username, code, semester, start);
            if (attendances.Count == 0)
                return Results.BadRequest("Ez a kurzus nem szerepel az általad tanított kurzusok között!".ToError());

            await context.ExamAttendances
                .Where(ea => ea.Username == username
                    && ea.CourseCode == code
                    && ea.CourseSemester == semester
                    && ea.CourseStart == start)
                .ExecuteDeleteAsync();

            return Results.NoContent();
        })
            .WithTags("Exams")
            .RequireAuthorization();

        app.MapPost("/api/exams-learn", async (
            ClaimsPrincipal principal,
            [FromQuery] string code,
            [FromQuery] string semester,
            [FromQuery] DateTimeOffset start,
            ETRContext context) =>
        {
            var session = principal.ToETR();
            var username = session.Username;
            var userRoles = await context.RolesFromUserAsync(username);

            if (!userRoles.Contains(RoleType.Student))
                return Results.Forbid();

            var courseAttendances = await context.GetCourseAttendanceAsync(username, code, semester);
            if (courseAttendances.Count == 0)
                return Results.BadRequest("Mivel nem vetted fel a tárgyat, így nem vizsgázhatsz belőle!".ToError());

            var attendances = await context.GetExamAttendanceAsync(username, code, semester, start);
            if (attendances.Count != 0)
                return Results.BadRequest("Ez a vizsga már szerepel a vizsgáid között!".ToError());

            var attendance = new ExamAttendance()
            {
                AttendanceType = AttendanceType.Participant,
                CourseCode = code,
                CourseSemester = semester,
                CourseStart = start,
                Username = username,
            };

            await context.ExamAttendances.AddAsync(attendance);
            await context.SaveChangesAsync();

            return Results.NoContent();
        })
            .WithTags("Exams")
            .RequireAuthorization();

        app.MapDelete("/api/exams-learn", async (
            ClaimsPrincipal principal,
            [FromQuery] string code,
            [FromQuery] string semester,
            [FromQuery] DateTimeOffset start,
            ETRContext context) =>
        {
            var session = principal.ToETR();
            var username = session.Username;
            var userRoles = await context.RolesFromUserAsync(username);

            if (!userRoles.Contains(RoleType.Student))
                return Results.Forbid();

            var attendances = await context.GetExamAttendanceAsync(username, code, semester, start);
            if (attendances.Count == 0)
                return Results.BadRequest("Ez a vizsga nem szerepel a vizsgáid között!".ToError());

            await context.ExamAttendances
                .Where(ea => ea.Username == username
                    && ea.CourseCode == code
                    && ea.CourseSemester == semester
                    && ea.CourseStart == start)
                .ExecuteDeleteAsync();

            return Results.NoContent();
        })
            .WithTags("Exams")
            .RequireAuthorization();
    }
}