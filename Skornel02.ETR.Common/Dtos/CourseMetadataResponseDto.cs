using Skornel02.ETR.Common.Enums;

namespace Skornel02.ETR.Common.Dtos;

public record CourseMetadataRequestDto(
    string Name,
    CourseType Type
);