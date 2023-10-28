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

    [Comment("Maximum kapacitás")]
    public int Capacity { get; init; }


    public required CourseMetadata CourseMetadata { get; init; }

    public List<CourseLocation> CourseLocations { get; init; } = [];

    public List<CourseAttendance> Attendees { get; init; } = [];
}