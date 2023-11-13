using System.ComponentModel.DataAnnotations.Schema;

using Microsoft.EntityFrameworkCore;

using Skornel02.ETR.Common.Enums;

namespace Skornel02.ETR.Api.Entities;

[Table("ExamAttendances"), PrimaryKey(nameof(Username), nameof(CourseCode), nameof(CourseSemester), nameof(CourseStart))]
public class ExamAttendance
{
    [ForeignKey(nameof(User))]
    public string Username { get; set; } = default!;
    public User User { get; set; } = default!;

    public string CourseCode { get; set; } = default!;
    public string CourseSemester { get; set; } = default!;
    public DateTimeOffset CourseStart { get; set; }
    [ForeignKey($"{nameof(CourseCode)}, {nameof(CourseSemester)}, {nameof(CourseStart)}")]
    public Exam Exam { get; set; } = default!;

    [Comment("Vizsga részvétel típusa (hallgató, oktató)")]
    public required AttendanceType AttendanceType { get; set; }
    [Comment("Elért érdemjegy")]
    public string? Grade { get; set; }
}