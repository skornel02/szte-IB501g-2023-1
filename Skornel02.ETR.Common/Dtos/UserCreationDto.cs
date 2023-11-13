using Skornel02.ETR.Common.Enums;

namespace Skornel02.ETR.Common.Dtos;

public record UserCreationDto(
    string Username,
    string Name,
    string Password,
    List<RoleType> Roles,
    DateTime BirthDate,
    string BirthLocation,
    List<string> Degrees
);