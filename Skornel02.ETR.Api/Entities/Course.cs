using System.ComponentModel.DataAnnotations;

using Microsoft.EntityFrameworkCore;

namespace Skornel02.ETR.Api.Entities;

[PrimaryKey(nameof(CourseCode), nameof(Semester))]
public class Course
{
    [StringLength(15)]
    public required string CourseCode { get; init; }
    [StringLength(6)]
    public required string Semester { get; init; }

    public required string Name { get; init; }

    public int Credits { get; init; }

    public int Capacity { get; init; }


    public required CourseMetadata CourseMetadata { get; init; }

    public List<CourseLocation> CourseLocations { get; init; } = [];
}