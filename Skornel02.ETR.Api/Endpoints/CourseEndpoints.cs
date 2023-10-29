using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

using Skornel02.ETR.Common.Dtos;

namespace Skornel02.ETR.Api.Endpoints;

public static class CourseEndpointsExtension
{
    public static void MapCourseEndpoints(this WebApplication app)
    {
        app.MapGet("/api/courses/{code:string}", async ([FromRoute] string code, ETRContext context) =>
        {
            var classrooms = await context.Database.SqlQuery<CourseMetadataRequestDto>($"""
                SELECT Name, Type FROM CourseMetadatas
                    WHERE CourseCode = {code}
                    LIMIT 1
                """).ToListAsync();

            return classrooms.FirstOrDefault();
        })
            .WithTags("Courses")
            .RequireAuthorization();
    }
}
