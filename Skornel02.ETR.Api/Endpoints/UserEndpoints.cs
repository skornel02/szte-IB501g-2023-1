using Skornel02.ETR.Api.Entities;
using Skornel02.ETR.Common.Enums;

namespace Skornel02.ETR.Api.Endpoints;

public static class UserMapping
{

    public static void MapUserEndpoints(this WebApplication app)
    {
        app.MapGet("/users", (ETRContext context) => context.Users)
            .WithName("GetUsers")
            .WithOpenApi();
    }

}