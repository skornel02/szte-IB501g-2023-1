using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

using Microsoft.EntityFrameworkCore;

using Skornel02.ETR.Common.Enums;

namespace Skornel02.ETR.Api.Entities;

[Table("ExamAttendances"), PrimaryKey(nameof(Username), nameof(CourseCode), nameof(CourseSemester), nameof(CourseStart))]
public class ExamAttendance
{
    [ForeignKey(nameof(User))]
    public string Username { get; init; } = default!;
    public required User User { get; init; }

    public string CourseCode { get; init; } = default!;
    public string CourseSemester { get; init; } = default!;
    public DateTimeOffset CourseStart { get; init; }
    [ForeignKey($"{nameof(CourseCode)}, {nameof(CourseSemester)}, {nameof(CourseStart)}")]
    public required Exam Exam { get; init; }

    public required AttendanceType AttendanceType { get; init; }
    public string? Grade { get; set; }
}