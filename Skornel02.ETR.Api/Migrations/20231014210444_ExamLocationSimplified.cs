using System;

using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Skornel02.ETR.Api.Migrations
{
    /// <inheritdoc />
    public partial class ExamLocationSimplified : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ExamLocations");

            migrationBuilder.AddColumn<string>(
                name: "ClassRoomAddress",
                table: "Exams",
                type: "varchar(255)",
                nullable: false,
                defaultValue: "")
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "ClassRoomRoomName",
                table: "Exams",
                type: "varchar(255)",
                nullable: false,
                defaultValue: "")
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "IX_Exams_ClassRoomAddress_ClassRoomRoomName",
                table: "Exams",
                columns: new[] { "ClassRoomAddress", "ClassRoomRoomName" });

            migrationBuilder.AddForeignKey(
                name: "FK_Exams_ClassRooms_ClassRoomAddress_ClassRoomRoomName",
                table: "Exams",
                columns: new[] { "ClassRoomAddress", "ClassRoomRoomName" },
                principalTable: "ClassRooms",
                principalColumns: new[] { "Address", "RoomNumber" },
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Exams_ClassRooms_ClassRoomAddress_ClassRoomRoomName",
                table: "Exams");

            migrationBuilder.DropIndex(
                name: "IX_Exams_ClassRoomAddress_ClassRoomRoomName",
                table: "Exams");

            migrationBuilder.DropColumn(
                name: "ClassRoomAddress",
                table: "Exams");

            migrationBuilder.DropColumn(
                name: "ClassRoomRoomName",
                table: "Exams");

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
                name: "IX_ExamLocations_Address_RoomName",
                table: "ExamLocations",
                columns: new[] { "Address", "RoomName" });

            migrationBuilder.CreateIndex(
                name: "IX_ExamLocations_CourseCode_CourseSemester_ExamStart",
                table: "ExamLocations",
                columns: new[] { "CourseCode", "CourseSemester", "ExamStart" },
                unique: true);
        }
    }
}