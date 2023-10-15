using System;

using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Skornel02.ETR.Api.Migrations
{
    /// <inheritdoc />
    public partial class FixesVol1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UserTypeEntity_Users_Username",
                table: "UserTypeEntity");

            migrationBuilder.DropPrimaryKey(
                name: "PK_UserTypeEntity",
                table: "UserTypeEntity");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "Courses");

            migrationBuilder.RenameTable(
                name: "UserTypeEntity",
                newName: "UserTypes");

            migrationBuilder.RenameIndex(
                name: "IX_UserTypeEntity_Username",
                table: "UserTypes",
                newName: "IX_UserTypes_Username");

            migrationBuilder.AddPrimaryKey(
                name: "PK_UserTypes",
                table: "UserTypes",
                columns: new[] { "UserType", "Username" });

            migrationBuilder.InsertData(
                table: "DegreeTypes",
                column: "Name",
                value: "Informatikus szak");

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Username", "BirthDate", "BirthLocation", "Name", "PasswordHash" },
                values: new object[,]
                {
                    { "oktato", new DateOnly(1980, 1, 2), "Szeged", "Doktor Doktor", "AQAAAAIAAYagAAAAEJQRnlk6FND0fXxkXtdWmlXFrcNKpfVYxIbAqTll82qqYAEnoRO7MehZbFwuxqCmjQ==" },
                    { "tanulo", new DateOnly(2000, 1, 2), "Szeged", "Teszt Elek", "AQAAAAIAAYagAAAAEHZI+KAYgFgraEbJnn8uqIhYLnR/uG9EM/rROV9vHKtJkS9EAMpR+DoBBnluq0JYcQ==" }
                });

            migrationBuilder.InsertData(
                table: "DegreeParticipations",
                columns: new[] { "DegreeName", "Username", "EndDate", "StartDate" },
                values: new object[,]
                {
                    { "Informatikus szak", "oktato", new DateOnly(2000, 6, 1), new DateOnly(1995, 9, 1) },
                    { "Informatikus szak", "tanulo", null, new DateOnly(2018, 9, 1) }
                });

            migrationBuilder.InsertData(
                table: "UserTypes",
                columns: new[] { "UserType", "Username" },
                values: new object[,]
                {
                    { 0, "tanulo" },
                    { 1, "oktato" }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_UserTypes_Users_Username",
                table: "UserTypes",
                column: "Username",
                principalTable: "Users",
                principalColumn: "Username",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UserTypes_Users_Username",
                table: "UserTypes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_UserTypes",
                table: "UserTypes");

            migrationBuilder.DeleteData(
                table: "DegreeParticipations",
                keyColumns: new[] { "DegreeName", "Username" },
                keyValues: new object[] { "Informatikus szak", "oktato" });

            migrationBuilder.DeleteData(
                table: "DegreeParticipations",
                keyColumns: new[] { "DegreeName", "Username" },
                keyValues: new object[] { "Informatikus szak", "tanulo" });

            migrationBuilder.DeleteData(
                table: "UserTypes",
                keyColumns: new[] { "UserType", "Username" },
                keyValues: new object[] { 0, "tanulo" });

            migrationBuilder.DeleteData(
                table: "UserTypes",
                keyColumns: new[] { "UserType", "Username" },
                keyValues: new object[] { 1, "oktato" });

            migrationBuilder.DeleteData(
                table: "DegreeTypes",
                keyColumn: "Name",
                keyValue: "Informatikus szak");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Username",
                keyValue: "oktato");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Username",
                keyValue: "tanulo");

            migrationBuilder.RenameTable(
                name: "UserTypes",
                newName: "UserTypeEntity");

            migrationBuilder.RenameIndex(
                name: "IX_UserTypes_Username",
                table: "UserTypeEntity",
                newName: "IX_UserTypeEntity_Username");

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Courses",
                type: "longtext",
                nullable: false)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddPrimaryKey(
                name: "PK_UserTypeEntity",
                table: "UserTypeEntity",
                columns: new[] { "UserType", "Username" });

            migrationBuilder.AddForeignKey(
                name: "FK_UserTypeEntity_Users_Username",
                table: "UserTypeEntity",
                column: "Username",
                principalTable: "Users",
                principalColumn: "Username",
                onDelete: ReferentialAction.Cascade);
        }
    }
}