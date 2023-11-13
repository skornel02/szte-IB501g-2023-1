using System.ComponentModel.DataAnnotations.Schema;

using Microsoft.EntityFrameworkCore;

namespace Skornel02.ETR.Api.Entities;

[Table("DegreeParticipations"), PrimaryKey(nameof(Username), nameof(DegreeName))]
public class DegreeParticipation
{
    [ForeignKey(nameof(User))]
    public string Username { get; set; } = default!;
    public User User { get; set; } = default!;

    [ForeignKey(nameof(Degree))]
    public string DegreeName { get; set; } = default!;
    public Degree Degree { get; set; } = default!;

    [Comment("Képzés kezdete")]
    public required DateOnly StartDate { get; set; }
    [Comment("Képzés vége")]
    public DateOnly? EndDate { get; set; }

}