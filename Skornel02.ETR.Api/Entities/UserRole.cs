using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;

using Microsoft.EntityFrameworkCore;

using Skornel02.ETR.Common.Enums;

namespace Skornel02.ETR.Api.Entities;

[Table("UserRoles"), PrimaryKey(nameof(UserType), nameof(Username))]
public class UserRole
{
    [Description("Felhasználó típusa")]
    public required RoleType UserType { get; init; }

    [ForeignKey(nameof(User))]
    public string Username { get; set; } = null!;
    public required User User { get; set; }
}