using System.ComponentModel.DataAnnotations.Schema;

using Microsoft.EntityFrameworkCore;

using Skornel02.ETR.Common.Enums;

namespace Skornel02.ETR.Api.Entities;

[Table("Exams"), PrimaryKey(nameof(CourseCode), nameof(CourseSemester), nameof(Start))]
public class Exam
{
    public string CourseCode { get; init; } = default!;
    public string CourseSemester { get; init; } = default!;
    [ForeignKey($"{nameof(CourseCode)}, {nameof(CourseSemester)}")]
    public Course Course { get; set; } = default!;

    [Comment("Vizsga kezdete")]
    public required DateTimeOffset Start { get; set; }
    [Comment("Vizsga vége")]
    public required DateTimeOffset End { get; set; }
    [Comment("Vizsga típusa")]
    public required ExamType ExamType { get; set; }

    public string ClassRoomAddress { get; set; } = default!;
    public string ClassRoomRoomName { get; set; } = default!;

    [ForeignKey($"{nameof(ClassRoomAddress)}, {nameof(ClassRoomRoomName)}")]
    public ClassRoom ClassRoom { get; set; } = default!;

    public List<ExamAttendance> Attendees { get; set; } = [];
}