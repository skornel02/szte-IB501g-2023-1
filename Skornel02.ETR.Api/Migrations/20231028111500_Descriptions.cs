using System;

using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Skornel02.ETR.Api.Migrations
{
    /// <inheritdoc />
    public partial class Descriptions : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "Credits",
                table: "Courses",
                type: "int",
                nullable: false,
                comment: "Tárgy kreditszáma",
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "Capacity",
                table: "Courses",
                type: "int",
                nullable: false,
                comment: "Maximum kapacitás",
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "Semester",
                table: "Courses",
                type: "varchar(6)",
                maxLength: 6,
                nullable: false,
                comment: "Aktuális félév",
                oldClrType: typeof(string),
                oldType: "varchar(6)",
                oldMaxLength: 6)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "CourseCode",
                table: "Courses",
                type: "varchar(15)",
                maxLength: 15,
                nullable: false,
                comment: "Kurzus kódja",
                oldClrType: typeof(string),
                oldType: "varchar(15)",
                oldMaxLength: 15)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.UpdateData(
                table: "DegreeParticipations",
                keyColumns: new[] { "DegreeName", "Username" },
                keyValues: new object[] { "Games & Toys (297)", "Aggelos.Aggelidoy35" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateOnly(2014, 7, 10), new DateOnly(2011, 7, 10) });

            migrationBuilder.UpdateData(
                table: "DegreeParticipations",
                keyColumns: new[] { "DegreeName", "Username" },
                keyValues: new object[] { "Electronics (266)", "Aggelos6" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateOnly(2020, 11, 19), new DateOnly(2017, 11, 19) });

            migrationBuilder.UpdateData(
                table: "DegreeParticipations",
                keyColumns: new[] { "DegreeName", "Username" },
                keyValues: new object[] { "Games & Toys (297)", "Aggelos87" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateOnly(2023, 3, 17), new DateOnly(2020, 3, 17) });

            migrationBuilder.UpdateData(
                table: "DegreeParticipations",
                keyColumns: new[] { "DegreeName", "Username" },
                keyValues: new object[] { "Toys (259)", "Aggelos_Georgiadis30" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateOnly(2025, 12, 23), new DateOnly(2022, 12, 23) });

            migrationBuilder.UpdateData(
                table: "DegreeParticipations",
                keyColumns: new[] { "DegreeName", "Username" },
                keyValues: new object[] { "Books (290)", "Aleksandros.Zervos61" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateOnly(2018, 5, 3), new DateOnly(2015, 5, 3) });

            migrationBuilder.UpdateData(
                table: "DegreeParticipations",
                keyColumns: new[] { "DegreeName", "Username" },
                keyValues: new object[] { "Baby (283)", "Anastasios_Bilaetis84" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateOnly(2009, 12, 9), new DateOnly(2006, 12, 9) });

            migrationBuilder.UpdateData(
                table: "DegreeParticipations",
                keyColumns: new[] { "DegreeName", "Username" },
                keyValues: new object[] { "Music, Movies & Industrial (280)", "Anastasios_Nikolakos52" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateOnly(2024, 3, 8), new DateOnly(2021, 3, 8) });

            migrationBuilder.UpdateData(
                table: "DegreeParticipations",
                keyColumns: new[] { "DegreeName", "Username" },
                keyValues: new object[] { "Health, Toys & Outdoors (255)", "Andreas22" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateOnly(2019, 9, 4), new DateOnly(2016, 9, 4) });

            migrationBuilder.UpdateData(
                table: "DegreeParticipations",
                keyColumns: new[] { "DegreeName", "Username" },
                keyValues: new object[] { "Garden (271)", "Andreas52" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateOnly(2009, 8, 15), new DateOnly(2006, 8, 15) });

            migrationBuilder.UpdateData(
                table: "DegreeParticipations",
                keyColumns: new[] { "DegreeName", "Username" },
                keyValues: new object[] { "Sports, Computers & Electronics (277)", "Andreas95" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateOnly(2021, 4, 14), new DateOnly(2018, 4, 14) });

            migrationBuilder.UpdateData(
                table: "DegreeParticipations",
                keyColumns: new[] { "DegreeName", "Username" },
                keyValues: new object[] { "Shoes & Toys (268)", "Andreas_Bikelidis33" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateOnly(2016, 9, 16), new DateOnly(2013, 9, 16) });

            migrationBuilder.UpdateData(
                table: "DegreeParticipations",
                keyColumns: new[] { "DegreeName", "Username" },
                keyValues: new object[] { "Jewelery, Automotive & Garden (276)", "Antonis.Lytras" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateOnly(2007, 7, 13), new DateOnly(2004, 7, 13) });

            migrationBuilder.UpdateData(
                table: "DegreeParticipations",
                keyColumns: new[] { "DegreeName", "Username" },
                keyValues: new object[] { "Books & Sports (273)", "Antonis4" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateOnly(2018, 6, 2), new DateOnly(2015, 6, 2) });

            migrationBuilder.UpdateData(
                table: "DegreeParticipations",
                keyColumns: new[] { "DegreeName", "Username" },
                keyValues: new object[] { "Electronics (266)", "Antonis_Antonopoylos" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateOnly(2024, 8, 26), new DateOnly(2021, 8, 26) });

            migrationBuilder.UpdateData(
                table: "DegreeParticipations",
                keyColumns: new[] { "DegreeName", "Username" },
                keyValues: new object[] { "Home (264)", "Antonis_Diamantopoylos43" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateOnly(2021, 1, 28), new DateOnly(2018, 1, 28) });

            migrationBuilder.UpdateData(
                table: "DegreeParticipations",
                keyColumns: new[] { "DegreeName", "Username" },
                keyValues: new object[] { "Clothing, Electronics & Jewelery (253)", "Antonis_Melioi26" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateOnly(2009, 8, 25), new DateOnly(2006, 8, 25) });

            migrationBuilder.UpdateData(
                table: "DegreeParticipations",
                keyColumns: new[] { "DegreeName", "Username" },
                keyValues: new object[] { "Kids & Tools (265)", "Apostolos44" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateOnly(2016, 4, 18), new DateOnly(2013, 4, 18) });

            migrationBuilder.UpdateData(
                table: "DegreeParticipations",
                keyColumns: new[] { "DegreeName", "Username" },
                keyValues: new object[] { "Shoes & Kids (281)", "Apostolos75" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateOnly(2022, 9, 7), new DateOnly(2019, 9, 7) });

            migrationBuilder.UpdateData(
                table: "DegreeParticipations",
                keyColumns: new[] { "DegreeName", "Username" },
                keyValues: new object[] { "Electronics & Jewelery (282)", "Apostolos_Daskalopoylos" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateOnly(2012, 8, 8), new DateOnly(2009, 8, 8) });

            migrationBuilder.UpdateData(
                table: "DegreeParticipations",
                keyColumns: new[] { "DegreeName", "Username" },
                keyValues: new object[] { "Automotive, Garden & Beauty (261)", "Aristeidis_Melioi" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateOnly(2024, 1, 6), new DateOnly(2021, 1, 6) });

            migrationBuilder.UpdateData(
                table: "DegreeParticipations",
                keyColumns: new[] { "DegreeName", "Username" },
                keyValues: new object[] { "Sports, Computers & Electronics (277)", "Basilis.Koytalianos17" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateOnly(2024, 6, 25), new DateOnly(2021, 6, 25) });

            migrationBuilder.UpdateData(
                table: "DegreeParticipations",
                keyColumns: new[] { "DegreeName", "Username" },
                keyValues: new object[] { "Electronics (251)", "Basilis_Oikonomoy" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateOnly(2024, 12, 8), new DateOnly(2021, 12, 8) });

            migrationBuilder.UpdateData(
                table: "DegreeParticipations",
                keyColumns: new[] { "DegreeName", "Username" },
                keyValues: new object[] { "Kids & Baby (287)", "Dimitris28" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateOnly(2019, 1, 9), new DateOnly(2016, 1, 9) });

            migrationBuilder.UpdateData(
                table: "DegreeParticipations",
                keyColumns: new[] { "DegreeName", "Username" },
                keyValues: new object[] { "Garden (262)", "Dionysios.Lytras" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateOnly(2009, 12, 10), new DateOnly(2006, 12, 10) });

            migrationBuilder.UpdateData(
                table: "DegreeParticipations",
                keyColumns: new[] { "DegreeName", "Username" },
                keyValues: new object[] { "Electronics (266)", "Eleytherios.Eleytherioy" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateOnly(2017, 2, 27), new DateOnly(2014, 2, 27) });

            migrationBuilder.UpdateData(
                table: "DegreeParticipations",
                keyColumns: new[] { "DegreeName", "Username" },
                keyValues: new object[] { "Electronics (251)", "Emmanoyil_Aleksioy5" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateOnly(2017, 7, 26), new DateOnly(2014, 7, 26) });

            migrationBuilder.UpdateData(
                table: "DegreeParticipations",
                keyColumns: new[] { "DegreeName", "Username" },
                keyValues: new object[] { "Toys (267)", "Emmanoyil_Koyndoyros" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateOnly(2021, 11, 29), new DateOnly(2018, 11, 29) });

            migrationBuilder.UpdateData(
                table: "DegreeParticipations",
                keyColumns: new[] { "DegreeName", "Username" },
                keyValues: new object[] { "Beauty (269)", "Eyaggelos_Koromilas73" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateOnly(2023, 12, 9), new DateOnly(2020, 12, 9) });

            migrationBuilder.UpdateData(
                table: "DegreeParticipations",
                keyColumns: new[] { "DegreeName", "Username" },
                keyValues: new object[] { "Games & Toys (297)", "Eystathios_Avramidis41" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateOnly(2026, 2, 20), new DateOnly(2023, 2, 20) });

            migrationBuilder.UpdateData(
                table: "DegreeParticipations",
                keyColumns: new[] { "DegreeName", "Username" },
                keyValues: new object[] { "Home (264)", "Fotios.Andreoy51" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateOnly(2025, 2, 10), new DateOnly(2022, 2, 10) });

            migrationBuilder.UpdateData(
                table: "DegreeParticipations",
                keyColumns: new[] { "DegreeName", "Username" },
                keyValues: new object[] { "Baby (283)", "Fotios90" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateOnly(2026, 10, 19), new DateOnly(2023, 10, 19) });

            migrationBuilder.UpdateData(
                table: "DegreeParticipations",
                keyColumns: new[] { "DegreeName", "Username" },
                keyValues: new object[] { "Garden (271)", "Fotios_Karavias7" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateOnly(2014, 8, 15), new DateOnly(2011, 8, 15) });

            migrationBuilder.UpdateData(
                table: "DegreeParticipations",
                keyColumns: new[] { "DegreeName", "Username" },
                keyValues: new object[] { "Clothing, Electronics & Jewelery (253)", "Georgios.Eytaksias" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateOnly(2013, 9, 30), new DateOnly(2010, 9, 30) });

            migrationBuilder.UpdateData(
                table: "DegreeParticipations",
                keyColumns: new[] { "DegreeName", "Username" },
                keyValues: new object[] { "Electronics (251)", "Georgios2" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateOnly(2024, 2, 10), new DateOnly(2021, 2, 10) });

            migrationBuilder.UpdateData(
                table: "DegreeParticipations",
                keyColumns: new[] { "DegreeName", "Username" },
                keyValues: new object[] { "Home (264)", "Georgios45" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateOnly(2024, 11, 12), new DateOnly(2021, 11, 12) });

            migrationBuilder.UpdateData(
                table: "DegreeParticipations",
                keyColumns: new[] { "DegreeName", "Username" },
                keyValues: new object[] { "Books (290)", "Georgios79" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateOnly(2008, 9, 14), new DateOnly(2005, 9, 14) });

            migrationBuilder.UpdateData(
                table: "DegreeParticipations",
                keyColumns: new[] { "DegreeName", "Username" },
                keyValues: new object[] { "Kids, Electronics & Movies (288)", "Georgios_Bilaetis20" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateOnly(2009, 4, 15), new DateOnly(2006, 4, 15) });

            migrationBuilder.UpdateData(
                table: "DegreeParticipations",
                keyColumns: new[] { "DegreeName", "Username" },
                keyValues: new object[] { "Baby (283)", "Grigorios.Boylgaris" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateOnly(2020, 3, 23), new DateOnly(2017, 3, 23) });

            migrationBuilder.UpdateData(
                table: "DegreeParticipations",
                keyColumns: new[] { "DegreeName", "Username" },
                keyValues: new object[] { "Baby (283)", "Grigorios_Kontoleon41" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateOnly(2013, 1, 18), new DateOnly(2010, 1, 18) });

            migrationBuilder.UpdateData(
                table: "DegreeParticipations",
                keyColumns: new[] { "DegreeName", "Username" },
                keyValues: new object[] { "Baby (279)", "Ilias.Metaksas74" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateOnly(2025, 1, 19), new DateOnly(2022, 1, 19) });

            migrationBuilder.UpdateData(
                table: "DegreeParticipations",
                keyColumns: new[] { "DegreeName", "Username" },
                keyValues: new object[] { "Kids & Tools (265)", "Ilias.Zafeiropoylos86" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateOnly(2010, 5, 10), new DateOnly(2007, 5, 10) });

            migrationBuilder.UpdateData(
                table: "DegreeParticipations",
                keyColumns: new[] { "DegreeName", "Username" },
                keyValues: new object[] { "Baby (279)", "Ilias56" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateOnly(2008, 6, 18), new DateOnly(2005, 6, 18) });

            migrationBuilder.UpdateData(
                table: "DegreeParticipations",
                keyColumns: new[] { "DegreeName", "Username" },
                keyValues: new object[] { "Garden (262)", "Ilias_Bamvas22" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateOnly(2024, 1, 16), new DateOnly(2021, 1, 16) });

            migrationBuilder.UpdateData(
                table: "DegreeParticipations",
                keyColumns: new[] { "DegreeName", "Username" },
                keyValues: new object[] { "Kids, Electronics & Movies (288)", "Ioannis.Aygerinoseponymo0" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateOnly(2021, 9, 20), new DateOnly(2018, 9, 20) });

            migrationBuilder.UpdateData(
                table: "DegreeParticipations",
                keyColumns: new[] { "DegreeName", "Username" },
                keyValues: new object[] { "Books (257)", "Ioannis.Zappas99" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateOnly(2014, 3, 6), new DateOnly(2011, 3, 6) });

            migrationBuilder.UpdateData(
                table: "DegreeParticipations",
                keyColumns: new[] { "DegreeName", "Username" },
                keyValues: new object[] { "Electronics (266)", "Ioannis28" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateOnly(2014, 9, 20), new DateOnly(2011, 9, 20) });

            migrationBuilder.UpdateData(
                table: "DegreeParticipations",
                keyColumns: new[] { "DegreeName", "Username" },
                keyValues: new object[] { "Garden (260)", "Ioannis_Basilopoylos" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateOnly(2019, 5, 18), new DateOnly(2016, 5, 18) });

            migrationBuilder.UpdateData(
                table: "DegreeParticipations",
                keyColumns: new[] { "DegreeName", "Username" },
                keyValues: new object[] { "Industrial, Toys & Automotive (250)", "Kostas43" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateOnly(2026, 3, 25), new DateOnly(2023, 3, 25) });

            migrationBuilder.UpdateData(
                table: "DegreeParticipations",
                keyColumns: new[] { "DegreeName", "Username" },
                keyValues: new object[] { "Clothing, Electronics & Jewelery (253)", "Kostas92" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateOnly(2008, 6, 8), new DateOnly(2005, 6, 8) });

            migrationBuilder.UpdateData(
                table: "DegreeParticipations",
                keyColumns: new[] { "DegreeName", "Username" },
                keyValues: new object[] { "Toys (259)", "Mixail.Bergas85" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateOnly(2006, 11, 3), new DateOnly(2003, 11, 3) });

            migrationBuilder.UpdateData(
                table: "DegreeParticipations",
                keyColumns: new[] { "DegreeName", "Username" },
                keyValues: new object[] { "Movies & Toys (286)", "Mixail.Ioannoy" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateOnly(2008, 3, 24), new DateOnly(2005, 3, 24) });

            migrationBuilder.UpdateData(
                table: "DegreeParticipations",
                keyColumns: new[] { "DegreeName", "Username" },
                keyValues: new object[] { "Toys (267)", "Mixail90" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateOnly(2016, 5, 27), new DateOnly(2013, 5, 27) });

            migrationBuilder.UpdateData(
                table: "DegreeParticipations",
                keyColumns: new[] { "DegreeName", "Username" },
                keyValues: new object[] { "Baby (283)", "Paraskeyas.Anagnostakis" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateOnly(2022, 11, 24), new DateOnly(2019, 11, 24) });

            migrationBuilder.UpdateData(
                table: "DegreeParticipations",
                keyColumns: new[] { "DegreeName", "Username" },
                keyValues: new object[] { "Books (257)", "Paraskeyas_THeodoridis89" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateOnly(2024, 4, 26), new DateOnly(2021, 4, 26) });

            migrationBuilder.UpdateData(
                table: "DegreeParticipations",
                keyColumns: new[] { "DegreeName", "Username" },
                keyValues: new object[] { "Books (257)", "Paylos.Giagkos" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateOnly(2014, 10, 26), new DateOnly(2011, 10, 26) });

            migrationBuilder.UpdateData(
                table: "DegreeParticipations",
                keyColumns: new[] { "DegreeName", "Username" },
                keyValues: new object[] { "Baby (279)", "Paylos.Koyndoyros" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateOnly(2009, 10, 9), new DateOnly(2006, 10, 9) });

            migrationBuilder.UpdateData(
                table: "DegreeParticipations",
                keyColumns: new[] { "DegreeName", "Username" },
                keyValues: new object[] { "Electronics (251)", "Paylos48" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateOnly(2016, 3, 6), new DateOnly(2013, 3, 6) });

            migrationBuilder.UpdateData(
                table: "DegreeParticipations",
                keyColumns: new[] { "DegreeName", "Username" },
                keyValues: new object[] { "Garden, Kids & Outdoors (289)", "Paylos_Kalyvas76" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateOnly(2024, 11, 14), new DateOnly(2021, 11, 14) });

            migrationBuilder.UpdateData(
                table: "DegreeParticipations",
                keyColumns: new[] { "DegreeName", "Username" },
                keyValues: new object[] { "Health, Toys & Outdoors (255)", "Petros.Blavianos51" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateOnly(2025, 2, 15), new DateOnly(2022, 2, 15) });

            migrationBuilder.UpdateData(
                table: "DegreeParticipations",
                keyColumns: new[] { "DegreeName", "Username" },
                keyValues: new object[] { "Sports (274)", "Petros50" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateOnly(2013, 11, 21), new DateOnly(2010, 11, 21) });

            migrationBuilder.UpdateData(
                table: "DegreeParticipations",
                keyColumns: new[] { "DegreeName", "Username" },
                keyValues: new object[] { "Automotive, Garden & Beauty (261)", "Petros77" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateOnly(2017, 9, 15), new DateOnly(2014, 9, 15) });

            migrationBuilder.UpdateData(
                table: "DegreeParticipations",
                keyColumns: new[] { "DegreeName", "Username" },
                keyValues: new object[] { "Tools, Tools & Tools (284)", "Sotirios.Kalogiannis43" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateOnly(2015, 1, 20), new DateOnly(2012, 1, 20) });

            migrationBuilder.UpdateData(
                table: "DegreeParticipations",
                keyColumns: new[] { "DegreeName", "Username" },
                keyValues: new object[] { "Beauty & Electronics (299)", "Sotirios.THeodosioy" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateOnly(2026, 10, 2), new DateOnly(2023, 10, 2) });

            migrationBuilder.UpdateData(
                table: "DegreeParticipations",
                keyColumns: new[] { "DegreeName", "Username" },
                keyValues: new object[] { "Industrial & Computers (252)", "Sotirios_Zervos" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateOnly(2019, 12, 30), new DateOnly(2016, 12, 30) });

            migrationBuilder.UpdateData(
                table: "DegreeParticipations",
                keyColumns: new[] { "DegreeName", "Username" },
                keyValues: new object[] { "Home, Movies & Shoes (272)", "Spyros_Anastasiadis" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateOnly(2014, 2, 12), new DateOnly(2011, 2, 12) });

            migrationBuilder.UpdateData(
                table: "DegreeParticipations",
                keyColumns: new[] { "DegreeName", "Username" },
                keyValues: new object[] { "Outdoors, Home & Baby (292)", "Stayros_Bergas29" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateOnly(2009, 11, 2), new DateOnly(2006, 11, 2) });

            migrationBuilder.UpdateData(
                table: "DegreeParticipations",
                keyColumns: new[] { "DegreeName", "Username" },
                keyValues: new object[] { "Books & Sports (273)", "Stefanos.Loypis27" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateOnly(2015, 2, 11), new DateOnly(2012, 2, 11) });

            migrationBuilder.UpdateData(
                table: "DegreeParticipations",
                keyColumns: new[] { "DegreeName", "Username" },
                keyValues: new object[] { "Beauty (296)", "Stefanos.Nikolaidis21" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateOnly(2014, 6, 20), new DateOnly(2011, 6, 20) });

            migrationBuilder.UpdateData(
                table: "DegreeParticipations",
                keyColumns: new[] { "DegreeName", "Username" },
                keyValues: new object[] { "Tools, Tools & Tools (284)", "Stylianos.Basileiadis" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateOnly(2012, 4, 7), new DateOnly(2009, 4, 7) });

            migrationBuilder.UpdateData(
                table: "DegreeParticipations",
                keyColumns: new[] { "DegreeName", "Username" },
                keyValues: new object[] { "Toys, Outdoors & Toys (293)", "Stylianos.Mitzoy" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateOnly(2013, 4, 18), new DateOnly(2010, 4, 18) });

            migrationBuilder.UpdateData(
                table: "DegreeParticipations",
                keyColumns: new[] { "DegreeName", "Username" },
                keyValues: new object[] { "Music & Grocery (258)", "THeodoros.Basileiadis2" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateOnly(2015, 12, 7), new DateOnly(2012, 12, 7) });

            migrationBuilder.UpdateData(
                table: "DegreeParticipations",
                keyColumns: new[] { "DegreeName", "Username" },
                keyValues: new object[] { "Toys (259)", "THeodoros.Zafeiropoylos96" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateOnly(2025, 5, 29), new DateOnly(2022, 5, 29) });

            migrationBuilder.UpdateData(
                table: "DegreeParticipations",
                keyColumns: new[] { "DegreeName", "Username" },
                keyValues: new object[] { "Home, Movies & Shoes (272)", "THeodoros68" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateOnly(2018, 10, 15), new DateOnly(2015, 10, 15) });

            migrationBuilder.UpdateData(
                table: "DegreeParticipations",
                keyColumns: new[] { "DegreeName", "Username" },
                keyValues: new object[] { "Industrial & Shoes (270)", "Xaralampos43" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateOnly(2016, 11, 6), new DateOnly(2013, 11, 6) });

            migrationBuilder.UpdateData(
                table: "DegreeParticipations",
                keyColumns: new[] { "DegreeName", "Username" },
                keyValues: new object[] { "Sports, Computers & Electronics (277)", "Xaralampos68" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateOnly(2015, 8, 24), new DateOnly(2012, 8, 24) });

            migrationBuilder.UpdateData(
                table: "DegreeParticipations",
                keyColumns: new[] { "DegreeName", "Username" },
                keyValues: new object[] { "Electronics (251)", "Xaralampos74" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateOnly(2018, 12, 26), new DateOnly(2015, 12, 26) });

            migrationBuilder.UpdateData(
                table: "DegreeParticipations",
                keyColumns: new[] { "DegreeName", "Username" },
                keyValues: new object[] { "Baby, Home & Jewelery (254)", "Xristos80" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateOnly(2020, 11, 13), new DateOnly(2017, 11, 13) });

            migrationBuilder.UpdateData(
                table: "DegreeParticipations",
                keyColumns: new[] { "DegreeName", "Username" },
                keyValues: new object[] { "Electronics (251)", "Xristos85" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateOnly(2021, 5, 27), new DateOnly(2018, 5, 27) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Username",
                keyValue: "Aggelos.Aggelidoy35",
                columns: new[] { "BirthDate", "PasswordHash" },
                values: new object[] { new DateOnly(1993, 7, 10), "AQAAAAIAAYagAAAAEEbBMC8yulAOry4kj6PD7onLgYp0fvCy3JfbDTDwkb/LNyTPMEuQyl1FHQnNcR0F8A==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Username",
                keyValue: "Aggelos6",
                columns: new[] { "BirthDate", "PasswordHash" },
                values: new object[] { new DateOnly(1999, 11, 19), "AQAAAAIAAYagAAAAEG8U99PxAO/RiJZz7fm1y/UrmK80OyDuGhMtlT6kIdCq0ZYVpdmmqAzm9fmzBXfDqw==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Username",
                keyValue: "Aggelos87",
                columns: new[] { "BirthDate", "PasswordHash" },
                values: new object[] { new DateOnly(2002, 3, 17), "AQAAAAIAAYagAAAAELzLi4gOv0lQKS5ldBkirNiAOWKiBKZiWVc8ptFTLE/A5hqOS0AopRzYGCq1ycb9lg==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Username",
                keyValue: "Aggelos_Georgiadis30",
                columns: new[] { "BirthDate", "PasswordHash" },
                values: new object[] { new DateOnly(2004, 12, 23), "AQAAAAIAAYagAAAAEO9Pvww63nmmSdWBw3avn0rvpt4PmOa2hjXyxn7mkQVJjVJLIuQ93Z//wLJqa1blwg==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Username",
                keyValue: "Aleksandros.Zervos61",
                columns: new[] { "BirthDate", "PasswordHash" },
                values: new object[] { new DateOnly(1997, 5, 3), "AQAAAAIAAYagAAAAEExQZ+qhkC3cMqY79N83qHj0D7NTsr4JhOzpY1+mfGV/deHZRxSJnhFD/tIxAErtyQ==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Username",
                keyValue: "Aleksandros41",
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEHhhMwEC7YqXXYwb3pBosfIf50cyRXEwBlpGMmKZFB7dmXQ0AetNqwpuIcW7Z9ZZog==");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Username",
                keyValue: "Anastasios_Bilaetis84",
                columns: new[] { "BirthDate", "PasswordHash" },
                values: new object[] { new DateOnly(1988, 12, 9), "AQAAAAIAAYagAAAAEL/8B6SiXaWl7lB/2YKKiIbrAQTkf7LClxyEwOJmYiu9o8HECYnV2PKyuo6GNlHQqQ==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Username",
                keyValue: "Anastasios_Nikolakos52",
                columns: new[] { "BirthDate", "PasswordHash" },
                values: new object[] { new DateOnly(2003, 3, 8), "AQAAAAIAAYagAAAAEMUMjT3ssh3OxwUGeWtdaPv8ISSIe+bM1vc69oIFMl6qQG6FehafkIftFKYDqHiMIw==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Username",
                keyValue: "Andreas22",
                columns: new[] { "BirthDate", "PasswordHash" },
                values: new object[] { new DateOnly(1998, 9, 4), "AQAAAAIAAYagAAAAEIM8tMoNOuEpxT1oZCnZW4aW3DyHgeqjq5NMQ9q4P8qU4RIKeGEGWAp89Dp48zUNxQ==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Username",
                keyValue: "Andreas52",
                columns: new[] { "BirthDate", "PasswordHash" },
                values: new object[] { new DateOnly(1988, 8, 15), "AQAAAAIAAYagAAAAECRuXeAkPrPI57htP4AeAg7pwpc2EhCgZfQ1J+RR0yerngQvZXKnuVF14RDgYV+EJg==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Username",
                keyValue: "Andreas95",
                columns: new[] { "BirthDate", "PasswordHash" },
                values: new object[] { new DateOnly(2000, 4, 14), "AQAAAAIAAYagAAAAEC3xJWckJYVOrGlX+pA2JlsWg6CYO8qyjQzoy1G78PGxFSFQXZ4v1eLTGFKlalfBUg==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Username",
                keyValue: "Andreas_Bikelidis33",
                columns: new[] { "BirthDate", "PasswordHash" },
                values: new object[] { new DateOnly(1995, 9, 16), "AQAAAAIAAYagAAAAECW92nXwy6fBfbBaScMEyv1P7JESHnYV5Etb43V76yO/gHUnSfTI803sK9T1mg6ZwA==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Username",
                keyValue: "Antonis.Lytras",
                columns: new[] { "BirthDate", "PasswordHash" },
                values: new object[] { new DateOnly(1986, 7, 13), "AQAAAAIAAYagAAAAEOBrbloyfHtLIHFrFGKsJj4vH4MZaaMltagd9fSf1xiFIr8cFKiC2lz6Bs4dp4D4wg==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Username",
                keyValue: "Antonis4",
                columns: new[] { "BirthDate", "PasswordHash" },
                values: new object[] { new DateOnly(1997, 6, 2), "AQAAAAIAAYagAAAAEOClR94ASIVaAOtCZQQM+H7ZmjOqrK3kxE7uqVPzZdn2DI92penl2GdPYOLVRmLqnA==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Username",
                keyValue: "Antonis_Antonopoylos",
                columns: new[] { "BirthDate", "PasswordHash" },
                values: new object[] { new DateOnly(2003, 8, 26), "AQAAAAIAAYagAAAAEN/JScH58gDZvYdUWAIP+aSeGPw4C2q2aODG+br8LN/wO1LIawypaXymw59NlxKMuA==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Username",
                keyValue: "Antonis_Diamantopoylos43",
                columns: new[] { "BirthDate", "PasswordHash" },
                values: new object[] { new DateOnly(2000, 1, 28), "AQAAAAIAAYagAAAAEPV6EN1uWhLOJWydJ3ZLYNfxLtJWGsl7L9n07h95da08/Rn41XSVTXoD6BT3BVF71A==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Username",
                keyValue: "Antonis_Karamanlis",
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAELVH7rtdgF85Y/K1Xol3UsespVr9rME+HWZDBWRZE6/pj59+BIl7ATx8ZnV+yabojg==");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Username",
                keyValue: "Antonis_Melioi26",
                columns: new[] { "BirthDate", "PasswordHash" },
                values: new object[] { new DateOnly(1988, 8, 25), "AQAAAAIAAYagAAAAEBxc+eDsLYk0PY1ldOAAGFdbK4DByxDYCv+7AnE8YeGrpjDvWGQndh/izOzzHBXDQg==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Username",
                keyValue: "Apostolos.Kypraios",
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEHxY0juU0C1cFJI2QxXwo67ZRbQFO81GncWk55f3Qy3ndPtfmnIBryNOASpdIg/wOA==");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Username",
                keyValue: "Apostolos44",
                columns: new[] { "BirthDate", "PasswordHash" },
                values: new object[] { new DateOnly(1995, 4, 18), "AQAAAAIAAYagAAAAEDkn9ebqnLXnVOwLcURVQ/yL1AODKD+bTlk9LUe7fUXKlG2uNO4qxfT0rTrC3aps4g==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Username",
                keyValue: "Apostolos75",
                columns: new[] { "BirthDate", "PasswordHash" },
                values: new object[] { new DateOnly(2001, 9, 7), "AQAAAAIAAYagAAAAEJdps6cbMDqMIQ32ziYMVJ+lYKKBapV0UuArbGKgBKaOt/v4ng5kijUhsNz1SBC6xQ==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Username",
                keyValue: "Apostolos_Daskalopoylos",
                columns: new[] { "BirthDate", "PasswordHash" },
                values: new object[] { new DateOnly(1991, 8, 8), "AQAAAAIAAYagAAAAELvHeN9I0DJXTGM4hP7iLNRwWAhKNBwQGI/CwOWQHw7Yn02uSM/MIkSgRr/skhbKPA==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Username",
                keyValue: "Aristeidis.Aleksandroy12",
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEOLNCljr5IZD5b1FS6mDJ4iFhsjHb9T3afJGcEUW/ExmIfQUXcp3jDXP3pTpH7BjBA==");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Username",
                keyValue: "Aristeidis.Papanikolaoy",
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEPzbnKkipWtWY0veOxsobapWGtpxzr5GjMHD9UJomfvIMOCM+c5+Vk+uXT8Fq6DNbg==");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Username",
                keyValue: "Aristeidis_Melioi",
                columns: new[] { "BirthDate", "PasswordHash" },
                values: new object[] { new DateOnly(2003, 1, 6), "AQAAAAIAAYagAAAAEChF7Kr+QFsoJDgopEzYupe9CN5xr5KkdBFHvarj7hu/y7IS1Kxlyq5OzCMGPgZmZA==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Username",
                keyValue: "Basilis.Koytalianos17",
                columns: new[] { "BirthDate", "PasswordHash" },
                values: new object[] { new DateOnly(2003, 6, 25), "AQAAAAIAAYagAAAAEBlmXJl+ytxdAvBvUw8ZlSJhzezbcp3TGguzMIMAJjoiqTPLvkbk3F6VoUl7ijt+Bg==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Username",
                keyValue: "Basilis61",
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEHmxOwfFZ4LHGoa2L3ZWhNrbiGIrezefFzdPF67NhfIBJ551YHhYn+oWlhyMpATvQA==");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Username",
                keyValue: "Basilis_Oikonomoy",
                columns: new[] { "BirthDate", "PasswordHash" },
                values: new object[] { new DateOnly(2003, 12, 8), "AQAAAAIAAYagAAAAEETWFHgGkFYynbNzxYyVVHqKBgAObX7lkHB+fFbToZKZRx2IsA0FUlJnHMXrd0JXsw==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Username",
                keyValue: "Dimitris28",
                columns: new[] { "BirthDate", "PasswordHash" },
                values: new object[] { new DateOnly(1998, 1, 9), "AQAAAAIAAYagAAAAEN5LOU3zyFGo3iOTD8HFsjQRAktaZOzTCw3f8smaW1fsY3xQWhyilmp3L+ZOnmluYA==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Username",
                keyValue: "Dionysios.Anagnostakis",
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEAAw/jzNOyxwk5klfNsmur1Abo0wUjG3AdxbFgUABakvdWo41MWngZawfcry/BkmNw==");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Username",
                keyValue: "Dionysios.Lytras",
                columns: new[] { "BirthDate", "PasswordHash" },
                values: new object[] { new DateOnly(1988, 12, 10), "AQAAAAIAAYagAAAAEGZDk/+8Z681V722/J7OsQal2a5KPa3tq6LkeuojBMqXldKsP4XXkN9O9J8paj4xGQ==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Username",
                keyValue: "Dionysios_Deli12",
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEMmc2XCsG6HT0ebdWhup4CjOvdu05DT3+9/F8XoUxfDc7mEzmlVOW0R1tRslB8le1g==");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Username",
                keyValue: "Eleytherios.Eleytherioy",
                columns: new[] { "BirthDate", "PasswordHash" },
                values: new object[] { new DateOnly(1996, 2, 27), "AQAAAAIAAYagAAAAELWCxxQ+/0wkYpPJBAYp5svTKP1uFHIWlcnVEdTmeUKPOHc2NZ7x6LsL2KoQ5GgMeg==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Username",
                keyValue: "Eleytherios_Didaskaloy",
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEIXk2HT7biCzgTb70jnMok1pCRPYASxzDsudKj6Csv0yteE3IjP06o424YAR1feIJQ==");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Username",
                keyValue: "Emmanoyil.Georgiadis",
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEP9dbHyDwRADGe/xtMdDtQvF3hHCCNI++mdxRGu8a1RRbH0CeR/GsafanrUXEHcHeQ==");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Username",
                keyValue: "Emmanoyil_Aleksioy5",
                columns: new[] { "BirthDate", "PasswordHash" },
                values: new object[] { new DateOnly(1996, 7, 26), "AQAAAAIAAYagAAAAEIhQD5SUSQRHp3S7pqNjOJ6+/VpEyd6WjB25PM8PmpL9WMjipkbsz1kRqB0w4rdfUw==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Username",
                keyValue: "Emmanoyil_Koyndoyros",
                columns: new[] { "BirthDate", "PasswordHash" },
                values: new object[] { new DateOnly(2000, 11, 29), "AQAAAAIAAYagAAAAEP0i3qt5UKbm0/roLfOH9dVKykio2/i8dXnmg3zVQLFaYt3rGhZ8qiOK6H4L6crklg==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Username",
                keyValue: "Emmanoyil_Maris67",
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEIPVodv1TBfI0xD9fPfzvhRb4rhps4ivS3frOTrtppqMBE4Wi+g/1XVAP2jGN/ILUw==");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Username",
                keyValue: "Eyaggelos_Koromilas73",
                columns: new[] { "BirthDate", "PasswordHash" },
                values: new object[] { new DateOnly(2002, 12, 9), "AQAAAAIAAYagAAAAEKtTgPe7t6mIBSBAxRsSNa6ARwuJCBI5zN/cmS6ZnWokw4pwM1SNos65vtniXOmWWg==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Username",
                keyValue: "Eystathios.Boyrdoympas",
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEJ/K+QyjwnBkvTgMhRA5XXg55wDTrlq4gGHquu4jX+YICl5lNYCwYS48wCJudnJc6A==");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Username",
                keyValue: "Eystathios17",
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAELpnTws4ynONC2BxTopmWTvZDEq6mTkb2kr+zOxgR7e3HWXWv9qMOT/o01uj2El4HQ==");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Username",
                keyValue: "Eystathios29",
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEDZrBx0x35hjl0T+m54CoGTPm6jTfAOXJoR/QFxreNZOjKBkgsCqQv2CK8JIMHsD5w==");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Username",
                keyValue: "Eystathios57",
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEPnCWElLqui6g9PHYEqRSc8Ryf3MheamMhJrM5113TAV1LQSCj48H+o6HP2v/iDUXA==");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Username",
                keyValue: "Eystathios_Avramidis41",
                columns: new[] { "BirthDate", "PasswordHash" },
                values: new object[] { new DateOnly(2005, 2, 20), "AQAAAAIAAYagAAAAEGKTgMtwkzcqgK/ZqGglSV8iDSoBa1IX0mUVorC8I3HIm9m+wOiYlW28nAk5jZHCYw==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Username",
                keyValue: "Fotios.Andreoy51",
                columns: new[] { "BirthDate", "PasswordHash" },
                values: new object[] { new DateOnly(2004, 2, 10), "AQAAAAIAAYagAAAAEAzCTiX21jWLHgt1QaNljJz7weFMM78OjGOIEoKLZkYFD9gMKJc2ohE8wEI797LS5g==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Username",
                keyValue: "Fotios90",
                columns: new[] { "BirthDate", "PasswordHash" },
                values: new object[] { new DateOnly(2005, 10, 19), "AQAAAAIAAYagAAAAEPMbmmCa0x0kxoR4B8WxOJZ0mruNZ5TfOYtmI9fC1epAtZLvERkPyU/3nUO1p2xRnw==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Username",
                keyValue: "Fotios_Karavias7",
                columns: new[] { "BirthDate", "PasswordHash" },
                values: new object[] { new DateOnly(1993, 8, 15), "AQAAAAIAAYagAAAAEG3Kp5mRoG8sPBgaXMyIYvwxMYoewqAlzfTe3KlnrILnoOQAAK1xJkIfEMcU8cY8Fg==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Username",
                keyValue: "Georgios.Eytaksias",
                columns: new[] { "BirthDate", "PasswordHash" },
                values: new object[] { new DateOnly(1992, 9, 30), "AQAAAAIAAYagAAAAEEdftLnQhQ7xlkbvf/cXFUslLvu7onkrPjq4IFnV9G4GvhBcBEddDjCq7QR6YUUj4A==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Username",
                keyValue: "Georgios2",
                columns: new[] { "BirthDate", "PasswordHash" },
                values: new object[] { new DateOnly(2003, 2, 10), "AQAAAAIAAYagAAAAEAMbkR5SWGvtYK6LJ1YSKN+KdoePmCA1goIvp8+ITU+cqnM1JyuFeQokw8f4zkVwBg==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Username",
                keyValue: "Georgios45",
                columns: new[] { "BirthDate", "PasswordHash" },
                values: new object[] { new DateOnly(2003, 11, 12), "AQAAAAIAAYagAAAAEKqc+VJd9Bt3S5iABTzAu9JUR5zmHpHWyGCgKBJVvXXMFL4P4/SDOH6ied9f41rDsw==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Username",
                keyValue: "Georgios79",
                columns: new[] { "BirthDate", "PasswordHash" },
                values: new object[] { new DateOnly(1987, 9, 14), "AQAAAAIAAYagAAAAECUL0x0WJN4/Xw9lb0Zl4KsjgGqNlPQs0PJAo4x5sq88ZO/90QwDvzsgtuCeWpmJVg==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Username",
                keyValue: "Georgios_Bilaetis20",
                columns: new[] { "BirthDate", "PasswordHash" },
                values: new object[] { new DateOnly(1988, 4, 15), "AQAAAAIAAYagAAAAEPY8zJCAHT0/XvuW1SH12YXlcVI4CpLAPMuEP200/yAopykRBfyzPd89CoCm+ZG96Q==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Username",
                keyValue: "Grigorios.Boylgaris",
                columns: new[] { "BirthDate", "PasswordHash" },
                values: new object[] { new DateOnly(1999, 3, 23), "AQAAAAIAAYagAAAAEP8XpzuKWpkdoQcOYoybojYRRmt/d61DKftDfaLsRXuubwxrP9mSQmU5w+fJFde87w==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Username",
                keyValue: "Grigorios_Kontoleon41",
                columns: new[] { "BirthDate", "PasswordHash" },
                values: new object[] { new DateOnly(1992, 1, 18), "AQAAAAIAAYagAAAAEKHDCnXUO8sVzt+gg74FQD1HX9gCv0eQ1GUZ7V/HG0bnyJn2+w1ao4LF02lb7jcICw==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Username",
                keyValue: "Ilias.Metaksas74",
                columns: new[] { "BirthDate", "PasswordHash" },
                values: new object[] { new DateOnly(2004, 1, 19), "AQAAAAIAAYagAAAAEBjB3miLqNCH6TOp/Agju95Wme7e0YOOEBDUFw/5Uz9MMfDq8e5LSyeywYH9MYErRQ==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Username",
                keyValue: "Ilias.Zafeiropoylos86",
                columns: new[] { "BirthDate", "PasswordHash" },
                values: new object[] { new DateOnly(1989, 5, 10), "AQAAAAIAAYagAAAAEJkbB2vq4UlhvNQk+CRQ12u5HXdwAG996vgO8r1rjX38G3J87D5E26B/RO6w6Ovppg==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Username",
                keyValue: "Ilias56",
                columns: new[] { "BirthDate", "PasswordHash" },
                values: new object[] { new DateOnly(1987, 6, 18), "AQAAAAIAAYagAAAAEHlaqWEbpw50NywEsclRqedbKaWwBbBUmQR6mUurFs/kvbp6gbaGczreIOVdHNCjQQ==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Username",
                keyValue: "Ilias_Bamvas22",
                columns: new[] { "BirthDate", "PasswordHash" },
                values: new object[] { new DateOnly(2003, 1, 16), "AQAAAAIAAYagAAAAEGCu+eeAaTAVvDf7A+vio9x7noG+QNOiJzZ2tqW5DvKF6/4JbYZwxsNWpcX6vqqyTw==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Username",
                keyValue: "Ioannis.Aygerinoseponymo0",
                columns: new[] { "BirthDate", "PasswordHash" },
                values: new object[] { new DateOnly(2000, 9, 20), "AQAAAAIAAYagAAAAEJr+qnfi3kBCWB0N16Y68QyVxeGzDcGy/3L99kV1dQDKNsJA+Jzcf8IehmULPfRlMQ==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Username",
                keyValue: "Ioannis.Zappas99",
                columns: new[] { "BirthDate", "PasswordHash" },
                values: new object[] { new DateOnly(1993, 3, 6), "AQAAAAIAAYagAAAAEE9Vq60xM/zix6MZZjXtMYTly20hRMxgqImU6zuPGB+LzZQTShWu1Pr1Z1jUQwvfKA==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Username",
                keyValue: "Ioannis28",
                columns: new[] { "BirthDate", "PasswordHash" },
                values: new object[] { new DateOnly(1993, 9, 20), "AQAAAAIAAYagAAAAEE6xmKr1QSdTS9T/9F8V/Z/N7TkchNs89cNnLP9c7HPL0PHS/nxG8jKFkoJP93IAbg==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Username",
                keyValue: "Ioannis_Basilopoylos",
                columns: new[] { "BirthDate", "PasswordHash" },
                values: new object[] { new DateOnly(1998, 5, 18), "AQAAAAIAAYagAAAAEF48pukFOL+TSMwnhja6D050Gz+MN3ux8wiDglmhEnNQRH3T4IlRHzAW3QlZhgjCpA==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Username",
                keyValue: "Kostas43",
                columns: new[] { "BirthDate", "PasswordHash" },
                values: new object[] { new DateOnly(2005, 3, 25), "AQAAAAIAAYagAAAAEL7vLRQtFXSUrk/jHjnCq7s3eWT8yMvHw26/FPvOQEkewOFzih86HUaTRZJW3NhScQ==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Username",
                keyValue: "Kostas92",
                columns: new[] { "BirthDate", "PasswordHash" },
                values: new object[] { new DateOnly(1987, 6, 8), "AQAAAAIAAYagAAAAEMvqbbGRTlgDibajJlNxxGQw4b6YWKFebi75ZcrTk1PXZWVkk4viS9giVNvZ3O7XiQ==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Username",
                keyValue: "Kostas_Byzantios65",
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEEk5HEW2AdNbFc40WmC9hyVgQE9IC+GYD6NCytp2JkJaxCAEYp/QQchK/yP7zQ4MPA==");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Username",
                keyValue: "Mixail.Bergas85",
                columns: new[] { "BirthDate", "PasswordHash" },
                values: new object[] { new DateOnly(1985, 11, 3), "AQAAAAIAAYagAAAAEArtR1s0vKwZ/AQlmbkmD67zctkL4k5TGJ5ll+iTRrAiqu+58DczBGNlvdlWRORzBA==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Username",
                keyValue: "Mixail.Ioannoy",
                columns: new[] { "BirthDate", "PasswordHash" },
                values: new object[] { new DateOnly(1987, 3, 24), "AQAAAAIAAYagAAAAEMJMq2dyHUFx3zOzuHDiaXgt/KOqTnBE3GlQDYXfymhpUOL3Xwey8iCEip3Ne1OAZw==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Username",
                keyValue: "Mixail90",
                columns: new[] { "BirthDate", "PasswordHash" },
                values: new object[] { new DateOnly(1995, 5, 27), "AQAAAAIAAYagAAAAEBjfooUw/FCIispnxhor+HIvOCu2EFRFEVc9EPqnllMd+ZMNdTyuMic/BqLA3uaj1Q==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Username",
                keyValue: "Nikolaos_Boyrdoympas15",
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEKW1a1MX0Dg/D0pVvG6qlZ0meYT5X3QKkNRp8dbz3hGEAEX9YWEtj6TZ5vbXuuisBg==");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Username",
                keyValue: "Paraskeyas.Anagnostakis",
                columns: new[] { "BirthDate", "PasswordHash" },
                values: new object[] { new DateOnly(2001, 11, 24), "AQAAAAIAAYagAAAAEA5rFCOXYAdKjK70JddQ8yq6G9UIWZ6h390IRjs3VroJSH+FA/rciNDY5TQbeOKaJA==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Username",
                keyValue: "Paraskeyas_THeodoridis89",
                columns: new[] { "BirthDate", "PasswordHash" },
                values: new object[] { new DateOnly(2003, 4, 26), "AQAAAAIAAYagAAAAENDxgHO+IbPwQmZJKdoovnWAFJ3iMFfhBvZdsd4d3YdWUIQZ62dZouHe/7QRLirfGA==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Username",
                keyValue: "Paylos.Giagkos",
                columns: new[] { "BirthDate", "PasswordHash" },
                values: new object[] { new DateOnly(1993, 10, 26), "AQAAAAIAAYagAAAAEO/dfgFoY/3+9cQvRloxT3srVaXL2U3M10yIDle2Z13wH5rpFBmseH983VWHtv27ag==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Username",
                keyValue: "Paylos.Koyndoyros",
                columns: new[] { "BirthDate", "PasswordHash" },
                values: new object[] { new DateOnly(1988, 10, 9), "AQAAAAIAAYagAAAAEDWTR929+JB3kB2dFXr7tMSqPO9sHnjr9mFRmuWuyNNHgym9UHmte82UC+icj435Og==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Username",
                keyValue: "Paylos18",
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEMRpU8lPoJ+piZZVTQ6eju1LLikeggZtv5Yk/i82JN6QP6SDlOqvzUZ4ZLaU3QFvbg==");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Username",
                keyValue: "Paylos48",
                columns: new[] { "BirthDate", "PasswordHash" },
                values: new object[] { new DateOnly(1995, 3, 6), "AQAAAAIAAYagAAAAEO9b0n0Bh1c7Z4fakB2qi7V+myOkW6megsjoKWM35fLLExQ+ZdxvSQDzEvbVmqQ53w==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Username",
                keyValue: "Paylos_Kalyvas76",
                columns: new[] { "BirthDate", "PasswordHash" },
                values: new object[] { new DateOnly(2003, 11, 14), "AQAAAAIAAYagAAAAELRptoxvS2B7qAD5hjrt1zfXCy47EGeZu6gEYe8L4XW5fvtqi6VUoIuOBQuu9jkLnA==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Username",
                keyValue: "Petros.Blavianos51",
                columns: new[] { "BirthDate", "PasswordHash" },
                values: new object[] { new DateOnly(2004, 2, 15), "AQAAAAIAAYagAAAAEBLtngSLPWXaZf6s8hjmaUKt13+XEfaM3lCbJhqMwhr/8l69CY10SIzEoaWUp2bMPA==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Username",
                keyValue: "Petros50",
                columns: new[] { "BirthDate", "PasswordHash" },
                values: new object[] { new DateOnly(1992, 11, 21), "AQAAAAIAAYagAAAAEIiSsSO/ki2p7nbuBkUkxXrfXwAUs69CpBlynoAPdPybEhPtEL/9/gbioTEkrzvQgg==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Username",
                keyValue: "Petros77",
                columns: new[] { "BirthDate", "PasswordHash" },
                values: new object[] { new DateOnly(1996, 9, 15), "AQAAAAIAAYagAAAAEMmTTTnWT1pPt77CKw4c6NaSPY4KFl9aMwPDUMwdrb5TMqUiwNHfusiAyd+mHYF2fw==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Username",
                keyValue: "Sotirios.Germanos87",
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEIZkA1P0gMeU1VLlDJciCpLHdLPMphjF36R5sQ/Ifq88cpR1+u9BmGUfvMpfUnj1BA==");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Username",
                keyValue: "Sotirios.Kalogiannis43",
                columns: new[] { "BirthDate", "PasswordHash" },
                values: new object[] { new DateOnly(1994, 1, 20), "AQAAAAIAAYagAAAAEM7E7YWhKru1pwjiz/Z7yakPXOEs83JhW1X0axLzkFLfhqIEZVC7olF4o+ezgDJ2zQ==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Username",
                keyValue: "Sotirios.THeodosioy",
                columns: new[] { "BirthDate", "PasswordHash" },
                values: new object[] { new DateOnly(2005, 10, 2), "AQAAAAIAAYagAAAAEP9B9PciDkUYidXSI3+izbznhe8jt9lyThhJC+g313n6WDcOcVJsOJ2zSvhKaSCxDQ==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Username",
                keyValue: "Sotirios_Zervos",
                columns: new[] { "BirthDate", "PasswordHash" },
                values: new object[] { new DateOnly(1998, 12, 30), "AQAAAAIAAYagAAAAEPqBRln+Zi226Tz9W2uK4ou4VmSujpjzIoD9EM/7DtdeTFAmDG4INpdGzKxYhyIJuA==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Username",
                keyValue: "Spyros97",
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEDCbYibbbQ4eRu0LxBxIQqs4ZGP3cqv93Xc1AWCMHBF8KgWcATIKOcgNKuXznL3mDQ==");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Username",
                keyValue: "Spyros_Anastasiadis",
                columns: new[] { "BirthDate", "PasswordHash" },
                values: new object[] { new DateOnly(1993, 2, 12), "AQAAAAIAAYagAAAAEOi2BUI4j7zkdCN7kHzdzG/7n+uI+WJeJI0mczrJcw/jc0FWBSXgaKo2Yy28T2QMYQ==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Username",
                keyValue: "Stayros.Koronaios",
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAELIUMq/0Tcd7scfqGNreKCR5QBPDWt6UORpBCMngswieKU+g0IPNwhL+ZAzxJY0zzw==");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Username",
                keyValue: "Stayros_Bergas29",
                columns: new[] { "BirthDate", "PasswordHash" },
                values: new object[] { new DateOnly(1988, 11, 2), "AQAAAAIAAYagAAAAEEAgBcrFiFg6FBlaRVB82x2HRhKfSW1poLNwZ5QiknNUi7pzmnP17SWd5RrDgeVhiA==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Username",
                keyValue: "Stefanos.Loypis27",
                columns: new[] { "BirthDate", "PasswordHash" },
                values: new object[] { new DateOnly(1994, 2, 11), "AQAAAAIAAYagAAAAEL5ez7Ni6dlY253KyMCNjJbFAAgY1PETkLn99VijB/w5F+a85WW6JhPnmiYtpDx0Yw==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Username",
                keyValue: "Stefanos.Nikolaidis21",
                columns: new[] { "BirthDate", "PasswordHash" },
                values: new object[] { new DateOnly(1993, 6, 20), "AQAAAAIAAYagAAAAEPdl8WLEvg7zzDqx911V5073TLpWcZ3Y0oRmM2iMZchPxyHtZwUEmzwgsrwvNATzSw==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Username",
                keyValue: "Stylianos.Basileiadis",
                columns: new[] { "BirthDate", "PasswordHash" },
                values: new object[] { new DateOnly(1991, 4, 7), "AQAAAAIAAYagAAAAEOVR+dTf5r5zT1tokIyeJkarNuCvnhEjZb7dpDHKpJqUaZEyxvcSGDlW7KhrrpVvaw==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Username",
                keyValue: "Stylianos.Mitzoy",
                columns: new[] { "BirthDate", "PasswordHash" },
                values: new object[] { new DateOnly(1992, 4, 18), "AQAAAAIAAYagAAAAEBUqG6tAWQ4OQbLAVv15Q0iWySseyLQ1K5IqcW9IsVQF9vCx8ILL0h6C6srqgVegeg==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Username",
                keyValue: "THeodoros.Basileiadis2",
                columns: new[] { "BirthDate", "PasswordHash" },
                values: new object[] { new DateOnly(1994, 12, 7), "AQAAAAIAAYagAAAAEKaSkc3g2HZpPvrKuLz7xzHcBzCNzVF4raQvprU6UIHkbPIq93OreiNLvgK3MvzFiQ==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Username",
                keyValue: "THeodoros.Zafeiropoylos96",
                columns: new[] { "BirthDate", "PasswordHash" },
                values: new object[] { new DateOnly(2004, 5, 29), "AQAAAAIAAYagAAAAEMb32d2s1NoHuerINXQe/uH6xEs0iPvE/M14PSJ7AH0+mKblyNn+jy3vXNDa5qKJqQ==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Username",
                keyValue: "THeodoros68",
                columns: new[] { "BirthDate", "PasswordHash" },
                values: new object[] { new DateOnly(1997, 10, 15), "AQAAAAIAAYagAAAAEKj99KS6bmTA5WJx4nz3qYhxaSGvHzQU2MaeATfOfC0PaJDjGUcUjCv2X4UoLovXvA==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Username",
                keyValue: "Xaralampos43",
                columns: new[] { "BirthDate", "PasswordHash" },
                values: new object[] { new DateOnly(1995, 11, 6), "AQAAAAIAAYagAAAAEHIEYBTAxL/+BvptviJtVkPoQq/uJ89qMRbfJJdpQI7FAzzLzOj0zkdU/Rh8TWwFNQ==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Username",
                keyValue: "Xaralampos68",
                columns: new[] { "BirthDate", "PasswordHash" },
                values: new object[] { new DateOnly(1994, 8, 24), "AQAAAAIAAYagAAAAEO9sfGkHXajFB81GpzayLEbIfmVItXBrYxP8IIxKj4ZkpdqANW9Gx9/yEdt6yxltdA==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Username",
                keyValue: "Xaralampos74",
                columns: new[] { "BirthDate", "PasswordHash" },
                values: new object[] { new DateOnly(1997, 12, 26), "AQAAAAIAAYagAAAAEGxoe2JRfxBdv0skSi+86FzAaVgcz4kd0M7oIzzM/4GIdlOvLkHymWREWfRh9RcvtA==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Username",
                keyValue: "Xristos.Aggelopoylos",
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEDIDMESbMj8HXuomJVgaeKV5mN678XixHRrQCmM2XSqKcUwxNMEZtvtmrJH0tq4bVA==");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Username",
                keyValue: "Xristos80",
                columns: new[] { "BirthDate", "PasswordHash" },
                values: new object[] { new DateOnly(1999, 11, 13), "AQAAAAIAAYagAAAAECGTFh6e7YVUpcjYP9CzD8q5NFsEbA7aITUkdgCWlY4dlQKJ82dcwstSi5qj582+HQ==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Username",
                keyValue: "Xristos85",
                columns: new[] { "BirthDate", "PasswordHash" },
                values: new object[] { new DateOnly(2000, 5, 27), "AQAAAAIAAYagAAAAEOWOK7C/cZ7C8PUaQ0J2HZx2nXWVeKRiQvc/6wH8vM4E9yng09YKiKUy9N4qmkDVGw==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Username",
                keyValue: "oktato",
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEAaOrVHD0IhcTfGfENPdChbVXkI4TRUJISpUNkU6KNwZ1/fP+h+5gm8FhflP6a2stQ==");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Username",
                keyValue: "tanulo",
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEGlERAvJciHbpbffnftlRRLvRAjfYzhAtzVXltSPwdgPT9BA7/LqD5x/fyX3B9kpGw==");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "Credits",
                table: "Courses",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldComment: "Tárgy kreditszáma");

            migrationBuilder.AlterColumn<int>(
                name: "Capacity",
                table: "Courses",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldComment: "Maximum kapacitás");

            migrationBuilder.AlterColumn<string>(
                name: "Semester",
                table: "Courses",
                type: "varchar(6)",
                maxLength: 6,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(6)",
                oldMaxLength: 6,
                oldComment: "Aktuális félév")
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "CourseCode",
                table: "Courses",
                type: "varchar(15)",
                maxLength: 15,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(15)",
                oldMaxLength: 15,
                oldComment: "Kurzus kódja")
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.UpdateData(
                table: "DegreeParticipations",
                keyColumns: new[] { "DegreeName", "Username" },
                keyValues: new object[] { "Games & Toys (297)", "Aggelos.Aggelidoy35" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateOnly(2014, 7, 11), new DateOnly(2011, 7, 11) });

            migrationBuilder.UpdateData(
                table: "DegreeParticipations",
                keyColumns: new[] { "DegreeName", "Username" },
                keyValues: new object[] { "Electronics (266)", "Aggelos6" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateOnly(2020, 11, 20), new DateOnly(2017, 11, 20) });

            migrationBuilder.UpdateData(
                table: "DegreeParticipations",
                keyColumns: new[] { "DegreeName", "Username" },
                keyValues: new object[] { "Games & Toys (297)", "Aggelos87" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateOnly(2023, 3, 18), new DateOnly(2020, 3, 18) });

            migrationBuilder.UpdateData(
                table: "DegreeParticipations",
                keyColumns: new[] { "DegreeName", "Username" },
                keyValues: new object[] { "Toys (259)", "Aggelos_Georgiadis30" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateOnly(2025, 12, 24), new DateOnly(2022, 12, 24) });

            migrationBuilder.UpdateData(
                table: "DegreeParticipations",
                keyColumns: new[] { "DegreeName", "Username" },
                keyValues: new object[] { "Books (290)", "Aleksandros.Zervos61" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateOnly(2018, 5, 4), new DateOnly(2015, 5, 4) });

            migrationBuilder.UpdateData(
                table: "DegreeParticipations",
                keyColumns: new[] { "DegreeName", "Username" },
                keyValues: new object[] { "Baby (283)", "Anastasios_Bilaetis84" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateOnly(2009, 12, 10), new DateOnly(2006, 12, 10) });

            migrationBuilder.UpdateData(
                table: "DegreeParticipations",
                keyColumns: new[] { "DegreeName", "Username" },
                keyValues: new object[] { "Music, Movies & Industrial (280)", "Anastasios_Nikolakos52" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateOnly(2024, 3, 9), new DateOnly(2021, 3, 9) });

            migrationBuilder.UpdateData(
                table: "DegreeParticipations",
                keyColumns: new[] { "DegreeName", "Username" },
                keyValues: new object[] { "Health, Toys & Outdoors (255)", "Andreas22" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateOnly(2019, 9, 5), new DateOnly(2016, 9, 5) });

            migrationBuilder.UpdateData(
                table: "DegreeParticipations",
                keyColumns: new[] { "DegreeName", "Username" },
                keyValues: new object[] { "Garden (271)", "Andreas52" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateOnly(2009, 8, 16), new DateOnly(2006, 8, 16) });

            migrationBuilder.UpdateData(
                table: "DegreeParticipations",
                keyColumns: new[] { "DegreeName", "Username" },
                keyValues: new object[] { "Sports, Computers & Electronics (277)", "Andreas95" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateOnly(2021, 4, 15), new DateOnly(2018, 4, 15) });

            migrationBuilder.UpdateData(
                table: "DegreeParticipations",
                keyColumns: new[] { "DegreeName", "Username" },
                keyValues: new object[] { "Shoes & Toys (268)", "Andreas_Bikelidis33" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateOnly(2016, 9, 17), new DateOnly(2013, 9, 17) });

            migrationBuilder.UpdateData(
                table: "DegreeParticipations",
                keyColumns: new[] { "DegreeName", "Username" },
                keyValues: new object[] { "Jewelery, Automotive & Garden (276)", "Antonis.Lytras" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateOnly(2007, 7, 14), new DateOnly(2004, 7, 14) });

            migrationBuilder.UpdateData(
                table: "DegreeParticipations",
                keyColumns: new[] { "DegreeName", "Username" },
                keyValues: new object[] { "Books & Sports (273)", "Antonis4" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateOnly(2018, 6, 3), new DateOnly(2015, 6, 3) });

            migrationBuilder.UpdateData(
                table: "DegreeParticipations",
                keyColumns: new[] { "DegreeName", "Username" },
                keyValues: new object[] { "Electronics (266)", "Antonis_Antonopoylos" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateOnly(2024, 8, 27), new DateOnly(2021, 8, 27) });

            migrationBuilder.UpdateData(
                table: "DegreeParticipations",
                keyColumns: new[] { "DegreeName", "Username" },
                keyValues: new object[] { "Home (264)", "Antonis_Diamantopoylos43" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateOnly(2021, 1, 29), new DateOnly(2018, 1, 29) });

            migrationBuilder.UpdateData(
                table: "DegreeParticipations",
                keyColumns: new[] { "DegreeName", "Username" },
                keyValues: new object[] { "Clothing, Electronics & Jewelery (253)", "Antonis_Melioi26" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateOnly(2009, 8, 26), new DateOnly(2006, 8, 26) });

            migrationBuilder.UpdateData(
                table: "DegreeParticipations",
                keyColumns: new[] { "DegreeName", "Username" },
                keyValues: new object[] { "Kids & Tools (265)", "Apostolos44" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateOnly(2016, 4, 19), new DateOnly(2013, 4, 19) });

            migrationBuilder.UpdateData(
                table: "DegreeParticipations",
                keyColumns: new[] { "DegreeName", "Username" },
                keyValues: new object[] { "Shoes & Kids (281)", "Apostolos75" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateOnly(2022, 9, 8), new DateOnly(2019, 9, 8) });

            migrationBuilder.UpdateData(
                table: "DegreeParticipations",
                keyColumns: new[] { "DegreeName", "Username" },
                keyValues: new object[] { "Electronics & Jewelery (282)", "Apostolos_Daskalopoylos" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateOnly(2012, 8, 9), new DateOnly(2009, 8, 9) });

            migrationBuilder.UpdateData(
                table: "DegreeParticipations",
                keyColumns: new[] { "DegreeName", "Username" },
                keyValues: new object[] { "Automotive, Garden & Beauty (261)", "Aristeidis_Melioi" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateOnly(2024, 1, 7), new DateOnly(2021, 1, 7) });

            migrationBuilder.UpdateData(
                table: "DegreeParticipations",
                keyColumns: new[] { "DegreeName", "Username" },
                keyValues: new object[] { "Sports, Computers & Electronics (277)", "Basilis.Koytalianos17" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateOnly(2024, 6, 26), new DateOnly(2021, 6, 26) });

            migrationBuilder.UpdateData(
                table: "DegreeParticipations",
                keyColumns: new[] { "DegreeName", "Username" },
                keyValues: new object[] { "Electronics (251)", "Basilis_Oikonomoy" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateOnly(2024, 12, 9), new DateOnly(2021, 12, 9) });

            migrationBuilder.UpdateData(
                table: "DegreeParticipations",
                keyColumns: new[] { "DegreeName", "Username" },
                keyValues: new object[] { "Kids & Baby (287)", "Dimitris28" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateOnly(2019, 1, 10), new DateOnly(2016, 1, 10) });

            migrationBuilder.UpdateData(
                table: "DegreeParticipations",
                keyColumns: new[] { "DegreeName", "Username" },
                keyValues: new object[] { "Garden (262)", "Dionysios.Lytras" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateOnly(2009, 12, 11), new DateOnly(2006, 12, 11) });

            migrationBuilder.UpdateData(
                table: "DegreeParticipations",
                keyColumns: new[] { "DegreeName", "Username" },
                keyValues: new object[] { "Electronics (266)", "Eleytherios.Eleytherioy" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateOnly(2017, 2, 28), new DateOnly(2014, 2, 28) });

            migrationBuilder.UpdateData(
                table: "DegreeParticipations",
                keyColumns: new[] { "DegreeName", "Username" },
                keyValues: new object[] { "Electronics (251)", "Emmanoyil_Aleksioy5" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateOnly(2017, 7, 27), new DateOnly(2014, 7, 27) });

            migrationBuilder.UpdateData(
                table: "DegreeParticipations",
                keyColumns: new[] { "DegreeName", "Username" },
                keyValues: new object[] { "Toys (267)", "Emmanoyil_Koyndoyros" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateOnly(2021, 11, 30), new DateOnly(2018, 11, 30) });

            migrationBuilder.UpdateData(
                table: "DegreeParticipations",
                keyColumns: new[] { "DegreeName", "Username" },
                keyValues: new object[] { "Beauty (269)", "Eyaggelos_Koromilas73" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateOnly(2023, 12, 10), new DateOnly(2020, 12, 10) });

            migrationBuilder.UpdateData(
                table: "DegreeParticipations",
                keyColumns: new[] { "DegreeName", "Username" },
                keyValues: new object[] { "Games & Toys (297)", "Eystathios_Avramidis41" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateOnly(2026, 2, 21), new DateOnly(2023, 2, 21) });

            migrationBuilder.UpdateData(
                table: "DegreeParticipations",
                keyColumns: new[] { "DegreeName", "Username" },
                keyValues: new object[] { "Home (264)", "Fotios.Andreoy51" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateOnly(2025, 2, 11), new DateOnly(2022, 2, 11) });

            migrationBuilder.UpdateData(
                table: "DegreeParticipations",
                keyColumns: new[] { "DegreeName", "Username" },
                keyValues: new object[] { "Baby (283)", "Fotios90" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateOnly(2026, 10, 20), new DateOnly(2023, 10, 20) });

            migrationBuilder.UpdateData(
                table: "DegreeParticipations",
                keyColumns: new[] { "DegreeName", "Username" },
                keyValues: new object[] { "Garden (271)", "Fotios_Karavias7" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateOnly(2014, 8, 16), new DateOnly(2011, 8, 16) });

            migrationBuilder.UpdateData(
                table: "DegreeParticipations",
                keyColumns: new[] { "DegreeName", "Username" },
                keyValues: new object[] { "Clothing, Electronics & Jewelery (253)", "Georgios.Eytaksias" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateOnly(2013, 10, 1), new DateOnly(2010, 10, 1) });

            migrationBuilder.UpdateData(
                table: "DegreeParticipations",
                keyColumns: new[] { "DegreeName", "Username" },
                keyValues: new object[] { "Electronics (251)", "Georgios2" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateOnly(2024, 2, 11), new DateOnly(2021, 2, 11) });

            migrationBuilder.UpdateData(
                table: "DegreeParticipations",
                keyColumns: new[] { "DegreeName", "Username" },
                keyValues: new object[] { "Home (264)", "Georgios45" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateOnly(2024, 11, 13), new DateOnly(2021, 11, 13) });

            migrationBuilder.UpdateData(
                table: "DegreeParticipations",
                keyColumns: new[] { "DegreeName", "Username" },
                keyValues: new object[] { "Books (290)", "Georgios79" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateOnly(2008, 9, 15), new DateOnly(2005, 9, 15) });

            migrationBuilder.UpdateData(
                table: "DegreeParticipations",
                keyColumns: new[] { "DegreeName", "Username" },
                keyValues: new object[] { "Kids, Electronics & Movies (288)", "Georgios_Bilaetis20" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateOnly(2009, 4, 16), new DateOnly(2006, 4, 16) });

            migrationBuilder.UpdateData(
                table: "DegreeParticipations",
                keyColumns: new[] { "DegreeName", "Username" },
                keyValues: new object[] { "Baby (283)", "Grigorios.Boylgaris" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateOnly(2020, 3, 24), new DateOnly(2017, 3, 24) });

            migrationBuilder.UpdateData(
                table: "DegreeParticipations",
                keyColumns: new[] { "DegreeName", "Username" },
                keyValues: new object[] { "Baby (283)", "Grigorios_Kontoleon41" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateOnly(2013, 1, 19), new DateOnly(2010, 1, 19) });

            migrationBuilder.UpdateData(
                table: "DegreeParticipations",
                keyColumns: new[] { "DegreeName", "Username" },
                keyValues: new object[] { "Baby (279)", "Ilias.Metaksas74" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateOnly(2025, 1, 20), new DateOnly(2022, 1, 20) });

            migrationBuilder.UpdateData(
                table: "DegreeParticipations",
                keyColumns: new[] { "DegreeName", "Username" },
                keyValues: new object[] { "Kids & Tools (265)", "Ilias.Zafeiropoylos86" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateOnly(2010, 5, 11), new DateOnly(2007, 5, 11) });

            migrationBuilder.UpdateData(
                table: "DegreeParticipations",
                keyColumns: new[] { "DegreeName", "Username" },
                keyValues: new object[] { "Baby (279)", "Ilias56" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateOnly(2008, 6, 19), new DateOnly(2005, 6, 19) });

            migrationBuilder.UpdateData(
                table: "DegreeParticipations",
                keyColumns: new[] { "DegreeName", "Username" },
                keyValues: new object[] { "Garden (262)", "Ilias_Bamvas22" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateOnly(2024, 1, 17), new DateOnly(2021, 1, 17) });

            migrationBuilder.UpdateData(
                table: "DegreeParticipations",
                keyColumns: new[] { "DegreeName", "Username" },
                keyValues: new object[] { "Kids, Electronics & Movies (288)", "Ioannis.Aygerinoseponymo0" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateOnly(2021, 9, 21), new DateOnly(2018, 9, 21) });

            migrationBuilder.UpdateData(
                table: "DegreeParticipations",
                keyColumns: new[] { "DegreeName", "Username" },
                keyValues: new object[] { "Books (257)", "Ioannis.Zappas99" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateOnly(2014, 3, 7), new DateOnly(2011, 3, 7) });

            migrationBuilder.UpdateData(
                table: "DegreeParticipations",
                keyColumns: new[] { "DegreeName", "Username" },
                keyValues: new object[] { "Electronics (266)", "Ioannis28" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateOnly(2014, 9, 21), new DateOnly(2011, 9, 21) });

            migrationBuilder.UpdateData(
                table: "DegreeParticipations",
                keyColumns: new[] { "DegreeName", "Username" },
                keyValues: new object[] { "Garden (260)", "Ioannis_Basilopoylos" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateOnly(2019, 5, 19), new DateOnly(2016, 5, 19) });

            migrationBuilder.UpdateData(
                table: "DegreeParticipations",
                keyColumns: new[] { "DegreeName", "Username" },
                keyValues: new object[] { "Industrial, Toys & Automotive (250)", "Kostas43" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateOnly(2026, 3, 26), new DateOnly(2023, 3, 26) });

            migrationBuilder.UpdateData(
                table: "DegreeParticipations",
                keyColumns: new[] { "DegreeName", "Username" },
                keyValues: new object[] { "Clothing, Electronics & Jewelery (253)", "Kostas92" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateOnly(2008, 6, 9), new DateOnly(2005, 6, 9) });

            migrationBuilder.UpdateData(
                table: "DegreeParticipations",
                keyColumns: new[] { "DegreeName", "Username" },
                keyValues: new object[] { "Toys (259)", "Mixail.Bergas85" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateOnly(2006, 11, 4), new DateOnly(2003, 11, 4) });

            migrationBuilder.UpdateData(
                table: "DegreeParticipations",
                keyColumns: new[] { "DegreeName", "Username" },
                keyValues: new object[] { "Movies & Toys (286)", "Mixail.Ioannoy" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateOnly(2008, 3, 25), new DateOnly(2005, 3, 25) });

            migrationBuilder.UpdateData(
                table: "DegreeParticipations",
                keyColumns: new[] { "DegreeName", "Username" },
                keyValues: new object[] { "Toys (267)", "Mixail90" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateOnly(2016, 5, 28), new DateOnly(2013, 5, 28) });

            migrationBuilder.UpdateData(
                table: "DegreeParticipations",
                keyColumns: new[] { "DegreeName", "Username" },
                keyValues: new object[] { "Baby (283)", "Paraskeyas.Anagnostakis" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateOnly(2022, 11, 25), new DateOnly(2019, 11, 25) });

            migrationBuilder.UpdateData(
                table: "DegreeParticipations",
                keyColumns: new[] { "DegreeName", "Username" },
                keyValues: new object[] { "Books (257)", "Paraskeyas_THeodoridis89" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateOnly(2024, 4, 27), new DateOnly(2021, 4, 27) });

            migrationBuilder.UpdateData(
                table: "DegreeParticipations",
                keyColumns: new[] { "DegreeName", "Username" },
                keyValues: new object[] { "Books (257)", "Paylos.Giagkos" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateOnly(2014, 10, 27), new DateOnly(2011, 10, 27) });

            migrationBuilder.UpdateData(
                table: "DegreeParticipations",
                keyColumns: new[] { "DegreeName", "Username" },
                keyValues: new object[] { "Baby (279)", "Paylos.Koyndoyros" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateOnly(2009, 10, 10), new DateOnly(2006, 10, 10) });

            migrationBuilder.UpdateData(
                table: "DegreeParticipations",
                keyColumns: new[] { "DegreeName", "Username" },
                keyValues: new object[] { "Electronics (251)", "Paylos48" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateOnly(2016, 3, 7), new DateOnly(2013, 3, 7) });

            migrationBuilder.UpdateData(
                table: "DegreeParticipations",
                keyColumns: new[] { "DegreeName", "Username" },
                keyValues: new object[] { "Garden, Kids & Outdoors (289)", "Paylos_Kalyvas76" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateOnly(2024, 11, 15), new DateOnly(2021, 11, 15) });

            migrationBuilder.UpdateData(
                table: "DegreeParticipations",
                keyColumns: new[] { "DegreeName", "Username" },
                keyValues: new object[] { "Health, Toys & Outdoors (255)", "Petros.Blavianos51" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateOnly(2025, 2, 16), new DateOnly(2022, 2, 16) });

            migrationBuilder.UpdateData(
                table: "DegreeParticipations",
                keyColumns: new[] { "DegreeName", "Username" },
                keyValues: new object[] { "Sports (274)", "Petros50" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateOnly(2013, 11, 22), new DateOnly(2010, 11, 22) });

            migrationBuilder.UpdateData(
                table: "DegreeParticipations",
                keyColumns: new[] { "DegreeName", "Username" },
                keyValues: new object[] { "Automotive, Garden & Beauty (261)", "Petros77" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateOnly(2017, 9, 16), new DateOnly(2014, 9, 16) });

            migrationBuilder.UpdateData(
                table: "DegreeParticipations",
                keyColumns: new[] { "DegreeName", "Username" },
                keyValues: new object[] { "Tools, Tools & Tools (284)", "Sotirios.Kalogiannis43" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateOnly(2015, 1, 21), new DateOnly(2012, 1, 21) });

            migrationBuilder.UpdateData(
                table: "DegreeParticipations",
                keyColumns: new[] { "DegreeName", "Username" },
                keyValues: new object[] { "Beauty & Electronics (299)", "Sotirios.THeodosioy" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateOnly(2026, 10, 3), new DateOnly(2023, 10, 3) });

            migrationBuilder.UpdateData(
                table: "DegreeParticipations",
                keyColumns: new[] { "DegreeName", "Username" },
                keyValues: new object[] { "Industrial & Computers (252)", "Sotirios_Zervos" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateOnly(2019, 12, 31), new DateOnly(2016, 12, 31) });

            migrationBuilder.UpdateData(
                table: "DegreeParticipations",
                keyColumns: new[] { "DegreeName", "Username" },
                keyValues: new object[] { "Home, Movies & Shoes (272)", "Spyros_Anastasiadis" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateOnly(2014, 2, 13), new DateOnly(2011, 2, 13) });

            migrationBuilder.UpdateData(
                table: "DegreeParticipations",
                keyColumns: new[] { "DegreeName", "Username" },
                keyValues: new object[] { "Outdoors, Home & Baby (292)", "Stayros_Bergas29" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateOnly(2009, 11, 3), new DateOnly(2006, 11, 3) });

            migrationBuilder.UpdateData(
                table: "DegreeParticipations",
                keyColumns: new[] { "DegreeName", "Username" },
                keyValues: new object[] { "Books & Sports (273)", "Stefanos.Loypis27" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateOnly(2015, 2, 12), new DateOnly(2012, 2, 12) });

            migrationBuilder.UpdateData(
                table: "DegreeParticipations",
                keyColumns: new[] { "DegreeName", "Username" },
                keyValues: new object[] { "Beauty (296)", "Stefanos.Nikolaidis21" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateOnly(2014, 6, 21), new DateOnly(2011, 6, 21) });

            migrationBuilder.UpdateData(
                table: "DegreeParticipations",
                keyColumns: new[] { "DegreeName", "Username" },
                keyValues: new object[] { "Tools, Tools & Tools (284)", "Stylianos.Basileiadis" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateOnly(2012, 4, 8), new DateOnly(2009, 4, 8) });

            migrationBuilder.UpdateData(
                table: "DegreeParticipations",
                keyColumns: new[] { "DegreeName", "Username" },
                keyValues: new object[] { "Toys, Outdoors & Toys (293)", "Stylianos.Mitzoy" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateOnly(2013, 4, 19), new DateOnly(2010, 4, 19) });

            migrationBuilder.UpdateData(
                table: "DegreeParticipations",
                keyColumns: new[] { "DegreeName", "Username" },
                keyValues: new object[] { "Music & Grocery (258)", "THeodoros.Basileiadis2" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateOnly(2015, 12, 8), new DateOnly(2012, 12, 8) });

            migrationBuilder.UpdateData(
                table: "DegreeParticipations",
                keyColumns: new[] { "DegreeName", "Username" },
                keyValues: new object[] { "Toys (259)", "THeodoros.Zafeiropoylos96" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateOnly(2025, 5, 30), new DateOnly(2022, 5, 30) });

            migrationBuilder.UpdateData(
                table: "DegreeParticipations",
                keyColumns: new[] { "DegreeName", "Username" },
                keyValues: new object[] { "Home, Movies & Shoes (272)", "THeodoros68" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateOnly(2018, 10, 16), new DateOnly(2015, 10, 16) });

            migrationBuilder.UpdateData(
                table: "DegreeParticipations",
                keyColumns: new[] { "DegreeName", "Username" },
                keyValues: new object[] { "Industrial & Shoes (270)", "Xaralampos43" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateOnly(2016, 11, 7), new DateOnly(2013, 11, 7) });

            migrationBuilder.UpdateData(
                table: "DegreeParticipations",
                keyColumns: new[] { "DegreeName", "Username" },
                keyValues: new object[] { "Sports, Computers & Electronics (277)", "Xaralampos68" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateOnly(2015, 8, 25), new DateOnly(2012, 8, 25) });

            migrationBuilder.UpdateData(
                table: "DegreeParticipations",
                keyColumns: new[] { "DegreeName", "Username" },
                keyValues: new object[] { "Electronics (251)", "Xaralampos74" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateOnly(2018, 12, 27), new DateOnly(2015, 12, 27) });

            migrationBuilder.UpdateData(
                table: "DegreeParticipations",
                keyColumns: new[] { "DegreeName", "Username" },
                keyValues: new object[] { "Baby, Home & Jewelery (254)", "Xristos80" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateOnly(2020, 11, 14), new DateOnly(2017, 11, 14) });

            migrationBuilder.UpdateData(
                table: "DegreeParticipations",
                keyColumns: new[] { "DegreeName", "Username" },
                keyValues: new object[] { "Electronics (251)", "Xristos85" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateOnly(2021, 5, 28), new DateOnly(2018, 5, 28) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Username",
                keyValue: "Aggelos.Aggelidoy35",
                columns: new[] { "BirthDate", "PasswordHash" },
                values: new object[] { new DateOnly(1993, 7, 11), "AQAAAAIAAYagAAAAEJiYJkB8lZkE0F9xOEkfsA47kIOo9miogUdD/NiwoHbbDdGypuTPvhMWlV/RyMJhbA==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Username",
                keyValue: "Aggelos6",
                columns: new[] { "BirthDate", "PasswordHash" },
                values: new object[] { new DateOnly(1999, 11, 20), "AQAAAAIAAYagAAAAELc0v/rkUEZzOvalAUuB3Ur1cuFfLz0nOF9a7a4yWDQKSqVcy34xBf2VP/qASf/0oQ==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Username",
                keyValue: "Aggelos87",
                columns: new[] { "BirthDate", "PasswordHash" },
                values: new object[] { new DateOnly(2002, 3, 18), "AQAAAAIAAYagAAAAEN8rjzKEoj5Z/Z6H+sHeS9L+G430WIvcBvx0RNL5LPa9KJzrd5MtTgN2+OnEqycjCQ==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Username",
                keyValue: "Aggelos_Georgiadis30",
                columns: new[] { "BirthDate", "PasswordHash" },
                values: new object[] { new DateOnly(2004, 12, 24), "AQAAAAIAAYagAAAAEPTIOm5ULz7hTgftol1YfpJAmnvx2r1QHdnC+Y8acl3v3csK61Geobjkqe0jGTmsmw==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Username",
                keyValue: "Aleksandros.Zervos61",
                columns: new[] { "BirthDate", "PasswordHash" },
                values: new object[] { new DateOnly(1997, 5, 4), "AQAAAAIAAYagAAAAEPgzleRsHtegk9SMghW0UsMBw7BYIy0CG6oPjvIvKmXXkqFEnKQHCFnrWi+pM19zsw==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Username",
                keyValue: "Aleksandros41",
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEI7xVJaPHomfx9SJOuFQ8HHqLmTauwLn/z0Il293FLFHFKD7pOyGwu5GNVjnDlosEg==");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Username",
                keyValue: "Anastasios_Bilaetis84",
                columns: new[] { "BirthDate", "PasswordHash" },
                values: new object[] { new DateOnly(1988, 12, 10), "AQAAAAIAAYagAAAAEAjavjrk8GzBmoZ+vVPso4rSPoFGF2WTpdw/YgnHWgfErX3vEfxVN3u1jwwf4tS8qA==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Username",
                keyValue: "Anastasios_Nikolakos52",
                columns: new[] { "BirthDate", "PasswordHash" },
                values: new object[] { new DateOnly(2003, 3, 9), "AQAAAAIAAYagAAAAELNFb0Wr7G+8n2L/0EEuyOljplKUbgHz5w6G0L/NyH1zNBAY5O9G7Bc822IzqmqOxA==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Username",
                keyValue: "Andreas22",
                columns: new[] { "BirthDate", "PasswordHash" },
                values: new object[] { new DateOnly(1998, 9, 5), "AQAAAAIAAYagAAAAEI+8N4mtkpbpMcDA3qIyRDLfp4YCeZAjJFvzEJc+eL4+eYdoEMetoUKHhNZA1YTiEQ==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Username",
                keyValue: "Andreas52",
                columns: new[] { "BirthDate", "PasswordHash" },
                values: new object[] { new DateOnly(1988, 8, 16), "AQAAAAIAAYagAAAAEKyLbOENjc6a3+Sve4DXqgT05GGAWrxZ3Q6B14ti+B0dRgcIZa6b7ypXJ6k/ZTpoCg==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Username",
                keyValue: "Andreas95",
                columns: new[] { "BirthDate", "PasswordHash" },
                values: new object[] { new DateOnly(2000, 4, 15), "AQAAAAIAAYagAAAAEKsRvniHYgJ0JZNea8Yr0s7rXkZCuv/nbKADm4OfZAocy3Z962zgYH7ZfhO2sumoAA==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Username",
                keyValue: "Andreas_Bikelidis33",
                columns: new[] { "BirthDate", "PasswordHash" },
                values: new object[] { new DateOnly(1995, 9, 17), "AQAAAAIAAYagAAAAEEU+Uvo9pBqMTg5uPdYZJ37nqBqRuphz3nvsVu9+NTus0Orpy6pXSyxH6nFf2yt4Rw==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Username",
                keyValue: "Antonis.Lytras",
                columns: new[] { "BirthDate", "PasswordHash" },
                values: new object[] { new DateOnly(1986, 7, 14), "AQAAAAIAAYagAAAAEKx92ejBlURA4BSe8f0Q9Md5JBTEWwRvVLzFRnOcdP92w/WCBApJJW0L0CWGFbawAA==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Username",
                keyValue: "Antonis4",
                columns: new[] { "BirthDate", "PasswordHash" },
                values: new object[] { new DateOnly(1997, 6, 3), "AQAAAAIAAYagAAAAEFnbZtxLGR0yGG9eOpqadiWGIf5GPvaC+bufAMxldutaGuAI95UeCak3izTgEfIjnA==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Username",
                keyValue: "Antonis_Antonopoylos",
                columns: new[] { "BirthDate", "PasswordHash" },
                values: new object[] { new DateOnly(2003, 8, 27), "AQAAAAIAAYagAAAAEMYsLWVrA57JEyV5Ehhb5qla33tPZei6jmwhfmxkYlPPiUGk4N967gugt3IDXgs6fg==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Username",
                keyValue: "Antonis_Diamantopoylos43",
                columns: new[] { "BirthDate", "PasswordHash" },
                values: new object[] { new DateOnly(2000, 1, 29), "AQAAAAIAAYagAAAAEIxf0sB4C8FvIxsJ1O7yy2PMJV+B8X0bkl8DhAPVDouCaAPn407ReIOk3LkKevcoHA==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Username",
                keyValue: "Antonis_Karamanlis",
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAELlI8dFhWckuadOuDhKk+HvCgL1QI2iqsceCxu54k0EfbQdfaS4JsXUzI3G95bQoIw==");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Username",
                keyValue: "Antonis_Melioi26",
                columns: new[] { "BirthDate", "PasswordHash" },
                values: new object[] { new DateOnly(1988, 8, 26), "AQAAAAIAAYagAAAAENYVMRqtQBqCGYGwSo4fXkJoULBXAfx5HCa4TZsnOQUR8F44e1r3TKXVPD0dOeCNMg==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Username",
                keyValue: "Apostolos.Kypraios",
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEPVUfm5/e/H/7teaTNOnzGWUwSqbpadxSQTKQVk3HWFSQald//PswL9jke0blrIMXA==");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Username",
                keyValue: "Apostolos44",
                columns: new[] { "BirthDate", "PasswordHash" },
                values: new object[] { new DateOnly(1995, 4, 19), "AQAAAAIAAYagAAAAELNELFOg1TiTBDd17vSto0Ww/yvc8KfkfTd26Gq/GPucOuSi182vrsRey4KL++1dwg==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Username",
                keyValue: "Apostolos75",
                columns: new[] { "BirthDate", "PasswordHash" },
                values: new object[] { new DateOnly(2001, 9, 8), "AQAAAAIAAYagAAAAEN/8r8HXa3QjFD718An5s60xQRPO9SrpuMOPVFrepZrAVRQnJQ4oTvSY0IMIRl/a/A==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Username",
                keyValue: "Apostolos_Daskalopoylos",
                columns: new[] { "BirthDate", "PasswordHash" },
                values: new object[] { new DateOnly(1991, 8, 9), "AQAAAAIAAYagAAAAECZhmW6R/GNZzJrtNQTGz/bdcN1vIvG0qPDENTWpeZtQIO+AOFl6kN15XU2KfP59Iw==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Username",
                keyValue: "Aristeidis.Aleksandroy12",
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEDZgmNFla3QTOMfyvCX+994EFOL1EYv2MXdFaEo1NvdSoCMwlV+rAqpQ8jDnv3Mclw==");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Username",
                keyValue: "Aristeidis.Papanikolaoy",
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAENrCwtLp7pagLUxAzedAkD6qOpXGvkZLvh145xEKw1D+ncpgkCs5By4f1jC62a/Zzw==");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Username",
                keyValue: "Aristeidis_Melioi",
                columns: new[] { "BirthDate", "PasswordHash" },
                values: new object[] { new DateOnly(2003, 1, 7), "AQAAAAIAAYagAAAAEOxQo3M3PFDpE2GQ5kbiICe0hJClbORaUmAaDAv1jNRnSo5vbGmk17IZEbjdxaQbLQ==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Username",
                keyValue: "Basilis.Koytalianos17",
                columns: new[] { "BirthDate", "PasswordHash" },
                values: new object[] { new DateOnly(2003, 6, 26), "AQAAAAIAAYagAAAAEGRPE9M44r8xaB4RfO/dliqMqSe4mTKZeF64x4uGiIZ/+Uqwnk77rFQL/5A+SrF0Lg==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Username",
                keyValue: "Basilis61",
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEKybuFnS3aZ9WWg0qXIkWnYrPAmi9RW5aAeFs7c1CoFtbDpte8F7TR42tq1BmDIk1w==");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Username",
                keyValue: "Basilis_Oikonomoy",
                columns: new[] { "BirthDate", "PasswordHash" },
                values: new object[] { new DateOnly(2003, 12, 9), "AQAAAAIAAYagAAAAEPbxVsHBErmsL+xEufk+U3fPmEvY5In+vJUPNhMm0Jiq2Pn7GwnpLajSCXr4dKPMUQ==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Username",
                keyValue: "Dimitris28",
                columns: new[] { "BirthDate", "PasswordHash" },
                values: new object[] { new DateOnly(1998, 1, 10), "AQAAAAIAAYagAAAAECdzcoeEhAhhlAmTT1GThHSqTjg5P4kNFdYYbacXj4prhP3i713gw6U0qpBENWtdig==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Username",
                keyValue: "Dionysios.Anagnostakis",
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEH4IctBZxKAoZ4HPSnvwgT3tjX7+Fa7LzZSBYb9LAzd8U18fX+M/ErCuf6Z4nNOz6Q==");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Username",
                keyValue: "Dionysios.Lytras",
                columns: new[] { "BirthDate", "PasswordHash" },
                values: new object[] { new DateOnly(1988, 12, 11), "AQAAAAIAAYagAAAAEEJmD0NfRXzGFdCPoLrFvkjhR/bag90RmrOY9sOFmltEL1Vqqrpoq+zSSAcYmjzcyg==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Username",
                keyValue: "Dionysios_Deli12",
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEJKiekRcM+6MIGSwU4KuvFxf0gdXAPn4trGaz+3uZ6rhHDk2LeXbL2VaPDHWWCN8hA==");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Username",
                keyValue: "Eleytherios.Eleytherioy",
                columns: new[] { "BirthDate", "PasswordHash" },
                values: new object[] { new DateOnly(1996, 2, 28), "AQAAAAIAAYagAAAAEA3Hr5BjP402noGlG5gzVPOPIwHxZCbDmBMog3BnAs8ozOvVIDpaSg5Qa4QrOT5gLg==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Username",
                keyValue: "Eleytherios_Didaskaloy",
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEP6h/R5i07QHLtTH1OuNHjvl0iu5eODxmy9V0aA2fBI2gUL+cLfK8m9GTpNfFFGZPg==");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Username",
                keyValue: "Emmanoyil.Georgiadis",
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEIc5D4fb0lRn45tF9SKCcN9hXdd3utUYBb9t+E0pvdX5pirXq1+rz/cbVh7Y9fpHgQ==");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Username",
                keyValue: "Emmanoyil_Aleksioy5",
                columns: new[] { "BirthDate", "PasswordHash" },
                values: new object[] { new DateOnly(1996, 7, 27), "AQAAAAIAAYagAAAAEB2j0tYA51VIxwc9cL8cwlGNsqWanK6Cxy9JvJI0s9FoOGbdVfMhHPxu/7d6IdmLxQ==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Username",
                keyValue: "Emmanoyil_Koyndoyros",
                columns: new[] { "BirthDate", "PasswordHash" },
                values: new object[] { new DateOnly(2000, 11, 30), "AQAAAAIAAYagAAAAEOKCZXVOww7iMBEs1xeR8/OOGlfDCcfyQOZh8eEzL1M8XM3M7bNqc+GbxugPHQCFeg==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Username",
                keyValue: "Emmanoyil_Maris67",
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEOwkX+jbdg5WtIN0mAScjY1JVHYoAZ0+8VkYTpblktiORvSZ+KqS7tMJVf8m/r4HhQ==");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Username",
                keyValue: "Eyaggelos_Koromilas73",
                columns: new[] { "BirthDate", "PasswordHash" },
                values: new object[] { new DateOnly(2002, 12, 10), "AQAAAAIAAYagAAAAEDFg9r1RXjfJyvsG4J+u2Yp0ukQPI56QqcvkyQLRoBcvGqd1hni5KmVyiZvesMJUtg==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Username",
                keyValue: "Eystathios.Boyrdoympas",
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEFaElEYLeirPH4DLUaLBHRp3SslbH/iPoyAME/Ko2Aw3gfLcmEJnSP96DOwOg7IQow==");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Username",
                keyValue: "Eystathios17",
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEMthRuHXcgDT0Frvj2kUGgb4MLoTFA5SBKHcv98T9ks/+6uhVR5184qUnowEzUS6eg==");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Username",
                keyValue: "Eystathios29",
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEEPt1XWJElIsZPtSqUtAzlx/ub5IbnGjm7q3lpMcJ6hE2d4mo0M1r9gzPYt3L+ZOqQ==");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Username",
                keyValue: "Eystathios57",
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEDLooUNQ5Y1lJbyIZdUO38aB/3lk7EFqDiNmO8V/uo1VI9Ao1+yuoGvEm4EvqXgK1A==");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Username",
                keyValue: "Eystathios_Avramidis41",
                columns: new[] { "BirthDate", "PasswordHash" },
                values: new object[] { new DateOnly(2005, 2, 21), "AQAAAAIAAYagAAAAEBbx/1LtrwFiUWbFmJngwomdyMzeizjncnO8tI4QaFHTeW7T0ADsmGLxDI04lhgYkw==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Username",
                keyValue: "Fotios.Andreoy51",
                columns: new[] { "BirthDate", "PasswordHash" },
                values: new object[] { new DateOnly(2004, 2, 11), "AQAAAAIAAYagAAAAEB4pNgzQHifyClr7u5kQNBAj94d4Sh3Ry3K98+ThKcKPKtBmes8nhQ/ej3y/lYEEmg==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Username",
                keyValue: "Fotios90",
                columns: new[] { "BirthDate", "PasswordHash" },
                values: new object[] { new DateOnly(2005, 10, 20), "AQAAAAIAAYagAAAAECNSqogErjtiBCMQmfi1opB5u2N/fRncVGD6ClZo8TY6vNNEqvWnD3XTWdXL/zwL6g==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Username",
                keyValue: "Fotios_Karavias7",
                columns: new[] { "BirthDate", "PasswordHash" },
                values: new object[] { new DateOnly(1993, 8, 16), "AQAAAAIAAYagAAAAEODTJeZbejckHW2CwYAPZAXVHVp9zJhSxZZbBvoaITT8Zzo3a1qBiRnFc7f68E0+QQ==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Username",
                keyValue: "Georgios.Eytaksias",
                columns: new[] { "BirthDate", "PasswordHash" },
                values: new object[] { new DateOnly(1992, 10, 1), "AQAAAAIAAYagAAAAEIornQKT4qfe1cEEUsb4d6VthEHY3P/h7Vg01nPgLn3RiqOxrQONivbU0esmLLYxRA==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Username",
                keyValue: "Georgios2",
                columns: new[] { "BirthDate", "PasswordHash" },
                values: new object[] { new DateOnly(2003, 2, 11), "AQAAAAIAAYagAAAAEAVZ5QUe92Es3KAAolQxnQUS/Uz6MdBuXIRB8QOzysg0JBlA3yyu3Hfo5JBFYn8D1w==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Username",
                keyValue: "Georgios45",
                columns: new[] { "BirthDate", "PasswordHash" },
                values: new object[] { new DateOnly(2003, 11, 13), "AQAAAAIAAYagAAAAELTR6IZ2Vmmto7OA+2siJ+T/LD8NkJLdRmAEaIK3K5HF8Mm38daDM7p0BtsnMGrZtQ==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Username",
                keyValue: "Georgios79",
                columns: new[] { "BirthDate", "PasswordHash" },
                values: new object[] { new DateOnly(1987, 9, 15), "AQAAAAIAAYagAAAAEEzSXbhBeOI4CtOzbNxSu9UZvrE1EpZW28i+9QB7VXoW9lJb8ELO46FzEY7pK4yMUQ==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Username",
                keyValue: "Georgios_Bilaetis20",
                columns: new[] { "BirthDate", "PasswordHash" },
                values: new object[] { new DateOnly(1988, 4, 16), "AQAAAAIAAYagAAAAEA6YV9AFo8D6Ctmo74Yin4YjkzwTXeKaSXnkNBIrIKrqpCDNYLHeMoc4nly/u+0BBA==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Username",
                keyValue: "Grigorios.Boylgaris",
                columns: new[] { "BirthDate", "PasswordHash" },
                values: new object[] { new DateOnly(1999, 3, 24), "AQAAAAIAAYagAAAAEFqUoaIwHMRweEMcCM7k3SqXPGMfcTdPrmQ/GGtmfmnCaoQEhDMQHsd3KaO7VBvt+g==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Username",
                keyValue: "Grigorios_Kontoleon41",
                columns: new[] { "BirthDate", "PasswordHash" },
                values: new object[] { new DateOnly(1992, 1, 19), "AQAAAAIAAYagAAAAEKyHGnyfm/gdMxfOdYQUNQJNHhP2BCG6kpgSxc0OAebhzysLpoQ3UC+sWVl5Oghp9w==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Username",
                keyValue: "Ilias.Metaksas74",
                columns: new[] { "BirthDate", "PasswordHash" },
                values: new object[] { new DateOnly(2004, 1, 20), "AQAAAAIAAYagAAAAEKj1oEwrm6rK3I/up4DmwxDzdSJrv9QAzPlD7JcDNIKfit6R4acCVN9gwVCheuB01w==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Username",
                keyValue: "Ilias.Zafeiropoylos86",
                columns: new[] { "BirthDate", "PasswordHash" },
                values: new object[] { new DateOnly(1989, 5, 11), "AQAAAAIAAYagAAAAEBo9YaO9FEuyciX2uV4apODOKhwHdHKlX29j9Hhva53PSqNbGZOqyYuzlMlHDff72Q==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Username",
                keyValue: "Ilias56",
                columns: new[] { "BirthDate", "PasswordHash" },
                values: new object[] { new DateOnly(1987, 6, 19), "AQAAAAIAAYagAAAAEEWNlBAUFq98U51/g+bnkqSvEXu1aVBwdkbzBNt3zw63aeU4UeDfFiPHVdn7d05Gsg==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Username",
                keyValue: "Ilias_Bamvas22",
                columns: new[] { "BirthDate", "PasswordHash" },
                values: new object[] { new DateOnly(2003, 1, 17), "AQAAAAIAAYagAAAAECHCw/DqRPB6Tp56XO5Jj8eEDeD9FXupl5VWmqqeseWQ4NRSsQWCvJJgIHZeFXZqWw==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Username",
                keyValue: "Ioannis.Aygerinoseponymo0",
                columns: new[] { "BirthDate", "PasswordHash" },
                values: new object[] { new DateOnly(2000, 9, 21), "AQAAAAIAAYagAAAAEJSnMbKtBOcmZZzPY8/dYNXs6Uai0irUwZN5X8yy0gXt5y/BP8p32WkWZueXmH6+Wg==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Username",
                keyValue: "Ioannis.Zappas99",
                columns: new[] { "BirthDate", "PasswordHash" },
                values: new object[] { new DateOnly(1993, 3, 7), "AQAAAAIAAYagAAAAEH6pcRxMHd1FXjAOpl/viX5FrUQfJa+TYkkwONAVaZpcU9upOo2voeR2nxQWjtOBkg==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Username",
                keyValue: "Ioannis28",
                columns: new[] { "BirthDate", "PasswordHash" },
                values: new object[] { new DateOnly(1993, 9, 21), "AQAAAAIAAYagAAAAEJr8wVilkyimW6TGt1y5eJqgDVWU/ylBCS9REOSuN1a4XRIgfWh0usku7ZdHhJcUqQ==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Username",
                keyValue: "Ioannis_Basilopoylos",
                columns: new[] { "BirthDate", "PasswordHash" },
                values: new object[] { new DateOnly(1998, 5, 19), "AQAAAAIAAYagAAAAEF2Ge20F9jm6GlUbAg/OZ2R0/X9278WWKmTewcdGMBh0q6uV9dYxqZMOEHmexggANg==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Username",
                keyValue: "Kostas43",
                columns: new[] { "BirthDate", "PasswordHash" },
                values: new object[] { new DateOnly(2005, 3, 26), "AQAAAAIAAYagAAAAEOBFUby45m3o1KojTXdJa6evUnsQGFTTjChqANlR9JF6FRxfa6kDKXeO0XnxIqcgZQ==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Username",
                keyValue: "Kostas92",
                columns: new[] { "BirthDate", "PasswordHash" },
                values: new object[] { new DateOnly(1987, 6, 9), "AQAAAAIAAYagAAAAELzveifOBfV8H2fqvNRTljloC8Jm8FTbXnV5gb0tRtJOdEtb4kvbLwv08mgHtRgHZg==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Username",
                keyValue: "Kostas_Byzantios65",
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAENA4ay5hh9cDtrK9dGkNr0lsG23/yJvmDe57bqufZBWjFkiqS4fTEhYiYBYjNc9wag==");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Username",
                keyValue: "Mixail.Bergas85",
                columns: new[] { "BirthDate", "PasswordHash" },
                values: new object[] { new DateOnly(1985, 11, 4), "AQAAAAIAAYagAAAAELgUW4sCrwv08L7Hg7Am59RhyZzhIPbi4eVQA3rcak0mkGveJaV3hgMiEd4b/+U4gw==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Username",
                keyValue: "Mixail.Ioannoy",
                columns: new[] { "BirthDate", "PasswordHash" },
                values: new object[] { new DateOnly(1987, 3, 25), "AQAAAAIAAYagAAAAEHM4iBbkO/dv5dQVuMMHONOZZ1/+tYk3gP+GvIt3Xnuli2qjFKeKps8pO2wE8HDqmw==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Username",
                keyValue: "Mixail90",
                columns: new[] { "BirthDate", "PasswordHash" },
                values: new object[] { new DateOnly(1995, 5, 28), "AQAAAAIAAYagAAAAENAlw0YZE9Bq50doOIjxPkfJlY6uKXJ+c5rhYehFzXdr3kTjYdPsp+ItQKifXp/iiw==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Username",
                keyValue: "Nikolaos_Boyrdoympas15",
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEAbRtFV9U9cg2hXLFktOVJFguL9h0lZYfnYchU/uAZeTc4cCmWyuMsxqA/gOSIda5A==");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Username",
                keyValue: "Paraskeyas.Anagnostakis",
                columns: new[] { "BirthDate", "PasswordHash" },
                values: new object[] { new DateOnly(2001, 11, 25), "AQAAAAIAAYagAAAAEFxmVE8XiBmQ083BXlx1AIOsuCV8PGG666DDaTsUKqZWv7+BUP+ZzmPBYKAP1jY0iQ==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Username",
                keyValue: "Paraskeyas_THeodoridis89",
                columns: new[] { "BirthDate", "PasswordHash" },
                values: new object[] { new DateOnly(2003, 4, 27), "AQAAAAIAAYagAAAAEAs71NgCR6YISo+CzqcXKpgMY/fl505U8dLSeKLfXL1Y8ngJSQ2usqRuXwmBCP7TGw==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Username",
                keyValue: "Paylos.Giagkos",
                columns: new[] { "BirthDate", "PasswordHash" },
                values: new object[] { new DateOnly(1993, 10, 27), "AQAAAAIAAYagAAAAEHRTgj0chl+mO+6MbavUlyL/Tx0tInb28FwskuE7wdoqFopImAUVQfnmMcVl8xD3ng==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Username",
                keyValue: "Paylos.Koyndoyros",
                columns: new[] { "BirthDate", "PasswordHash" },
                values: new object[] { new DateOnly(1988, 10, 10), "AQAAAAIAAYagAAAAEJggk700C65+rFu/2GlDHT/25FZ2DT4P9iEpK4H223+AanMSyKUuXvIf5TK0+mvIFA==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Username",
                keyValue: "Paylos18",
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEBy73Alj78QDV/HOCCwEiitz2BRRRBdUsHDcHq/O1UdDalTL0vXlZb3dRh28o5Xfow==");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Username",
                keyValue: "Paylos48",
                columns: new[] { "BirthDate", "PasswordHash" },
                values: new object[] { new DateOnly(1995, 3, 7), "AQAAAAIAAYagAAAAEAKi0DsQhR0LxCFMAU1uYQM/OGjDziP/7GE+aklf0pbcVE+PFJ8Bp8fxCb9/84QeAg==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Username",
                keyValue: "Paylos_Kalyvas76",
                columns: new[] { "BirthDate", "PasswordHash" },
                values: new object[] { new DateOnly(2003, 11, 15), "AQAAAAIAAYagAAAAEAlGDJ284NjjSV6P1+cgo+8fx4wNW/PekyVtsgDH5n4aAFD0LUwGOitqtgCvclW1Aw==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Username",
                keyValue: "Petros.Blavianos51",
                columns: new[] { "BirthDate", "PasswordHash" },
                values: new object[] { new DateOnly(2004, 2, 16), "AQAAAAIAAYagAAAAEHYpX1XVs2PY1jbGqtkrBoRqy5qOLIIf0OrLh8Z1l+qGua/0w+W99xD6Ea54wYqzuA==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Username",
                keyValue: "Petros50",
                columns: new[] { "BirthDate", "PasswordHash" },
                values: new object[] { new DateOnly(1992, 11, 22), "AQAAAAIAAYagAAAAELynujC+jdCtMmCTL53hrQOHMX1Bns5zGirXKnHD4SilH/Lux8LaAjUTfi5INAtjPw==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Username",
                keyValue: "Petros77",
                columns: new[] { "BirthDate", "PasswordHash" },
                values: new object[] { new DateOnly(1996, 9, 16), "AQAAAAIAAYagAAAAENfC/e8w5s224SJwQAE8+lDUdwW61jRBK3vwPIyhBsI6EMLp2Y3AfHz0CP41bBi4Xg==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Username",
                keyValue: "Sotirios.Germanos87",
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEN1Ycv3zJPnXxf1PHzYm76gHGhrXMQw3ZUV+YwW3PsnIUP5pPiwsxtOs0XxoCSIH8Q==");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Username",
                keyValue: "Sotirios.Kalogiannis43",
                columns: new[] { "BirthDate", "PasswordHash" },
                values: new object[] { new DateOnly(1994, 1, 21), "AQAAAAIAAYagAAAAEKaHzZ77SHxg3GpRSA+l2Qe4OfhQ7Ou4tTwy/fVlIfJe4QrtjWf6HQFnMt6qAjbHTg==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Username",
                keyValue: "Sotirios.THeodosioy",
                columns: new[] { "BirthDate", "PasswordHash" },
                values: new object[] { new DateOnly(2005, 10, 3), "AQAAAAIAAYagAAAAECxhaLrKqxYPstsHdN1L1a87otxi2Gpx+gsoJjDUCXNw6TS2mnotNBJwrbAr8j3+hQ==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Username",
                keyValue: "Sotirios_Zervos",
                columns: new[] { "BirthDate", "PasswordHash" },
                values: new object[] { new DateOnly(1998, 12, 31), "AQAAAAIAAYagAAAAEE2L1CO4RsOj8T+w4lZi4oMxiW160CfntlZhShvjxHbLd2FsR74jgcp7aGFbocLmlQ==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Username",
                keyValue: "Spyros97",
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEAejv6o5mpyG1SujWh05HalXDF36fK+uxSDkvFXthKeOj6kPREz76pqFmZH6FYQ4vg==");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Username",
                keyValue: "Spyros_Anastasiadis",
                columns: new[] { "BirthDate", "PasswordHash" },
                values: new object[] { new DateOnly(1993, 2, 13), "AQAAAAIAAYagAAAAEKNLUZ0h6kf835fMo6XAI4zNA7qazgRoN3dL+bN689GLBbGzRVtyos8mH+SnLVYDUQ==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Username",
                keyValue: "Stayros.Koronaios",
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEBVGYknXCovdvEu7Sxduwx3tFOYRYij2vuHc9dplo4I3fO3t53LtKS1hEu/89G/D3w==");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Username",
                keyValue: "Stayros_Bergas29",
                columns: new[] { "BirthDate", "PasswordHash" },
                values: new object[] { new DateOnly(1988, 11, 3), "AQAAAAIAAYagAAAAEF2glNS6zblGtTCiFEKznbniHMINZjok6L6dKAHxQNgk5YIyTi5lWKOfuvKmkuK/3w==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Username",
                keyValue: "Stefanos.Loypis27",
                columns: new[] { "BirthDate", "PasswordHash" },
                values: new object[] { new DateOnly(1994, 2, 12), "AQAAAAIAAYagAAAAEMSyh8PH3f4/BnFl57ZLX2YzzY5IjV6LUzdObS9xno7TXCwSgI/I/DsGt/jFG76eBQ==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Username",
                keyValue: "Stefanos.Nikolaidis21",
                columns: new[] { "BirthDate", "PasswordHash" },
                values: new object[] { new DateOnly(1993, 6, 21), "AQAAAAIAAYagAAAAEEYlFxFjp2oJnBcQN8TWsAoa/v6fSDB3s9+C3zQ4EQLgzkmhJ5CNNnrBSi5LFebe6g==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Username",
                keyValue: "Stylianos.Basileiadis",
                columns: new[] { "BirthDate", "PasswordHash" },
                values: new object[] { new DateOnly(1991, 4, 8), "AQAAAAIAAYagAAAAEBdRTIGp3kiwMcacwXSWB+YbdZIQXNz1mpRLXQf7BjH/TMwxYX2JAUxOyapJs9NQQA==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Username",
                keyValue: "Stylianos.Mitzoy",
                columns: new[] { "BirthDate", "PasswordHash" },
                values: new object[] { new DateOnly(1992, 4, 19), "AQAAAAIAAYagAAAAEAfe58KQXiawiFHu4Io9oNP/tLHJjHM8mm8Hg9Crlau0SiB/QjbqUobDk281Q07t5g==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Username",
                keyValue: "THeodoros.Basileiadis2",
                columns: new[] { "BirthDate", "PasswordHash" },
                values: new object[] { new DateOnly(1994, 12, 8), "AQAAAAIAAYagAAAAEEFELta4pFi1idZwivHiU32tqXIuRnpoj4+Un082Mhz8pgxDB5OJpLpW06DMn7fNRQ==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Username",
                keyValue: "THeodoros.Zafeiropoylos96",
                columns: new[] { "BirthDate", "PasswordHash" },
                values: new object[] { new DateOnly(2004, 5, 30), "AQAAAAIAAYagAAAAEMu1K+znggsf1UIMWxddsIQOTAlmuXxxWB7OiDzRPS9J0soOz9cqG+3DSB+g8W77eQ==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Username",
                keyValue: "THeodoros68",
                columns: new[] { "BirthDate", "PasswordHash" },
                values: new object[] { new DateOnly(1997, 10, 16), "AQAAAAIAAYagAAAAEMWgzIlgsQW00Guf18Z4JXlZNYYucnvc8UeTdb5TSxyk5MJrtsZgRi3LdFPgGRVl6Q==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Username",
                keyValue: "Xaralampos43",
                columns: new[] { "BirthDate", "PasswordHash" },
                values: new object[] { new DateOnly(1995, 11, 7), "AQAAAAIAAYagAAAAEBG5KSvuZ37GG6XNfjX06Fb0h9SMwr8mMku+YBc5QRRqAyxqjqF/2R86DADU8DpXJw==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Username",
                keyValue: "Xaralampos68",
                columns: new[] { "BirthDate", "PasswordHash" },
                values: new object[] { new DateOnly(1994, 8, 25), "AQAAAAIAAYagAAAAEHWDN4P9telwOBvAJffudTmOCqIy+wTp6rI4IYTxUz2WrkCCM0pgdbGxyfSbTCiUaA==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Username",
                keyValue: "Xaralampos74",
                columns: new[] { "BirthDate", "PasswordHash" },
                values: new object[] { new DateOnly(1997, 12, 27), "AQAAAAIAAYagAAAAEIqxdHIiJj9+flqB6pktWZa1MbzREGeZBBGH1cOOc2P65raxNK3jZz0qEuMj4wlkWQ==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Username",
                keyValue: "Xristos.Aggelopoylos",
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEKEd+B6yyvFWk8r/a/baAukwLM5NlNS+Th8f/nWTqaqwbvaJSUNcMdLHT9VPXNC+4g==");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Username",
                keyValue: "Xristos80",
                columns: new[] { "BirthDate", "PasswordHash" },
                values: new object[] { new DateOnly(1999, 11, 14), "AQAAAAIAAYagAAAAEHnEiILjVSyxpubl0jUNnHdb22bDtOo4ysmwUCi6yklNU0RJRaBLM65kfWv1LJW02g==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Username",
                keyValue: "Xristos85",
                columns: new[] { "BirthDate", "PasswordHash" },
                values: new object[] { new DateOnly(2000, 5, 28), "AQAAAAIAAYagAAAAEF4r/wgJIn9qWXHEubD1Pfxm4mfa6h94mN7u8ufT4BUD9qhKGKo4a2sChTYY3gSpgA==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Username",
                keyValue: "oktato",
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEDuEdJ/sv0ztd+F3zfKpKRTvk7xZiDg4/Q4Mo+kaBRWvlWeYv3EhEvp3a7pjIofORg==");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Username",
                keyValue: "tanulo",
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEEbJmwHl/JcBAm2U1NhrFQwHL8AJ2uOxKfbbhGhsyN0ebiHGEKOdDZQfaK0NWoUbXA==");
        }
    }
}