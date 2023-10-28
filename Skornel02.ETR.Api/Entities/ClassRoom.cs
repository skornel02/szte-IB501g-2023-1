using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

using Microsoft.EntityFrameworkCore;

using Skornel02.ETR.Common.Enums;

namespace Skornel02.ETR.Api.Entities;

[Table("ClassRooms"), PrimaryKey(nameof(Address), nameof(RoomNumber))]
public class ClassRoom
{
    [MaxLength(100)]
    [Description("Cím")]
    public required string Address { get; init; }
    [MaxLength(10)]
    [Description("Terem száma")]
    public required string RoomNumber { get; init; }
    [Description("Terem típusa")]
    public required RoomType RoomType { get; set; }
    [Description("Terem neve")]
    public required string Name { get; set; }
    [Description("Terem férőhely")]
    public required int Capacity { get; set; }

    public List<Course> Courses { get; set; } = [];

    public List<Exam> Exams { get; set; } = [];
}