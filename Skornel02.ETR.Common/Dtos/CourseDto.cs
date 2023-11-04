using Skornel02.ETR.Common.Enums;

namespace Skornel02.ETR.Common.Dtos;

public record CourseDto(
    string CourseCode,
    string CourseSemester,
    int Hours,
    int Credits,
    string? CourseName,
    CourseType? CourseType,
    string ClassRoomAddress,
    string ClassRoomNumber,
    string ClassRoomName
);