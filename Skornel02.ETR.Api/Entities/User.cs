using System.ComponentModel.DataAnnotations;

namespace Skornel02.ETR.Api.Entities;

public class User
{
    [Key]
    public required string Username { get; init; }

    public required string EmailAddress { get; init; }

    public required string PasswordHash { get; init; }
    
    public required List<UserTypeEntity> Roles { get; init; }

    public required DateOnly BirthDate { get; init; }

    public required string BirthLocation { get; init; }

    public List<DegreeParticipation> DegreeParticipations { get; set; } = [];
}