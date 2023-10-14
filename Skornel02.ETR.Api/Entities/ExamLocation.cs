using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

using Microsoft.EntityFrameworkCore;

namespace Skornel02.ETR.Api.Entities;

[PrimaryKey(nameof(CourseCode), nameof(CourseSemester), nameof(ExamStart), nameof(Address), nameof(RoomName))]
public class ExamLocation
{
    [StringLength(15)]
    public string CourseCode { get; init; } = default!;
    [StringLength(6)]
    public string CourseSemester { get; init; } = default!;
    public DateTimeOffset ExamStart { get; init; }
    [ForeignKey($"{nameof(CourseCode)}, {nameof(CourseSemester)}, {nameof(ExamStart)}")]
    public required Exam Exam { get; init; }

    public string Address { get; init; } = default!;
    public string RoomName { get; init; } = default!;

    [ForeignKey($"{nameof(Address)}, {nameof(RoomName)}")]
    public required ClassRoom ClassRoom { get; init; }

}