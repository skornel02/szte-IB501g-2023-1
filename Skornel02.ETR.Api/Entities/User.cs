using System.ComponentModel.DataAnnotations;

namespace Skornel02.ETR.Api.Entities;

public class User
{
    [Key]
    public required string Username { get; init; }
    public required string Name { get; set; }

    public string PasswordHash { get; set; } = default!;

    public List<UserTypeEntity> Roles { get; init; } = [];

    public required DateOnly BirthDate { get; set; }

    public required string BirthLocation { get; set; }

    public List<DegreeParticipation> DegreeParticipations { get; set; } = [];

    public List<CourseAttendance> CourseAttendances { get; set; } = [];

    public List<ExamAttendance> ExamAttendances { get; set; } = [];
}