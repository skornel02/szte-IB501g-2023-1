using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

using Skornel02.ETR.Common.Enums;

namespace Skornel02.ETR.Api.Entities;

[Table("Degree")]
public class Degree
{
    [Key]
    [Description("Képzés neve")]
    public required string Name { get; init; }

    [Description("Képzés szintje")]
    public required DegreeLevel Level { get; init; }

    public List<DegreeParticipation> DegreeParticipations { get; set; } = [];
}