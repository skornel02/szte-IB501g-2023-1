using Microsoft.EntityFrameworkCore;

using Skornel02.ETR.Common.Enums;

namespace Skornel02.ETR.Api.Entities;

[PrimaryKey(nameof(Address), nameof(Floor), nameof(RoomNumber))]
public class ClassRoom {
    public required string Address { get; init; }
    public required string Floor { get; init; }
    public required string RoomNumber { get; init; }
    public required RoomType RoomType { get; init; }

    public List<Course> Courses { get; set; } = [];

    public List<Exam> Exams { get; set; } = [];
}