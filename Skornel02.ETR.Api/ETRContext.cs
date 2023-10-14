using Microsoft.EntityFrameworkCore;

using Skornel02.ETR.Api.Entities;

namespace Skornel02.ETR.Api;

public class ETRContext(DbContextOptions<ETRContext> options) : DbContext(options)
{
    public DbSet<User> Users { get; set; } = default!;

    public DbSet<UserTypeEntity> UserTypes = default!;

    public DbSet<DegreeType> DegreeTypes { get; set; } = default!;
    public DbSet<DegreeParticipation> DegreeParticipations { get; set; } = default!;

    public DbSet<Course> Courses { get; set; } = default!;
    public DbSet<CourseAttendance> CourseAttendances { get; set; } = default!;

    public DbSet<Exam> Exams { get; set; } = default!;
    public DbSet<ExamAttendance> ExamAttendances { get; set; } = default!;

    public DbSet<ClassRoom> ClassRooms { get; set; } = default!;

    public DbSet<CourseLocation> CourseLocations { get; set; } = default!;

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(ETRContext).Assembly);
    }
}