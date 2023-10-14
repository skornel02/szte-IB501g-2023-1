using Skornel02.ETR.Common.Enums;

namespace Skornel02.ETR.Api.Entities;

public class CourseAttendance
{
    public required User User { get; init; }
    public required Course Course { get; init; }
    public required AttendanceType AttendanceType { get; init; }
}