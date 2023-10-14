using Skornel02.ETR.Common.Enums;

namespace Skornel02.ETR.Api.Entities;

public class ExamAttendance
{
    public required User User { get; init; }
    public required Exam Exam { get; init; }
    public required AttendanceType AttendanceType { get; init; }
}