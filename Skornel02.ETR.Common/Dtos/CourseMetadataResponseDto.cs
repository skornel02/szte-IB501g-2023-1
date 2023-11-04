using Skornel02.ETR.Common.Enums;

namespace Skornel02.ETR.Common.Dtos;

public record CourseMetadataResponseDto(
    string Name,
    CourseType Type
);