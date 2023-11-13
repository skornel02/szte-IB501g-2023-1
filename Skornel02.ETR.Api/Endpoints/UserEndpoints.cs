using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

using Skornel02.ETR.Api.Entities;
using Skornel02.ETR.Api.Mappers;
using Skornel02.ETR.Common.Dtos;

namespace Skornel02.ETR.Api.Endpoints;

public static class UserMapping
{

    public static void MapUserEndpoints(this WebApplication app)
    {
        app.MapPost("/api/register", async ([FromBody] UserCreationDto request,
            ETRContext context,
            PasswordHasher<User> passwordHasher,
            ILogger<UserCreationDto> logger,
            CancellationToken token) =>
        {
            await using var transaction = await context.Database.BeginTransactionAsync(token);

            var userAlreadyExists = await context.Users.FromSqlInterpolated($"""
                SELECT * FROM Users 
                    WHERE Username = {request.Username}
                """)
                .FirstOrDefaultAsync(token);

            if (userAlreadyExists is not null)
            {
                return Results.BadRequest("A felhasználónév már foglalt!".ToError());
            }

            var user = request.ToUser();
            user.PasswordHash = passwordHasher.HashPassword(user, request.Password!);


            logger.LogInformation("New user created! {user}", user.Username);

            await context.Users.AddAsync(user, token);

            var userTypes = request.Roles.Select(role => new UserRole
            {
                User = user,
                UserType = role
            });

            await context.UserTypes.AddRangeAsync(userTypes, token);

            await context.SaveChangesAsync(token);
            await transaction.CommitAsync(token);

            return Results.NoContent();
        })
            .WithTags("Users");
    }

}