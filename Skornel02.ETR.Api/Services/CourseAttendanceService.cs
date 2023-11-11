using Microsoft.EntityFrameworkCore;

using Skornel02.ETR.Common.Dtos;

namespace Skornel02.ETR.Api.Services;

public static class CourseAttendanceSevice
{
    public static Task<List<CourseAttendanceDto>> GetCourseAttendanceAsync(this ETRContext context, string username)
    {
        return context.Database.SqlQuery<CourseAttendanceDto>($"""
                SELECT Username, CourseCode, CourseSemester, AttendanceType, Grade from CourseAttendances ca
                    WHERE ca.Username = {username}
            """).ToListAsync();
    }

    public static Task<List<CourseAttendanceDto>> GetCourseAttendanceAsync(
        this ETRContext context,
        string username,
        string courseCode,
        string courseSemester)
    {
        return context.Database.SqlQuery<CourseAttendanceDto>($"""
                SELECT Username, CourseCode, CourseSemester, AttendanceType, Grade from CourseAttendances ca
                    WHERE ca.Username = {username} AND ca.CourseCode = {courseCode} AND ca.CourseSemester = {courseSemester}
            """).ToListAsync();
    }
}