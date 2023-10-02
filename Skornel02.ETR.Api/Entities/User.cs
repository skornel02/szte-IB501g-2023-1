using System.ComponentModel.DataAnnotations;

using Microsoft.EntityFrameworkCore;

using Skornel02.ETR.Common.Enums;

namespace Skornel02.ETR.Api.Entities;

[PrimaryKey(nameof(Username), nameof(UserType))]
public class User
{
    public required string Username { get; init; }
    public required UserType UserType { get; init; }

    public required string EmailAddress { get; init; }

    public required string PasswordHash { get; init; }

    public required DateOnly BirthDate { get; init; }

    public required string BirthLocation { get; init; }
}