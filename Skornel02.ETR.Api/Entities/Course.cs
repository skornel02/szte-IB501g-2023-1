using System.ComponentModel.DataAnnotations;

namespace Skornel02.ETR.Api.Entities;

public class Course {
    [Key]
    public required string CourseCode { get; init; }

    public required string Name { get; init; }

    public int Credits { get; init; }

    public required ClassRoom ClassRoom { get; init; }
}