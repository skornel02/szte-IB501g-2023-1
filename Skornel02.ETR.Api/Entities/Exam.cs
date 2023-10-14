using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

using Microsoft.EntityFrameworkCore;

namespace Skornel02.ETR.Api.Entities;

[PrimaryKey(nameof(CourseCode), nameof(CourseSemester), nameof(Start))]
public class Exam
{
    [StringLength(15)]
    public string CourseCode { get; init; } = default!;
    [StringLength(6)]
    public string CourseSemester { get; init; } = default!;
    [ForeignKey($"{nameof(CourseCode)}, {nameof(CourseSemester)}")]
    public required Course Course { get; init; }

    public required DateTimeOffset Start { get; init; }
    public required DateTimeOffset End { get; init; }

    public string ClassRoomAddress { get; init; } = default!;
    public string ClassRoomRoomName { get; init; } = default!;

    [ForeignKey($"{nameof(ClassRoomAddress)}, {nameof(ClassRoomRoomName)}")]
    public required ClassRoom ClassRoom { get; init; }
}