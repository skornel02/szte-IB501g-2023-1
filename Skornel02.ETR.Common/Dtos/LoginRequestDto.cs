using System.ComponentModel.DataAnnotations;

using Skornel02.ETR.Common.Enums;

namespace Skornel02.ETR.Common.Dtos;

public record LoginRequestDto(
    string Username,
    string Password,
    RoleType UserType
);