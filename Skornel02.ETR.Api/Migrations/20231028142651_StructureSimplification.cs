using System;

using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Skornel02.ETR.Api.Migrations
{
    /// <inheritdoc />
    public partial class StructureSimplification : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CourseLocations");

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
                keyValues: new object[] { "2857 Παύλος Mall, West Ελευθέριοςhaven, Armenia", "141" });

            migrationBuilder.DeleteData(
                table: "ClassRooms",
                keyColumns: new[] { "Address", "RoomNumber" },
                keyValues: new object[] { "299 Άγγελος Crescent, Βασιλικόςtown, Suriname", "177" });

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
                keyValues: new object[] { "333 Μήτζου Run, Lake Αθανάσιος, Sierra Leone", "166" });

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
                keyValues: new object[] { "48878 Αλεξάνδρου Mountain, East Ιωάννηςland, Malaysia", "73" });

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
                keyValues: new object[] { "868 Βικελίδης Underpass, North Παύλος, Japan", "243" });

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
                keyValues: new object[] { "89875 Ευάγγελος Fields, New Νικόλαος, Niger", "49" });

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
                keyValues: new object[] { "Movies & Toys (286)", "Anastasios.Liapis89" });

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
                keyValues: new object[] { "Movies & Toys (286)", "Andreas65" });

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
                keyValues: new object[] { "Toys (267)", "Apostolos_Mitsotakis" });

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
                keyValues: new object[] { "Garden (271)", "Basilis.Athanasioy" });

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
                keyValues: new object[] { "Music, Movies & Industrial (280)", "Dimitris93" });

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
                keyValues: new object[] { "Sports (274)", "Eleytherios16" });

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
                keyValues: new object[] { "Jewelery, Automotive & Garden (276)", "Eyaggelos_Galanis52" });

            migrationBuilder.DeleteData(
                table: "DegreeParticipations",
                keyColumns: new[] { "DegreeName", "Username" },
                keyValues: new object[] { "Beauty (269)", "Eyaggelos_Koromilas73" });

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
                keyValues: new object[] { "Computers, Toys & Beauty (278)", "Panagiotis29" });

            migrationBuilder.DeleteData(
                table: "DegreeParticipations",
                keyColumns: new[] { "DegreeName", "Username" },
                keyValues: new object[] { "Baby (283)", "Paraskeyas.Anagnostakis" });

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
                keyValues: new object[] { "Jewelery, Automotive & Garden (276)", "Spyros17" });

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
                table: "UserRoles",
                keyColumns: new[] { "UserType", "Username" },
                keyValues: new object[] { 0, "Aggelos.Aggelidoy35" });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "UserType", "Username" },
                keyValues: new object[] { 0, "Aggelos6" });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "UserType", "Username" },
                keyValues: new object[] { 0, "Aggelos87" });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "UserType", "Username" },
                keyValues: new object[] { 0, "Aggelos_Georgiadis30" });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "UserType", "Username" },
                keyValues: new object[] { 0, "Aleksandros41" });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "UserType", "Username" },
                keyValues: new object[] { 0, "Anastasios_Nikolakos52" });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "UserType", "Username" },
                keyValues: new object[] { 0, "Andreas22" });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "UserType", "Username" },
                keyValues: new object[] { 0, "Andreas52" });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "UserType", "Username" },
                keyValues: new object[] { 0, "Andreas_Bikelidis33" });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "UserType", "Username" },
                keyValues: new object[] { 0, "Antonis_Antonopoylos" });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "UserType", "Username" },
                keyValues: new object[] { 0, "Antonis_Diamantopoylos43" });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "UserType", "Username" },
                keyValues: new object[] { 0, "Antonis_Melioi26" });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "UserType", "Username" },
                keyValues: new object[] { 0, "Apostolos.Kypraios" });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "UserType", "Username" },
                keyValues: new object[] { 0, "Apostolos44" });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "UserType", "Username" },
                keyValues: new object[] { 0, "Apostolos75" });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "UserType", "Username" },
                keyValues: new object[] { 0, "Apostolos_Daskalopoylos" });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "UserType", "Username" },
                keyValues: new object[] { 0, "Apostolos_Mitsotakis" });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "UserType", "Username" },
                keyValues: new object[] { 0, "Aristeidis.Papanikolaoy" });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "UserType", "Username" },
                keyValues: new object[] { 0, "Aristeidis_Melioi" });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "UserType", "Username" },
                keyValues: new object[] { 0, "Basilis.Athanasioy" });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "UserType", "Username" },
                keyValues: new object[] { 0, "Basilis.Koytalianos17" });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "UserType", "Username" },
                keyValues: new object[] { 0, "Basilis_Oikonomoy" });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "UserType", "Username" },
                keyValues: new object[] { 0, "Dimitris93" });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "UserType", "Username" },
                keyValues: new object[] { 0, "Dionysios.Anagnostakis" });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "UserType", "Username" },
                keyValues: new object[] { 0, "Dionysios.Lytras" });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "UserType", "Username" },
                keyValues: new object[] { 0, "Dionysios_Deli12" });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "UserType", "Username" },
                keyValues: new object[] { 0, "Emmanoyil.Georgiadis" });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "UserType", "Username" },
                keyValues: new object[] { 0, "Emmanoyil_Aleksioy5" });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "UserType", "Username" },
                keyValues: new object[] { 0, "Emmanoyil_Koyndoyros" });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "UserType", "Username" },
                keyValues: new object[] { 0, "Eyaggelos_Koromilas73" });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "UserType", "Username" },
                keyValues: new object[] { 0, "Eystathios17" });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "UserType", "Username" },
                keyValues: new object[] { 0, "Eystathios29" });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "UserType", "Username" },
                keyValues: new object[] { 0, "Eystathios57" });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "UserType", "Username" },
                keyValues: new object[] { 0, "Eystathios_Avramidis41" });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "UserType", "Username" },
                keyValues: new object[] { 0, "Fotios_Karavias7" });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "UserType", "Username" },
                keyValues: new object[] { 0, "Georgios2" });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "UserType", "Username" },
                keyValues: new object[] { 0, "Georgios79" });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "UserType", "Username" },
                keyValues: new object[] { 0, "Grigorios.Boylgaris" });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "UserType", "Username" },
                keyValues: new object[] { 0, "Grigorios_Kontoleon41" });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "UserType", "Username" },
                keyValues: new object[] { 0, "Ioannis.Aygerinoseponymo0" });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "UserType", "Username" },
                keyValues: new object[] { 0, "Ioannis.Zappas99" });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "UserType", "Username" },
                keyValues: new object[] { 0, "Ioannis28" });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "UserType", "Username" },
                keyValues: new object[] { 0, "Ioannis_Basilopoylos" });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "UserType", "Username" },
                keyValues: new object[] { 0, "Kostas92" });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "UserType", "Username" },
                keyValues: new object[] { 0, "Mixail.Bergas85" });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "UserType", "Username" },
                keyValues: new object[] { 0, "Mixail.Ioannoy" });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "UserType", "Username" },
                keyValues: new object[] { 0, "Mixail90" });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "UserType", "Username" },
                keyValues: new object[] { 0, "Nikolaos_Boyrdoympas15" });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "UserType", "Username" },
                keyValues: new object[] { 0, "Paraskeyas.Anagnostakis" });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "UserType", "Username" },
                keyValues: new object[] { 0, "Paylos.Giagkos" });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "UserType", "Username" },
                keyValues: new object[] { 0, "Paylos_Kalyvas76" });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "UserType", "Username" },
                keyValues: new object[] { 0, "Petros77" });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "UserType", "Username" },
                keyValues: new object[] { 0, "Sotirios.Germanos87" });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "UserType", "Username" },
                keyValues: new object[] { 0, "Sotirios.THeodosioy" });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "UserType", "Username" },
                keyValues: new object[] { 0, "Sotirios_Zervos" });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "UserType", "Username" },
                keyValues: new object[] { 0, "Spyros17" });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "UserType", "Username" },
                keyValues: new object[] { 0, "Spyros97" });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "UserType", "Username" },
                keyValues: new object[] { 0, "Spyros_Anastasiadis" });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "UserType", "Username" },
                keyValues: new object[] { 0, "Stayros.Koronaios" });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "UserType", "Username" },
                keyValues: new object[] { 0, "Stefanos.Loypis27" });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "UserType", "Username" },
                keyValues: new object[] { 0, "Stylianos.Mitzoy" });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "UserType", "Username" },
                keyValues: new object[] { 0, "THeodoros.Basileiadis2" });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "UserType", "Username" },
                keyValues: new object[] { 0, "THeodoros.Zafeiropoylos96" });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "UserType", "Username" },
                keyValues: new object[] { 0, "THeodoros68" });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "UserType", "Username" },
                keyValues: new object[] { 0, "Xaralampos43" });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "UserType", "Username" },
                keyValues: new object[] { 0, "Xaralampos74" });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "UserType", "Username" },
                keyValues: new object[] { 0, "Xristos.Aggelopoylos" });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "UserType", "Username" },
                keyValues: new object[] { 0, "Xristos80" });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "UserType", "Username" },
                keyValues: new object[] { 0, "Xristos85" });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "UserType", "Username" },
                keyValues: new object[] { 1, "Aggelos.Aggelidoy35" });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "UserType", "Username" },
                keyValues: new object[] { 1, "Aggelos87" });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "UserType", "Username" },
                keyValues: new object[] { 1, "Aggelos_Georgiadis30" });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "UserType", "Username" },
                keyValues: new object[] { 1, "Aleksandros.Zervos61" });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "UserType", "Username" },
                keyValues: new object[] { 1, "Aleksandros41" });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "UserType", "Username" },
                keyValues: new object[] { 1, "Anastasios.Liapis89" });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "UserType", "Username" },
                keyValues: new object[] { 1, "Anastasios_Nikolakos52" });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "UserType", "Username" },
                keyValues: new object[] { 1, "Andreas65" });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "UserType", "Username" },
                keyValues: new object[] { 1, "Andreas_Bikelidis33" });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "UserType", "Username" },
                keyValues: new object[] { 1, "Antonis.Lytras" });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "UserType", "Username" },
                keyValues: new object[] { 1, "Antonis4" });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "UserType", "Username" },
                keyValues: new object[] { 1, "Antonis_Karamanlis" });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "UserType", "Username" },
                keyValues: new object[] { 1, "Antonis_Melioi26" });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "UserType", "Username" },
                keyValues: new object[] { 1, "Apostolos_Daskalopoylos" });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "UserType", "Username" },
                keyValues: new object[] { 1, "Apostolos_Mitsotakis" });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "UserType", "Username" },
                keyValues: new object[] { 1, "Aristeidis.Aleksandroy12" });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "UserType", "Username" },
                keyValues: new object[] { 1, "Aristeidis.Papanikolaoy" });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "UserType", "Username" },
                keyValues: new object[] { 1, "Aristeidis_Melioi" });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "UserType", "Username" },
                keyValues: new object[] { 1, "Basilis.Athanasioy" });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "UserType", "Username" },
                keyValues: new object[] { 1, "Basilis.Koytalianos17" });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "UserType", "Username" },
                keyValues: new object[] { 1, "Basilis61" });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "UserType", "Username" },
                keyValues: new object[] { 1, "Basilis_Oikonomoy" });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "UserType", "Username" },
                keyValues: new object[] { 1, "Dimitris28" });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "UserType", "Username" },
                keyValues: new object[] { 1, "Dimitris93" });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "UserType", "Username" },
                keyValues: new object[] { 1, "Dionysios.Anagnostakis" });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "UserType", "Username" },
                keyValues: new object[] { 1, "Dionysios.Lytras" });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "UserType", "Username" },
                keyValues: new object[] { 1, "Dionysios_Deli12" });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "UserType", "Username" },
                keyValues: new object[] { 1, "Eleytherios.Eleytherioy" });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "UserType", "Username" },
                keyValues: new object[] { 1, "Eleytherios16" });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "UserType", "Username" },
                keyValues: new object[] { 1, "Emmanoyil_Aleksioy5" });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "UserType", "Username" },
                keyValues: new object[] { 1, "Emmanoyil_Koyndoyros" });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "UserType", "Username" },
                keyValues: new object[] { 1, "Emmanoyil_Maris67" });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "UserType", "Username" },
                keyValues: new object[] { 1, "Eyaggelos_Galanis52" });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "UserType", "Username" },
                keyValues: new object[] { 1, "Eyaggelos_Koromilas73" });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "UserType", "Username" },
                keyValues: new object[] { 1, "Eystathios17" });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "UserType", "Username" },
                keyValues: new object[] { 1, "Eystathios29" });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "UserType", "Username" },
                keyValues: new object[] { 1, "Eystathios57" });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "UserType", "Username" },
                keyValues: new object[] { 1, "Fotios90" });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "UserType", "Username" },
                keyValues: new object[] { 1, "Fotios_Karavias7" });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "UserType", "Username" },
                keyValues: new object[] { 1, "Georgios.Eytaksias" });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "UserType", "Username" },
                keyValues: new object[] { 1, "Georgios2" });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "UserType", "Username" },
                keyValues: new object[] { 1, "Georgios45" });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "UserType", "Username" },
                keyValues: new object[] { 1, "Georgios79" });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "UserType", "Username" },
                keyValues: new object[] { 1, "Georgios_Bilaetis20" });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "UserType", "Username" },
                keyValues: new object[] { 1, "Grigorios.Boylgaris" });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "UserType", "Username" },
                keyValues: new object[] { 1, "Ilias.Metaksas74" });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "UserType", "Username" },
                keyValues: new object[] { 1, "Ilias.Zafeiropoylos86" });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "UserType", "Username" },
                keyValues: new object[] { 1, "Ilias_Bamvas22" });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "UserType", "Username" },
                keyValues: new object[] { 1, "Ioannis.Aygerinoseponymo0" });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "UserType", "Username" },
                keyValues: new object[] { 1, "Ioannis28" });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "UserType", "Username" },
                keyValues: new object[] { 1, "Kostas43" });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "UserType", "Username" },
                keyValues: new object[] { 1, "Kostas92" });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "UserType", "Username" },
                keyValues: new object[] { 1, "Kostas_Byzantios65" });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "UserType", "Username" },
                keyValues: new object[] { 1, "Mixail.Bergas85" });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "UserType", "Username" },
                keyValues: new object[] { 1, "Mixail.Ioannoy" });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "UserType", "Username" },
                keyValues: new object[] { 1, "Mixail90" });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "UserType", "Username" },
                keyValues: new object[] { 1, "Panagiotis29" });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "UserType", "Username" },
                keyValues: new object[] { 1, "Paraskeyas.Anagnostakis" });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "UserType", "Username" },
                keyValues: new object[] { 1, "Paylos.Koyndoyros" });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "UserType", "Username" },
                keyValues: new object[] { 1, "Paylos48" });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "UserType", "Username" },
                keyValues: new object[] { 1, "Paylos_Kalyvas76" });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "UserType", "Username" },
                keyValues: new object[] { 1, "Petros.Blavianos51" });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "UserType", "Username" },
                keyValues: new object[] { 1, "Petros77" });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "UserType", "Username" },
                keyValues: new object[] { 1, "Sotirios.Kalogiannis43" });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "UserType", "Username" },
                keyValues: new object[] { 1, "Sotirios.THeodosioy" });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "UserType", "Username" },
                keyValues: new object[] { 1, "Sotirios_Zervos" });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "UserType", "Username" },
                keyValues: new object[] { 1, "Spyros17" });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "UserType", "Username" },
                keyValues: new object[] { 1, "Spyros97" });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "UserType", "Username" },
                keyValues: new object[] { 1, "Spyros_Anastasiadis" });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "UserType", "Username" },
                keyValues: new object[] { 1, "Stayros.Koronaios" });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "UserType", "Username" },
                keyValues: new object[] { 1, "Stayros_Bergas29" });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "UserType", "Username" },
                keyValues: new object[] { 1, "Stefanos.Loypis27" });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "UserType", "Username" },
                keyValues: new object[] { 1, "Stefanos.Nikolaidis21" });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "UserType", "Username" },
                keyValues: new object[] { 1, "Stylianos.Basileiadis" });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "UserType", "Username" },
                keyValues: new object[] { 1, "Stylianos.Mitzoy" });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "UserType", "Username" },
                keyValues: new object[] { 1, "THeodoros.Basileiadis2" });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "UserType", "Username" },
                keyValues: new object[] { 1, "THeodoros68" });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "UserType", "Username" },
                keyValues: new object[] { 1, "Xaralampos43" });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "UserType", "Username" },
                keyValues: new object[] { 1, "Xaralampos68" });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "UserType", "Username" },
                keyValues: new object[] { 1, "Xaralampos74" });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "UserType", "Username" },
                keyValues: new object[] { 1, "Xristos80" });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "UserType", "Username" },
                keyValues: new object[] { 1, "Xristos85" });

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
                keyValue: "Anastasios.Liapis89");

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
                keyValue: "Andreas65");

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
                keyValue: "Apostolos_Mitsotakis");

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
                keyValue: "Basilis.Athanasioy");

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
                keyValue: "Dimitris93");

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
                keyValue: "Eleytherios16");

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
                keyValue: "Eyaggelos_Galanis52");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Username",
                keyValue: "Eyaggelos_Koromilas73");

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
                keyValue: "Panagiotis29");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Username",
                keyValue: "Paraskeyas.Anagnostakis");

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
                keyValue: "Spyros17");

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

            migrationBuilder.DropColumn(
                name: "Capacity",
                table: "Courses");

            migrationBuilder.AddColumn<int>(
                name: "ExamType",
                table: "Exams",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "ClassRoomAddress",
                table: "Courses",
                type: "varchar(100)",
                nullable: false,
                defaultValue: "")
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "ClassRoomRoomName",
                table: "Courses",
                type: "varchar(10)",
                nullable: false,
                defaultValue: "")
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<int>(
                name: "Hours",
                table: "Courses",
                type: "int",
                nullable: false,
                defaultValue: 0,
                comment: "Kurzus heti óraszáma");

            migrationBuilder.AddColumn<int>(
                name: "Capacity",
                table: "ClassRooms",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "ClassRooms",
                type: "longtext",
                nullable: false)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.InsertData(
                table: "ClassRooms",
                columns: new[] { "Address", "RoomNumber", "Capacity", "Name", "RoomType" },
                values: new object[,]
                {
                    { "0189 Kutch Haven, West Daynaborough, Brunei Darussalam", "191", 38, "Rustic Soft Chips", 3 },
                    { "02511 Hermann Prairie, North Aliyahside, Benin", "179", 397, "Incredible Concrete Tuna", 1 },
                    { "0272 Eli Stream, Trantowtown, United States Minor Outlying Islands", "278", 252, "Gorgeous Plastic Pants", 2 },
                    { "0276 Harris Spur, West Sean, Iran", "198", 259, "Tasty Frozen Computer", 2 },
                    { "03179 Bianka Mountains, Stefanville, Kazakhstan", "47", 24, "Fantastic Soft Bacon", 3 },
                    { "060 Schimmel Hill, Lake Sherwood, Macao", "287", 202, "Ergonomic Soft Bike", 3 },
                    { "06445 Turcotte Gateway, Maidashire, Saint Pierre and Miquelon", "15", 578, "Ergonomic Frozen Chair", 3 },
                    { "068 Monahan Rapid, North Cadetown, Barbados", "187", 173, "Gorgeous Rubber Chair", 1 },
                    { "081 Jalyn Union, Thompsonhaven, France", "68", 396, "Practical Rubber Ball", 3 },
                    { "120 Prosacco Trafficway, South Charliefurt, Republic of Korea", "289", 289, "Sleek Plastic Chicken", 1 },
                    { "13325 Hickle Plain, Ebertfort, Burkina Faso", "227", 483, "Rustic Metal Table", 2 },
                    { "1628 Eddie Curve, South Donald, Papua New Guinea", "21", 207, "Awesome Frozen Chair", 0 },
                    { "184 Dietrich Flats, Eliberg, Micronesia", "22", 222, "Intelligent Metal Computer", 3 },
                    { "18597 Buck Cove, East Tonyburgh, Andorra", "58", 540, "Handcrafted Fresh Shoes", 3 },
                    { "18735 Beer Valley, North Alexys, Jamaica", "40", 455, "Awesome Cotton Table", 3 },
                    { "193 Tad Parkways, Hartmannmouth, Mauritania", "170", 306, "Handcrafted Rubber Chicken", 0 },
                    { "23973 Katrina Mills, Madisonshire, Palau", "325", 378, "Awesome Plastic Salad", 0 },
                    { "24163 Sasha Expressway, East Nakia, Nicaragua", "59", 605, "Licensed Cotton Chicken", 1 },
                    { "2435 Erdman Fords, South Ebbaborough, New Zealand", "330", 25, "Handmade Rubber Fish", 0 },
                    { "24667 Unique Port, Port Sister, Anguilla", "180", 172, "Incredible Wooden Pizza", 3 },
                    { "256 Bergnaum Radial, Arvelstad, Guernsey", "135", 168, "Rustic Steel Pants", 1 },
                    { "261 Schaden Parks, Bennettchester, Bahrain", "301", 477, "Handmade Fresh Tuna", 0 },
                    { "2621 Monahan Rapid, Port Kalebfort, Algeria", "318", 438, "Ergonomic Plastic Bacon", 3 },
                    { "26312 Nader Crest, West Lempi, Taiwan", "73", 197, "Gorgeous Cotton Pants", 1 },
                    { "274 Bennie Prairie, Braunfort, Senegal", "226", 411, "Incredible Plastic Hat", 1 },
                    { "275 Bennie Spurs, Feeneytown, Comoros", "145", 350, "Incredible Granite Keyboard", 2 },
                    { "2823 Gulgowski Vista, Lake Lucindastad, Honduras", "60", 323, "Fantastic Metal Hat", 0 },
                    { "2850 Hope Mission, Lake Brennaberg, Azerbaijan", "132", 535, "Rustic Granite Salad", 0 },
                    { "293 Koss Alley, Jerrodmouth, Austria", "305", 120, "Generic Wooden Bacon", 0 },
                    { "3011 Jewel Wall, East Sandy, Christmas Island", "99", 308, "Sleek Plastic Salad", 1 },
                    { "3044 Beatty Village, Spencerside, Sudan", "82", 501, "Generic Plastic Bacon", 1 },
                    { "32133 Stracke Stream, Ollieview, Virgin Islands, U.S.", "199", 245, "Licensed Wooden Pizza", 3 },
                    { "332 Bryce Circle, Lake Kylie, Togo", "337", 119, "Small Fresh Pizza", 3 },
                    { "333 Schiller Run, Lake Darrel, Sierra Leone", "166", 442, "Licensed Granite Keyboard", 1 },
                    { "3390 Frederick Ferry, Schmidtville, Micronesia", "26", 27, "Small Soft Chicken", 1 },
                    { "357 Carroll Shoal, North Athenaton, Ethiopia", "73", 173, "Gorgeous Fresh Ball", 1 },
                    { "35912 McDermott Extension, South Ethaborough, Kyrgyz Republic", "226", 477, "Licensed Fresh Chicken", 3 },
                    { "362 Rolfson Run, West Adelia, Greece", "44", 496, "Handcrafted Concrete Salad", 3 },
                    { "36474 Tre Island, Schadenport, Kazakhstan", "288", 418, "Handmade Frozen Soap", 3 },
                    { "3684 Bode Camp, Gaylordview, Denmark", "162", 55, "Ergonomic Granite Pants", 0 },
                    { "4028 Kris Ramp, Isabellburgh, Heard Island and McDonald Islands", "304", 618, "Gorgeous Soft Shirt", 3 },
                    { "41656 Jaiden Course, Estelville, Lithuania", "249", 71, "Refined Metal Towels", 3 },
                    { "422 Haley Expressway, Daremouth, Bermuda", "162", 381, "Licensed Wooden Tuna", 2 },
                    { "43655 Eldridge Rapid, Franeckiton, United Arab Emirates", "160", 667, "Rustic Rubber Computer", 1 },
                    { "443 Verdie Groves, Bessieview, Mauritania", "47", 652, "Awesome Wooden Pizza", 0 },
                    { "444 Kobe Vista, New Hubert, Sweden", "156", 669, "Refined Cotton Shoes", 2 },
                    { "457 Pfannerstill Harbors, Hermanchester, Kuwait", "38", 202, "Refined Cotton Chips", 3 },
                    { "475 Kathlyn Field, Kunzebury, Bahamas", "32", 275, "Practical Wooden Sausages", 1 },
                    { "4887 Douglas Oval, Lake Everardo, Andorra", "343", 317, "Handcrafted Steel Bike", 1 },
                    { "4927 Rosenbaum Glens, Douglaschester, Lesotho", "26", 132, "Tasty Rubber Keyboard", 2 },
                    { "4935 Cole Lights, Emardshire, Cocos (Keeling) Islands", "42", 351, "Tasty Granite Sausages", 0 },
                    { "499 Pearline Camp, South Brionnafurt, South Africa", "277", 627, "Gorgeous Metal Pants", 0 },
                    { "4999 Pollich Hollow, South Carolanne, Grenada", "126", 63, "Gorgeous Rubber Fish", 3 },
                    { "501 Hudson Path, South Federico, Micronesia", "235", 223, "Refined Steel Chair", 0 },
                    { "527 Ledner Ville, Lianatown, Ecuador", "225", 237, "Licensed Rubber Cheese", 0 },
                    { "5294 Dickinson Gardens, Mullerfort, Germany", "182", 493, "Awesome Metal Sausages", 3 },
                    { "540 Mosciski Shoal, South Rosellafort, Mayotte", "103", 408, "Intelligent Granite Sausages", 0 },
                    { "54213 Raynor Island, Kirlinmouth, Fiji", "130", 579, "Tasty Concrete Chair", 1 },
                    { "54979 Malachi Track, Krajcikview, American Samoa", "122", 84, "Refined Cotton Hat", 1 },
                    { "55646 Merle Rest, Oscarstad, Bahamas", "264", 279, "Generic Fresh Table", 1 },
                    { "5798 Little Viaduct, New Braedenport, Mayotte", "231", 223, "Refined Wooden Salad", 0 },
                    { "5822 Streich Unions, North Tillmanside, Argentina", "203", 307, "Gorgeous Concrete Fish", 1 },
                    { "583 Tillman Falls, Bonnieshire, Gabon", "175", 293, "Sleek Cotton Gloves", 1 },
                    { "58902 Ledner Run, Leonardofurt, Liberia", "221", 638, "Generic Cotton Computer", 1 },
                    { "6037 Lakin Lock, Nicoville, Congo", "96", 616, "Fantastic Granite Sausages", 0 },
                    { "62452 Billie Squares, New Everettview, Guyana", "75", 613, "Tasty Concrete Computer", 1 },
                    { "64942 Jaeden Mountains, Lehnerchester, Cameroon", "147", 649, "Handcrafted Fresh Car", 1 },
                    { "65072 Presley Spurs, Streichstad, Angola", "218", 248, "Small Wooden Tuna", 1 },
                    { "6619 Robel Crescent, New Sylviamouth, Cayman Islands", "323", 469, "Sleek Fresh Cheese", 3 },
                    { "6713 Wyman Mill, East Antoinette, Italy", "195", 408, "Fantastic Steel Tuna", 1 },
                    { "708 Zieme Village, Kelliberg, Uganda", "156", 397, "Licensed Soft Ball", 0 },
                    { "711 Charity Shoals, Oniestad, Tunisia", "198", 209, "Practical Plastic Mouse", 2 },
                    { "71321 Itzel Curve, Alannaberg, Burkina Faso", "62", 615, "Licensed Soft Cheese", 3 },
                    { "717 Juliana Rapid, Port Elviefort, Tokelau", "303", 517, "Licensed Concrete Keyboard", 0 },
                    { "7310 Chet Wall, Lake Caleb, Somalia", "58", 160, "Gorgeous Frozen Sausages", 3 },
                    { "7402 Murphy Grove, Noblefort, Tuvalu", "249", 25, "Fantastic Soft Fish", 2 },
                    { "753 Hoppe Field, Schroederburgh, Portugal", "184", 339, "Rustic Wooden Keyboard", 1 },
                    { "76271 Botsford Lights, South Bryana, South Africa", "349", 378, "Awesome Fresh Chips", 0 },
                    { "7934 Adams Lodge, South Deronbury, Colombia", "313", 699, "Sleek Soft Towels", 0 },
                    { "794 Patrick Port, Zanechester, Puerto Rico", "35", 147, "Licensed Steel Computer", 2 },
                    { "79430 Gleason Spur, Kunzestad, Slovenia", "175", 670, "Gorgeous Wooden Towels", 2 },
                    { "7984 Madyson Fields, New Anselland, Kazakhstan", "58", 533, "Handmade Frozen Mouse", 1 },
                    { "80133 Norma Forge, Treutelburgh, Latvia", "99", 270, "Generic Steel Soap", 0 },
                    { "806 Olson Corners, Lake Isai, Slovakia (Slovak Republic)", "42", 322, "Unbranded Cotton Pants", 1 },
                    { "821 Alejandrin Harbors, East Chazville, Montserrat", "306", 509, "Unbranded Granite Car", 3 },
                    { "827 Klein Mountain, Mikemouth, Monaco", "229", 392, "Incredible Granite Gloves", 3 },
                    { "8298 Marcelino Ways, Schuylerberg, Belgium", "320", 653, "Practical Metal Hat", 0 },
                    { "832 Konopelski Terrace, Bufordmouth, Pakistan", "195", 326, "Refined Steel Towels", 3 },
                    { "851 Klein Square, North Ernesto, Slovenia", "284", 606, "Practical Frozen Chair", 2 },
                    { "85848 Wisozk Course, East Aniyahaven, Dominican Republic", "323", 323, "Gorgeous Fresh Pizza", 3 },
                    { "864 Trent Burgs, Garfieldfort, Virgin Islands, British", "147", 140, "Awesome Cotton Bacon", 3 },
                    { "879 Carey Glen, South Jonathan, Switzerland", "206", 688, "Intelligent Metal Shirt", 1 },
                    { "8841 Jacobi Unions, New Theresemouth, Swaziland", "226", 594, "Generic Wooden Chicken", 3 },
                    { "91230 Schoen Wells, Port Laceyville, Guatemala", "288", 244, "Refined Steel Car", 0 },
                    { "926 Skiles Mission, Audreannechester, Antarctica (the territory South of 60 deg S)", "172", 64, "Intelligent Fresh Chips", 2 },
                    { "962 Yvonne Trail, Wintheiserberg, Central African Republic", "63", 247, "Practical Concrete Chicken", 2 },
                    { "97229 Hand Turnpike, New Abagail, Ghana", "92", 57, "Refined Concrete Fish", 2 },
                    { "98040 Wilderman Green, South Loraine, Kazakhstan", "340", 435, "Ergonomic Metal Bike", 3 },
                    { "997 Neva Landing, Auershire, Gabon", "298", 419, "Fantastic Rubber Soap", 1 },
                    { "9991 Fay Walk, Port Nelson, Angola", "90", 559, "Incredible Metal Shirt", 2 }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Username", "BirthDate", "BirthLocation", "Name", "PasswordHash" },
                values: new object[,]
                {
                    { "Aaron79", new DateOnly(1965, 1, 23), "Hermistonside", "Claudia Bogisich", "AQAAAAIAAYagAAAAEPy0Sa3t+0fqE5iMzp1a5B7FRWSO31WJ37yCzKu2fXCjldLH0utein9gF7o23hnu5g==" },
                    { "Adriana.Koepp", new DateOnly(1976, 5, 31), "East Lorenzamouth", "Curtis Lesch", "AQAAAAIAAYagAAAAEPy0Sa3t+0fqE5iMzp1a5B7FRWSO31WJ37yCzKu2fXCjldLH0utein9gF7o23hnu5g==" },
                    { "Agnes45", new DateOnly(2001, 6, 3), "Lake Maymie", "Laisha Satterfield", "AQAAAAIAAYagAAAAEPy0Sa3t+0fqE5iMzp1a5B7FRWSO31WJ37yCzKu2fXCjldLH0utein9gF7o23hnu5g==" },
                    { "Allan_Dicki", new DateOnly(1989, 1, 28), "Port Whitney", "Ashton Hamill", "AQAAAAIAAYagAAAAEPy0Sa3t+0fqE5iMzp1a5B7FRWSO31WJ37yCzKu2fXCjldLH0utein9gF7o23hnu5g==" },
                    { "Amari.Cummerata0", new DateOnly(1994, 5, 8), "West Isabelleport", "Vanessa Durgan", "AQAAAAIAAYagAAAAEPy0Sa3t+0fqE5iMzp1a5B7FRWSO31WJ37yCzKu2fXCjldLH0utein9gF7o23hnu5g==" },
                    { "Amos28", new DateOnly(1978, 8, 7), "New Ariel", "Willy Schneider", "AQAAAAIAAYagAAAAEPy0Sa3t+0fqE5iMzp1a5B7FRWSO31WJ37yCzKu2fXCjldLH0utein9gF7o23hnu5g==" },
                    { "Angelita.Dooley85", new DateOnly(1978, 10, 22), "New Jarodfurt", "Helmer Gorczany", "AQAAAAIAAYagAAAAEPy0Sa3t+0fqE5iMzp1a5B7FRWSO31WJ37yCzKu2fXCjldLH0utein9gF7o23hnu5g==" },
                    { "Annalise_Friesen", new DateOnly(1996, 4, 4), "New Carissa", "Nelle Donnelly", "AQAAAAIAAYagAAAAEPy0Sa3t+0fqE5iMzp1a5B7FRWSO31WJ37yCzKu2fXCjldLH0utein9gF7o23hnu5g==" },
                    { "Antonina92", new DateOnly(1964, 6, 15), "East Kathleen", "Euna Mohr", "AQAAAAIAAYagAAAAEPy0Sa3t+0fqE5iMzp1a5B7FRWSO31WJ37yCzKu2fXCjldLH0utein9gF7o23hnu5g==" },
                    { "Ayla.Reinger75", new DateOnly(1990, 5, 4), "Barrowsport", "Pascale Howe", "AQAAAAIAAYagAAAAEPy0Sa3t+0fqE5iMzp1a5B7FRWSO31WJ37yCzKu2fXCjldLH0utein9gF7o23hnu5g==" },
                    { "Benjamin93", new DateOnly(1969, 3, 25), "West Dereck", "Andreanne Lemke", "AQAAAAIAAYagAAAAEPy0Sa3t+0fqE5iMzp1a5B7FRWSO31WJ37yCzKu2fXCjldLH0utein9gF7o23hnu5g==" },
                    { "Berenice28", new DateOnly(1988, 4, 13), "Ressieland", "Luciano Wolf", "AQAAAAIAAYagAAAAEPy0Sa3t+0fqE5iMzp1a5B7FRWSO31WJ37yCzKu2fXCjldLH0utein9gF7o23hnu5g==" },
                    { "Betty.Cremin", new DateOnly(1995, 2, 15), "East Sanfordton", "Mason Ryan", "AQAAAAIAAYagAAAAEPy0Sa3t+0fqE5iMzp1a5B7FRWSO31WJ37yCzKu2fXCjldLH0utein9gF7o23hnu5g==" },
                    { "Chelsie_McClure", new DateOnly(2001, 3, 28), "Joeton", "Rae Koelpin", "AQAAAAIAAYagAAAAEPy0Sa3t+0fqE5iMzp1a5B7FRWSO31WJ37yCzKu2fXCjldLH0utein9gF7o23hnu5g==" },
                    { "Chester.Bartoletti", new DateOnly(1965, 11, 3), "Brekkemouth", "Ray Powlowski", "AQAAAAIAAYagAAAAEPy0Sa3t+0fqE5iMzp1a5B7FRWSO31WJ37yCzKu2fXCjldLH0utein9gF7o23hnu5g==" },
                    { "Cicero_VonRueden", new DateOnly(2001, 8, 1), "Elmerside", "Trace Terry", "AQAAAAIAAYagAAAAEPy0Sa3t+0fqE5iMzp1a5B7FRWSO31WJ37yCzKu2fXCjldLH0utein9gF7o23hnu5g==" },
                    { "Clay61", new DateOnly(1980, 7, 10), "Bryonborough", "Eulah O'Reilly", "AQAAAAIAAYagAAAAEPy0Sa3t+0fqE5iMzp1a5B7FRWSO31WJ37yCzKu2fXCjldLH0utein9gF7o23hnu5g==" },
                    { "Dahlia_Rodriguez47", new DateOnly(1988, 3, 22), "North Andreville", "Jarod Weimann", "AQAAAAIAAYagAAAAEPy0Sa3t+0fqE5iMzp1a5B7FRWSO31WJ37yCzKu2fXCjldLH0utein9gF7o23hnu5g==" },
                    { "Daisha.Aufderhar", new DateOnly(1977, 1, 18), "Bechtelarside", "Patricia Kuphal", "AQAAAAIAAYagAAAAEPy0Sa3t+0fqE5iMzp1a5B7FRWSO31WJ37yCzKu2fXCjldLH0utein9gF7o23hnu5g==" },
                    { "Demarcus.Erdman85", new DateOnly(1960, 11, 13), "Tomburgh", "Elmira Dietrich", "AQAAAAIAAYagAAAAEPy0Sa3t+0fqE5iMzp1a5B7FRWSO31WJ37yCzKu2fXCjldLH0utein9gF7o23hnu5g==" },
                    { "Demetris90", new DateOnly(1982, 5, 20), "Barrowsberg", "Eryn Thiel", "AQAAAAIAAYagAAAAEPy0Sa3t+0fqE5iMzp1a5B7FRWSO31WJ37yCzKu2fXCjldLH0utein9gF7o23hnu5g==" },
                    { "Deon_Ziemann", new DateOnly(2005, 3, 20), "South Sanfordberg", "Jannie Schuppe", "AQAAAAIAAYagAAAAEPy0Sa3t+0fqE5iMzp1a5B7FRWSO31WJ37yCzKu2fXCjldLH0utein9gF7o23hnu5g==" },
                    { "Dixie.Lueilwitz", new DateOnly(1963, 12, 27), "Othohaven", "Rolando Johnson", "AQAAAAIAAYagAAAAEPy0Sa3t+0fqE5iMzp1a5B7FRWSO31WJ37yCzKu2fXCjldLH0utein9gF7o23hnu5g==" },
                    { "Domingo.Watsica", new DateOnly(2003, 4, 21), "North Juliettown", "Justyn Hayes", "AQAAAAIAAYagAAAAEPy0Sa3t+0fqE5iMzp1a5B7FRWSO31WJ37yCzKu2fXCjldLH0utein9gF7o23hnu5g==" },
                    { "Dusty_Graham52", new DateOnly(1994, 6, 22), "Port Jazmynmouth", "Rubye Gorczany", "AQAAAAIAAYagAAAAEPy0Sa3t+0fqE5iMzp1a5B7FRWSO31WJ37yCzKu2fXCjldLH0utein9gF7o23hnu5g==" },
                    { "Eldora.OKon", new DateOnly(2004, 3, 5), "North Imanishire", "Coty Runolfsdottir", "AQAAAAIAAYagAAAAEPy0Sa3t+0fqE5iMzp1a5B7FRWSO31WJ37yCzKu2fXCjldLH0utein9gF7o23hnu5g==" },
                    { "Elizabeth_Orn73", new DateOnly(1999, 5, 4), "New Sherman", "Myah Gaylord", "AQAAAAIAAYagAAAAEPy0Sa3t+0fqE5iMzp1a5B7FRWSO31WJ37yCzKu2fXCjldLH0utein9gF7o23hnu5g==" },
                    { "Elsie_Breitenberg", new DateOnly(1977, 3, 31), "Effertzland", "Malvina Reinger", "AQAAAAIAAYagAAAAEPy0Sa3t+0fqE5iMzp1a5B7FRWSO31WJ37yCzKu2fXCjldLH0utein9gF7o23hnu5g==" },
                    { "Elvera17", new DateOnly(2005, 3, 22), "Gradyburgh", "Alvah McGlynn", "AQAAAAIAAYagAAAAEPy0Sa3t+0fqE5iMzp1a5B7FRWSO31WJ37yCzKu2fXCjldLH0utein9gF7o23hnu5g==" },
                    { "Elza.Wintheiser", new DateOnly(1980, 8, 13), "Dallintown", "Kaelyn Smith", "AQAAAAIAAYagAAAAEPy0Sa3t+0fqE5iMzp1a5B7FRWSO31WJ37yCzKu2fXCjldLH0utein9gF7o23hnu5g==" },
                    { "Enrico97", new DateOnly(1971, 8, 14), "North Amelia", "Rhiannon Toy", "AQAAAAIAAYagAAAAEPy0Sa3t+0fqE5iMzp1a5B7FRWSO31WJ37yCzKu2fXCjldLH0utein9gF7o23hnu5g==" },
                    { "Eve_Champlin", new DateOnly(2000, 12, 10), "North Audra", "Rosalyn Collins", "AQAAAAIAAYagAAAAEPy0Sa3t+0fqE5iMzp1a5B7FRWSO31WJ37yCzKu2fXCjldLH0utein9gF7o23hnu5g==" },
                    { "Ewell_Yost", new DateOnly(2004, 9, 4), "Stiedemannberg", "Misael Lebsack", "AQAAAAIAAYagAAAAEPy0Sa3t+0fqE5iMzp1a5B7FRWSO31WJ37yCzKu2fXCjldLH0utein9gF7o23hnu5g==" },
                    { "Fay_Jast43", new DateOnly(1992, 11, 23), "New Seanshire", "Shaun Haley", "AQAAAAIAAYagAAAAEPy0Sa3t+0fqE5iMzp1a5B7FRWSO31WJ37yCzKu2fXCjldLH0utein9gF7o23hnu5g==" },
                    { "Filiberto4", new DateOnly(1986, 12, 4), "Elliotchester", "Frederik Hane", "AQAAAAIAAYagAAAAEPy0Sa3t+0fqE5iMzp1a5B7FRWSO31WJ37yCzKu2fXCjldLH0utein9gF7o23hnu5g==" },
                    { "Finn_Stehr26", new DateOnly(1967, 3, 12), "Haydentown", "Laverne Bernier", "AQAAAAIAAYagAAAAEPy0Sa3t+0fqE5iMzp1a5B7FRWSO31WJ37yCzKu2fXCjldLH0utein9gF7o23hnu5g==" },
                    { "Fletcher_McDermott46", new DateOnly(1966, 3, 13), "Fernandostad", "Consuelo Kutch", "AQAAAAIAAYagAAAAEPy0Sa3t+0fqE5iMzp1a5B7FRWSO31WJ37yCzKu2fXCjldLH0utein9gF7o23hnu5g==" },
                    { "Francis.Kunze", new DateOnly(1991, 8, 13), "Bretthaven", "Caesar Huel", "AQAAAAIAAYagAAAAEPy0Sa3t+0fqE5iMzp1a5B7FRWSO31WJ37yCzKu2fXCjldLH0utein9gF7o23hnu5g==" },
                    { "Genoveva_Volkman52", new DateOnly(1999, 11, 22), "Petermouth", "Lucie Wyman", "AQAAAAIAAYagAAAAEPy0Sa3t+0fqE5iMzp1a5B7FRWSO31WJ37yCzKu2fXCjldLH0utein9gF7o23hnu5g==" },
                    { "Gilberto.Ruecker89", new DateOnly(1986, 12, 8), "North Vivienneburgh", "Quinten Lynch", "AQAAAAIAAYagAAAAEPy0Sa3t+0fqE5iMzp1a5B7FRWSO31WJ37yCzKu2fXCjldLH0utein9gF7o23hnu5g==" },
                    { "Giovanny.Kuphal96", new DateOnly(2002, 8, 25), "New Terrance", "Hermann Carroll", "AQAAAAIAAYagAAAAEPy0Sa3t+0fqE5iMzp1a5B7FRWSO31WJ37yCzKu2fXCjldLH0utein9gF7o23hnu5g==" },
                    { "Gladyce.Doyle2", new DateOnly(1981, 4, 30), "Port Garrymouth", "Cierra Jerde", "AQAAAAIAAYagAAAAEPy0Sa3t+0fqE5iMzp1a5B7FRWSO31WJ37yCzKu2fXCjldLH0utein9gF7o23hnu5g==" },
                    { "Grant68", new DateOnly(1987, 10, 2), "South Emelia", "Gretchen Emmerich", "AQAAAAIAAYagAAAAEPy0Sa3t+0fqE5iMzp1a5B7FRWSO31WJ37yCzKu2fXCjldLH0utein9gF7o23hnu5g==" },
                    { "Gregoria_Bailey", new DateOnly(1971, 9, 6), "Lake Ebony", "Michelle O'Connell", "AQAAAAIAAYagAAAAEPy0Sa3t+0fqE5iMzp1a5B7FRWSO31WJ37yCzKu2fXCjldLH0utein9gF7o23hnu5g==" },
                    { "Hector65", new DateOnly(2003, 3, 15), "Bernhardbury", "Alba Fisher", "AQAAAAIAAYagAAAAEPy0Sa3t+0fqE5iMzp1a5B7FRWSO31WJ37yCzKu2fXCjldLH0utein9gF7o23hnu5g==" },
                    { "Hortense_Gerhold93", new DateOnly(1973, 8, 19), "North Hilbertshire", "Selmer Runolfsson", "AQAAAAIAAYagAAAAEPy0Sa3t+0fqE5iMzp1a5B7FRWSO31WJ37yCzKu2fXCjldLH0utein9gF7o23hnu5g==" },
                    { "Houston22", new DateOnly(1989, 9, 30), "Port Keyonchester", "Shakira Auer", "AQAAAAIAAYagAAAAEPy0Sa3t+0fqE5iMzp1a5B7FRWSO31WJ37yCzKu2fXCjldLH0utein9gF7o23hnu5g==" },
                    { "Imelda.Sawayn26", new DateOnly(1969, 7, 31), "West Beth", "Sydney Corwin", "AQAAAAIAAYagAAAAEPy0Sa3t+0fqE5iMzp1a5B7FRWSO31WJ37yCzKu2fXCjldLH0utein9gF7o23hnu5g==" },
                    { "Jacynthe43", new DateOnly(1983, 5, 22), "West Saige", "Arden Morissette", "AQAAAAIAAYagAAAAEPy0Sa3t+0fqE5iMzp1a5B7FRWSO31WJ37yCzKu2fXCjldLH0utein9gF7o23hnu5g==" },
                    { "Jakayla74", new DateOnly(1988, 3, 14), "New Hilma", "Chandler Jacobi", "AQAAAAIAAYagAAAAEPy0Sa3t+0fqE5iMzp1a5B7FRWSO31WJ37yCzKu2fXCjldLH0utein9gF7o23hnu5g==" },
                    { "Javier41", new DateOnly(1972, 10, 1), "Florenceville", "Tanya Davis", "AQAAAAIAAYagAAAAEPy0Sa3t+0fqE5iMzp1a5B7FRWSO31WJ37yCzKu2fXCjldLH0utein9gF7o23hnu5g==" },
                    { "Jenifer_Lueilwitz72", new DateOnly(1971, 12, 30), "North Ludwig", "Imelda Toy", "AQAAAAIAAYagAAAAEPy0Sa3t+0fqE5iMzp1a5B7FRWSO31WJ37yCzKu2fXCjldLH0utein9gF7o23hnu5g==" },
                    { "Jessy.Lang61", new DateOnly(1986, 9, 26), "Dillonhaven", "Charles Metz", "AQAAAAIAAYagAAAAEPy0Sa3t+0fqE5iMzp1a5B7FRWSO31WJ37yCzKu2fXCjldLH0utein9gF7o23hnu5g==" },
                    { "Jordy_Bergstrom5", new DateOnly(1985, 1, 2), "Binsland", "Margarete Friesen", "AQAAAAIAAYagAAAAEPy0Sa3t+0fqE5iMzp1a5B7FRWSO31WJ37yCzKu2fXCjldLH0utein9gF7o23hnu5g==" },
                    { "Joshuah.Hagenes", new DateOnly(1997, 12, 4), "Cristobaltown", "Marion Murphy", "AQAAAAIAAYagAAAAEPy0Sa3t+0fqE5iMzp1a5B7FRWSO31WJ37yCzKu2fXCjldLH0utein9gF7o23hnu5g==" },
                    { "Jude_Simonis67", new DateOnly(1991, 10, 10), "Sandraton", "Rowland Hahn", "AQAAAAIAAYagAAAAEPy0Sa3t+0fqE5iMzp1a5B7FRWSO31WJ37yCzKu2fXCjldLH0utein9gF7o23hnu5g==" },
                    { "Kane14", new DateOnly(1996, 10, 20), "Schmidtmouth", "Keara Abshire", "AQAAAAIAAYagAAAAEPy0Sa3t+0fqE5iMzp1a5B7FRWSO31WJ37yCzKu2fXCjldLH0utein9gF7o23hnu5g==" },
                    { "Katelynn.Abshire2", new DateOnly(1999, 9, 24), "Lake Aylin", "Joaquin Jacobson", "AQAAAAIAAYagAAAAEPy0Sa3t+0fqE5iMzp1a5B7FRWSO31WJ37yCzKu2fXCjldLH0utein9gF7o23hnu5g==" },
                    { "Katrine_Daniel22", new DateOnly(1999, 7, 29), "North Kyler", "Asa Bogan", "AQAAAAIAAYagAAAAEPy0Sa3t+0fqE5iMzp1a5B7FRWSO31WJ37yCzKu2fXCjldLH0utein9gF7o23hnu5g==" },
                    { "Kattie.Stracke74", new DateOnly(2001, 11, 4), "South Judgehaven", "Jay Bayer", "AQAAAAIAAYagAAAAEPy0Sa3t+0fqE5iMzp1a5B7FRWSO31WJ37yCzKu2fXCjldLH0utein9gF7o23hnu5g==" },
                    { "Koby_Erdman29", new DateOnly(1967, 8, 14), "Mikelstad", "Gordon Lemke", "AQAAAAIAAYagAAAAEPy0Sa3t+0fqE5iMzp1a5B7FRWSO31WJ37yCzKu2fXCjldLH0utein9gF7o23hnu5g==" },
                    { "Larue.Frami51", new DateOnly(2002, 1, 4), "Arnaldoport", "Herminio Bernhard", "AQAAAAIAAYagAAAAEPy0Sa3t+0fqE5iMzp1a5B7FRWSO31WJ37yCzKu2fXCjldLH0utein9gF7o23hnu5g==" },
                    { "Lenora77", new DateOnly(1985, 4, 27), "Ivahland", "Cyril Rolfson", "AQAAAAIAAYagAAAAEPy0Sa3t+0fqE5iMzp1a5B7FRWSO31WJ37yCzKu2fXCjldLH0utein9gF7o23hnu5g==" },
                    { "Leopoldo.Lesch", new DateOnly(2005, 9, 3), "Port Eveline", "Cecelia Kuvalis", "AQAAAAIAAYagAAAAEPy0Sa3t+0fqE5iMzp1a5B7FRWSO31WJ37yCzKu2fXCjldLH0utein9gF7o23hnu5g==" },
                    { "Lexie_Lang", new DateOnly(1990, 6, 20), "Port Louveniaside", "Burley Goyette", "AQAAAAIAAYagAAAAEPy0Sa3t+0fqE5iMzp1a5B7FRWSO31WJ37yCzKu2fXCjldLH0utein9gF7o23hnu5g==" },
                    { "Lilian.McKenzie43", new DateOnly(1979, 5, 10), "Port Xanderport", "Vincenza Swaniawski", "AQAAAAIAAYagAAAAEPy0Sa3t+0fqE5iMzp1a5B7FRWSO31WJ37yCzKu2fXCjldLH0utein9gF7o23hnu5g==" },
                    { "Mack.Schiller", new DateOnly(1975, 5, 25), "Rebekafort", "Dedric Wunsch", "AQAAAAIAAYagAAAAEPy0Sa3t+0fqE5iMzp1a5B7FRWSO31WJ37yCzKu2fXCjldLH0utein9gF7o23hnu5g==" },
                    { "Margie.Klocko", new DateOnly(1984, 1, 31), "Lake Clinton", "Kathryn Funk", "AQAAAAIAAYagAAAAEPy0Sa3t+0fqE5iMzp1a5B7FRWSO31WJ37yCzKu2fXCjldLH0utein9gF7o23hnu5g==" },
                    { "Mariane0", new DateOnly(2004, 3, 12), "New Charleymouth", "Gunner Strosin", "AQAAAAIAAYagAAAAEPy0Sa3t+0fqE5iMzp1a5B7FRWSO31WJ37yCzKu2fXCjldLH0utein9gF7o23hnu5g==" },
                    { "Matteo15", new DateOnly(1992, 8, 21), "Kunzeton", "Josefa Jast", "AQAAAAIAAYagAAAAEPy0Sa3t+0fqE5iMzp1a5B7FRWSO31WJ37yCzKu2fXCjldLH0utein9gF7o23hnu5g==" },
                    { "Melba75", new DateOnly(1996, 7, 9), "Thielburgh", "Monty Dibbert", "AQAAAAIAAYagAAAAEPy0Sa3t+0fqE5iMzp1a5B7FRWSO31WJ37yCzKu2fXCjldLH0utein9gF7o23hnu5g==" },
                    { "Milan.Ratke", new DateOnly(1975, 12, 28), "Cassieton", "Edgardo Stamm", "AQAAAAIAAYagAAAAEPy0Sa3t+0fqE5iMzp1a5B7FRWSO31WJ37yCzKu2fXCjldLH0utein9gF7o23hnu5g==" },
                    { "Miracle_Hilpert", new DateOnly(1973, 10, 30), "Deckowtown", "Alice Hilll", "AQAAAAIAAYagAAAAEPy0Sa3t+0fqE5iMzp1a5B7FRWSO31WJ37yCzKu2fXCjldLH0utein9gF7o23hnu5g==" },
                    { "Mireille_Streich", new DateOnly(1999, 1, 18), "East Rosalind", "Keegan MacGyver", "AQAAAAIAAYagAAAAEPy0Sa3t+0fqE5iMzp1a5B7FRWSO31WJ37yCzKu2fXCjldLH0utein9gF7o23hnu5g==" },
                    { "Monty.Murphy93", new DateOnly(1978, 11, 6), "New Walton", "Kamille Marks", "AQAAAAIAAYagAAAAEPy0Sa3t+0fqE5iMzp1a5B7FRWSO31WJ37yCzKu2fXCjldLH0utein9gF7o23hnu5g==" },
                    { "Nelson.Simonis18", new DateOnly(1998, 8, 14), "Riceshire", "Edmund Gulgowski", "AQAAAAIAAYagAAAAEPy0Sa3t+0fqE5iMzp1a5B7FRWSO31WJ37yCzKu2fXCjldLH0utein9gF7o23hnu5g==" },
                    { "Nichole_Stiedemann24", new DateOnly(2001, 1, 30), "Gildamouth", "Ciara Gleichner", "AQAAAAIAAYagAAAAEPy0Sa3t+0fqE5iMzp1a5B7FRWSO31WJ37yCzKu2fXCjldLH0utein9gF7o23hnu5g==" },
                    { "Nick.Boyle", new DateOnly(1972, 11, 13), "West Vernie", "Lilla Schuster", "AQAAAAIAAYagAAAAEPy0Sa3t+0fqE5iMzp1a5B7FRWSO31WJ37yCzKu2fXCjldLH0utein9gF7o23hnu5g==" },
                    { "Nina.Renner", new DateOnly(1967, 11, 7), "Jodymouth", "Bettye Lebsack", "AQAAAAIAAYagAAAAEPy0Sa3t+0fqE5iMzp1a5B7FRWSO31WJ37yCzKu2fXCjldLH0utein9gF7o23hnu5g==" },
                    { "Pat_Nienow13", new DateOnly(1962, 9, 20), "West Bette", "Presley Harris", "AQAAAAIAAYagAAAAEPy0Sa3t+0fqE5iMzp1a5B7FRWSO31WJ37yCzKu2fXCjldLH0utein9gF7o23hnu5g==" },
                    { "Princess.Gerhold", new DateOnly(1990, 12, 25), "East Kenyatta", "Mortimer Ondricka", "AQAAAAIAAYagAAAAEPy0Sa3t+0fqE5iMzp1a5B7FRWSO31WJ37yCzKu2fXCjldLH0utein9gF7o23hnu5g==" },
                    { "Rae87", new DateOnly(1997, 9, 11), "Raetown", "Dorothea Kunze", "AQAAAAIAAYagAAAAEPy0Sa3t+0fqE5iMzp1a5B7FRWSO31WJ37yCzKu2fXCjldLH0utein9gF7o23hnu5g==" },
                    { "Ricky_Haley30", new DateOnly(2003, 12, 5), "Charlottemouth", "Nona Abernathy", "AQAAAAIAAYagAAAAEPy0Sa3t+0fqE5iMzp1a5B7FRWSO31WJ37yCzKu2fXCjldLH0utein9gF7o23hnu5g==" },
                    { "Rosa.Satterfield27", new DateOnly(1979, 6, 27), "West Leefort", "Arturo Ratke", "AQAAAAIAAYagAAAAEPy0Sa3t+0fqE5iMzp1a5B7FRWSO31WJ37yCzKu2fXCjldLH0utein9gF7o23hnu5g==" },
                    { "Rowena.Vandervort21", new DateOnly(1978, 1, 12), "East Bridgetteberg", "Sibyl Adams", "AQAAAAIAAYagAAAAEPy0Sa3t+0fqE5iMzp1a5B7FRWSO31WJ37yCzKu2fXCjldLH0utein9gF7o23hnu5g==" },
                    { "Ruben24", new DateOnly(1984, 8, 31), "New Angeline", "Zetta Hegmann", "AQAAAAIAAYagAAAAEPy0Sa3t+0fqE5iMzp1a5B7FRWSO31WJ37yCzKu2fXCjldLH0utein9gF7o23hnu5g==" },
                    { "Sally29", new DateOnly(2002, 11, 4), "North Anissaport", "Rory Frami", "AQAAAAIAAYagAAAAEPy0Sa3t+0fqE5iMzp1a5B7FRWSO31WJ37yCzKu2fXCjldLH0utein9gF7o23hnu5g==" },
                    { "Sandy40", new DateOnly(1973, 12, 23), "Dejontown", "Esmeralda Johnston", "AQAAAAIAAYagAAAAEPy0Sa3t+0fqE5iMzp1a5B7FRWSO31WJ37yCzKu2fXCjldLH0utein9gF7o23hnu5g==" },
                    { "Shanna_Abernathy41", new DateOnly(2004, 4, 18), "Mosesfort", "Evert Ratke", "AQAAAAIAAYagAAAAEPy0Sa3t+0fqE5iMzp1a5B7FRWSO31WJ37yCzKu2fXCjldLH0utein9gF7o23hnu5g==" },
                    { "Shirley17", new DateOnly(1987, 12, 28), "Lafayettebury", "Chet Larson", "AQAAAAIAAYagAAAAEPy0Sa3t+0fqE5iMzp1a5B7FRWSO31WJ37yCzKu2fXCjldLH0utein9gF7o23hnu5g==" },
                    { "Sophie_Marquardt76", new DateOnly(2001, 6, 8), "Lockmanside", "Elmira McGlynn", "AQAAAAIAAYagAAAAEPy0Sa3t+0fqE5iMzp1a5B7FRWSO31WJ37yCzKu2fXCjldLH0utein9gF7o23hnu5g==" },
                    { "Stan.Nader", new DateOnly(1967, 6, 20), "Port Alvastad", "Tianna Bayer", "AQAAAAIAAYagAAAAEPy0Sa3t+0fqE5iMzp1a5B7FRWSO31WJ37yCzKu2fXCjldLH0utein9gF7o23hnu5g==" },
                    { "Susan48", new DateOnly(1981, 11, 17), "West Marcelle", "Reed Mayert", "AQAAAAIAAYagAAAAEPy0Sa3t+0fqE5iMzp1a5B7FRWSO31WJ37yCzKu2fXCjldLH0utein9gF7o23hnu5g==" },
                    { "Tito29", new DateOnly(1976, 5, 21), "Lake Alvena", "Kara Hand", "AQAAAAIAAYagAAAAEPy0Sa3t+0fqE5iMzp1a5B7FRWSO31WJ37yCzKu2fXCjldLH0utein9gF7o23hnu5g==" },
                    { "Tobin.Boyle", new DateOnly(1996, 12, 31), "North Liana", "Letha Lemke", "AQAAAAIAAYagAAAAEPy0Sa3t+0fqE5iMzp1a5B7FRWSO31WJ37yCzKu2fXCjldLH0utein9gF7o23hnu5g==" },
                    { "Torey.Kohler48", new DateOnly(1987, 8, 9), "Franeckibury", "Alexandrine Cole", "AQAAAAIAAYagAAAAEPy0Sa3t+0fqE5iMzp1a5B7FRWSO31WJ37yCzKu2fXCjldLH0utein9gF7o23hnu5g==" },
                    { "Vance_Stehr", new DateOnly(1999, 7, 7), "Stiedemannchester", "Lilla Hoppe", "AQAAAAIAAYagAAAAEPy0Sa3t+0fqE5iMzp1a5B7FRWSO31WJ37yCzKu2fXCjldLH0utein9gF7o23hnu5g==" },
                    { "Verna.Boehm12", new DateOnly(1995, 1, 25), "Breanneland", "Salvador O'Kon", "AQAAAAIAAYagAAAAEPy0Sa3t+0fqE5iMzp1a5B7FRWSO31WJ37yCzKu2fXCjldLH0utein9gF7o23hnu5g==" },
                    { "Viviane.Wiza", new DateOnly(1982, 12, 7), "Stanfordberg", "Cullen Rodriguez", "AQAAAAIAAYagAAAAEPy0Sa3t+0fqE5iMzp1a5B7FRWSO31WJ37yCzKu2fXCjldLH0utein9gF7o23hnu5g==" },
                    { "Wiley_Kohler", new DateOnly(1987, 12, 25), "Wunschville", "Arne Tremblay", "AQAAAAIAAYagAAAAEPy0Sa3t+0fqE5iMzp1a5B7FRWSO31WJ37yCzKu2fXCjldLH0utein9gF7o23hnu5g==" }
                });

            migrationBuilder.InsertData(
                table: "DegreeParticipations",
                columns: new[] { "DegreeName", "Username", "EndDate", "StartDate" },
                values: new object[,]
                {
                    { "Books (290)", "Aaron79", new DateOnly(1986, 1, 23), new DateOnly(1983, 1, 23) },
                    { "Clothing, Electronics & Jewelery (253)", "Adriana.Koepp", new DateOnly(1997, 5, 31), new DateOnly(1994, 5, 31) },
                    { "Home (264)", "Agnes45", new DateOnly(2022, 6, 3), new DateOnly(2019, 6, 3) },
                    { "Garden (260)", "Allan_Dicki", new DateOnly(2010, 1, 28), new DateOnly(2007, 1, 28) },
                    { "Kids, Electronics & Movies (288)", "Amari.Cummerata0", new DateOnly(2015, 5, 8), new DateOnly(2012, 5, 8) },
                    { "Electronics (266)", "Amos28", new DateOnly(1999, 8, 7), new DateOnly(1996, 8, 7) },
                    { "Baby (256)", "Angelita.Dooley85", new DateOnly(1999, 10, 22), new DateOnly(1996, 10, 22) },
                    { "Outdoors, Home & Baby (292)", "Annalise_Friesen", new DateOnly(2017, 4, 4), new DateOnly(2014, 4, 4) },
                    { "Clothing, Electronics & Jewelery (253)", "Antonina92", new DateOnly(1985, 6, 15), new DateOnly(1982, 6, 15) },
                    { "Garden (271)", "Ayla.Reinger75", new DateOnly(2011, 5, 4), new DateOnly(2008, 5, 4) },
                    { "Music, Movies & Industrial (280)", "Benjamin93", new DateOnly(1990, 3, 25), new DateOnly(1987, 3, 25) },
                    { "Kids & Baby (287)", "Berenice28", new DateOnly(2009, 4, 13), new DateOnly(2006, 4, 13) },
                    { "Books & Sports (273)", "Betty.Cremin", new DateOnly(2016, 2, 15), new DateOnly(2013, 2, 15) },
                    { "Baby (256)", "Chelsie_McClure", new DateOnly(2022, 3, 28), new DateOnly(2019, 3, 28) },
                    { "Garden (271)", "Chester.Bartoletti", new DateOnly(1986, 11, 3), new DateOnly(1983, 11, 3) },
                    { "Electronics (251)", "Cicero_VonRueden", new DateOnly(2022, 8, 1), new DateOnly(2019, 8, 1) },
                    { "Sports, Kids & Industrial (291)", "Clay61", new DateOnly(2001, 7, 10), new DateOnly(1998, 7, 10) },
                    { "Industrial & Computers (252)", "Dahlia_Rodriguez47", new DateOnly(2009, 3, 22), new DateOnly(2006, 3, 22) },
                    { "Toys (295)", "Daisha.Aufderhar", new DateOnly(1998, 1, 18), new DateOnly(1995, 1, 18) },
                    { "Toys (259)", "Demarcus.Erdman85", new DateOnly(1981, 11, 13), new DateOnly(1978, 11, 13) },
                    { "Toys (267)", "Demetris90", new DateOnly(2003, 5, 20), new DateOnly(2000, 5, 20) },
                    { "Electronics & Jewelery (282)", "Deon_Ziemann", new DateOnly(2026, 3, 20), new DateOnly(2023, 3, 20) },
                    { "Movies & Toys (286)", "Dixie.Lueilwitz", new DateOnly(1984, 12, 27), new DateOnly(1981, 12, 27) },
                    { "Garden (262)", "Domingo.Watsica", new DateOnly(2024, 4, 21), new DateOnly(2021, 4, 21) },
                    { "Jewelery, Automotive & Garden (276)", "Dusty_Graham52", new DateOnly(2015, 6, 22), new DateOnly(2012, 6, 22) },
                    { "Games & Toys (297)", "Eldora.OKon", new DateOnly(2025, 3, 5), new DateOnly(2022, 3, 5) },
                    { "Beauty (269)", "Elizabeth_Orn73", new DateOnly(2020, 5, 4), new DateOnly(2017, 5, 4) },
                    { "Home, Movies & Shoes (272)", "Elsie_Breitenberg", new DateOnly(1998, 3, 31), new DateOnly(1995, 3, 31) },
                    { "Jewelery, Automotive & Garden (276)", "Elvera17", new DateOnly(2026, 3, 22), new DateOnly(2023, 3, 22) },
                    { "Music & Grocery (258)", "Elza.Wintheiser", new DateOnly(2001, 8, 13), new DateOnly(1998, 8, 13) },
                    { "Baby (279)", "Enrico97", new DateOnly(1992, 8, 14), new DateOnly(1989, 8, 14) },
                    { "Electronics (266)", "Eve_Champlin", new DateOnly(2021, 12, 10), new DateOnly(2018, 12, 10) },
                    { "Health, Toys & Outdoors (255)", "Ewell_Yost", new DateOnly(2025, 9, 4), new DateOnly(2022, 9, 4) },
                    { "Home (264)", "Fay_Jast43", new DateOnly(2013, 11, 23), new DateOnly(2010, 11, 23) },
                    { "Books & Sports (273)", "Filiberto4", new DateOnly(2007, 12, 4), new DateOnly(2004, 12, 4) },
                    { "Clothing, Electronics & Jewelery (253)", "Finn_Stehr26", new DateOnly(1988, 3, 12), new DateOnly(1985, 3, 12) },
                    { "Baby (279)", "Fletcher_McDermott46", new DateOnly(1987, 3, 13), new DateOnly(1984, 3, 13) },
                    { "Baby (283)", "Francis.Kunze", new DateOnly(2012, 8, 13), new DateOnly(2009, 8, 13) },
                    { "Music, Movies & Industrial (280)", "Genoveva_Volkman52", new DateOnly(2020, 11, 22), new DateOnly(2017, 11, 22) },
                    { "Movies & Toys (286)", "Gilberto.Ruecker89", new DateOnly(2007, 12, 8), new DateOnly(2004, 12, 8) },
                    { "Toys (259)", "Giovanny.Kuphal96", new DateOnly(2023, 8, 25), new DateOnly(2020, 8, 25) },
                    { "Music & Grocery (258)", "Gladyce.Doyle2", new DateOnly(2002, 4, 30), new DateOnly(1999, 4, 30) },
                    { "Home, Movies & Shoes (272)", "Grant68", new DateOnly(2008, 10, 2), new DateOnly(2005, 10, 2) },
                    { "Baby (256)", "Gregoria_Bailey", new DateOnly(1992, 9, 6), new DateOnly(1989, 9, 6) },
                    { "Movies & Toys (286)", "Hector65", new DateOnly(2024, 3, 15), new DateOnly(2021, 3, 15) },
                    { "Books (290)", "Hortense_Gerhold93", new DateOnly(1994, 8, 19), new DateOnly(1991, 8, 19) },
                    { "Health, Toys & Outdoors (255)", "Houston22", new DateOnly(2010, 9, 30), new DateOnly(2007, 9, 30) },
                    { "Games & Toys (297)", "Imelda.Sawayn26", new DateOnly(1990, 7, 31), new DateOnly(1987, 7, 31) },
                    { "Industrial & Shoes (270)", "Jacynthe43", new DateOnly(2004, 5, 22), new DateOnly(2001, 5, 22) },
                    { "Electronics (251)", "Jakayla74", new DateOnly(2009, 3, 14), new DateOnly(2006, 3, 14) },
                    { "Baby (279)", "Javier41", new DateOnly(1993, 10, 1), new DateOnly(1990, 10, 1) },
                    { "Beauty (269)", "Jenifer_Lueilwitz72", new DateOnly(1992, 12, 30), new DateOnly(1989, 12, 30) },
                    { "Books (290)", "Jessy.Lang61", new DateOnly(2007, 9, 26), new DateOnly(2004, 9, 26) },
                    { "Electronics (251)", "Jordy_Bergstrom5", new DateOnly(2006, 1, 2), new DateOnly(2003, 1, 2) },
                    { "Kids & Tools (265)", "Joshuah.Hagenes", new DateOnly(2018, 12, 4), new DateOnly(2015, 12, 4) },
                    { "Baby (279)", "Jude_Simonis67", new DateOnly(2012, 10, 10), new DateOnly(2009, 10, 10) },
                    { "Tools, Tools & Tools (284)", "Kane14", new DateOnly(2017, 10, 20), new DateOnly(2014, 10, 20) },
                    { "Electronics (251)", "Katelynn.Abshire2", new DateOnly(2020, 9, 24), new DateOnly(2017, 9, 24) },
                    { "Garden (262)", "Katrine_Daniel22", new DateOnly(2020, 7, 29), new DateOnly(2017, 7, 29) },
                    { "Baby (279)", "Kattie.Stracke74", new DateOnly(2022, 11, 4), new DateOnly(2019, 11, 4) },
                    { "Outdoors, Home & Baby (292)", "Koby_Erdman29", new DateOnly(1988, 8, 14), new DateOnly(1985, 8, 14) },
                    { "Health, Toys & Outdoors (255)", "Larue.Frami51", new DateOnly(2023, 1, 4), new DateOnly(2020, 1, 4) },
                    { "Automotive, Garden & Beauty (261)", "Lenora77", new DateOnly(2006, 4, 27), new DateOnly(2003, 4, 27) },
                    { "Beauty & Electronics (299)", "Leopoldo.Lesch", new DateOnly(2026, 9, 3), new DateOnly(2023, 9, 3) },
                    { "Industrial & Computers (252)", "Lexie_Lang", new DateOnly(2011, 6, 20), new DateOnly(2008, 6, 20) },
                    { "Tools, Tools & Tools (284)", "Lilian.McKenzie43", new DateOnly(2000, 5, 10), new DateOnly(1997, 5, 10) },
                    { "Toys, Outdoors & Toys (293)", "Mack.Schiller", new DateOnly(1996, 5, 25), new DateOnly(1993, 5, 25) },
                    { "Electronics (266)", "Margie.Klocko", new DateOnly(2005, 1, 31), new DateOnly(2002, 1, 31) },
                    { "Kids & Tools (265)", "Mariane0", new DateOnly(2025, 3, 12), new DateOnly(2022, 3, 12) },
                    { "Toys (295)", "Matteo15", new DateOnly(2013, 8, 21), new DateOnly(2010, 8, 21) },
                    { "Shoes & Kids (281)", "Melba75", new DateOnly(2017, 7, 9), new DateOnly(2014, 7, 9) },
                    { "Garden (260)", "Milan.Ratke", new DateOnly(1996, 12, 28), new DateOnly(1993, 12, 28) },
                    { "Electronics & Jewelery (282)", "Miracle_Hilpert", new DateOnly(1994, 10, 30), new DateOnly(1991, 10, 30) },
                    { "Toys (267)", "Mireille_Streich", new DateOnly(2020, 1, 18), new DateOnly(2017, 1, 18) },
                    { "Clothing, Electronics & Jewelery (253)", "Monty.Murphy93", new DateOnly(1999, 11, 6), new DateOnly(1996, 11, 6) },
                    { "Health, Toys & Outdoors (255)", "Nelson.Simonis18", new DateOnly(2019, 8, 14), new DateOnly(2016, 8, 14) },
                    { "Baby, Home & Jewelery (254)", "Nichole_Stiedemann24", new DateOnly(2022, 1, 30), new DateOnly(2019, 1, 30) },
                    { "Shoes & Kids (281)", "Nick.Boyle", new DateOnly(1993, 11, 13), new DateOnly(1990, 11, 13) },
                    { "Garden (262)", "Nina.Renner", new DateOnly(1988, 11, 7), new DateOnly(1985, 11, 7) },
                    { "Garden (262)", "Pat_Nienow13", new DateOnly(1983, 9, 20), new DateOnly(1980, 9, 20) },
                    { "Baby (283)", "Princess.Gerhold", new DateOnly(2011, 12, 25), new DateOnly(2008, 12, 25) },
                    { "Games & Toys (297)", "Rae87", new DateOnly(2018, 9, 11), new DateOnly(2015, 9, 11) },
                    { "Toys (259)", "Ricky_Haley30", new DateOnly(2024, 12, 5), new DateOnly(2021, 12, 5) },
                    { "Books & Sports (273)", "Rosa.Satterfield27", new DateOnly(2000, 6, 27), new DateOnly(1997, 6, 27) },
                    { "Beauty (296)", "Rowena.Vandervort21", new DateOnly(1999, 1, 12), new DateOnly(1996, 1, 12) },
                    { "Clothing, Electronics & Jewelery (253)", "Ruben24", new DateOnly(2005, 8, 31), new DateOnly(2002, 8, 31) },
                    { "Computers & Health (285)", "Sally29", new DateOnly(2023, 11, 4), new DateOnly(2020, 11, 4) },
                    { "Beauty & Electronics (299)", "Sandy40", new DateOnly(1994, 12, 23), new DateOnly(1991, 12, 23) },
                    { "Games & Toys (297)", "Shanna_Abernathy41", new DateOnly(2025, 4, 18), new DateOnly(2022, 4, 18) },
                    { "Books, Garden & Garden (275)", "Shirley17", new DateOnly(2008, 12, 28), new DateOnly(2005, 12, 28) },
                    { "Garden, Kids & Outdoors (289)", "Sophie_Marquardt76", new DateOnly(2022, 6, 8), new DateOnly(2019, 6, 8) },
                    { "Baby (279)", "Stan.Nader", new DateOnly(1988, 6, 20), new DateOnly(1985, 6, 20) },
                    { "Electronics (251)", "Susan48", new DateOnly(2002, 11, 17), new DateOnly(1999, 11, 17) },
                    { "Kids, Electronics & Movies (288)", "Tito29", new DateOnly(1997, 5, 21), new DateOnly(1994, 5, 21) },
                    { "Baby (283)", "Tobin.Boyle", new DateOnly(2017, 12, 31), new DateOnly(2014, 12, 31) },
                    { "Shoes & Tools (263)", "Torey.Kohler48", new DateOnly(2008, 8, 9), new DateOnly(2005, 8, 9) },
                    { "Automotive, Garden & Beauty (261)", "Vance_Stehr", new DateOnly(2020, 7, 7), new DateOnly(2017, 7, 7) },
                    { "Baby (283)", "Verna.Boehm12", new DateOnly(2016, 1, 25), new DateOnly(2013, 1, 25) },
                    { "Sports, Computers & Electronics (277)", "Viviane.Wiza", new DateOnly(2003, 12, 7), new DateOnly(2000, 12, 7) },
                    { "Industrial, Toys & Automotive (250)", "Wiley_Kohler", new DateOnly(2008, 12, 25), new DateOnly(2005, 12, 25) }
                });

            migrationBuilder.InsertData(
                table: "UserRoles",
                columns: new[] { "UserType", "Username" },
                values: new object[,]
                {
                    { 0, "Aaron79" },
                    { 0, "Allan_Dicki" },
                    { 0, "Amari.Cummerata0" },
                    { 0, "Amos28" },
                    { 0, "Annalise_Friesen" },
                    { 0, "Antonina92" },
                    { 0, "Benjamin93" },
                    { 0, "Chester.Bartoletti" },
                    { 0, "Cicero_VonRueden" },
                    { 0, "Daisha.Aufderhar" },
                    { 0, "Demarcus.Erdman85" },
                    { 0, "Demetris90" },
                    { 0, "Deon_Ziemann" },
                    { 0, "Dixie.Lueilwitz" },
                    { 0, "Eldora.OKon" },
                    { 0, "Elizabeth_Orn73" },
                    { 0, "Elsie_Breitenberg" },
                    { 0, "Elvera17" },
                    { 0, "Enrico97" },
                    { 0, "Eve_Champlin" },
                    { 0, "Fay_Jast43" },
                    { 0, "Finn_Stehr26" },
                    { 0, "Fletcher_McDermott46" },
                    { 0, "Francis.Kunze" },
                    { 0, "Genoveva_Volkman52" },
                    { 0, "Giovanny.Kuphal96" },
                    { 0, "Gladyce.Doyle2" },
                    { 0, "Grant68" },
                    { 0, "Hortense_Gerhold93" },
                    { 0, "Houston22" },
                    { 0, "Imelda.Sawayn26" },
                    { 0, "Jacynthe43" },
                    { 0, "Jakayla74" },
                    { 0, "Javier41" },
                    { 0, "Jenifer_Lueilwitz72" },
                    { 0, "Jordy_Bergstrom5" },
                    { 0, "Joshuah.Hagenes" },
                    { 0, "Kane14" },
                    { 0, "Katelynn.Abshire2" },
                    { 0, "Lenora77" },
                    { 0, "Leopoldo.Lesch" },
                    { 0, "Lexie_Lang" },
                    { 0, "Mack.Schiller" },
                    { 0, "Mariane0" },
                    { 0, "Melba75" },
                    { 0, "Milan.Ratke" },
                    { 0, "Miracle_Hilpert" },
                    { 0, "Mireille_Streich" },
                    { 0, "Nick.Boyle" },
                    { 0, "Nina.Renner" },
                    { 0, "Princess.Gerhold" },
                    { 0, "Rae87" },
                    { 0, "Ricky_Haley30" },
                    { 0, "Rosa.Satterfield27" },
                    { 0, "Sally29" },
                    { 0, "Sandy40" },
                    { 0, "Shanna_Abernathy41" },
                    { 0, "Shirley17" },
                    { 0, "Sophie_Marquardt76" },
                    { 0, "Tito29" },
                    { 0, "Tobin.Boyle" },
                    { 0, "Vance_Stehr" },
                    { 0, "Viviane.Wiza" },
                    { 0, "Wiley_Kohler" },
                    { 1, "Aaron79" },
                    { 1, "Adriana.Koepp" },
                    { 1, "Agnes45" },
                    { 1, "Amari.Cummerata0" },
                    { 1, "Amos28" },
                    { 1, "Angelita.Dooley85" },
                    { 1, "Annalise_Friesen" },
                    { 1, "Antonina92" },
                    { 1, "Ayla.Reinger75" },
                    { 1, "Benjamin93" },
                    { 1, "Berenice28" },
                    { 1, "Betty.Cremin" },
                    { 1, "Chelsie_McClure" },
                    { 1, "Chester.Bartoletti" },
                    { 1, "Cicero_VonRueden" },
                    { 1, "Clay61" },
                    { 1, "Dahlia_Rodriguez47" },
                    { 1, "Demarcus.Erdman85" },
                    { 1, "Demetris90" },
                    { 1, "Deon_Ziemann" },
                    { 1, "Dixie.Lueilwitz" },
                    { 1, "Domingo.Watsica" },
                    { 1, "Dusty_Graham52" },
                    { 1, "Eldora.OKon" },
                    { 1, "Elizabeth_Orn73" },
                    { 1, "Elsie_Breitenberg" },
                    { 1, "Elvera17" },
                    { 1, "Elza.Wintheiser" },
                    { 1, "Enrico97" },
                    { 1, "Ewell_Yost" },
                    { 1, "Filiberto4" },
                    { 1, "Finn_Stehr26" },
                    { 1, "Fletcher_McDermott46" },
                    { 1, "Francis.Kunze" },
                    { 1, "Genoveva_Volkman52" },
                    { 1, "Gilberto.Ruecker89" },
                    { 1, "Gladyce.Doyle2" },
                    { 1, "Grant68" },
                    { 1, "Gregoria_Bailey" },
                    { 1, "Hector65" },
                    { 1, "Imelda.Sawayn26" },
                    { 1, "Jacynthe43" },
                    { 1, "Jakayla74" },
                    { 1, "Javier41" },
                    { 1, "Jenifer_Lueilwitz72" },
                    { 1, "Jessy.Lang61" },
                    { 1, "Jordy_Bergstrom5" },
                    { 1, "Jude_Simonis67" },
                    { 1, "Kane14" },
                    { 1, "Katelynn.Abshire2" },
                    { 1, "Katrine_Daniel22" },
                    { 1, "Kattie.Stracke74" },
                    { 1, "Koby_Erdman29" },
                    { 1, "Larue.Frami51" },
                    { 1, "Lenora77" },
                    { 1, "Leopoldo.Lesch" },
                    { 1, "Lexie_Lang" },
                    { 1, "Lilian.McKenzie43" },
                    { 1, "Mack.Schiller" },
                    { 1, "Margie.Klocko" },
                    { 1, "Mariane0" },
                    { 1, "Matteo15" },
                    { 1, "Miracle_Hilpert" },
                    { 1, "Mireille_Streich" },
                    { 1, "Monty.Murphy93" },
                    { 1, "Nelson.Simonis18" },
                    { 1, "Nichole_Stiedemann24" },
                    { 1, "Nick.Boyle" },
                    { 1, "Nina.Renner" },
                    { 1, "Pat_Nienow13" },
                    { 1, "Princess.Gerhold" },
                    { 1, "Rae87" },
                    { 1, "Ricky_Haley30" },
                    { 1, "Rosa.Satterfield27" },
                    { 1, "Rowena.Vandervort21" },
                    { 1, "Ruben24" },
                    { 1, "Sally29" },
                    { 1, "Sandy40" },
                    { 1, "Shirley17" },
                    { 1, "Sophie_Marquardt76" },
                    { 1, "Stan.Nader" },
                    { 1, "Susan48" },
                    { 1, "Tobin.Boyle" },
                    { 1, "Torey.Kohler48" },
                    { 1, "Vance_Stehr" },
                    { 1, "Verna.Boehm12" },
                    { 1, "Viviane.Wiza" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Courses_ClassRoomAddress_ClassRoomRoomName",
                table: "Courses",
                columns: new[] { "ClassRoomAddress", "ClassRoomRoomName" });

            migrationBuilder.AddForeignKey(
                name: "FK_Courses_ClassRooms_ClassRoomAddress_ClassRoomRoomName",
                table: "Courses",
                columns: new[] { "ClassRoomAddress", "ClassRoomRoomName" },
                principalTable: "ClassRooms",
                principalColumns: new[] { "Address", "RoomNumber" },
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Courses_ClassRooms_ClassRoomAddress_ClassRoomRoomName",
                table: "Courses");

            migrationBuilder.DropIndex(
                name: "IX_Courses_ClassRoomAddress_ClassRoomRoomName",
                table: "Courses");

            migrationBuilder.DeleteData(
                table: "ClassRooms",
                keyColumns: new[] { "Address", "RoomNumber" },
                keyValues: new object[] { "0189 Kutch Haven, West Daynaborough, Brunei Darussalam", "191" });

            migrationBuilder.DeleteData(
                table: "ClassRooms",
                keyColumns: new[] { "Address", "RoomNumber" },
                keyValues: new object[] { "02511 Hermann Prairie, North Aliyahside, Benin", "179" });

            migrationBuilder.DeleteData(
                table: "ClassRooms",
                keyColumns: new[] { "Address", "RoomNumber" },
                keyValues: new object[] { "0272 Eli Stream, Trantowtown, United States Minor Outlying Islands", "278" });

            migrationBuilder.DeleteData(
                table: "ClassRooms",
                keyColumns: new[] { "Address", "RoomNumber" },
                keyValues: new object[] { "0276 Harris Spur, West Sean, Iran", "198" });

            migrationBuilder.DeleteData(
                table: "ClassRooms",
                keyColumns: new[] { "Address", "RoomNumber" },
                keyValues: new object[] { "03179 Bianka Mountains, Stefanville, Kazakhstan", "47" });

            migrationBuilder.DeleteData(
                table: "ClassRooms",
                keyColumns: new[] { "Address", "RoomNumber" },
                keyValues: new object[] { "060 Schimmel Hill, Lake Sherwood, Macao", "287" });

            migrationBuilder.DeleteData(
                table: "ClassRooms",
                keyColumns: new[] { "Address", "RoomNumber" },
                keyValues: new object[] { "06445 Turcotte Gateway, Maidashire, Saint Pierre and Miquelon", "15" });

            migrationBuilder.DeleteData(
                table: "ClassRooms",
                keyColumns: new[] { "Address", "RoomNumber" },
                keyValues: new object[] { "068 Monahan Rapid, North Cadetown, Barbados", "187" });

            migrationBuilder.DeleteData(
                table: "ClassRooms",
                keyColumns: new[] { "Address", "RoomNumber" },
                keyValues: new object[] { "081 Jalyn Union, Thompsonhaven, France", "68" });

            migrationBuilder.DeleteData(
                table: "ClassRooms",
                keyColumns: new[] { "Address", "RoomNumber" },
                keyValues: new object[] { "120 Prosacco Trafficway, South Charliefurt, Republic of Korea", "289" });

            migrationBuilder.DeleteData(
                table: "ClassRooms",
                keyColumns: new[] { "Address", "RoomNumber" },
                keyValues: new object[] { "13325 Hickle Plain, Ebertfort, Burkina Faso", "227" });

            migrationBuilder.DeleteData(
                table: "ClassRooms",
                keyColumns: new[] { "Address", "RoomNumber" },
                keyValues: new object[] { "1628 Eddie Curve, South Donald, Papua New Guinea", "21" });

            migrationBuilder.DeleteData(
                table: "ClassRooms",
                keyColumns: new[] { "Address", "RoomNumber" },
                keyValues: new object[] { "184 Dietrich Flats, Eliberg, Micronesia", "22" });

            migrationBuilder.DeleteData(
                table: "ClassRooms",
                keyColumns: new[] { "Address", "RoomNumber" },
                keyValues: new object[] { "18597 Buck Cove, East Tonyburgh, Andorra", "58" });

            migrationBuilder.DeleteData(
                table: "ClassRooms",
                keyColumns: new[] { "Address", "RoomNumber" },
                keyValues: new object[] { "18735 Beer Valley, North Alexys, Jamaica", "40" });

            migrationBuilder.DeleteData(
                table: "ClassRooms",
                keyColumns: new[] { "Address", "RoomNumber" },
                keyValues: new object[] { "193 Tad Parkways, Hartmannmouth, Mauritania", "170" });

            migrationBuilder.DeleteData(
                table: "ClassRooms",
                keyColumns: new[] { "Address", "RoomNumber" },
                keyValues: new object[] { "23973 Katrina Mills, Madisonshire, Palau", "325" });

            migrationBuilder.DeleteData(
                table: "ClassRooms",
                keyColumns: new[] { "Address", "RoomNumber" },
                keyValues: new object[] { "24163 Sasha Expressway, East Nakia, Nicaragua", "59" });

            migrationBuilder.DeleteData(
                table: "ClassRooms",
                keyColumns: new[] { "Address", "RoomNumber" },
                keyValues: new object[] { "2435 Erdman Fords, South Ebbaborough, New Zealand", "330" });

            migrationBuilder.DeleteData(
                table: "ClassRooms",
                keyColumns: new[] { "Address", "RoomNumber" },
                keyValues: new object[] { "24667 Unique Port, Port Sister, Anguilla", "180" });

            migrationBuilder.DeleteData(
                table: "ClassRooms",
                keyColumns: new[] { "Address", "RoomNumber" },
                keyValues: new object[] { "256 Bergnaum Radial, Arvelstad, Guernsey", "135" });

            migrationBuilder.DeleteData(
                table: "ClassRooms",
                keyColumns: new[] { "Address", "RoomNumber" },
                keyValues: new object[] { "261 Schaden Parks, Bennettchester, Bahrain", "301" });

            migrationBuilder.DeleteData(
                table: "ClassRooms",
                keyColumns: new[] { "Address", "RoomNumber" },
                keyValues: new object[] { "2621 Monahan Rapid, Port Kalebfort, Algeria", "318" });

            migrationBuilder.DeleteData(
                table: "ClassRooms",
                keyColumns: new[] { "Address", "RoomNumber" },
                keyValues: new object[] { "26312 Nader Crest, West Lempi, Taiwan", "73" });

            migrationBuilder.DeleteData(
                table: "ClassRooms",
                keyColumns: new[] { "Address", "RoomNumber" },
                keyValues: new object[] { "274 Bennie Prairie, Braunfort, Senegal", "226" });

            migrationBuilder.DeleteData(
                table: "ClassRooms",
                keyColumns: new[] { "Address", "RoomNumber" },
                keyValues: new object[] { "275 Bennie Spurs, Feeneytown, Comoros", "145" });

            migrationBuilder.DeleteData(
                table: "ClassRooms",
                keyColumns: new[] { "Address", "RoomNumber" },
                keyValues: new object[] { "2823 Gulgowski Vista, Lake Lucindastad, Honduras", "60" });

            migrationBuilder.DeleteData(
                table: "ClassRooms",
                keyColumns: new[] { "Address", "RoomNumber" },
                keyValues: new object[] { "2850 Hope Mission, Lake Brennaberg, Azerbaijan", "132" });

            migrationBuilder.DeleteData(
                table: "ClassRooms",
                keyColumns: new[] { "Address", "RoomNumber" },
                keyValues: new object[] { "293 Koss Alley, Jerrodmouth, Austria", "305" });

            migrationBuilder.DeleteData(
                table: "ClassRooms",
                keyColumns: new[] { "Address", "RoomNumber" },
                keyValues: new object[] { "3011 Jewel Wall, East Sandy, Christmas Island", "99" });

            migrationBuilder.DeleteData(
                table: "ClassRooms",
                keyColumns: new[] { "Address", "RoomNumber" },
                keyValues: new object[] { "3044 Beatty Village, Spencerside, Sudan", "82" });

            migrationBuilder.DeleteData(
                table: "ClassRooms",
                keyColumns: new[] { "Address", "RoomNumber" },
                keyValues: new object[] { "32133 Stracke Stream, Ollieview, Virgin Islands, U.S.", "199" });

            migrationBuilder.DeleteData(
                table: "ClassRooms",
                keyColumns: new[] { "Address", "RoomNumber" },
                keyValues: new object[] { "332 Bryce Circle, Lake Kylie, Togo", "337" });

            migrationBuilder.DeleteData(
                table: "ClassRooms",
                keyColumns: new[] { "Address", "RoomNumber" },
                keyValues: new object[] { "333 Schiller Run, Lake Darrel, Sierra Leone", "166" });

            migrationBuilder.DeleteData(
                table: "ClassRooms",
                keyColumns: new[] { "Address", "RoomNumber" },
                keyValues: new object[] { "3390 Frederick Ferry, Schmidtville, Micronesia", "26" });

            migrationBuilder.DeleteData(
                table: "ClassRooms",
                keyColumns: new[] { "Address", "RoomNumber" },
                keyValues: new object[] { "357 Carroll Shoal, North Athenaton, Ethiopia", "73" });

            migrationBuilder.DeleteData(
                table: "ClassRooms",
                keyColumns: new[] { "Address", "RoomNumber" },
                keyValues: new object[] { "35912 McDermott Extension, South Ethaborough, Kyrgyz Republic", "226" });

            migrationBuilder.DeleteData(
                table: "ClassRooms",
                keyColumns: new[] { "Address", "RoomNumber" },
                keyValues: new object[] { "362 Rolfson Run, West Adelia, Greece", "44" });

            migrationBuilder.DeleteData(
                table: "ClassRooms",
                keyColumns: new[] { "Address", "RoomNumber" },
                keyValues: new object[] { "36474 Tre Island, Schadenport, Kazakhstan", "288" });

            migrationBuilder.DeleteData(
                table: "ClassRooms",
                keyColumns: new[] { "Address", "RoomNumber" },
                keyValues: new object[] { "3684 Bode Camp, Gaylordview, Denmark", "162" });

            migrationBuilder.DeleteData(
                table: "ClassRooms",
                keyColumns: new[] { "Address", "RoomNumber" },
                keyValues: new object[] { "4028 Kris Ramp, Isabellburgh, Heard Island and McDonald Islands", "304" });

            migrationBuilder.DeleteData(
                table: "ClassRooms",
                keyColumns: new[] { "Address", "RoomNumber" },
                keyValues: new object[] { "41656 Jaiden Course, Estelville, Lithuania", "249" });

            migrationBuilder.DeleteData(
                table: "ClassRooms",
                keyColumns: new[] { "Address", "RoomNumber" },
                keyValues: new object[] { "422 Haley Expressway, Daremouth, Bermuda", "162" });

            migrationBuilder.DeleteData(
                table: "ClassRooms",
                keyColumns: new[] { "Address", "RoomNumber" },
                keyValues: new object[] { "43655 Eldridge Rapid, Franeckiton, United Arab Emirates", "160" });

            migrationBuilder.DeleteData(
                table: "ClassRooms",
                keyColumns: new[] { "Address", "RoomNumber" },
                keyValues: new object[] { "443 Verdie Groves, Bessieview, Mauritania", "47" });

            migrationBuilder.DeleteData(
                table: "ClassRooms",
                keyColumns: new[] { "Address", "RoomNumber" },
                keyValues: new object[] { "444 Kobe Vista, New Hubert, Sweden", "156" });

            migrationBuilder.DeleteData(
                table: "ClassRooms",
                keyColumns: new[] { "Address", "RoomNumber" },
                keyValues: new object[] { "457 Pfannerstill Harbors, Hermanchester, Kuwait", "38" });

            migrationBuilder.DeleteData(
                table: "ClassRooms",
                keyColumns: new[] { "Address", "RoomNumber" },
                keyValues: new object[] { "475 Kathlyn Field, Kunzebury, Bahamas", "32" });

            migrationBuilder.DeleteData(
                table: "ClassRooms",
                keyColumns: new[] { "Address", "RoomNumber" },
                keyValues: new object[] { "4887 Douglas Oval, Lake Everardo, Andorra", "343" });

            migrationBuilder.DeleteData(
                table: "ClassRooms",
                keyColumns: new[] { "Address", "RoomNumber" },
                keyValues: new object[] { "4927 Rosenbaum Glens, Douglaschester, Lesotho", "26" });

            migrationBuilder.DeleteData(
                table: "ClassRooms",
                keyColumns: new[] { "Address", "RoomNumber" },
                keyValues: new object[] { "4935 Cole Lights, Emardshire, Cocos (Keeling) Islands", "42" });

            migrationBuilder.DeleteData(
                table: "ClassRooms",
                keyColumns: new[] { "Address", "RoomNumber" },
                keyValues: new object[] { "499 Pearline Camp, South Brionnafurt, South Africa", "277" });

            migrationBuilder.DeleteData(
                table: "ClassRooms",
                keyColumns: new[] { "Address", "RoomNumber" },
                keyValues: new object[] { "4999 Pollich Hollow, South Carolanne, Grenada", "126" });

            migrationBuilder.DeleteData(
                table: "ClassRooms",
                keyColumns: new[] { "Address", "RoomNumber" },
                keyValues: new object[] { "501 Hudson Path, South Federico, Micronesia", "235" });

            migrationBuilder.DeleteData(
                table: "ClassRooms",
                keyColumns: new[] { "Address", "RoomNumber" },
                keyValues: new object[] { "527 Ledner Ville, Lianatown, Ecuador", "225" });

            migrationBuilder.DeleteData(
                table: "ClassRooms",
                keyColumns: new[] { "Address", "RoomNumber" },
                keyValues: new object[] { "5294 Dickinson Gardens, Mullerfort, Germany", "182" });

            migrationBuilder.DeleteData(
                table: "ClassRooms",
                keyColumns: new[] { "Address", "RoomNumber" },
                keyValues: new object[] { "540 Mosciski Shoal, South Rosellafort, Mayotte", "103" });

            migrationBuilder.DeleteData(
                table: "ClassRooms",
                keyColumns: new[] { "Address", "RoomNumber" },
                keyValues: new object[] { "54213 Raynor Island, Kirlinmouth, Fiji", "130" });

            migrationBuilder.DeleteData(
                table: "ClassRooms",
                keyColumns: new[] { "Address", "RoomNumber" },
                keyValues: new object[] { "54979 Malachi Track, Krajcikview, American Samoa", "122" });

            migrationBuilder.DeleteData(
                table: "ClassRooms",
                keyColumns: new[] { "Address", "RoomNumber" },
                keyValues: new object[] { "55646 Merle Rest, Oscarstad, Bahamas", "264" });

            migrationBuilder.DeleteData(
                table: "ClassRooms",
                keyColumns: new[] { "Address", "RoomNumber" },
                keyValues: new object[] { "5798 Little Viaduct, New Braedenport, Mayotte", "231" });

            migrationBuilder.DeleteData(
                table: "ClassRooms",
                keyColumns: new[] { "Address", "RoomNumber" },
                keyValues: new object[] { "5822 Streich Unions, North Tillmanside, Argentina", "203" });

            migrationBuilder.DeleteData(
                table: "ClassRooms",
                keyColumns: new[] { "Address", "RoomNumber" },
                keyValues: new object[] { "583 Tillman Falls, Bonnieshire, Gabon", "175" });

            migrationBuilder.DeleteData(
                table: "ClassRooms",
                keyColumns: new[] { "Address", "RoomNumber" },
                keyValues: new object[] { "58902 Ledner Run, Leonardofurt, Liberia", "221" });

            migrationBuilder.DeleteData(
                table: "ClassRooms",
                keyColumns: new[] { "Address", "RoomNumber" },
                keyValues: new object[] { "6037 Lakin Lock, Nicoville, Congo", "96" });

            migrationBuilder.DeleteData(
                table: "ClassRooms",
                keyColumns: new[] { "Address", "RoomNumber" },
                keyValues: new object[] { "62452 Billie Squares, New Everettview, Guyana", "75" });

            migrationBuilder.DeleteData(
                table: "ClassRooms",
                keyColumns: new[] { "Address", "RoomNumber" },
                keyValues: new object[] { "64942 Jaeden Mountains, Lehnerchester, Cameroon", "147" });

            migrationBuilder.DeleteData(
                table: "ClassRooms",
                keyColumns: new[] { "Address", "RoomNumber" },
                keyValues: new object[] { "65072 Presley Spurs, Streichstad, Angola", "218" });

            migrationBuilder.DeleteData(
                table: "ClassRooms",
                keyColumns: new[] { "Address", "RoomNumber" },
                keyValues: new object[] { "6619 Robel Crescent, New Sylviamouth, Cayman Islands", "323" });

            migrationBuilder.DeleteData(
                table: "ClassRooms",
                keyColumns: new[] { "Address", "RoomNumber" },
                keyValues: new object[] { "6713 Wyman Mill, East Antoinette, Italy", "195" });

            migrationBuilder.DeleteData(
                table: "ClassRooms",
                keyColumns: new[] { "Address", "RoomNumber" },
                keyValues: new object[] { "708 Zieme Village, Kelliberg, Uganda", "156" });

            migrationBuilder.DeleteData(
                table: "ClassRooms",
                keyColumns: new[] { "Address", "RoomNumber" },
                keyValues: new object[] { "711 Charity Shoals, Oniestad, Tunisia", "198" });

            migrationBuilder.DeleteData(
                table: "ClassRooms",
                keyColumns: new[] { "Address", "RoomNumber" },
                keyValues: new object[] { "71321 Itzel Curve, Alannaberg, Burkina Faso", "62" });

            migrationBuilder.DeleteData(
                table: "ClassRooms",
                keyColumns: new[] { "Address", "RoomNumber" },
                keyValues: new object[] { "717 Juliana Rapid, Port Elviefort, Tokelau", "303" });

            migrationBuilder.DeleteData(
                table: "ClassRooms",
                keyColumns: new[] { "Address", "RoomNumber" },
                keyValues: new object[] { "7310 Chet Wall, Lake Caleb, Somalia", "58" });

            migrationBuilder.DeleteData(
                table: "ClassRooms",
                keyColumns: new[] { "Address", "RoomNumber" },
                keyValues: new object[] { "7402 Murphy Grove, Noblefort, Tuvalu", "249" });

            migrationBuilder.DeleteData(
                table: "ClassRooms",
                keyColumns: new[] { "Address", "RoomNumber" },
                keyValues: new object[] { "753 Hoppe Field, Schroederburgh, Portugal", "184" });

            migrationBuilder.DeleteData(
                table: "ClassRooms",
                keyColumns: new[] { "Address", "RoomNumber" },
                keyValues: new object[] { "76271 Botsford Lights, South Bryana, South Africa", "349" });

            migrationBuilder.DeleteData(
                table: "ClassRooms",
                keyColumns: new[] { "Address", "RoomNumber" },
                keyValues: new object[] { "7934 Adams Lodge, South Deronbury, Colombia", "313" });

            migrationBuilder.DeleteData(
                table: "ClassRooms",
                keyColumns: new[] { "Address", "RoomNumber" },
                keyValues: new object[] { "794 Patrick Port, Zanechester, Puerto Rico", "35" });

            migrationBuilder.DeleteData(
                table: "ClassRooms",
                keyColumns: new[] { "Address", "RoomNumber" },
                keyValues: new object[] { "79430 Gleason Spur, Kunzestad, Slovenia", "175" });

            migrationBuilder.DeleteData(
                table: "ClassRooms",
                keyColumns: new[] { "Address", "RoomNumber" },
                keyValues: new object[] { "7984 Madyson Fields, New Anselland, Kazakhstan", "58" });

            migrationBuilder.DeleteData(
                table: "ClassRooms",
                keyColumns: new[] { "Address", "RoomNumber" },
                keyValues: new object[] { "80133 Norma Forge, Treutelburgh, Latvia", "99" });

            migrationBuilder.DeleteData(
                table: "ClassRooms",
                keyColumns: new[] { "Address", "RoomNumber" },
                keyValues: new object[] { "806 Olson Corners, Lake Isai, Slovakia (Slovak Republic)", "42" });

            migrationBuilder.DeleteData(
                table: "ClassRooms",
                keyColumns: new[] { "Address", "RoomNumber" },
                keyValues: new object[] { "821 Alejandrin Harbors, East Chazville, Montserrat", "306" });

            migrationBuilder.DeleteData(
                table: "ClassRooms",
                keyColumns: new[] { "Address", "RoomNumber" },
                keyValues: new object[] { "827 Klein Mountain, Mikemouth, Monaco", "229" });

            migrationBuilder.DeleteData(
                table: "ClassRooms",
                keyColumns: new[] { "Address", "RoomNumber" },
                keyValues: new object[] { "8298 Marcelino Ways, Schuylerberg, Belgium", "320" });

            migrationBuilder.DeleteData(
                table: "ClassRooms",
                keyColumns: new[] { "Address", "RoomNumber" },
                keyValues: new object[] { "832 Konopelski Terrace, Bufordmouth, Pakistan", "195" });

            migrationBuilder.DeleteData(
                table: "ClassRooms",
                keyColumns: new[] { "Address", "RoomNumber" },
                keyValues: new object[] { "851 Klein Square, North Ernesto, Slovenia", "284" });

            migrationBuilder.DeleteData(
                table: "ClassRooms",
                keyColumns: new[] { "Address", "RoomNumber" },
                keyValues: new object[] { "85848 Wisozk Course, East Aniyahaven, Dominican Republic", "323" });

            migrationBuilder.DeleteData(
                table: "ClassRooms",
                keyColumns: new[] { "Address", "RoomNumber" },
                keyValues: new object[] { "864 Trent Burgs, Garfieldfort, Virgin Islands, British", "147" });

            migrationBuilder.DeleteData(
                table: "ClassRooms",
                keyColumns: new[] { "Address", "RoomNumber" },
                keyValues: new object[] { "879 Carey Glen, South Jonathan, Switzerland", "206" });

            migrationBuilder.DeleteData(
                table: "ClassRooms",
                keyColumns: new[] { "Address", "RoomNumber" },
                keyValues: new object[] { "8841 Jacobi Unions, New Theresemouth, Swaziland", "226" });

            migrationBuilder.DeleteData(
                table: "ClassRooms",
                keyColumns: new[] { "Address", "RoomNumber" },
                keyValues: new object[] { "91230 Schoen Wells, Port Laceyville, Guatemala", "288" });

            migrationBuilder.DeleteData(
                table: "ClassRooms",
                keyColumns: new[] { "Address", "RoomNumber" },
                keyValues: new object[] { "926 Skiles Mission, Audreannechester, Antarctica (the territory South of 60 deg S)", "172" });

            migrationBuilder.DeleteData(
                table: "ClassRooms",
                keyColumns: new[] { "Address", "RoomNumber" },
                keyValues: new object[] { "962 Yvonne Trail, Wintheiserberg, Central African Republic", "63" });

            migrationBuilder.DeleteData(
                table: "ClassRooms",
                keyColumns: new[] { "Address", "RoomNumber" },
                keyValues: new object[] { "97229 Hand Turnpike, New Abagail, Ghana", "92" });

            migrationBuilder.DeleteData(
                table: "ClassRooms",
                keyColumns: new[] { "Address", "RoomNumber" },
                keyValues: new object[] { "98040 Wilderman Green, South Loraine, Kazakhstan", "340" });

            migrationBuilder.DeleteData(
                table: "ClassRooms",
                keyColumns: new[] { "Address", "RoomNumber" },
                keyValues: new object[] { "997 Neva Landing, Auershire, Gabon", "298" });

            migrationBuilder.DeleteData(
                table: "ClassRooms",
                keyColumns: new[] { "Address", "RoomNumber" },
                keyValues: new object[] { "9991 Fay Walk, Port Nelson, Angola", "90" });

            migrationBuilder.DeleteData(
                table: "DegreeParticipations",
                keyColumns: new[] { "DegreeName", "Username" },
                keyValues: new object[] { "Books (290)", "Aaron79" });

            migrationBuilder.DeleteData(
                table: "DegreeParticipations",
                keyColumns: new[] { "DegreeName", "Username" },
                keyValues: new object[] { "Clothing, Electronics & Jewelery (253)", "Adriana.Koepp" });

            migrationBuilder.DeleteData(
                table: "DegreeParticipations",
                keyColumns: new[] { "DegreeName", "Username" },
                keyValues: new object[] { "Home (264)", "Agnes45" });

            migrationBuilder.DeleteData(
                table: "DegreeParticipations",
                keyColumns: new[] { "DegreeName", "Username" },
                keyValues: new object[] { "Garden (260)", "Allan_Dicki" });

            migrationBuilder.DeleteData(
                table: "DegreeParticipations",
                keyColumns: new[] { "DegreeName", "Username" },
                keyValues: new object[] { "Kids, Electronics & Movies (288)", "Amari.Cummerata0" });

            migrationBuilder.DeleteData(
                table: "DegreeParticipations",
                keyColumns: new[] { "DegreeName", "Username" },
                keyValues: new object[] { "Electronics (266)", "Amos28" });

            migrationBuilder.DeleteData(
                table: "DegreeParticipations",
                keyColumns: new[] { "DegreeName", "Username" },
                keyValues: new object[] { "Baby (256)", "Angelita.Dooley85" });

            migrationBuilder.DeleteData(
                table: "DegreeParticipations",
                keyColumns: new[] { "DegreeName", "Username" },
                keyValues: new object[] { "Outdoors, Home & Baby (292)", "Annalise_Friesen" });

            migrationBuilder.DeleteData(
                table: "DegreeParticipations",
                keyColumns: new[] { "DegreeName", "Username" },
                keyValues: new object[] { "Clothing, Electronics & Jewelery (253)", "Antonina92" });

            migrationBuilder.DeleteData(
                table: "DegreeParticipations",
                keyColumns: new[] { "DegreeName", "Username" },
                keyValues: new object[] { "Garden (271)", "Ayla.Reinger75" });

            migrationBuilder.DeleteData(
                table: "DegreeParticipations",
                keyColumns: new[] { "DegreeName", "Username" },
                keyValues: new object[] { "Music, Movies & Industrial (280)", "Benjamin93" });

            migrationBuilder.DeleteData(
                table: "DegreeParticipations",
                keyColumns: new[] { "DegreeName", "Username" },
                keyValues: new object[] { "Kids & Baby (287)", "Berenice28" });

            migrationBuilder.DeleteData(
                table: "DegreeParticipations",
                keyColumns: new[] { "DegreeName", "Username" },
                keyValues: new object[] { "Books & Sports (273)", "Betty.Cremin" });

            migrationBuilder.DeleteData(
                table: "DegreeParticipations",
                keyColumns: new[] { "DegreeName", "Username" },
                keyValues: new object[] { "Baby (256)", "Chelsie_McClure" });

            migrationBuilder.DeleteData(
                table: "DegreeParticipations",
                keyColumns: new[] { "DegreeName", "Username" },
                keyValues: new object[] { "Garden (271)", "Chester.Bartoletti" });

            migrationBuilder.DeleteData(
                table: "DegreeParticipations",
                keyColumns: new[] { "DegreeName", "Username" },
                keyValues: new object[] { "Electronics (251)", "Cicero_VonRueden" });

            migrationBuilder.DeleteData(
                table: "DegreeParticipations",
                keyColumns: new[] { "DegreeName", "Username" },
                keyValues: new object[] { "Sports, Kids & Industrial (291)", "Clay61" });

            migrationBuilder.DeleteData(
                table: "DegreeParticipations",
                keyColumns: new[] { "DegreeName", "Username" },
                keyValues: new object[] { "Industrial & Computers (252)", "Dahlia_Rodriguez47" });

            migrationBuilder.DeleteData(
                table: "DegreeParticipations",
                keyColumns: new[] { "DegreeName", "Username" },
                keyValues: new object[] { "Toys (295)", "Daisha.Aufderhar" });

            migrationBuilder.DeleteData(
                table: "DegreeParticipations",
                keyColumns: new[] { "DegreeName", "Username" },
                keyValues: new object[] { "Toys (259)", "Demarcus.Erdman85" });

            migrationBuilder.DeleteData(
                table: "DegreeParticipations",
                keyColumns: new[] { "DegreeName", "Username" },
                keyValues: new object[] { "Toys (267)", "Demetris90" });

            migrationBuilder.DeleteData(
                table: "DegreeParticipations",
                keyColumns: new[] { "DegreeName", "Username" },
                keyValues: new object[] { "Electronics & Jewelery (282)", "Deon_Ziemann" });

            migrationBuilder.DeleteData(
                table: "DegreeParticipations",
                keyColumns: new[] { "DegreeName", "Username" },
                keyValues: new object[] { "Movies & Toys (286)", "Dixie.Lueilwitz" });

            migrationBuilder.DeleteData(
                table: "DegreeParticipations",
                keyColumns: new[] { "DegreeName", "Username" },
                keyValues: new object[] { "Garden (262)", "Domingo.Watsica" });

            migrationBuilder.DeleteData(
                table: "DegreeParticipations",
                keyColumns: new[] { "DegreeName", "Username" },
                keyValues: new object[] { "Jewelery, Automotive & Garden (276)", "Dusty_Graham52" });

            migrationBuilder.DeleteData(
                table: "DegreeParticipations",
                keyColumns: new[] { "DegreeName", "Username" },
                keyValues: new object[] { "Games & Toys (297)", "Eldora.OKon" });

            migrationBuilder.DeleteData(
                table: "DegreeParticipations",
                keyColumns: new[] { "DegreeName", "Username" },
                keyValues: new object[] { "Beauty (269)", "Elizabeth_Orn73" });

            migrationBuilder.DeleteData(
                table: "DegreeParticipations",
                keyColumns: new[] { "DegreeName", "Username" },
                keyValues: new object[] { "Home, Movies & Shoes (272)", "Elsie_Breitenberg" });

            migrationBuilder.DeleteData(
                table: "DegreeParticipations",
                keyColumns: new[] { "DegreeName", "Username" },
                keyValues: new object[] { "Jewelery, Automotive & Garden (276)", "Elvera17" });

            migrationBuilder.DeleteData(
                table: "DegreeParticipations",
                keyColumns: new[] { "DegreeName", "Username" },
                keyValues: new object[] { "Music & Grocery (258)", "Elza.Wintheiser" });

            migrationBuilder.DeleteData(
                table: "DegreeParticipations",
                keyColumns: new[] { "DegreeName", "Username" },
                keyValues: new object[] { "Baby (279)", "Enrico97" });

            migrationBuilder.DeleteData(
                table: "DegreeParticipations",
                keyColumns: new[] { "DegreeName", "Username" },
                keyValues: new object[] { "Electronics (266)", "Eve_Champlin" });

            migrationBuilder.DeleteData(
                table: "DegreeParticipations",
                keyColumns: new[] { "DegreeName", "Username" },
                keyValues: new object[] { "Health, Toys & Outdoors (255)", "Ewell_Yost" });

            migrationBuilder.DeleteData(
                table: "DegreeParticipations",
                keyColumns: new[] { "DegreeName", "Username" },
                keyValues: new object[] { "Home (264)", "Fay_Jast43" });

            migrationBuilder.DeleteData(
                table: "DegreeParticipations",
                keyColumns: new[] { "DegreeName", "Username" },
                keyValues: new object[] { "Books & Sports (273)", "Filiberto4" });

            migrationBuilder.DeleteData(
                table: "DegreeParticipations",
                keyColumns: new[] { "DegreeName", "Username" },
                keyValues: new object[] { "Clothing, Electronics & Jewelery (253)", "Finn_Stehr26" });

            migrationBuilder.DeleteData(
                table: "DegreeParticipations",
                keyColumns: new[] { "DegreeName", "Username" },
                keyValues: new object[] { "Baby (279)", "Fletcher_McDermott46" });

            migrationBuilder.DeleteData(
                table: "DegreeParticipations",
                keyColumns: new[] { "DegreeName", "Username" },
                keyValues: new object[] { "Baby (283)", "Francis.Kunze" });

            migrationBuilder.DeleteData(
                table: "DegreeParticipations",
                keyColumns: new[] { "DegreeName", "Username" },
                keyValues: new object[] { "Music, Movies & Industrial (280)", "Genoveva_Volkman52" });

            migrationBuilder.DeleteData(
                table: "DegreeParticipations",
                keyColumns: new[] { "DegreeName", "Username" },
                keyValues: new object[] { "Movies & Toys (286)", "Gilberto.Ruecker89" });

            migrationBuilder.DeleteData(
                table: "DegreeParticipations",
                keyColumns: new[] { "DegreeName", "Username" },
                keyValues: new object[] { "Toys (259)", "Giovanny.Kuphal96" });

            migrationBuilder.DeleteData(
                table: "DegreeParticipations",
                keyColumns: new[] { "DegreeName", "Username" },
                keyValues: new object[] { "Music & Grocery (258)", "Gladyce.Doyle2" });

            migrationBuilder.DeleteData(
                table: "DegreeParticipations",
                keyColumns: new[] { "DegreeName", "Username" },
                keyValues: new object[] { "Home, Movies & Shoes (272)", "Grant68" });

            migrationBuilder.DeleteData(
                table: "DegreeParticipations",
                keyColumns: new[] { "DegreeName", "Username" },
                keyValues: new object[] { "Baby (256)", "Gregoria_Bailey" });

            migrationBuilder.DeleteData(
                table: "DegreeParticipations",
                keyColumns: new[] { "DegreeName", "Username" },
                keyValues: new object[] { "Movies & Toys (286)", "Hector65" });

            migrationBuilder.DeleteData(
                table: "DegreeParticipations",
                keyColumns: new[] { "DegreeName", "Username" },
                keyValues: new object[] { "Books (290)", "Hortense_Gerhold93" });

            migrationBuilder.DeleteData(
                table: "DegreeParticipations",
                keyColumns: new[] { "DegreeName", "Username" },
                keyValues: new object[] { "Health, Toys & Outdoors (255)", "Houston22" });

            migrationBuilder.DeleteData(
                table: "DegreeParticipations",
                keyColumns: new[] { "DegreeName", "Username" },
                keyValues: new object[] { "Games & Toys (297)", "Imelda.Sawayn26" });

            migrationBuilder.DeleteData(
                table: "DegreeParticipations",
                keyColumns: new[] { "DegreeName", "Username" },
                keyValues: new object[] { "Industrial & Shoes (270)", "Jacynthe43" });

            migrationBuilder.DeleteData(
                table: "DegreeParticipations",
                keyColumns: new[] { "DegreeName", "Username" },
                keyValues: new object[] { "Electronics (251)", "Jakayla74" });

            migrationBuilder.DeleteData(
                table: "DegreeParticipations",
                keyColumns: new[] { "DegreeName", "Username" },
                keyValues: new object[] { "Baby (279)", "Javier41" });

            migrationBuilder.DeleteData(
                table: "DegreeParticipations",
                keyColumns: new[] { "DegreeName", "Username" },
                keyValues: new object[] { "Beauty (269)", "Jenifer_Lueilwitz72" });

            migrationBuilder.DeleteData(
                table: "DegreeParticipations",
                keyColumns: new[] { "DegreeName", "Username" },
                keyValues: new object[] { "Books (290)", "Jessy.Lang61" });

            migrationBuilder.DeleteData(
                table: "DegreeParticipations",
                keyColumns: new[] { "DegreeName", "Username" },
                keyValues: new object[] { "Electronics (251)", "Jordy_Bergstrom5" });

            migrationBuilder.DeleteData(
                table: "DegreeParticipations",
                keyColumns: new[] { "DegreeName", "Username" },
                keyValues: new object[] { "Kids & Tools (265)", "Joshuah.Hagenes" });

            migrationBuilder.DeleteData(
                table: "DegreeParticipations",
                keyColumns: new[] { "DegreeName", "Username" },
                keyValues: new object[] { "Baby (279)", "Jude_Simonis67" });

            migrationBuilder.DeleteData(
                table: "DegreeParticipations",
                keyColumns: new[] { "DegreeName", "Username" },
                keyValues: new object[] { "Tools, Tools & Tools (284)", "Kane14" });

            migrationBuilder.DeleteData(
                table: "DegreeParticipations",
                keyColumns: new[] { "DegreeName", "Username" },
                keyValues: new object[] { "Electronics (251)", "Katelynn.Abshire2" });

            migrationBuilder.DeleteData(
                table: "DegreeParticipations",
                keyColumns: new[] { "DegreeName", "Username" },
                keyValues: new object[] { "Garden (262)", "Katrine_Daniel22" });

            migrationBuilder.DeleteData(
                table: "DegreeParticipations",
                keyColumns: new[] { "DegreeName", "Username" },
                keyValues: new object[] { "Baby (279)", "Kattie.Stracke74" });

            migrationBuilder.DeleteData(
                table: "DegreeParticipations",
                keyColumns: new[] { "DegreeName", "Username" },
                keyValues: new object[] { "Outdoors, Home & Baby (292)", "Koby_Erdman29" });

            migrationBuilder.DeleteData(
                table: "DegreeParticipations",
                keyColumns: new[] { "DegreeName", "Username" },
                keyValues: new object[] { "Health, Toys & Outdoors (255)", "Larue.Frami51" });

            migrationBuilder.DeleteData(
                table: "DegreeParticipations",
                keyColumns: new[] { "DegreeName", "Username" },
                keyValues: new object[] { "Automotive, Garden & Beauty (261)", "Lenora77" });

            migrationBuilder.DeleteData(
                table: "DegreeParticipations",
                keyColumns: new[] { "DegreeName", "Username" },
                keyValues: new object[] { "Beauty & Electronics (299)", "Leopoldo.Lesch" });

            migrationBuilder.DeleteData(
                table: "DegreeParticipations",
                keyColumns: new[] { "DegreeName", "Username" },
                keyValues: new object[] { "Industrial & Computers (252)", "Lexie_Lang" });

            migrationBuilder.DeleteData(
                table: "DegreeParticipations",
                keyColumns: new[] { "DegreeName", "Username" },
                keyValues: new object[] { "Tools, Tools & Tools (284)", "Lilian.McKenzie43" });

            migrationBuilder.DeleteData(
                table: "DegreeParticipations",
                keyColumns: new[] { "DegreeName", "Username" },
                keyValues: new object[] { "Toys, Outdoors & Toys (293)", "Mack.Schiller" });

            migrationBuilder.DeleteData(
                table: "DegreeParticipations",
                keyColumns: new[] { "DegreeName", "Username" },
                keyValues: new object[] { "Electronics (266)", "Margie.Klocko" });

            migrationBuilder.DeleteData(
                table: "DegreeParticipations",
                keyColumns: new[] { "DegreeName", "Username" },
                keyValues: new object[] { "Kids & Tools (265)", "Mariane0" });

            migrationBuilder.DeleteData(
                table: "DegreeParticipations",
                keyColumns: new[] { "DegreeName", "Username" },
                keyValues: new object[] { "Toys (295)", "Matteo15" });

            migrationBuilder.DeleteData(
                table: "DegreeParticipations",
                keyColumns: new[] { "DegreeName", "Username" },
                keyValues: new object[] { "Shoes & Kids (281)", "Melba75" });

            migrationBuilder.DeleteData(
                table: "DegreeParticipations",
                keyColumns: new[] { "DegreeName", "Username" },
                keyValues: new object[] { "Garden (260)", "Milan.Ratke" });

            migrationBuilder.DeleteData(
                table: "DegreeParticipations",
                keyColumns: new[] { "DegreeName", "Username" },
                keyValues: new object[] { "Electronics & Jewelery (282)", "Miracle_Hilpert" });

            migrationBuilder.DeleteData(
                table: "DegreeParticipations",
                keyColumns: new[] { "DegreeName", "Username" },
                keyValues: new object[] { "Toys (267)", "Mireille_Streich" });

            migrationBuilder.DeleteData(
                table: "DegreeParticipations",
                keyColumns: new[] { "DegreeName", "Username" },
                keyValues: new object[] { "Clothing, Electronics & Jewelery (253)", "Monty.Murphy93" });

            migrationBuilder.DeleteData(
                table: "DegreeParticipations",
                keyColumns: new[] { "DegreeName", "Username" },
                keyValues: new object[] { "Health, Toys & Outdoors (255)", "Nelson.Simonis18" });

            migrationBuilder.DeleteData(
                table: "DegreeParticipations",
                keyColumns: new[] { "DegreeName", "Username" },
                keyValues: new object[] { "Baby, Home & Jewelery (254)", "Nichole_Stiedemann24" });

            migrationBuilder.DeleteData(
                table: "DegreeParticipations",
                keyColumns: new[] { "DegreeName", "Username" },
                keyValues: new object[] { "Shoes & Kids (281)", "Nick.Boyle" });

            migrationBuilder.DeleteData(
                table: "DegreeParticipations",
                keyColumns: new[] { "DegreeName", "Username" },
                keyValues: new object[] { "Garden (262)", "Nina.Renner" });

            migrationBuilder.DeleteData(
                table: "DegreeParticipations",
                keyColumns: new[] { "DegreeName", "Username" },
                keyValues: new object[] { "Garden (262)", "Pat_Nienow13" });

            migrationBuilder.DeleteData(
                table: "DegreeParticipations",
                keyColumns: new[] { "DegreeName", "Username" },
                keyValues: new object[] { "Baby (283)", "Princess.Gerhold" });

            migrationBuilder.DeleteData(
                table: "DegreeParticipations",
                keyColumns: new[] { "DegreeName", "Username" },
                keyValues: new object[] { "Games & Toys (297)", "Rae87" });

            migrationBuilder.DeleteData(
                table: "DegreeParticipations",
                keyColumns: new[] { "DegreeName", "Username" },
                keyValues: new object[] { "Toys (259)", "Ricky_Haley30" });

            migrationBuilder.DeleteData(
                table: "DegreeParticipations",
                keyColumns: new[] { "DegreeName", "Username" },
                keyValues: new object[] { "Books & Sports (273)", "Rosa.Satterfield27" });

            migrationBuilder.DeleteData(
                table: "DegreeParticipations",
                keyColumns: new[] { "DegreeName", "Username" },
                keyValues: new object[] { "Beauty (296)", "Rowena.Vandervort21" });

            migrationBuilder.DeleteData(
                table: "DegreeParticipations",
                keyColumns: new[] { "DegreeName", "Username" },
                keyValues: new object[] { "Clothing, Electronics & Jewelery (253)", "Ruben24" });

            migrationBuilder.DeleteData(
                table: "DegreeParticipations",
                keyColumns: new[] { "DegreeName", "Username" },
                keyValues: new object[] { "Computers & Health (285)", "Sally29" });

            migrationBuilder.DeleteData(
                table: "DegreeParticipations",
                keyColumns: new[] { "DegreeName", "Username" },
                keyValues: new object[] { "Beauty & Electronics (299)", "Sandy40" });

            migrationBuilder.DeleteData(
                table: "DegreeParticipations",
                keyColumns: new[] { "DegreeName", "Username" },
                keyValues: new object[] { "Games & Toys (297)", "Shanna_Abernathy41" });

            migrationBuilder.DeleteData(
                table: "DegreeParticipations",
                keyColumns: new[] { "DegreeName", "Username" },
                keyValues: new object[] { "Books, Garden & Garden (275)", "Shirley17" });

            migrationBuilder.DeleteData(
                table: "DegreeParticipations",
                keyColumns: new[] { "DegreeName", "Username" },
                keyValues: new object[] { "Garden, Kids & Outdoors (289)", "Sophie_Marquardt76" });

            migrationBuilder.DeleteData(
                table: "DegreeParticipations",
                keyColumns: new[] { "DegreeName", "Username" },
                keyValues: new object[] { "Baby (279)", "Stan.Nader" });

            migrationBuilder.DeleteData(
                table: "DegreeParticipations",
                keyColumns: new[] { "DegreeName", "Username" },
                keyValues: new object[] { "Electronics (251)", "Susan48" });

            migrationBuilder.DeleteData(
                table: "DegreeParticipations",
                keyColumns: new[] { "DegreeName", "Username" },
                keyValues: new object[] { "Kids, Electronics & Movies (288)", "Tito29" });

            migrationBuilder.DeleteData(
                table: "DegreeParticipations",
                keyColumns: new[] { "DegreeName", "Username" },
                keyValues: new object[] { "Baby (283)", "Tobin.Boyle" });

            migrationBuilder.DeleteData(
                table: "DegreeParticipations",
                keyColumns: new[] { "DegreeName", "Username" },
                keyValues: new object[] { "Shoes & Tools (263)", "Torey.Kohler48" });

            migrationBuilder.DeleteData(
                table: "DegreeParticipations",
                keyColumns: new[] { "DegreeName", "Username" },
                keyValues: new object[] { "Automotive, Garden & Beauty (261)", "Vance_Stehr" });

            migrationBuilder.DeleteData(
                table: "DegreeParticipations",
                keyColumns: new[] { "DegreeName", "Username" },
                keyValues: new object[] { "Baby (283)", "Verna.Boehm12" });

            migrationBuilder.DeleteData(
                table: "DegreeParticipations",
                keyColumns: new[] { "DegreeName", "Username" },
                keyValues: new object[] { "Sports, Computers & Electronics (277)", "Viviane.Wiza" });

            migrationBuilder.DeleteData(
                table: "DegreeParticipations",
                keyColumns: new[] { "DegreeName", "Username" },
                keyValues: new object[] { "Industrial, Toys & Automotive (250)", "Wiley_Kohler" });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "UserType", "Username" },
                keyValues: new object[] { 0, "Aaron79" });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "UserType", "Username" },
                keyValues: new object[] { 0, "Allan_Dicki" });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "UserType", "Username" },
                keyValues: new object[] { 0, "Amari.Cummerata0" });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "UserType", "Username" },
                keyValues: new object[] { 0, "Amos28" });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "UserType", "Username" },
                keyValues: new object[] { 0, "Annalise_Friesen" });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "UserType", "Username" },
                keyValues: new object[] { 0, "Antonina92" });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "UserType", "Username" },
                keyValues: new object[] { 0, "Benjamin93" });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "UserType", "Username" },
                keyValues: new object[] { 0, "Chester.Bartoletti" });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "UserType", "Username" },
                keyValues: new object[] { 0, "Cicero_VonRueden" });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "UserType", "Username" },
                keyValues: new object[] { 0, "Daisha.Aufderhar" });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "UserType", "Username" },
                keyValues: new object[] { 0, "Demarcus.Erdman85" });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "UserType", "Username" },
                keyValues: new object[] { 0, "Demetris90" });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "UserType", "Username" },
                keyValues: new object[] { 0, "Deon_Ziemann" });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "UserType", "Username" },
                keyValues: new object[] { 0, "Dixie.Lueilwitz" });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "UserType", "Username" },
                keyValues: new object[] { 0, "Eldora.OKon" });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "UserType", "Username" },
                keyValues: new object[] { 0, "Elizabeth_Orn73" });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "UserType", "Username" },
                keyValues: new object[] { 0, "Elsie_Breitenberg" });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "UserType", "Username" },
                keyValues: new object[] { 0, "Elvera17" });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "UserType", "Username" },
                keyValues: new object[] { 0, "Enrico97" });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "UserType", "Username" },
                keyValues: new object[] { 0, "Eve_Champlin" });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "UserType", "Username" },
                keyValues: new object[] { 0, "Fay_Jast43" });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "UserType", "Username" },
                keyValues: new object[] { 0, "Finn_Stehr26" });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "UserType", "Username" },
                keyValues: new object[] { 0, "Fletcher_McDermott46" });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "UserType", "Username" },
                keyValues: new object[] { 0, "Francis.Kunze" });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "UserType", "Username" },
                keyValues: new object[] { 0, "Genoveva_Volkman52" });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "UserType", "Username" },
                keyValues: new object[] { 0, "Giovanny.Kuphal96" });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "UserType", "Username" },
                keyValues: new object[] { 0, "Gladyce.Doyle2" });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "UserType", "Username" },
                keyValues: new object[] { 0, "Grant68" });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "UserType", "Username" },
                keyValues: new object[] { 0, "Hortense_Gerhold93" });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "UserType", "Username" },
                keyValues: new object[] { 0, "Houston22" });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "UserType", "Username" },
                keyValues: new object[] { 0, "Imelda.Sawayn26" });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "UserType", "Username" },
                keyValues: new object[] { 0, "Jacynthe43" });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "UserType", "Username" },
                keyValues: new object[] { 0, "Jakayla74" });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "UserType", "Username" },
                keyValues: new object[] { 0, "Javier41" });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "UserType", "Username" },
                keyValues: new object[] { 0, "Jenifer_Lueilwitz72" });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "UserType", "Username" },
                keyValues: new object[] { 0, "Jordy_Bergstrom5" });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "UserType", "Username" },
                keyValues: new object[] { 0, "Joshuah.Hagenes" });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "UserType", "Username" },
                keyValues: new object[] { 0, "Kane14" });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "UserType", "Username" },
                keyValues: new object[] { 0, "Katelynn.Abshire2" });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "UserType", "Username" },
                keyValues: new object[] { 0, "Lenora77" });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "UserType", "Username" },
                keyValues: new object[] { 0, "Leopoldo.Lesch" });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "UserType", "Username" },
                keyValues: new object[] { 0, "Lexie_Lang" });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "UserType", "Username" },
                keyValues: new object[] { 0, "Mack.Schiller" });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "UserType", "Username" },
                keyValues: new object[] { 0, "Mariane0" });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "UserType", "Username" },
                keyValues: new object[] { 0, "Melba75" });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "UserType", "Username" },
                keyValues: new object[] { 0, "Milan.Ratke" });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "UserType", "Username" },
                keyValues: new object[] { 0, "Miracle_Hilpert" });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "UserType", "Username" },
                keyValues: new object[] { 0, "Mireille_Streich" });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "UserType", "Username" },
                keyValues: new object[] { 0, "Nick.Boyle" });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "UserType", "Username" },
                keyValues: new object[] { 0, "Nina.Renner" });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "UserType", "Username" },
                keyValues: new object[] { 0, "Princess.Gerhold" });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "UserType", "Username" },
                keyValues: new object[] { 0, "Rae87" });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "UserType", "Username" },
                keyValues: new object[] { 0, "Ricky_Haley30" });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "UserType", "Username" },
                keyValues: new object[] { 0, "Rosa.Satterfield27" });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "UserType", "Username" },
                keyValues: new object[] { 0, "Sally29" });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "UserType", "Username" },
                keyValues: new object[] { 0, "Sandy40" });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "UserType", "Username" },
                keyValues: new object[] { 0, "Shanna_Abernathy41" });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "UserType", "Username" },
                keyValues: new object[] { 0, "Shirley17" });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "UserType", "Username" },
                keyValues: new object[] { 0, "Sophie_Marquardt76" });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "UserType", "Username" },
                keyValues: new object[] { 0, "Tito29" });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "UserType", "Username" },
                keyValues: new object[] { 0, "Tobin.Boyle" });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "UserType", "Username" },
                keyValues: new object[] { 0, "Vance_Stehr" });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "UserType", "Username" },
                keyValues: new object[] { 0, "Viviane.Wiza" });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "UserType", "Username" },
                keyValues: new object[] { 0, "Wiley_Kohler" });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "UserType", "Username" },
                keyValues: new object[] { 1, "Aaron79" });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "UserType", "Username" },
                keyValues: new object[] { 1, "Adriana.Koepp" });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "UserType", "Username" },
                keyValues: new object[] { 1, "Agnes45" });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "UserType", "Username" },
                keyValues: new object[] { 1, "Amari.Cummerata0" });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "UserType", "Username" },
                keyValues: new object[] { 1, "Amos28" });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "UserType", "Username" },
                keyValues: new object[] { 1, "Angelita.Dooley85" });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "UserType", "Username" },
                keyValues: new object[] { 1, "Annalise_Friesen" });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "UserType", "Username" },
                keyValues: new object[] { 1, "Antonina92" });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "UserType", "Username" },
                keyValues: new object[] { 1, "Ayla.Reinger75" });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "UserType", "Username" },
                keyValues: new object[] { 1, "Benjamin93" });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "UserType", "Username" },
                keyValues: new object[] { 1, "Berenice28" });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "UserType", "Username" },
                keyValues: new object[] { 1, "Betty.Cremin" });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "UserType", "Username" },
                keyValues: new object[] { 1, "Chelsie_McClure" });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "UserType", "Username" },
                keyValues: new object[] { 1, "Chester.Bartoletti" });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "UserType", "Username" },
                keyValues: new object[] { 1, "Cicero_VonRueden" });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "UserType", "Username" },
                keyValues: new object[] { 1, "Clay61" });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "UserType", "Username" },
                keyValues: new object[] { 1, "Dahlia_Rodriguez47" });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "UserType", "Username" },
                keyValues: new object[] { 1, "Demarcus.Erdman85" });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "UserType", "Username" },
                keyValues: new object[] { 1, "Demetris90" });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "UserType", "Username" },
                keyValues: new object[] { 1, "Deon_Ziemann" });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "UserType", "Username" },
                keyValues: new object[] { 1, "Dixie.Lueilwitz" });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "UserType", "Username" },
                keyValues: new object[] { 1, "Domingo.Watsica" });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "UserType", "Username" },
                keyValues: new object[] { 1, "Dusty_Graham52" });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "UserType", "Username" },
                keyValues: new object[] { 1, "Eldora.OKon" });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "UserType", "Username" },
                keyValues: new object[] { 1, "Elizabeth_Orn73" });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "UserType", "Username" },
                keyValues: new object[] { 1, "Elsie_Breitenberg" });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "UserType", "Username" },
                keyValues: new object[] { 1, "Elvera17" });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "UserType", "Username" },
                keyValues: new object[] { 1, "Elza.Wintheiser" });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "UserType", "Username" },
                keyValues: new object[] { 1, "Enrico97" });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "UserType", "Username" },
                keyValues: new object[] { 1, "Ewell_Yost" });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "UserType", "Username" },
                keyValues: new object[] { 1, "Filiberto4" });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "UserType", "Username" },
                keyValues: new object[] { 1, "Finn_Stehr26" });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "UserType", "Username" },
                keyValues: new object[] { 1, "Fletcher_McDermott46" });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "UserType", "Username" },
                keyValues: new object[] { 1, "Francis.Kunze" });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "UserType", "Username" },
                keyValues: new object[] { 1, "Genoveva_Volkman52" });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "UserType", "Username" },
                keyValues: new object[] { 1, "Gilberto.Ruecker89" });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "UserType", "Username" },
                keyValues: new object[] { 1, "Gladyce.Doyle2" });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "UserType", "Username" },
                keyValues: new object[] { 1, "Grant68" });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "UserType", "Username" },
                keyValues: new object[] { 1, "Gregoria_Bailey" });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "UserType", "Username" },
                keyValues: new object[] { 1, "Hector65" });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "UserType", "Username" },
                keyValues: new object[] { 1, "Imelda.Sawayn26" });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "UserType", "Username" },
                keyValues: new object[] { 1, "Jacynthe43" });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "UserType", "Username" },
                keyValues: new object[] { 1, "Jakayla74" });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "UserType", "Username" },
                keyValues: new object[] { 1, "Javier41" });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "UserType", "Username" },
                keyValues: new object[] { 1, "Jenifer_Lueilwitz72" });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "UserType", "Username" },
                keyValues: new object[] { 1, "Jessy.Lang61" });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "UserType", "Username" },
                keyValues: new object[] { 1, "Jordy_Bergstrom5" });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "UserType", "Username" },
                keyValues: new object[] { 1, "Jude_Simonis67" });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "UserType", "Username" },
                keyValues: new object[] { 1, "Kane14" });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "UserType", "Username" },
                keyValues: new object[] { 1, "Katelynn.Abshire2" });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "UserType", "Username" },
                keyValues: new object[] { 1, "Katrine_Daniel22" });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "UserType", "Username" },
                keyValues: new object[] { 1, "Kattie.Stracke74" });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "UserType", "Username" },
                keyValues: new object[] { 1, "Koby_Erdman29" });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "UserType", "Username" },
                keyValues: new object[] { 1, "Larue.Frami51" });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "UserType", "Username" },
                keyValues: new object[] { 1, "Lenora77" });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "UserType", "Username" },
                keyValues: new object[] { 1, "Leopoldo.Lesch" });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "UserType", "Username" },
                keyValues: new object[] { 1, "Lexie_Lang" });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "UserType", "Username" },
                keyValues: new object[] { 1, "Lilian.McKenzie43" });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "UserType", "Username" },
                keyValues: new object[] { 1, "Mack.Schiller" });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "UserType", "Username" },
                keyValues: new object[] { 1, "Margie.Klocko" });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "UserType", "Username" },
                keyValues: new object[] { 1, "Mariane0" });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "UserType", "Username" },
                keyValues: new object[] { 1, "Matteo15" });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "UserType", "Username" },
                keyValues: new object[] { 1, "Miracle_Hilpert" });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "UserType", "Username" },
                keyValues: new object[] { 1, "Mireille_Streich" });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "UserType", "Username" },
                keyValues: new object[] { 1, "Monty.Murphy93" });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "UserType", "Username" },
                keyValues: new object[] { 1, "Nelson.Simonis18" });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "UserType", "Username" },
                keyValues: new object[] { 1, "Nichole_Stiedemann24" });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "UserType", "Username" },
                keyValues: new object[] { 1, "Nick.Boyle" });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "UserType", "Username" },
                keyValues: new object[] { 1, "Nina.Renner" });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "UserType", "Username" },
                keyValues: new object[] { 1, "Pat_Nienow13" });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "UserType", "Username" },
                keyValues: new object[] { 1, "Princess.Gerhold" });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "UserType", "Username" },
                keyValues: new object[] { 1, "Rae87" });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "UserType", "Username" },
                keyValues: new object[] { 1, "Ricky_Haley30" });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "UserType", "Username" },
                keyValues: new object[] { 1, "Rosa.Satterfield27" });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "UserType", "Username" },
                keyValues: new object[] { 1, "Rowena.Vandervort21" });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "UserType", "Username" },
                keyValues: new object[] { 1, "Ruben24" });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "UserType", "Username" },
                keyValues: new object[] { 1, "Sally29" });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "UserType", "Username" },
                keyValues: new object[] { 1, "Sandy40" });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "UserType", "Username" },
                keyValues: new object[] { 1, "Shirley17" });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "UserType", "Username" },
                keyValues: new object[] { 1, "Sophie_Marquardt76" });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "UserType", "Username" },
                keyValues: new object[] { 1, "Stan.Nader" });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "UserType", "Username" },
                keyValues: new object[] { 1, "Susan48" });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "UserType", "Username" },
                keyValues: new object[] { 1, "Tobin.Boyle" });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "UserType", "Username" },
                keyValues: new object[] { 1, "Torey.Kohler48" });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "UserType", "Username" },
                keyValues: new object[] { 1, "Vance_Stehr" });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "UserType", "Username" },
                keyValues: new object[] { 1, "Verna.Boehm12" });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "UserType", "Username" },
                keyValues: new object[] { 1, "Viviane.Wiza" });

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Username",
                keyValue: "Aaron79");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Username",
                keyValue: "Adriana.Koepp");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Username",
                keyValue: "Agnes45");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Username",
                keyValue: "Allan_Dicki");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Username",
                keyValue: "Amari.Cummerata0");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Username",
                keyValue: "Amos28");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Username",
                keyValue: "Angelita.Dooley85");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Username",
                keyValue: "Annalise_Friesen");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Username",
                keyValue: "Antonina92");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Username",
                keyValue: "Ayla.Reinger75");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Username",
                keyValue: "Benjamin93");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Username",
                keyValue: "Berenice28");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Username",
                keyValue: "Betty.Cremin");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Username",
                keyValue: "Chelsie_McClure");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Username",
                keyValue: "Chester.Bartoletti");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Username",
                keyValue: "Cicero_VonRueden");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Username",
                keyValue: "Clay61");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Username",
                keyValue: "Dahlia_Rodriguez47");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Username",
                keyValue: "Daisha.Aufderhar");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Username",
                keyValue: "Demarcus.Erdman85");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Username",
                keyValue: "Demetris90");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Username",
                keyValue: "Deon_Ziemann");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Username",
                keyValue: "Dixie.Lueilwitz");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Username",
                keyValue: "Domingo.Watsica");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Username",
                keyValue: "Dusty_Graham52");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Username",
                keyValue: "Eldora.OKon");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Username",
                keyValue: "Elizabeth_Orn73");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Username",
                keyValue: "Elsie_Breitenberg");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Username",
                keyValue: "Elvera17");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Username",
                keyValue: "Elza.Wintheiser");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Username",
                keyValue: "Enrico97");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Username",
                keyValue: "Eve_Champlin");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Username",
                keyValue: "Ewell_Yost");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Username",
                keyValue: "Fay_Jast43");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Username",
                keyValue: "Filiberto4");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Username",
                keyValue: "Finn_Stehr26");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Username",
                keyValue: "Fletcher_McDermott46");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Username",
                keyValue: "Francis.Kunze");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Username",
                keyValue: "Genoveva_Volkman52");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Username",
                keyValue: "Gilberto.Ruecker89");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Username",
                keyValue: "Giovanny.Kuphal96");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Username",
                keyValue: "Gladyce.Doyle2");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Username",
                keyValue: "Grant68");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Username",
                keyValue: "Gregoria_Bailey");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Username",
                keyValue: "Hector65");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Username",
                keyValue: "Hortense_Gerhold93");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Username",
                keyValue: "Houston22");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Username",
                keyValue: "Imelda.Sawayn26");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Username",
                keyValue: "Jacynthe43");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Username",
                keyValue: "Jakayla74");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Username",
                keyValue: "Javier41");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Username",
                keyValue: "Jenifer_Lueilwitz72");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Username",
                keyValue: "Jessy.Lang61");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Username",
                keyValue: "Jordy_Bergstrom5");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Username",
                keyValue: "Joshuah.Hagenes");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Username",
                keyValue: "Jude_Simonis67");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Username",
                keyValue: "Kane14");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Username",
                keyValue: "Katelynn.Abshire2");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Username",
                keyValue: "Katrine_Daniel22");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Username",
                keyValue: "Kattie.Stracke74");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Username",
                keyValue: "Koby_Erdman29");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Username",
                keyValue: "Larue.Frami51");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Username",
                keyValue: "Lenora77");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Username",
                keyValue: "Leopoldo.Lesch");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Username",
                keyValue: "Lexie_Lang");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Username",
                keyValue: "Lilian.McKenzie43");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Username",
                keyValue: "Mack.Schiller");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Username",
                keyValue: "Margie.Klocko");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Username",
                keyValue: "Mariane0");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Username",
                keyValue: "Matteo15");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Username",
                keyValue: "Melba75");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Username",
                keyValue: "Milan.Ratke");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Username",
                keyValue: "Miracle_Hilpert");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Username",
                keyValue: "Mireille_Streich");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Username",
                keyValue: "Monty.Murphy93");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Username",
                keyValue: "Nelson.Simonis18");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Username",
                keyValue: "Nichole_Stiedemann24");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Username",
                keyValue: "Nick.Boyle");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Username",
                keyValue: "Nina.Renner");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Username",
                keyValue: "Pat_Nienow13");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Username",
                keyValue: "Princess.Gerhold");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Username",
                keyValue: "Rae87");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Username",
                keyValue: "Ricky_Haley30");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Username",
                keyValue: "Rosa.Satterfield27");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Username",
                keyValue: "Rowena.Vandervort21");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Username",
                keyValue: "Ruben24");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Username",
                keyValue: "Sally29");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Username",
                keyValue: "Sandy40");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Username",
                keyValue: "Shanna_Abernathy41");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Username",
                keyValue: "Shirley17");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Username",
                keyValue: "Sophie_Marquardt76");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Username",
                keyValue: "Stan.Nader");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Username",
                keyValue: "Susan48");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Username",
                keyValue: "Tito29");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Username",
                keyValue: "Tobin.Boyle");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Username",
                keyValue: "Torey.Kohler48");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Username",
                keyValue: "Vance_Stehr");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Username",
                keyValue: "Verna.Boehm12");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Username",
                keyValue: "Viviane.Wiza");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Username",
                keyValue: "Wiley_Kohler");

            migrationBuilder.DropColumn(
                name: "ExamType",
                table: "Exams");

            migrationBuilder.DropColumn(
                name: "ClassRoomAddress",
                table: "Courses");

            migrationBuilder.DropColumn(
                name: "ClassRoomRoomName",
                table: "Courses");

            migrationBuilder.DropColumn(
                name: "Hours",
                table: "Courses");

            migrationBuilder.DropColumn(
                name: "Capacity",
                table: "ClassRooms");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "ClassRooms");

            migrationBuilder.AddColumn<int>(
                name: "Capacity",
                table: "Courses",
                type: "int",
                nullable: false,
                defaultValue: 0,
                comment: "Maximum kapacitás");

            migrationBuilder.CreateTable(
                name: "CourseLocations",
                columns: table => new
                {
                    CourseCode = table.Column<string>(type: "varchar(15)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    CourseSemester = table.Column<string>(type: "varchar(6)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Address = table.Column<string>(type: "varchar(100)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    RoomName = table.Column<string>(type: "varchar(10)", nullable: false)
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
                    { "2857 Παύλος Mall, West Ελευθέριοςhaven, Armenia", "141", 3 },
                    { "299 Άγγελος Crescent, Βασιλικόςtown, Suriname", "177", 3 },
                    { "31452 Σωτήριος Ports, Ζωγράφοςton, Brunei Darussalam", "297", 0 },
                    { "318 Αθανασιάδης Mews, Βικελίδηςburgh, Suriname", "262", 0 },
                    { "327 Στέφανος Streets, Lake Ελευθέριοςmouth, Swaziland", "39", 2 },
                    { "333 Μήτζου Run, Lake Αθανάσιος, Sierra Leone", "166", 3 },
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
                    { "48878 Αλεξάνδρου Mountain, East Ιωάννηςland, Malaysia", "73", 2 },
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
                    { "868 Βικελίδης Underpass, North Παύλος, Japan", "243", 2 },
                    { "8765 Βασιλόπουλος Loop, New Αθανάσιοςshire, Syrian Arab Republic", "219", 0 },
                    { "879 Παναγιώτης Glen, South Εμμανουήλ, Switzerland", "206", 0 },
                    { "8809 Θεόδωρος Skyway, Port Αριστείδηςton, Singapore", "190", 3 },
                    { "8881 Παπακώστας Burgs, New Αριστείδης, Cuba", "93", 0 },
                    { "895 Ζωγράφος Shores, Βυζάντιοςville, China", "54", 3 },
                    { "896 Αναστάσιος Meadows, Γεώργιοςstad, Swaziland", "46", 0 },
                    { "89826 Θεόδωρος View, Lake Ευάγγελος, Pitcairn Islands", "235", 0 },
                    { "89875 Ευάγγελος Fields, New Νικόλαος, Niger", "49", 2 },
                    { "908 Μιχαηλίδης Islands, Αλέξανδροςstad, Haiti", "280", 3 },
                    { "9187 Λεωνίδας Center, New Αντώνης, Bahamas", "25", 1 },
                    { "92323 Νικόλαος Trafficway, South Παναγιώτηςfort, Virgin Islands, British", "346", 0 },
                    { "94874 Νικόλαος Ramp, Μακρήςhaven, Costa Rica", "190", 3 },
                    { "9571 Λούλης Light, Παππάςborough, Northern Mariana Islands", "206", 1 },
                    { "98003 Μαλαξός Springs, New Αλέξανδρος, Honduras", "246", 2 }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Username", "BirthDate", "BirthLocation", "Name", "PasswordHash" },
                values: new object[,]
                {
                    { "Aggelos.Aggelidoy35", new DateOnly(1978, 2, 26), "East Στέφανοςborough", "Άγγελος Μιχαηλίδης", "AQAAAAIAAYagAAAAEPy0Sa3t+0fqE5iMzp1a5B7FRWSO31WJ37yCzKu2fXCjldLH0utein9gF7o23hnu5g==" },
                    { "Aggelos6", new DateOnly(1992, 6, 19), "Μανωλάςton", "Στυλιανός Παπάζογλου", "AQAAAAIAAYagAAAAEPy0Sa3t+0fqE5iMzp1a5B7FRWSO31WJ37yCzKu2fXCjldLH0utein9gF7o23hnu5g==" },
                    { "Aggelos87", new DateOnly(1997, 9, 11), "Άγγελοςtown", "Μιχαήλ Ζαφειρόπουλος", "AQAAAAIAAYagAAAAEPy0Sa3t+0fqE5iMzp1a5B7FRWSO31WJ37yCzKu2fXCjldLH0utein9gF7o23hnu5g==" },
                    { "Aggelos_Georgiadis30", new DateOnly(2003, 12, 5), "Βασίληςmouth", "Διονύσιος Αβραμίδης", "AQAAAAIAAYagAAAAEPy0Sa3t+0fqE5iMzp1a5B7FRWSO31WJ37yCzKu2fXCjldLH0utein9gF7o23hnu5g==" },
                    { "Aleksandros.Zervos61", new DateOnly(1986, 9, 26), "Μιχαήλhaven", "Βασίλης Καραβίας", "AQAAAAIAAYagAAAAEPy0Sa3t+0fqE5iMzp1a5B7FRWSO31WJ37yCzKu2fXCjldLH0utein9gF7o23hnu5g==" },
                    { "Aleksandros41", new DateOnly(1972, 10, 1), "Αντώνηςville", "Παύλος Βαρνακιώτης", "AQAAAAIAAYagAAAAEPy0Sa3t+0fqE5iMzp1a5B7FRWSO31WJ37yCzKu2fXCjldLH0utein9gF7o23hnu5g==" },
                    { "Anastasios.Liapis89", new DateOnly(1986, 12, 8), "North Αριστείδηςburgh", "Γρηγόριος Καζαντζής", "AQAAAAIAAYagAAAAEPy0Sa3t+0fqE5iMzp1a5B7FRWSO31WJ37yCzKu2fXCjldLH0utein9gF7o23hnu5g==" },
                    { "Anastasios_Nikolakos52", new DateOnly(1999, 11, 22), "Γρηγόριοςmouth", "Στυλιανός Παπαστεφάνου", "AQAAAAIAAYagAAAAEPy0Sa3t+0fqE5iMzp1a5B7FRWSO31WJ37yCzKu2fXCjldLH0utein9gF7o23hnu5g==" },
                    { "Andreas22", new DateOnly(1989, 9, 30), "Port Σταύροςchester", "Ευστάθιος Αγγελόπουλος", "AQAAAAIAAYagAAAAEPy0Sa3t+0fqE5iMzp1a5B7FRWSO31WJ37yCzKu2fXCjldLH0utein9gF7o23hnu5g==" },
                    { "Andreas52", new DateOnly(1967, 2, 16), "New Αριστείδης", "Ευάγγελος Κρεστενίτης", "AQAAAAIAAYagAAAAEPy0Sa3t+0fqE5iMzp1a5B7FRWSO31WJ37yCzKu2fXCjldLH0utein9gF7o23hnu5g==" },
                    { "Andreas65", new DateOnly(2003, 3, 15), "Δημήτρηςbury", "Γεώργιος Βλαβιανός", "AQAAAAIAAYagAAAAEPy0Sa3t+0fqE5iMzp1a5B7FRWSO31WJ37yCzKu2fXCjldLH0utein9gF7o23hnu5g==" },
                    { "Andreas_Bikelidis33", new DateOnly(1983, 1, 27), "North Ευάγγελος", "Απόστολος Λαγός", "AQAAAAIAAYagAAAAEPy0Sa3t+0fqE5iMzp1a5B7FRWSO31WJ37yCzKu2fXCjldLH0utein9gF7o23hnu5g==" },
                    { "Antonis.Lytras", new DateOnly(1962, 6, 3), "Βουγιουκλάκηςland", "Ευστάθιος Δελή", "AQAAAAIAAYagAAAAEPy0Sa3t+0fqE5iMzp1a5B7FRWSO31WJ37yCzKu2fXCjldLH0utein9gF7o23hnu5g==" },
                    { "Antonis4", new DateOnly(1986, 12, 4), "Ευάγγελοςchester", "Αναστάσιος Γιαννόπουλος", "AQAAAAIAAYagAAAAEPy0Sa3t+0fqE5iMzp1a5B7FRWSO31WJ37yCzKu2fXCjldLH0utein9gF7o23hnu5g==" },
                    { "Antonis_Antonopoylos", new DateOnly(2000, 12, 10), "North Δημήτρης", "Στέφανος Αξιώτης", "AQAAAAIAAYagAAAAEPy0Sa3t+0fqE5iMzp1a5B7FRWSO31WJ37yCzKu2fXCjldLH0utein9gF7o23hnu5g==" },
                    { "Antonis_Diamantopoylos43", new DateOnly(1992, 11, 23), "New Ευστάθιοςshire", "Ευστάθιος Γεωργιάδης", "AQAAAAIAAYagAAAAEPy0Sa3t+0fqE5iMzp1a5B7FRWSO31WJ37yCzKu2fXCjldLH0utein9gF7o23hnu5g==" },
                    { "Antonis_Karamanlis", new DateOnly(1986, 3, 25), "South Αριστείδης", "Ανδρέας Μιχαηλίδης", "AQAAAAIAAYagAAAAEPy0Sa3t+0fqE5iMzp1a5B7FRWSO31WJ37yCzKu2fXCjldLH0utein9gF7o23hnu5g==" },
                    { "Antonis_Melioi26", new DateOnly(1967, 3, 12), "Ανδρέαςtown", "Πέτρος Αλεξίου", "AQAAAAIAAYagAAAAEPy0Sa3t+0fqE5iMzp1a5B7FRWSO31WJ37yCzKu2fXCjldLH0utein9gF7o23hnu5g==" },
                    { "Apostolos.Kypraios", new DateOnly(1975, 12, 28), "Παναγιώτηςton", "Ευάγγελος Μελετόπουλος", "AQAAAAIAAYagAAAAEPy0Sa3t+0fqE5iMzp1a5B7FRWSO31WJ37yCzKu2fXCjldLH0utein9gF7o23hnu5g==" },
                    { "Apostolos44", new DateOnly(1982, 2, 21), "Παππάςside", "Γρηγόριος Βλαβιανός", "AQAAAAIAAYagAAAAEPy0Sa3t+0fqE5iMzp1a5B7FRWSO31WJ37yCzKu2fXCjldLH0utein9gF7o23hnu5g==" },
                    { "Apostolos75", new DateOnly(1996, 7, 9), "Μιχαηλίδηςburgh", "Φώτιος Βαρουξής", "AQAAAAIAAYagAAAAEPy0Sa3t+0fqE5iMzp1a5B7FRWSO31WJ37yCzKu2fXCjldLH0utein9gF7o23hnu5g==" },
                    { "Apostolos_Daskalopoylos", new DateOnly(1973, 10, 30), "Βαρνακιώτηςtown", "Ιωάννης Δαμασκηνός", "AQAAAAIAAYagAAAAEPy0Sa3t+0fqE5iMzp1a5B7FRWSO31WJ37yCzKu2fXCjldLH0utein9gF7o23hnu5g==" },
                    { "Apostolos_Mitsotakis", new DateOnly(1999, 1, 18), "East Στέφανος", "Σταύρος Κακριδής", "AQAAAAIAAYagAAAAEPy0Sa3t+0fqE5iMzp1a5B7FRWSO31WJ37yCzKu2fXCjldLH0utein9gF7o23hnu5g==" },
                    { "Aristeidis.Aleksandroy12", new DateOnly(1995, 1, 25), "Νικόλαοςland", "Ευστάθιος Κόρακας", "AQAAAAIAAYagAAAAEPy0Sa3t+0fqE5iMzp1a5B7FRWSO31WJ37yCzKu2fXCjldLH0utein9gF7o23hnu5g==" },
                    { "Aristeidis.Papanikolaoy", new DateOnly(1982, 12, 7), "Παύλοςberg", "Χρήστος Λαμέρας", "AQAAAAIAAYagAAAAEPy0Sa3t+0fqE5iMzp1a5B7FRWSO31WJ37yCzKu2fXCjldLH0utein9gF7o23hnu5g==" },
                    { "Aristeidis_Melioi", new DateOnly(1999, 7, 7), "Μεσσηνέζηςchester", "Σωτήριος Δελή", "AQAAAAIAAYagAAAAEPy0Sa3t+0fqE5iMzp1a5B7FRWSO31WJ37yCzKu2fXCjldLH0utein9gF7o23hnu5g==" },
                    { "Basilis.Athanasioy", new DateOnly(1965, 11, 3), "Αναστασιάδηςmouth", "Άγγελος Κουρμούλης", "AQAAAAIAAYagAAAAEPy0Sa3t+0fqE5iMzp1a5B7FRWSO31WJ37yCzKu2fXCjldLH0utein9gF7o23hnu5g==" },
                    { "Basilis.Koytalianos17", new DateOnly(2000, 7, 24), "New Διονύσιοςstad", "Φώτιος Λούλης", "AQAAAAIAAYagAAAAEPy0Sa3t+0fqE5iMzp1a5B7FRWSO31WJ37yCzKu2fXCjldLH0utein9gF7o23hnu5g==" },
                    { "Basilis61", new DateOnly(1980, 7, 10), "Παναγιώτηςborough", "Αντώνης Κορομηλάς", "AQAAAAIAAYagAAAAEPy0Sa3t+0fqE5iMzp1a5B7FRWSO31WJ37yCzKu2fXCjldLH0utein9gF7o23hnu5g==" },
                    { "Basilis_Oikonomoy", new DateOnly(2001, 8, 1), "Ευάγγελοςside", "Παρασκευάς Μιχαηλίδης", "AQAAAAIAAYagAAAAEPy0Sa3t+0fqE5iMzp1a5B7FRWSO31WJ37yCzKu2fXCjldLH0utein9gF7o23hnu5g==" },
                    { "Dimitris28", new DateOnly(1988, 4, 13), "Άγγελοςland", "Στυλιανός Παπανικολάου", "AQAAAAIAAYagAAAAEPy0Sa3t+0fqE5iMzp1a5B7FRWSO31WJ37yCzKu2fXCjldLH0utein9gF7o23hnu5g==" },
                    { "Dimitris93", new DateOnly(1969, 3, 25), "West Μιχαήλ", "Κώστας Θεοδοσίου", "AQAAAAIAAYagAAAAEPy0Sa3t+0fqE5iMzp1a5B7FRWSO31WJ37yCzKu2fXCjldLH0utein9gF7o23hnu5g==" },
                    { "Dionysios.Anagnostakis", new DateOnly(1972, 11, 13), "West Αριστείδης", "Σωτήριος Μανωλάς", "AQAAAAIAAYagAAAAEPy0Sa3t+0fqE5iMzp1a5B7FRWSO31WJ37yCzKu2fXCjldLH0utein9gF7o23hnu5g==" },
                    { "Dionysios.Lytras", new DateOnly(1967, 11, 7), "Εμμανουήλmouth", "Νικόλαος Ζωγράφου", "AQAAAAIAAYagAAAAEPy0Sa3t+0fqE5iMzp1a5B7FRWSO31WJ37yCzKu2fXCjldLH0utein9gF7o23hnu5g==" },
                    { "Dionysios_Deli12", new DateOnly(1974, 12, 17), "West Εμμανουήλ", "Στέφανος Παπανδρέου", "AQAAAAIAAYagAAAAEPy0Sa3t+0fqE5iMzp1a5B7FRWSO31WJ37yCzKu2fXCjldLH0utein9gF7o23hnu5g==" },
                    { "Eleytherios.Eleytherioy", new DateOnly(1984, 1, 31), "Lake Χρήστος", "Ηλίας Βλαχόπουλος", "AQAAAAIAAYagAAAAEPy0Sa3t+0fqE5iMzp1a5B7FRWSO31WJ37yCzKu2fXCjldLH0utein9gF7o23hnu5g==" },
                    { "Eleytherios16", new DateOnly(1967, 10, 23), "Σταύροςhaven", "Εμμανουήλ Κουρμούλης", "AQAAAAIAAYagAAAAEPy0Sa3t+0fqE5iMzp1a5B7FRWSO31WJ37yCzKu2fXCjldLH0utein9gF7o23hnu5g==" },
                    { "Emmanoyil.Georgiadis", new DateOnly(1997, 12, 4), "Χρήστοςtown", "Ελευθέριος Κεδίκογλου", "AQAAAAIAAYagAAAAEPy0Sa3t+0fqE5iMzp1a5B7FRWSO31WJ37yCzKu2fXCjldLH0utein9gF7o23hnu5g==" },
                    { "Emmanoyil_Aleksioy5", new DateOnly(1985, 1, 2), "Αλεξόπουλοςland", "Ελευθέριος Βλαστός", "AQAAAAIAAYagAAAAEPy0Sa3t+0fqE5iMzp1a5B7FRWSO31WJ37yCzKu2fXCjldLH0utein9gF7o23hnu5g==" },
                    { "Emmanoyil_Koyndoyros", new DateOnly(1994, 10, 13), "Καραμανλήςmouth", "Νικόλαος Κορνάρος", "AQAAAAIAAYagAAAAEPy0Sa3t+0fqE5iMzp1a5B7FRWSO31WJ37yCzKu2fXCjldLH0utein9gF7o23hnu5g==" },
                    { "Emmanoyil_Maris67", new DateOnly(1991, 10, 10), "Ευστάθιοςton", "Στέφανος Γεωργιάδης", "AQAAAAIAAYagAAAAEPy0Sa3t+0fqE5iMzp1a5B7FRWSO31WJ37yCzKu2fXCjldLH0utein9gF7o23hnu5g==" },
                    { "Eyaggelos_Galanis52", new DateOnly(1994, 6, 22), "Port Αλέξανδροςmouth", "Στέφανος Βυζάντιος", "AQAAAAIAAYagAAAAEPy0Sa3t+0fqE5iMzp1a5B7FRWSO31WJ37yCzKu2fXCjldLH0utein9gF7o23hnu5g==" },
                    { "Eyaggelos_Koromilas73", new DateOnly(1999, 5, 4), "New Ευστάθιος", "Φώτιος Βλαχόπουλος", "AQAAAAIAAYagAAAAEPy0Sa3t+0fqE5iMzp1a5B7FRWSO31WJ37yCzKu2fXCjldLH0utein9gF7o23hnu5g==" },
                    { "Eystathios17", new DateOnly(1987, 12, 28), "Πέτροςbury", "Βασίλης Ζωγράφος", "AQAAAAIAAYagAAAAEPy0Sa3t+0fqE5iMzp1a5B7FRWSO31WJ37yCzKu2fXCjldLH0utein9gF7o23hnu5g==" },
                    { "Eystathios29", new DateOnly(2002, 11, 4), "North Κώσταςport", "Στέφανος Βλαστός", "AQAAAAIAAYagAAAAEPy0Sa3t+0fqE5iMzp1a5B7FRWSO31WJ37yCzKu2fXCjldLH0utein9gF7o23hnu5g==" },
                    { "Eystathios57", new DateOnly(1972, 2, 3), "Χαράλαμποςtown", "Ιωάννης Αβραμίδης", "AQAAAAIAAYagAAAAEPy0Sa3t+0fqE5iMzp1a5B7FRWSO31WJ37yCzKu2fXCjldLH0utein9gF7o23hnu5g==" },
                    { "Eystathios_Avramidis41", new DateOnly(2004, 4, 18), "Φώτιοςfort", "Αντώνης Κυπραίος", "AQAAAAIAAYagAAAAEPy0Sa3t+0fqE5iMzp1a5B7FRWSO31WJ37yCzKu2fXCjldLH0utein9gF7o23hnu5g==" },
                    { "Fotios90", new DateOnly(2005, 10, 10), "East Στέφανος", "Ευάγγελος Καραμανλής", "AQAAAAIAAYagAAAAEPy0Sa3t+0fqE5iMzp1a5B7FRWSO31WJ37yCzKu2fXCjldLH0utein9gF7o23hnu5g==" },
                    { "Fotios_Karavias7", new DateOnly(1978, 5, 19), "Αλέξανδροςstad", "Αθανάσιος Καλύβας", "AQAAAAIAAYagAAAAEPy0Sa3t+0fqE5iMzp1a5B7FRWSO31WJ37yCzKu2fXCjldLH0utein9gF7o23hnu5g==" },
                    { "Georgios.Eytaksias", new DateOnly(1976, 5, 31), "East Σωτήριοςmouth", "Χρήστος Θεοδοσίου", "AQAAAAIAAYagAAAAEPy0Sa3t+0fqE5iMzp1a5B7FRWSO31WJ37yCzKu2fXCjldLH0utein9gF7o23hnu5g==" },
                    { "Georgios2", new DateOnly(1999, 9, 24), "Lake Δημήτρης", "Εμμανουήλ Δημητρακόπουλος", "AQAAAAIAAYagAAAAEPy0Sa3t+0fqE5iMzp1a5B7FRWSO31WJ37yCzKu2fXCjldLH0utein9gF7o23hnu5g==" },
                    { "Georgios45", new DateOnly(2001, 6, 3), "Lake Απόστολος", "Πέτρος Λούπης", "AQAAAAIAAYagAAAAEPy0Sa3t+0fqE5iMzp1a5B7FRWSO31WJ37yCzKu2fXCjldLH0utein9gF7o23hnu5g==" },
                    { "Georgios79", new DateOnly(1965, 1, 23), "Δάβηςside", "Βασίλης Αλεξιάδης", "AQAAAAIAAYagAAAAEPy0Sa3t+0fqE5iMzp1a5B7FRWSO31WJ37yCzKu2fXCjldLH0utein9gF7o23hnu5g==" },
                    { "Georgios_Bilaetis20", new DateOnly(1966, 5, 18), "North Παναγιώτηςborough", "Αντώνης Μαλαξός", "AQAAAAIAAYagAAAAEPy0Sa3t+0fqE5iMzp1a5B7FRWSO31WJ37yCzKu2fXCjldLH0utein9gF7o23hnu5g==" },
                    { "Grigorios.Boylgaris", new DateOnly(1990, 12, 25), "East Σταύρος", "Φώτιος Κορνάρος", "AQAAAAIAAYagAAAAEPy0Sa3t+0fqE5iMzp1a5B7FRWSO31WJ37yCzKu2fXCjldLH0utein9gF7o23hnu5g==" },
                    { "Grigorios_Kontoleon41", new DateOnly(1974, 11, 1), "Κώσταςmouth", "Σταύρος Παπαϊωάννου", "AQAAAAIAAYagAAAAEPy0Sa3t+0fqE5iMzp1a5B7FRWSO31WJ37yCzKu2fXCjldLH0utein9gF7o23hnu5g==" },
                    { "Ilias.Metaksas74", new DateOnly(2001, 11, 4), "South Εμμανουήλhaven", "Αλέξανδρος Αλαβάνος", "AQAAAAIAAYagAAAAEPy0Sa3t+0fqE5iMzp1a5B7FRWSO31WJ37yCzKu2fXCjldLH0utein9gF7o23hnu5g==" },
                    { "Ilias.Zafeiropoylos86", new DateOnly(1968, 10, 13), "East Απόστολοςhaven", "Σωτήριος Αξιώτης", "AQAAAAIAAYagAAAAEPy0Sa3t+0fqE5iMzp1a5B7FRWSO31WJ37yCzKu2fXCjldLH0utein9gF7o23hnu5g==" },
                    { "Ilias_Bamvas22", new DateOnly(1999, 7, 29), "North Πέτρος", "Δημήτρης Αλεξιάδης", "AQAAAAIAAYagAAAAEPy0Sa3t+0fqE5iMzp1a5B7FRWSO31WJ37yCzKu2fXCjldLH0utein9gF7o23hnu5g==" },
                    { "Ioannis.Aygerinoseponymo0", new DateOnly(1994, 5, 8), "West Χαράλαμποςport", "Αριστείδης Βασιλικός", "AQAAAAIAAYagAAAAEPy0Sa3t+0fqE5iMzp1a5B7FRWSO31WJ37yCzKu2fXCjldLH0utein9gF7o23hnu5g==" },
                    { "Ioannis.Zappas99", new DateOnly(1977, 5, 19), "Lake Αριστείδης", "Ευστάθιος Παπάγος", "AQAAAAIAAYagAAAAEPy0Sa3t+0fqE5iMzp1a5B7FRWSO31WJ37yCzKu2fXCjldLH0utein9gF7o23hnu5g==" },
                    { "Ioannis28", new DateOnly(1978, 8, 7), "New Κώστας", "Λεωνίδας Μακρή", "AQAAAAIAAYagAAAAEPy0Sa3t+0fqE5iMzp1a5B7FRWSO31WJ37yCzKu2fXCjldLH0utein9gF7o23hnu5g==" },
                    { "Ioannis_Basilopoylos", new DateOnly(1989, 1, 28), "Port Λεωνίδας", "Δημήτρης Γιάγκος", "AQAAAAIAAYagAAAAEPy0Sa3t+0fqE5iMzp1a5B7FRWSO31WJ37yCzKu2fXCjldLH0utein9gF7o23hnu5g==" },
                    { "Kostas43", new DateOnly(2004, 6, 29), "East Θεόδωρος", "Αλέξανδρος Δασκαλόπουλος", "AQAAAAIAAYagAAAAEPy0Sa3t+0fqE5iMzp1a5B7FRWSO31WJ37yCzKu2fXCjldLH0utein9gF7o23hnu5g==" },
                    { "Kostas92", new DateOnly(1964, 6, 15), "East Ηλίας", "Αντώνης Καραμανλής", "AQAAAAIAAYagAAAAEPy0Sa3t+0fqE5iMzp1a5B7FRWSO31WJ37yCzKu2fXCjldLH0utein9gF7o23hnu5g==" },
                    { "Kostas_Byzantios65", new DateOnly(1995, 6, 12), "Ευάγγελοςville", "Πέτρος Κοτζιάς", "AQAAAAIAAYagAAAAEPy0Sa3t+0fqE5iMzp1a5B7FRWSO31WJ37yCzKu2fXCjldLH0utein9gF7o23hnu5g==" },
                    { "Mixail.Bergas85", new DateOnly(1960, 11, 13), "Παρασκευάςburgh", "Σπύρος Βασιλείου", "AQAAAAIAAYagAAAAEPy0Sa3t+0fqE5iMzp1a5B7FRWSO31WJ37yCzKu2fXCjldLH0utein9gF7o23hnu5g==" },
                    { "Mixail.Ioannoy", new DateOnly(1963, 12, 27), "Γρηγόριοςhaven", "Στέφανος Δοξαράς", "AQAAAAIAAYagAAAAEPy0Sa3t+0fqE5iMzp1a5B7FRWSO31WJ37yCzKu2fXCjldLH0utein9gF7o23hnu5g==" },
                    { "Mixail90", new DateOnly(1982, 5, 20), "Αθανασιάδηςberg", "Σπύρος Μιχαηλίδης", "AQAAAAIAAYagAAAAEPy0Sa3t+0fqE5iMzp1a5B7FRWSO31WJ37yCzKu2fXCjldLH0utein9gF7o23hnu5g==" },
                    { "Nikolaos_Boyrdoympas15", new DateOnly(1994, 8, 30), "Αλεξανδρίδηςville", "Παναγιώτης Λιάπης", "AQAAAAIAAYagAAAAEPy0Sa3t+0fqE5iMzp1a5B7FRWSO31WJ37yCzKu2fXCjldLH0utein9gF7o23hnu5g==" },
                    { "Panagiotis29", new DateOnly(1996, 4, 1), "North Ανδρέας", "Βασίλης Αντωνιάδης", "AQAAAAIAAYagAAAAEPy0Sa3t+0fqE5iMzp1a5B7FRWSO31WJ37yCzKu2fXCjldLH0utein9gF7o23hnu5g==" },
                    { "Paraskeyas.Anagnostakis", new DateOnly(1996, 12, 31), "North Σωτήριος", "Σωτήριος Θεοδοσίου", "AQAAAAIAAYagAAAAEPy0Sa3t+0fqE5iMzp1a5B7FRWSO31WJ37yCzKu2fXCjldLH0utein9gF7o23hnu5g==" },
                    { "Paylos.Giagkos", new DateOnly(1978, 10, 27), "West Στέφανοςborough", "Σωτήριος Αλεβίζος", "AQAAAAIAAYagAAAAEPy0Sa3t+0fqE5iMzp1a5B7FRWSO31WJ37yCzKu2fXCjldLH0utein9gF7o23hnu5g==" },
                    { "Paylos.Koyndoyros", new DateOnly(1967, 6, 20), "Port Ιωάννηςstad", "Παρασκευάς Αλαφούζος", "AQAAAAIAAYagAAAAEPy0Sa3t+0fqE5iMzp1a5B7FRWSO31WJ37yCzKu2fXCjldLH0utein9gF7o23hnu5g==" },
                    { "Paylos48", new DateOnly(1981, 11, 17), "West Ελευθέριος", "Άγγελος Καλαμογδάρτης", "AQAAAAIAAYagAAAAEPy0Sa3t+0fqE5iMzp1a5B7FRWSO31WJ37yCzKu2fXCjldLH0utein9gF7o23hnu5g==" },
                    { "Paylos_Kalyvas76", new DateOnly(2001, 6, 8), "Ιωαννίδηςside", "Ευάγγελος Καλογιάννης", "AQAAAAIAAYagAAAAEPy0Sa3t+0fqE5iMzp1a5B7FRWSO31WJ37yCzKu2fXCjldLH0utein9gF7o23hnu5g==" },
                    { "Petros.Blavianos51", new DateOnly(2002, 1, 4), "Κώσταςport", "Ανδρέας Αλεξίου", "AQAAAAIAAYagAAAAEPy0Sa3t+0fqE5iMzp1a5B7FRWSO31WJ37yCzKu2fXCjldLH0utein9gF7o23hnu5g==" },
                    { "Petros77", new DateOnly(1985, 4, 27), "Χαράλαμποςland", "Χρήστος Λαμπρόπουλος", "AQAAAAIAAYagAAAAEPy0Sa3t+0fqE5iMzp1a5B7FRWSO31WJ37yCzKu2fXCjldLH0utein9gF7o23hnu5g==" },
                    { "Sotirios.Germanos87", new DateOnly(1997, 4, 3), "Κομνηνόςstad", "Μιχαήλ Γεωργιάδης", "AQAAAAIAAYagAAAAEPy0Sa3t+0fqE5iMzp1a5B7FRWSO31WJ37yCzKu2fXCjldLH0utein9gF7o23hnu5g==" },
                    { "Sotirios.Kalogiannis43", new DateOnly(1979, 5, 10), "Port Λεωνίδαςport", "Αριστείδης Μιαούλης", "AQAAAAIAAYagAAAAEPy0Sa3t+0fqE5iMzp1a5B7FRWSO31WJ37yCzKu2fXCjldLH0utein9gF7o23hnu5g==" },
                    { "Sotirios.THeodosioy", new DateOnly(2005, 9, 3), "Port Αντώνης", "Βασίλης Ζαχαρίου", "AQAAAAIAAYagAAAAEPy0Sa3t+0fqE5iMzp1a5B7FRWSO31WJ37yCzKu2fXCjldLH0utein9gF7o23hnu5g==" },
                    { "Sotirios_Zervos", new DateOnly(1990, 6, 20), "Port Σωτήριοςside", "Παναγιώτης Γαλάνη", "AQAAAAIAAYagAAAAEPy0Sa3t+0fqE5iMzp1a5B7FRWSO31WJ37yCzKu2fXCjldLH0utein9gF7o23hnu5g==" },
                    { "Spyros17", new DateOnly(2005, 3, 22), "Γαλάνηburgh", "Ιωάννης Καλογιάννης", "AQAAAAIAAYagAAAAEPy0Sa3t+0fqE5iMzp1a5B7FRWSO31WJ37yCzKu2fXCjldLH0utein9gF7o23hnu5g==" },
                    { "Spyros97", new DateOnly(1971, 8, 14), "North Ιωάννης", "Άγγελος Μπότσαρης", "AQAAAAIAAYagAAAAEPy0Sa3t+0fqE5iMzp1a5B7FRWSO31WJ37yCzKu2fXCjldLH0utein9gF7o23hnu5g==" },
                    { "Spyros_Anastasiadis", new DateOnly(1977, 3, 31), "Βενιζέλοςland", "Στυλιανός Λόντος", "AQAAAAIAAYagAAAAEPy0Sa3t+0fqE5iMzp1a5B7FRWSO31WJ37yCzKu2fXCjldLH0utein9gF7o23hnu5g==" },
                    { "Stayros.Koronaios", new DateOnly(1976, 5, 20), "East Αναστάσιος", "Αθανάσιος Μακρής", "AQAAAAIAAYagAAAAEPy0Sa3t+0fqE5iMzp1a5B7FRWSO31WJ37yCzKu2fXCjldLH0utein9gF7o23hnu5g==" },
                    { "Stayros_Bergas29", new DateOnly(1967, 8, 14), "Απόστολοςstad", "Θεόδωρος Θεοδοσίου", "AQAAAAIAAYagAAAAEPy0Sa3t+0fqE5iMzp1a5B7FRWSO31WJ37yCzKu2fXCjldLH0utein9gF7o23hnu5g==" },
                    { "Stefanos.Loypis27", new DateOnly(1979, 6, 27), "West Πέτροςfort", "Δημήτρης Κυπραίος", "AQAAAAIAAYagAAAAEPy0Sa3t+0fqE5iMzp1a5B7FRWSO31WJ37yCzKu2fXCjldLH0utein9gF7o23hnu5g==" },
                    { "Stefanos.Nikolaidis21", new DateOnly(1978, 1, 12), "East Νικόλαοςberg", "Ευστάθιος Αγγελίδης", "AQAAAAIAAYagAAAAEPy0Sa3t+0fqE5iMzp1a5B7FRWSO31WJ37yCzKu2fXCjldLH0utein9gF7o23hnu5g==" },
                    { "Stylianos.Basileiadis", new DateOnly(1973, 1, 27), "Lake Αντώνης", "Άγγελος Μιαούλης", "AQAAAAIAAYagAAAAEPy0Sa3t+0fqE5iMzp1a5B7FRWSO31WJ37yCzKu2fXCjldLH0utein9gF7o23hnu5g==" },
                    { "Stylianos.Mitzoy", new DateOnly(1975, 5, 25), "Άγγελοςfort", "Αθανάσιος Παπαστεφάνου", "AQAAAAIAAYagAAAAEPy0Sa3t+0fqE5iMzp1a5B7FRWSO31WJ37yCzKu2fXCjldLH0utein9gF7o23hnu5g==" },
                    { "THeodoros.Basileiadis2", new DateOnly(1981, 4, 30), "Port Αναστάσιοςmouth", "Βασίλης Διδασκάλου", "AQAAAAIAAYagAAAAEPy0Sa3t+0fqE5iMzp1a5B7FRWSO31WJ37yCzKu2fXCjldLH0utein9gF7o23hnu5g==" },
                    { "THeodoros.Zafeiropoylos96", new DateOnly(2002, 8, 25), "New Παρασκευάς", "Ανδρέας Ανδρέου", "AQAAAAIAAYagAAAAEPy0Sa3t+0fqE5iMzp1a5B7FRWSO31WJ37yCzKu2fXCjldLH0utein9gF7o23hnu5g==" },
                    { "THeodoros68", new DateOnly(1987, 10, 2), "South Σπύρος", "Θεόδωρος Βέργας", "AQAAAAIAAYagAAAAEPy0Sa3t+0fqE5iMzp1a5B7FRWSO31WJ37yCzKu2fXCjldLH0utein9gF7o23hnu5g==" },
                    { "Xaralampos43", new DateOnly(1983, 5, 22), "West Ευστάθιος", "Κώστας Κασιδιάρης", "AQAAAAIAAYagAAAAEPy0Sa3t+0fqE5iMzp1a5B7FRWSO31WJ37yCzKu2fXCjldLH0utein9gF7o23hnu5g==" },
                    { "Xaralampos68", new DateOnly(1980, 9, 6), "South Βασίληςhaven", "Νικόλαος Ευταξίας", "AQAAAAIAAYagAAAAEPy0Sa3t+0fqE5iMzp1a5B7FRWSO31WJ37yCzKu2fXCjldLH0utein9gF7o23hnu5g==" },
                    { "Xaralampos74", new DateOnly(1988, 3, 14), "New Ανδρέας", "Βασίλης Δημητρίου", "AQAAAAIAAYagAAAAEPy0Sa3t+0fqE5iMzp1a5B7FRWSO31WJ37yCzKu2fXCjldLH0utein9gF7o23hnu5g==" },
                    { "Xristos.Aggelopoylos", new DateOnly(1977, 1, 18), "Αλεβιζόπουλοςside", "Γρηγόριος Ζαφειρόπουλος", "AQAAAAIAAYagAAAAEPy0Sa3t+0fqE5iMzp1a5B7FRWSO31WJ37yCzKu2fXCjldLH0utein9gF7o23hnu5g==" },
                    { "Xristos80", new DateOnly(1992, 6, 6), "New Γεώργιοςville", "Ανδρέας Κόρακας", "AQAAAAIAAYagAAAAEPy0Sa3t+0fqE5iMzp1a5B7FRWSO31WJ37yCzKu2fXCjldLH0utein9gF7o23hnu5g==" },
                    { "Xristos85", new DateOnly(1993, 8, 21), "Γεώργιοςmouth", "Αλέξανδρος Ελευθεριάδης", "AQAAAAIAAYagAAAAEPy0Sa3t+0fqE5iMzp1a5B7FRWSO31WJ37yCzKu2fXCjldLH0utein9gF7o23hnu5g==" }
                });

            migrationBuilder.InsertData(
                table: "DegreeParticipations",
                columns: new[] { "DegreeName", "Username", "EndDate", "StartDate" },
                values: new object[,]
                {
                    { "Games & Toys (297)", "Aggelos.Aggelidoy35", new DateOnly(1999, 2, 26), new DateOnly(1996, 2, 26) },
                    { "Electronics (266)", "Aggelos6", new DateOnly(2013, 6, 19), new DateOnly(2010, 6, 19) },
                    { "Games & Toys (297)", "Aggelos87", new DateOnly(2018, 9, 11), new DateOnly(2015, 9, 11) },
                    { "Toys (259)", "Aggelos_Georgiadis30", new DateOnly(2024, 12, 5), new DateOnly(2021, 12, 5) },
                    { "Books (290)", "Aleksandros.Zervos61", new DateOnly(2007, 9, 26), new DateOnly(2004, 9, 26) },
                    { "Baby (279)", "Aleksandros41", new DateOnly(1993, 10, 1), new DateOnly(1990, 10, 1) },
                    { "Movies & Toys (286)", "Anastasios.Liapis89", new DateOnly(2007, 12, 8), new DateOnly(2004, 12, 8) },
                    { "Music, Movies & Industrial (280)", "Anastasios_Nikolakos52", new DateOnly(2020, 11, 22), new DateOnly(2017, 11, 22) },
                    { "Health, Toys & Outdoors (255)", "Andreas22", new DateOnly(2010, 9, 30), new DateOnly(2007, 9, 30) },
                    { "Garden (271)", "Andreas52", new DateOnly(1988, 2, 16), new DateOnly(1985, 2, 16) },
                    { "Movies & Toys (286)", "Andreas65", new DateOnly(2024, 3, 15), new DateOnly(2021, 3, 15) },
                    { "Shoes & Toys (268)", "Andreas_Bikelidis33", new DateOnly(2004, 1, 27), new DateOnly(2001, 1, 27) },
                    { "Jewelery, Automotive & Garden (276)", "Antonis.Lytras", new DateOnly(1983, 6, 3), new DateOnly(1980, 6, 3) },
                    { "Books & Sports (273)", "Antonis4", new DateOnly(2007, 12, 4), new DateOnly(2004, 12, 4) },
                    { "Electronics (266)", "Antonis_Antonopoylos", new DateOnly(2021, 12, 10), new DateOnly(2018, 12, 10) },
                    { "Home (264)", "Antonis_Diamantopoylos43", new DateOnly(2013, 11, 23), new DateOnly(2010, 11, 23) },
                    { "Industrial, Toys & Automotive (250)", "Antonis_Karamanlis", new DateOnly(2007, 3, 25), new DateOnly(2004, 3, 25) },
                    { "Clothing, Electronics & Jewelery (253)", "Antonis_Melioi26", new DateOnly(1988, 3, 12), new DateOnly(1985, 3, 12) },
                    { "Garden (260)", "Apostolos.Kypraios", new DateOnly(1996, 12, 28), new DateOnly(1993, 12, 28) },
                    { "Kids & Tools (265)", "Apostolos44", new DateOnly(2003, 2, 21), new DateOnly(2000, 2, 21) },
                    { "Shoes & Kids (281)", "Apostolos75", new DateOnly(2017, 7, 9), new DateOnly(2014, 7, 9) },
                    { "Electronics & Jewelery (282)", "Apostolos_Daskalopoylos", new DateOnly(1994, 10, 30), new DateOnly(1991, 10, 30) },
                    { "Toys (267)", "Apostolos_Mitsotakis", new DateOnly(2020, 1, 18), new DateOnly(2017, 1, 18) },
                    { "Baby (283)", "Aristeidis.Aleksandroy12", new DateOnly(2016, 1, 25), new DateOnly(2013, 1, 25) },
                    { "Sports, Computers & Electronics (277)", "Aristeidis.Papanikolaoy", new DateOnly(2003, 12, 7), new DateOnly(2000, 12, 7) },
                    { "Automotive, Garden & Beauty (261)", "Aristeidis_Melioi", new DateOnly(2020, 7, 7), new DateOnly(2017, 7, 7) },
                    { "Garden (271)", "Basilis.Athanasioy", new DateOnly(1986, 11, 3), new DateOnly(1983, 11, 3) },
                    { "Sports, Computers & Electronics (277)", "Basilis.Koytalianos17", new DateOnly(2021, 7, 24), new DateOnly(2018, 7, 24) },
                    { "Sports, Kids & Industrial (291)", "Basilis61", new DateOnly(2001, 7, 10), new DateOnly(1998, 7, 10) },
                    { "Electronics (251)", "Basilis_Oikonomoy", new DateOnly(2022, 8, 1), new DateOnly(2019, 8, 1) },
                    { "Kids & Baby (287)", "Dimitris28", new DateOnly(2009, 4, 13), new DateOnly(2006, 4, 13) },
                    { "Music, Movies & Industrial (280)", "Dimitris93", new DateOnly(1990, 3, 25), new DateOnly(1987, 3, 25) },
                    { "Shoes & Kids (281)", "Dionysios.Anagnostakis", new DateOnly(1993, 11, 13), new DateOnly(1990, 11, 13) },
                    { "Garden (262)", "Dionysios.Lytras", new DateOnly(1988, 11, 7), new DateOnly(1985, 11, 7) },
                    { "Books (290)", "Dionysios_Deli12", new DateOnly(1995, 12, 17), new DateOnly(1992, 12, 17) },
                    { "Electronics (266)", "Eleytherios.Eleytherioy", new DateOnly(2005, 1, 31), new DateOnly(2002, 1, 31) },
                    { "Sports (274)", "Eleytherios16", new DateOnly(1988, 10, 23), new DateOnly(1985, 10, 23) },
                    { "Kids & Tools (265)", "Emmanoyil.Georgiadis", new DateOnly(2018, 12, 4), new DateOnly(2015, 12, 4) },
                    { "Electronics (251)", "Emmanoyil_Aleksioy5", new DateOnly(2006, 1, 2), new DateOnly(2003, 1, 2) },
                    { "Toys (267)", "Emmanoyil_Koyndoyros", new DateOnly(2015, 10, 13), new DateOnly(2012, 10, 13) },
                    { "Baby (279)", "Emmanoyil_Maris67", new DateOnly(2012, 10, 10), new DateOnly(2009, 10, 10) },
                    { "Jewelery, Automotive & Garden (276)", "Eyaggelos_Galanis52", new DateOnly(2015, 6, 22), new DateOnly(2012, 6, 22) },
                    { "Beauty (269)", "Eyaggelos_Koromilas73", new DateOnly(2020, 5, 4), new DateOnly(2017, 5, 4) },
                    { "Books, Garden & Garden (275)", "Eystathios17", new DateOnly(2008, 12, 28), new DateOnly(2005, 12, 28) },
                    { "Computers & Health (285)", "Eystathios29", new DateOnly(2023, 11, 4), new DateOnly(2020, 11, 4) },
                    { "Shoes & Kids (281)", "Eystathios57", new DateOnly(1993, 2, 3), new DateOnly(1990, 2, 3) },
                    { "Games & Toys (297)", "Eystathios_Avramidis41", new DateOnly(2025, 4, 18), new DateOnly(2022, 4, 18) },
                    { "Baby (283)", "Fotios90", new DateOnly(2026, 10, 10), new DateOnly(2023, 10, 10) },
                    { "Garden (271)", "Fotios_Karavias7", new DateOnly(1999, 5, 19), new DateOnly(1996, 5, 19) },
                    { "Clothing, Electronics & Jewelery (253)", "Georgios.Eytaksias", new DateOnly(1997, 5, 31), new DateOnly(1994, 5, 31) },
                    { "Electronics (251)", "Georgios2", new DateOnly(2020, 9, 24), new DateOnly(2017, 9, 24) },
                    { "Home (264)", "Georgios45", new DateOnly(2022, 6, 3), new DateOnly(2019, 6, 3) },
                    { "Books (290)", "Georgios79", new DateOnly(1986, 1, 23), new DateOnly(1983, 1, 23) },
                    { "Kids, Electronics & Movies (288)", "Georgios_Bilaetis20", new DateOnly(1987, 5, 18), new DateOnly(1984, 5, 18) },
                    { "Baby (283)", "Grigorios.Boylgaris", new DateOnly(2011, 12, 25), new DateOnly(2008, 12, 25) },
                    { "Baby (283)", "Grigorios_Kontoleon41", new DateOnly(1995, 11, 1), new DateOnly(1992, 11, 1) },
                    { "Baby (279)", "Ilias.Metaksas74", new DateOnly(2022, 11, 4), new DateOnly(2019, 11, 4) },
                    { "Kids & Tools (265)", "Ilias.Zafeiropoylos86", new DateOnly(1989, 10, 13), new DateOnly(1986, 10, 13) },
                    { "Garden (262)", "Ilias_Bamvas22", new DateOnly(2020, 7, 29), new DateOnly(2017, 7, 29) },
                    { "Kids, Electronics & Movies (288)", "Ioannis.Aygerinoseponymo0", new DateOnly(2015, 5, 8), new DateOnly(2012, 5, 8) },
                    { "Books (257)", "Ioannis.Zappas99", new DateOnly(1998, 5, 19), new DateOnly(1995, 5, 19) },
                    { "Electronics (266)", "Ioannis28", new DateOnly(1999, 8, 7), new DateOnly(1996, 8, 7) },
                    { "Garden (260)", "Ioannis_Basilopoylos", new DateOnly(2010, 1, 28), new DateOnly(2007, 1, 28) },
                    { "Industrial, Toys & Automotive (250)", "Kostas43", new DateOnly(2025, 6, 29), new DateOnly(2022, 6, 29) },
                    { "Clothing, Electronics & Jewelery (253)", "Kostas92", new DateOnly(1985, 6, 15), new DateOnly(1982, 6, 15) },
                    { "Jewelery, Automotive & Garden (276)", "Kostas_Byzantios65", new DateOnly(2016, 6, 12), new DateOnly(2013, 6, 12) },
                    { "Toys (259)", "Mixail.Bergas85", new DateOnly(1981, 11, 13), new DateOnly(1978, 11, 13) },
                    { "Movies & Toys (286)", "Mixail.Ioannoy", new DateOnly(1984, 12, 27), new DateOnly(1981, 12, 27) },
                    { "Toys (267)", "Mixail90", new DateOnly(2003, 5, 20), new DateOnly(2000, 5, 20) },
                    { "Beauty & Electronics (299)", "Nikolaos_Boyrdoympas15", new DateOnly(2015, 8, 30), new DateOnly(2012, 8, 30) },
                    { "Computers, Toys & Beauty (278)", "Panagiotis29", new DateOnly(2017, 4, 1), new DateOnly(2014, 4, 1) },
                    { "Baby (283)", "Paraskeyas.Anagnostakis", new DateOnly(2017, 12, 31), new DateOnly(2014, 12, 31) },
                    { "Books (257)", "Paylos.Giagkos", new DateOnly(1999, 10, 27), new DateOnly(1996, 10, 27) },
                    { "Baby (279)", "Paylos.Koyndoyros", new DateOnly(1988, 6, 20), new DateOnly(1985, 6, 20) },
                    { "Electronics (251)", "Paylos48", new DateOnly(2002, 11, 17), new DateOnly(1999, 11, 17) },
                    { "Garden, Kids & Outdoors (289)", "Paylos_Kalyvas76", new DateOnly(2022, 6, 8), new DateOnly(2019, 6, 8) },
                    { "Health, Toys & Outdoors (255)", "Petros.Blavianos51", new DateOnly(2023, 1, 4), new DateOnly(2020, 1, 4) },
                    { "Automotive, Garden & Beauty (261)", "Petros77", new DateOnly(2006, 4, 27), new DateOnly(2003, 4, 27) },
                    { "Shoes & Toys (268)", "Sotirios.Germanos87", new DateOnly(2018, 4, 3), new DateOnly(2015, 4, 3) },
                    { "Tools, Tools & Tools (284)", "Sotirios.Kalogiannis43", new DateOnly(2000, 5, 10), new DateOnly(1997, 5, 10) },
                    { "Beauty & Electronics (299)", "Sotirios.THeodosioy", new DateOnly(2026, 9, 3), new DateOnly(2023, 9, 3) },
                    { "Industrial & Computers (252)", "Sotirios_Zervos", new DateOnly(2011, 6, 20), new DateOnly(2008, 6, 20) },
                    { "Jewelery, Automotive & Garden (276)", "Spyros17", new DateOnly(2026, 3, 22), new DateOnly(2023, 3, 22) },
                    { "Baby (279)", "Spyros97", new DateOnly(1992, 8, 14), new DateOnly(1989, 8, 14) },
                    { "Home, Movies & Shoes (272)", "Spyros_Anastasiadis", new DateOnly(1998, 3, 31), new DateOnly(1995, 3, 31) },
                    { "Garden (262)", "Stayros.Koronaios", new DateOnly(1997, 5, 20), new DateOnly(1994, 5, 20) },
                    { "Outdoors, Home & Baby (292)", "Stayros_Bergas29", new DateOnly(1988, 8, 14), new DateOnly(1985, 8, 14) },
                    { "Books & Sports (273)", "Stefanos.Loypis27", new DateOnly(2000, 6, 27), new DateOnly(1997, 6, 27) },
                    { "Beauty (296)", "Stefanos.Nikolaidis21", new DateOnly(1999, 1, 12), new DateOnly(1996, 1, 12) },
                    { "Tools, Tools & Tools (284)", "Stylianos.Basileiadis", new DateOnly(1994, 1, 27), new DateOnly(1991, 1, 27) },
                    { "Toys, Outdoors & Toys (293)", "Stylianos.Mitzoy", new DateOnly(1996, 5, 25), new DateOnly(1993, 5, 25) },
                    { "Music & Grocery (258)", "THeodoros.Basileiadis2", new DateOnly(2002, 4, 30), new DateOnly(1999, 4, 30) },
                    { "Toys (259)", "THeodoros.Zafeiropoylos96", new DateOnly(2023, 8, 25), new DateOnly(2020, 8, 25) },
                    { "Home, Movies & Shoes (272)", "THeodoros68", new DateOnly(2008, 10, 2), new DateOnly(2005, 10, 2) },
                    { "Industrial & Shoes (270)", "Xaralampos43", new DateOnly(2004, 5, 22), new DateOnly(2001, 5, 22) },
                    { "Sports, Computers & Electronics (277)", "Xaralampos68", new DateOnly(2001, 9, 6), new DateOnly(1998, 9, 6) },
                    { "Electronics (251)", "Xaralampos74", new DateOnly(2009, 3, 14), new DateOnly(2006, 3, 14) },
                    { "Toys (295)", "Xristos.Aggelopoylos", new DateOnly(1998, 1, 18), new DateOnly(1995, 1, 18) },
                    { "Baby, Home & Jewelery (254)", "Xristos80", new DateOnly(2013, 6, 6), new DateOnly(2010, 6, 6) },
                    { "Electronics (251)", "Xristos85", new DateOnly(2014, 8, 21), new DateOnly(2011, 8, 21) }
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
                    { 0, "Andreas_Bikelidis33" },
                    { 0, "Antonis_Antonopoylos" },
                    { 0, "Antonis_Diamantopoylos43" },
                    { 0, "Antonis_Melioi26" },
                    { 0, "Apostolos.Kypraios" },
                    { 0, "Apostolos44" },
                    { 0, "Apostolos75" },
                    { 0, "Apostolos_Daskalopoylos" },
                    { 0, "Apostolos_Mitsotakis" },
                    { 0, "Aristeidis.Papanikolaoy" },
                    { 0, "Aristeidis_Melioi" },
                    { 0, "Basilis.Athanasioy" },
                    { 0, "Basilis.Koytalianos17" },
                    { 0, "Basilis_Oikonomoy" },
                    { 0, "Dimitris93" },
                    { 0, "Dionysios.Anagnostakis" },
                    { 0, "Dionysios.Lytras" },
                    { 0, "Dionysios_Deli12" },
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
                    { 0, "Paylos.Giagkos" },
                    { 0, "Paylos_Kalyvas76" },
                    { 0, "Petros77" },
                    { 0, "Sotirios.Germanos87" },
                    { 0, "Sotirios.THeodosioy" },
                    { 0, "Sotirios_Zervos" },
                    { 0, "Spyros17" },
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
                    { 1, "Anastasios.Liapis89" },
                    { 1, "Anastasios_Nikolakos52" },
                    { 1, "Andreas65" },
                    { 1, "Andreas_Bikelidis33" },
                    { 1, "Antonis.Lytras" },
                    { 1, "Antonis4" },
                    { 1, "Antonis_Karamanlis" },
                    { 1, "Antonis_Melioi26" },
                    { 1, "Apostolos_Daskalopoylos" },
                    { 1, "Apostolos_Mitsotakis" },
                    { 1, "Aristeidis.Aleksandroy12" },
                    { 1, "Aristeidis.Papanikolaoy" },
                    { 1, "Aristeidis_Melioi" },
                    { 1, "Basilis.Athanasioy" },
                    { 1, "Basilis.Koytalianos17" },
                    { 1, "Basilis61" },
                    { 1, "Basilis_Oikonomoy" },
                    { 1, "Dimitris28" },
                    { 1, "Dimitris93" },
                    { 1, "Dionysios.Anagnostakis" },
                    { 1, "Dionysios.Lytras" },
                    { 1, "Dionysios_Deli12" },
                    { 1, "Eleytherios.Eleytherioy" },
                    { 1, "Eleytherios16" },
                    { 1, "Emmanoyil_Aleksioy5" },
                    { 1, "Emmanoyil_Koyndoyros" },
                    { 1, "Emmanoyil_Maris67" },
                    { 1, "Eyaggelos_Galanis52" },
                    { 1, "Eyaggelos_Koromilas73" },
                    { 1, "Eystathios17" },
                    { 1, "Eystathios29" },
                    { 1, "Eystathios57" },
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
                    { 1, "Ilias_Bamvas22" },
                    { 1, "Ioannis.Aygerinoseponymo0" },
                    { 1, "Ioannis28" },
                    { 1, "Kostas43" },
                    { 1, "Kostas92" },
                    { 1, "Kostas_Byzantios65" },
                    { 1, "Mixail.Bergas85" },
                    { 1, "Mixail.Ioannoy" },
                    { 1, "Mixail90" },
                    { 1, "Panagiotis29" },
                    { 1, "Paraskeyas.Anagnostakis" },
                    { 1, "Paylos.Koyndoyros" },
                    { 1, "Paylos48" },
                    { 1, "Paylos_Kalyvas76" },
                    { 1, "Petros.Blavianos51" },
                    { 1, "Petros77" },
                    { 1, "Sotirios.Kalogiannis43" },
                    { 1, "Sotirios.THeodosioy" },
                    { 1, "Sotirios_Zervos" },
                    { 1, "Spyros17" },
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
                name: "IX_CourseLocations_Address_RoomName",
                table: "CourseLocations",
                columns: new[] { "Address", "RoomName" });
        }
    }
}