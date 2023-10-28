namespace Skornel02.ETR.Common.Dtos;

public record UserCoursesStatisticsDto(
    string Username,
    string Name,
    int CourseCount
);