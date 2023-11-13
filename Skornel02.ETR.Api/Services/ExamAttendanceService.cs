using Microsoft.EntityFrameworkCore;

using Skornel02.ETR.Common.Dtos;

namespace Skornel02.ETR.Api.Services;

public static class ExamAttendanceSevice
{
    public static Task<List<ExamAttendanceDto>> GetExamAttendanceAsync(this ETRContext context, string username)
    {
        return context.Database.SqlQuery<ExamAttendanceDto>($"""
                SELECT Username, CourseCode, CourseSemester, CourseStart as 'Start', AttendanceType, Grade from ExamAttendances ea
                    WHERE ea.Username = {username}
            """).ToListAsync();
    }

    public static Task<List<ExamAttendanceDto>> GetExamAttendanceAsync(
        this ETRContext context,
        string username,
        string courseCode,
        string courseSemester,
        DateTimeOffset start)
    {
        return context.Database.SqlQuery<ExamAttendanceDto>($"""
                SELECT Username, CourseCode, CourseSemester, CourseStart as 'Start', AttendanceType, Grade from ExamAttendances ea
                    WHERE ea.Username = {username} 
                        AND ea.CourseCode = {courseCode} 
                        AND ea.CourseSemester = {courseSemester}
                        AND ea.Start = {start}
            """).ToListAsync();
    }
}