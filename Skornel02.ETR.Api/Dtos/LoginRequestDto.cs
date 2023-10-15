using System.ComponentModel.DataAnnotations;

using Skornel02.ETR.Common.Enums;

namespace Skornel02.ETR.Api.Dtos;

public record LoginRequestDto(
    [Required] string? Username,
    [Required] string? Password,
    [Required] UserType UserType
);