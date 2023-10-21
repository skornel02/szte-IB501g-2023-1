using Skornel02.ETR.Common.Enums;

namespace Skornel02.ETR.Api.Dtos;

public record UserCreationDto(
    string Username,
    string Name,
    string Password,
    List<UserType> Roles,
    DateTime BirthDate,
    string BirthLocation
);