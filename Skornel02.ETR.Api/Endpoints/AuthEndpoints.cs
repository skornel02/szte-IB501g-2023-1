using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

using Skornel02.ETR.Api.Dtos;
using Skornel02.ETR.Api.Entities;
using Skornel02.ETR.Api.Mappers;

namespace Skornel02.ETR.Api.Endpoints;

public static class AuthEndpoints
{
    public static void MapAuthEndpoints(this WebApplication app)
    {
        app.MapPost("/api/check-auth", async ([FromBody] LoginRequestDto request, ETRContext context, PasswordHasher<User> hasher) =>
        {

            var userMatch = (await context.Users.FromSqlInterpolated($""" 
                SELECT * FROM Users
                    WHERE Username = {request.Username}
                    LIMIT 1;
                """).ToListAsync()).FirstOrDefault();
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
                SELECT * FROM UserTypes
                    WHERE Username = {userMatch.Username};
                """).ToListAsync();

            if (!userTypes.Any(role => role.UserType == request.UserType))
            {
                return Results.BadRequest("Ez a fiók ilyen jogkörben nem használható!".ToError());
            }

            return Results.NoContent();
        })
            .WithTags("Auth")
            .Produces(204)
            .Produces<ErrorResponseDto>(400);
    }
}