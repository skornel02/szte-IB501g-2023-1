using Skornel02.ETR.Common.Enums;

namespace Skornel02.ETR.Api.Dtos;

public record ProfileDto
{
    public required string Name { get; set; }
    public required string Username { get; set; }
    public List<DegreeDto> Degrees { get; set; } = [];
    public List<RoleType> Roles { get; set; } = [];
}