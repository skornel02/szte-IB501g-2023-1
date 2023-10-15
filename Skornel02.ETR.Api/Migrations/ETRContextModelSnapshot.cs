﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Skornel02.ETR.Api;

#nullable disable

namespace Skornel02.ETR.Api.Migrations
{
    [DbContext(typeof(ETRContext))]
    partial class ETRContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.0-rc.2.23480.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("Skornel02.ETR.Api.Entities.ClassRoom", b =>
                {
                    b.Property<string>("Address")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("RoomNumber")
                        .HasColumnType("varchar(255)");

                    b.Property<int>("RoomType")
                        .HasColumnType("int");

                    b.HasKey("Address", "RoomNumber");

                    b.ToTable("ClassRooms");
                });

            modelBuilder.Entity("Skornel02.ETR.Api.Entities.Course", b =>
                {
                    b.Property<string>("CourseCode")
                        .HasMaxLength(15)
                        .HasColumnType("varchar(15)");

                    b.Property<string>("Semester")
                        .HasMaxLength(6)
                        .HasColumnType("varchar(6)");

                    b.Property<int>("Capacity")
                        .HasColumnType("int");

                    b.Property<int>("Credits")
                        .HasColumnType("int");

                    b.HasKey("CourseCode", "Semester");

                    b.ToTable("Courses");
                });

            modelBuilder.Entity("Skornel02.ETR.Api.Entities.CourseAttendance", b =>
                {
                    b.Property<string>("Username")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("CourseCode")
                        .HasMaxLength(15)
                        .HasColumnType("varchar(15)");

                    b.Property<string>("CourseSemester")
                        .HasMaxLength(6)
                        .HasColumnType("varchar(6)");

                    b.Property<int>("AttendanceType")
                        .HasColumnType("int");

                    b.Property<string>("Grade")
                        .HasColumnType("longtext");

                    b.HasKey("Username", "CourseCode", "CourseSemester");

                    b.HasIndex("CourseCode", "CourseSemester");

                    b.ToTable("CourseAttendances");
                });

            modelBuilder.Entity("Skornel02.ETR.Api.Entities.CourseLocation", b =>
                {
                    b.Property<string>("CourseCode")
                        .HasMaxLength(15)
                        .HasColumnType("varchar(15)");

                    b.Property<string>("CourseSemester")
                        .HasMaxLength(6)
                        .HasColumnType("varchar(6)");

                    b.Property<string>("Address")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("RoomName")
                        .HasColumnType("varchar(255)");

                    b.Property<DateTimeOffset>("Start")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTimeOffset>("End")
                        .HasColumnType("datetime(6)");

                    b.HasKey("CourseCode", "CourseSemester", "Address", "RoomName", "Start");

                    b.HasIndex("Address", "RoomName");

                    b.ToTable("CourseLocations");
                });

            modelBuilder.Entity("Skornel02.ETR.Api.Entities.CourseMetadata", b =>
                {
                    b.Property<string>("CourseCode")
                        .HasMaxLength(15)
                        .HasColumnType("varchar(15)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("Type")
                        .HasColumnType("int");

                    b.HasKey("CourseCode");

                    b.ToTable("CourseMetadata");
                });

            modelBuilder.Entity("Skornel02.ETR.Api.Entities.DegreeParticipation", b =>
                {
                    b.Property<string>("Username")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("DegreeName")
                        .HasColumnType("varchar(255)");

                    b.Property<DateOnly?>("EndDate")
                        .HasColumnType("date");

                    b.Property<DateOnly>("StartDate")
                        .HasColumnType("date");

                    b.HasKey("Username", "DegreeName");

                    b.HasIndex("DegreeName");

                    b.ToTable("DegreeParticipations");

                    b.HasData(
                        new
                        {
                            Username = "tanulo",
                            DegreeName = "Informatikus szak",
                            StartDate = new DateOnly(2018, 9, 1)
                        },
                        new
                        {
                            Username = "oktato",
                            DegreeName = "Informatikus szak",
                            EndDate = new DateOnly(2000, 6, 1),
                            StartDate = new DateOnly(1995, 9, 1)
                        });
                });

            modelBuilder.Entity("Skornel02.ETR.Api.Entities.DegreeType", b =>
                {
                    b.Property<string>("Name")
                        .HasColumnType("varchar(255)");

                    b.HasKey("Name");

                    b.ToTable("DegreeTypes");

                    b.HasData(
                        new
                        {
                            Name = "Informatikus szak"
                        });
                });

            modelBuilder.Entity("Skornel02.ETR.Api.Entities.Exam", b =>
                {
                    b.Property<string>("CourseCode")
                        .HasMaxLength(15)
                        .HasColumnType("varchar(15)");

                    b.Property<string>("CourseSemester")
                        .HasMaxLength(6)
                        .HasColumnType("varchar(6)");

                    b.Property<DateTimeOffset>("Start")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("ClassRoomAddress")
                        .IsRequired()
                        .HasColumnType("varchar(255)");

                    b.Property<string>("ClassRoomRoomName")
                        .IsRequired()
                        .HasColumnType("varchar(255)");

                    b.Property<DateTimeOffset>("End")
                        .HasColumnType("datetime(6)");

                    b.HasKey("CourseCode", "CourseSemester", "Start");

                    b.HasIndex("ClassRoomAddress", "ClassRoomRoomName");

                    b.ToTable("Exams");
                });

            modelBuilder.Entity("Skornel02.ETR.Api.Entities.ExamAttendance", b =>
                {
                    b.Property<string>("Username")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("CourseCode")
                        .HasMaxLength(15)
                        .HasColumnType("varchar(15)");

                    b.Property<string>("CourseSemester")
                        .HasMaxLength(6)
                        .HasColumnType("varchar(6)");

                    b.Property<DateTimeOffset>("CourseStart")
                        .HasColumnType("datetime(6)");

                    b.Property<int>("AttendanceType")
                        .HasColumnType("int");

                    b.Property<string>("Grade")
                        .HasColumnType("longtext");

                    b.HasKey("Username", "CourseCode", "CourseSemester", "CourseStart");

                    b.HasIndex("CourseCode", "CourseSemester", "CourseStart");

                    b.ToTable("ExamAttendances");
                });

            modelBuilder.Entity("Skornel02.ETR.Api.Entities.User", b =>
                {
                    b.Property<string>("Username")
                        .HasColumnType("varchar(255)");

                    b.Property<DateOnly>("BirthDate")
                        .HasColumnType("date");

                    b.Property<string>("BirthLocation")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("PasswordHash")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Username");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Username = "tanulo",
                            BirthDate = new DateOnly(2000, 1, 2),
                            BirthLocation = "Szeged",
                            Name = "Teszt Elek",
                            PasswordHash = "AQAAAAIAAYagAAAAEHZI+KAYgFgraEbJnn8uqIhYLnR/uG9EM/rROV9vHKtJkS9EAMpR+DoBBnluq0JYcQ=="
                        },
                        new
                        {
                            Username = "oktato",
                            BirthDate = new DateOnly(1980, 1, 2),
                            BirthLocation = "Szeged",
                            Name = "Doktor Doktor",
                            PasswordHash = "AQAAAAIAAYagAAAAEJQRnlk6FND0fXxkXtdWmlXFrcNKpfVYxIbAqTll82qqYAEnoRO7MehZbFwuxqCmjQ=="
                        });
                });

            modelBuilder.Entity("Skornel02.ETR.Api.Entities.UserTypeEntity", b =>
                {
                    b.Property<int>("UserType")
                        .HasColumnType("int");

                    b.Property<string>("Username")
                        .HasColumnType("varchar(255)");

                    b.HasKey("UserType", "Username");

                    b.HasIndex("Username");

                    b.ToTable("UserTypes");

                    b.HasData(
                        new
                        {
                            UserType = 0,
                            Username = "tanulo"
                        },
                        new
                        {
                            UserType = 1,
                            Username = "oktato"
                        });
                });

            modelBuilder.Entity("Skornel02.ETR.Api.Entities.Course", b =>
                {
                    b.HasOne("Skornel02.ETR.Api.Entities.CourseMetadata", "CourseMetadata")
                        .WithMany("Courses")
                        .HasForeignKey("CourseCode")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("CourseMetadata");
                });

            modelBuilder.Entity("Skornel02.ETR.Api.Entities.CourseAttendance", b =>
                {
                    b.HasOne("Skornel02.ETR.Api.Entities.User", "User")
                        .WithMany("CourseAttendances")
                        .HasForeignKey("Username")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Skornel02.ETR.Api.Entities.Course", "Course")
                        .WithMany("Attendees")
                        .HasForeignKey("CourseCode", "CourseSemester")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Course");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Skornel02.ETR.Api.Entities.CourseLocation", b =>
                {
                    b.HasOne("Skornel02.ETR.Api.Entities.ClassRoom", "ClassRoom")
                        .WithMany("Courses")
                        .HasForeignKey("Address", "RoomName")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Skornel02.ETR.Api.Entities.Course", "Course")
                        .WithMany("CourseLocations")
                        .HasForeignKey("CourseCode", "CourseSemester")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ClassRoom");

                    b.Navigation("Course");
                });

            modelBuilder.Entity("Skornel02.ETR.Api.Entities.DegreeParticipation", b =>
                {
                    b.HasOne("Skornel02.ETR.Api.Entities.DegreeType", "DegreeType")
                        .WithMany("DegreeParticipations")
                        .HasForeignKey("DegreeName")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Skornel02.ETR.Api.Entities.User", "User")
                        .WithMany("DegreeParticipations")
                        .HasForeignKey("Username")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("DegreeType");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Skornel02.ETR.Api.Entities.Exam", b =>
                {
                    b.HasOne("Skornel02.ETR.Api.Entities.ClassRoom", "ClassRoom")
                        .WithMany("Exams")
                        .HasForeignKey("ClassRoomAddress", "ClassRoomRoomName")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Skornel02.ETR.Api.Entities.Course", "Course")
                        .WithMany()
                        .HasForeignKey("CourseCode", "CourseSemester")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ClassRoom");

                    b.Navigation("Course");
                });

            modelBuilder.Entity("Skornel02.ETR.Api.Entities.ExamAttendance", b =>
                {
                    b.HasOne("Skornel02.ETR.Api.Entities.User", "User")
                        .WithMany("ExamAttendances")
                        .HasForeignKey("Username")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Skornel02.ETR.Api.Entities.Exam", "Exam")
                        .WithMany("Attendees")
                        .HasForeignKey("CourseCode", "CourseSemester", "CourseStart")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Exam");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Skornel02.ETR.Api.Entities.UserTypeEntity", b =>
                {
                    b.HasOne("Skornel02.ETR.Api.Entities.User", "User")
                        .WithMany("Roles")
                        .HasForeignKey("Username")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("Skornel02.ETR.Api.Entities.ClassRoom", b =>
                {
                    b.Navigation("Courses");

                    b.Navigation("Exams");
                });

            modelBuilder.Entity("Skornel02.ETR.Api.Entities.Course", b =>
                {
                    b.Navigation("Attendees");

                    b.Navigation("CourseLocations");
                });

            modelBuilder.Entity("Skornel02.ETR.Api.Entities.CourseMetadata", b =>
                {
                    b.Navigation("Courses");
                });

            modelBuilder.Entity("Skornel02.ETR.Api.Entities.DegreeType", b =>
                {
                    b.Navigation("DegreeParticipations");
                });

            modelBuilder.Entity("Skornel02.ETR.Api.Entities.Exam", b =>
                {
                    b.Navigation("Attendees");
                });

            modelBuilder.Entity("Skornel02.ETR.Api.Entities.User", b =>
                {
                    b.Navigation("CourseAttendances");

                    b.Navigation("DegreeParticipations");

                    b.Navigation("ExamAttendances");

                    b.Navigation("Roles");
                });
#pragma warning restore 612, 618
        }
    }
}
