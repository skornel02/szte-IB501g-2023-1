using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Skornel02.ETR.Api.Migrations
{
    /// <inheritdoc />
    public partial class RenamingSpreeAndBogus : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Courses_CourseMetadata_CourseCode",
                table: "Courses");

            migrationBuilder.DropForeignKey(
                name: "FK_DegreeParticipations_DegreeTypes_DegreeName",
                table: "DegreeParticipations");

            migrationBuilder.DropTable(
                name: "DegreeTypes");

            migrationBuilder.DropTable(
                name: "UserTypeEntities");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CourseMetadata",
                table: "CourseMetadata");

            migrationBuilder.DeleteData(
                table: "DegreeParticipations",
                keyColumns: new[] { "DegreeName", "Username" },
                keyValues: new object[] { "Informatikus szak", "oktato" });

            migrationBuilder.DeleteData(
                table: "DegreeParticipations",
                keyColumns: new[] { "DegreeName", "Username" },
                keyValues: new object[] { "Informatikus szak", "tanulo" });

            migrationBuilder.RenameTable(
                name: "CourseMetadata",
                newName: "CourseMetadatas");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CourseMetadatas",
                table: "CourseMetadatas",
                column: "CourseCode");

            migrationBuilder.CreateTable(
                name: "Degree",
                columns: table => new
                {
                    Name = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Level = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Degree", x => x.Name);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "UserRoles",
                columns: table => new
                {
                    UserType = table.Column<int>(type: "int", nullable: false),
                    Username = table.Column<string>(type: "varchar(32)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserRoles", x => new { x.UserType, x.Username });
                    table.ForeignKey(
                        name: "FK_UserRoles_Users_Username",
                        column: x => x.Username,
                        principalTable: "Users",
                        principalColumn: "Username",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.InsertData(
                table: "ClassRooms",
                columns: new[] { "Address", "RoomNumber", "RoomType" },
                values: new object[,]
                {
                    { "04171 Κακριδής Drive, West Παναγιώτης, Rwanda", "21", 0 },
                    { "043 Παρασκευάς Tunnel, Port Άγγελοςberg, Finland", "299", 0 },
                    { "04836 Ζαφειρόπουλος Villages, Port Αναστάσιοςtown, Ireland", "153", 0 },
                    { "0534 Ιωάννης Lights, Κομνηνόςfort, Macao", "329", 0 },
                    { "072 Κοσμόπουλος Oval, Μητσοτάκηςstad, Angola", "218", 0 },
                    { "09393 Παπανδρέου Route, Μαλαξόςhaven, Latvia", "50", 0 },
                    { "0941 Μιαούλης Forge, Νικόλαοςburgh, Uruguay", "309", 0 },
                    { "095 Ελευθέριος Meadows, New Παναγιώτηςtown, Svalbard & Jan Mayen Islands", "103", 0 },
                    { "097 Διονύσιος Tunnel, West Αντώνης, Pakistan", "129", 0 },
                    { "10111 Γρηγόριος Fort, Ευστάθιοςhaven, Luxembourg", "39", 0 },
                    { "103 Καλαμογδάρτης Roads, Port Πέτροςville, Guadeloupe", "197", 0 },
                    { "1371 Φώτιος Wells, Φώτιοςview, Serbia", "295", 0 },
                    { "13999 Κορωναίος Mount, Ασπάσιοςburgh, United Arab Emirates", "266", 0 },
                    { "144 Γεννάδιος Road, Lake Λεωνίδαςstad, Taiwan", "339", 0 },
                    { "1449 Πέτρος Underpass, South Αριστείδης, Croatia", "333", 0 },
                    { "20133 Καλλιγάς Tunnel, Παναγιώτηςmouth, Latvia", "18", 0 },
                    { "211 Μαρκόπουλος Gardens, Παπαδάκηςtown, Mauritius", "111", 0 },
                    { "2243 Παπακωνσταντίνου Fields, Βασίληςview, Fiji", "123", 0 },
                    { "229 Παπαφιλίππου Ridges, North Νικόλαος, Pakistan", "318", 0 },
                    { "23758 Αντώνης Inlet, Αθανασίουhaven, Swaziland", "294", 0 },
                    { "23973 Ηλίας Mills, Στυλιανόςshire, Palau", "325", 0 },
                    { "253 Καλλιγάς Port, Ιωαννίδηςhaven, Cook Islands", "72", 0 },
                    { "25392 Ευστάθιος Estates, West Ευάγγελος, Guernsey", "168", 0 },
                    { "256 Αλεξάκης Radial, Δημήτρηςstad, Guernsey", "135", 0 },
                    { "25789 Ελευθερόπουλος Common, Θεόδωροςmouth, Qatar", "209", 0 },
                    { "279 Βασιλικός Prairie, Διδασκάλουberg, Netherlands Antilles", "37", 0 },
                    { "2857 Παύλος Mall, West Ελευθέριοςhaven, Armenia", "141", 0 },
                    { "28710 Διαμαντόπουλος Ramp, Κοντολέωνberg, Jordan", "223", 0 },
                    { "2879 Δραγούμης Dale, South Εμμανουήλ, Switzerland", "206", 0 },
                    { "299 Άγγελος Crescent, Βασιλικόςtown, Suriname", "177", 0 },
                    { "308 Μπουκουβαλαίοι Mews, New Άγγελος, Kyrgyz Republic", "105", 0 },
                    { "314 Μιχαήλ Center, Βέργαςmouth, Armenia", "329", 0 },
                    { "31688 Αλέξανδρος Loop, East Παναγιώτης, Guadeloupe", "136", 0 },
                    { "32635 Αλιβιζάτος Meadows, Lake Ευστάθιοςbury, Mongolia", "184", 0 },
                    { "333 Μήτζου Run, Lake Αθανάσιος, Sierra Leone", "166", 0 },
                    { "33467 Χρήστος Mews, Κουρμούληςshire, Oman", "258", 0 },
                    { "33492 Εμμανουήλ Key, Κούνδουροςland, Denmark", "235", 0 },
                    { "340 Στυλιανός Greens, North Απόστολος, Egypt", "320", 0 },
                    { "34052 Διονύσιος Well, East Ευστάθιος, Liberia", "259", 0 },
                    { "348 Λιακόπουλος Prairie, Γεννάδιοςport, Uruguay", "114", 0 },
                    { "34999 Σωτήριος Rest, South Παναγιώτης, Grenada", "126", 0 },
                    { "360 Βικελίδης Trail, South Νικόλαος, Bulgaria", "79", 0 },
                    { "38124 Αλεξανδρίδης Heights, New Σπύροςburgh, Canada", "263", 0 },
                    { "401 Ανδρέας Camp, Λιάπηςbury, Chad", "21", 0 },
                    { "4879 Λύκος Mills, Στέφανοςstad, Saint Pierre and Miquelon", "79", 0 },
                    { "48878 Αλεξάνδρου Mountain, East Ιωάννηςland, Malaysia", "73", 0 },
                    { "490 Πανταζής Avenue, Ανδρεάδηςshire, Thailand", "300", 0 },
                    { "49082 Αθανάσιος Knoll, Port Απόστολοςborough, Monaco", "161", 0 },
                    { "4954 Παπακώστας Shore, Γεώργιοςbury, Saint Barthelemy", "203", 0 },
                    { "5300 Ανδρέας Cliffs, Βαρνακιώτηςberg, Burundi", "53", 0 },
                    { "54500 Δοξαράς Parkways, New Στέφανος, Jordan", "311", 0 },
                    { "56697 Ευταξίας Lodge, North Λεωνίδαςtown, Venezuela", "290", 0 },
                    { "56800 Ηλίας Inlet, West Νικόλαοςshire, Bahamas", "49", 0 },
                    { "5763 Ευάγγελος Flat, West Χρήστοςville, South Georgia and the South Sandwich Islands", "73", 0 },
                    { "5843 Δημήτρης Forges, North Ευστάθιοςside, Croatia", "127", 0 },
                    { "6026 Διονύσιος Ramp, Καζαντζήςmouth, Cape Verde", "121", 0 },
                    { "60674 Λιάπης Stream, South Λεωνίδαςborough, Afghanistan", "57", 0 },
                    { "6068 Παπάζογλου Plain, North Παναγιώτηςtown, Barbados", "187", 0 },
                    { "619 Αντωνόπουλος Port, New Παύλοςmouth, Cayman Islands", "323", 0 },
                    { "6274 Αρβανίτης Course, Αναγνώστουfort, Senegal", "226", 0 },
                    { "62836 Δάβης Parkway, West Αντώνηςburgh, Mayotte", "295", 0 },
                    { "6314 Αλέξανδρος Plains, Αθανάσιοςfort, Macao", "43", 0 },
                    { "63793 Κεδίκογλου Meadows, Αναστάσιοςfort, Tajikistan", "73", 0 },
                    { "638 Μαυρογένης Fall, New Στυλιανός, Andorra", "306", 0 },
                    { "6430 Ζαχαρίου Heights, Διονύσιοςfurt, Bhutan", "311", 0 },
                    { "646 Σωτήριος Drives, Στυλιανόςland, Uzbekistan", "318", 0 },
                    { "6483 Μαλαξός Centers, Αλαβάνοςburgh, Saint Kitts and Nevis", "239", 0 },
                    { "6616 Καλάρης Terrace, Μαυρογένηςfort, Azerbaijan", "51", 0 },
                    { "66542 Γρηγόριος Creek, Port Αντώνηςborough, Norfolk Island", "165", 0 },
                    { "6713 Παπαστεφάνου Mill, East Κώστας, Italy", "195", 0 },
                    { "67673 Διαμαντόπουλος Hill, New Δημήτρηςburgh, Portugal", "313", 0 },
                    { "68124 Σπύρος Knolls, West Μιχαήλ, Tunisia", "217", 0 },
                    { "685 Αντώνης Way, South Παύλος, Fiji", "279", 0 },
                    { "718 Λεωνίδας Orchard, Γιάνναρηςfurt, Mexico", "157", 0 },
                    { "72392 Παρασκευάς Locks, West Άγγελοςton, Russian Federation", "192", 0 },
                    { "7355 Παρασκευάς Islands, New Πέτρος, Papua New Guinea", "70", 0 },
                    { "753 Δελή Field, Μαλαξόςburgh, Portugal", "184", 0 },
                    { "75519 Σταύρος Fort, Port Παναγιώτηςfort, Peru", "132", 0 },
                    { "75843 Βενιζέλος Lake, North Χαράλαμποςton, Uruguay", "182", 0 },
                    { "77195 Στυλιανός Lake, Παπαδόπουλοςmouth, Bahamas", "291", 0 },
                    { "7978 Αναστάσιος Dam, South Δημήτρηςbury, Saint Pierre and Miquelon", "284", 0 },
                    { "79800 Άγγελος Station, West Ελευθέριος, Lebanon", "144", 0 },
                    { "799 Ελευθερόπουλος Union, South Γεώργιος, Germany", "310", 0 },
                    { "8094 Στέφανος Lock, West Χαράλαμπος, Qatar", "242", 0 },
                    { "821 Διονύσιος Ferry, Διονύσιοςstad, Saint Barthelemy", "198", 0 },
                    { "85225 Αλέξανδρος Summit, Αγγελοπούλουmouth, Palau", "170", 0 },
                    { "859 Διονύσιος Stravenue, New Φώτιοςton, Pitcairn Islands", "24", 0 },
                    { "868 Βικελίδης Underpass, North Παύλος, Japan", "243", 0 },
                    { "882 Άγγελος Turnpike, North Φώτιοςmouth, Luxembourg", "268", 0 },
                    { "882 Ζέρβας Stream, Ευστάθιοςborough, Pitcairn Islands", "55", 0 },
                    { "8821 Παρασκευάς Land, Ανδρέαςville, Sri Lanka", "45", 0 },
                    { "88467 Γαλάνης Street, South Ελευθέριοςmouth, Bouvet Island (Bouvetoya)", "268", 0 },
                    { "88490 Ιωάννης Highway, Ευστάθιοςchester, Tanzania", "138", 0 },
                    { "89875 Ευάγγελος Fields, New Νικόλαος, Niger", "49", 0 },
                    { "8990 Εμμανουήλ Crossroad, New Βασίληςburgh, South Georgia and the South Sandwich Islands", "40", 0 },
                    { "9093 Παπακωνσταντίνου Road, Γούσιοςstad, Nepal", "166", 0 },
                    { "91858 Αγγελοπούλου Throughway, Lake Κώστας, Cote d'Ivoire", "35", 0 },
                    { "94768 Σταύρος Flats, South Ηλίας, New Zealand", "329", 0 },
                    { "9915 Διδασκάλου Neck, South Στέφανος, Serbia", "190", 0 },
                    { "99241 Αλαβάνος Land, Άγγελοςmouth, Dominica", "250", 0 }
                });

            migrationBuilder.InsertData(
                table: "Degree",
                columns: new[] { "Name", "Level" },
                values: new object[,]
                {
                    { "Automotive, Garden & Beauty (261)", 3 },
                    { "Baby (256)", 1 },
                    { "Baby (279)", 0 },
                    { "Baby (283)", 2 },
                    { "Baby, Home & Jewelery (254)", 2 },
                    { "Beauty & Electronics (299)", 3 },
                    { "Beauty (269)", 1 },
                    { "Beauty (296)", 1 },
                    { "Books & Sports (273)", 0 },
                    { "Books (257)", 3 },
                    { "Books (290)", 1 },
                    { "Books, Garden & Garden (275)", 0 },
                    { "Clothing, Electronics & Jewelery (253)", 2 },
                    { "Computers & Health (285)", 0 },
                    { "Computers, Toys & Beauty (278)", 0 },
                    { "Electronics & Jewelery (282)", 0 },
                    { "Electronics (251)", 2 },
                    { "Electronics (266)", 3 },
                    { "Games & Toys (297)", 0 },
                    { "Garden (260)", 2 },
                    { "Garden (262)", 1 },
                    { "Garden (271)", 2 },
                    { "Garden, Kids & Outdoors (289)", 1 },
                    { "Health, Toys & Outdoors (255)", 2 },
                    { "Home (264)", 0 },
                    { "Home, Movies & Shoes (272)", 1 },
                    { "Industrial & Computers (252)", 2 },
                    { "Industrial & Shoes (270)", 2 },
                    { "Industrial, Toys & Automotive (250)", 2 },
                    { "Jewelery, Automotive & Garden (276)", 2 },
                    { "Kids & Baby (287)", 0 },
                    { "Kids & Tools (265)", 0 },
                    { "Kids, Electronics & Movies (288)", 2 },
                    { "Movies & Toys (286)", 2 },
                    { "Movies (294)", 3 },
                    { "Music & Grocery (258)", 0 },
                    { "Music, Movies & Industrial (280)", 3 },
                    { "Mérnökinformatikus Bsc", 1 },
                    { "Outdoors, Home & Baby (292)", 1 },
                    { "Programtervező informatikus Bsc", 1 },
                    { "Shoes & Kids (281)", 1 },
                    { "Shoes & Tools (263)", 1 },
                    { "Shoes & Toys (268)", 1 },
                    { "Sports (274)", 3 },
                    { "Sports, Computers & Electronics (277)", 0 },
                    { "Sports, Kids & Industrial (291)", 2 },
                    { "Tools, Tools & Tools (284)", 1 },
                    { "Toys (259)", 0 },
                    { "Toys (267)", 2 },
                    { "Toys (295)", 3 },
                    { "Toys, Music & Movies (298)", 1 },
                    { "Toys, Outdoors & Toys (293)", 2 }
                });

            migrationBuilder.InsertData(
                table: "UserRoles",
                columns: new[] { "UserType", "Username" },
                values: new object[,]
                {
                    { 0, "tanulo" },
                    { 1, "oktato" }
                });

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

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Username", "BirthDate", "BirthLocation", "Name", "PasswordHash" },
                values: new object[,]
                {
                    { "Aggelos.Aggelidoy35", new DateOnly(1993, 7, 11), "East Στέφανοςborough", "Άγγελος Μιχαηλίδης", "AQAAAAIAAYagAAAAEJiYJkB8lZkE0F9xOEkfsA47kIOo9miogUdD/NiwoHbbDdGypuTPvhMWlV/RyMJhbA==" },
                    { "Aggelos6", new DateOnly(1999, 11, 20), "Μανωλάςton", "Στυλιανός Παπάζογλου", "AQAAAAIAAYagAAAAELc0v/rkUEZzOvalAUuB3Ur1cuFfLz0nOF9a7a4yWDQKSqVcy34xBf2VP/qASf/0oQ==" },
                    { "Aggelos87", new DateOnly(2002, 3, 18), "Άγγελοςtown", "Μιχαήλ Ζαφειρόπουλος", "AQAAAAIAAYagAAAAEN8rjzKEoj5Z/Z6H+sHeS9L+G430WIvcBvx0RNL5LPa9KJzrd5MtTgN2+OnEqycjCQ==" },
                    { "Aggelos_Georgiadis30", new DateOnly(2004, 12, 24), "Βασίληςmouth", "Διονύσιος Αβραμίδης", "AQAAAAIAAYagAAAAEPTIOm5ULz7hTgftol1YfpJAmnvx2r1QHdnC+Y8acl3v3csK61Geobjkqe0jGTmsmw==" },
                    { "Aleksandros.Zervos61", new DateOnly(1997, 5, 4), "Μιχαήλhaven", "Βασίλης Καραβίας", "AQAAAAIAAYagAAAAEPgzleRsHtegk9SMghW0UsMBw7BYIy0CG6oPjvIvKmXXkqFEnKQHCFnrWi+pM19zsw==" },
                    { "Aleksandros41", new DateOnly(1991, 2, 14), "Αντώνηςville", "Παύλος Βαρνακιώτης", "AQAAAAIAAYagAAAAEI7xVJaPHomfx9SJOuFQ8HHqLmTauwLn/z0Il293FLFHFKD7pOyGwu5GNVjnDlosEg==" },
                    { "Anastasios_Bilaetis84", new DateOnly(1988, 12, 10), "East Απόστολος", "Χαράλαμπος Μεσσηνέζης", "AQAAAAIAAYagAAAAEAjavjrk8GzBmoZ+vVPso4rSPoFGF2WTpdw/YgnHWgfErX3vEfxVN3u1jwwf4tS8qA==" },
                    { "Anastasios_Nikolakos52", new DateOnly(2003, 3, 9), "Γρηγόριοςmouth", "Στυλιανός Παπαστεφάνου", "AQAAAAIAAYagAAAAELNFb0Wr7G+8n2L/0EEuyOljplKUbgHz5w6G0L/NyH1zNBAY5O9G7Bc822IzqmqOxA==" },
                    { "Andreas22", new DateOnly(1998, 9, 5), "Port Σταύροςchester", "Ευστάθιος Αγγελόπουλος", "AQAAAAIAAYagAAAAEI+8N4mtkpbpMcDA3qIyRDLfp4YCeZAjJFvzEJc+eL4+eYdoEMetoUKHhNZA1YTiEQ==" },
                    { "Andreas52", new DateOnly(1988, 8, 16), "New Αριστείδης", "Ευάγγελος Κρεστενίτης", "AQAAAAIAAYagAAAAEKyLbOENjc6a3+Sve4DXqgT05GGAWrxZ3Q6B14ti+B0dRgcIZa6b7ypXJ6k/ZTpoCg==" },
                    { "Andreas95", new DateOnly(2000, 4, 15), "Βαρνακιώτηςview", "Μιχαήλ Αναγνωστάκης", "AQAAAAIAAYagAAAAEKsRvniHYgJ0JZNea8Yr0s7rXkZCuv/nbKADm4OfZAocy3Z962zgYH7ZfhO2sumoAA==" },
                    { "Andreas_Bikelidis33", new DateOnly(1995, 9, 17), "North Ευάγγελος", "Απόστολος Λαγός", "AQAAAAIAAYagAAAAEEU+Uvo9pBqMTg5uPdYZJ37nqBqRuphz3nvsVu9+NTus0Orpy6pXSyxH6nFf2yt4Rw==" },
                    { "Antonis.Lytras", new DateOnly(1986, 7, 14), "Βουγιουκλάκηςland", "Ευστάθιος Δελή", "AQAAAAIAAYagAAAAEKx92ejBlURA4BSe8f0Q9Md5JBTEWwRvVLzFRnOcdP92w/WCBApJJW0L0CWGFbawAA==" },
                    { "Antonis4", new DateOnly(1997, 6, 3), "Ευάγγελοςchester", "Αναστάσιος Γιαννόπουλος", "AQAAAAIAAYagAAAAEFnbZtxLGR0yGG9eOpqadiWGIf5GPvaC+bufAMxldutaGuAI95UeCak3izTgEfIjnA==" },
                    { "Antonis_Antonopoylos", new DateOnly(2003, 8, 27), "North Δημήτρης", "Στέφανος Αξιώτης", "AQAAAAIAAYagAAAAEMYsLWVrA57JEyV5Ehhb5qla33tPZei6jmwhfmxkYlPPiUGk4N967gugt3IDXgs6fg==" },
                    { "Antonis_Diamantopoylos43", new DateOnly(2000, 1, 29), "New Ευστάθιοςshire", "Ευστάθιος Γεωργιάδης", "AQAAAAIAAYagAAAAEIxf0sB4C8FvIxsJ1O7yy2PMJV+B8X0bkl8DhAPVDouCaAPn407ReIOk3LkKevcoHA==" },
                    { "Antonis_Karamanlis", new DateOnly(1997, 2, 10), "South Αριστείδης", "Ανδρέας Μιχαηλίδης", "AQAAAAIAAYagAAAAELlI8dFhWckuadOuDhKk+HvCgL1QI2iqsceCxu54k0EfbQdfaS4JsXUzI3G95bQoIw==" },
                    { "Antonis_Melioi26", new DateOnly(1988, 8, 26), "Ανδρέαςtown", "Πέτρος Αλεξίου", "AQAAAAIAAYagAAAAENYVMRqtQBqCGYGwSo4fXkJoULBXAfx5HCa4TZsnOQUR8F44e1r3TKXVPD0dOeCNMg==" },
                    { "Apostolos.Kypraios", new DateOnly(1992, 7, 24), "Παναγιώτηςton", "Ευάγγελος Μελετόπουλος", "AQAAAAIAAYagAAAAEPVUfm5/e/H/7teaTNOnzGWUwSqbpadxSQTKQVk3HWFSQald//PswL9jke0blrIMXA==" },
                    { "Apostolos44", new DateOnly(1995, 4, 19), "Παππάςside", "Γρηγόριος Βλαβιανός", "AQAAAAIAAYagAAAAELNELFOg1TiTBDd17vSto0Ww/yvc8KfkfTd26Gq/GPucOuSi182vrsRey4KL++1dwg==" },
                    { "Apostolos75", new DateOnly(2001, 9, 8), "Μιχαηλίδηςburgh", "Φώτιος Βαρουξής", "AQAAAAIAAYagAAAAEN/8r8HXa3QjFD718An5s60xQRPO9SrpuMOPVFrepZrAVRQnJQ4oTvSY0IMIRl/a/A==" },
                    { "Apostolos_Daskalopoylos", new DateOnly(1991, 8, 9), "Βαρνακιώτηςtown", "Ιωάννης Δαμασκηνός", "AQAAAAIAAYagAAAAECZhmW6R/GNZzJrtNQTGz/bdcN1vIvG0qPDENTWpeZtQIO+AOFl6kN15XU2KfP59Iw==" },
                    { "Aristeidis.Aleksandroy12", new DateOnly(2001, 1, 15), "Νικόλαοςland", "Ευστάθιος Κόρακας", "AQAAAAIAAYagAAAAEDZgmNFla3QTOMfyvCX+994EFOL1EYv2MXdFaEo1NvdSoCMwlV+rAqpQ8jDnv3Mclw==" },
                    { "Aristeidis.Papanikolaoy", new DateOnly(1995, 8, 25), "Παύλοςberg", "Χρήστος Λαμέρας", "AQAAAAIAAYagAAAAENrCwtLp7pagLUxAzedAkD6qOpXGvkZLvh145xEKw1D+ncpgkCs5By4f1jC62a/Zzw==" },
                    { "Aristeidis_Melioi", new DateOnly(2003, 1, 7), "Μεσσηνέζηςchester", "Σωτήριος Δελή", "AQAAAAIAAYagAAAAEOxQo3M3PFDpE2GQ5kbiICe0hJClbORaUmAaDAv1jNRnSo5vbGmk17IZEbjdxaQbLQ==" },
                    { "Basilis.Koytalianos17", new DateOnly(2003, 6, 26), "New Διονύσιοςstad", "Φώτιος Λούλης", "AQAAAAIAAYagAAAAEGRPE9M44r8xaB4RfO/dliqMqSe4mTKZeF64x4uGiIZ/+Uqwnk77rFQL/5A+SrF0Lg==" },
                    { "Basilis61", new DateOnly(1994, 7, 30), "Παναγιώτηςborough", "Αντώνης Κορομηλάς", "AQAAAAIAAYagAAAAEKybuFnS3aZ9WWg0qXIkWnYrPAmi9RW5aAeFs7c1CoFtbDpte8F7TR42tq1BmDIk1w==" },
                    { "Basilis_Oikonomoy", new DateOnly(2003, 12, 9), "Ευάγγελοςside", "Παρασκευάς Μιχαηλίδης", "AQAAAAIAAYagAAAAEPbxVsHBErmsL+xEufk+U3fPmEvY5In+vJUPNhMm0Jiq2Pn7GwnpLajSCXr4dKPMUQ==" },
                    { "Dimitris28", new DateOnly(1998, 1, 10), "Άγγελοςland", "Στυλιανός Παπανικολάου", "AQAAAAIAAYagAAAAECdzcoeEhAhhlAmTT1GThHSqTjg5P4kNFdYYbacXj4prhP3i713gw6U0qpBENWtdig==" },
                    { "Dionysios.Anagnostakis", new DateOnly(1991, 3, 5), "West Αριστείδης", "Σωτήριος Μανωλάς", "AQAAAAIAAYagAAAAEH4IctBZxKAoZ4HPSnvwgT3tjX7+Fa7LzZSBYb9LAzd8U18fX+M/ErCuf6Z4nNOz6Q==" },
                    { "Dionysios.Lytras", new DateOnly(1988, 12, 11), "Εμμανουήλmouth", "Νικόλαος Ζωγράφου", "AQAAAAIAAYagAAAAEEJmD0NfRXzGFdCPoLrFvkjhR/bag90RmrOY9sOFmltEL1Vqqrpoq+zSSAcYmjzcyg==" },
                    { "Dionysios_Deli12", new DateOnly(1992, 2, 8), "West Εμμανουήλ", "Στέφανος Παπανδρέου", "AQAAAAIAAYagAAAAEJKiekRcM+6MIGSwU4KuvFxf0gdXAPn4trGaz+3uZ6rhHDk2LeXbL2VaPDHWWCN8hA==" },
                    { "Eleytherios.Eleytherioy", new DateOnly(1996, 2, 28), "Lake Χρήστος", "Ηλίας Βλαχόπουλος", "AQAAAAIAAYagAAAAEA3Hr5BjP402noGlG5gzVPOPIwHxZCbDmBMog3BnAs8ozOvVIDpaSg5Qa4QrOT5gLg==" },
                    { "Eleytherios_Didaskaloy", new DateOnly(2004, 7, 24), "Στυλιανόςhaven", "Γρηγόριος Καραμανλής", "AQAAAAIAAYagAAAAEP6h/R5i07QHLtTH1OuNHjvl0iu5eODxmy9V0aA2fBI2gUL+cLfK8m9GTpNfFFGZPg==" },
                    { "Emmanoyil.Georgiadis", new DateOnly(2002, 4, 24), "Χρήστοςtown", "Ελευθέριος Κεδίκογλου", "AQAAAAIAAYagAAAAEIc5D4fb0lRn45tF9SKCcN9hXdd3utUYBb9t+E0pvdX5pirXq1+rz/cbVh7Y9fpHgQ==" },
                    { "Emmanoyil_Aleksioy5", new DateOnly(1996, 7, 27), "Αλεξόπουλοςland", "Ελευθέριος Βλαστός", "AQAAAAIAAYagAAAAEB2j0tYA51VIxwc9cL8cwlGNsqWanK6Cxy9JvJI0s9FoOGbdVfMhHPxu/7d6IdmLxQ==" },
                    { "Emmanoyil_Koyndoyros", new DateOnly(2000, 11, 30), "Καραμανλήςmouth", "Νικόλαος Κορνάρος", "AQAAAAIAAYagAAAAEOKCZXVOww7iMBEs1xeR8/OOGlfDCcfyQOZh8eEzL1M8XM3M7bNqc+GbxugPHQCFeg==" },
                    { "Emmanoyil_Maris67", new DateOnly(1999, 7, 30), "Ευστάθιοςton", "Στέφανος Γεωργιάδης", "AQAAAAIAAYagAAAAEOwkX+jbdg5WtIN0mAScjY1JVHYoAZ0+8VkYTpblktiORvSZ+KqS7tMJVf8m/r4HhQ==" },
                    { "Eyaggelos_Koromilas73", new DateOnly(2002, 12, 10), "New Ευστάθιος", "Φώτιος Βλαχόπουλος", "AQAAAAIAAYagAAAAEDFg9r1RXjfJyvsG4J+u2Yp0ukQPI56QqcvkyQLRoBcvGqd1hni5KmVyiZvesMJUtg==" },
                    { "Eystathios.Boyrdoympas", new DateOnly(2000, 5, 31), "South Χρήστος", "Γρηγόριος Καρράς", "AQAAAAIAAYagAAAAEFaElEYLeirPH4DLUaLBHRp3SslbH/iPoyAME/Ko2Aw3gfLcmEJnSP96DOwOg7IQow==" },
                    { "Eystathios17", new DateOnly(1997, 11, 23), "Πέτροςbury", "Βασίλης Ζωγράφος", "AQAAAAIAAYagAAAAEMthRuHXcgDT0Frvj2kUGgb4MLoTFA5SBKHcv98T9ks/+6uhVR5184qUnowEzUS6eg==" },
                    { "Eystathios29", new DateOnly(2004, 6, 30), "North Κώσταςport", "Στέφανος Βλαστός", "AQAAAAIAAYagAAAAEEPt1XWJElIsZPtSqUtAzlx/ub5IbnGjm7q3lpMcJ6hE2d4mo0M1r9gzPYt3L+ZOqQ==" },
                    { "Eystathios57", new DateOnly(1990, 10, 30), "Χαράλαμποςtown", "Ιωάννης Αβραμίδης", "AQAAAAIAAYagAAAAEDLooUNQ5Y1lJbyIZdUO38aB/3lk7EFqDiNmO8V/uo1VI9Ao1+yuoGvEm4EvqXgK1A==" },
                    { "Eystathios_Avramidis41", new DateOnly(2005, 2, 21), "Φώτιοςfort", "Αντώνης Κυπραίος", "AQAAAAIAAYagAAAAEBbx/1LtrwFiUWbFmJngwomdyMzeizjncnO8tI4QaFHTeW7T0ADsmGLxDI04lhgYkw==" },
                    { "Fotios.Andreoy51", new DateOnly(2004, 2, 11), "North Μιχαήλville", "Διονύσιος Αλεβιζόπουλος", "AQAAAAIAAYagAAAAEB4pNgzQHifyClr7u5kQNBAj94d4Sh3Ry3K98+ThKcKPKtBmes8nhQ/ej3y/lYEEmg==" },
                    { "Fotios90", new DateOnly(2005, 10, 20), "East Στέφανος", "Ευάγγελος Καραμανλής", "AQAAAAIAAYagAAAAECNSqogErjtiBCMQmfi1opB5u2N/fRncVGD6ClZo8TY6vNNEqvWnD3XTWdXL/zwL6g==" },
                    { "Fotios_Karavias7", new DateOnly(1993, 8, 16), "Αλέξανδροςstad", "Αθανάσιος Καλύβας", "AQAAAAIAAYagAAAAEODTJeZbejckHW2CwYAPZAXVHVp9zJhSxZZbBvoaITT8Zzo3a1qBiRnFc7f68E0+QQ==" },
                    { "Georgios.Eytaksias", new DateOnly(1992, 10, 1), "East Σωτήριοςmouth", "Χρήστος Θεοδοσίου", "AQAAAAIAAYagAAAAEIornQKT4qfe1cEEUsb4d6VthEHY3P/h7Vg01nPgLn3RiqOxrQONivbU0esmLLYxRA==" },
                    { "Georgios2", new DateOnly(2003, 2, 11), "Lake Δημήτρης", "Εμμανουήλ Δημητρακόπουλος", "AQAAAAIAAYagAAAAEAVZ5QUe92Es3KAAolQxnQUS/Uz6MdBuXIRB8QOzysg0JBlA3yyu3Hfo5JBFYn8D1w==" },
                    { "Georgios45", new DateOnly(2003, 11, 13), "Lake Απόστολος", "Πέτρος Λούπης", "AQAAAAIAAYagAAAAELTR6IZ2Vmmto7OA+2siJ+T/LD8NkJLdRmAEaIK3K5HF8Mm38daDM7p0BtsnMGrZtQ==" },
                    { "Georgios79", new DateOnly(1987, 9, 15), "Δάβηςside", "Βασίλης Αλεξιάδης", "AQAAAAIAAYagAAAAEEzSXbhBeOI4CtOzbNxSu9UZvrE1EpZW28i+9QB7VXoW9lJb8ELO46FzEY7pK4yMUQ==" },
                    { "Georgios_Bilaetis20", new DateOnly(1988, 4, 16), "North Παναγιώτηςborough", "Αντώνης Μαλαξός", "AQAAAAIAAYagAAAAEA6YV9AFo8D6Ctmo74Yin4YjkzwTXeKaSXnkNBIrIKrqpCDNYLHeMoc4nly/u+0BBA==" },
                    { "Grigorios.Boylgaris", new DateOnly(1999, 3, 24), "East Σταύρος", "Φώτιος Κορνάρος", "AQAAAAIAAYagAAAAEFqUoaIwHMRweEMcCM7k3SqXPGMfcTdPrmQ/GGtmfmnCaoQEhDMQHsd3KaO7VBvt+g==" },
                    { "Grigorios_Kontoleon41", new DateOnly(1992, 1, 19), "Κώσταςmouth", "Σταύρος Παπαϊωάννου", "AQAAAAIAAYagAAAAEKyHGnyfm/gdMxfOdYQUNQJNHhP2BCG6kpgSxc0OAebhzysLpoQ3UC+sWVl5Oghp9w==" },
                    { "Ilias.Metaksas74", new DateOnly(2004, 1, 20), "South Εμμανουήλhaven", "Αλέξανδρος Αλαβάνος", "AQAAAAIAAYagAAAAEKj1oEwrm6rK3I/up4DmwxDzdSJrv9QAzPlD7JcDNIKfit6R4acCVN9gwVCheuB01w==" },
                    { "Ilias.Zafeiropoylos86", new DateOnly(1989, 5, 11), "East Απόστολοςhaven", "Σωτήριος Αξιώτης", "AQAAAAIAAYagAAAAEBo9YaO9FEuyciX2uV4apODOKhwHdHKlX29j9Hhva53PSqNbGZOqyYuzlMlHDff72Q==" },
                    { "Ilias56", new DateOnly(1987, 6, 19), "East Απόστολοςchester", "Παύλος Ελευθερόπουλος", "AQAAAAIAAYagAAAAEEWNlBAUFq98U51/g+bnkqSvEXu1aVBwdkbzBNt3zw63aeU4UeDfFiPHVdn7d05Gsg==" },
                    { "Ilias_Bamvas22", new DateOnly(2003, 1, 17), "North Πέτρος", "Δημήτρης Αλεξιάδης", "AQAAAAIAAYagAAAAECHCw/DqRPB6Tp56XO5Jj8eEDeD9FXupl5VWmqqeseWQ4NRSsQWCvJJgIHZeFXZqWw==" },
                    { "Ioannis.Aygerinoseponymo0", new DateOnly(2000, 9, 21), "West Χαράλαμποςport", "Αριστείδης Βασιλικός", "AQAAAAIAAYagAAAAEJSnMbKtBOcmZZzPY8/dYNXs6Uai0irUwZN5X8yy0gXt5y/BP8p32WkWZueXmH6+Wg==" },
                    { "Ioannis.Zappas99", new DateOnly(1993, 3, 7), "Lake Αριστείδης", "Ευστάθιος Παπάγος", "AQAAAAIAAYagAAAAEH6pcRxMHd1FXjAOpl/viX5FrUQfJa+TYkkwONAVaZpcU9upOo2voeR2nxQWjtOBkg==" },
                    { "Ioannis28", new DateOnly(1993, 9, 21), "New Κώστας", "Λεωνίδας Μακρή", "AQAAAAIAAYagAAAAEJr8wVilkyimW6TGt1y5eJqgDVWU/ylBCS9REOSuN1a4XRIgfWh0usku7ZdHhJcUqQ==" },
                    { "Ioannis_Basilopoylos", new DateOnly(1998, 5, 19), "Port Λεωνίδας", "Δημήτρης Γιάγκος", "AQAAAAIAAYagAAAAEF2Ge20F9jm6GlUbAg/OZ2R0/X9278WWKmTewcdGMBh0q6uV9dYxqZMOEHmexggANg==" },
                    { "Kostas43", new DateOnly(2005, 3, 26), "East Θεόδωρος", "Αλέξανδρος Δασκαλόπουλος", "AQAAAAIAAYagAAAAEOBFUby45m3o1KojTXdJa6evUnsQGFTTjChqANlR9JF6FRxfa6kDKXeO0XnxIqcgZQ==" },
                    { "Kostas92", new DateOnly(1987, 6, 9), "East Ηλίας", "Αντώνης Καραμανλής", "AQAAAAIAAYagAAAAELzveifOBfV8H2fqvNRTljloC8Jm8FTbXnV5gb0tRtJOdEtb4kvbLwv08mgHtRgHZg==" },
                    { "Kostas_Byzantios65", new DateOnly(2001, 3, 17), "Ευάγγελοςville", "Πέτρος Κοτζιάς", "AQAAAAIAAYagAAAAENA4ay5hh9cDtrK9dGkNr0lsG23/yJvmDe57bqufZBWjFkiqS4fTEhYiYBYjNc9wag==" },
                    { "Mixail.Bergas85", new DateOnly(1985, 11, 4), "Παρασκευάςburgh", "Σπύρος Βασιλείου", "AQAAAAIAAYagAAAAELgUW4sCrwv08L7Hg7Am59RhyZzhIPbi4eVQA3rcak0mkGveJaV3hgMiEd4b/+U4gw==" },
                    { "Mixail.Ioannoy", new DateOnly(1987, 3, 25), "Γρηγόριοςhaven", "Στέφανος Δοξαράς", "AQAAAAIAAYagAAAAEHM4iBbkO/dv5dQVuMMHONOZZ1/+tYk3gP+GvIt3Xnuli2qjFKeKps8pO2wE8HDqmw==" },
                    { "Mixail90", new DateOnly(1995, 5, 28), "Αθανασιάδηςberg", "Σπύρος Μιχαηλίδης", "AQAAAAIAAYagAAAAENAlw0YZE9Bq50doOIjxPkfJlY6uKXJ+c5rhYehFzXdr3kTjYdPsp+ItQKifXp/iiw==" },
                    { "Nikolaos_Boyrdoympas15", new DateOnly(2000, 11, 10), "Αλεξανδρίδηςville", "Παναγιώτης Λιάπης", "AQAAAAIAAYagAAAAEAbRtFV9U9cg2hXLFktOVJFguL9h0lZYfnYchU/uAZeTc4cCmWyuMsxqA/gOSIda5A==" },
                    { "Paraskeyas.Anagnostakis", new DateOnly(2001, 11, 25), "North Σωτήριος", "Σωτήριος Θεοδοσίου", "AQAAAAIAAYagAAAAEFxmVE8XiBmQ083BXlx1AIOsuCV8PGG666DDaTsUKqZWv7+BUP+ZzmPBYKAP1jY0iQ==" },
                    { "Paraskeyas_THeodoridis89", new DateOnly(2003, 4, 27), "Σταύροςfurt", "Γεώργιος Κομνηνός", "AQAAAAIAAYagAAAAEAs71NgCR6YISo+CzqcXKpgMY/fl505U8dLSeKLfXL1Y8ngJSQ2usqRuXwmBCP7TGw==" },
                    { "Paylos.Giagkos", new DateOnly(1993, 10, 27), "West Στέφανοςborough", "Σωτήριος Αλεβίζος", "AQAAAAIAAYagAAAAEHRTgj0chl+mO+6MbavUlyL/Tx0tInb28FwskuE7wdoqFopImAUVQfnmMcVl8xD3ng==" },
                    { "Paylos.Koyndoyros", new DateOnly(1988, 10, 10), "Port Ιωάννηςstad", "Παρασκευάς Αλαφούζος", "AQAAAAIAAYagAAAAEJggk700C65+rFu/2GlDHT/25FZ2DT4P9iEpK4H223+AanMSyKUuXvIf5TK0+mvIFA==" },
                    { "Paylos18", new DateOnly(1996, 8, 10), "South Βασίληςchester", "Νικόλαος Βενιζέλος", "AQAAAAIAAYagAAAAEBy73Alj78QDV/HOCCwEiitz2BRRRBdUsHDcHq/O1UdDalTL0vXlZb3dRh28o5Xfow==" },
                    { "Paylos48", new DateOnly(1995, 3, 7), "West Ελευθέριος", "Άγγελος Καλαμογδάρτης", "AQAAAAIAAYagAAAAEAKi0DsQhR0LxCFMAU1uYQM/OGjDziP/7GE+aklf0pbcVE+PFJ8Bp8fxCb9/84QeAg==" },
                    { "Paylos_Kalyvas76", new DateOnly(2003, 11, 15), "Ιωαννίδηςside", "Ευάγγελος Καλογιάννης", "AQAAAAIAAYagAAAAEAlGDJ284NjjSV6P1+cgo+8fx4wNW/PekyVtsgDH5n4aAFD0LUwGOitqtgCvclW1Aw==" },
                    { "Petros.Blavianos51", new DateOnly(2004, 2, 16), "Κώσταςport", "Ανδρέας Αλεξίου", "AQAAAAIAAYagAAAAEHYpX1XVs2PY1jbGqtkrBoRqy5qOLIIf0OrLh8Z1l+qGua/0w+W99xD6Ea54wYqzuA==" },
                    { "Petros50", new DateOnly(1992, 11, 22), "Ευστάθιοςton", "Απόστολος Μαυρογένης", "AQAAAAIAAYagAAAAELynujC+jdCtMmCTL53hrQOHMX1Bns5zGirXKnHD4SilH/Lux8LaAjUTfi5INAtjPw==" },
                    { "Petros77", new DateOnly(1996, 9, 16), "Χαράλαμποςland", "Χρήστος Λαμπρόπουλος", "AQAAAAIAAYagAAAAENfC/e8w5s224SJwQAE8+lDUdwW61jRBK3vwPIyhBsI6EMLp2Y3AfHz0CP41bBi4Xg==" },
                    { "Sotirios.Germanos87", new DateOnly(2002, 1, 5), "Κομνηνόςstad", "Μιχαήλ Γεωργιάδης", "AQAAAAIAAYagAAAAEN1Ycv3zJPnXxf1PHzYm76gHGhrXMQw3ZUV+YwW3PsnIUP5pPiwsxtOs0XxoCSIH8Q==" },
                    { "Sotirios.Kalogiannis43", new DateOnly(1994, 1, 21), "Port Λεωνίδαςport", "Αριστείδης Μιαούλης", "AQAAAAIAAYagAAAAEKaHzZ77SHxg3GpRSA+l2Qe4OfhQ7Ou4tTwy/fVlIfJe4QrtjWf6HQFnMt6qAjbHTg==" },
                    { "Sotirios.THeodosioy", new DateOnly(2005, 10, 3), "Port Αντώνης", "Βασίλης Ζαχαρίου", "AQAAAAIAAYagAAAAECxhaLrKqxYPstsHdN1L1a87otxi2Gpx+gsoJjDUCXNw6TS2mnotNBJwrbAr8j3+hQ==" },
                    { "Sotirios_Zervos", new DateOnly(1998, 12, 31), "Port Σωτήριοςside", "Παναγιώτης Γαλάνη", "AQAAAAIAAYagAAAAEE2L1CO4RsOj8T+w4lZi4oMxiW160CfntlZhShvjxHbLd2FsR74jgcp7aGFbocLmlQ==" },
                    { "Spyros97", new DateOnly(1990, 8, 14), "North Ιωάννης", "Άγγελος Μπότσαρης", "AQAAAAIAAYagAAAAEAejv6o5mpyG1SujWh05HalXDF36fK+uxSDkvFXthKeOj6kPREz76pqFmZH6FYQ4vg==" },
                    { "Spyros_Anastasiadis", new DateOnly(1993, 2, 13), "Βενιζέλοςland", "Στυλιανός Λόντος", "AQAAAAIAAYagAAAAEKNLUZ0h6kf835fMo6XAI4zNA7qazgRoN3dL+bN689GLBbGzRVtyos8mH+SnLVYDUQ==" },
                    { "Stayros.Koronaios", new DateOnly(1992, 9, 26), "East Αναστάσιος", "Αθανάσιος Μακρής", "AQAAAAIAAYagAAAAEBVGYknXCovdvEu7Sxduwx3tFOYRYij2vuHc9dplo4I3fO3t53LtKS1hEu/89G/D3w==" },
                    { "Stayros_Bergas29", new DateOnly(1988, 11, 3), "Απόστολοςstad", "Θεόδωρος Θεοδοσίου", "AQAAAAIAAYagAAAAEF2glNS6zblGtTCiFEKznbniHMINZjok6L6dKAHxQNgk5YIyTi5lWKOfuvKmkuK/3w==" },
                    { "Stefanos.Loypis27", new DateOnly(1994, 2, 12), "West Πέτροςfort", "Δημήτρης Κυπραίος", "AQAAAAIAAYagAAAAEMSyh8PH3f4/BnFl57ZLX2YzzY5IjV6LUzdObS9xno7TXCwSgI/I/DsGt/jFG76eBQ==" },
                    { "Stefanos.Nikolaidis21", new DateOnly(1993, 6, 21), "East Νικόλαοςberg", "Ευστάθιος Αγγελίδης", "AQAAAAIAAYagAAAAEEYlFxFjp2oJnBcQN8TWsAoa/v6fSDB3s9+C3zQ4EQLgzkmhJ5CNNnrBSi5LFebe6g==" },
                    { "Stylianos.Basileiadis", new DateOnly(1991, 4, 8), "Lake Αντώνης", "Άγγελος Μιαούλης", "AQAAAAIAAYagAAAAEBdRTIGp3kiwMcacwXSWB+YbdZIQXNz1mpRLXQf7BjH/TMwxYX2JAUxOyapJs9NQQA==" },
                    { "Stylianos.Mitzoy", new DateOnly(1992, 4, 19), "Άγγελοςfort", "Αθανάσιος Παπαστεφάνου", "AQAAAAIAAYagAAAAEAfe58KQXiawiFHu4Io9oNP/tLHJjHM8mm8Hg9Crlau0SiB/QjbqUobDk281Q07t5g==" },
                    { "THeodoros.Basileiadis2", new DateOnly(1994, 12, 8), "Port Αναστάσιοςmouth", "Βασίλης Διδασκάλου", "AQAAAAIAAYagAAAAEEFELta4pFi1idZwivHiU32tqXIuRnpoj4+Un082Mhz8pgxDB5OJpLpW06DMn7fNRQ==" },
                    { "THeodoros.Zafeiropoylos96", new DateOnly(2004, 5, 30), "New Παρασκευάς", "Ανδρέας Ανδρέου", "AQAAAAIAAYagAAAAEMu1K+znggsf1UIMWxddsIQOTAlmuXxxWB7OiDzRPS9J0soOz9cqG+3DSB+g8W77eQ==" },
                    { "THeodoros68", new DateOnly(1997, 10, 16), "South Σπύρος", "Θεόδωρος Βέργας", "AQAAAAIAAYagAAAAEMWgzIlgsQW00Guf18Z4JXlZNYYucnvc8UeTdb5TSxyk5MJrtsZgRi3LdFPgGRVl6Q==" },
                    { "Xaralampos43", new DateOnly(1995, 11, 7), "West Ευστάθιος", "Κώστας Κασιδιάρης", "AQAAAAIAAYagAAAAEBG5KSvuZ37GG6XNfjX06Fb0h9SMwr8mMku+YBc5QRRqAyxqjqF/2R86DADU8DpXJw==" },
                    { "Xaralampos68", new DateOnly(1994, 8, 25), "South Βασίληςhaven", "Νικόλαος Ευταξίας", "AQAAAAIAAYagAAAAEHWDN4P9telwOBvAJffudTmOCqIy+wTp6rI4IYTxUz2WrkCCM0pgdbGxyfSbTCiUaA==" },
                    { "Xaralampos74", new DateOnly(1997, 12, 27), "New Ανδρέας", "Βασίλης Δημητρίου", "AQAAAAIAAYagAAAAEIqxdHIiJj9+flqB6pktWZa1MbzREGeZBBGH1cOOc2P65raxNK3jZz0qEuMj4wlkWQ==" },
                    { "Xristos.Aggelopoylos", new DateOnly(1993, 1, 12), "Αλεβιζόπουλοςside", "Γρηγόριος Ζαφειρόπουλος", "AQAAAAIAAYagAAAAEKEd+B6yyvFWk8r/a/baAukwLM5NlNS+Th8f/nWTqaqwbvaJSUNcMdLHT9VPXNC+4g==" },
                    { "Xristos80", new DateOnly(1999, 11, 14), "New Γεώργιοςville", "Ανδρέας Κόρακας", "AQAAAAIAAYagAAAAEHnEiILjVSyxpubl0jUNnHdb22bDtOo4ysmwUCi6yklNU0RJRaBLM65kfWv1LJW02g==" },
                    { "Xristos85", new DateOnly(2000, 5, 28), "Γεώργιοςmouth", "Αλέξανδρος Ελευθεριάδης", "AQAAAAIAAYagAAAAEF4r/wgJIn9qWXHEubD1Pfxm4mfa6h94mN7u8ufT4BUD9qhKGKo4a2sChTYY3gSpgA==" }
                });

            migrationBuilder.InsertData(
                table: "DegreeParticipations",
                columns: new[] { "DegreeName", "Username", "EndDate", "StartDate" },
                values: new object[,]
                {
                    { "Games & Toys (297)", "Aggelos.Aggelidoy35", new DateOnly(2014, 7, 11), new DateOnly(2011, 7, 11) },
                    { "Electronics (266)", "Aggelos6", new DateOnly(2020, 11, 20), new DateOnly(2017, 11, 20) },
                    { "Games & Toys (297)", "Aggelos87", new DateOnly(2023, 3, 18), new DateOnly(2020, 3, 18) },
                    { "Toys (259)", "Aggelos_Georgiadis30", new DateOnly(2025, 12, 24), new DateOnly(2022, 12, 24) },
                    { "Books (290)", "Aleksandros.Zervos61", new DateOnly(2018, 5, 4), new DateOnly(2015, 5, 4) },
                    { "Baby (279)", "Aleksandros41", new DateOnly(2012, 2, 14), new DateOnly(2009, 2, 14) },
                    { "Baby (283)", "Anastasios_Bilaetis84", new DateOnly(2009, 12, 10), new DateOnly(2006, 12, 10) },
                    { "Music, Movies & Industrial (280)", "Anastasios_Nikolakos52", new DateOnly(2024, 3, 9), new DateOnly(2021, 3, 9) },
                    { "Health, Toys & Outdoors (255)", "Andreas22", new DateOnly(2019, 9, 5), new DateOnly(2016, 9, 5) },
                    { "Garden (271)", "Andreas52", new DateOnly(2009, 8, 16), new DateOnly(2006, 8, 16) },
                    { "Sports, Computers & Electronics (277)", "Andreas95", new DateOnly(2021, 4, 15), new DateOnly(2018, 4, 15) },
                    { "Shoes & Toys (268)", "Andreas_Bikelidis33", new DateOnly(2016, 9, 17), new DateOnly(2013, 9, 17) },
                    { "Jewelery, Automotive & Garden (276)", "Antonis.Lytras", new DateOnly(2007, 7, 14), new DateOnly(2004, 7, 14) },
                    { "Books & Sports (273)", "Antonis4", new DateOnly(2018, 6, 3), new DateOnly(2015, 6, 3) },
                    { "Electronics (266)", "Antonis_Antonopoylos", new DateOnly(2024, 8, 27), new DateOnly(2021, 8, 27) },
                    { "Home (264)", "Antonis_Diamantopoylos43", new DateOnly(2021, 1, 29), new DateOnly(2018, 1, 29) },
                    { "Industrial, Toys & Automotive (250)", "Antonis_Karamanlis", new DateOnly(2018, 2, 10), new DateOnly(2015, 2, 10) },
                    { "Clothing, Electronics & Jewelery (253)", "Antonis_Melioi26", new DateOnly(2009, 8, 26), new DateOnly(2006, 8, 26) },
                    { "Garden (260)", "Apostolos.Kypraios", new DateOnly(2013, 7, 24), new DateOnly(2010, 7, 24) },
                    { "Kids & Tools (265)", "Apostolos44", new DateOnly(2016, 4, 19), new DateOnly(2013, 4, 19) },
                    { "Shoes & Kids (281)", "Apostolos75", new DateOnly(2022, 9, 8), new DateOnly(2019, 9, 8) },
                    { "Electronics & Jewelery (282)", "Apostolos_Daskalopoylos", new DateOnly(2012, 8, 9), new DateOnly(2009, 8, 9) },
                    { "Baby (283)", "Aristeidis.Aleksandroy12", new DateOnly(2022, 1, 15), new DateOnly(2019, 1, 15) },
                    { "Sports, Computers & Electronics (277)", "Aristeidis.Papanikolaoy", new DateOnly(2016, 8, 25), new DateOnly(2013, 8, 25) },
                    { "Automotive, Garden & Beauty (261)", "Aristeidis_Melioi", new DateOnly(2024, 1, 7), new DateOnly(2021, 1, 7) },
                    { "Sports, Computers & Electronics (277)", "Basilis.Koytalianos17", new DateOnly(2024, 6, 26), new DateOnly(2021, 6, 26) },
                    { "Sports, Kids & Industrial (291)", "Basilis61", new DateOnly(2015, 7, 30), new DateOnly(2012, 7, 30) },
                    { "Electronics (251)", "Basilis_Oikonomoy", new DateOnly(2024, 12, 9), new DateOnly(2021, 12, 9) },
                    { "Kids & Baby (287)", "Dimitris28", new DateOnly(2019, 1, 10), new DateOnly(2016, 1, 10) },
                    { "Shoes & Kids (281)", "Dionysios.Anagnostakis", new DateOnly(2012, 3, 5), new DateOnly(2009, 3, 5) },
                    { "Garden (262)", "Dionysios.Lytras", new DateOnly(2009, 12, 11), new DateOnly(2006, 12, 11) },
                    { "Books (290)", "Dionysios_Deli12", new DateOnly(2013, 2, 8), new DateOnly(2010, 2, 8) },
                    { "Electronics (266)", "Eleytherios.Eleytherioy", new DateOnly(2017, 2, 28), new DateOnly(2014, 2, 28) },
                    { "Beauty (269)", "Eleytherios_Didaskaloy", new DateOnly(2025, 7, 24), new DateOnly(2022, 7, 24) },
                    { "Kids & Tools (265)", "Emmanoyil.Georgiadis", new DateOnly(2023, 4, 24), new DateOnly(2020, 4, 24) },
                    { "Electronics (251)", "Emmanoyil_Aleksioy5", new DateOnly(2017, 7, 27), new DateOnly(2014, 7, 27) },
                    { "Toys (267)", "Emmanoyil_Koyndoyros", new DateOnly(2021, 11, 30), new DateOnly(2018, 11, 30) },
                    { "Baby (279)", "Emmanoyil_Maris67", new DateOnly(2020, 7, 30), new DateOnly(2017, 7, 30) },
                    { "Beauty (269)", "Eyaggelos_Koromilas73", new DateOnly(2023, 12, 10), new DateOnly(2020, 12, 10) },
                    { "Toys (267)", "Eystathios.Boyrdoympas", new DateOnly(2021, 5, 31), new DateOnly(2018, 5, 31) },
                    { "Books, Garden & Garden (275)", "Eystathios17", new DateOnly(2018, 11, 23), new DateOnly(2015, 11, 23) },
                    { "Computers & Health (285)", "Eystathios29", new DateOnly(2025, 6, 30), new DateOnly(2022, 6, 30) },
                    { "Shoes & Kids (281)", "Eystathios57", new DateOnly(2011, 10, 30), new DateOnly(2008, 10, 30) },
                    { "Games & Toys (297)", "Eystathios_Avramidis41", new DateOnly(2026, 2, 21), new DateOnly(2023, 2, 21) },
                    { "Home (264)", "Fotios.Andreoy51", new DateOnly(2025, 2, 11), new DateOnly(2022, 2, 11) },
                    { "Baby (283)", "Fotios90", new DateOnly(2026, 10, 20), new DateOnly(2023, 10, 20) },
                    { "Garden (271)", "Fotios_Karavias7", new DateOnly(2014, 8, 16), new DateOnly(2011, 8, 16) },
                    { "Clothing, Electronics & Jewelery (253)", "Georgios.Eytaksias", new DateOnly(2013, 10, 1), new DateOnly(2010, 10, 1) },
                    { "Electronics (251)", "Georgios2", new DateOnly(2024, 2, 11), new DateOnly(2021, 2, 11) },
                    { "Home (264)", "Georgios45", new DateOnly(2024, 11, 13), new DateOnly(2021, 11, 13) },
                    { "Books (290)", "Georgios79", new DateOnly(2008, 9, 15), new DateOnly(2005, 9, 15) },
                    { "Kids, Electronics & Movies (288)", "Georgios_Bilaetis20", new DateOnly(2009, 4, 16), new DateOnly(2006, 4, 16) },
                    { "Baby (283)", "Grigorios.Boylgaris", new DateOnly(2020, 3, 24), new DateOnly(2017, 3, 24) },
                    { "Baby (283)", "Grigorios_Kontoleon41", new DateOnly(2013, 1, 19), new DateOnly(2010, 1, 19) },
                    { "Baby (279)", "Ilias.Metaksas74", new DateOnly(2025, 1, 20), new DateOnly(2022, 1, 20) },
                    { "Kids & Tools (265)", "Ilias.Zafeiropoylos86", new DateOnly(2010, 5, 11), new DateOnly(2007, 5, 11) },
                    { "Baby (279)", "Ilias56", new DateOnly(2008, 6, 19), new DateOnly(2005, 6, 19) },
                    { "Garden (262)", "Ilias_Bamvas22", new DateOnly(2024, 1, 17), new DateOnly(2021, 1, 17) },
                    { "Kids, Electronics & Movies (288)", "Ioannis.Aygerinoseponymo0", new DateOnly(2021, 9, 21), new DateOnly(2018, 9, 21) },
                    { "Books (257)", "Ioannis.Zappas99", new DateOnly(2014, 3, 7), new DateOnly(2011, 3, 7) },
                    { "Electronics (266)", "Ioannis28", new DateOnly(2014, 9, 21), new DateOnly(2011, 9, 21) },
                    { "Garden (260)", "Ioannis_Basilopoylos", new DateOnly(2019, 5, 19), new DateOnly(2016, 5, 19) },
                    { "Industrial, Toys & Automotive (250)", "Kostas43", new DateOnly(2026, 3, 26), new DateOnly(2023, 3, 26) },
                    { "Clothing, Electronics & Jewelery (253)", "Kostas92", new DateOnly(2008, 6, 9), new DateOnly(2005, 6, 9) },
                    { "Jewelery, Automotive & Garden (276)", "Kostas_Byzantios65", new DateOnly(2022, 3, 17), new DateOnly(2019, 3, 17) },
                    { "Toys (259)", "Mixail.Bergas85", new DateOnly(2006, 11, 4), new DateOnly(2003, 11, 4) },
                    { "Movies & Toys (286)", "Mixail.Ioannoy", new DateOnly(2008, 3, 25), new DateOnly(2005, 3, 25) },
                    { "Toys (267)", "Mixail90", new DateOnly(2016, 5, 28), new DateOnly(2013, 5, 28) },
                    { "Beauty & Electronics (299)", "Nikolaos_Boyrdoympas15", new DateOnly(2021, 11, 10), new DateOnly(2018, 11, 10) },
                    { "Baby (283)", "Paraskeyas.Anagnostakis", new DateOnly(2022, 11, 25), new DateOnly(2019, 11, 25) },
                    { "Books (257)", "Paraskeyas_THeodoridis89", new DateOnly(2024, 4, 27), new DateOnly(2021, 4, 27) },
                    { "Books (257)", "Paylos.Giagkos", new DateOnly(2014, 10, 27), new DateOnly(2011, 10, 27) },
                    { "Baby (279)", "Paylos.Koyndoyros", new DateOnly(2009, 10, 10), new DateOnly(2006, 10, 10) },
                    { "Tools, Tools & Tools (284)", "Paylos18", new DateOnly(2017, 8, 10), new DateOnly(2014, 8, 10) },
                    { "Electronics (251)", "Paylos48", new DateOnly(2016, 3, 7), new DateOnly(2013, 3, 7) },
                    { "Garden, Kids & Outdoors (289)", "Paylos_Kalyvas76", new DateOnly(2024, 11, 15), new DateOnly(2021, 11, 15) },
                    { "Health, Toys & Outdoors (255)", "Petros.Blavianos51", new DateOnly(2025, 2, 16), new DateOnly(2022, 2, 16) },
                    { "Sports (274)", "Petros50", new DateOnly(2013, 11, 22), new DateOnly(2010, 11, 22) },
                    { "Automotive, Garden & Beauty (261)", "Petros77", new DateOnly(2017, 9, 16), new DateOnly(2014, 9, 16) },
                    { "Shoes & Toys (268)", "Sotirios.Germanos87", new DateOnly(2023, 1, 5), new DateOnly(2020, 1, 5) },
                    { "Tools, Tools & Tools (284)", "Sotirios.Kalogiannis43", new DateOnly(2015, 1, 21), new DateOnly(2012, 1, 21) },
                    { "Beauty & Electronics (299)", "Sotirios.THeodosioy", new DateOnly(2026, 10, 3), new DateOnly(2023, 10, 3) },
                    { "Industrial & Computers (252)", "Sotirios_Zervos", new DateOnly(2019, 12, 31), new DateOnly(2016, 12, 31) },
                    { "Baby (279)", "Spyros97", new DateOnly(2011, 8, 14), new DateOnly(2008, 8, 14) },
                    { "Home, Movies & Shoes (272)", "Spyros_Anastasiadis", new DateOnly(2014, 2, 13), new DateOnly(2011, 2, 13) },
                    { "Garden (262)", "Stayros.Koronaios", new DateOnly(2013, 9, 26), new DateOnly(2010, 9, 26) },
                    { "Outdoors, Home & Baby (292)", "Stayros_Bergas29", new DateOnly(2009, 11, 3), new DateOnly(2006, 11, 3) },
                    { "Books & Sports (273)", "Stefanos.Loypis27", new DateOnly(2015, 2, 12), new DateOnly(2012, 2, 12) },
                    { "Beauty (296)", "Stefanos.Nikolaidis21", new DateOnly(2014, 6, 21), new DateOnly(2011, 6, 21) },
                    { "Tools, Tools & Tools (284)", "Stylianos.Basileiadis", new DateOnly(2012, 4, 8), new DateOnly(2009, 4, 8) },
                    { "Toys, Outdoors & Toys (293)", "Stylianos.Mitzoy", new DateOnly(2013, 4, 19), new DateOnly(2010, 4, 19) },
                    { "Music & Grocery (258)", "THeodoros.Basileiadis2", new DateOnly(2015, 12, 8), new DateOnly(2012, 12, 8) },
                    { "Toys (259)", "THeodoros.Zafeiropoylos96", new DateOnly(2025, 5, 30), new DateOnly(2022, 5, 30) },
                    { "Home, Movies & Shoes (272)", "THeodoros68", new DateOnly(2018, 10, 16), new DateOnly(2015, 10, 16) },
                    { "Industrial & Shoes (270)", "Xaralampos43", new DateOnly(2016, 11, 7), new DateOnly(2013, 11, 7) },
                    { "Sports, Computers & Electronics (277)", "Xaralampos68", new DateOnly(2015, 8, 25), new DateOnly(2012, 8, 25) },
                    { "Electronics (251)", "Xaralampos74", new DateOnly(2018, 12, 27), new DateOnly(2015, 12, 27) },
                    { "Toys (295)", "Xristos.Aggelopoylos", new DateOnly(2014, 1, 12), new DateOnly(2011, 1, 12) },
                    { "Baby, Home & Jewelery (254)", "Xristos80", new DateOnly(2020, 11, 14), new DateOnly(2017, 11, 14) },
                    { "Electronics (251)", "Xristos85", new DateOnly(2021, 5, 28), new DateOnly(2018, 5, 28) },
                    { "Programtervező informatikus Bsc", "oktato", new DateOnly(2000, 6, 1), new DateOnly(1995, 9, 1) },
                    { "Programtervező informatikus Bsc", "tanulo", null, new DateOnly(2018, 9, 1) }
                });

            migrationBuilder.InsertData(
                table: "UserRoles",
                columns: new[] { "UserType", "Username" },
                values: new object[,]
                {
                    { 0, "Aggelos.Aggelidoy35" },
                    { 0, "Aggelos6" },
                    { 0, "Aggelos87" },
                    { 0, "Aggelos_Georgiadis30" },
                    { 0, "Aleksandros41" },
                    { 0, "Anastasios_Nikolakos52" },
                    { 0, "Andreas22" },
                    { 0, "Andreas52" },
                    { 0, "Andreas95" },
                    { 0, "Andreas_Bikelidis33" },
                    { 0, "Antonis_Antonopoylos" },
                    { 0, "Antonis_Diamantopoylos43" },
                    { 0, "Antonis_Melioi26" },
                    { 0, "Apostolos.Kypraios" },
                    { 0, "Apostolos44" },
                    { 0, "Apostolos75" },
                    { 0, "Apostolos_Daskalopoylos" },
                    { 0, "Aristeidis.Papanikolaoy" },
                    { 0, "Aristeidis_Melioi" },
                    { 0, "Basilis.Koytalianos17" },
                    { 0, "Basilis_Oikonomoy" },
                    { 0, "Dionysios.Anagnostakis" },
                    { 0, "Dionysios.Lytras" },
                    { 0, "Dionysios_Deli12" },
                    { 0, "Eleytherios_Didaskaloy" },
                    { 0, "Emmanoyil.Georgiadis" },
                    { 0, "Emmanoyil_Aleksioy5" },
                    { 0, "Emmanoyil_Koyndoyros" },
                    { 0, "Eyaggelos_Koromilas73" },
                    { 0, "Eystathios17" },
                    { 0, "Eystathios29" },
                    { 0, "Eystathios57" },
                    { 0, "Eystathios_Avramidis41" },
                    { 0, "Fotios_Karavias7" },
                    { 0, "Georgios2" },
                    { 0, "Georgios79" },
                    { 0, "Grigorios.Boylgaris" },
                    { 0, "Grigorios_Kontoleon41" },
                    { 0, "Ilias56" },
                    { 0, "Ioannis.Aygerinoseponymo0" },
                    { 0, "Ioannis.Zappas99" },
                    { 0, "Ioannis28" },
                    { 0, "Ioannis_Basilopoylos" },
                    { 0, "Kostas92" },
                    { 0, "Mixail.Bergas85" },
                    { 0, "Mixail.Ioannoy" },
                    { 0, "Mixail90" },
                    { 0, "Nikolaos_Boyrdoympas15" },
                    { 0, "Paraskeyas.Anagnostakis" },
                    { 0, "Paraskeyas_THeodoridis89" },
                    { 0, "Paylos.Giagkos" },
                    { 0, "Paylos18" },
                    { 0, "Paylos_Kalyvas76" },
                    { 0, "Petros50" },
                    { 0, "Petros77" },
                    { 0, "Sotirios.Germanos87" },
                    { 0, "Sotirios.THeodosioy" },
                    { 0, "Sotirios_Zervos" },
                    { 0, "Spyros97" },
                    { 0, "Spyros_Anastasiadis" },
                    { 0, "Stayros.Koronaios" },
                    { 0, "Stefanos.Loypis27" },
                    { 0, "Stylianos.Mitzoy" },
                    { 0, "THeodoros.Basileiadis2" },
                    { 0, "THeodoros.Zafeiropoylos96" },
                    { 0, "THeodoros68" },
                    { 0, "Xaralampos43" },
                    { 0, "Xaralampos74" },
                    { 0, "Xristos.Aggelopoylos" },
                    { 0, "Xristos80" },
                    { 0, "Xristos85" },
                    { 1, "Aggelos.Aggelidoy35" },
                    { 1, "Aggelos87" },
                    { 1, "Aggelos_Georgiadis30" },
                    { 1, "Aleksandros.Zervos61" },
                    { 1, "Aleksandros41" },
                    { 1, "Anastasios_Bilaetis84" },
                    { 1, "Anastasios_Nikolakos52" },
                    { 1, "Andreas95" },
                    { 1, "Andreas_Bikelidis33" },
                    { 1, "Antonis.Lytras" },
                    { 1, "Antonis4" },
                    { 1, "Antonis_Karamanlis" },
                    { 1, "Antonis_Melioi26" },
                    { 1, "Apostolos_Daskalopoylos" },
                    { 1, "Aristeidis.Aleksandroy12" },
                    { 1, "Aristeidis.Papanikolaoy" },
                    { 1, "Aristeidis_Melioi" },
                    { 1, "Basilis.Koytalianos17" },
                    { 1, "Basilis61" },
                    { 1, "Basilis_Oikonomoy" },
                    { 1, "Dimitris28" },
                    { 1, "Dionysios.Anagnostakis" },
                    { 1, "Dionysios.Lytras" },
                    { 1, "Dionysios_Deli12" },
                    { 1, "Eleytherios.Eleytherioy" },
                    { 1, "Emmanoyil_Aleksioy5" },
                    { 1, "Emmanoyil_Koyndoyros" },
                    { 1, "Emmanoyil_Maris67" },
                    { 1, "Eyaggelos_Koromilas73" },
                    { 1, "Eystathios.Boyrdoympas" },
                    { 1, "Eystathios17" },
                    { 1, "Eystathios29" },
                    { 1, "Eystathios57" },
                    { 1, "Fotios.Andreoy51" },
                    { 1, "Fotios90" },
                    { 1, "Fotios_Karavias7" },
                    { 1, "Georgios.Eytaksias" },
                    { 1, "Georgios2" },
                    { 1, "Georgios45" },
                    { 1, "Georgios79" },
                    { 1, "Georgios_Bilaetis20" },
                    { 1, "Grigorios.Boylgaris" },
                    { 1, "Ilias.Metaksas74" },
                    { 1, "Ilias.Zafeiropoylos86" },
                    { 1, "Ilias56" },
                    { 1, "Ilias_Bamvas22" },
                    { 1, "Ioannis.Aygerinoseponymo0" },
                    { 1, "Ioannis28" },
                    { 1, "Kostas43" },
                    { 1, "Kostas92" },
                    { 1, "Kostas_Byzantios65" },
                    { 1, "Mixail.Bergas85" },
                    { 1, "Mixail.Ioannoy" },
                    { 1, "Mixail90" },
                    { 1, "Paraskeyas.Anagnostakis" },
                    { 1, "Paraskeyas_THeodoridis89" },
                    { 1, "Paylos.Koyndoyros" },
                    { 1, "Paylos18" },
                    { 1, "Paylos48" },
                    { 1, "Paylos_Kalyvas76" },
                    { 1, "Petros.Blavianos51" },
                    { 1, "Petros50" },
                    { 1, "Petros77" },
                    { 1, "Sotirios.Kalogiannis43" },
                    { 1, "Sotirios.THeodosioy" },
                    { 1, "Sotirios_Zervos" },
                    { 1, "Spyros97" },
                    { 1, "Spyros_Anastasiadis" },
                    { 1, "Stayros.Koronaios" },
                    { 1, "Stayros_Bergas29" },
                    { 1, "Stefanos.Loypis27" },
                    { 1, "Stefanos.Nikolaidis21" },
                    { 1, "Stylianos.Basileiadis" },
                    { 1, "Stylianos.Mitzoy" },
                    { 1, "THeodoros.Basileiadis2" },
                    { 1, "THeodoros68" },
                    { 1, "Xaralampos43" },
                    { 1, "Xaralampos68" },
                    { 1, "Xaralampos74" },
                    { 1, "Xristos80" },
                    { 1, "Xristos85" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_UserRoles_Username",
                table: "UserRoles",
                column: "Username");

            migrationBuilder.AddForeignKey(
                name: "FK_Courses_CourseMetadatas_CourseCode",
                table: "Courses",
                column: "CourseCode",
                principalTable: "CourseMetadatas",
                principalColumn: "CourseCode",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_DegreeParticipations_Degree_DegreeName",
                table: "DegreeParticipations",
                column: "DegreeName",
                principalTable: "Degree",
                principalColumn: "Name",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Courses_CourseMetadatas_CourseCode",
                table: "Courses");

            migrationBuilder.DropForeignKey(
                name: "FK_DegreeParticipations_Degree_DegreeName",
                table: "DegreeParticipations");

            migrationBuilder.DropTable(
                name: "Degree");

            migrationBuilder.DropTable(
                name: "UserRoles");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CourseMetadatas",
                table: "CourseMetadatas");

            migrationBuilder.DeleteData(
                table: "ClassRooms",
                keyColumns: new[] { "Address", "RoomNumber" },
                keyValues: new object[] { "04171 Κακριδής Drive, West Παναγιώτης, Rwanda", "21" });

            migrationBuilder.DeleteData(
                table: "ClassRooms",
                keyColumns: new[] { "Address", "RoomNumber" },
                keyValues: new object[] { "043 Παρασκευάς Tunnel, Port Άγγελοςberg, Finland", "299" });

            migrationBuilder.DeleteData(
                table: "ClassRooms",
                keyColumns: new[] { "Address", "RoomNumber" },
                keyValues: new object[] { "04836 Ζαφειρόπουλος Villages, Port Αναστάσιοςtown, Ireland", "153" });

            migrationBuilder.DeleteData(
                table: "ClassRooms",
                keyColumns: new[] { "Address", "RoomNumber" },
                keyValues: new object[] { "0534 Ιωάννης Lights, Κομνηνόςfort, Macao", "329" });

            migrationBuilder.DeleteData(
                table: "ClassRooms",
                keyColumns: new[] { "Address", "RoomNumber" },
                keyValues: new object[] { "072 Κοσμόπουλος Oval, Μητσοτάκηςstad, Angola", "218" });

            migrationBuilder.DeleteData(
                table: "ClassRooms",
                keyColumns: new[] { "Address", "RoomNumber" },
                keyValues: new object[] { "09393 Παπανδρέου Route, Μαλαξόςhaven, Latvia", "50" });

            migrationBuilder.DeleteData(
                table: "ClassRooms",
                keyColumns: new[] { "Address", "RoomNumber" },
                keyValues: new object[] { "0941 Μιαούλης Forge, Νικόλαοςburgh, Uruguay", "309" });

            migrationBuilder.DeleteData(
                table: "ClassRooms",
                keyColumns: new[] { "Address", "RoomNumber" },
                keyValues: new object[] { "095 Ελευθέριος Meadows, New Παναγιώτηςtown, Svalbard & Jan Mayen Islands", "103" });

            migrationBuilder.DeleteData(
                table: "ClassRooms",
                keyColumns: new[] { "Address", "RoomNumber" },
                keyValues: new object[] { "097 Διονύσιος Tunnel, West Αντώνης, Pakistan", "129" });

            migrationBuilder.DeleteData(
                table: "ClassRooms",
                keyColumns: new[] { "Address", "RoomNumber" },
                keyValues: new object[] { "10111 Γρηγόριος Fort, Ευστάθιοςhaven, Luxembourg", "39" });

            migrationBuilder.DeleteData(
                table: "ClassRooms",
                keyColumns: new[] { "Address", "RoomNumber" },
                keyValues: new object[] { "103 Καλαμογδάρτης Roads, Port Πέτροςville, Guadeloupe", "197" });

            migrationBuilder.DeleteData(
                table: "ClassRooms",
                keyColumns: new[] { "Address", "RoomNumber" },
                keyValues: new object[] { "1371 Φώτιος Wells, Φώτιοςview, Serbia", "295" });

            migrationBuilder.DeleteData(
                table: "ClassRooms",
                keyColumns: new[] { "Address", "RoomNumber" },
                keyValues: new object[] { "13999 Κορωναίος Mount, Ασπάσιοςburgh, United Arab Emirates", "266" });

            migrationBuilder.DeleteData(
                table: "ClassRooms",
                keyColumns: new[] { "Address", "RoomNumber" },
                keyValues: new object[] { "144 Γεννάδιος Road, Lake Λεωνίδαςstad, Taiwan", "339" });

            migrationBuilder.DeleteData(
                table: "ClassRooms",
                keyColumns: new[] { "Address", "RoomNumber" },
                keyValues: new object[] { "1449 Πέτρος Underpass, South Αριστείδης, Croatia", "333" });

            migrationBuilder.DeleteData(
                table: "ClassRooms",
                keyColumns: new[] { "Address", "RoomNumber" },
                keyValues: new object[] { "20133 Καλλιγάς Tunnel, Παναγιώτηςmouth, Latvia", "18" });

            migrationBuilder.DeleteData(
                table: "ClassRooms",
                keyColumns: new[] { "Address", "RoomNumber" },
                keyValues: new object[] { "211 Μαρκόπουλος Gardens, Παπαδάκηςtown, Mauritius", "111" });

            migrationBuilder.DeleteData(
                table: "ClassRooms",
                keyColumns: new[] { "Address", "RoomNumber" },
                keyValues: new object[] { "2243 Παπακωνσταντίνου Fields, Βασίληςview, Fiji", "123" });

            migrationBuilder.DeleteData(
                table: "ClassRooms",
                keyColumns: new[] { "Address", "RoomNumber" },
                keyValues: new object[] { "229 Παπαφιλίππου Ridges, North Νικόλαος, Pakistan", "318" });

            migrationBuilder.DeleteData(
                table: "ClassRooms",
                keyColumns: new[] { "Address", "RoomNumber" },
                keyValues: new object[] { "23758 Αντώνης Inlet, Αθανασίουhaven, Swaziland", "294" });

            migrationBuilder.DeleteData(
                table: "ClassRooms",
                keyColumns: new[] { "Address", "RoomNumber" },
                keyValues: new object[] { "23973 Ηλίας Mills, Στυλιανόςshire, Palau", "325" });

            migrationBuilder.DeleteData(
                table: "ClassRooms",
                keyColumns: new[] { "Address", "RoomNumber" },
                keyValues: new object[] { "253 Καλλιγάς Port, Ιωαννίδηςhaven, Cook Islands", "72" });

            migrationBuilder.DeleteData(
                table: "ClassRooms",
                keyColumns: new[] { "Address", "RoomNumber" },
                keyValues: new object[] { "25392 Ευστάθιος Estates, West Ευάγγελος, Guernsey", "168" });

            migrationBuilder.DeleteData(
                table: "ClassRooms",
                keyColumns: new[] { "Address", "RoomNumber" },
                keyValues: new object[] { "256 Αλεξάκης Radial, Δημήτρηςstad, Guernsey", "135" });

            migrationBuilder.DeleteData(
                table: "ClassRooms",
                keyColumns: new[] { "Address", "RoomNumber" },
                keyValues: new object[] { "25789 Ελευθερόπουλος Common, Θεόδωροςmouth, Qatar", "209" });

            migrationBuilder.DeleteData(
                table: "ClassRooms",
                keyColumns: new[] { "Address", "RoomNumber" },
                keyValues: new object[] { "279 Βασιλικός Prairie, Διδασκάλουberg, Netherlands Antilles", "37" });

            migrationBuilder.DeleteData(
                table: "ClassRooms",
                keyColumns: new[] { "Address", "RoomNumber" },
                keyValues: new object[] { "2857 Παύλος Mall, West Ελευθέριοςhaven, Armenia", "141" });

            migrationBuilder.DeleteData(
                table: "ClassRooms",
                keyColumns: new[] { "Address", "RoomNumber" },
                keyValues: new object[] { "28710 Διαμαντόπουλος Ramp, Κοντολέωνberg, Jordan", "223" });

            migrationBuilder.DeleteData(
                table: "ClassRooms",
                keyColumns: new[] { "Address", "RoomNumber" },
                keyValues: new object[] { "2879 Δραγούμης Dale, South Εμμανουήλ, Switzerland", "206" });

            migrationBuilder.DeleteData(
                table: "ClassRooms",
                keyColumns: new[] { "Address", "RoomNumber" },
                keyValues: new object[] { "299 Άγγελος Crescent, Βασιλικόςtown, Suriname", "177" });

            migrationBuilder.DeleteData(
                table: "ClassRooms",
                keyColumns: new[] { "Address", "RoomNumber" },
                keyValues: new object[] { "308 Μπουκουβαλαίοι Mews, New Άγγελος, Kyrgyz Republic", "105" });

            migrationBuilder.DeleteData(
                table: "ClassRooms",
                keyColumns: new[] { "Address", "RoomNumber" },
                keyValues: new object[] { "314 Μιχαήλ Center, Βέργαςmouth, Armenia", "329" });

            migrationBuilder.DeleteData(
                table: "ClassRooms",
                keyColumns: new[] { "Address", "RoomNumber" },
                keyValues: new object[] { "31688 Αλέξανδρος Loop, East Παναγιώτης, Guadeloupe", "136" });

            migrationBuilder.DeleteData(
                table: "ClassRooms",
                keyColumns: new[] { "Address", "RoomNumber" },
                keyValues: new object[] { "32635 Αλιβιζάτος Meadows, Lake Ευστάθιοςbury, Mongolia", "184" });

            migrationBuilder.DeleteData(
                table: "ClassRooms",
                keyColumns: new[] { "Address", "RoomNumber" },
                keyValues: new object[] { "333 Μήτζου Run, Lake Αθανάσιος, Sierra Leone", "166" });

            migrationBuilder.DeleteData(
                table: "ClassRooms",
                keyColumns: new[] { "Address", "RoomNumber" },
                keyValues: new object[] { "33467 Χρήστος Mews, Κουρμούληςshire, Oman", "258" });

            migrationBuilder.DeleteData(
                table: "ClassRooms",
                keyColumns: new[] { "Address", "RoomNumber" },
                keyValues: new object[] { "33492 Εμμανουήλ Key, Κούνδουροςland, Denmark", "235" });

            migrationBuilder.DeleteData(
                table: "ClassRooms",
                keyColumns: new[] { "Address", "RoomNumber" },
                keyValues: new object[] { "340 Στυλιανός Greens, North Απόστολος, Egypt", "320" });

            migrationBuilder.DeleteData(
                table: "ClassRooms",
                keyColumns: new[] { "Address", "RoomNumber" },
                keyValues: new object[] { "34052 Διονύσιος Well, East Ευστάθιος, Liberia", "259" });

            migrationBuilder.DeleteData(
                table: "ClassRooms",
                keyColumns: new[] { "Address", "RoomNumber" },
                keyValues: new object[] { "348 Λιακόπουλος Prairie, Γεννάδιοςport, Uruguay", "114" });

            migrationBuilder.DeleteData(
                table: "ClassRooms",
                keyColumns: new[] { "Address", "RoomNumber" },
                keyValues: new object[] { "34999 Σωτήριος Rest, South Παναγιώτης, Grenada", "126" });

            migrationBuilder.DeleteData(
                table: "ClassRooms",
                keyColumns: new[] { "Address", "RoomNumber" },
                keyValues: new object[] { "360 Βικελίδης Trail, South Νικόλαος, Bulgaria", "79" });

            migrationBuilder.DeleteData(
                table: "ClassRooms",
                keyColumns: new[] { "Address", "RoomNumber" },
                keyValues: new object[] { "38124 Αλεξανδρίδης Heights, New Σπύροςburgh, Canada", "263" });

            migrationBuilder.DeleteData(
                table: "ClassRooms",
                keyColumns: new[] { "Address", "RoomNumber" },
                keyValues: new object[] { "401 Ανδρέας Camp, Λιάπηςbury, Chad", "21" });

            migrationBuilder.DeleteData(
                table: "ClassRooms",
                keyColumns: new[] { "Address", "RoomNumber" },
                keyValues: new object[] { "4879 Λύκος Mills, Στέφανοςstad, Saint Pierre and Miquelon", "79" });

            migrationBuilder.DeleteData(
                table: "ClassRooms",
                keyColumns: new[] { "Address", "RoomNumber" },
                keyValues: new object[] { "48878 Αλεξάνδρου Mountain, East Ιωάννηςland, Malaysia", "73" });

            migrationBuilder.DeleteData(
                table: "ClassRooms",
                keyColumns: new[] { "Address", "RoomNumber" },
                keyValues: new object[] { "490 Πανταζής Avenue, Ανδρεάδηςshire, Thailand", "300" });

            migrationBuilder.DeleteData(
                table: "ClassRooms",
                keyColumns: new[] { "Address", "RoomNumber" },
                keyValues: new object[] { "49082 Αθανάσιος Knoll, Port Απόστολοςborough, Monaco", "161" });

            migrationBuilder.DeleteData(
                table: "ClassRooms",
                keyColumns: new[] { "Address", "RoomNumber" },
                keyValues: new object[] { "4954 Παπακώστας Shore, Γεώργιοςbury, Saint Barthelemy", "203" });

            migrationBuilder.DeleteData(
                table: "ClassRooms",
                keyColumns: new[] { "Address", "RoomNumber" },
                keyValues: new object[] { "5300 Ανδρέας Cliffs, Βαρνακιώτηςberg, Burundi", "53" });

            migrationBuilder.DeleteData(
                table: "ClassRooms",
                keyColumns: new[] { "Address", "RoomNumber" },
                keyValues: new object[] { "54500 Δοξαράς Parkways, New Στέφανος, Jordan", "311" });

            migrationBuilder.DeleteData(
                table: "ClassRooms",
                keyColumns: new[] { "Address", "RoomNumber" },
                keyValues: new object[] { "56697 Ευταξίας Lodge, North Λεωνίδαςtown, Venezuela", "290" });

            migrationBuilder.DeleteData(
                table: "ClassRooms",
                keyColumns: new[] { "Address", "RoomNumber" },
                keyValues: new object[] { "56800 Ηλίας Inlet, West Νικόλαοςshire, Bahamas", "49" });

            migrationBuilder.DeleteData(
                table: "ClassRooms",
                keyColumns: new[] { "Address", "RoomNumber" },
                keyValues: new object[] { "5763 Ευάγγελος Flat, West Χρήστοςville, South Georgia and the South Sandwich Islands", "73" });

            migrationBuilder.DeleteData(
                table: "ClassRooms",
                keyColumns: new[] { "Address", "RoomNumber" },
                keyValues: new object[] { "5843 Δημήτρης Forges, North Ευστάθιοςside, Croatia", "127" });

            migrationBuilder.DeleteData(
                table: "ClassRooms",
                keyColumns: new[] { "Address", "RoomNumber" },
                keyValues: new object[] { "6026 Διονύσιος Ramp, Καζαντζήςmouth, Cape Verde", "121" });

            migrationBuilder.DeleteData(
                table: "ClassRooms",
                keyColumns: new[] { "Address", "RoomNumber" },
                keyValues: new object[] { "60674 Λιάπης Stream, South Λεωνίδαςborough, Afghanistan", "57" });

            migrationBuilder.DeleteData(
                table: "ClassRooms",
                keyColumns: new[] { "Address", "RoomNumber" },
                keyValues: new object[] { "6068 Παπάζογλου Plain, North Παναγιώτηςtown, Barbados", "187" });

            migrationBuilder.DeleteData(
                table: "ClassRooms",
                keyColumns: new[] { "Address", "RoomNumber" },
                keyValues: new object[] { "619 Αντωνόπουλος Port, New Παύλοςmouth, Cayman Islands", "323" });

            migrationBuilder.DeleteData(
                table: "ClassRooms",
                keyColumns: new[] { "Address", "RoomNumber" },
                keyValues: new object[] { "6274 Αρβανίτης Course, Αναγνώστουfort, Senegal", "226" });

            migrationBuilder.DeleteData(
                table: "ClassRooms",
                keyColumns: new[] { "Address", "RoomNumber" },
                keyValues: new object[] { "62836 Δάβης Parkway, West Αντώνηςburgh, Mayotte", "295" });

            migrationBuilder.DeleteData(
                table: "ClassRooms",
                keyColumns: new[] { "Address", "RoomNumber" },
                keyValues: new object[] { "6314 Αλέξανδρος Plains, Αθανάσιοςfort, Macao", "43" });

            migrationBuilder.DeleteData(
                table: "ClassRooms",
                keyColumns: new[] { "Address", "RoomNumber" },
                keyValues: new object[] { "63793 Κεδίκογλου Meadows, Αναστάσιοςfort, Tajikistan", "73" });

            migrationBuilder.DeleteData(
                table: "ClassRooms",
                keyColumns: new[] { "Address", "RoomNumber" },
                keyValues: new object[] { "638 Μαυρογένης Fall, New Στυλιανός, Andorra", "306" });

            migrationBuilder.DeleteData(
                table: "ClassRooms",
                keyColumns: new[] { "Address", "RoomNumber" },
                keyValues: new object[] { "6430 Ζαχαρίου Heights, Διονύσιοςfurt, Bhutan", "311" });

            migrationBuilder.DeleteData(
                table: "ClassRooms",
                keyColumns: new[] { "Address", "RoomNumber" },
                keyValues: new object[] { "646 Σωτήριος Drives, Στυλιανόςland, Uzbekistan", "318" });

            migrationBuilder.DeleteData(
                table: "ClassRooms",
                keyColumns: new[] { "Address", "RoomNumber" },
                keyValues: new object[] { "6483 Μαλαξός Centers, Αλαβάνοςburgh, Saint Kitts and Nevis", "239" });

            migrationBuilder.DeleteData(
                table: "ClassRooms",
                keyColumns: new[] { "Address", "RoomNumber" },
                keyValues: new object[] { "6616 Καλάρης Terrace, Μαυρογένηςfort, Azerbaijan", "51" });

            migrationBuilder.DeleteData(
                table: "ClassRooms",
                keyColumns: new[] { "Address", "RoomNumber" },
                keyValues: new object[] { "66542 Γρηγόριος Creek, Port Αντώνηςborough, Norfolk Island", "165" });

            migrationBuilder.DeleteData(
                table: "ClassRooms",
                keyColumns: new[] { "Address", "RoomNumber" },
                keyValues: new object[] { "6713 Παπαστεφάνου Mill, East Κώστας, Italy", "195" });

            migrationBuilder.DeleteData(
                table: "ClassRooms",
                keyColumns: new[] { "Address", "RoomNumber" },
                keyValues: new object[] { "67673 Διαμαντόπουλος Hill, New Δημήτρηςburgh, Portugal", "313" });

            migrationBuilder.DeleteData(
                table: "ClassRooms",
                keyColumns: new[] { "Address", "RoomNumber" },
                keyValues: new object[] { "68124 Σπύρος Knolls, West Μιχαήλ, Tunisia", "217" });

            migrationBuilder.DeleteData(
                table: "ClassRooms",
                keyColumns: new[] { "Address", "RoomNumber" },
                keyValues: new object[] { "685 Αντώνης Way, South Παύλος, Fiji", "279" });

            migrationBuilder.DeleteData(
                table: "ClassRooms",
                keyColumns: new[] { "Address", "RoomNumber" },
                keyValues: new object[] { "718 Λεωνίδας Orchard, Γιάνναρηςfurt, Mexico", "157" });

            migrationBuilder.DeleteData(
                table: "ClassRooms",
                keyColumns: new[] { "Address", "RoomNumber" },
                keyValues: new object[] { "72392 Παρασκευάς Locks, West Άγγελοςton, Russian Federation", "192" });

            migrationBuilder.DeleteData(
                table: "ClassRooms",
                keyColumns: new[] { "Address", "RoomNumber" },
                keyValues: new object[] { "7355 Παρασκευάς Islands, New Πέτρος, Papua New Guinea", "70" });

            migrationBuilder.DeleteData(
                table: "ClassRooms",
                keyColumns: new[] { "Address", "RoomNumber" },
                keyValues: new object[] { "753 Δελή Field, Μαλαξόςburgh, Portugal", "184" });

            migrationBuilder.DeleteData(
                table: "ClassRooms",
                keyColumns: new[] { "Address", "RoomNumber" },
                keyValues: new object[] { "75519 Σταύρος Fort, Port Παναγιώτηςfort, Peru", "132" });

            migrationBuilder.DeleteData(
                table: "ClassRooms",
                keyColumns: new[] { "Address", "RoomNumber" },
                keyValues: new object[] { "75843 Βενιζέλος Lake, North Χαράλαμποςton, Uruguay", "182" });

            migrationBuilder.DeleteData(
                table: "ClassRooms",
                keyColumns: new[] { "Address", "RoomNumber" },
                keyValues: new object[] { "77195 Στυλιανός Lake, Παπαδόπουλοςmouth, Bahamas", "291" });

            migrationBuilder.DeleteData(
                table: "ClassRooms",
                keyColumns: new[] { "Address", "RoomNumber" },
                keyValues: new object[] { "7978 Αναστάσιος Dam, South Δημήτρηςbury, Saint Pierre and Miquelon", "284" });

            migrationBuilder.DeleteData(
                table: "ClassRooms",
                keyColumns: new[] { "Address", "RoomNumber" },
                keyValues: new object[] { "79800 Άγγελος Station, West Ελευθέριος, Lebanon", "144" });

            migrationBuilder.DeleteData(
                table: "ClassRooms",
                keyColumns: new[] { "Address", "RoomNumber" },
                keyValues: new object[] { "799 Ελευθερόπουλος Union, South Γεώργιος, Germany", "310" });

            migrationBuilder.DeleteData(
                table: "ClassRooms",
                keyColumns: new[] { "Address", "RoomNumber" },
                keyValues: new object[] { "8094 Στέφανος Lock, West Χαράλαμπος, Qatar", "242" });

            migrationBuilder.DeleteData(
                table: "ClassRooms",
                keyColumns: new[] { "Address", "RoomNumber" },
                keyValues: new object[] { "821 Διονύσιος Ferry, Διονύσιοςstad, Saint Barthelemy", "198" });

            migrationBuilder.DeleteData(
                table: "ClassRooms",
                keyColumns: new[] { "Address", "RoomNumber" },
                keyValues: new object[] { "85225 Αλέξανδρος Summit, Αγγελοπούλουmouth, Palau", "170" });

            migrationBuilder.DeleteData(
                table: "ClassRooms",
                keyColumns: new[] { "Address", "RoomNumber" },
                keyValues: new object[] { "859 Διονύσιος Stravenue, New Φώτιοςton, Pitcairn Islands", "24" });

            migrationBuilder.DeleteData(
                table: "ClassRooms",
                keyColumns: new[] { "Address", "RoomNumber" },
                keyValues: new object[] { "868 Βικελίδης Underpass, North Παύλος, Japan", "243" });

            migrationBuilder.DeleteData(
                table: "ClassRooms",
                keyColumns: new[] { "Address", "RoomNumber" },
                keyValues: new object[] { "882 Άγγελος Turnpike, North Φώτιοςmouth, Luxembourg", "268" });

            migrationBuilder.DeleteData(
                table: "ClassRooms",
                keyColumns: new[] { "Address", "RoomNumber" },
                keyValues: new object[] { "882 Ζέρβας Stream, Ευστάθιοςborough, Pitcairn Islands", "55" });

            migrationBuilder.DeleteData(
                table: "ClassRooms",
                keyColumns: new[] { "Address", "RoomNumber" },
                keyValues: new object[] { "8821 Παρασκευάς Land, Ανδρέαςville, Sri Lanka", "45" });

            migrationBuilder.DeleteData(
                table: "ClassRooms",
                keyColumns: new[] { "Address", "RoomNumber" },
                keyValues: new object[] { "88467 Γαλάνης Street, South Ελευθέριοςmouth, Bouvet Island (Bouvetoya)", "268" });

            migrationBuilder.DeleteData(
                table: "ClassRooms",
                keyColumns: new[] { "Address", "RoomNumber" },
                keyValues: new object[] { "88490 Ιωάννης Highway, Ευστάθιοςchester, Tanzania", "138" });

            migrationBuilder.DeleteData(
                table: "ClassRooms",
                keyColumns: new[] { "Address", "RoomNumber" },
                keyValues: new object[] { "89875 Ευάγγελος Fields, New Νικόλαος, Niger", "49" });

            migrationBuilder.DeleteData(
                table: "ClassRooms",
                keyColumns: new[] { "Address", "RoomNumber" },
                keyValues: new object[] { "8990 Εμμανουήλ Crossroad, New Βασίληςburgh, South Georgia and the South Sandwich Islands", "40" });

            migrationBuilder.DeleteData(
                table: "ClassRooms",
                keyColumns: new[] { "Address", "RoomNumber" },
                keyValues: new object[] { "9093 Παπακωνσταντίνου Road, Γούσιοςstad, Nepal", "166" });

            migrationBuilder.DeleteData(
                table: "ClassRooms",
                keyColumns: new[] { "Address", "RoomNumber" },
                keyValues: new object[] { "91858 Αγγελοπούλου Throughway, Lake Κώστας, Cote d'Ivoire", "35" });

            migrationBuilder.DeleteData(
                table: "ClassRooms",
                keyColumns: new[] { "Address", "RoomNumber" },
                keyValues: new object[] { "94768 Σταύρος Flats, South Ηλίας, New Zealand", "329" });

            migrationBuilder.DeleteData(
                table: "ClassRooms",
                keyColumns: new[] { "Address", "RoomNumber" },
                keyValues: new object[] { "9915 Διδασκάλου Neck, South Στέφανος, Serbia", "190" });

            migrationBuilder.DeleteData(
                table: "ClassRooms",
                keyColumns: new[] { "Address", "RoomNumber" },
                keyValues: new object[] { "99241 Αλαβάνος Land, Άγγελοςmouth, Dominica", "250" });

            migrationBuilder.DeleteData(
                table: "DegreeParticipations",
                keyColumns: new[] { "DegreeName", "Username" },
                keyValues: new object[] { "Games & Toys (297)", "Aggelos.Aggelidoy35" });

            migrationBuilder.DeleteData(
                table: "DegreeParticipations",
                keyColumns: new[] { "DegreeName", "Username" },
                keyValues: new object[] { "Electronics (266)", "Aggelos6" });

            migrationBuilder.DeleteData(
                table: "DegreeParticipations",
                keyColumns: new[] { "DegreeName", "Username" },
                keyValues: new object[] { "Games & Toys (297)", "Aggelos87" });

            migrationBuilder.DeleteData(
                table: "DegreeParticipations",
                keyColumns: new[] { "DegreeName", "Username" },
                keyValues: new object[] { "Toys (259)", "Aggelos_Georgiadis30" });

            migrationBuilder.DeleteData(
                table: "DegreeParticipations",
                keyColumns: new[] { "DegreeName", "Username" },
                keyValues: new object[] { "Books (290)", "Aleksandros.Zervos61" });

            migrationBuilder.DeleteData(
                table: "DegreeParticipations",
                keyColumns: new[] { "DegreeName", "Username" },
                keyValues: new object[] { "Baby (279)", "Aleksandros41" });

            migrationBuilder.DeleteData(
                table: "DegreeParticipations",
                keyColumns: new[] { "DegreeName", "Username" },
                keyValues: new object[] { "Baby (283)", "Anastasios_Bilaetis84" });

            migrationBuilder.DeleteData(
                table: "DegreeParticipations",
                keyColumns: new[] { "DegreeName", "Username" },
                keyValues: new object[] { "Music, Movies & Industrial (280)", "Anastasios_Nikolakos52" });

            migrationBuilder.DeleteData(
                table: "DegreeParticipations",
                keyColumns: new[] { "DegreeName", "Username" },
                keyValues: new object[] { "Health, Toys & Outdoors (255)", "Andreas22" });

            migrationBuilder.DeleteData(
                table: "DegreeParticipations",
                keyColumns: new[] { "DegreeName", "Username" },
                keyValues: new object[] { "Garden (271)", "Andreas52" });

            migrationBuilder.DeleteData(
                table: "DegreeParticipations",
                keyColumns: new[] { "DegreeName", "Username" },
                keyValues: new object[] { "Sports, Computers & Electronics (277)", "Andreas95" });

            migrationBuilder.DeleteData(
                table: "DegreeParticipations",
                keyColumns: new[] { "DegreeName", "Username" },
                keyValues: new object[] { "Shoes & Toys (268)", "Andreas_Bikelidis33" });

            migrationBuilder.DeleteData(
                table: "DegreeParticipations",
                keyColumns: new[] { "DegreeName", "Username" },
                keyValues: new object[] { "Jewelery, Automotive & Garden (276)", "Antonis.Lytras" });

            migrationBuilder.DeleteData(
                table: "DegreeParticipations",
                keyColumns: new[] { "DegreeName", "Username" },
                keyValues: new object[] { "Books & Sports (273)", "Antonis4" });

            migrationBuilder.DeleteData(
                table: "DegreeParticipations",
                keyColumns: new[] { "DegreeName", "Username" },
                keyValues: new object[] { "Electronics (266)", "Antonis_Antonopoylos" });

            migrationBuilder.DeleteData(
                table: "DegreeParticipations",
                keyColumns: new[] { "DegreeName", "Username" },
                keyValues: new object[] { "Home (264)", "Antonis_Diamantopoylos43" });

            migrationBuilder.DeleteData(
                table: "DegreeParticipations",
                keyColumns: new[] { "DegreeName", "Username" },
                keyValues: new object[] { "Industrial, Toys & Automotive (250)", "Antonis_Karamanlis" });

            migrationBuilder.DeleteData(
                table: "DegreeParticipations",
                keyColumns: new[] { "DegreeName", "Username" },
                keyValues: new object[] { "Clothing, Electronics & Jewelery (253)", "Antonis_Melioi26" });

            migrationBuilder.DeleteData(
                table: "DegreeParticipations",
                keyColumns: new[] { "DegreeName", "Username" },
                keyValues: new object[] { "Garden (260)", "Apostolos.Kypraios" });

            migrationBuilder.DeleteData(
                table: "DegreeParticipations",
                keyColumns: new[] { "DegreeName", "Username" },
                keyValues: new object[] { "Kids & Tools (265)", "Apostolos44" });

            migrationBuilder.DeleteData(
                table: "DegreeParticipations",
                keyColumns: new[] { "DegreeName", "Username" },
                keyValues: new object[] { "Shoes & Kids (281)", "Apostolos75" });

            migrationBuilder.DeleteData(
                table: "DegreeParticipations",
                keyColumns: new[] { "DegreeName", "Username" },
                keyValues: new object[] { "Electronics & Jewelery (282)", "Apostolos_Daskalopoylos" });

            migrationBuilder.DeleteData(
                table: "DegreeParticipations",
                keyColumns: new[] { "DegreeName", "Username" },
                keyValues: new object[] { "Baby (283)", "Aristeidis.Aleksandroy12" });

            migrationBuilder.DeleteData(
                table: "DegreeParticipations",
                keyColumns: new[] { "DegreeName", "Username" },
                keyValues: new object[] { "Sports, Computers & Electronics (277)", "Aristeidis.Papanikolaoy" });

            migrationBuilder.DeleteData(
                table: "DegreeParticipations",
                keyColumns: new[] { "DegreeName", "Username" },
                keyValues: new object[] { "Automotive, Garden & Beauty (261)", "Aristeidis_Melioi" });

            migrationBuilder.DeleteData(
                table: "DegreeParticipations",
                keyColumns: new[] { "DegreeName", "Username" },
                keyValues: new object[] { "Sports, Computers & Electronics (277)", "Basilis.Koytalianos17" });

            migrationBuilder.DeleteData(
                table: "DegreeParticipations",
                keyColumns: new[] { "DegreeName", "Username" },
                keyValues: new object[] { "Sports, Kids & Industrial (291)", "Basilis61" });

            migrationBuilder.DeleteData(
                table: "DegreeParticipations",
                keyColumns: new[] { "DegreeName", "Username" },
                keyValues: new object[] { "Electronics (251)", "Basilis_Oikonomoy" });

            migrationBuilder.DeleteData(
                table: "DegreeParticipations",
                keyColumns: new[] { "DegreeName", "Username" },
                keyValues: new object[] { "Kids & Baby (287)", "Dimitris28" });

            migrationBuilder.DeleteData(
                table: "DegreeParticipations",
                keyColumns: new[] { "DegreeName", "Username" },
                keyValues: new object[] { "Shoes & Kids (281)", "Dionysios.Anagnostakis" });

            migrationBuilder.DeleteData(
                table: "DegreeParticipations",
                keyColumns: new[] { "DegreeName", "Username" },
                keyValues: new object[] { "Garden (262)", "Dionysios.Lytras" });

            migrationBuilder.DeleteData(
                table: "DegreeParticipations",
                keyColumns: new[] { "DegreeName", "Username" },
                keyValues: new object[] { "Books (290)", "Dionysios_Deli12" });

            migrationBuilder.DeleteData(
                table: "DegreeParticipations",
                keyColumns: new[] { "DegreeName", "Username" },
                keyValues: new object[] { "Electronics (266)", "Eleytherios.Eleytherioy" });

            migrationBuilder.DeleteData(
                table: "DegreeParticipations",
                keyColumns: new[] { "DegreeName", "Username" },
                keyValues: new object[] { "Beauty (269)", "Eleytherios_Didaskaloy" });

            migrationBuilder.DeleteData(
                table: "DegreeParticipations",
                keyColumns: new[] { "DegreeName", "Username" },
                keyValues: new object[] { "Kids & Tools (265)", "Emmanoyil.Georgiadis" });

            migrationBuilder.DeleteData(
                table: "DegreeParticipations",
                keyColumns: new[] { "DegreeName", "Username" },
                keyValues: new object[] { "Electronics (251)", "Emmanoyil_Aleksioy5" });

            migrationBuilder.DeleteData(
                table: "DegreeParticipations",
                keyColumns: new[] { "DegreeName", "Username" },
                keyValues: new object[] { "Toys (267)", "Emmanoyil_Koyndoyros" });

            migrationBuilder.DeleteData(
                table: "DegreeParticipations",
                keyColumns: new[] { "DegreeName", "Username" },
                keyValues: new object[] { "Baby (279)", "Emmanoyil_Maris67" });

            migrationBuilder.DeleteData(
                table: "DegreeParticipations",
                keyColumns: new[] { "DegreeName", "Username" },
                keyValues: new object[] { "Beauty (269)", "Eyaggelos_Koromilas73" });

            migrationBuilder.DeleteData(
                table: "DegreeParticipations",
                keyColumns: new[] { "DegreeName", "Username" },
                keyValues: new object[] { "Toys (267)", "Eystathios.Boyrdoympas" });

            migrationBuilder.DeleteData(
                table: "DegreeParticipations",
                keyColumns: new[] { "DegreeName", "Username" },
                keyValues: new object[] { "Books, Garden & Garden (275)", "Eystathios17" });

            migrationBuilder.DeleteData(
                table: "DegreeParticipations",
                keyColumns: new[] { "DegreeName", "Username" },
                keyValues: new object[] { "Computers & Health (285)", "Eystathios29" });

            migrationBuilder.DeleteData(
                table: "DegreeParticipations",
                keyColumns: new[] { "DegreeName", "Username" },
                keyValues: new object[] { "Shoes & Kids (281)", "Eystathios57" });

            migrationBuilder.DeleteData(
                table: "DegreeParticipations",
                keyColumns: new[] { "DegreeName", "Username" },
                keyValues: new object[] { "Games & Toys (297)", "Eystathios_Avramidis41" });

            migrationBuilder.DeleteData(
                table: "DegreeParticipations",
                keyColumns: new[] { "DegreeName", "Username" },
                keyValues: new object[] { "Home (264)", "Fotios.Andreoy51" });

            migrationBuilder.DeleteData(
                table: "DegreeParticipations",
                keyColumns: new[] { "DegreeName", "Username" },
                keyValues: new object[] { "Baby (283)", "Fotios90" });

            migrationBuilder.DeleteData(
                table: "DegreeParticipations",
                keyColumns: new[] { "DegreeName", "Username" },
                keyValues: new object[] { "Garden (271)", "Fotios_Karavias7" });

            migrationBuilder.DeleteData(
                table: "DegreeParticipations",
                keyColumns: new[] { "DegreeName", "Username" },
                keyValues: new object[] { "Clothing, Electronics & Jewelery (253)", "Georgios.Eytaksias" });

            migrationBuilder.DeleteData(
                table: "DegreeParticipations",
                keyColumns: new[] { "DegreeName", "Username" },
                keyValues: new object[] { "Electronics (251)", "Georgios2" });

            migrationBuilder.DeleteData(
                table: "DegreeParticipations",
                keyColumns: new[] { "DegreeName", "Username" },
                keyValues: new object[] { "Home (264)", "Georgios45" });

            migrationBuilder.DeleteData(
                table: "DegreeParticipations",
                keyColumns: new[] { "DegreeName", "Username" },
                keyValues: new object[] { "Books (290)", "Georgios79" });

            migrationBuilder.DeleteData(
                table: "DegreeParticipations",
                keyColumns: new[] { "DegreeName", "Username" },
                keyValues: new object[] { "Kids, Electronics & Movies (288)", "Georgios_Bilaetis20" });

            migrationBuilder.DeleteData(
                table: "DegreeParticipations",
                keyColumns: new[] { "DegreeName", "Username" },
                keyValues: new object[] { "Baby (283)", "Grigorios.Boylgaris" });

            migrationBuilder.DeleteData(
                table: "DegreeParticipations",
                keyColumns: new[] { "DegreeName", "Username" },
                keyValues: new object[] { "Baby (283)", "Grigorios_Kontoleon41" });

            migrationBuilder.DeleteData(
                table: "DegreeParticipations",
                keyColumns: new[] { "DegreeName", "Username" },
                keyValues: new object[] { "Baby (279)", "Ilias.Metaksas74" });

            migrationBuilder.DeleteData(
                table: "DegreeParticipations",
                keyColumns: new[] { "DegreeName", "Username" },
                keyValues: new object[] { "Kids & Tools (265)", "Ilias.Zafeiropoylos86" });

            migrationBuilder.DeleteData(
                table: "DegreeParticipations",
                keyColumns: new[] { "DegreeName", "Username" },
                keyValues: new object[] { "Baby (279)", "Ilias56" });

            migrationBuilder.DeleteData(
                table: "DegreeParticipations",
                keyColumns: new[] { "DegreeName", "Username" },
                keyValues: new object[] { "Garden (262)", "Ilias_Bamvas22" });

            migrationBuilder.DeleteData(
                table: "DegreeParticipations",
                keyColumns: new[] { "DegreeName", "Username" },
                keyValues: new object[] { "Kids, Electronics & Movies (288)", "Ioannis.Aygerinoseponymo0" });

            migrationBuilder.DeleteData(
                table: "DegreeParticipations",
                keyColumns: new[] { "DegreeName", "Username" },
                keyValues: new object[] { "Books (257)", "Ioannis.Zappas99" });

            migrationBuilder.DeleteData(
                table: "DegreeParticipations",
                keyColumns: new[] { "DegreeName", "Username" },
                keyValues: new object[] { "Electronics (266)", "Ioannis28" });

            migrationBuilder.DeleteData(
                table: "DegreeParticipations",
                keyColumns: new[] { "DegreeName", "Username" },
                keyValues: new object[] { "Garden (260)", "Ioannis_Basilopoylos" });

            migrationBuilder.DeleteData(
                table: "DegreeParticipations",
                keyColumns: new[] { "DegreeName", "Username" },
                keyValues: new object[] { "Industrial, Toys & Automotive (250)", "Kostas43" });

            migrationBuilder.DeleteData(
                table: "DegreeParticipations",
                keyColumns: new[] { "DegreeName", "Username" },
                keyValues: new object[] { "Clothing, Electronics & Jewelery (253)", "Kostas92" });

            migrationBuilder.DeleteData(
                table: "DegreeParticipations",
                keyColumns: new[] { "DegreeName", "Username" },
                keyValues: new object[] { "Jewelery, Automotive & Garden (276)", "Kostas_Byzantios65" });

            migrationBuilder.DeleteData(
                table: "DegreeParticipations",
                keyColumns: new[] { "DegreeName", "Username" },
                keyValues: new object[] { "Toys (259)", "Mixail.Bergas85" });

            migrationBuilder.DeleteData(
                table: "DegreeParticipations",
                keyColumns: new[] { "DegreeName", "Username" },
                keyValues: new object[] { "Movies & Toys (286)", "Mixail.Ioannoy" });

            migrationBuilder.DeleteData(
                table: "DegreeParticipations",
                keyColumns: new[] { "DegreeName", "Username" },
                keyValues: new object[] { "Toys (267)", "Mixail90" });

            migrationBuilder.DeleteData(
                table: "DegreeParticipations",
                keyColumns: new[] { "DegreeName", "Username" },
                keyValues: new object[] { "Beauty & Electronics (299)", "Nikolaos_Boyrdoympas15" });

            migrationBuilder.DeleteData(
                table: "DegreeParticipations",
                keyColumns: new[] { "DegreeName", "Username" },
                keyValues: new object[] { "Baby (283)", "Paraskeyas.Anagnostakis" });

            migrationBuilder.DeleteData(
                table: "DegreeParticipations",
                keyColumns: new[] { "DegreeName", "Username" },
                keyValues: new object[] { "Books (257)", "Paraskeyas_THeodoridis89" });

            migrationBuilder.DeleteData(
                table: "DegreeParticipations",
                keyColumns: new[] { "DegreeName", "Username" },
                keyValues: new object[] { "Books (257)", "Paylos.Giagkos" });

            migrationBuilder.DeleteData(
                table: "DegreeParticipations",
                keyColumns: new[] { "DegreeName", "Username" },
                keyValues: new object[] { "Baby (279)", "Paylos.Koyndoyros" });

            migrationBuilder.DeleteData(
                table: "DegreeParticipations",
                keyColumns: new[] { "DegreeName", "Username" },
                keyValues: new object[] { "Tools, Tools & Tools (284)", "Paylos18" });

            migrationBuilder.DeleteData(
                table: "DegreeParticipations",
                keyColumns: new[] { "DegreeName", "Username" },
                keyValues: new object[] { "Electronics (251)", "Paylos48" });

            migrationBuilder.DeleteData(
                table: "DegreeParticipations",
                keyColumns: new[] { "DegreeName", "Username" },
                keyValues: new object[] { "Garden, Kids & Outdoors (289)", "Paylos_Kalyvas76" });

            migrationBuilder.DeleteData(
                table: "DegreeParticipations",
                keyColumns: new[] { "DegreeName", "Username" },
                keyValues: new object[] { "Health, Toys & Outdoors (255)", "Petros.Blavianos51" });

            migrationBuilder.DeleteData(
                table: "DegreeParticipations",
                keyColumns: new[] { "DegreeName", "Username" },
                keyValues: new object[] { "Sports (274)", "Petros50" });

            migrationBuilder.DeleteData(
                table: "DegreeParticipations",
                keyColumns: new[] { "DegreeName", "Username" },
                keyValues: new object[] { "Automotive, Garden & Beauty (261)", "Petros77" });

            migrationBuilder.DeleteData(
                table: "DegreeParticipations",
                keyColumns: new[] { "DegreeName", "Username" },
                keyValues: new object[] { "Shoes & Toys (268)", "Sotirios.Germanos87" });

            migrationBuilder.DeleteData(
                table: "DegreeParticipations",
                keyColumns: new[] { "DegreeName", "Username" },
                keyValues: new object[] { "Tools, Tools & Tools (284)", "Sotirios.Kalogiannis43" });

            migrationBuilder.DeleteData(
                table: "DegreeParticipations",
                keyColumns: new[] { "DegreeName", "Username" },
                keyValues: new object[] { "Beauty & Electronics (299)", "Sotirios.THeodosioy" });

            migrationBuilder.DeleteData(
                table: "DegreeParticipations",
                keyColumns: new[] { "DegreeName", "Username" },
                keyValues: new object[] { "Industrial & Computers (252)", "Sotirios_Zervos" });

            migrationBuilder.DeleteData(
                table: "DegreeParticipations",
                keyColumns: new[] { "DegreeName", "Username" },
                keyValues: new object[] { "Baby (279)", "Spyros97" });

            migrationBuilder.DeleteData(
                table: "DegreeParticipations",
                keyColumns: new[] { "DegreeName", "Username" },
                keyValues: new object[] { "Home, Movies & Shoes (272)", "Spyros_Anastasiadis" });

            migrationBuilder.DeleteData(
                table: "DegreeParticipations",
                keyColumns: new[] { "DegreeName", "Username" },
                keyValues: new object[] { "Garden (262)", "Stayros.Koronaios" });

            migrationBuilder.DeleteData(
                table: "DegreeParticipations",
                keyColumns: new[] { "DegreeName", "Username" },
                keyValues: new object[] { "Outdoors, Home & Baby (292)", "Stayros_Bergas29" });

            migrationBuilder.DeleteData(
                table: "DegreeParticipations",
                keyColumns: new[] { "DegreeName", "Username" },
                keyValues: new object[] { "Books & Sports (273)", "Stefanos.Loypis27" });

            migrationBuilder.DeleteData(
                table: "DegreeParticipations",
                keyColumns: new[] { "DegreeName", "Username" },
                keyValues: new object[] { "Beauty (296)", "Stefanos.Nikolaidis21" });

            migrationBuilder.DeleteData(
                table: "DegreeParticipations",
                keyColumns: new[] { "DegreeName", "Username" },
                keyValues: new object[] { "Tools, Tools & Tools (284)", "Stylianos.Basileiadis" });

            migrationBuilder.DeleteData(
                table: "DegreeParticipations",
                keyColumns: new[] { "DegreeName", "Username" },
                keyValues: new object[] { "Toys, Outdoors & Toys (293)", "Stylianos.Mitzoy" });

            migrationBuilder.DeleteData(
                table: "DegreeParticipations",
                keyColumns: new[] { "DegreeName", "Username" },
                keyValues: new object[] { "Music & Grocery (258)", "THeodoros.Basileiadis2" });

            migrationBuilder.DeleteData(
                table: "DegreeParticipations",
                keyColumns: new[] { "DegreeName", "Username" },
                keyValues: new object[] { "Toys (259)", "THeodoros.Zafeiropoylos96" });

            migrationBuilder.DeleteData(
                table: "DegreeParticipations",
                keyColumns: new[] { "DegreeName", "Username" },
                keyValues: new object[] { "Home, Movies & Shoes (272)", "THeodoros68" });

            migrationBuilder.DeleteData(
                table: "DegreeParticipations",
                keyColumns: new[] { "DegreeName", "Username" },
                keyValues: new object[] { "Industrial & Shoes (270)", "Xaralampos43" });

            migrationBuilder.DeleteData(
                table: "DegreeParticipations",
                keyColumns: new[] { "DegreeName", "Username" },
                keyValues: new object[] { "Sports, Computers & Electronics (277)", "Xaralampos68" });

            migrationBuilder.DeleteData(
                table: "DegreeParticipations",
                keyColumns: new[] { "DegreeName", "Username" },
                keyValues: new object[] { "Electronics (251)", "Xaralampos74" });

            migrationBuilder.DeleteData(
                table: "DegreeParticipations",
                keyColumns: new[] { "DegreeName", "Username" },
                keyValues: new object[] { "Toys (295)", "Xristos.Aggelopoylos" });

            migrationBuilder.DeleteData(
                table: "DegreeParticipations",
                keyColumns: new[] { "DegreeName", "Username" },
                keyValues: new object[] { "Baby, Home & Jewelery (254)", "Xristos80" });

            migrationBuilder.DeleteData(
                table: "DegreeParticipations",
                keyColumns: new[] { "DegreeName", "Username" },
                keyValues: new object[] { "Electronics (251)", "Xristos85" });

            migrationBuilder.DeleteData(
                table: "DegreeParticipations",
                keyColumns: new[] { "DegreeName", "Username" },
                keyValues: new object[] { "Programtervező informatikus Bsc", "oktato" });

            migrationBuilder.DeleteData(
                table: "DegreeParticipations",
                keyColumns: new[] { "DegreeName", "Username" },
                keyValues: new object[] { "Programtervező informatikus Bsc", "tanulo" });

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Username",
                keyValue: "Aggelos.Aggelidoy35");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Username",
                keyValue: "Aggelos6");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Username",
                keyValue: "Aggelos87");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Username",
                keyValue: "Aggelos_Georgiadis30");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Username",
                keyValue: "Aleksandros.Zervos61");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Username",
                keyValue: "Aleksandros41");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Username",
                keyValue: "Anastasios_Bilaetis84");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Username",
                keyValue: "Anastasios_Nikolakos52");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Username",
                keyValue: "Andreas22");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Username",
                keyValue: "Andreas52");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Username",
                keyValue: "Andreas95");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Username",
                keyValue: "Andreas_Bikelidis33");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Username",
                keyValue: "Antonis.Lytras");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Username",
                keyValue: "Antonis4");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Username",
                keyValue: "Antonis_Antonopoylos");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Username",
                keyValue: "Antonis_Diamantopoylos43");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Username",
                keyValue: "Antonis_Karamanlis");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Username",
                keyValue: "Antonis_Melioi26");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Username",
                keyValue: "Apostolos.Kypraios");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Username",
                keyValue: "Apostolos44");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Username",
                keyValue: "Apostolos75");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Username",
                keyValue: "Apostolos_Daskalopoylos");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Username",
                keyValue: "Aristeidis.Aleksandroy12");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Username",
                keyValue: "Aristeidis.Papanikolaoy");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Username",
                keyValue: "Aristeidis_Melioi");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Username",
                keyValue: "Basilis.Koytalianos17");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Username",
                keyValue: "Basilis61");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Username",
                keyValue: "Basilis_Oikonomoy");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Username",
                keyValue: "Dimitris28");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Username",
                keyValue: "Dionysios.Anagnostakis");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Username",
                keyValue: "Dionysios.Lytras");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Username",
                keyValue: "Dionysios_Deli12");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Username",
                keyValue: "Eleytherios.Eleytherioy");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Username",
                keyValue: "Eleytherios_Didaskaloy");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Username",
                keyValue: "Emmanoyil.Georgiadis");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Username",
                keyValue: "Emmanoyil_Aleksioy5");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Username",
                keyValue: "Emmanoyil_Koyndoyros");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Username",
                keyValue: "Emmanoyil_Maris67");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Username",
                keyValue: "Eyaggelos_Koromilas73");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Username",
                keyValue: "Eystathios.Boyrdoympas");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Username",
                keyValue: "Eystathios17");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Username",
                keyValue: "Eystathios29");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Username",
                keyValue: "Eystathios57");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Username",
                keyValue: "Eystathios_Avramidis41");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Username",
                keyValue: "Fotios.Andreoy51");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Username",
                keyValue: "Fotios90");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Username",
                keyValue: "Fotios_Karavias7");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Username",
                keyValue: "Georgios.Eytaksias");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Username",
                keyValue: "Georgios2");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Username",
                keyValue: "Georgios45");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Username",
                keyValue: "Georgios79");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Username",
                keyValue: "Georgios_Bilaetis20");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Username",
                keyValue: "Grigorios.Boylgaris");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Username",
                keyValue: "Grigorios_Kontoleon41");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Username",
                keyValue: "Ilias.Metaksas74");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Username",
                keyValue: "Ilias.Zafeiropoylos86");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Username",
                keyValue: "Ilias56");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Username",
                keyValue: "Ilias_Bamvas22");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Username",
                keyValue: "Ioannis.Aygerinoseponymo0");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Username",
                keyValue: "Ioannis.Zappas99");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Username",
                keyValue: "Ioannis28");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Username",
                keyValue: "Ioannis_Basilopoylos");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Username",
                keyValue: "Kostas43");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Username",
                keyValue: "Kostas92");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Username",
                keyValue: "Kostas_Byzantios65");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Username",
                keyValue: "Mixail.Bergas85");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Username",
                keyValue: "Mixail.Ioannoy");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Username",
                keyValue: "Mixail90");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Username",
                keyValue: "Nikolaos_Boyrdoympas15");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Username",
                keyValue: "Paraskeyas.Anagnostakis");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Username",
                keyValue: "Paraskeyas_THeodoridis89");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Username",
                keyValue: "Paylos.Giagkos");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Username",
                keyValue: "Paylos.Koyndoyros");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Username",
                keyValue: "Paylos18");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Username",
                keyValue: "Paylos48");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Username",
                keyValue: "Paylos_Kalyvas76");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Username",
                keyValue: "Petros.Blavianos51");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Username",
                keyValue: "Petros50");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Username",
                keyValue: "Petros77");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Username",
                keyValue: "Sotirios.Germanos87");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Username",
                keyValue: "Sotirios.Kalogiannis43");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Username",
                keyValue: "Sotirios.THeodosioy");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Username",
                keyValue: "Sotirios_Zervos");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Username",
                keyValue: "Spyros97");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Username",
                keyValue: "Spyros_Anastasiadis");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Username",
                keyValue: "Stayros.Koronaios");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Username",
                keyValue: "Stayros_Bergas29");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Username",
                keyValue: "Stefanos.Loypis27");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Username",
                keyValue: "Stefanos.Nikolaidis21");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Username",
                keyValue: "Stylianos.Basileiadis");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Username",
                keyValue: "Stylianos.Mitzoy");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Username",
                keyValue: "THeodoros.Basileiadis2");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Username",
                keyValue: "THeodoros.Zafeiropoylos96");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Username",
                keyValue: "THeodoros68");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Username",
                keyValue: "Xaralampos43");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Username",
                keyValue: "Xaralampos68");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Username",
                keyValue: "Xaralampos74");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Username",
                keyValue: "Xristos.Aggelopoylos");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Username",
                keyValue: "Xristos80");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Username",
                keyValue: "Xristos85");

            migrationBuilder.RenameTable(
                name: "CourseMetadatas",
                newName: "CourseMetadata");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CourseMetadata",
                table: "CourseMetadata",
                column: "CourseCode");

            migrationBuilder.CreateTable(
                name: "DegreeTypes",
                columns: table => new
                {
                    Name = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DegreeTypes", x => x.Name);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "UserTypeEntities",
                columns: table => new
                {
                    UserType = table.Column<int>(type: "int", nullable: false),
                    Username = table.Column<string>(type: "varchar(32)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserTypeEntities", x => new { x.UserType, x.Username });
                    table.ForeignKey(
                        name: "FK_UserTypeEntities_Users_Username",
                        column: x => x.Username,
                        principalTable: "Users",
                        principalColumn: "Username",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.InsertData(
                table: "DegreeTypes",
                column: "Name",
                value: "Informatikus szak");

            migrationBuilder.InsertData(
                table: "UserTypeEntities",
                columns: new[] { "UserType", "Username" },
                values: new object[,]
                {
                    { 0, "tanulo" },
                    { 1, "oktato" }
                });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Username",
                keyValue: "oktato",
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEGBr94IzKcUaun9DbjRNoqC6B2OKAmCYBdYV2R2sEeYrv66j/rPtZFpBDL6BK6PjWA==");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Username",
                keyValue: "tanulo",
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEKAOGcxDkeUULJTBwOEeISItpWyTzslmwgLxoJWOFQcIMNsZj6K2ykFsECp85TjGxg==");

            migrationBuilder.InsertData(
                table: "DegreeParticipations",
                columns: new[] { "DegreeName", "Username", "EndDate", "StartDate" },
                values: new object[,]
                {
                    { "Informatikus szak", "oktato", new DateOnly(2000, 6, 1), new DateOnly(1995, 9, 1) },
                    { "Informatikus szak", "tanulo", null, new DateOnly(2018, 9, 1) }
                });

            migrationBuilder.CreateIndex(
                name: "IX_UserTypeEntities_Username",
                table: "UserTypeEntities",
                column: "Username");

            migrationBuilder.AddForeignKey(
                name: "FK_Courses_CourseMetadata_CourseCode",
                table: "Courses",
                column: "CourseCode",
                principalTable: "CourseMetadata",
                principalColumn: "CourseCode",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_DegreeParticipations_DegreeTypes_DegreeName",
                table: "DegreeParticipations",
                column: "DegreeName",
                principalTable: "DegreeTypes",
                principalColumn: "Name",
                onDelete: ReferentialAction.Cascade);
        }
    }
}