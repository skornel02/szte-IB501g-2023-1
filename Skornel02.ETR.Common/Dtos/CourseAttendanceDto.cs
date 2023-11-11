using Skornel02.ETR.Common.Enums;

namespace Skornel02.ETR.Common.Dtos;

public record CourseAttendanceDto(
    string CourseCode,
    string CourseSemester,
    string Username,
    AttendanceType AttendanceType,
    string? Grade
);