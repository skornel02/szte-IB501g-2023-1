using Microsoft.EntityFrameworkCore;

namespace Skornel02.ETR.Api.Entities;

[PrimaryKey(nameof(Course), nameof(Date))]
public class Exam {
    public required Course Owner { get; init; }
    public required DateOnly Date { get; init; }
    public required ClassRoom ClassRoom { get; init; }
}