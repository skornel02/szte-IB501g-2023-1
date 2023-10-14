using System;

using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Skornel02.ETR.Api.Migrations
{
    /// <inheritdoc />
    public partial class DatabaseFormalization : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DegreeParticipation_DegreeType_DegreeName",
                table: "DegreeParticipation");

            migrationBuilder.DropForeignKey(
                name: "FK_DegreeParticipation_Users_Username",
                table: "DegreeParticipation");

            migrationBuilder.DropPrimaryKey(
                name: "PK_DegreeType",
                table: "DegreeType");

            migrationBuilder.DropPrimaryKey(
                name: "PK_DegreeParticipation",
                table: "DegreeParticipation");

            migrationBuilder.RenameTable(
                name: "DegreeType",
                newName: "DegreeTypes");

            migrationBuilder.RenameTable(
                name: "DegreeParticipation",
                newName: "DegreeParticipations");

            migrationBuilder.RenameColumn(
                name: "EmailAddress",
                table: "Users",
                newName: "Name");

            migrationBuilder.RenameIndex(
                name: "IX_DegreeParticipation_DegreeName",
                table: "DegreeParticipations",
                newName: "IX_DegreeParticipations_DegreeName");

            migrationBuilder.AddPrimaryKey(
                name: "PK_DegreeTypes",
                table: "DegreeTypes",
                column: "Name");

            migrationBuilder.AddPrimaryKey(
                name: "PK_DegreeParticipations",
                table: "DegreeParticipations",
                columns: new[] { "Username", "DegreeName" });

            migrationBuilder.CreateTable(
                name: "ClassRooms",
                columns: table => new
                {
                    Address = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    RoomNumber = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    RoomType = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClassRooms", x => new { x.Address, x.RoomNumber });
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "CourseMetadata",
                columns: table => new
                {
                    CourseCode = table.Column<string>(type: "varchar(15)", maxLength: 15, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Type = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CourseMetadata", x => x.CourseCode);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Courses",
                columns: table => new
                {
                    CourseCode = table.Column<string>(type: "varchar(15)", maxLength: 15, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Semester = table.Column<string>(type: "varchar(6)", maxLength: 6, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Name = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Credits = table.Column<int>(type: "int", nullable: false),
                    Capacity = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Courses", x => new { x.CourseCode, x.Semester });
                    table.ForeignKey(
                        name: "FK_Courses_CourseMetadata_CourseCode",
                        column: x => x.CourseCode,
                        principalTable: "CourseMetadata",
                        principalColumn: "CourseCode",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "CourseAttendances",
                columns: table => new
                {
                    Username = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    CourseCode = table.Column<string>(type: "varchar(15)", maxLength: 15, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    CourseSemester = table.Column<string>(type: "varchar(6)", maxLength: 6, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    AttendanceType = table.Column<int>(type: "int", nullable: false),
                    Grade = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CourseAttendances", x => new { x.Username, x.CourseCode, x.CourseSemester });
                    table.ForeignKey(
                        name: "FK_CourseAttendances_Courses_CourseCode_CourseSemester",
                        columns: x => new { x.CourseCode, x.CourseSemester },
                        principalTable: "Courses",
                        principalColumns: new[] { "CourseCode", "Semester" },
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CourseAttendances_Users_Username",
                        column: x => x.Username,
                        principalTable: "Users",
                        principalColumn: "Username",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "CourseLocations",
                columns: table => new
                {
                    CourseCode = table.Column<string>(type: "varchar(15)", maxLength: 15, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    CourseSemester = table.Column<string>(type: "varchar(6)", maxLength: 6, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Address = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    RoomName = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Start = table.Column<DateTimeOffset>(type: "datetime(6)", nullable: false),
                    End = table.Column<DateTimeOffset>(type: "datetime(6)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CourseLocations", x => new { x.CourseCode, x.CourseSemester, x.Address, x.RoomName, x.Start });
                    table.ForeignKey(
                        name: "FK_CourseLocations_ClassRooms_Address_RoomName",
                        columns: x => new { x.Address, x.RoomName },
                        principalTable: "ClassRooms",
                        principalColumns: new[] { "Address", "RoomNumber" },
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CourseLocations_Courses_CourseCode_CourseSemester",
                        columns: x => new { x.CourseCode, x.CourseSemester },
                        principalTable: "Courses",
                        principalColumns: new[] { "CourseCode", "Semester" },
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Exams",
                columns: table => new
                {
                    CourseCode = table.Column<string>(type: "varchar(15)", maxLength: 15, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    CourseSemester = table.Column<string>(type: "varchar(6)", maxLength: 6, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Start = table.Column<DateTimeOffset>(type: "datetime(6)", nullable: false),
                    End = table.Column<DateTimeOffset>(type: "datetime(6)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Exams", x => new { x.CourseCode, x.CourseSemester, x.Start });
                    table.ForeignKey(
                        name: "FK_Exams_Courses_CourseCode_CourseSemester",
                        columns: x => new { x.CourseCode, x.CourseSemester },
                        principalTable: "Courses",
                        principalColumns: new[] { "CourseCode", "Semester" },
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "ExamAttendances",
                columns: table => new
                {
                    Username = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    CourseCode = table.Column<string>(type: "varchar(15)", maxLength: 15, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    CourseSemester = table.Column<string>(type: "varchar(6)", maxLength: 6, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    CourseStart = table.Column<DateTimeOffset>(type: "datetime(6)", nullable: false),
                    AttendanceType = table.Column<int>(type: "int", nullable: false),
                    Grade = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ExamAttendances", x => new { x.Username, x.CourseCode, x.CourseSemester, x.CourseStart });
                    table.ForeignKey(
                        name: "FK_ExamAttendances_Exams_CourseCode_CourseSemester_CourseStart",
                        columns: x => new { x.CourseCode, x.CourseSemester, x.CourseStart },
                        principalTable: "Exams",
                        principalColumns: new[] { "CourseCode", "CourseSemester", "Start" },
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ExamAttendances_Users_Username",
                        column: x => x.Username,
                        principalTable: "Users",
                        principalColumn: "Username",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "ExamLocations",
                columns: table => new
                {
                    CourseCode = table.Column<string>(type: "varchar(15)", maxLength: 15, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    CourseSemester = table.Column<string>(type: "varchar(6)", maxLength: 6, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ExamStart = table.Column<DateTimeOffset>(type: "datetime(6)", nullable: false),
                    Address = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    RoomName = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ExamLocations", x => new { x.CourseCode, x.CourseSemester, x.ExamStart, x.Address, x.RoomName });
                    table.ForeignKey(
                        name: "FK_ExamLocations_ClassRooms_Address_RoomName",
                        columns: x => new { x.Address, x.RoomName },
                        principalTable: "ClassRooms",
                        principalColumns: new[] { "Address", "RoomNumber" },
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ExamLocations_Exams_CourseCode_CourseSemester_ExamStart",
                        columns: x => new { x.CourseCode, x.CourseSemester, x.ExamStart },
                        principalTable: "Exams",
                        principalColumns: new[] { "CourseCode", "CourseSemester", "Start" },
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "IX_CourseAttendances_CourseCode_CourseSemester",
                table: "CourseAttendances",
                columns: new[] { "CourseCode", "CourseSemester" });

            migrationBuilder.CreateIndex(
                name: "IX_CourseLocations_Address_RoomName",
                table: "CourseLocations",
                columns: new[] { "Address", "RoomName" });

            migrationBuilder.CreateIndex(
                name: "IX_ExamAttendances_CourseCode_CourseSemester_CourseStart",
                table: "ExamAttendances",
                columns: new[] { "CourseCode", "CourseSemester", "CourseStart" });

            migrationBuilder.CreateIndex(
                name: "IX_ExamLocations_Address_RoomName",
                table: "ExamLocations",
                columns: new[] { "Address", "RoomName" });

            migrationBuilder.CreateIndex(
                name: "IX_ExamLocations_CourseCode_CourseSemester_ExamStart",
                table: "ExamLocations",
                columns: new[] { "CourseCode", "CourseSemester", "ExamStart" },
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_DegreeParticipations_DegreeTypes_DegreeName",
                table: "DegreeParticipations",
                column: "DegreeName",
                principalTable: "DegreeTypes",
                principalColumn: "Name",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_DegreeParticipations_Users_Username",
                table: "DegreeParticipations",
                column: "Username",
                principalTable: "Users",
                principalColumn: "Username",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DegreeParticipations_DegreeTypes_DegreeName",
                table: "DegreeParticipations");

            migrationBuilder.DropForeignKey(
                name: "FK_DegreeParticipations_Users_Username",
                table: "DegreeParticipations");

            migrationBuilder.DropTable(
                name: "CourseAttendances");

            migrationBuilder.DropTable(
                name: "CourseLocations");

            migrationBuilder.DropTable(
                name: "ExamAttendances");

            migrationBuilder.DropTable(
                name: "ExamLocations");

            migrationBuilder.DropTable(
                name: "ClassRooms");

            migrationBuilder.DropTable(
                name: "Exams");

            migrationBuilder.DropTable(
                name: "Courses");

            migrationBuilder.DropTable(
                name: "CourseMetadata");

            migrationBuilder.DropPrimaryKey(
                name: "PK_DegreeTypes",
                table: "DegreeTypes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_DegreeParticipations",
                table: "DegreeParticipations");

            migrationBuilder.RenameTable(
                name: "DegreeTypes",
                newName: "DegreeType");

            migrationBuilder.RenameTable(
                name: "DegreeParticipations",
                newName: "DegreeParticipation");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Users",
                newName: "EmailAddress");

            migrationBuilder.RenameIndex(
                name: "IX_DegreeParticipations_DegreeName",
                table: "DegreeParticipation",
                newName: "IX_DegreeParticipation_DegreeName");

            migrationBuilder.AddPrimaryKey(
                name: "PK_DegreeType",
                table: "DegreeType",
                column: "Name");

            migrationBuilder.AddPrimaryKey(
                name: "PK_DegreeParticipation",
                table: "DegreeParticipation",
                columns: new[] { "Username", "DegreeName" });

            migrationBuilder.AddForeignKey(
                name: "FK_DegreeParticipation_DegreeType_DegreeName",
                table: "DegreeParticipation",
                column: "DegreeName",
                principalTable: "DegreeType",
                principalColumn: "Name",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_DegreeParticipation_Users_Username",
                table: "DegreeParticipation",
                column: "Username",
                principalTable: "Users",
                principalColumn: "Username",
                onDelete: ReferentialAction.Cascade);
        }
    }
}