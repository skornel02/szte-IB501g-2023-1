using Skornel02.ETR.Common.Enums;

namespace Skornel02.ETR.Common.Dtos;

public record ExamAttendanceDto(
    string CourseCode,
    string CourseSemester,
    DateTimeOffset Start,
    string Username,
    AttendanceType AttendanceType,
    string? Grade
);