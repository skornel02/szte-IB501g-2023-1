using System;

using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Skornel02.ETR.Api.Migrations
{
    /// <inheritdoc />
    public partial class LessAndMoreRandom : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                keyValues: new object[] { "28710 Διαμαντόπουλος Ramp, Κοντολέωνberg, Jordan", "223" });

            migrationBuilder.DeleteData(
                table: "ClassRooms",
                keyColumns: new[] { "Address", "RoomNumber" },
                keyValues: new object[] { "2879 Δραγούμης Dale, South Εμμανουήλ, Switzerland", "206" });

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
                keyValues: new object[] { "Baby (283)", "Anastasios_Bilaetis84" });

            migrationBuilder.DeleteData(
                table: "DegreeParticipations",
                keyColumns: new[] { "DegreeName", "Username" },
                keyValues: new object[] { "Sports, Computers & Electronics (277)", "Andreas95" });

            migrationBuilder.DeleteData(
                table: "DegreeParticipations",
                keyColumns: new[] { "DegreeName", "Username" },
                keyValues: new object[] { "Beauty (269)", "Eleytherios_Didaskaloy" });

            migrationBuilder.DeleteData(
                table: "DegreeParticipations",
                keyColumns: new[] { "DegreeName", "Username" },
                keyValues: new object[] { "Toys (267)", "Eystathios.Boyrdoympas" });

            migrationBuilder.DeleteData(
                table: "DegreeParticipations",
                keyColumns: new[] { "DegreeName", "Username" },
                keyValues: new object[] { "Home (264)", "Fotios.Andreoy51" });

            migrationBuilder.DeleteData(
                table: "DegreeParticipations",
                keyColumns: new[] { "DegreeName", "Username" },
                keyValues: new object[] { "Baby (279)", "Ilias56" });

            migrationBuilder.DeleteData(
                table: "DegreeParticipations",
                keyColumns: new[] { "DegreeName", "Username" },
                keyValues: new object[] { "Books (257)", "Paraskeyas_THeodoridis89" });

            migrationBuilder.DeleteData(
                table: "DegreeParticipations",
                keyColumns: new[] { "DegreeName", "Username" },
                keyValues: new object[] { "Tools, Tools & Tools (284)", "Paylos18" });

            migrationBuilder.DeleteData(
                table: "DegreeParticipations",
                keyColumns: new[] { "DegreeName", "Username" },
                keyValues: new object[] { "Sports (274)", "Petros50" });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "UserType", "Username" },
                keyValues: new object[] { 0, "Andreas95" });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "UserType", "Username" },
                keyValues: new object[] { 0, "Eleytherios_Didaskaloy" });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "UserType", "Username" },
                keyValues: new object[] { 0, "Ilias56" });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "UserType", "Username" },
                keyValues: new object[] { 0, "Paraskeyas_THeodoridis89" });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "UserType", "Username" },
                keyValues: new object[] { 0, "Paylos18" });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "UserType", "Username" },
                keyValues: new object[] { 0, "Petros50" });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "UserType", "Username" },
                keyValues: new object[] { 1, "Anastasios_Bilaetis84" });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "UserType", "Username" },
                keyValues: new object[] { 1, "Andreas95" });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "UserType", "Username" },
                keyValues: new object[] { 1, "Eystathios.Boyrdoympas" });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "UserType", "Username" },
                keyValues: new object[] { 1, "Fotios.Andreoy51" });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "UserType", "Username" },
                keyValues: new object[] { 1, "Ilias56" });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "UserType", "Username" },
                keyValues: new object[] { 1, "Paraskeyas_THeodoridis89" });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "UserType", "Username" },
                keyValues: new object[] { 1, "Paylos18" });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "UserType", "Username" },
                keyValues: new object[] { 1, "Petros50" });

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Username",
                keyValue: "Anastasios_Bilaetis84");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Username",
                keyValue: "Andreas95");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Username",
                keyValue: "Eleytherios_Didaskaloy");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Username",
                keyValue: "Eystathios.Boyrdoympas");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Username",
                keyValue: "Fotios.Andreoy51");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Username",
                keyValue: "Ilias56");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Username",
                keyValue: "Paraskeyas_THeodoridis89");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Username",
                keyValue: "Paylos18");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Username",
                keyValue: "Petros50");

            migrationBuilder.UpdateData(
                table: "ClassRooms",
                keyColumns: new[] { "Address", "RoomNumber" },
                keyValues: new object[] { "2857 Παύλος Mall, West Ελευθέριοςhaven, Armenia", "141" },
                column: "RoomType",
                value: 3);

            migrationBuilder.UpdateData(
                table: "ClassRooms",
                keyColumns: new[] { "Address", "RoomNumber" },
                keyValues: new object[] { "299 Άγγελος Crescent, Βασιλικόςtown, Suriname", "177" },
                column: "RoomType",
                value: 3);

            migrationBuilder.UpdateData(
                table: "ClassRooms",
                keyColumns: new[] { "Address", "RoomNumber" },
                keyValues: new object[] { "333 Μήτζου Run, Lake Αθανάσιος, Sierra Leone", "166" },
                column: "RoomType",
                value: 3);

            migrationBuilder.UpdateData(
                table: "ClassRooms",
                keyColumns: new[] { "Address", "RoomNumber" },
                keyValues: new object[] { "48878 Αλεξάνδρου Mountain, East Ιωάννηςland, Malaysia", "73" },
                column: "RoomType",
                value: 2);

            migrationBuilder.UpdateData(
                table: "ClassRooms",
                keyColumns: new[] { "Address", "RoomNumber" },
                keyValues: new object[] { "868 Βικελίδης Underpass, North Παύλος, Japan", "243" },
                column: "RoomType",
                value: 2);

            migrationBuilder.UpdateData(
                table: "ClassRooms",
                keyColumns: new[] { "Address", "RoomNumber" },
                keyValues: new object[] { "89875 Ευάγγελος Fields, New Νικόλαος, Niger", "49" },
                column: "RoomType",
                value: 2);

            migrationBuilder.InsertData(
                table: "ClassRooms",
                columns: new[] { "Address", "RoomNumber", "RoomType" },
                values: new object[,]
                {
                    { "0002 Λειβαδάς Causeway, East Ευστάθιοςburgh, Honduras", "90", 3 },
                    { "0272 Ευάγγελος Stream, Μπότσαρηςtown, United States Minor Outlying Islands", "278", 1 },
                    { "04326 Ιωάννης Union, South Γεώργιος, Rwanda", "307", 1 },
                    { "067 Μαρής Ports, East Εμμανουήλ, Virgin Islands, U.S.", "132", 0 },
                    { "0855 Παπαδόπουλος Shores, Port Ανδρέαςfort, Singapore", "108", 0 },
                    { "09433 Ελευθερόπουλος Station, Lake Ελευθέριος, Gibraltar", "23", 1 },
                    { "109 Στέφανος Shoals, Αθανάσιοςview, Netherlands Antilles", "243", 3 },
                    { "11443 Ζερβός Creek, New Ευστάθιοςfort, French Polynesia", "87", 0 },
                    { "11588 Κώστας Expressway, Κώσταςfort, Puerto Rico", "81", 3 },
                    { "1211 Ιωάννης Valley, Lake Σταύροςshire, Philippines", "87", 0 },
                    { "12346 Στυλιανός Haven, Βαμβακάςburgh, Italy", "132", 1 },
                    { "12539 Μιχαήλ Track, West Σπύρος, Finland", "134", 1 },
                    { "1616 Βενιζέλος Station, New Ελευθέριος, Niger", "52", 3 },
                    { "1695 Αντωνιάδης Views, Port Αλέξανδροςhaven, Saint Martin", "272", 2 },
                    { "17283 Κοτζιάς Skyway, Μπλέτσαςhaven, Sierra Leone", "81", 0 },
                    { "1878 Άγγελος Trail, East Γρηγόριος, Lithuania", "137", 3 },
                    { "1988 Αγγελίδου Stravenue, East Χαράλαμπος, Micronesia", "103", 3 },
                    { "2369 Βάμβας Locks, Σταύροςchester, China", "16", 1 },
                    { "24163 Ευστάθιος Expressway, East Φώτιος, Nicaragua", "59", 3 },
                    { "252 Παπακώστας Extension, Ελευθεριάδηςmouth, Netherlands Antilles", "284", 1 },
                    { "2578 Αντώνης Hill, New Ανδρέαςhaven, Gibraltar", "276", 0 },
                    { "260 Μελετόπουλος Lake, South Νικόλαοςchester, Zimbabwe", "78", 1 },
                    { "27308 Μαρής Spur, Εμμανουήλville, Guam", "340", 3 },
                    { "276 Παπακώστας Neck, Γεώργιοςberg, Netherlands", "286", 2 },
                    { "2821 Αλεξάνδρου Spring, Διονύσιοςstad, Saint Barthelemy", "198", 1 },
                    { "31452 Σωτήριος Ports, Ζωγράφοςton, Brunei Darussalam", "297", 0 },
                    { "318 Αθανασιάδης Mews, Βικελίδηςburgh, Suriname", "262", 0 },
                    { "327 Στέφανος Streets, Lake Ελευθέριοςmouth, Swaziland", "39", 2 },
                    { "3431 Χρήστος Place, Βλαχόπουλοςton, Faroe Islands", "307", 0 },
                    { "35546 Δασκαλόπουλος Springs, Ελευθέριοςville, Ireland", "207", 3 },
                    { "3595 Γλυκύς Station, Απόστολοςland, Grenada", "178", 0 },
                    { "36767 Στυλιανός Knolls, North Ελευθέριος, Belize", "108", 2 },
                    { "3684 Αλεξάνδρου Camp, Βλαχόπουλοςview, Denmark", "162", 0 },
                    { "377 Ουζουνίδης Ridge, Γεώργιοςhaven, New Zealand", "83", 2 },
                    { "384 Αλέξανδρος Bridge, Αναστάσιοςton, Egypt", "195", 3 },
                    { "392 Διονύσιος Glen, West Άγγελοςton, Russian Federation", "192", 3 },
                    { "39884 Δημητρίου Villages, East Σταύροςside, Mayotte", "301", 2 },
                    { "40306 Γερμανός Junction, Port Ευστάθιος, Peru", "228", 3 },
                    { "416 Κώστας View, East Αριστείδηςhaven, Jamaica", "327", 2 },
                    { "417 Αυγερινός (επώνυμο) Causeway, West Ευάγγελοςville, Rwanda", "21", 0 },
                    { "430 Γιαννακόπουλος Rest, Διονύσιοςfurt, Bhutan", "311", 0 },
                    { "43084 Λειβαδάς Underpass, Άγγελοςport, Ethiopia", "72", 2 },
                    { "438 Μέλιοι Light, West Νικόλαος, Sierra Leone", "220", 1 },
                    { "453 Λεωνίδας Groves, West Θεόδωρος, Uruguay", "84", 3 },
                    { "45669 Ελευθέριος Lodge, Αβραμίδηςton, Zimbabwe", "18", 3 },
                    { "475 Ηλίας Field, Ζαΐμηςbury, Bahamas", "32", 1 },
                    { "4762 Στέφανος Corner, Νικόλαοςview, Lebanon", "61", 3 },
                    { "481 Ηλίας Corner, Ελευθέριοςmouth, India", "109", 0 },
                    { "490 Δημήτρης Well, Lake Αντώνης, Niue", "30", 3 },
                    { "49187 Βούλγαρης Spring, Αντώνηςborough, Malawi", "155", 2 },
                    { "4927 Λειβαδάς Glens, Βασιλειάδηςchester, Lesotho", "26", 3 },
                    { "50225 Εμμανουήλ Gardens, Κοντόσταυλοςburgh, Colombia", "154", 0 },
                    { "5146 Καψής Locks, Αντώνηςbury, Vanuatu", "317", 3 },
                    { "52259 Στέφανος Station, South Ελευθέριοςview, Rwanda", "16", 1 },
                    { "523 Ανδρέας Causeway, Port Αλέξανδροςchester, Mexico", "26", 3 },
                    { "52397 Ανδρέας Oval, New Στυλιανός, Zambia", "241", 3 },
                    { "5259 Παπανδρέου Cliff, South Ανδρέαςside, Heard Island and McDonald Islands", "187", 3 },
                    { "5356 Δημήτρης Heights, Ακρίδαςtown, Ecuador", "114", 0 },
                    { "546 Δοξαράς Wells, West Φώτιοςmouth, Saint Lucia", "70", 0 },
                    { "591 Βασιλόπουλος Hollow, East Αλέξανδροςborough, Grenada", "174", 2 },
                    { "60625 Νικόλαος Terrace, Ηλίαςton, Namibia", "134", 1 },
                    { "6356 Δάβης Club, Lake Αναστάσιοςstad, Central African Republic", "122", 1 },
                    { "6528 Παπάγος Terrace, New Κώστας, French Polynesia", "187", 0 },
                    { "670 Παπανδρέου Ferry, Ιωάννηςview, Cocos (Keeling) Islands", "311", 3 },
                    { "6859 Ανδρέας Stravenue, Σπύροςmouth, Jordan", "44", 0 },
                    { "702 Σπύρος View, New Θεόδωρος, Pitcairn Islands", "281", 0 },
                    { "74404 Γεννάδιος Forest, East Λεωνίδαςmouth, Hungary", "71", 0 },
                    { "7487 Στυλιανός Locks, Χαράλαμποςfort, Qatar", "322", 2 },
                    { "75820 Γρηγόριος Forks, West Ευάγγελοςport, Burundi", "205", 1 },
                    { "7655 Βασιλειάδης Freeway, Θεόδωροςfurt, Portugal", "277", 2 },
                    { "771 Παπάζογλου Ramp, Αλαβάνοςbury, United States Minor Outlying Islands", "335", 0 },
                    { "78513 Λαγός Locks, West Άγγελοςfort, Israel", "332", 0 },
                    { "798 Παπαγεωργίου Mountains, New Νικόλαοςport, Mayotte", "231", 3 },
                    { "80115 Μπουκουβαλαίοι Streets, West Παναγιώτηςchester, Western Sahara", "254", 3 },
                    { "8208 Παρασκευάς Club, Αναστάσιοςstad, Jamaica", "84", 0 },
                    { "82709 Βασίλης Meadow, North Κώσταςborough, Guadeloupe", "96", 1 },
                    { "82749 Αυγερινός (επώνυμο) Camp, Κυπραίοςside, Andorra", "335", 1 },
                    { "829 Χρήστος Centers, Lake Ευστάθιος, Somalia", "164", 2 },
                    { "845 Δάβης Hill, Παπανικολάουland, Madagascar", "132", 2 },
                    { "8545 Λεωνίδας Points, Γαλάνηςmouth, Marshall Islands", "255", 3 },
                    { "8582 Εμμανουήλ Highway, New Ευστάθιοςport, Jersey", "320", 2 },
                    { "8765 Βασιλόπουλος Loop, New Αθανάσιοςshire, Syrian Arab Republic", "219", 0 },
                    { "879 Παναγιώτης Glen, South Εμμανουήλ, Switzerland", "206", 0 },
                    { "8809 Θεόδωρος Skyway, Port Αριστείδηςton, Singapore", "190", 3 },
                    { "8881 Παπακώστας Burgs, New Αριστείδης, Cuba", "93", 0 },
                    { "895 Ζωγράφος Shores, Βυζάντιοςville, China", "54", 3 },
                    { "896 Αναστάσιος Meadows, Γεώργιοςstad, Swaziland", "46", 0 },
                    { "89826 Θεόδωρος View, Lake Ευάγγελος, Pitcairn Islands", "235", 0 },
                    { "908 Μιχαηλίδης Islands, Αλέξανδροςstad, Haiti", "280", 3 },
                    { "9187 Λεωνίδας Center, New Αντώνης, Bahamas", "25", 1 },
                    { "92323 Νικόλαος Trafficway, South Παναγιώτηςfort, Virgin Islands, British", "346", 0 },
                    { "94874 Νικόλαος Ramp, Μακρήςhaven, Costa Rica", "190", 3 },
                    { "9571 Λούλης Light, Παππάςborough, Northern Mariana Islands", "206", 1 },
                    { "98003 Μαλαξός Springs, New Αλέξανδρος, Honduras", "246", 2 }
                });

            migrationBuilder.UpdateData(
                table: "DegreeParticipations",
                keyColumns: new[] { "DegreeName", "Username" },
                keyValues: new object[] { "Games & Toys (297)", "Aggelos.Aggelidoy35" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateOnly(1999, 2, 26), new DateOnly(1996, 2, 26) });

            migrationBuilder.UpdateData(
                table: "DegreeParticipations",
                keyColumns: new[] { "DegreeName", "Username" },
                keyValues: new object[] { "Electronics (266)", "Aggelos6" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateOnly(2013, 6, 19), new DateOnly(2010, 6, 19) });

            migrationBuilder.UpdateData(
                table: "DegreeParticipations",
                keyColumns: new[] { "DegreeName", "Username" },
                keyValues: new object[] { "Games & Toys (297)", "Aggelos87" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateOnly(2018, 9, 11), new DateOnly(2015, 9, 11) });

            migrationBuilder.UpdateData(
                table: "DegreeParticipations",
                keyColumns: new[] { "DegreeName", "Username" },
                keyValues: new object[] { "Toys (259)", "Aggelos_Georgiadis30" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateOnly(2024, 12, 5), new DateOnly(2021, 12, 5) });

            migrationBuilder.UpdateData(
                table: "DegreeParticipations",
                keyColumns: new[] { "DegreeName", "Username" },
                keyValues: new object[] { "Books (290)", "Aleksandros.Zervos61" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateOnly(2007, 9, 26), new DateOnly(2004, 9, 26) });

            migrationBuilder.UpdateData(
                table: "DegreeParticipations",
                keyColumns: new[] { "DegreeName", "Username" },
                keyValues: new object[] { "Baby (279)", "Aleksandros41" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateOnly(1993, 10, 1), new DateOnly(1990, 10, 1) });

            migrationBuilder.UpdateData(
                table: "DegreeParticipations",
                keyColumns: new[] { "DegreeName", "Username" },
                keyValues: new object[] { "Music, Movies & Industrial (280)", "Anastasios_Nikolakos52" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateOnly(2020, 11, 22), new DateOnly(2017, 11, 22) });

            migrationBuilder.UpdateData(
                table: "DegreeParticipations",
                keyColumns: new[] { "DegreeName", "Username" },
                keyValues: new object[] { "Health, Toys & Outdoors (255)", "Andreas22" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateOnly(2010, 9, 30), new DateOnly(2007, 9, 30) });

            migrationBuilder.UpdateData(
                table: "DegreeParticipations",
                keyColumns: new[] { "DegreeName", "Username" },
                keyValues: new object[] { "Garden (271)", "Andreas52" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateOnly(1988, 2, 16), new DateOnly(1985, 2, 16) });

            migrationBuilder.UpdateData(
                table: "DegreeParticipations",
                keyColumns: new[] { "DegreeName", "Username" },
                keyValues: new object[] { "Shoes & Toys (268)", "Andreas_Bikelidis33" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateOnly(2004, 1, 27), new DateOnly(2001, 1, 27) });

            migrationBuilder.UpdateData(
                table: "DegreeParticipations",
                keyColumns: new[] { "DegreeName", "Username" },
                keyValues: new object[] { "Jewelery, Automotive & Garden (276)", "Antonis.Lytras" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateOnly(1983, 6, 3), new DateOnly(1980, 6, 3) });

            migrationBuilder.UpdateData(
                table: "DegreeParticipations",
                keyColumns: new[] { "DegreeName", "Username" },
                keyValues: new object[] { "Books & Sports (273)", "Antonis4" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateOnly(2007, 12, 4), new DateOnly(2004, 12, 4) });

            migrationBuilder.UpdateData(
                table: "DegreeParticipations",
                keyColumns: new[] { "DegreeName", "Username" },
                keyValues: new object[] { "Electronics (266)", "Antonis_Antonopoylos" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateOnly(2021, 12, 10), new DateOnly(2018, 12, 10) });

            migrationBuilder.UpdateData(
                table: "DegreeParticipations",
                keyColumns: new[] { "DegreeName", "Username" },
                keyValues: new object[] { "Home (264)", "Antonis_Diamantopoylos43" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateOnly(2013, 11, 23), new DateOnly(2010, 11, 23) });

            migrationBuilder.UpdateData(
                table: "DegreeParticipations",
                keyColumns: new[] { "DegreeName", "Username" },
                keyValues: new object[] { "Industrial, Toys & Automotive (250)", "Antonis_Karamanlis" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateOnly(2007, 3, 25), new DateOnly(2004, 3, 25) });

            migrationBuilder.UpdateData(
                table: "DegreeParticipations",
                keyColumns: new[] { "DegreeName", "Username" },
                keyValues: new object[] { "Clothing, Electronics & Jewelery (253)", "Antonis_Melioi26" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateOnly(1988, 3, 12), new DateOnly(1985, 3, 12) });

            migrationBuilder.UpdateData(
                table: "DegreeParticipations",
                keyColumns: new[] { "DegreeName", "Username" },
                keyValues: new object[] { "Garden (260)", "Apostolos.Kypraios" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateOnly(1996, 12, 28), new DateOnly(1993, 12, 28) });

            migrationBuilder.UpdateData(
                table: "DegreeParticipations",
                keyColumns: new[] { "DegreeName", "Username" },
                keyValues: new object[] { "Kids & Tools (265)", "Apostolos44" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateOnly(2003, 2, 21), new DateOnly(2000, 2, 21) });

            migrationBuilder.UpdateData(
                table: "DegreeParticipations",
                keyColumns: new[] { "DegreeName", "Username" },
                keyValues: new object[] { "Shoes & Kids (281)", "Apostolos75" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateOnly(2017, 7, 9), new DateOnly(2014, 7, 9) });

            migrationBuilder.UpdateData(
                table: "DegreeParticipations",
                keyColumns: new[] { "DegreeName", "Username" },
                keyValues: new object[] { "Electronics & Jewelery (282)", "Apostolos_Daskalopoylos" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateOnly(1994, 10, 30), new DateOnly(1991, 10, 30) });

            migrationBuilder.UpdateData(
                table: "DegreeParticipations",
                keyColumns: new[] { "DegreeName", "Username" },
                keyValues: new object[] { "Baby (283)", "Aristeidis.Aleksandroy12" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateOnly(2016, 1, 25), new DateOnly(2013, 1, 25) });

            migrationBuilder.UpdateData(
                table: "DegreeParticipations",
                keyColumns: new[] { "DegreeName", "Username" },
                keyValues: new object[] { "Sports, Computers & Electronics (277)", "Aristeidis.Papanikolaoy" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateOnly(2003, 12, 7), new DateOnly(2000, 12, 7) });

            migrationBuilder.UpdateData(
                table: "DegreeParticipations",
                keyColumns: new[] { "DegreeName", "Username" },
                keyValues: new object[] { "Automotive, Garden & Beauty (261)", "Aristeidis_Melioi" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateOnly(2020, 7, 7), new DateOnly(2017, 7, 7) });

            migrationBuilder.UpdateData(
                table: "DegreeParticipations",
                keyColumns: new[] { "DegreeName", "Username" },
                keyValues: new object[] { "Sports, Computers & Electronics (277)", "Basilis.Koytalianos17" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateOnly(2021, 7, 24), new DateOnly(2018, 7, 24) });

            migrationBuilder.UpdateData(
                table: "DegreeParticipations",
                keyColumns: new[] { "DegreeName", "Username" },
                keyValues: new object[] { "Sports, Kids & Industrial (291)", "Basilis61" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateOnly(2001, 7, 10), new DateOnly(1998, 7, 10) });

            migrationBuilder.UpdateData(
                table: "DegreeParticipations",
                keyColumns: new[] { "DegreeName", "Username" },
                keyValues: new object[] { "Electronics (251)", "Basilis_Oikonomoy" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateOnly(2022, 8, 1), new DateOnly(2019, 8, 1) });

            migrationBuilder.UpdateData(
                table: "DegreeParticipations",
                keyColumns: new[] { "DegreeName", "Username" },
                keyValues: new object[] { "Kids & Baby (287)", "Dimitris28" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateOnly(2009, 4, 13), new DateOnly(2006, 4, 13) });

            migrationBuilder.UpdateData(
                table: "DegreeParticipations",
                keyColumns: new[] { "DegreeName", "Username" },
                keyValues: new object[] { "Shoes & Kids (281)", "Dionysios.Anagnostakis" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateOnly(1993, 11, 13), new DateOnly(1990, 11, 13) });

            migrationBuilder.UpdateData(
                table: "DegreeParticipations",
                keyColumns: new[] { "DegreeName", "Username" },
                keyValues: new object[] { "Garden (262)", "Dionysios.Lytras" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateOnly(1988, 11, 7), new DateOnly(1985, 11, 7) });

            migrationBuilder.UpdateData(
                table: "DegreeParticipations",
                keyColumns: new[] { "DegreeName", "Username" },
                keyValues: new object[] { "Books (290)", "Dionysios_Deli12" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateOnly(1995, 12, 17), new DateOnly(1992, 12, 17) });

            migrationBuilder.UpdateData(
                table: "DegreeParticipations",
                keyColumns: new[] { "DegreeName", "Username" },
                keyValues: new object[] { "Electronics (266)", "Eleytherios.Eleytherioy" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateOnly(2005, 1, 31), new DateOnly(2002, 1, 31) });

            migrationBuilder.UpdateData(
                table: "DegreeParticipations",
                keyColumns: new[] { "DegreeName", "Username" },
                keyValues: new object[] { "Kids & Tools (265)", "Emmanoyil.Georgiadis" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateOnly(2018, 12, 4), new DateOnly(2015, 12, 4) });

            migrationBuilder.UpdateData(
                table: "DegreeParticipations",
                keyColumns: new[] { "DegreeName", "Username" },
                keyValues: new object[] { "Electronics (251)", "Emmanoyil_Aleksioy5" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateOnly(2006, 1, 2), new DateOnly(2003, 1, 2) });

            migrationBuilder.UpdateData(
                table: "DegreeParticipations",
                keyColumns: new[] { "DegreeName", "Username" },
                keyValues: new object[] { "Toys (267)", "Emmanoyil_Koyndoyros" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateOnly(2015, 10, 13), new DateOnly(2012, 10, 13) });

            migrationBuilder.UpdateData(
                table: "DegreeParticipations",
                keyColumns: new[] { "DegreeName", "Username" },
                keyValues: new object[] { "Baby (279)", "Emmanoyil_Maris67" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateOnly(2012, 10, 10), new DateOnly(2009, 10, 10) });

            migrationBuilder.UpdateData(
                table: "DegreeParticipations",
                keyColumns: new[] { "DegreeName", "Username" },
                keyValues: new object[] { "Beauty (269)", "Eyaggelos_Koromilas73" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateOnly(2020, 5, 4), new DateOnly(2017, 5, 4) });

            migrationBuilder.UpdateData(
                table: "DegreeParticipations",
                keyColumns: new[] { "DegreeName", "Username" },
                keyValues: new object[] { "Books, Garden & Garden (275)", "Eystathios17" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateOnly(2008, 12, 28), new DateOnly(2005, 12, 28) });

            migrationBuilder.UpdateData(
                table: "DegreeParticipations",
                keyColumns: new[] { "DegreeName", "Username" },
                keyValues: new object[] { "Computers & Health (285)", "Eystathios29" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateOnly(2023, 11, 4), new DateOnly(2020, 11, 4) });

            migrationBuilder.UpdateData(
                table: "DegreeParticipations",
                keyColumns: new[] { "DegreeName", "Username" },
                keyValues: new object[] { "Shoes & Kids (281)", "Eystathios57" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateOnly(1993, 2, 3), new DateOnly(1990, 2, 3) });

            migrationBuilder.UpdateData(
                table: "DegreeParticipations",
                keyColumns: new[] { "DegreeName", "Username" },
                keyValues: new object[] { "Games & Toys (297)", "Eystathios_Avramidis41" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateOnly(2025, 4, 18), new DateOnly(2022, 4, 18) });

            migrationBuilder.UpdateData(
                table: "DegreeParticipations",
                keyColumns: new[] { "DegreeName", "Username" },
                keyValues: new object[] { "Baby (283)", "Fotios90" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateOnly(2026, 10, 10), new DateOnly(2023, 10, 10) });

            migrationBuilder.UpdateData(
                table: "DegreeParticipations",
                keyColumns: new[] { "DegreeName", "Username" },
                keyValues: new object[] { "Garden (271)", "Fotios_Karavias7" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateOnly(1999, 5, 19), new DateOnly(1996, 5, 19) });

            migrationBuilder.UpdateData(
                table: "DegreeParticipations",
                keyColumns: new[] { "DegreeName", "Username" },
                keyValues: new object[] { "Clothing, Electronics & Jewelery (253)", "Georgios.Eytaksias" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateOnly(1997, 5, 31), new DateOnly(1994, 5, 31) });

            migrationBuilder.UpdateData(
                table: "DegreeParticipations",
                keyColumns: new[] { "DegreeName", "Username" },
                keyValues: new object[] { "Electronics (251)", "Georgios2" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateOnly(2020, 9, 24), new DateOnly(2017, 9, 24) });

            migrationBuilder.UpdateData(
                table: "DegreeParticipations",
                keyColumns: new[] { "DegreeName", "Username" },
                keyValues: new object[] { "Home (264)", "Georgios45" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateOnly(2022, 6, 3), new DateOnly(2019, 6, 3) });

            migrationBuilder.UpdateData(
                table: "DegreeParticipations",
                keyColumns: new[] { "DegreeName", "Username" },
                keyValues: new object[] { "Books (290)", "Georgios79" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateOnly(1986, 1, 23), new DateOnly(1983, 1, 23) });

            migrationBuilder.UpdateData(
                table: "DegreeParticipations",
                keyColumns: new[] { "DegreeName", "Username" },
                keyValues: new object[] { "Kids, Electronics & Movies (288)", "Georgios_Bilaetis20" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateOnly(1987, 5, 18), new DateOnly(1984, 5, 18) });

            migrationBuilder.UpdateData(
                table: "DegreeParticipations",
                keyColumns: new[] { "DegreeName", "Username" },
                keyValues: new object[] { "Baby (283)", "Grigorios.Boylgaris" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateOnly(2011, 12, 25), new DateOnly(2008, 12, 25) });

            migrationBuilder.UpdateData(
                table: "DegreeParticipations",
                keyColumns: new[] { "DegreeName", "Username" },
                keyValues: new object[] { "Baby (283)", "Grigorios_Kontoleon41" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateOnly(1995, 11, 1), new DateOnly(1992, 11, 1) });

            migrationBuilder.UpdateData(
                table: "DegreeParticipations",
                keyColumns: new[] { "DegreeName", "Username" },
                keyValues: new object[] { "Baby (279)", "Ilias.Metaksas74" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateOnly(2022, 11, 4), new DateOnly(2019, 11, 4) });

            migrationBuilder.UpdateData(
                table: "DegreeParticipations",
                keyColumns: new[] { "DegreeName", "Username" },
                keyValues: new object[] { "Kids & Tools (265)", "Ilias.Zafeiropoylos86" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateOnly(1989, 10, 13), new DateOnly(1986, 10, 13) });

            migrationBuilder.UpdateData(
                table: "DegreeParticipations",
                keyColumns: new[] { "DegreeName", "Username" },
                keyValues: new object[] { "Garden (262)", "Ilias_Bamvas22" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateOnly(2020, 7, 29), new DateOnly(2017, 7, 29) });

            migrationBuilder.UpdateData(
                table: "DegreeParticipations",
                keyColumns: new[] { "DegreeName", "Username" },
                keyValues: new object[] { "Kids, Electronics & Movies (288)", "Ioannis.Aygerinoseponymo0" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateOnly(2015, 5, 8), new DateOnly(2012, 5, 8) });

            migrationBuilder.UpdateData(
                table: "DegreeParticipations",
                keyColumns: new[] { "DegreeName", "Username" },
                keyValues: new object[] { "Books (257)", "Ioannis.Zappas99" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateOnly(1998, 5, 19), new DateOnly(1995, 5, 19) });

            migrationBuilder.UpdateData(
                table: "DegreeParticipations",
                keyColumns: new[] { "DegreeName", "Username" },
                keyValues: new object[] { "Electronics (266)", "Ioannis28" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateOnly(1999, 8, 7), new DateOnly(1996, 8, 7) });

            migrationBuilder.UpdateData(
                table: "DegreeParticipations",
                keyColumns: new[] { "DegreeName", "Username" },
                keyValues: new object[] { "Garden (260)", "Ioannis_Basilopoylos" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateOnly(2010, 1, 28), new DateOnly(2007, 1, 28) });

            migrationBuilder.UpdateData(
                table: "DegreeParticipations",
                keyColumns: new[] { "DegreeName", "Username" },
                keyValues: new object[] { "Industrial, Toys & Automotive (250)", "Kostas43" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateOnly(2025, 6, 29), new DateOnly(2022, 6, 29) });

            migrationBuilder.UpdateData(
                table: "DegreeParticipations",
                keyColumns: new[] { "DegreeName", "Username" },
                keyValues: new object[] { "Clothing, Electronics & Jewelery (253)", "Kostas92" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateOnly(1985, 6, 15), new DateOnly(1982, 6, 15) });

            migrationBuilder.UpdateData(
                table: "DegreeParticipations",
                keyColumns: new[] { "DegreeName", "Username" },
                keyValues: new object[] { "Jewelery, Automotive & Garden (276)", "Kostas_Byzantios65" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateOnly(2016, 6, 12), new DateOnly(2013, 6, 12) });

            migrationBuilder.UpdateData(
                table: "DegreeParticipations",
                keyColumns: new[] { "DegreeName", "Username" },
                keyValues: new object[] { "Toys (259)", "Mixail.Bergas85" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateOnly(1981, 11, 13), new DateOnly(1978, 11, 13) });

            migrationBuilder.UpdateData(
                table: "DegreeParticipations",
                keyColumns: new[] { "DegreeName", "Username" },
                keyValues: new object[] { "Movies & Toys (286)", "Mixail.Ioannoy" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateOnly(1984, 12, 27), new DateOnly(1981, 12, 27) });

            migrationBuilder.UpdateData(
                table: "DegreeParticipations",
                keyColumns: new[] { "DegreeName", "Username" },
                keyValues: new object[] { "Toys (267)", "Mixail90" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateOnly(2003, 5, 20), new DateOnly(2000, 5, 20) });

            migrationBuilder.UpdateData(
                table: "DegreeParticipations",
                keyColumns: new[] { "DegreeName", "Username" },
                keyValues: new object[] { "Beauty & Electronics (299)", "Nikolaos_Boyrdoympas15" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateOnly(2015, 8, 30), new DateOnly(2012, 8, 30) });

            migrationBuilder.UpdateData(
                table: "DegreeParticipations",
                keyColumns: new[] { "DegreeName", "Username" },
                keyValues: new object[] { "Baby (283)", "Paraskeyas.Anagnostakis" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateOnly(2017, 12, 31), new DateOnly(2014, 12, 31) });

            migrationBuilder.UpdateData(
                table: "DegreeParticipations",
                keyColumns: new[] { "DegreeName", "Username" },
                keyValues: new object[] { "Books (257)", "Paylos.Giagkos" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateOnly(1999, 10, 27), new DateOnly(1996, 10, 27) });

            migrationBuilder.UpdateData(
                table: "DegreeParticipations",
                keyColumns: new[] { "DegreeName", "Username" },
                keyValues: new object[] { "Baby (279)", "Paylos.Koyndoyros" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateOnly(1988, 6, 20), new DateOnly(1985, 6, 20) });

            migrationBuilder.UpdateData(
                table: "DegreeParticipations",
                keyColumns: new[] { "DegreeName", "Username" },
                keyValues: new object[] { "Electronics (251)", "Paylos48" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateOnly(2002, 11, 17), new DateOnly(1999, 11, 17) });

            migrationBuilder.UpdateData(
                table: "DegreeParticipations",
                keyColumns: new[] { "DegreeName", "Username" },
                keyValues: new object[] { "Garden, Kids & Outdoors (289)", "Paylos_Kalyvas76" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateOnly(2022, 6, 8), new DateOnly(2019, 6, 8) });

            migrationBuilder.UpdateData(
                table: "DegreeParticipations",
                keyColumns: new[] { "DegreeName", "Username" },
                keyValues: new object[] { "Health, Toys & Outdoors (255)", "Petros.Blavianos51" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateOnly(2023, 1, 4), new DateOnly(2020, 1, 4) });

            migrationBuilder.UpdateData(
                table: "DegreeParticipations",
                keyColumns: new[] { "DegreeName", "Username" },
                keyValues: new object[] { "Automotive, Garden & Beauty (261)", "Petros77" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateOnly(2006, 4, 27), new DateOnly(2003, 4, 27) });

            migrationBuilder.UpdateData(
                table: "DegreeParticipations",
                keyColumns: new[] { "DegreeName", "Username" },
                keyValues: new object[] { "Shoes & Toys (268)", "Sotirios.Germanos87" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateOnly(2018, 4, 3), new DateOnly(2015, 4, 3) });

            migrationBuilder.UpdateData(
                table: "DegreeParticipations",
                keyColumns: new[] { "DegreeName", "Username" },
                keyValues: new object[] { "Tools, Tools & Tools (284)", "Sotirios.Kalogiannis43" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateOnly(2000, 5, 10), new DateOnly(1997, 5, 10) });

            migrationBuilder.UpdateData(
                table: "DegreeParticipations",
                keyColumns: new[] { "DegreeName", "Username" },
                keyValues: new object[] { "Beauty & Electronics (299)", "Sotirios.THeodosioy" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateOnly(2026, 9, 3), new DateOnly(2023, 9, 3) });

            migrationBuilder.UpdateData(
                table: "DegreeParticipations",
                keyColumns: new[] { "DegreeName", "Username" },
                keyValues: new object[] { "Industrial & Computers (252)", "Sotirios_Zervos" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateOnly(2011, 6, 20), new DateOnly(2008, 6, 20) });

            migrationBuilder.UpdateData(
                table: "DegreeParticipations",
                keyColumns: new[] { "DegreeName", "Username" },
                keyValues: new object[] { "Baby (279)", "Spyros97" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateOnly(1992, 8, 14), new DateOnly(1989, 8, 14) });

            migrationBuilder.UpdateData(
                table: "DegreeParticipations",
                keyColumns: new[] { "DegreeName", "Username" },
                keyValues: new object[] { "Home, Movies & Shoes (272)", "Spyros_Anastasiadis" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateOnly(1998, 3, 31), new DateOnly(1995, 3, 31) });

            migrationBuilder.UpdateData(
                table: "DegreeParticipations",
                keyColumns: new[] { "DegreeName", "Username" },
                keyValues: new object[] { "Garden (262)", "Stayros.Koronaios" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateOnly(1997, 5, 20), new DateOnly(1994, 5, 20) });

            migrationBuilder.UpdateData(
                table: "DegreeParticipations",
                keyColumns: new[] { "DegreeName", "Username" },
                keyValues: new object[] { "Outdoors, Home & Baby (292)", "Stayros_Bergas29" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateOnly(1988, 8, 14), new DateOnly(1985, 8, 14) });

            migrationBuilder.UpdateData(
                table: "DegreeParticipations",
                keyColumns: new[] { "DegreeName", "Username" },
                keyValues: new object[] { "Books & Sports (273)", "Stefanos.Loypis27" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateOnly(2000, 6, 27), new DateOnly(1997, 6, 27) });

            migrationBuilder.UpdateData(
                table: "DegreeParticipations",
                keyColumns: new[] { "DegreeName", "Username" },
                keyValues: new object[] { "Beauty (296)", "Stefanos.Nikolaidis21" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateOnly(1999, 1, 12), new DateOnly(1996, 1, 12) });

            migrationBuilder.UpdateData(
                table: "DegreeParticipations",
                keyColumns: new[] { "DegreeName", "Username" },
                keyValues: new object[] { "Tools, Tools & Tools (284)", "Stylianos.Basileiadis" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateOnly(1994, 1, 27), new DateOnly(1991, 1, 27) });

            migrationBuilder.UpdateData(
                table: "DegreeParticipations",
                keyColumns: new[] { "DegreeName", "Username" },
                keyValues: new object[] { "Toys, Outdoors & Toys (293)", "Stylianos.Mitzoy" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateOnly(1996, 5, 25), new DateOnly(1993, 5, 25) });

            migrationBuilder.UpdateData(
                table: "DegreeParticipations",
                keyColumns: new[] { "DegreeName", "Username" },
                keyValues: new object[] { "Music & Grocery (258)", "THeodoros.Basileiadis2" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateOnly(2002, 4, 30), new DateOnly(1999, 4, 30) });

            migrationBuilder.UpdateData(
                table: "DegreeParticipations",
                keyColumns: new[] { "DegreeName", "Username" },
                keyValues: new object[] { "Toys (259)", "THeodoros.Zafeiropoylos96" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateOnly(2023, 8, 25), new DateOnly(2020, 8, 25) });

            migrationBuilder.UpdateData(
                table: "DegreeParticipations",
                keyColumns: new[] { "DegreeName", "Username" },
                keyValues: new object[] { "Home, Movies & Shoes (272)", "THeodoros68" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateOnly(2008, 10, 2), new DateOnly(2005, 10, 2) });

            migrationBuilder.UpdateData(
                table: "DegreeParticipations",
                keyColumns: new[] { "DegreeName", "Username" },
                keyValues: new object[] { "Industrial & Shoes (270)", "Xaralampos43" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateOnly(2004, 5, 22), new DateOnly(2001, 5, 22) });

            migrationBuilder.UpdateData(
                table: "DegreeParticipations",
                keyColumns: new[] { "DegreeName", "Username" },
                keyValues: new object[] { "Sports, Computers & Electronics (277)", "Xaralampos68" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateOnly(2001, 9, 6), new DateOnly(1998, 9, 6) });

            migrationBuilder.UpdateData(
                table: "DegreeParticipations",
                keyColumns: new[] { "DegreeName", "Username" },
                keyValues: new object[] { "Electronics (251)", "Xaralampos74" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateOnly(2009, 3, 14), new DateOnly(2006, 3, 14) });

            migrationBuilder.UpdateData(
                table: "DegreeParticipations",
                keyColumns: new[] { "DegreeName", "Username" },
                keyValues: new object[] { "Toys (295)", "Xristos.Aggelopoylos" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateOnly(1998, 1, 18), new DateOnly(1995, 1, 18) });

            migrationBuilder.UpdateData(
                table: "DegreeParticipations",
                keyColumns: new[] { "DegreeName", "Username" },
                keyValues: new object[] { "Baby, Home & Jewelery (254)", "Xristos80" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateOnly(2013, 6, 6), new DateOnly(2010, 6, 6) });

            migrationBuilder.UpdateData(
                table: "DegreeParticipations",
                keyColumns: new[] { "DegreeName", "Username" },
                keyValues: new object[] { "Electronics (251)", "Xristos85" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateOnly(2014, 8, 21), new DateOnly(2011, 8, 21) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Username",
                keyValue: "Aggelos.Aggelidoy35",
                columns: new[] { "BirthDate", "PasswordHash" },
                values: new object[] { new DateOnly(1978, 2, 26), "AQAAAAIAAYagAAAAEPy0Sa3t+0fqE5iMzp1a5B7FRWSO31WJ37yCzKu2fXCjldLH0utein9gF7o23hnu5g==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Username",
                keyValue: "Aggelos6",
                columns: new[] { "BirthDate", "PasswordHash" },
                values: new object[] { new DateOnly(1992, 6, 19), "AQAAAAIAAYagAAAAEPy0Sa3t+0fqE5iMzp1a5B7FRWSO31WJ37yCzKu2fXCjldLH0utein9gF7o23hnu5g==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Username",
                keyValue: "Aggelos87",
                columns: new[] { "BirthDate", "PasswordHash" },
                values: new object[] { new DateOnly(1997, 9, 11), "AQAAAAIAAYagAAAAEPy0Sa3t+0fqE5iMzp1a5B7FRWSO31WJ37yCzKu2fXCjldLH0utein9gF7o23hnu5g==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Username",
                keyValue: "Aggelos_Georgiadis30",
                columns: new[] { "BirthDate", "PasswordHash" },
                values: new object[] { new DateOnly(2003, 12, 5), "AQAAAAIAAYagAAAAEPy0Sa3t+0fqE5iMzp1a5B7FRWSO31WJ37yCzKu2fXCjldLH0utein9gF7o23hnu5g==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Username",
                keyValue: "Aleksandros.Zervos61",
                columns: new[] { "BirthDate", "PasswordHash" },
                values: new object[] { new DateOnly(1986, 9, 26), "AQAAAAIAAYagAAAAEPy0Sa3t+0fqE5iMzp1a5B7FRWSO31WJ37yCzKu2fXCjldLH0utein9gF7o23hnu5g==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Username",
                keyValue: "Aleksandros41",
                columns: new[] { "BirthDate", "PasswordHash" },
                values: new object[] { new DateOnly(1972, 10, 1), "AQAAAAIAAYagAAAAEPy0Sa3t+0fqE5iMzp1a5B7FRWSO31WJ37yCzKu2fXCjldLH0utein9gF7o23hnu5g==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Username",
                keyValue: "Anastasios_Nikolakos52",
                columns: new[] { "BirthDate", "PasswordHash" },
                values: new object[] { new DateOnly(1999, 11, 22), "AQAAAAIAAYagAAAAEPy0Sa3t+0fqE5iMzp1a5B7FRWSO31WJ37yCzKu2fXCjldLH0utein9gF7o23hnu5g==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Username",
                keyValue: "Andreas22",
                columns: new[] { "BirthDate", "PasswordHash" },
                values: new object[] { new DateOnly(1989, 9, 30), "AQAAAAIAAYagAAAAEPy0Sa3t+0fqE5iMzp1a5B7FRWSO31WJ37yCzKu2fXCjldLH0utein9gF7o23hnu5g==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Username",
                keyValue: "Andreas52",
                columns: new[] { "BirthDate", "PasswordHash" },
                values: new object[] { new DateOnly(1967, 2, 16), "AQAAAAIAAYagAAAAEPy0Sa3t+0fqE5iMzp1a5B7FRWSO31WJ37yCzKu2fXCjldLH0utein9gF7o23hnu5g==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Username",
                keyValue: "Andreas_Bikelidis33",
                columns: new[] { "BirthDate", "PasswordHash" },
                values: new object[] { new DateOnly(1983, 1, 27), "AQAAAAIAAYagAAAAEPy0Sa3t+0fqE5iMzp1a5B7FRWSO31WJ37yCzKu2fXCjldLH0utein9gF7o23hnu5g==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Username",
                keyValue: "Antonis.Lytras",
                columns: new[] { "BirthDate", "PasswordHash" },
                values: new object[] { new DateOnly(1962, 6, 3), "AQAAAAIAAYagAAAAEPy0Sa3t+0fqE5iMzp1a5B7FRWSO31WJ37yCzKu2fXCjldLH0utein9gF7o23hnu5g==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Username",
                keyValue: "Antonis4",
                columns: new[] { "BirthDate", "PasswordHash" },
                values: new object[] { new DateOnly(1986, 12, 4), "AQAAAAIAAYagAAAAEPy0Sa3t+0fqE5iMzp1a5B7FRWSO31WJ37yCzKu2fXCjldLH0utein9gF7o23hnu5g==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Username",
                keyValue: "Antonis_Antonopoylos",
                columns: new[] { "BirthDate", "PasswordHash" },
                values: new object[] { new DateOnly(2000, 12, 10), "AQAAAAIAAYagAAAAEPy0Sa3t+0fqE5iMzp1a5B7FRWSO31WJ37yCzKu2fXCjldLH0utein9gF7o23hnu5g==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Username",
                keyValue: "Antonis_Diamantopoylos43",
                columns: new[] { "BirthDate", "PasswordHash" },
                values: new object[] { new DateOnly(1992, 11, 23), "AQAAAAIAAYagAAAAEPy0Sa3t+0fqE5iMzp1a5B7FRWSO31WJ37yCzKu2fXCjldLH0utein9gF7o23hnu5g==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Username",
                keyValue: "Antonis_Karamanlis",
                columns: new[] { "BirthDate", "PasswordHash" },
                values: new object[] { new DateOnly(1986, 3, 25), "AQAAAAIAAYagAAAAEPy0Sa3t+0fqE5iMzp1a5B7FRWSO31WJ37yCzKu2fXCjldLH0utein9gF7o23hnu5g==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Username",
                keyValue: "Antonis_Melioi26",
                columns: new[] { "BirthDate", "PasswordHash" },
                values: new object[] { new DateOnly(1967, 3, 12), "AQAAAAIAAYagAAAAEPy0Sa3t+0fqE5iMzp1a5B7FRWSO31WJ37yCzKu2fXCjldLH0utein9gF7o23hnu5g==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Username",
                keyValue: "Apostolos.Kypraios",
                columns: new[] { "BirthDate", "PasswordHash" },
                values: new object[] { new DateOnly(1975, 12, 28), "AQAAAAIAAYagAAAAEPy0Sa3t+0fqE5iMzp1a5B7FRWSO31WJ37yCzKu2fXCjldLH0utein9gF7o23hnu5g==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Username",
                keyValue: "Apostolos44",
                columns: new[] { "BirthDate", "PasswordHash" },
                values: new object[] { new DateOnly(1982, 2, 21), "AQAAAAIAAYagAAAAEPy0Sa3t+0fqE5iMzp1a5B7FRWSO31WJ37yCzKu2fXCjldLH0utein9gF7o23hnu5g==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Username",
                keyValue: "Apostolos75",
                columns: new[] { "BirthDate", "PasswordHash" },
                values: new object[] { new DateOnly(1996, 7, 9), "AQAAAAIAAYagAAAAEPy0Sa3t+0fqE5iMzp1a5B7FRWSO31WJ37yCzKu2fXCjldLH0utein9gF7o23hnu5g==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Username",
                keyValue: "Apostolos_Daskalopoylos",
                columns: new[] { "BirthDate", "PasswordHash" },
                values: new object[] { new DateOnly(1973, 10, 30), "AQAAAAIAAYagAAAAEPy0Sa3t+0fqE5iMzp1a5B7FRWSO31WJ37yCzKu2fXCjldLH0utein9gF7o23hnu5g==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Username",
                keyValue: "Aristeidis.Aleksandroy12",
                columns: new[] { "BirthDate", "PasswordHash" },
                values: new object[] { new DateOnly(1995, 1, 25), "AQAAAAIAAYagAAAAEPy0Sa3t+0fqE5iMzp1a5B7FRWSO31WJ37yCzKu2fXCjldLH0utein9gF7o23hnu5g==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Username",
                keyValue: "Aristeidis.Papanikolaoy",
                columns: new[] { "BirthDate", "PasswordHash" },
                values: new object[] { new DateOnly(1982, 12, 7), "AQAAAAIAAYagAAAAEPy0Sa3t+0fqE5iMzp1a5B7FRWSO31WJ37yCzKu2fXCjldLH0utein9gF7o23hnu5g==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Username",
                keyValue: "Aristeidis_Melioi",
                columns: new[] { "BirthDate", "PasswordHash" },
                values: new object[] { new DateOnly(1999, 7, 7), "AQAAAAIAAYagAAAAEPy0Sa3t+0fqE5iMzp1a5B7FRWSO31WJ37yCzKu2fXCjldLH0utein9gF7o23hnu5g==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Username",
                keyValue: "Basilis.Koytalianos17",
                columns: new[] { "BirthDate", "PasswordHash" },
                values: new object[] { new DateOnly(2000, 7, 24), "AQAAAAIAAYagAAAAEPy0Sa3t+0fqE5iMzp1a5B7FRWSO31WJ37yCzKu2fXCjldLH0utein9gF7o23hnu5g==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Username",
                keyValue: "Basilis61",
                columns: new[] { "BirthDate", "PasswordHash" },
                values: new object[] { new DateOnly(1980, 7, 10), "AQAAAAIAAYagAAAAEPy0Sa3t+0fqE5iMzp1a5B7FRWSO31WJ37yCzKu2fXCjldLH0utein9gF7o23hnu5g==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Username",
                keyValue: "Basilis_Oikonomoy",
                columns: new[] { "BirthDate", "PasswordHash" },
                values: new object[] { new DateOnly(2001, 8, 1), "AQAAAAIAAYagAAAAEPy0Sa3t+0fqE5iMzp1a5B7FRWSO31WJ37yCzKu2fXCjldLH0utein9gF7o23hnu5g==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Username",
                keyValue: "Dimitris28",
                columns: new[] { "BirthDate", "PasswordHash" },
                values: new object[] { new DateOnly(1988, 4, 13), "AQAAAAIAAYagAAAAEPy0Sa3t+0fqE5iMzp1a5B7FRWSO31WJ37yCzKu2fXCjldLH0utein9gF7o23hnu5g==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Username",
                keyValue: "Dionysios.Anagnostakis",
                columns: new[] { "BirthDate", "PasswordHash" },
                values: new object[] { new DateOnly(1972, 11, 13), "AQAAAAIAAYagAAAAEPy0Sa3t+0fqE5iMzp1a5B7FRWSO31WJ37yCzKu2fXCjldLH0utein9gF7o23hnu5g==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Username",
                keyValue: "Dionysios.Lytras",
                columns: new[] { "BirthDate", "PasswordHash" },
                values: new object[] { new DateOnly(1967, 11, 7), "AQAAAAIAAYagAAAAEPy0Sa3t+0fqE5iMzp1a5B7FRWSO31WJ37yCzKu2fXCjldLH0utein9gF7o23hnu5g==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Username",
                keyValue: "Dionysios_Deli12",
                columns: new[] { "BirthDate", "PasswordHash" },
                values: new object[] { new DateOnly(1974, 12, 17), "AQAAAAIAAYagAAAAEPy0Sa3t+0fqE5iMzp1a5B7FRWSO31WJ37yCzKu2fXCjldLH0utein9gF7o23hnu5g==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Username",
                keyValue: "Eleytherios.Eleytherioy",
                columns: new[] { "BirthDate", "PasswordHash" },
                values: new object[] { new DateOnly(1984, 1, 31), "AQAAAAIAAYagAAAAEPy0Sa3t+0fqE5iMzp1a5B7FRWSO31WJ37yCzKu2fXCjldLH0utein9gF7o23hnu5g==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Username",
                keyValue: "Emmanoyil.Georgiadis",
                columns: new[] { "BirthDate", "PasswordHash" },
                values: new object[] { new DateOnly(1997, 12, 4), "AQAAAAIAAYagAAAAEPy0Sa3t+0fqE5iMzp1a5B7FRWSO31WJ37yCzKu2fXCjldLH0utein9gF7o23hnu5g==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Username",
                keyValue: "Emmanoyil_Aleksioy5",
                columns: new[] { "BirthDate", "PasswordHash" },
                values: new object[] { new DateOnly(1985, 1, 2), "AQAAAAIAAYagAAAAEPy0Sa3t+0fqE5iMzp1a5B7FRWSO31WJ37yCzKu2fXCjldLH0utein9gF7o23hnu5g==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Username",
                keyValue: "Emmanoyil_Koyndoyros",
                columns: new[] { "BirthDate", "PasswordHash" },
                values: new object[] { new DateOnly(1994, 10, 13), "AQAAAAIAAYagAAAAEPy0Sa3t+0fqE5iMzp1a5B7FRWSO31WJ37yCzKu2fXCjldLH0utein9gF7o23hnu5g==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Username",
                keyValue: "Emmanoyil_Maris67",
                columns: new[] { "BirthDate", "PasswordHash" },
                values: new object[] { new DateOnly(1991, 10, 10), "AQAAAAIAAYagAAAAEPy0Sa3t+0fqE5iMzp1a5B7FRWSO31WJ37yCzKu2fXCjldLH0utein9gF7o23hnu5g==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Username",
                keyValue: "Eyaggelos_Koromilas73",
                columns: new[] { "BirthDate", "PasswordHash" },
                values: new object[] { new DateOnly(1999, 5, 4), "AQAAAAIAAYagAAAAEPy0Sa3t+0fqE5iMzp1a5B7FRWSO31WJ37yCzKu2fXCjldLH0utein9gF7o23hnu5g==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Username",
                keyValue: "Eystathios17",
                columns: new[] { "BirthDate", "PasswordHash" },
                values: new object[] { new DateOnly(1987, 12, 28), "AQAAAAIAAYagAAAAEPy0Sa3t+0fqE5iMzp1a5B7FRWSO31WJ37yCzKu2fXCjldLH0utein9gF7o23hnu5g==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Username",
                keyValue: "Eystathios29",
                columns: new[] { "BirthDate", "PasswordHash" },
                values: new object[] { new DateOnly(2002, 11, 4), "AQAAAAIAAYagAAAAEPy0Sa3t+0fqE5iMzp1a5B7FRWSO31WJ37yCzKu2fXCjldLH0utein9gF7o23hnu5g==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Username",
                keyValue: "Eystathios57",
                columns: new[] { "BirthDate", "PasswordHash" },
                values: new object[] { new DateOnly(1972, 2, 3), "AQAAAAIAAYagAAAAEPy0Sa3t+0fqE5iMzp1a5B7FRWSO31WJ37yCzKu2fXCjldLH0utein9gF7o23hnu5g==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Username",
                keyValue: "Eystathios_Avramidis41",
                columns: new[] { "BirthDate", "PasswordHash" },
                values: new object[] { new DateOnly(2004, 4, 18), "AQAAAAIAAYagAAAAEPy0Sa3t+0fqE5iMzp1a5B7FRWSO31WJ37yCzKu2fXCjldLH0utein9gF7o23hnu5g==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Username",
                keyValue: "Fotios90",
                columns: new[] { "BirthDate", "PasswordHash" },
                values: new object[] { new DateOnly(2005, 10, 10), "AQAAAAIAAYagAAAAEPy0Sa3t+0fqE5iMzp1a5B7FRWSO31WJ37yCzKu2fXCjldLH0utein9gF7o23hnu5g==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Username",
                keyValue: "Fotios_Karavias7",
                columns: new[] { "BirthDate", "PasswordHash" },
                values: new object[] { new DateOnly(1978, 5, 19), "AQAAAAIAAYagAAAAEPy0Sa3t+0fqE5iMzp1a5B7FRWSO31WJ37yCzKu2fXCjldLH0utein9gF7o23hnu5g==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Username",
                keyValue: "Georgios.Eytaksias",
                columns: new[] { "BirthDate", "PasswordHash" },
                values: new object[] { new DateOnly(1976, 5, 31), "AQAAAAIAAYagAAAAEPy0Sa3t+0fqE5iMzp1a5B7FRWSO31WJ37yCzKu2fXCjldLH0utein9gF7o23hnu5g==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Username",
                keyValue: "Georgios2",
                columns: new[] { "BirthDate", "PasswordHash" },
                values: new object[] { new DateOnly(1999, 9, 24), "AQAAAAIAAYagAAAAEPy0Sa3t+0fqE5iMzp1a5B7FRWSO31WJ37yCzKu2fXCjldLH0utein9gF7o23hnu5g==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Username",
                keyValue: "Georgios45",
                columns: new[] { "BirthDate", "PasswordHash" },
                values: new object[] { new DateOnly(2001, 6, 3), "AQAAAAIAAYagAAAAEPy0Sa3t+0fqE5iMzp1a5B7FRWSO31WJ37yCzKu2fXCjldLH0utein9gF7o23hnu5g==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Username",
                keyValue: "Georgios79",
                columns: new[] { "BirthDate", "PasswordHash" },
                values: new object[] { new DateOnly(1965, 1, 23), "AQAAAAIAAYagAAAAEPy0Sa3t+0fqE5iMzp1a5B7FRWSO31WJ37yCzKu2fXCjldLH0utein9gF7o23hnu5g==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Username",
                keyValue: "Georgios_Bilaetis20",
                columns: new[] { "BirthDate", "PasswordHash" },
                values: new object[] { new DateOnly(1966, 5, 18), "AQAAAAIAAYagAAAAEPy0Sa3t+0fqE5iMzp1a5B7FRWSO31WJ37yCzKu2fXCjldLH0utein9gF7o23hnu5g==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Username",
                keyValue: "Grigorios.Boylgaris",
                columns: new[] { "BirthDate", "PasswordHash" },
                values: new object[] { new DateOnly(1990, 12, 25), "AQAAAAIAAYagAAAAEPy0Sa3t+0fqE5iMzp1a5B7FRWSO31WJ37yCzKu2fXCjldLH0utein9gF7o23hnu5g==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Username",
                keyValue: "Grigorios_Kontoleon41",
                columns: new[] { "BirthDate", "PasswordHash" },
                values: new object[] { new DateOnly(1974, 11, 1), "AQAAAAIAAYagAAAAEPy0Sa3t+0fqE5iMzp1a5B7FRWSO31WJ37yCzKu2fXCjldLH0utein9gF7o23hnu5g==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Username",
                keyValue: "Ilias.Metaksas74",
                columns: new[] { "BirthDate", "PasswordHash" },
                values: new object[] { new DateOnly(2001, 11, 4), "AQAAAAIAAYagAAAAEPy0Sa3t+0fqE5iMzp1a5B7FRWSO31WJ37yCzKu2fXCjldLH0utein9gF7o23hnu5g==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Username",
                keyValue: "Ilias.Zafeiropoylos86",
                columns: new[] { "BirthDate", "PasswordHash" },
                values: new object[] { new DateOnly(1968, 10, 13), "AQAAAAIAAYagAAAAEPy0Sa3t+0fqE5iMzp1a5B7FRWSO31WJ37yCzKu2fXCjldLH0utein9gF7o23hnu5g==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Username",
                keyValue: "Ilias_Bamvas22",
                columns: new[] { "BirthDate", "PasswordHash" },
                values: new object[] { new DateOnly(1999, 7, 29), "AQAAAAIAAYagAAAAEPy0Sa3t+0fqE5iMzp1a5B7FRWSO31WJ37yCzKu2fXCjldLH0utein9gF7o23hnu5g==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Username",
                keyValue: "Ioannis.Aygerinoseponymo0",
                columns: new[] { "BirthDate", "PasswordHash" },
                values: new object[] { new DateOnly(1994, 5, 8), "AQAAAAIAAYagAAAAEPy0Sa3t+0fqE5iMzp1a5B7FRWSO31WJ37yCzKu2fXCjldLH0utein9gF7o23hnu5g==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Username",
                keyValue: "Ioannis.Zappas99",
                columns: new[] { "BirthDate", "PasswordHash" },
                values: new object[] { new DateOnly(1977, 5, 19), "AQAAAAIAAYagAAAAEPy0Sa3t+0fqE5iMzp1a5B7FRWSO31WJ37yCzKu2fXCjldLH0utein9gF7o23hnu5g==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Username",
                keyValue: "Ioannis28",
                columns: new[] { "BirthDate", "PasswordHash" },
                values: new object[] { new DateOnly(1978, 8, 7), "AQAAAAIAAYagAAAAEPy0Sa3t+0fqE5iMzp1a5B7FRWSO31WJ37yCzKu2fXCjldLH0utein9gF7o23hnu5g==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Username",
                keyValue: "Ioannis_Basilopoylos",
                columns: new[] { "BirthDate", "PasswordHash" },
                values: new object[] { new DateOnly(1989, 1, 28), "AQAAAAIAAYagAAAAEPy0Sa3t+0fqE5iMzp1a5B7FRWSO31WJ37yCzKu2fXCjldLH0utein9gF7o23hnu5g==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Username",
                keyValue: "Kostas43",
                columns: new[] { "BirthDate", "PasswordHash" },
                values: new object[] { new DateOnly(2004, 6, 29), "AQAAAAIAAYagAAAAEPy0Sa3t+0fqE5iMzp1a5B7FRWSO31WJ37yCzKu2fXCjldLH0utein9gF7o23hnu5g==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Username",
                keyValue: "Kostas92",
                columns: new[] { "BirthDate", "PasswordHash" },
                values: new object[] { new DateOnly(1964, 6, 15), "AQAAAAIAAYagAAAAEPy0Sa3t+0fqE5iMzp1a5B7FRWSO31WJ37yCzKu2fXCjldLH0utein9gF7o23hnu5g==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Username",
                keyValue: "Kostas_Byzantios65",
                columns: new[] { "BirthDate", "PasswordHash" },
                values: new object[] { new DateOnly(1995, 6, 12), "AQAAAAIAAYagAAAAEPy0Sa3t+0fqE5iMzp1a5B7FRWSO31WJ37yCzKu2fXCjldLH0utein9gF7o23hnu5g==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Username",
                keyValue: "Mixail.Bergas85",
                columns: new[] { "BirthDate", "PasswordHash" },
                values: new object[] { new DateOnly(1960, 11, 13), "AQAAAAIAAYagAAAAEPy0Sa3t+0fqE5iMzp1a5B7FRWSO31WJ37yCzKu2fXCjldLH0utein9gF7o23hnu5g==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Username",
                keyValue: "Mixail.Ioannoy",
                columns: new[] { "BirthDate", "PasswordHash" },
                values: new object[] { new DateOnly(1963, 12, 27), "AQAAAAIAAYagAAAAEPy0Sa3t+0fqE5iMzp1a5B7FRWSO31WJ37yCzKu2fXCjldLH0utein9gF7o23hnu5g==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Username",
                keyValue: "Mixail90",
                columns: new[] { "BirthDate", "PasswordHash" },
                values: new object[] { new DateOnly(1982, 5, 20), "AQAAAAIAAYagAAAAEPy0Sa3t+0fqE5iMzp1a5B7FRWSO31WJ37yCzKu2fXCjldLH0utein9gF7o23hnu5g==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Username",
                keyValue: "Nikolaos_Boyrdoympas15",
                columns: new[] { "BirthDate", "PasswordHash" },
                values: new object[] { new DateOnly(1994, 8, 30), "AQAAAAIAAYagAAAAEPy0Sa3t+0fqE5iMzp1a5B7FRWSO31WJ37yCzKu2fXCjldLH0utein9gF7o23hnu5g==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Username",
                keyValue: "Paraskeyas.Anagnostakis",
                columns: new[] { "BirthDate", "PasswordHash" },
                values: new object[] { new DateOnly(1996, 12, 31), "AQAAAAIAAYagAAAAEPy0Sa3t+0fqE5iMzp1a5B7FRWSO31WJ37yCzKu2fXCjldLH0utein9gF7o23hnu5g==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Username",
                keyValue: "Paylos.Giagkos",
                columns: new[] { "BirthDate", "PasswordHash" },
                values: new object[] { new DateOnly(1978, 10, 27), "AQAAAAIAAYagAAAAEPy0Sa3t+0fqE5iMzp1a5B7FRWSO31WJ37yCzKu2fXCjldLH0utein9gF7o23hnu5g==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Username",
                keyValue: "Paylos.Koyndoyros",
                columns: new[] { "BirthDate", "PasswordHash" },
                values: new object[] { new DateOnly(1967, 6, 20), "AQAAAAIAAYagAAAAEPy0Sa3t+0fqE5iMzp1a5B7FRWSO31WJ37yCzKu2fXCjldLH0utein9gF7o23hnu5g==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Username",
                keyValue: "Paylos48",
                columns: new[] { "BirthDate", "PasswordHash" },
                values: new object[] { new DateOnly(1981, 11, 17), "AQAAAAIAAYagAAAAEPy0Sa3t+0fqE5iMzp1a5B7FRWSO31WJ37yCzKu2fXCjldLH0utein9gF7o23hnu5g==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Username",
                keyValue: "Paylos_Kalyvas76",
                columns: new[] { "BirthDate", "PasswordHash" },
                values: new object[] { new DateOnly(2001, 6, 8), "AQAAAAIAAYagAAAAEPy0Sa3t+0fqE5iMzp1a5B7FRWSO31WJ37yCzKu2fXCjldLH0utein9gF7o23hnu5g==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Username",
                keyValue: "Petros.Blavianos51",
                columns: new[] { "BirthDate", "PasswordHash" },
                values: new object[] { new DateOnly(2002, 1, 4), "AQAAAAIAAYagAAAAEPy0Sa3t+0fqE5iMzp1a5B7FRWSO31WJ37yCzKu2fXCjldLH0utein9gF7o23hnu5g==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Username",
                keyValue: "Petros77",
                columns: new[] { "BirthDate", "PasswordHash" },
                values: new object[] { new DateOnly(1985, 4, 27), "AQAAAAIAAYagAAAAEPy0Sa3t+0fqE5iMzp1a5B7FRWSO31WJ37yCzKu2fXCjldLH0utein9gF7o23hnu5g==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Username",
                keyValue: "Sotirios.Germanos87",
                columns: new[] { "BirthDate", "PasswordHash" },
                values: new object[] { new DateOnly(1997, 4, 3), "AQAAAAIAAYagAAAAEPy0Sa3t+0fqE5iMzp1a5B7FRWSO31WJ37yCzKu2fXCjldLH0utein9gF7o23hnu5g==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Username",
                keyValue: "Sotirios.Kalogiannis43",
                columns: new[] { "BirthDate", "PasswordHash" },
                values: new object[] { new DateOnly(1979, 5, 10), "AQAAAAIAAYagAAAAEPy0Sa3t+0fqE5iMzp1a5B7FRWSO31WJ37yCzKu2fXCjldLH0utein9gF7o23hnu5g==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Username",
                keyValue: "Sotirios.THeodosioy",
                columns: new[] { "BirthDate", "PasswordHash" },
                values: new object[] { new DateOnly(2005, 9, 3), "AQAAAAIAAYagAAAAEPy0Sa3t+0fqE5iMzp1a5B7FRWSO31WJ37yCzKu2fXCjldLH0utein9gF7o23hnu5g==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Username",
                keyValue: "Sotirios_Zervos",
                columns: new[] { "BirthDate", "PasswordHash" },
                values: new object[] { new DateOnly(1990, 6, 20), "AQAAAAIAAYagAAAAEPy0Sa3t+0fqE5iMzp1a5B7FRWSO31WJ37yCzKu2fXCjldLH0utein9gF7o23hnu5g==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Username",
                keyValue: "Spyros97",
                columns: new[] { "BirthDate", "PasswordHash" },
                values: new object[] { new DateOnly(1971, 8, 14), "AQAAAAIAAYagAAAAEPy0Sa3t+0fqE5iMzp1a5B7FRWSO31WJ37yCzKu2fXCjldLH0utein9gF7o23hnu5g==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Username",
                keyValue: "Spyros_Anastasiadis",
                columns: new[] { "BirthDate", "PasswordHash" },
                values: new object[] { new DateOnly(1977, 3, 31), "AQAAAAIAAYagAAAAEPy0Sa3t+0fqE5iMzp1a5B7FRWSO31WJ37yCzKu2fXCjldLH0utein9gF7o23hnu5g==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Username",
                keyValue: "Stayros.Koronaios",
                columns: new[] { "BirthDate", "PasswordHash" },
                values: new object[] { new DateOnly(1976, 5, 20), "AQAAAAIAAYagAAAAEPy0Sa3t+0fqE5iMzp1a5B7FRWSO31WJ37yCzKu2fXCjldLH0utein9gF7o23hnu5g==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Username",
                keyValue: "Stayros_Bergas29",
                columns: new[] { "BirthDate", "PasswordHash" },
                values: new object[] { new DateOnly(1967, 8, 14), "AQAAAAIAAYagAAAAEPy0Sa3t+0fqE5iMzp1a5B7FRWSO31WJ37yCzKu2fXCjldLH0utein9gF7o23hnu5g==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Username",
                keyValue: "Stefanos.Loypis27",
                columns: new[] { "BirthDate", "PasswordHash" },
                values: new object[] { new DateOnly(1979, 6, 27), "AQAAAAIAAYagAAAAEPy0Sa3t+0fqE5iMzp1a5B7FRWSO31WJ37yCzKu2fXCjldLH0utein9gF7o23hnu5g==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Username",
                keyValue: "Stefanos.Nikolaidis21",
                columns: new[] { "BirthDate", "PasswordHash" },
                values: new object[] { new DateOnly(1978, 1, 12), "AQAAAAIAAYagAAAAEPy0Sa3t+0fqE5iMzp1a5B7FRWSO31WJ37yCzKu2fXCjldLH0utein9gF7o23hnu5g==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Username",
                keyValue: "Stylianos.Basileiadis",
                columns: new[] { "BirthDate", "PasswordHash" },
                values: new object[] { new DateOnly(1973, 1, 27), "AQAAAAIAAYagAAAAEPy0Sa3t+0fqE5iMzp1a5B7FRWSO31WJ37yCzKu2fXCjldLH0utein9gF7o23hnu5g==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Username",
                keyValue: "Stylianos.Mitzoy",
                columns: new[] { "BirthDate", "PasswordHash" },
                values: new object[] { new DateOnly(1975, 5, 25), "AQAAAAIAAYagAAAAEPy0Sa3t+0fqE5iMzp1a5B7FRWSO31WJ37yCzKu2fXCjldLH0utein9gF7o23hnu5g==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Username",
                keyValue: "THeodoros.Basileiadis2",
                columns: new[] { "BirthDate", "PasswordHash" },
                values: new object[] { new DateOnly(1981, 4, 30), "AQAAAAIAAYagAAAAEPy0Sa3t+0fqE5iMzp1a5B7FRWSO31WJ37yCzKu2fXCjldLH0utein9gF7o23hnu5g==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Username",
                keyValue: "THeodoros.Zafeiropoylos96",
                columns: new[] { "BirthDate", "PasswordHash" },
                values: new object[] { new DateOnly(2002, 8, 25), "AQAAAAIAAYagAAAAEPy0Sa3t+0fqE5iMzp1a5B7FRWSO31WJ37yCzKu2fXCjldLH0utein9gF7o23hnu5g==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Username",
                keyValue: "THeodoros68",
                columns: new[] { "BirthDate", "PasswordHash" },
                values: new object[] { new DateOnly(1987, 10, 2), "AQAAAAIAAYagAAAAEPy0Sa3t+0fqE5iMzp1a5B7FRWSO31WJ37yCzKu2fXCjldLH0utein9gF7o23hnu5g==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Username",
                keyValue: "Xaralampos43",
                columns: new[] { "BirthDate", "PasswordHash" },
                values: new object[] { new DateOnly(1983, 5, 22), "AQAAAAIAAYagAAAAEPy0Sa3t+0fqE5iMzp1a5B7FRWSO31WJ37yCzKu2fXCjldLH0utein9gF7o23hnu5g==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Username",
                keyValue: "Xaralampos68",
                columns: new[] { "BirthDate", "PasswordHash" },
                values: new object[] { new DateOnly(1980, 9, 6), "AQAAAAIAAYagAAAAEPy0Sa3t+0fqE5iMzp1a5B7FRWSO31WJ37yCzKu2fXCjldLH0utein9gF7o23hnu5g==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Username",
                keyValue: "Xaralampos74",
                columns: new[] { "BirthDate", "PasswordHash" },
                values: new object[] { new DateOnly(1988, 3, 14), "AQAAAAIAAYagAAAAEPy0Sa3t+0fqE5iMzp1a5B7FRWSO31WJ37yCzKu2fXCjldLH0utein9gF7o23hnu5g==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Username",
                keyValue: "Xristos.Aggelopoylos",
                columns: new[] { "BirthDate", "PasswordHash" },
                values: new object[] { new DateOnly(1977, 1, 18), "AQAAAAIAAYagAAAAEPy0Sa3t+0fqE5iMzp1a5B7FRWSO31WJ37yCzKu2fXCjldLH0utein9gF7o23hnu5g==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Username",
                keyValue: "Xristos80",
                columns: new[] { "BirthDate", "PasswordHash" },
                values: new object[] { new DateOnly(1992, 6, 6), "AQAAAAIAAYagAAAAEPy0Sa3t+0fqE5iMzp1a5B7FRWSO31WJ37yCzKu2fXCjldLH0utein9gF7o23hnu5g==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Username",
                keyValue: "Xristos85",
                columns: new[] { "BirthDate", "PasswordHash" },
                values: new object[] { new DateOnly(1993, 8, 21), "AQAAAAIAAYagAAAAEPy0Sa3t+0fqE5iMzp1a5B7FRWSO31WJ37yCzKu2fXCjldLH0utein9gF7o23hnu5g==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Username",
                keyValue: "oktato",
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEGwWzLcK2LgEqebi3IQz3KDZalg30QuzeHZhqgav06HdMDPOVOm5CJ8u4IsOPjCFqw==");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Username",
                keyValue: "tanulo",
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEPy0Sa3t+0fqE5iMzp1a5B7FRWSO31WJ37yCzKu2fXCjldLH0utein9gF7o23hnu5g==");

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Username", "BirthDate", "BirthLocation", "Name", "PasswordHash" },
                values: new object[,]
                {
                    { "Anastasios.Liapis89", new DateOnly(1986, 12, 8), "North Αριστείδηςburgh", "Γρηγόριος Καζαντζής", "AQAAAAIAAYagAAAAEPy0Sa3t+0fqE5iMzp1a5B7FRWSO31WJ37yCzKu2fXCjldLH0utein9gF7o23hnu5g==" },
                    { "Andreas65", new DateOnly(2003, 3, 15), "Δημήτρηςbury", "Γεώργιος Βλαβιανός", "AQAAAAIAAYagAAAAEPy0Sa3t+0fqE5iMzp1a5B7FRWSO31WJ37yCzKu2fXCjldLH0utein9gF7o23hnu5g==" },
                    { "Apostolos_Mitsotakis", new DateOnly(1999, 1, 18), "East Στέφανος", "Σταύρος Κακριδής", "AQAAAAIAAYagAAAAEPy0Sa3t+0fqE5iMzp1a5B7FRWSO31WJ37yCzKu2fXCjldLH0utein9gF7o23hnu5g==" },
                    { "Basilis.Athanasioy", new DateOnly(1965, 11, 3), "Αναστασιάδηςmouth", "Άγγελος Κουρμούλης", "AQAAAAIAAYagAAAAEPy0Sa3t+0fqE5iMzp1a5B7FRWSO31WJ37yCzKu2fXCjldLH0utein9gF7o23hnu5g==" },
                    { "Dimitris93", new DateOnly(1969, 3, 25), "West Μιχαήλ", "Κώστας Θεοδοσίου", "AQAAAAIAAYagAAAAEPy0Sa3t+0fqE5iMzp1a5B7FRWSO31WJ37yCzKu2fXCjldLH0utein9gF7o23hnu5g==" },
                    { "Eleytherios16", new DateOnly(1967, 10, 23), "Σταύροςhaven", "Εμμανουήλ Κουρμούλης", "AQAAAAIAAYagAAAAEPy0Sa3t+0fqE5iMzp1a5B7FRWSO31WJ37yCzKu2fXCjldLH0utein9gF7o23hnu5g==" },
                    { "Eyaggelos_Galanis52", new DateOnly(1994, 6, 22), "Port Αλέξανδροςmouth", "Στέφανος Βυζάντιος", "AQAAAAIAAYagAAAAEPy0Sa3t+0fqE5iMzp1a5B7FRWSO31WJ37yCzKu2fXCjldLH0utein9gF7o23hnu5g==" },
                    { "Panagiotis29", new DateOnly(1996, 4, 1), "North Ανδρέας", "Βασίλης Αντωνιάδης", "AQAAAAIAAYagAAAAEPy0Sa3t+0fqE5iMzp1a5B7FRWSO31WJ37yCzKu2fXCjldLH0utein9gF7o23hnu5g==" },
                    { "Spyros17", new DateOnly(2005, 3, 22), "Γαλάνηburgh", "Ιωάννης Καλογιάννης", "AQAAAAIAAYagAAAAEPy0Sa3t+0fqE5iMzp1a5B7FRWSO31WJ37yCzKu2fXCjldLH0utein9gF7o23hnu5g==" }
                });

            migrationBuilder.InsertData(
                table: "DegreeParticipations",
                columns: new[] { "DegreeName", "Username", "EndDate", "StartDate" },
                values: new object[,]
                {
                    { "Movies & Toys (286)", "Anastasios.Liapis89", new DateOnly(2007, 12, 8), new DateOnly(2004, 12, 8) },
                    { "Movies & Toys (286)", "Andreas65", new DateOnly(2024, 3, 15), new DateOnly(2021, 3, 15) },
                    { "Toys (267)", "Apostolos_Mitsotakis", new DateOnly(2020, 1, 18), new DateOnly(2017, 1, 18) },
                    { "Garden (271)", "Basilis.Athanasioy", new DateOnly(1986, 11, 3), new DateOnly(1983, 11, 3) },
                    { "Music, Movies & Industrial (280)", "Dimitris93", new DateOnly(1990, 3, 25), new DateOnly(1987, 3, 25) },
                    { "Sports (274)", "Eleytherios16", new DateOnly(1988, 10, 23), new DateOnly(1985, 10, 23) },
                    { "Jewelery, Automotive & Garden (276)", "Eyaggelos_Galanis52", new DateOnly(2015, 6, 22), new DateOnly(2012, 6, 22) },
                    { "Computers, Toys & Beauty (278)", "Panagiotis29", new DateOnly(2017, 4, 1), new DateOnly(2014, 4, 1) },
                    { "Jewelery, Automotive & Garden (276)", "Spyros17", new DateOnly(2026, 3, 22), new DateOnly(2023, 3, 22) }
                });

            migrationBuilder.InsertData(
                table: "UserRoles",
                columns: new[] { "UserType", "Username" },
                values: new object[,]
                {
                    { 0, "Apostolos_Mitsotakis" },
                    { 0, "Basilis.Athanasioy" },
                    { 0, "Dimitris93" },
                    { 0, "Spyros17" },
                    { 1, "Anastasios.Liapis89" },
                    { 1, "Andreas65" },
                    { 1, "Apostolos_Mitsotakis" },
                    { 1, "Basilis.Athanasioy" },
                    { 1, "Dimitris93" },
                    { 1, "Eleytherios16" },
                    { 1, "Eyaggelos_Galanis52" },
                    { 1, "Panagiotis29" },
                    { 1, "Spyros17" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ClassRooms",
                keyColumns: new[] { "Address", "RoomNumber" },
                keyValues: new object[] { "0002 Λειβαδάς Causeway, East Ευστάθιοςburgh, Honduras", "90" });

            migrationBuilder.DeleteData(
                table: "ClassRooms",
                keyColumns: new[] { "Address", "RoomNumber" },
                keyValues: new object[] { "0272 Ευάγγελος Stream, Μπότσαρηςtown, United States Minor Outlying Islands", "278" });

            migrationBuilder.DeleteData(
                table: "ClassRooms",
                keyColumns: new[] { "Address", "RoomNumber" },
                keyValues: new object[] { "04326 Ιωάννης Union, South Γεώργιος, Rwanda", "307" });

            migrationBuilder.DeleteData(
                table: "ClassRooms",
                keyColumns: new[] { "Address", "RoomNumber" },
                keyValues: new object[] { "067 Μαρής Ports, East Εμμανουήλ, Virgin Islands, U.S.", "132" });

            migrationBuilder.DeleteData(
                table: "ClassRooms",
                keyColumns: new[] { "Address", "RoomNumber" },
                keyValues: new object[] { "0855 Παπαδόπουλος Shores, Port Ανδρέαςfort, Singapore", "108" });

            migrationBuilder.DeleteData(
                table: "ClassRooms",
                keyColumns: new[] { "Address", "RoomNumber" },
                keyValues: new object[] { "09433 Ελευθερόπουλος Station, Lake Ελευθέριος, Gibraltar", "23" });

            migrationBuilder.DeleteData(
                table: "ClassRooms",
                keyColumns: new[] { "Address", "RoomNumber" },
                keyValues: new object[] { "109 Στέφανος Shoals, Αθανάσιοςview, Netherlands Antilles", "243" });

            migrationBuilder.DeleteData(
                table: "ClassRooms",
                keyColumns: new[] { "Address", "RoomNumber" },
                keyValues: new object[] { "11443 Ζερβός Creek, New Ευστάθιοςfort, French Polynesia", "87" });

            migrationBuilder.DeleteData(
                table: "ClassRooms",
                keyColumns: new[] { "Address", "RoomNumber" },
                keyValues: new object[] { "11588 Κώστας Expressway, Κώσταςfort, Puerto Rico", "81" });

            migrationBuilder.DeleteData(
                table: "ClassRooms",
                keyColumns: new[] { "Address", "RoomNumber" },
                keyValues: new object[] { "1211 Ιωάννης Valley, Lake Σταύροςshire, Philippines", "87" });

            migrationBuilder.DeleteData(
                table: "ClassRooms",
                keyColumns: new[] { "Address", "RoomNumber" },
                keyValues: new object[] { "12346 Στυλιανός Haven, Βαμβακάςburgh, Italy", "132" });

            migrationBuilder.DeleteData(
                table: "ClassRooms",
                keyColumns: new[] { "Address", "RoomNumber" },
                keyValues: new object[] { "12539 Μιχαήλ Track, West Σπύρος, Finland", "134" });

            migrationBuilder.DeleteData(
                table: "ClassRooms",
                keyColumns: new[] { "Address", "RoomNumber" },
                keyValues: new object[] { "1616 Βενιζέλος Station, New Ελευθέριος, Niger", "52" });

            migrationBuilder.DeleteData(
                table: "ClassRooms",
                keyColumns: new[] { "Address", "RoomNumber" },
                keyValues: new object[] { "1695 Αντωνιάδης Views, Port Αλέξανδροςhaven, Saint Martin", "272" });

            migrationBuilder.DeleteData(
                table: "ClassRooms",
                keyColumns: new[] { "Address", "RoomNumber" },
                keyValues: new object[] { "17283 Κοτζιάς Skyway, Μπλέτσαςhaven, Sierra Leone", "81" });

            migrationBuilder.DeleteData(
                table: "ClassRooms",
                keyColumns: new[] { "Address", "RoomNumber" },
                keyValues: new object[] { "1878 Άγγελος Trail, East Γρηγόριος, Lithuania", "137" });

            migrationBuilder.DeleteData(
                table: "ClassRooms",
                keyColumns: new[] { "Address", "RoomNumber" },
                keyValues: new object[] { "1988 Αγγελίδου Stravenue, East Χαράλαμπος, Micronesia", "103" });

            migrationBuilder.DeleteData(
                table: "ClassRooms",
                keyColumns: new[] { "Address", "RoomNumber" },
                keyValues: new object[] { "2369 Βάμβας Locks, Σταύροςchester, China", "16" });

            migrationBuilder.DeleteData(
                table: "ClassRooms",
                keyColumns: new[] { "Address", "RoomNumber" },
                keyValues: new object[] { "24163 Ευστάθιος Expressway, East Φώτιος, Nicaragua", "59" });

            migrationBuilder.DeleteData(
                table: "ClassRooms",
                keyColumns: new[] { "Address", "RoomNumber" },
                keyValues: new object[] { "252 Παπακώστας Extension, Ελευθεριάδηςmouth, Netherlands Antilles", "284" });

            migrationBuilder.DeleteData(
                table: "ClassRooms",
                keyColumns: new[] { "Address", "RoomNumber" },
                keyValues: new object[] { "2578 Αντώνης Hill, New Ανδρέαςhaven, Gibraltar", "276" });

            migrationBuilder.DeleteData(
                table: "ClassRooms",
                keyColumns: new[] { "Address", "RoomNumber" },
                keyValues: new object[] { "260 Μελετόπουλος Lake, South Νικόλαοςchester, Zimbabwe", "78" });

            migrationBuilder.DeleteData(
                table: "ClassRooms",
                keyColumns: new[] { "Address", "RoomNumber" },
                keyValues: new object[] { "27308 Μαρής Spur, Εμμανουήλville, Guam", "340" });

            migrationBuilder.DeleteData(
                table: "ClassRooms",
                keyColumns: new[] { "Address", "RoomNumber" },
                keyValues: new object[] { "276 Παπακώστας Neck, Γεώργιοςberg, Netherlands", "286" });

            migrationBuilder.DeleteData(
                table: "ClassRooms",
                keyColumns: new[] { "Address", "RoomNumber" },
                keyValues: new object[] { "2821 Αλεξάνδρου Spring, Διονύσιοςstad, Saint Barthelemy", "198" });

            migrationBuilder.DeleteData(
                table: "ClassRooms",
                keyColumns: new[] { "Address", "RoomNumber" },
                keyValues: new object[] { "31452 Σωτήριος Ports, Ζωγράφοςton, Brunei Darussalam", "297" });

            migrationBuilder.DeleteData(
                table: "ClassRooms",
                keyColumns: new[] { "Address", "RoomNumber" },
                keyValues: new object[] { "318 Αθανασιάδης Mews, Βικελίδηςburgh, Suriname", "262" });

            migrationBuilder.DeleteData(
                table: "ClassRooms",
                keyColumns: new[] { "Address", "RoomNumber" },
                keyValues: new object[] { "327 Στέφανος Streets, Lake Ελευθέριοςmouth, Swaziland", "39" });

            migrationBuilder.DeleteData(
                table: "ClassRooms",
                keyColumns: new[] { "Address", "RoomNumber" },
                keyValues: new object[] { "3431 Χρήστος Place, Βλαχόπουλοςton, Faroe Islands", "307" });

            migrationBuilder.DeleteData(
                table: "ClassRooms",
                keyColumns: new[] { "Address", "RoomNumber" },
                keyValues: new object[] { "35546 Δασκαλόπουλος Springs, Ελευθέριοςville, Ireland", "207" });

            migrationBuilder.DeleteData(
                table: "ClassRooms",
                keyColumns: new[] { "Address", "RoomNumber" },
                keyValues: new object[] { "3595 Γλυκύς Station, Απόστολοςland, Grenada", "178" });

            migrationBuilder.DeleteData(
                table: "ClassRooms",
                keyColumns: new[] { "Address", "RoomNumber" },
                keyValues: new object[] { "36767 Στυλιανός Knolls, North Ελευθέριος, Belize", "108" });

            migrationBuilder.DeleteData(
                table: "ClassRooms",
                keyColumns: new[] { "Address", "RoomNumber" },
                keyValues: new object[] { "3684 Αλεξάνδρου Camp, Βλαχόπουλοςview, Denmark", "162" });

            migrationBuilder.DeleteData(
                table: "ClassRooms",
                keyColumns: new[] { "Address", "RoomNumber" },
                keyValues: new object[] { "377 Ουζουνίδης Ridge, Γεώργιοςhaven, New Zealand", "83" });

            migrationBuilder.DeleteData(
                table: "ClassRooms",
                keyColumns: new[] { "Address", "RoomNumber" },
                keyValues: new object[] { "384 Αλέξανδρος Bridge, Αναστάσιοςton, Egypt", "195" });

            migrationBuilder.DeleteData(
                table: "ClassRooms",
                keyColumns: new[] { "Address", "RoomNumber" },
                keyValues: new object[] { "392 Διονύσιος Glen, West Άγγελοςton, Russian Federation", "192" });

            migrationBuilder.DeleteData(
                table: "ClassRooms",
                keyColumns: new[] { "Address", "RoomNumber" },
                keyValues: new object[] { "39884 Δημητρίου Villages, East Σταύροςside, Mayotte", "301" });

            migrationBuilder.DeleteData(
                table: "ClassRooms",
                keyColumns: new[] { "Address", "RoomNumber" },
                keyValues: new object[] { "40306 Γερμανός Junction, Port Ευστάθιος, Peru", "228" });

            migrationBuilder.DeleteData(
                table: "ClassRooms",
                keyColumns: new[] { "Address", "RoomNumber" },
                keyValues: new object[] { "416 Κώστας View, East Αριστείδηςhaven, Jamaica", "327" });

            migrationBuilder.DeleteData(
                table: "ClassRooms",
                keyColumns: new[] { "Address", "RoomNumber" },
                keyValues: new object[] { "417 Αυγερινός (επώνυμο) Causeway, West Ευάγγελοςville, Rwanda", "21" });

            migrationBuilder.DeleteData(
                table: "ClassRooms",
                keyColumns: new[] { "Address", "RoomNumber" },
                keyValues: new object[] { "430 Γιαννακόπουλος Rest, Διονύσιοςfurt, Bhutan", "311" });

            migrationBuilder.DeleteData(
                table: "ClassRooms",
                keyColumns: new[] { "Address", "RoomNumber" },
                keyValues: new object[] { "43084 Λειβαδάς Underpass, Άγγελοςport, Ethiopia", "72" });

            migrationBuilder.DeleteData(
                table: "ClassRooms",
                keyColumns: new[] { "Address", "RoomNumber" },
                keyValues: new object[] { "438 Μέλιοι Light, West Νικόλαος, Sierra Leone", "220" });

            migrationBuilder.DeleteData(
                table: "ClassRooms",
                keyColumns: new[] { "Address", "RoomNumber" },
                keyValues: new object[] { "453 Λεωνίδας Groves, West Θεόδωρος, Uruguay", "84" });

            migrationBuilder.DeleteData(
                table: "ClassRooms",
                keyColumns: new[] { "Address", "RoomNumber" },
                keyValues: new object[] { "45669 Ελευθέριος Lodge, Αβραμίδηςton, Zimbabwe", "18" });

            migrationBuilder.DeleteData(
                table: "ClassRooms",
                keyColumns: new[] { "Address", "RoomNumber" },
                keyValues: new object[] { "475 Ηλίας Field, Ζαΐμηςbury, Bahamas", "32" });

            migrationBuilder.DeleteData(
                table: "ClassRooms",
                keyColumns: new[] { "Address", "RoomNumber" },
                keyValues: new object[] { "4762 Στέφανος Corner, Νικόλαοςview, Lebanon", "61" });

            migrationBuilder.DeleteData(
                table: "ClassRooms",
                keyColumns: new[] { "Address", "RoomNumber" },
                keyValues: new object[] { "481 Ηλίας Corner, Ελευθέριοςmouth, India", "109" });

            migrationBuilder.DeleteData(
                table: "ClassRooms",
                keyColumns: new[] { "Address", "RoomNumber" },
                keyValues: new object[] { "490 Δημήτρης Well, Lake Αντώνης, Niue", "30" });

            migrationBuilder.DeleteData(
                table: "ClassRooms",
                keyColumns: new[] { "Address", "RoomNumber" },
                keyValues: new object[] { "49187 Βούλγαρης Spring, Αντώνηςborough, Malawi", "155" });

            migrationBuilder.DeleteData(
                table: "ClassRooms",
                keyColumns: new[] { "Address", "RoomNumber" },
                keyValues: new object[] { "4927 Λειβαδάς Glens, Βασιλειάδηςchester, Lesotho", "26" });

            migrationBuilder.DeleteData(
                table: "ClassRooms",
                keyColumns: new[] { "Address", "RoomNumber" },
                keyValues: new object[] { "50225 Εμμανουήλ Gardens, Κοντόσταυλοςburgh, Colombia", "154" });

            migrationBuilder.DeleteData(
                table: "ClassRooms",
                keyColumns: new[] { "Address", "RoomNumber" },
                keyValues: new object[] { "5146 Καψής Locks, Αντώνηςbury, Vanuatu", "317" });

            migrationBuilder.DeleteData(
                table: "ClassRooms",
                keyColumns: new[] { "Address", "RoomNumber" },
                keyValues: new object[] { "52259 Στέφανος Station, South Ελευθέριοςview, Rwanda", "16" });

            migrationBuilder.DeleteData(
                table: "ClassRooms",
                keyColumns: new[] { "Address", "RoomNumber" },
                keyValues: new object[] { "523 Ανδρέας Causeway, Port Αλέξανδροςchester, Mexico", "26" });

            migrationBuilder.DeleteData(
                table: "ClassRooms",
                keyColumns: new[] { "Address", "RoomNumber" },
                keyValues: new object[] { "52397 Ανδρέας Oval, New Στυλιανός, Zambia", "241" });

            migrationBuilder.DeleteData(
                table: "ClassRooms",
                keyColumns: new[] { "Address", "RoomNumber" },
                keyValues: new object[] { "5259 Παπανδρέου Cliff, South Ανδρέαςside, Heard Island and McDonald Islands", "187" });

            migrationBuilder.DeleteData(
                table: "ClassRooms",
                keyColumns: new[] { "Address", "RoomNumber" },
                keyValues: new object[] { "5356 Δημήτρης Heights, Ακρίδαςtown, Ecuador", "114" });

            migrationBuilder.DeleteData(
                table: "ClassRooms",
                keyColumns: new[] { "Address", "RoomNumber" },
                keyValues: new object[] { "546 Δοξαράς Wells, West Φώτιοςmouth, Saint Lucia", "70" });

            migrationBuilder.DeleteData(
                table: "ClassRooms",
                keyColumns: new[] { "Address", "RoomNumber" },
                keyValues: new object[] { "591 Βασιλόπουλος Hollow, East Αλέξανδροςborough, Grenada", "174" });

            migrationBuilder.DeleteData(
                table: "ClassRooms",
                keyColumns: new[] { "Address", "RoomNumber" },
                keyValues: new object[] { "60625 Νικόλαος Terrace, Ηλίαςton, Namibia", "134" });

            migrationBuilder.DeleteData(
                table: "ClassRooms",
                keyColumns: new[] { "Address", "RoomNumber" },
                keyValues: new object[] { "6356 Δάβης Club, Lake Αναστάσιοςstad, Central African Republic", "122" });

            migrationBuilder.DeleteData(
                table: "ClassRooms",
                keyColumns: new[] { "Address", "RoomNumber" },
                keyValues: new object[] { "6528 Παπάγος Terrace, New Κώστας, French Polynesia", "187" });

            migrationBuilder.DeleteData(
                table: "ClassRooms",
                keyColumns: new[] { "Address", "RoomNumber" },
                keyValues: new object[] { "670 Παπανδρέου Ferry, Ιωάννηςview, Cocos (Keeling) Islands", "311" });

            migrationBuilder.DeleteData(
                table: "ClassRooms",
                keyColumns: new[] { "Address", "RoomNumber" },
                keyValues: new object[] { "6859 Ανδρέας Stravenue, Σπύροςmouth, Jordan", "44" });

            migrationBuilder.DeleteData(
                table: "ClassRooms",
                keyColumns: new[] { "Address", "RoomNumber" },
                keyValues: new object[] { "702 Σπύρος View, New Θεόδωρος, Pitcairn Islands", "281" });

            migrationBuilder.DeleteData(
                table: "ClassRooms",
                keyColumns: new[] { "Address", "RoomNumber" },
                keyValues: new object[] { "74404 Γεννάδιος Forest, East Λεωνίδαςmouth, Hungary", "71" });

            migrationBuilder.DeleteData(
                table: "ClassRooms",
                keyColumns: new[] { "Address", "RoomNumber" },
                keyValues: new object[] { "7487 Στυλιανός Locks, Χαράλαμποςfort, Qatar", "322" });

            migrationBuilder.DeleteData(
                table: "ClassRooms",
                keyColumns: new[] { "Address", "RoomNumber" },
                keyValues: new object[] { "75820 Γρηγόριος Forks, West Ευάγγελοςport, Burundi", "205" });

            migrationBuilder.DeleteData(
                table: "ClassRooms",
                keyColumns: new[] { "Address", "RoomNumber" },
                keyValues: new object[] { "7655 Βασιλειάδης Freeway, Θεόδωροςfurt, Portugal", "277" });

            migrationBuilder.DeleteData(
                table: "ClassRooms",
                keyColumns: new[] { "Address", "RoomNumber" },
                keyValues: new object[] { "771 Παπάζογλου Ramp, Αλαβάνοςbury, United States Minor Outlying Islands", "335" });

            migrationBuilder.DeleteData(
                table: "ClassRooms",
                keyColumns: new[] { "Address", "RoomNumber" },
                keyValues: new object[] { "78513 Λαγός Locks, West Άγγελοςfort, Israel", "332" });

            migrationBuilder.DeleteData(
                table: "ClassRooms",
                keyColumns: new[] { "Address", "RoomNumber" },
                keyValues: new object[] { "798 Παπαγεωργίου Mountains, New Νικόλαοςport, Mayotte", "231" });

            migrationBuilder.DeleteData(
                table: "ClassRooms",
                keyColumns: new[] { "Address", "RoomNumber" },
                keyValues: new object[] { "80115 Μπουκουβαλαίοι Streets, West Παναγιώτηςchester, Western Sahara", "254" });

            migrationBuilder.DeleteData(
                table: "ClassRooms",
                keyColumns: new[] { "Address", "RoomNumber" },
                keyValues: new object[] { "8208 Παρασκευάς Club, Αναστάσιοςstad, Jamaica", "84" });

            migrationBuilder.DeleteData(
                table: "ClassRooms",
                keyColumns: new[] { "Address", "RoomNumber" },
                keyValues: new object[] { "82709 Βασίλης Meadow, North Κώσταςborough, Guadeloupe", "96" });

            migrationBuilder.DeleteData(
                table: "ClassRooms",
                keyColumns: new[] { "Address", "RoomNumber" },
                keyValues: new object[] { "82749 Αυγερινός (επώνυμο) Camp, Κυπραίοςside, Andorra", "335" });

            migrationBuilder.DeleteData(
                table: "ClassRooms",
                keyColumns: new[] { "Address", "RoomNumber" },
                keyValues: new object[] { "829 Χρήστος Centers, Lake Ευστάθιος, Somalia", "164" });

            migrationBuilder.DeleteData(
                table: "ClassRooms",
                keyColumns: new[] { "Address", "RoomNumber" },
                keyValues: new object[] { "845 Δάβης Hill, Παπανικολάουland, Madagascar", "132" });

            migrationBuilder.DeleteData(
                table: "ClassRooms",
                keyColumns: new[] { "Address", "RoomNumber" },
                keyValues: new object[] { "8545 Λεωνίδας Points, Γαλάνηςmouth, Marshall Islands", "255" });

            migrationBuilder.DeleteData(
                table: "ClassRooms",
                keyColumns: new[] { "Address", "RoomNumber" },
                keyValues: new object[] { "8582 Εμμανουήλ Highway, New Ευστάθιοςport, Jersey", "320" });

            migrationBuilder.DeleteData(
                table: "ClassRooms",
                keyColumns: new[] { "Address", "RoomNumber" },
                keyValues: new object[] { "8765 Βασιλόπουλος Loop, New Αθανάσιοςshire, Syrian Arab Republic", "219" });

            migrationBuilder.DeleteData(
                table: "ClassRooms",
                keyColumns: new[] { "Address", "RoomNumber" },
                keyValues: new object[] { "879 Παναγιώτης Glen, South Εμμανουήλ, Switzerland", "206" });

            migrationBuilder.DeleteData(
                table: "ClassRooms",
                keyColumns: new[] { "Address", "RoomNumber" },
                keyValues: new object[] { "8809 Θεόδωρος Skyway, Port Αριστείδηςton, Singapore", "190" });

            migrationBuilder.DeleteData(
                table: "ClassRooms",
                keyColumns: new[] { "Address", "RoomNumber" },
                keyValues: new object[] { "8881 Παπακώστας Burgs, New Αριστείδης, Cuba", "93" });

            migrationBuilder.DeleteData(
                table: "ClassRooms",
                keyColumns: new[] { "Address", "RoomNumber" },
                keyValues: new object[] { "895 Ζωγράφος Shores, Βυζάντιοςville, China", "54" });

            migrationBuilder.DeleteData(
                table: "ClassRooms",
                keyColumns: new[] { "Address", "RoomNumber" },
                keyValues: new object[] { "896 Αναστάσιος Meadows, Γεώργιοςstad, Swaziland", "46" });

            migrationBuilder.DeleteData(
                table: "ClassRooms",
                keyColumns: new[] { "Address", "RoomNumber" },
                keyValues: new object[] { "89826 Θεόδωρος View, Lake Ευάγγελος, Pitcairn Islands", "235" });

            migrationBuilder.DeleteData(
                table: "ClassRooms",
                keyColumns: new[] { "Address", "RoomNumber" },
                keyValues: new object[] { "908 Μιχαηλίδης Islands, Αλέξανδροςstad, Haiti", "280" });

            migrationBuilder.DeleteData(
                table: "ClassRooms",
                keyColumns: new[] { "Address", "RoomNumber" },
                keyValues: new object[] { "9187 Λεωνίδας Center, New Αντώνης, Bahamas", "25" });

            migrationBuilder.DeleteData(
                table: "ClassRooms",
                keyColumns: new[] { "Address", "RoomNumber" },
                keyValues: new object[] { "92323 Νικόλαος Trafficway, South Παναγιώτηςfort, Virgin Islands, British", "346" });

            migrationBuilder.DeleteData(
                table: "ClassRooms",
                keyColumns: new[] { "Address", "RoomNumber" },
                keyValues: new object[] { "94874 Νικόλαος Ramp, Μακρήςhaven, Costa Rica", "190" });

            migrationBuilder.DeleteData(
                table: "ClassRooms",
                keyColumns: new[] { "Address", "RoomNumber" },
                keyValues: new object[] { "9571 Λούλης Light, Παππάςborough, Northern Mariana Islands", "206" });

            migrationBuilder.DeleteData(
                table: "ClassRooms",
                keyColumns: new[] { "Address", "RoomNumber" },
                keyValues: new object[] { "98003 Μαλαξός Springs, New Αλέξανδρος, Honduras", "246" });

            migrationBuilder.DeleteData(
                table: "DegreeParticipations",
                keyColumns: new[] { "DegreeName", "Username" },
                keyValues: new object[] { "Movies & Toys (286)", "Anastasios.Liapis89" });

            migrationBuilder.DeleteData(
                table: "DegreeParticipations",
                keyColumns: new[] { "DegreeName", "Username" },
                keyValues: new object[] { "Movies & Toys (286)", "Andreas65" });

            migrationBuilder.DeleteData(
                table: "DegreeParticipations",
                keyColumns: new[] { "DegreeName", "Username" },
                keyValues: new object[] { "Toys (267)", "Apostolos_Mitsotakis" });

            migrationBuilder.DeleteData(
                table: "DegreeParticipations",
                keyColumns: new[] { "DegreeName", "Username" },
                keyValues: new object[] { "Garden (271)", "Basilis.Athanasioy" });

            migrationBuilder.DeleteData(
                table: "DegreeParticipations",
                keyColumns: new[] { "DegreeName", "Username" },
                keyValues: new object[] { "Music, Movies & Industrial (280)", "Dimitris93" });

            migrationBuilder.DeleteData(
                table: "DegreeParticipations",
                keyColumns: new[] { "DegreeName", "Username" },
                keyValues: new object[] { "Sports (274)", "Eleytherios16" });

            migrationBuilder.DeleteData(
                table: "DegreeParticipations",
                keyColumns: new[] { "DegreeName", "Username" },
                keyValues: new object[] { "Jewelery, Automotive & Garden (276)", "Eyaggelos_Galanis52" });

            migrationBuilder.DeleteData(
                table: "DegreeParticipations",
                keyColumns: new[] { "DegreeName", "Username" },
                keyValues: new object[] { "Computers, Toys & Beauty (278)", "Panagiotis29" });

            migrationBuilder.DeleteData(
                table: "DegreeParticipations",
                keyColumns: new[] { "DegreeName", "Username" },
                keyValues: new object[] { "Jewelery, Automotive & Garden (276)", "Spyros17" });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "UserType", "Username" },
                keyValues: new object[] { 0, "Apostolos_Mitsotakis" });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "UserType", "Username" },
                keyValues: new object[] { 0, "Basilis.Athanasioy" });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "UserType", "Username" },
                keyValues: new object[] { 0, "Dimitris93" });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "UserType", "Username" },
                keyValues: new object[] { 0, "Spyros17" });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "UserType", "Username" },
                keyValues: new object[] { 1, "Anastasios.Liapis89" });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "UserType", "Username" },
                keyValues: new object[] { 1, "Andreas65" });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "UserType", "Username" },
                keyValues: new object[] { 1, "Apostolos_Mitsotakis" });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "UserType", "Username" },
                keyValues: new object[] { 1, "Basilis.Athanasioy" });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "UserType", "Username" },
                keyValues: new object[] { 1, "Dimitris93" });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "UserType", "Username" },
                keyValues: new object[] { 1, "Eleytherios16" });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "UserType", "Username" },
                keyValues: new object[] { 1, "Eyaggelos_Galanis52" });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "UserType", "Username" },
                keyValues: new object[] { 1, "Panagiotis29" });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "UserType", "Username" },
                keyValues: new object[] { 1, "Spyros17" });

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Username",
                keyValue: "Anastasios.Liapis89");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Username",
                keyValue: "Andreas65");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Username",
                keyValue: "Apostolos_Mitsotakis");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Username",
                keyValue: "Basilis.Athanasioy");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Username",
                keyValue: "Dimitris93");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Username",
                keyValue: "Eleytherios16");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Username",
                keyValue: "Eyaggelos_Galanis52");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Username",
                keyValue: "Panagiotis29");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Username",
                keyValue: "Spyros17");

            migrationBuilder.UpdateData(
                table: "ClassRooms",
                keyColumns: new[] { "Address", "RoomNumber" },
                keyValues: new object[] { "2857 Παύλος Mall, West Ελευθέριοςhaven, Armenia", "141" },
                column: "RoomType",
                value: 0);

            migrationBuilder.UpdateData(
                table: "ClassRooms",
                keyColumns: new[] { "Address", "RoomNumber" },
                keyValues: new object[] { "299 Άγγελος Crescent, Βασιλικόςtown, Suriname", "177" },
                column: "RoomType",
                value: 0);

            migrationBuilder.UpdateData(
                table: "ClassRooms",
                keyColumns: new[] { "Address", "RoomNumber" },
                keyValues: new object[] { "333 Μήτζου Run, Lake Αθανάσιος, Sierra Leone", "166" },
                column: "RoomType",
                value: 0);

            migrationBuilder.UpdateData(
                table: "ClassRooms",
                keyColumns: new[] { "Address", "RoomNumber" },
                keyValues: new object[] { "48878 Αλεξάνδρου Mountain, East Ιωάννηςland, Malaysia", "73" },
                column: "RoomType",
                value: 0);

            migrationBuilder.UpdateData(
                table: "ClassRooms",
                keyColumns: new[] { "Address", "RoomNumber" },
                keyValues: new object[] { "868 Βικελίδης Underpass, North Παύλος, Japan", "243" },
                column: "RoomType",
                value: 0);

            migrationBuilder.UpdateData(
                table: "ClassRooms",
                keyColumns: new[] { "Address", "RoomNumber" },
                keyValues: new object[] { "89875 Ευάγγελος Fields, New Νικόλαος, Niger", "49" },
                column: "RoomType",
                value: 0);

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
                    { "28710 Διαμαντόπουλος Ramp, Κοντολέωνberg, Jordan", "223", 0 },
                    { "2879 Δραγούμης Dale, South Εμμανουήλ, Switzerland", "206", 0 },
                    { "308 Μπουκουβαλαίοι Mews, New Άγγελος, Kyrgyz Republic", "105", 0 },
                    { "314 Μιχαήλ Center, Βέργαςmouth, Armenia", "329", 0 },
                    { "31688 Αλέξανδρος Loop, East Παναγιώτης, Guadeloupe", "136", 0 },
                    { "32635 Αλιβιζάτος Meadows, Lake Ευστάθιοςbury, Mongolia", "184", 0 },
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
                    { "882 Άγγελος Turnpike, North Φώτιοςmouth, Luxembourg", "268", 0 },
                    { "882 Ζέρβας Stream, Ευστάθιοςborough, Pitcairn Islands", "55", 0 },
                    { "8821 Παρασκευάς Land, Ανδρέαςville, Sri Lanka", "45", 0 },
                    { "88467 Γαλάνης Street, South Ελευθέριοςmouth, Bouvet Island (Bouvetoya)", "268", 0 },
                    { "88490 Ιωάννης Highway, Ευστάθιοςchester, Tanzania", "138", 0 },
                    { "8990 Εμμανουήλ Crossroad, New Βασίληςburgh, South Georgia and the South Sandwich Islands", "40", 0 },
                    { "9093 Παπακωνσταντίνου Road, Γούσιοςstad, Nepal", "166", 0 },
                    { "91858 Αγγελοπούλου Throughway, Lake Κώστας, Cote d'Ivoire", "35", 0 },
                    { "94768 Σταύρος Flats, South Ηλίας, New Zealand", "329", 0 },
                    { "9915 Διδασκάλου Neck, South Στέφανος, Serbia", "190", 0 },
                    { "99241 Αλαβάνος Land, Άγγελοςmouth, Dominica", "250", 0 }
                });

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
                keyValues: new object[] { "Baby (279)", "Aleksandros41" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateOnly(2012, 2, 14), new DateOnly(2009, 2, 14) });

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
                keyValues: new object[] { "Industrial, Toys & Automotive (250)", "Antonis_Karamanlis" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateOnly(2018, 2, 10), new DateOnly(2015, 2, 10) });

            migrationBuilder.UpdateData(
                table: "DegreeParticipations",
                keyColumns: new[] { "DegreeName", "Username" },
                keyValues: new object[] { "Clothing, Electronics & Jewelery (253)", "Antonis_Melioi26" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateOnly(2009, 8, 25), new DateOnly(2006, 8, 25) });

            migrationBuilder.UpdateData(
                table: "DegreeParticipations",
                keyColumns: new[] { "DegreeName", "Username" },
                keyValues: new object[] { "Garden (260)", "Apostolos.Kypraios" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateOnly(2013, 7, 24), new DateOnly(2010, 7, 24) });

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
                keyValues: new object[] { "Baby (283)", "Aristeidis.Aleksandroy12" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateOnly(2022, 1, 15), new DateOnly(2019, 1, 15) });

            migrationBuilder.UpdateData(
                table: "DegreeParticipations",
                keyColumns: new[] { "DegreeName", "Username" },
                keyValues: new object[] { "Sports, Computers & Electronics (277)", "Aristeidis.Papanikolaoy" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateOnly(2016, 8, 25), new DateOnly(2013, 8, 25) });

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
                keyValues: new object[] { "Sports, Kids & Industrial (291)", "Basilis61" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateOnly(2015, 7, 30), new DateOnly(2012, 7, 30) });

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
                keyValues: new object[] { "Shoes & Kids (281)", "Dionysios.Anagnostakis" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateOnly(2012, 3, 5), new DateOnly(2009, 3, 5) });

            migrationBuilder.UpdateData(
                table: "DegreeParticipations",
                keyColumns: new[] { "DegreeName", "Username" },
                keyValues: new object[] { "Garden (262)", "Dionysios.Lytras" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateOnly(2009, 12, 10), new DateOnly(2006, 12, 10) });

            migrationBuilder.UpdateData(
                table: "DegreeParticipations",
                keyColumns: new[] { "DegreeName", "Username" },
                keyValues: new object[] { "Books (290)", "Dionysios_Deli12" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateOnly(2013, 2, 8), new DateOnly(2010, 2, 8) });

            migrationBuilder.UpdateData(
                table: "DegreeParticipations",
                keyColumns: new[] { "DegreeName", "Username" },
                keyValues: new object[] { "Electronics (266)", "Eleytherios.Eleytherioy" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateOnly(2017, 2, 27), new DateOnly(2014, 2, 27) });

            migrationBuilder.UpdateData(
                table: "DegreeParticipations",
                keyColumns: new[] { "DegreeName", "Username" },
                keyValues: new object[] { "Kids & Tools (265)", "Emmanoyil.Georgiadis" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateOnly(2023, 4, 24), new DateOnly(2020, 4, 24) });

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
                keyValues: new object[] { "Baby (279)", "Emmanoyil_Maris67" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateOnly(2020, 7, 30), new DateOnly(2017, 7, 30) });

            migrationBuilder.UpdateData(
                table: "DegreeParticipations",
                keyColumns: new[] { "DegreeName", "Username" },
                keyValues: new object[] { "Beauty (269)", "Eyaggelos_Koromilas73" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateOnly(2023, 12, 9), new DateOnly(2020, 12, 9) });

            migrationBuilder.UpdateData(
                table: "DegreeParticipations",
                keyColumns: new[] { "DegreeName", "Username" },
                keyValues: new object[] { "Books, Garden & Garden (275)", "Eystathios17" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateOnly(2018, 11, 23), new DateOnly(2015, 11, 23) });

            migrationBuilder.UpdateData(
                table: "DegreeParticipations",
                keyColumns: new[] { "DegreeName", "Username" },
                keyValues: new object[] { "Computers & Health (285)", "Eystathios29" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateOnly(2025, 6, 30), new DateOnly(2022, 6, 30) });

            migrationBuilder.UpdateData(
                table: "DegreeParticipations",
                keyColumns: new[] { "DegreeName", "Username" },
                keyValues: new object[] { "Shoes & Kids (281)", "Eystathios57" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateOnly(2011, 10, 30), new DateOnly(2008, 10, 30) });

            migrationBuilder.UpdateData(
                table: "DegreeParticipations",
                keyColumns: new[] { "DegreeName", "Username" },
                keyValues: new object[] { "Games & Toys (297)", "Eystathios_Avramidis41" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateOnly(2026, 2, 20), new DateOnly(2023, 2, 20) });

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
                keyValues: new object[] { "Jewelery, Automotive & Garden (276)", "Kostas_Byzantios65" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateOnly(2022, 3, 17), new DateOnly(2019, 3, 17) });

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
                keyValues: new object[] { "Beauty & Electronics (299)", "Nikolaos_Boyrdoympas15" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateOnly(2021, 11, 10), new DateOnly(2018, 11, 10) });

            migrationBuilder.UpdateData(
                table: "DegreeParticipations",
                keyColumns: new[] { "DegreeName", "Username" },
                keyValues: new object[] { "Baby (283)", "Paraskeyas.Anagnostakis" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateOnly(2022, 11, 24), new DateOnly(2019, 11, 24) });

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
                keyValues: new object[] { "Automotive, Garden & Beauty (261)", "Petros77" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateOnly(2017, 9, 15), new DateOnly(2014, 9, 15) });

            migrationBuilder.UpdateData(
                table: "DegreeParticipations",
                keyColumns: new[] { "DegreeName", "Username" },
                keyValues: new object[] { "Shoes & Toys (268)", "Sotirios.Germanos87" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateOnly(2023, 1, 5), new DateOnly(2020, 1, 5) });

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
                keyValues: new object[] { "Baby (279)", "Spyros97" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateOnly(2011, 8, 14), new DateOnly(2008, 8, 14) });

            migrationBuilder.UpdateData(
                table: "DegreeParticipations",
                keyColumns: new[] { "DegreeName", "Username" },
                keyValues: new object[] { "Home, Movies & Shoes (272)", "Spyros_Anastasiadis" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateOnly(2014, 2, 12), new DateOnly(2011, 2, 12) });

            migrationBuilder.UpdateData(
                table: "DegreeParticipations",
                keyColumns: new[] { "DegreeName", "Username" },
                keyValues: new object[] { "Garden (262)", "Stayros.Koronaios" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateOnly(2013, 9, 26), new DateOnly(2010, 9, 26) });

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
                keyValues: new object[] { "Toys (295)", "Xristos.Aggelopoylos" },
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateOnly(2014, 1, 12), new DateOnly(2011, 1, 12) });

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
                columns: new[] { "BirthDate", "PasswordHash" },
                values: new object[] { new DateOnly(1991, 2, 14), "AQAAAAIAAYagAAAAEHhhMwEC7YqXXYwb3pBosfIf50cyRXEwBlpGMmKZFB7dmXQ0AetNqwpuIcW7Z9ZZog==" });

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
                columns: new[] { "BirthDate", "PasswordHash" },
                values: new object[] { new DateOnly(1997, 2, 10), "AQAAAAIAAYagAAAAELVH7rtdgF85Y/K1Xol3UsespVr9rME+HWZDBWRZE6/pj59+BIl7ATx8ZnV+yabojg==" });

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
                columns: new[] { "BirthDate", "PasswordHash" },
                values: new object[] { new DateOnly(1992, 7, 24), "AQAAAAIAAYagAAAAEHxY0juU0C1cFJI2QxXwo67ZRbQFO81GncWk55f3Qy3ndPtfmnIBryNOASpdIg/wOA==" });

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
                columns: new[] { "BirthDate", "PasswordHash" },
                values: new object[] { new DateOnly(2001, 1, 15), "AQAAAAIAAYagAAAAEOLNCljr5IZD5b1FS6mDJ4iFhsjHb9T3afJGcEUW/ExmIfQUXcp3jDXP3pTpH7BjBA==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Username",
                keyValue: "Aristeidis.Papanikolaoy",
                columns: new[] { "BirthDate", "PasswordHash" },
                values: new object[] { new DateOnly(1995, 8, 25), "AQAAAAIAAYagAAAAEPzbnKkipWtWY0veOxsobapWGtpxzr5GjMHD9UJomfvIMOCM+c5+Vk+uXT8Fq6DNbg==" });

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
                columns: new[] { "BirthDate", "PasswordHash" },
                values: new object[] { new DateOnly(1994, 7, 30), "AQAAAAIAAYagAAAAEHmxOwfFZ4LHGoa2L3ZWhNrbiGIrezefFzdPF67NhfIBJ551YHhYn+oWlhyMpATvQA==" });

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
                columns: new[] { "BirthDate", "PasswordHash" },
                values: new object[] { new DateOnly(1991, 3, 5), "AQAAAAIAAYagAAAAEAAw/jzNOyxwk5klfNsmur1Abo0wUjG3AdxbFgUABakvdWo41MWngZawfcry/BkmNw==" });

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
                columns: new[] { "BirthDate", "PasswordHash" },
                values: new object[] { new DateOnly(1992, 2, 8), "AQAAAAIAAYagAAAAEMmc2XCsG6HT0ebdWhup4CjOvdu05DT3+9/F8XoUxfDc7mEzmlVOW0R1tRslB8le1g==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Username",
                keyValue: "Eleytherios.Eleytherioy",
                columns: new[] { "BirthDate", "PasswordHash" },
                values: new object[] { new DateOnly(1996, 2, 27), "AQAAAAIAAYagAAAAELWCxxQ+/0wkYpPJBAYp5svTKP1uFHIWlcnVEdTmeUKPOHc2NZ7x6LsL2KoQ5GgMeg==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Username",
                keyValue: "Emmanoyil.Georgiadis",
                columns: new[] { "BirthDate", "PasswordHash" },
                values: new object[] { new DateOnly(2002, 4, 24), "AQAAAAIAAYagAAAAEP9dbHyDwRADGe/xtMdDtQvF3hHCCNI++mdxRGu8a1RRbH0CeR/GsafanrUXEHcHeQ==" });

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
                columns: new[] { "BirthDate", "PasswordHash" },
                values: new object[] { new DateOnly(1999, 7, 30), "AQAAAAIAAYagAAAAEIPVodv1TBfI0xD9fPfzvhRb4rhps4ivS3frOTrtppqMBE4Wi+g/1XVAP2jGN/ILUw==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Username",
                keyValue: "Eyaggelos_Koromilas73",
                columns: new[] { "BirthDate", "PasswordHash" },
                values: new object[] { new DateOnly(2002, 12, 9), "AQAAAAIAAYagAAAAEKtTgPe7t6mIBSBAxRsSNa6ARwuJCBI5zN/cmS6ZnWokw4pwM1SNos65vtniXOmWWg==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Username",
                keyValue: "Eystathios17",
                columns: new[] { "BirthDate", "PasswordHash" },
                values: new object[] { new DateOnly(1997, 11, 23), "AQAAAAIAAYagAAAAELpnTws4ynONC2BxTopmWTvZDEq6mTkb2kr+zOxgR7e3HWXWv9qMOT/o01uj2El4HQ==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Username",
                keyValue: "Eystathios29",
                columns: new[] { "BirthDate", "PasswordHash" },
                values: new object[] { new DateOnly(2004, 6, 30), "AQAAAAIAAYagAAAAEDZrBx0x35hjl0T+m54CoGTPm6jTfAOXJoR/QFxreNZOjKBkgsCqQv2CK8JIMHsD5w==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Username",
                keyValue: "Eystathios57",
                columns: new[] { "BirthDate", "PasswordHash" },
                values: new object[] { new DateOnly(1990, 10, 30), "AQAAAAIAAYagAAAAEPnCWElLqui6g9PHYEqRSc8Ryf3MheamMhJrM5113TAV1LQSCj48H+o6HP2v/iDUXA==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Username",
                keyValue: "Eystathios_Avramidis41",
                columns: new[] { "BirthDate", "PasswordHash" },
                values: new object[] { new DateOnly(2005, 2, 20), "AQAAAAIAAYagAAAAEGKTgMtwkzcqgK/ZqGglSV8iDSoBa1IX0mUVorC8I3HIm9m+wOiYlW28nAk5jZHCYw==" });

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
                columns: new[] { "BirthDate", "PasswordHash" },
                values: new object[] { new DateOnly(2001, 3, 17), "AQAAAAIAAYagAAAAEEk5HEW2AdNbFc40WmC9hyVgQE9IC+GYD6NCytp2JkJaxCAEYp/QQchK/yP7zQ4MPA==" });

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
                columns: new[] { "BirthDate", "PasswordHash" },
                values: new object[] { new DateOnly(2000, 11, 10), "AQAAAAIAAYagAAAAEKW1a1MX0Dg/D0pVvG6qlZ0meYT5X3QKkNRp8dbz3hGEAEX9YWEtj6TZ5vbXuuisBg==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Username",
                keyValue: "Paraskeyas.Anagnostakis",
                columns: new[] { "BirthDate", "PasswordHash" },
                values: new object[] { new DateOnly(2001, 11, 24), "AQAAAAIAAYagAAAAEA5rFCOXYAdKjK70JddQ8yq6G9UIWZ6h390IRjs3VroJSH+FA/rciNDY5TQbeOKaJA==" });

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
                keyValue: "Petros77",
                columns: new[] { "BirthDate", "PasswordHash" },
                values: new object[] { new DateOnly(1996, 9, 15), "AQAAAAIAAYagAAAAEMmTTTnWT1pPt77CKw4c6NaSPY4KFl9aMwPDUMwdrb5TMqUiwNHfusiAyd+mHYF2fw==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Username",
                keyValue: "Sotirios.Germanos87",
                columns: new[] { "BirthDate", "PasswordHash" },
                values: new object[] { new DateOnly(2002, 1, 5), "AQAAAAIAAYagAAAAEIZkA1P0gMeU1VLlDJciCpLHdLPMphjF36R5sQ/Ifq88cpR1+u9BmGUfvMpfUnj1BA==" });

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
                columns: new[] { "BirthDate", "PasswordHash" },
                values: new object[] { new DateOnly(1990, 8, 14), "AQAAAAIAAYagAAAAEDCbYibbbQ4eRu0LxBxIQqs4ZGP3cqv93Xc1AWCMHBF8KgWcATIKOcgNKuXznL3mDQ==" });

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
                columns: new[] { "BirthDate", "PasswordHash" },
                values: new object[] { new DateOnly(1992, 9, 26), "AQAAAAIAAYagAAAAELIUMq/0Tcd7scfqGNreKCR5QBPDWt6UORpBCMngswieKU+g0IPNwhL+ZAzxJY0zzw==" });

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
                columns: new[] { "BirthDate", "PasswordHash" },
                values: new object[] { new DateOnly(1993, 1, 12), "AQAAAAIAAYagAAAAEDIDMESbMj8HXuomJVgaeKV5mN678XixHRrQCmM2XSqKcUwxNMEZtvtmrJH0tq4bVA==" });

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

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Username", "BirthDate", "BirthLocation", "Name", "PasswordHash" },
                values: new object[,]
                {
                    { "Anastasios_Bilaetis84", new DateOnly(1988, 12, 9), "East Απόστολος", "Χαράλαμπος Μεσσηνέζης", "AQAAAAIAAYagAAAAEL/8B6SiXaWl7lB/2YKKiIbrAQTkf7LClxyEwOJmYiu9o8HECYnV2PKyuo6GNlHQqQ==" },
                    { "Andreas95", new DateOnly(2000, 4, 14), "Βαρνακιώτηςview", "Μιχαήλ Αναγνωστάκης", "AQAAAAIAAYagAAAAEC3xJWckJYVOrGlX+pA2JlsWg6CYO8qyjQzoy1G78PGxFSFQXZ4v1eLTGFKlalfBUg==" },
                    { "Eleytherios_Didaskaloy", new DateOnly(2004, 7, 24), "Στυλιανόςhaven", "Γρηγόριος Καραμανλής", "AQAAAAIAAYagAAAAEIXk2HT7biCzgTb70jnMok1pCRPYASxzDsudKj6Csv0yteE3IjP06o424YAR1feIJQ==" },
                    { "Eystathios.Boyrdoympas", new DateOnly(2000, 5, 31), "South Χρήστος", "Γρηγόριος Καρράς", "AQAAAAIAAYagAAAAEJ/K+QyjwnBkvTgMhRA5XXg55wDTrlq4gGHquu4jX+YICl5lNYCwYS48wCJudnJc6A==" },
                    { "Fotios.Andreoy51", new DateOnly(2004, 2, 10), "North Μιχαήλville", "Διονύσιος Αλεβιζόπουλος", "AQAAAAIAAYagAAAAEAzCTiX21jWLHgt1QaNljJz7weFMM78OjGOIEoKLZkYFD9gMKJc2ohE8wEI797LS5g==" },
                    { "Ilias56", new DateOnly(1987, 6, 18), "East Απόστολοςchester", "Παύλος Ελευθερόπουλος", "AQAAAAIAAYagAAAAEHlaqWEbpw50NywEsclRqedbKaWwBbBUmQR6mUurFs/kvbp6gbaGczreIOVdHNCjQQ==" },
                    { "Paraskeyas_THeodoridis89", new DateOnly(2003, 4, 26), "Σταύροςfurt", "Γεώργιος Κομνηνός", "AQAAAAIAAYagAAAAENDxgHO+IbPwQmZJKdoovnWAFJ3iMFfhBvZdsd4d3YdWUIQZ62dZouHe/7QRLirfGA==" },
                    { "Paylos18", new DateOnly(1996, 8, 10), "South Βασίληςchester", "Νικόλαος Βενιζέλος", "AQAAAAIAAYagAAAAEMRpU8lPoJ+piZZVTQ6eju1LLikeggZtv5Yk/i82JN6QP6SDlOqvzUZ4ZLaU3QFvbg==" },
                    { "Petros50", new DateOnly(1992, 11, 21), "Ευστάθιοςton", "Απόστολος Μαυρογένης", "AQAAAAIAAYagAAAAEIiSsSO/ki2p7nbuBkUkxXrfXwAUs69CpBlynoAPdPybEhPtEL/9/gbioTEkrzvQgg==" }
                });

            migrationBuilder.InsertData(
                table: "DegreeParticipations",
                columns: new[] { "DegreeName", "Username", "EndDate", "StartDate" },
                values: new object[,]
                {
                    { "Baby (283)", "Anastasios_Bilaetis84", new DateOnly(2009, 12, 9), new DateOnly(2006, 12, 9) },
                    { "Sports, Computers & Electronics (277)", "Andreas95", new DateOnly(2021, 4, 14), new DateOnly(2018, 4, 14) },
                    { "Beauty (269)", "Eleytherios_Didaskaloy", new DateOnly(2025, 7, 24), new DateOnly(2022, 7, 24) },
                    { "Toys (267)", "Eystathios.Boyrdoympas", new DateOnly(2021, 5, 31), new DateOnly(2018, 5, 31) },
                    { "Home (264)", "Fotios.Andreoy51", new DateOnly(2025, 2, 10), new DateOnly(2022, 2, 10) },
                    { "Baby (279)", "Ilias56", new DateOnly(2008, 6, 18), new DateOnly(2005, 6, 18) },
                    { "Books (257)", "Paraskeyas_THeodoridis89", new DateOnly(2024, 4, 26), new DateOnly(2021, 4, 26) },
                    { "Tools, Tools & Tools (284)", "Paylos18", new DateOnly(2017, 8, 10), new DateOnly(2014, 8, 10) },
                    { "Sports (274)", "Petros50", new DateOnly(2013, 11, 21), new DateOnly(2010, 11, 21) }
                });

            migrationBuilder.InsertData(
                table: "UserRoles",
                columns: new[] { "UserType", "Username" },
                values: new object[,]
                {
                    { 0, "Andreas95" },
                    { 0, "Eleytherios_Didaskaloy" },
                    { 0, "Ilias56" },
                    { 0, "Paraskeyas_THeodoridis89" },
                    { 0, "Paylos18" },
                    { 0, "Petros50" },
                    { 1, "Anastasios_Bilaetis84" },
                    { 1, "Andreas95" },
                    { 1, "Eystathios.Boyrdoympas" },
                    { 1, "Fotios.Andreoy51" },
                    { 1, "Ilias56" },
                    { 1, "Paraskeyas_THeodoridis89" },
                    { 1, "Paylos18" },
                    { 1, "Petros50" }
                });
        }
    }
}