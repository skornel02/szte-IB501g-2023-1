namespace Skornel02.ETR.Common.Dtos;

public record UserStatisticsDto(
    string Username,
    string Name,
    DateOnly BirthDate,
    string BirthLocation
);