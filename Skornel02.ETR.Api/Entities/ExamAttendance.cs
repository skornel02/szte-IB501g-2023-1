using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

using Microsoft.EntityFrameworkCore;

using Skornel02.ETR.Common.Enums;

namespace Skornel02.ETR.Api.Entities;

[PrimaryKey(nameof(Username), nameof(CourseCode), nameof(CourseSemester), nameof(CourseStart))]
public class ExamAttendance
{
    [ForeignKey(nameof(User))]
    public string Username { get; init; } = default!;
    public required User User { get; init; }

    [StringLength(15)]
    public string CourseCode { get; init; } = default!;
    [StringLength(6)]
    public string CourseSemester { get; init; } = default!;
    public DateTimeOffset CourseStart { get; init; }
    [ForeignKey($"{nameof(CourseCode)}, {nameof(CourseSemester)}, {nameof(CourseStart)}")]
    public required Exam Exam { get; init; }

    public required AttendanceType AttendanceType { get; init; }
    public string? Grade { get; set; }
}