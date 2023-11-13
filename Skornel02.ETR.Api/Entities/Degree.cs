using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

using Microsoft.EntityFrameworkCore;

using Skornel02.ETR.Common.Enums;

namespace Skornel02.ETR.Api.Entities;

[Table("Degree")]
public class Degree
{
    [Key]
    [Comment("Képzés neve")]
    public required string Name { get; init; }

    [Comment("Képzés szintje")]
    public required DegreeLevel Level { get; init; }

    public List<DegreeParticipation> DegreeParticipations { get; set; } = [];
}