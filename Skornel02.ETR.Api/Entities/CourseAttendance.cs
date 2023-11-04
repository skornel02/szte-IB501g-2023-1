using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;

using Microsoft.EntityFrameworkCore;

using Skornel02.ETR.Common.Enums;

namespace Skornel02.ETR.Api.Entities;

[Table("CourseAttendances"), PrimaryKey(nameof(Username), nameof(CourseCode), nameof(CourseSemester))]
public class CourseAttendance
{
    [ForeignKey(nameof(User))]
    public string Username { get; set; } = default!;
    public User User { get; set; } = default!;

    public string CourseCode { get; set; } = default!;
    public string CourseSemester { get; set; } = default!;
    [ForeignKey($"{nameof(CourseCode)}, {nameof(CourseSemester)}")]
    public Course Course { get; set; } = default!;

    [Description("Részvétel típusa (hallgató, oktató)")]
    public required AttendanceType AttendanceType { get; set; }
    [Description("Elért érdemjegy")]
    public string? Grade { get; set; }
}