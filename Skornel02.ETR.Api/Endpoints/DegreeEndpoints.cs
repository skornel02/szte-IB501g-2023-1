using Microsoft.EntityFrameworkCore;

using Skornel02.ETR.Common.Dtos;

namespace Skornel02.ETR.Api.Endpoints;

public static class DegreeEndpoints
{
    public static void MapDegreeEndpoints(this WebApplication app)
    {
        app.MapGet("/api/degrees", async (ETRContext context) =>
        {
            List<DegreeTypeDto> degrees = await context.Database.SqlQuery<DegreeTypeDto>(
                $"SELECT Name, Level FROM Degree")
                .ToListAsync();

            return Results.Ok(degrees);
        })
            .WithTags("Degrees")
            .Produces(200);
    }
}