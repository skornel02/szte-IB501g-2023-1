using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

using Microsoft.EntityFrameworkCore;

namespace Skornel02.ETR.Api.Entities;

[PrimaryKey(nameof(CourseCode), nameof(CourseSemester), nameof(Address), nameof(RoomName), nameof(Start))]
public class CourseLocation
{
    [StringLength(15)]
    public string CourseCode { get; init; } = default!;
    [StringLength(6)]
    public string CourseSemester { get; init; } = default!;
    [ForeignKey($"{nameof(CourseCode)}, {nameof(CourseSemester)}")]
    public required Course Course { get; init; }

    public string Address { get; init; } = default!;
    public string RoomName { get; init; } = default!;

    [ForeignKey($"{nameof(Address)}, {nameof(RoomName)}")]
    public required ClassRoom ClassRoom { get; init; }

    public required DateTimeOffset Start { get; init; }

    public required DateTimeOffset End { get; init; }
}