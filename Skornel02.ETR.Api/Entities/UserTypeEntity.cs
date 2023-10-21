using System.ComponentModel.DataAnnotations.Schema;

using Microsoft.EntityFrameworkCore;

using Skornel02.ETR.Common.Enums;

namespace Skornel02.ETR.Api.Entities;

[Table("UserTypeEntities"), PrimaryKey(nameof(UserType), nameof(Username))]
public class UserTypeEntity
{
    public required UserType UserType { get; init; }

    [ForeignKey(nameof(User))]
    public string Username { get; init; } = null!;
    public required User User { get; init; }
}