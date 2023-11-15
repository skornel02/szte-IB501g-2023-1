using Skornel02.ETR.Common.Enums;

namespace Skornel02.ETR.Common.Dtos;

public record ExamCreationDto(
    string CourseCode,
    string CourseSemester,
    DateTimeOffset Start,
    DateTimeOffset End,
    ExamType ExamType,
    string ClassRoomAddress,
    string ClassRoomNumber
);