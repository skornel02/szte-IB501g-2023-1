using Bogus;

using Microsoft.EntityFrameworkCore;

using Skornel02.ETR.Api.Entities;
using Skornel02.ETR.Common.Enums;

namespace Skornel02.ETR.Api;

public class ETRContext(DbContextOptions<ETRContext> options) : DbContext(options)
{
    public DbSet<User> Users { get; set; } = default!;

    public DbSet<UserRole> UserTypes { get; set; } = default!;

    public DbSet<Degree> Degrees { get; set; } = default!;
    public DbSet<DegreeParticipation> DegreeParticipations { get; set; } = default!;

    public DbSet<Course> Courses { get; set; } = default!;
    public DbSet<CourseAttendance> CourseAttendances { get; set; } = default!;

    public DbSet<Exam> Exams { get; set; } = default!;
    public DbSet<ExamAttendance> ExamAttendances { get; set; } = default!;

    public DbSet<ClassRoom> ClassRooms { get; set; } = default!;

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(ETRContext).Assembly);

        var random = new Random(8675309);
        Randomizer.Seed = random;
        var now = new DateTime(2023, 10, 26);

        #region Szakok
        var infoSzak = new Degree()
        {
            Name = "Programtervező informatikus Bsc",
            Level = DegreeLevel.Bsc,
        };
        var mernokinfoSzak = new Degree()
        {
            Name = "Mérnökinformatikus Bsc",
            Level = DegreeLevel.Bsc,
        };

        modelBuilder.Entity<Degree>().HasData(infoSzak);
        modelBuilder.Entity<Degree>().HasData(mernokinfoSzak);
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
        var tanuloHash = "AQAAAAIAAYagAAAAEPy0Sa3t+0fqE5iMzp1a5B7FRWSO31WJ37yCzKu2fXCjldLH0utein9gF7o23hnu5g==";
        tanulo.PasswordHash = tanuloHash;
        modelBuilder.Entity<User>().HasData(tanulo);

        var tanuloRole = new UserRole()
        {
            Username = tanulo.Username,
            User = null!,
            UserType = RoleType.Student
        };
        modelBuilder.Entity<UserRole>().HasData(tanuloRole);

        var tanuloSzak = new DegreeParticipation()
        {
            Degree = null!,
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
        var oktatoHash = "AQAAAAIAAYagAAAAEGwWzLcK2LgEqebi3IQz3KDZalg30QuzeHZhqgav06HdMDPOVOm5CJ8u4IsOPjCFqw==";
        oktato.PasswordHash = oktatoHash;
        modelBuilder.Entity<User>().HasData(oktato);

        var oktatoRole = new UserRole()
        {
            Username = oktato.Username,
            User = null!,
            UserType = RoleType.Teacher
        };
        modelBuilder.Entity<UserRole>().HasData(oktatoRole);

        var oktatoSzak = new DegreeParticipation()
        {
            Degree = null!,
            DegreeName = infoSzak.Name,
            User = null!,
            Username = oktato.Username,
            StartDate = new DateOnly(1995, 9, 1),
            EndDate = new DateOnly(2000, 6, 1)
        };
        modelBuilder.Entity<DegreeParticipation>().HasData(oktatoSzak);
        #endregion

        #region Random degrees
        var randomDegrees = new Faker<Degree>()
            .RuleFor(d => d.Name, f => $"{f.Commerce.Department(3)} ({f.UniqueIndex})")
            .RuleFor(d => d.Level, f => f.PickRandom<DegreeLevel>())
            .Generate(50);

        modelBuilder.Entity<Degree>().HasData(randomDegrees);
        #endregion

        #region Random classrooms 
        var randomClassRooms = new Faker<ClassRoom>()
            .RuleFor(c => c.Address, f => f.Address.FullAddress())
            .RuleFor(c => c.RoomNumber, f => f.Random.Int(14, 350).ToString())
            .RuleFor(c => c.Name, f => f.Commerce.ProductName())
            .RuleFor(c => c.RoomType, f => f.PickRandom<RoomType>())
            .RuleFor(c => c.Capacity, f => f.Random.Int(20, 700))
            .Generate(100);

        modelBuilder.Entity<ClassRoom>().HasData(randomClassRooms);
        #endregion

        #region Random users
        var randomUsers = new List<User>();

        for (int i = 0; i < 100; i++)
        {
            var user = new Faker<User>()
                .RuleFor(u => u.Username, f => f.Internet.UserName())
                .RuleFor(u => u.Name, f => f.Name.FullName())
                .RuleFor(u => u.BirthDate, f => DateOnly.FromDateTime(f.Date.Past(45, now.AddYears(-18))))
                .RuleFor(u => u.BirthLocation, f => f.Address.City())
                .Generate();

            randomUsers.Add(user);

            user.PasswordHash = tanuloHash;

            modelBuilder.Entity<User>().HasData(user);

            var roleToAdd = random.Next(1, 3);
            var roles = new List<UserRole>();
            if (roleToAdd == 1)
            {
                roles.Add(new UserRole()
                {
                    Username = user.Username,
                    User = null!,
                    UserType = random.Next(2) == 0 ? RoleType.Student : RoleType.Teacher,
                });
            }
            else
            {
                roles.Add(new UserRole()
                {
                    Username = user.Username,
                    User = null!,
                    UserType = RoleType.Student,
                });
                roles.Add(new UserRole()
                {
                    Username = user.Username,
                    User = null!,
                    UserType = RoleType.Teacher,
                });
            }

            modelBuilder.Entity<UserRole>().HasData(roles);

            var chosenDegree = randomDegrees[random.Next(0, randomDegrees.Count)];
            var degreeParticipation = new DegreeParticipation()
            {
                DegreeName = chosenDegree.Name,
                Degree = null!,
                StartDate = user.BirthDate.AddYears(18),
                EndDate = user.BirthDate.AddYears(21),
                Username = user.Username,
                User = null!
            };

            modelBuilder.Entity<DegreeParticipation>().HasData(degreeParticipation);
        }

        var randomStundents = randomUsers
            .Where(user => user.Roles.Any(r => r.UserType == RoleType.Student))
            .ToList();

        var randomTeachers = randomUsers
            .Where(user => user.Roles.Any(r => r.UserType == RoleType.Teacher))
            .ToList();
        #endregion
    }
}