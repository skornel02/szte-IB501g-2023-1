using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

using Microsoft.EntityFrameworkCore;

namespace Skornel02.ETR.Api.Entities;

[Table("Courses"), PrimaryKey(nameof(CourseCode), nameof(Semester))]
public class Course
{
    [StringLength(15)]
    [Comment("Kurzus kódja")]
    public required string CourseCode { get; init; }
    [StringLength(6)]
    [Comment("Aktuális félév")]
    public required string Semester { get; init; }

    [Comment("Tárgy kreditszáma")]
    public int Credits { get; init; }

    [Comment("Kurzus heti óraszáma")]
    public int Hours { get; init; }

    public string ClassRoomAddress { get; set; } = default!;
    public string ClassRoomRoomName { get; set; } = default!;

    [ForeignKey($"{nameof(ClassRoomAddress)}, {nameof(ClassRoomRoomName)}")]
    public required ClassRoom ClassRoom { get; set; }

    [ForeignKey(nameof(CourseCode))]
    public required CourseMetadata CourseMetadata { get; init; }

    public List<CourseAttendance> Attendees { get; init; } = [];
}