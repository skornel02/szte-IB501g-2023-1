using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

using Microsoft.EntityFrameworkCore;

using Skornel02.ETR.Common.Enums;

namespace Skornel02.ETR.Api.Entities;

[Table("ClassRooms"), PrimaryKey(nameof(Address), nameof(RoomNumber))]
public class ClassRoom
{
    [MaxLength(100)]
    public required string Address { get; init; }
    [MaxLength(10)]
    public required string RoomNumber { get; init; }
    public required RoomType RoomType { get; set; }

    public List<CourseLocation> Courses { get; set; } = [];

    public List<Exam> Exams { get; set; } = [];
}