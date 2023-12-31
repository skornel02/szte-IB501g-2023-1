using System.Security.Claims;

using Microsoft.EntityFrameworkCore;

using Skornel02.ETR.Api.Mappers;
using Skornel02.ETR.Api.Services;
using Skornel02.ETR.Common.Dtos;

namespace Skornel02.ETR.Api.Endpoints;

public static class ProfileMapping
{
    public static void MapProfileEndpoints(this WebApplication app)
    {
        app.MapGet("/api/profile", async (ClaimsPrincipal principal,
            ETRContext context) =>
        {
            var session = principal.ToETR();

            var user = await context.Users.FromSqlInterpolated($"""
                SELECT * FROM Users
                    WHERE Username = {session.Username}
                """).FirstAsync();

            var roles = await context.RolesFromUserAsync(session.Username);

            var degrees = await context.Database.SqlQuery<DegreeDto>($"""
                SELECT DegreeName as 'Name', StartDate, EndDate FROM DegreeParticipations
                    WHERE Username = {session.Username}
                """).ToListAsync();

            var profile = user.ToProfileDto();
            profile.Roles = roles;
            profile.Degrees = degrees;

            return profile;
        })
            .WithTags("Profile")
            .RequireAuthorization();
    }
}