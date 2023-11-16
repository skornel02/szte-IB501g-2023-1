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
                        e.ExamType,
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

                var courses = await context.Database.SqlQuery<ExamDto>($"""
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
                        INNER JOIN ExamAttendances ea ON ea.CourseCode = e.CourseCode 
                            AND ea.CourseSemester = e.CourseSemester
                            AND ea.CourseStart = e.Start 
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

        app.MapPost("/api/exams", async (
            ClaimsPrincipal principal,
            [FromBody] ExamCreationDto dto,
            ETRContext context
        ) =>
        {
            var session = principal.ToETR();
            var username = session.Username;
            var userRoles = await context.RolesFromUserAsync(username);

            if (!userRoles.Contains(RoleType.Teacher))
                return Results.Forbid();

            var courseExists = await context.Courses
                .AnyAsync(c => c.CourseCode == dto.CourseCode && c.Semester == dto.CourseSemester);

            if (!courseExists)
            {
                return Results.BadRequest("Nem létezik ilyen tárgy!".ToError());
            }

            var exam = dto.ToExam();
            await context.Exams.AddAsync(exam);

            var attendance = new ExamAttendance()
            {
                AttendanceType = AttendanceType.Organizer,
                Exam = exam,
                Username = username,
            };
            await context.ExamAttendances.AddAsync(attendance);

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
            .WithTags("Exams")
            .RequireAuthorization();

        app.MapDelete("/api/exams", async (
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

            await context.Exams
                .Where(exam => exam.CourseCode == code && exam.CourseSemester == semester && exam.Start == start)
                .ExecuteDeleteAsync();

            return Results.NoContent();
        })
            .WithTags("Exams")
            .RequireAuthorization();

        app.MapPatch("/api/exams", async (
            ClaimsPrincipal principal,
            [FromBody] ExamUpdateDto dto,
            ETRContext context
        ) => {
            var session = principal.ToETR();
            var username = session.Username;
            var userRoles = await context.RolesFromUserAsync(username);

            if (!userRoles.Contains(RoleType.Teacher))
                return Results.Forbid();

            await context.Database.ExecuteSqlInterpolatedAsync($"""
                UPDATE Exams
                SET
                    ClassRoomAddress = {dto.ClassRoomAddress},
                    ClassRoomRoomName = {dto.ClassRoomNumber},
                    End = {dto.End},
                    ExamType = {dto.ExamType}
                WHERE
                    CourseCode = {dto.CourseCode}
                    AND CourseSemester = {dto.CourseSemester}
                    AND Start = {dto.OriginalStart}
            """);

            return Results.Accepted();
        });

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