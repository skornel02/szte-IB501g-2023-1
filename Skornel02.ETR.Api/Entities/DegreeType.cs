using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Skornel02.ETR.Api.Entities;

[Table("DegreeTypes")]
public class DegreeType
{
    [Key]
    public required string Name { get; init; }

    public List<DegreeParticipation> DegreeParticipations { get; set; } = [];
}