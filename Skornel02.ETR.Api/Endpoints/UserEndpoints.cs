using Microsoft.AspNetCore.Mvc;

using Skornel02.ETR.Api.Dtos;
using Skornel02.ETR.Api.Entities;
using Skornel02.ETR.Common.Enums;

namespace Skornel02.ETR.Api.Endpoints;

public static class UserMapping
{

    public static void MapUserEndpoints(this WebApplication app)
    {
        app.MapPost("/api/register", ([FromBody] UserCreationDto request, ETRContext context) =>
        {
            return Results.NoContent();
        })
            .WithTags("Users");
    }

}