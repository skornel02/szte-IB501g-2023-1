using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

using Skornel02.ETR.Api.Entities;
using Skornel02.ETR.Api.Mappers;
using Skornel02.ETR.Common.Dtos;

namespace Skornel02.ETR.Api.Endpoints;

public static class AuthEndpoints
{
    public static void MapAuthEndpoints(this WebApplication app)
    {
        app.MapPost("/api/auth", async ([FromBody] LoginRequestDto request,
            ETRContext context,
            PasswordHasher<User> hasher,
            ILogger<LoginRequestDto> logger) =>
        {

            var userMatch = await context.Users.FromSqlInterpolated($""" 
                SELECT * FROM Users
                    WHERE Username = {request.Username}
                    LIMIT 1
                """).FirstOrDefaultAsync();
            if (userMatch is null)
            {
                return Results.BadRequest("A felhasználó nem létezik!".ToError());
            }

            if (request.Password is null
                || hasher.VerifyHashedPassword(userMatch, userMatch.PasswordHash, request.Password) == PasswordVerificationResult.Failed)
            {
                return Results.BadRequest("Helytelen jelszó!".ToError());
            }

            var userTypes = await context.UserTypes.FromSqlInterpolated($""" 
                SELECT * FROM UserRoles
                    WHERE Username = {userMatch.Username}
                """).ToListAsync();

            var roles = userTypes.Select(role => role.UserType).ToArray();

            if (!roles.Any(role => role == request.UserType))
            {
                return Results.BadRequest("Ez a fiók ilyen jogkörben nem használható!".ToError());
            }

            var etr = new ETRIdentity(userMatch.Username).ToClaimsPrinciple();

            return Results.SignIn(etr);
        })
            .WithTags("Auth")
            .Produces(204)
            .Produces<ErrorResponseDto>(400);
    }
}