using Microsoft.EntityFrameworkCore;

using Skornel02.ETR.Common.Enums;

namespace Skornel02.ETR.Api.Entities;

[PrimaryKey(nameof(Address), nameof(RoomNumber))]
public class ClassRoom
{
    public required string Address { get; init; }
    public required string RoomNumber { get; init; }
    public required RoomType RoomType { get; set; }

    public List<CourseLocation> Courses { get; set; } = [];

    public List<Exam> Exams { get; set; } = [];
}