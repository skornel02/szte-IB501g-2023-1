using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

using Microsoft.AspNetCore.Components;
using Microsoft.EntityFrameworkCore;

namespace Skornel02.ETR.Api.Entities;

[Table("Users")]
public class User
{
    [Key]
    [MaxLength(32)]
    [Comment("Felhasználónév")]
    public required string Username { get; init; }
    [MaxLength(100)]
    [Comment("Rendes név")]
    public required string Name { get; set; }

    [Comment("Titkosított jelszó")]
    public string PasswordHash { get; set; } = default!;

    public List<UserRole> Roles { get; set; } = [];

    [Comment("Születési dátum")]
    public required DateOnly BirthDate { get; set; }

    [MaxLength(100)]
    [Comment("Születési hely")]
    public required string BirthLocation { get; set; }

    public List<DegreeParticipation> DegreeParticipations { get; set; } = [];

    public List<CourseAttendance> CourseAttendances { get; set; } = [];

    public List<ExamAttendance> ExamAttendances { get; set; } = [];
}