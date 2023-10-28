using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

using Microsoft.EntityFrameworkCore;

namespace Skornel02.ETR.Api.Entities;

[Table("Exams"), PrimaryKey(nameof(CourseCode), nameof(CourseSemester), nameof(Start))]
public class Exam
{
    public string CourseCode { get; init; } = default!;
    public string CourseSemester { get; init; } = default!;
    [ForeignKey($"{nameof(CourseCode)}, {nameof(CourseSemester)}")]
    public required Course Course { get; init; }

    [Description("Vizsga kezdete")]
    public required DateTimeOffset Start { get; set; }
    [Description("Vizsga vége")]
    public required DateTimeOffset End { get; set; }

    public string ClassRoomAddress { get; set; } = default!;
    public string ClassRoomRoomName { get; set; } = default!;

    [ForeignKey($"{nameof(ClassRoomAddress)}, {nameof(ClassRoomRoomName)}")]
    public required ClassRoom ClassRoom { get; set; }

    public List<ExamAttendance> Attendees { get; init; } = [];
}