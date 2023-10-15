using System.ComponentModel.DataAnnotations;

using Skornel02.ETR.Common.Enums;

namespace Skornel02.ETR.Api.Dtos;

public record UserCreationDto(
    [Required] string? Username,
    [Required] string? Name,
    [Required] string? Password,
    [Required] List<UserType> Roles,
    [Required] DateTime? BirthDate,
    [Required] string? BirthLocation
);