
using Microsoft.EntityFrameworkCore;

using Skornel02.ETR.Api;
using Skornel02.ETR.Common.Dtos;
using Skornel02.ETR.Common.Enums;

public static class StatisticsEndpoints
{
    public static void MapStatisticsEndpoints(this WebApplication app)
    {
        app.MapGet("/api/statistics/teachers", async (ETRContext context) =>
        {
            var teachers = await context.Database.SqlQuery<UserStatisticsDto>($"""
                SELECT u.Username, u.Name, u.BirthDate , u.BirthLocation FROM Users u
                    INNER JOIN UserRoles r ON u.Username = r.Username
                    WHERE r.UserType = {RoleType.Teacher}
                    ORDER BY u.BirthDate Desc
                """).ToListAsync();

            return teachers;
        })
            .WithTags("Statistics")
            .RequireAuthorization();

        app.MapGet("/api/statistics/students", async (ETRContext context) =>
        {
            var teachers = await context.Database.SqlQuery<UserCoursesStatisticsDto>($"""
                SELECT u.Username, u.Name, COUNT(ca.CourseCode) as 'CourseCount' FROM Users u
                    INNER JOIN UserRoles r ON u.Username = r.Username
                    LEFT JOIN CourseAttendances ca ON u.Username = ca.Username
                    WHERE r.UserType = {RoleType.Student}
                    GROUP BY u.Username, u.Name
                    ORDER BY u.Name Asc
                """).ToListAsync();

            return teachers;
        })
            .WithTags("Statistics")
            .RequireAuthorization();

        app.MapGet("/api/statistics/teacher-load-level", async (ETRContext context) =>
        {
            var teachersLoadLevel = await context.Database.SqlQuery<TeacherLoadStatisticsDto>($"""
                SELECT u.Username, u.Name, c.Semester , sum(c.Hours) 
                    FROM Users u
                    INNER JOIN UserRoles r ON u.Username = r.Username
                    INNER JOIN CourseAttendances ca ON u.Username = ca.Username 
                    INNER JOIN Courses c  on c.CourseCode = ca.CourseCode and c.Semester = ca.CourseSemester 
                    WHERE r.UserType = {RoleType.Teacher} 
                        and (ca.AttendanceType is null or ca.AttendanceType = {AttendanceType.Organizer})
                    GROUP BY u.Username, u.Name, c.Semester
                    ORDER BY u.Name Asc, c.Semester Desc
                """).ToListAsync();

            return teachersLoadLevel;
        })
            .WithTags("Statistics")
            .RequireAuthorization();
    }
}