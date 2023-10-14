using System.ComponentModel.DataAnnotations.Schema;

using Microsoft.EntityFrameworkCore;

namespace Skornel02.ETR.Api.Entities;

[PrimaryKey(nameof(Username), nameof(DegreeName))]
public class DegreeParticipation
{
    [ForeignKey(nameof(User))]
    public string Username { get; init; } = default!;
    public required User User { get; init; }

    [ForeignKey(nameof(DegreeType))]
    public string DegreeName { get; init; } = default!;
    public required DegreeType DegreeType { get; init; }

    public required DateOnly StartDate { get; init; }
    public DateOnly? EndDate { get; init; }

}