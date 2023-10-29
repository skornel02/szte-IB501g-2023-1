using Skornel02.ETR.Common.Enums;

namespace Skornel02.ETR.Common.Dtos;

public record CourseCreationDto(
    string CourseCode,
    string CourseSemester,
    int Hours,
    int Credits,
    string? CourseName,
    CourseType? CourseType,
    string ClassRoomAddress,
    string ClassRoomNumber
);
