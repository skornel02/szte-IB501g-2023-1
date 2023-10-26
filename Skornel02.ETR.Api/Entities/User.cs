using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

using Microsoft.AspNetCore.Components;

namespace Skornel02.ETR.Api.Entities;

[Table("Users")]
public class User
{
    [Key]
    [MaxLength(32)]
    public required string Username { get; init; }
    [MaxLength(100)]
    public required string Name { get; set; }

    public string PasswordHash { get; set; } = default!;

    public List<UserRole> Roles { get; set; } = [];

    public required DateOnly BirthDate { get; set; }

    [MaxLength(100)]
    public required string BirthLocation { get; set; }

    public List<DegreeParticipation> DegreeParticipations { get; set; } = [];

    public List<CourseAttendance> CourseAttendances { get; set; } = [];

    public List<ExamAttendance> ExamAttendances { get; set; } = [];
}