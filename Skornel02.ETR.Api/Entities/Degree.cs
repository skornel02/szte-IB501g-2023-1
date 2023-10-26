using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

using Skornel02.ETR.Common.Enums;

namespace Skornel02.ETR.Api.Entities;

[Table("Degree")]
public class Degree
{
    [Key]
    public required string Name { get; init; }

    public required DegreeLevel Level { get; init; }

    public List<DegreeParticipation> DegreeParticipations { get; set; } = [];
}