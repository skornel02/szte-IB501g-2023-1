using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

using Skornel02.ETR.Api.Entities;
using Skornel02.ETR.Common.Enums;

namespace Skornel02.ETR.Api;

public class ETRContext(DbContextOptions<ETRContext> options) : DbContext(options)
{
    public DbSet<User> Users { get; set; } = default!;

    public DbSet<UserTypeEntity> UserTypes { get; set; } = default!;

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

        #region Szakok
        var infoSzak = new DegreeType()
        {
            Name = "Informatikus szak"
        };
        modelBuilder.Entity<DegreeType>().HasData(infoSzak);
        #endregion

        #region Tanuló 1
        var tanulo = new User()
        {
            Username = "tanulo",
            PasswordHash = "",
            Name = "Teszt Elek",
            BirthDate = new DateOnly(2000, 1, 2),
            BirthLocation = "Szeged"
        };
        tanulo.PasswordHash = new PasswordHasher<User>().HashPassword(tanulo, "tanulo");
        modelBuilder.Entity<User>().HasData(tanulo);

        var tanuloRole = new UserTypeEntity()
        {
            Username = tanulo.Username,
            User = null!,
            UserType = UserType.Student
        };
        modelBuilder.Entity<UserTypeEntity>().HasData(tanuloRole);

        var tanuloSzak = new DegreeParticipation()
        {
            DegreeType = null!,
            DegreeName = infoSzak.Name,
            User = null!,
            Username = tanulo.Username,
            StartDate = new DateOnly(2018, 9, 1),
        };
        modelBuilder.Entity<DegreeParticipation>().HasData(tanuloSzak);

        #endregion

        #region Oktató 1
        var oktato = new User()
        {
            Username = "oktato",
            PasswordHash = "",
            Name = "Doktor Doktor",
            BirthDate = new DateOnly(1980, 1, 2),
            BirthLocation = "Szeged"
        };
        oktato.PasswordHash = new PasswordHasher<User>().HashPassword(oktato, "oktato");
        modelBuilder.Entity<User>().HasData(oktato);

        var oktatoRole = new UserTypeEntity()
        {
            Username = oktato.Username,
            User = null!,
            UserType = UserType.Teacher
        };
        modelBuilder.Entity<UserTypeEntity>().HasData(oktatoRole);

        var oktatoSzak = new DegreeParticipation()
        {
            DegreeType = null!,
            DegreeName = infoSzak.Name,
            User = null!,
            Username = oktato.Username,
            StartDate = new DateOnly(1995, 9, 1),
            EndDate = new DateOnly(2000, 6, 1)
        };
        modelBuilder.Entity<DegreeParticipation>().HasData(oktatoSzak);
        #endregion
    }


}