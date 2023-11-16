using Skornel02.ETR.Common.Enums;

namespace Skornel02.ETR.Common.Dtos;

public record ExamUpdateDto(
    string CourseCode,
    string CourseSemester,
    DateTimeOffset OriginalStart,
    DateTimeOffset End,
    ExamType ExamType,
    string ClassRoomAddress,
    string ClassRoomNumber
);