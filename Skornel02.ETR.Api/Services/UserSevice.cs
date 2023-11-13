using Microsoft.EntityFrameworkCore;

using Skornel02.ETR.Common.Enums;

namespace Skornel02.ETR.Api.Services;

public static class UserService
{
    public static Task<List<RoleType>> RolesFromUserAsync(this ETRContext context, string username)
    {
        return context.Database.SqlQuery<RoleType>($"""
                SELECT UserType FROM UserRoles
                    WHERE Username = {username}
            """).ToListAsync();
    }
}