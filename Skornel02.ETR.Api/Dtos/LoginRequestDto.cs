using System.ComponentModel.DataAnnotations;

using Skornel02.ETR.Common.Enums;

namespace Skornel02.ETR.Api.Dtos;

public record LoginRequestDto(
    string Username,
    string Password,
    UserType UserType
);