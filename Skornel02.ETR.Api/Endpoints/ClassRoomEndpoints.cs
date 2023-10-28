using System.Security.Claims;

using Microsoft.EntityFrameworkCore;

using Skornel02.ETR.Common.Dtos;

namespace Skornel02.ETR.Api.Endpoints;

public static class ClassRoomEndpointsExtension
{
    public static void MapClassRoomEndpoints(this WebApplication app)
    {
        app.MapGet("/api/classrooms", async (ETRContext context) =>
        {
            var classrooms = await context.Database.SqlQuery<ClassRoomDto>($"""
                SELECT Address, RoomNumber, RoomType FROM ClassRooms
                """).ToListAsync();

            return classrooms;
        })
            .WithTags("ClassRoom")
            .RequireAuthorization();
    }
}