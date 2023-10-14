using System.ComponentModel.DataAnnotations;

namespace Skornel02.ETR.Api.Entities;

public class DegreeType
{
    [Key]
    public required string Name { get; init; }

    public List<DegreeParticipation> DegreeParticipations { get; set; } = [];
}