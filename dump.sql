-- MySQL dump 10.13  Distrib 8.0.19, for Win64 (x86_64)
--
-- Host: localhost    Database: abbeadando
-- ------------------------------------------------------
-- Server version	5.5.5-10.4.28-MariaDB

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!50503 SET NAMES utf8mb4 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Table structure for table `__efmigrationshistory`
--

DROP TABLE IF EXISTS `__efmigrationshistory`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `__efmigrationshistory` (
  `MigrationId` varchar(150) NOT NULL,
  `ProductVersion` varchar(32) NOT NULL,
  PRIMARY KEY (`MigrationId`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `__efmigrationshistory`
--

LOCK TABLES `__efmigrationshistory` WRITE;
/*!40000 ALTER TABLE `__efmigrationshistory` DISABLE KEYS */;
/*!40000 ALTER TABLE `__efmigrationshistory` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `classrooms`
--

DROP TABLE IF EXISTS `classrooms`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `classrooms` (
  `Address` varchar(100) NOT NULL COMMENT 'Cím',
  `RoomNumber` varchar(10) NOT NULL COMMENT 'Terem száma',
  `RoomType` int(11) NOT NULL COMMENT 'Terem típusa (enum)',
  `Name` longtext NOT NULL COMMENT 'Terem neve',
  `Capacity` int(11) NOT NULL COMMENT 'Terem férohely',
  PRIMARY KEY (`Address`,`RoomNumber`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `classrooms`
--

LOCK TABLES `classrooms` WRITE;
/*!40000 ALTER TABLE `classrooms` DISABLE KEYS */;
INSERT INTO `classrooms` VALUES ('0189 Kutch Haven, West Daynaborough, Brunei Darussalam','191',3,'Rustic Soft Chips',38),('02511 Hermann Prairie, North Aliyahside, Benin','179',1,'Incredible Concrete Tuna',397),('0272 Eli Stream, Trantowtown, United States Minor Outlying Islands','278',2,'Gorgeous Plastic Pants',252),('0276 Harris Spur, West Sean, Iran','198',2,'Tasty Frozen Computer',259),('03179 Bianka Mountains, Stefanville, Kazakhstan','47',3,'Fantastic Soft Bacon',24),('060 Schimmel Hill, Lake Sherwood, Macao','287',3,'Ergonomic Soft Bike',202),('06445 Turcotte Gateway, Maidashire, Saint Pierre and Miquelon','15',3,'Ergonomic Frozen Chair',578),('068 Monahan Rapid, North Cadetown, Barbados','187',1,'Gorgeous Rubber Chair',173),('081 Jalyn Union, Thompsonhaven, France','68',3,'Practical Rubber Ball',396),('120 Prosacco Trafficway, South Charliefurt, Republic of Korea','289',1,'Sleek Plastic Chicken',289),('13325 Hickle Plain, Ebertfort, Burkina Faso','227',2,'Rustic Metal Table',483),('1628 Eddie Curve, South Donald, Papua New Guinea','21',0,'Awesome Frozen Chair',207),('184 Dietrich Flats, Eliberg, Micronesia','22',3,'Intelligent Metal Computer',222),('18597 Buck Cove, East Tonyburgh, Andorra','58',3,'Handcrafted Fresh Shoes',540),('18735 Beer Valley, North Alexys, Jamaica','40',3,'Awesome Cotton Table',455),('193 Tad Parkways, Hartmannmouth, Mauritania','170',0,'Handcrafted Rubber Chicken',306),('23973 Katrina Mills, Madisonshire, Palau','325',0,'Awesome Plastic Salad',378),('24163 Sasha Expressway, East Nakia, Nicaragua','59',1,'Licensed Cotton Chicken',605),('2435 Erdman Fords, South Ebbaborough, New Zealand','330',0,'Handmade Rubber Fish',25),('24667 Unique Port, Port Sister, Anguilla','180',3,'Incredible Wooden Pizza',172),('256 Bergnaum Radial, Arvelstad, Guernsey','135',1,'Rustic Steel Pants',168),('261 Schaden Parks, Bennettchester, Bahrain','301',0,'Handmade Fresh Tuna',477),('2621 Monahan Rapid, Port Kalebfort, Algeria','318',3,'Ergonomic Plastic Bacon',438),('26312 Nader Crest, West Lempi, Taiwan','73',1,'Gorgeous Cotton Pants',197),('274 Bennie Prairie, Braunfort, Senegal','226',1,'Incredible Plastic Hat',411),('275 Bennie Spurs, Feeneytown, Comoros','145',2,'Incredible Granite Keyboard',350),('2823 Gulgowski Vista, Lake Lucindastad, Honduras','60',0,'Fantastic Metal Hat',323),('2850 Hope Mission, Lake Brennaberg, Azerbaijan','132',0,'Rustic Granite Salad',535),('293 Koss Alley, Jerrodmouth, Austria','305',0,'Generic Wooden Bacon',120),('3011 Jewel Wall, East Sandy, Christmas Island','99',1,'Sleek Plastic Salad',308),('3044 Beatty Village, Spencerside, Sudan','82',1,'Generic Plastic Bacon',501),('32133 Stracke Stream, Ollieview, Virgin Islands, U.S.','199',3,'Licensed Wooden Pizza',245),('332 Bryce Circle, Lake Kylie, Togo','337',3,'Small Fresh Pizza',119),('333 Schiller Run, Lake Darrel, Sierra Leone','166',1,'Licensed Granite Keyboard',442),('3390 Frederick Ferry, Schmidtville, Micronesia','26',1,'Small Soft Chicken',27),('357 Carroll Shoal, North Athenaton, Ethiopia','73',1,'Gorgeous Fresh Ball',173),('35912 McDermott Extension, South Ethaborough, Kyrgyz Republic','226',3,'Licensed Fresh Chicken',477),('362 Rolfson Run, West Adelia, Greece','44',3,'Handcrafted Concrete Salad',496),('36474 Tre Island, Schadenport, Kazakhstan','288',3,'Handmade Frozen Soap',418),('3684 Bode Camp, Gaylordview, Denmark','162',0,'Ergonomic Granite Pants',55),('4028 Kris Ramp, Isabellburgh, Heard Island and McDonald Islands','304',3,'Gorgeous Soft Shirt',618),('41656 Jaiden Course, Estelville, Lithuania','249',3,'Refined Metal Towels',71),('422 Haley Expressway, Daremouth, Bermuda','162',2,'Licensed Wooden Tuna',381),('43655 Eldridge Rapid, Franeckiton, United Arab Emirates','160',1,'Rustic Rubber Computer',667),('443 Verdie Groves, Bessieview, Mauritania','47',0,'Awesome Wooden Pizza',652),('444 Kobe Vista, New Hubert, Sweden','156',2,'Refined Cotton Shoes',669),('457 Pfannerstill Harbors, Hermanchester, Kuwait','38',3,'Refined Cotton Chips',202),('475 Kathlyn Field, Kunzebury, Bahamas','32',1,'Practical Wooden Sausages',275),('4887 Douglas Oval, Lake Everardo, Andorra','343',1,'Handcrafted Steel Bike',317),('4927 Rosenbaum Glens, Douglaschester, Lesotho','26',2,'Tasty Rubber Keyboard',132),('4935 Cole Lights, Emardshire, Cocos (Keeling) Islands','42',0,'Tasty Granite Sausages',351),('499 Pearline Camp, South Brionnafurt, South Africa','277',0,'Gorgeous Metal Pants',627),('4999 Pollich Hollow, South Carolanne, Grenada','126',3,'Gorgeous Rubber Fish',63),('501 Hudson Path, South Federico, Micronesia','235',0,'Refined Steel Chair',223),('527 Ledner Ville, Lianatown, Ecuador','225',0,'Licensed Rubber Cheese',237),('5294 Dickinson Gardens, Mullerfort, Germany','182',3,'Awesome Metal Sausages',493),('540 Mosciski Shoal, South Rosellafort, Mayotte','103',0,'Intelligent Granite Sausages',408),('54213 Raynor Island, Kirlinmouth, Fiji','130',1,'Tasty Concrete Chair',579),('54979 Malachi Track, Krajcikview, American Samoa','122',1,'Refined Cotton Hat',84),('55646 Merle Rest, Oscarstad, Bahamas','264',1,'Generic Fresh Table',279),('5798 Little Viaduct, New Braedenport, Mayotte','231',0,'Refined Wooden Salad',223),('5822 Streich Unions, North Tillmanside, Argentina','203',1,'Gorgeous Concrete Fish',307),('583 Tillman Falls, Bonnieshire, Gabon','175',1,'Sleek Cotton Gloves',293),('58902 Ledner Run, Leonardofurt, Liberia','221',1,'Generic Cotton Computer',638),('6037 Lakin Lock, Nicoville, Congo','96',0,'Fantastic Granite Sausages',616),('62452 Billie Squares, New Everettview, Guyana','75',1,'Tasty Concrete Computer',613),('64942 Jaeden Mountains, Lehnerchester, Cameroon','147',1,'Handcrafted Fresh Car',649),('65072 Presley Spurs, Streichstad, Angola','218',1,'Small Wooden Tuna',248),('6619 Robel Crescent, New Sylviamouth, Cayman Islands','323',3,'Sleek Fresh Cheese',469),('6713 Wyman Mill, East Antoinette, Italy','195',1,'Fantastic Steel Tuna',408),('708 Zieme Village, Kelliberg, Uganda','156',0,'Licensed Soft Ball',397),('711 Charity Shoals, Oniestad, Tunisia','198',2,'Practical Plastic Mouse',209),('71321 Itzel Curve, Alannaberg, Burkina Faso','62',3,'Licensed Soft Cheese',615),('717 Juliana Rapid, Port Elviefort, Tokelau','303',0,'Licensed Concrete Keyboard',517),('7310 Chet Wall, Lake Caleb, Somalia','58',3,'Gorgeous Frozen Sausages',160),('7402 Murphy Grove, Noblefort, Tuvalu','249',2,'Fantastic Soft Fish',25),('753 Hoppe Field, Schroederburgh, Portugal','184',1,'Rustic Wooden Keyboard',339),('76271 Botsford Lights, South Bryana, South Africa','349',0,'Awesome Fresh Chips',378),('7934 Adams Lodge, South Deronbury, Colombia','313',0,'Sleek Soft Towels',699),('794 Patrick Port, Zanechester, Puerto Rico','35',2,'Licensed Steel Computer',147),('79430 Gleason Spur, Kunzestad, Slovenia','175',2,'Gorgeous Wooden Towels',670),('7984 Madyson Fields, New Anselland, Kazakhstan','58',1,'Handmade Frozen Mouse',533),('80133 Norma Forge, Treutelburgh, Latvia','99',0,'Generic Steel Soap',270),('806 Olson Corners, Lake Isai, Slovakia (Slovak Republic)','42',1,'Unbranded Cotton Pants',322),('821 Alejandrin Harbors, East Chazville, Montserrat','306',3,'Unbranded Granite Car',509),('827 Klein Mountain, Mikemouth, Monaco','229',3,'Incredible Granite Gloves',392),('8298 Marcelino Ways, Schuylerberg, Belgium','320',0,'Practical Metal Hat',653),('832 Konopelski Terrace, Bufordmouth, Pakistan','195',3,'Refined Steel Towels',326),('851 Klein Square, North Ernesto, Slovenia','284',2,'Practical Frozen Chair',606),('85848 Wisozk Course, East Aniyahaven, Dominican Republic','323',3,'Gorgeous Fresh Pizza',323),('864 Trent Burgs, Garfieldfort, Virgin Islands, British','147',3,'Awesome Cotton Bacon',140),('879 Carey Glen, South Jonathan, Switzerland','206',1,'Intelligent Metal Shirt',688),('8841 Jacobi Unions, New Theresemouth, Swaziland','226',3,'Generic Wooden Chicken',594),('91230 Schoen Wells, Port Laceyville, Guatemala','288',0,'Refined Steel Car',244),('926 Skiles Mission, Audreannechester, Antarctica (the territory South of 60 deg S)','172',2,'Intelligent Fresh Chips',64),('962 Yvonne Trail, Wintheiserberg, Central African Republic','63',2,'Practical Concrete Chicken',247),('97229 Hand Turnpike, New Abagail, Ghana','92',2,'Refined Concrete Fish',57),('98040 Wilderman Green, South Loraine, Kazakhstan','340',3,'Ergonomic Metal Bike',435),('997 Neva Landing, Auershire, Gabon','298',1,'Fantastic Rubber Soap',419),('9991 Fay Walk, Port Nelson, Angola','90',2,'Incredible Metal Shirt',559);
/*!40000 ALTER TABLE `classrooms` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `courseattendances`
--

DROP TABLE IF EXISTS `courseattendances`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `courseattendances` (
  `Username` varchar(32) NOT NULL,
  `CourseCode` varchar(15) NOT NULL,
  `CourseSemester` varchar(6) NOT NULL,
  `AttendanceType` int(11) NOT NULL COMMENT 'Részvétel típusa (hallgató, oktató)',
  `Grade` longtext DEFAULT NULL COMMENT 'Elért érdemjegy',
  PRIMARY KEY (`Username`,`CourseCode`,`CourseSemester`),
  KEY `IX_CourseAttendances_CourseCode_CourseSemester` (`CourseCode`,`CourseSemester`),
  CONSTRAINT `FK_CourseAttendances_Courses_CourseCode_CourseSemester` FOREIGN KEY (`CourseCode`, `CourseSemester`) REFERENCES `courses` (`CourseCode`, `Semester`) ON DELETE CASCADE,
  CONSTRAINT `FK_CourseAttendances_Users_Username` FOREIGN KEY (`Username`) REFERENCES `users` (`Username`) ON DELETE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `courseattendances`
--

LOCK TABLES `courseattendances` WRITE;
/*!40000 ALTER TABLE `courseattendances` DISABLE KEYS */;
INSERT INTO `courseattendances` VALUES ('abcdef','abc','2021/1',1,NULL),('abcdef','abc','2023/1',0,NULL),('Nichole_Stiedemann24','abc','2021/1',0,NULL),('oktato','A kurzus 2','2023/1',0,NULL),('oktato','abcdef','2023/1',0,NULL),('tanulo','abc','2021/1',1,NULL),('tanulo','abc2','2023/1',1,NULL);
/*!40000 ALTER TABLE `courseattendances` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `coursemetadatas`
--

DROP TABLE IF EXISTS `coursemetadatas`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `coursemetadatas` (
  `CourseCode` varchar(15) NOT NULL COMMENT 'Kurzus kódja',
  `Type` int(11) NOT NULL COMMENT 'Kurzus típusa',
  `Name` longtext NOT NULL COMMENT 'Kurzus neve',
  PRIMARY KEY (`CourseCode`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `coursemetadatas`
--

LOCK TABLES `coursemetadatas` WRITE;
/*!40000 ALTER TABLE `coursemetadatas` DISABLE KEYS */;
INSERT INTO `coursemetadatas` VALUES ('A kurzus',2,'Teszt kurzus 3333'),('A kurzus 2',2,'Teszt kurzus 3333'),('abc',1,'Teszt kurzus'),('abc2',0,'Teszt kurzus2'),('abc3',2,'Teszt kurzus 3333'),('abcdef',1,'Legjobb kurzus');
/*!40000 ALTER TABLE `coursemetadatas` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `courses`
--

DROP TABLE IF EXISTS `courses`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `courses` (
  `CourseCode` varchar(15) NOT NULL COMMENT 'Kurzus kódja',
  `Semester` varchar(6) NOT NULL COMMENT 'Aktuális félév',
  `Credits` int(11) NOT NULL COMMENT 'Tárgy kreditszáma',
  `Hours` int(11) NOT NULL COMMENT 'Kurzus heti óraszáma',
  `ClassRoomAddress` varchar(100) NOT NULL,
  `ClassRoomRoomName` varchar(10) NOT NULL,
  PRIMARY KEY (`CourseCode`,`Semester`),
  KEY `IX_Courses_ClassRoomAddress_ClassRoomRoomName` (`ClassRoomAddress`,`ClassRoomRoomName`),
  CONSTRAINT `FK_Courses_ClassRooms_ClassRoomAddress_ClassRoomRoomName` FOREIGN KEY (`ClassRoomAddress`, `ClassRoomRoomName`) REFERENCES `classrooms` (`Address`, `RoomNumber`) ON DELETE CASCADE,
  CONSTRAINT `FK_Courses_CourseMetadatas_CourseCode` FOREIGN KEY (`CourseCode`) REFERENCES `coursemetadatas` (`CourseCode`) ON DELETE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `courses`
--

LOCK TABLES `courses` WRITE;
/*!40000 ALTER TABLE `courses` DISABLE KEYS */;
INSERT INTO `courses` VALUES ('A kurzus','2024/1',3,2,'03179 Bianka Mountains, Stefanville, Kazakhstan','47'),('A kurzus 2','2023/1',10,60,'7934 Adams Lodge, South Deronbury, Colombia','313'),('A kurzus 2','2024/2',3,2,'03179 Bianka Mountains, Stefanville, Kazakhstan','47'),('abc','2021/1',2,2,'0189 Kutch Haven, West Daynaborough, Brunei Darussalam','191'),('abc','2023/1',1,2,'0189 Kutch Haven, West Daynaborough, Brunei Darussalam','191'),('abc2','2023/1',3,1,'0189 Kutch Haven, West Daynaborough, Brunei Darussalam','191'),('abcdef','2023/1',2,2,'7310 Chet Wall, Lake Caleb, Somalia','58');
/*!40000 ALTER TABLE `courses` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `degree`
--

DROP TABLE IF EXISTS `degree`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `degree` (
  `Name` varchar(255) NOT NULL COMMENT 'Képzés neve',
  `Level` int(11) NOT NULL COMMENT 'Képzés szintje',
  PRIMARY KEY (`Name`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `degree`
--

LOCK TABLES `degree` WRITE;
/*!40000 ALTER TABLE `degree` DISABLE KEYS */;
INSERT INTO `degree` VALUES ('Automotive, Garden & Beauty (261)',3),('Baby (256)',1),('Baby (279)',0),('Baby (283)',2),('Baby, Home & Jewelery (254)',2),('Beauty & Electronics (299)',3),('Beauty (269)',1),('Beauty (296)',1),('Books & Sports (273)',0),('Books (257)',3),('Books (290)',1),('Books, Garden & Garden (275)',0),('Clothing, Electronics & Jewelery (253)',2),('Computers & Health (285)',0),('Computers, Toys & Beauty (278)',0),('Electronics & Jewelery (282)',0),('Electronics (251)',2),('Electronics (266)',3),('Games & Toys (297)',0),('Garden (260)',2),('Garden (262)',1),('Garden (271)',2),('Garden, Kids & Outdoors (289)',1),('Health, Toys & Outdoors (255)',2),('Home (264)',0),('Home, Movies & Shoes (272)',1),('Industrial & Computers (252)',2),('Industrial & Shoes (270)',2),('Industrial, Toys & Automotive (250)',2),('Jewelery, Automotive & Garden (276)',2),('Kids & Baby (287)',0),('Kids & Tools (265)',0),('Kids, Electronics & Movies (288)',2),('Mérnökinformatikus Bsc',1),('Movies & Toys (286)',2),('Movies (294)',3),('Music & Grocery (258)',0),('Music, Movies & Industrial (280)',3),('Outdoors, Home & Baby (292)',1),('Programtervező informatikus Bsc',1),('Shoes & Kids (281)',1),('Shoes & Tools (263)',1),('Shoes & Toys (268)',1),('Sports (274)',3),('Sports, Computers & Electronics (277)',0),('Sports, Kids & Industrial (291)',2),('Tools, Tools & Tools (284)',1),('Toys (259)',0),('Toys (267)',2),('Toys (295)',3),('Toys, Music & Movies (298)',1),('Toys, Outdoors & Toys (293)',2);
/*!40000 ALTER TABLE `degree` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `degreeparticipations`
--

DROP TABLE IF EXISTS `degreeparticipations`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `degreeparticipations` (
  `Username` varchar(32) NOT NULL,
  `DegreeName` varchar(255) NOT NULL,
  `StartDate` date NOT NULL COMMENT 'Képzés kezdete',
  `EndDate` date DEFAULT NULL COMMENT 'Képzés vége',
  PRIMARY KEY (`Username`,`DegreeName`),
  KEY `IX_DegreeParticipations_DegreeName` (`DegreeName`),
  CONSTRAINT `FK_DegreeParticipations_Degree_DegreeName` FOREIGN KEY (`DegreeName`) REFERENCES `degree` (`Name`) ON DELETE CASCADE,
  CONSTRAINT `FK_DegreeParticipations_Users_Username` FOREIGN KEY (`Username`) REFERENCES `users` (`Username`) ON DELETE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `degreeparticipations`
--

LOCK TABLES `degreeparticipations` WRITE;
/*!40000 ALTER TABLE `degreeparticipations` DISABLE KEYS */;
INSERT INTO `degreeparticipations` VALUES ('Aaron79','Books (290)','1983-01-23','1986-01-23'),('abcdef3','Automotive, Garden & Beauty (261)','2023-11-13',NULL),('abcdef3','Baby (256)','2023-11-13',NULL),('abcdef3','Baby (279)','2023-11-13',NULL),('abcdef3','Baby (283)','2023-11-13',NULL),('abcdef3','Beauty & Electronics (299)','2023-11-13',NULL),('abcdef3','Beauty (269)','2023-11-13',NULL),('abcdef3','Beauty (296)','2023-11-13',NULL),('abcdef3','Books (257)','2023-11-13',NULL),('Adriana.Koepp','Clothing, Electronics & Jewelery (253)','1994-05-31','1997-05-31'),('Agnes45','Home (264)','2019-06-03','2022-06-03'),('Allan_Dicki','Garden (260)','2007-01-28','2010-01-28'),('Amari.Cummerata0','Kids, Electronics & Movies (288)','2012-05-08','2015-05-08'),('Amos28','Electronics (266)','1996-08-07','1999-08-07'),('Angelita.Dooley85','Baby (256)','1996-10-22','1999-10-22'),('Annalise_Friesen','Outdoors, Home & Baby (292)','2014-04-04','2017-04-04'),('Antonina92','Clothing, Electronics & Jewelery (253)','1982-06-15','1985-06-15'),('Ayla.Reinger75','Garden (271)','2008-05-04','2011-05-04'),('Benjamin93','Music, Movies & Industrial (280)','1987-03-25','1990-03-25'),('Berenice28','Kids & Baby (287)','2006-04-13','2009-04-13'),('Betty.Cremin','Books & Sports (273)','2013-02-15','2016-02-15'),('Chelsie_McClure','Baby (256)','2019-03-28','2022-03-28'),('Chester.Bartoletti','Garden (271)','1983-11-03','1986-11-03'),('Cicero_VonRueden','Electronics (251)','2019-08-01','2022-08-01'),('Clay61','Sports, Kids & Industrial (291)','1998-07-10','2001-07-10'),('Dahlia_Rodriguez47','Industrial & Computers (252)','2006-03-22','2009-03-22'),('Daisha.Aufderhar','Toys (295)','1995-01-18','1998-01-18'),('Demarcus.Erdman85','Toys (259)','1978-11-13','1981-11-13'),('Demetris90','Toys (267)','2000-05-20','2003-05-20'),('Deon_Ziemann','Electronics & Jewelery (282)','2023-03-20','2026-03-20'),('Dixie.Lueilwitz','Movies & Toys (286)','1981-12-27','1984-12-27'),('Domingo.Watsica','Garden (262)','2021-04-21','2024-04-21'),('Dusty_Graham52','Jewelery, Automotive & Garden (276)','2012-06-22','2015-06-22'),('Eldora.OKon','Games & Toys (297)','2022-03-05','2025-03-05'),('Elizabeth_Orn73','Beauty (269)','2017-05-04','2020-05-04'),('Elsie_Breitenberg','Home, Movies & Shoes (272)','1995-03-31','1998-03-31'),('Elvera17','Jewelery, Automotive & Garden (276)','2023-03-22','2026-03-22'),('Elza.Wintheiser','Music & Grocery (258)','1998-08-13','2001-08-13'),('Enrico97','Baby (279)','1989-08-14','1992-08-14'),('Eve_Champlin','Electronics (266)','2018-12-10','2021-12-10'),('Ewell_Yost','Health, Toys & Outdoors (255)','2022-09-04','2025-09-04'),('Fay_Jast43','Home (264)','2010-11-23','2013-11-23'),('Filiberto4','Books & Sports (273)','2004-12-04','2007-12-04'),('Finn_Stehr26','Clothing, Electronics & Jewelery (253)','1985-03-12','1988-03-12'),('Fletcher_McDermott46','Baby (279)','1984-03-13','1987-03-13'),('Francis.Kunze','Baby (283)','2009-08-13','2012-08-13'),('Genoveva_Volkman52','Music, Movies & Industrial (280)','2017-11-22','2020-11-22'),('Gilberto.Ruecker89','Movies & Toys (286)','2004-12-08','2007-12-08'),('Giovanny.Kuphal96','Toys (259)','2020-08-25','2023-08-25'),('Gladyce.Doyle2','Music & Grocery (258)','1999-04-30','2002-04-30'),('Grant68','Home, Movies & Shoes (272)','2005-10-02','2008-10-02'),('Gregoria_Bailey','Baby (256)','1989-09-06','1992-09-06'),('Hector65','Movies & Toys (286)','2021-03-15','2024-03-15'),('Hortense_Gerhold93','Books (290)','1991-08-19','1994-08-19'),('Houston22','Health, Toys & Outdoors (255)','2007-09-30','2010-09-30'),('Imelda.Sawayn26','Games & Toys (297)','1987-07-31','1990-07-31'),('Jacynthe43','Industrial & Shoes (270)','2001-05-22','2004-05-22'),('Jakayla74','Electronics (251)','2006-03-14','2009-03-14'),('Javier41','Baby (279)','1990-10-01','1993-10-01'),('Jenifer_Lueilwitz72','Beauty (269)','1989-12-30','1992-12-30'),('Jessy.Lang61','Books (290)','2004-09-26','2007-09-26'),('Jordy_Bergstrom5','Electronics (251)','2003-01-02','2006-01-02'),('Joshuah.Hagenes','Kids & Tools (265)','2015-12-04','2018-12-04'),('Jude_Simonis67','Baby (279)','2009-10-10','2012-10-10'),('Kane14','Tools, Tools & Tools (284)','2014-10-20','2017-10-20'),('Katelynn.Abshire2','Electronics (251)','2017-09-24','2020-09-24'),('Katrine_Daniel22','Garden (262)','2017-07-29','2020-07-29'),('Kattie.Stracke74','Baby (279)','2019-11-04','2022-11-04'),('Koby_Erdman29','Outdoors, Home & Baby (292)','1985-08-14','1988-08-14'),('Larue.Frami51','Health, Toys & Outdoors (255)','2020-01-04','2023-01-04'),('Lenora77','Automotive, Garden & Beauty (261)','2003-04-27','2006-04-27'),('Leopoldo.Lesch','Beauty & Electronics (299)','2023-09-03','2026-09-03'),('Lexie_Lang','Industrial & Computers (252)','2008-06-20','2011-06-20'),('Lilian.McKenzie43','Tools, Tools & Tools (284)','1997-05-10','2000-05-10'),('Mack.Schiller','Toys, Outdoors & Toys (293)','1993-05-25','1996-05-25'),('Margie.Klocko','Electronics (266)','2002-01-31','2005-01-31'),('Mariane0','Kids & Tools (265)','2022-03-12','2025-03-12'),('Matteo15','Toys (295)','2010-08-21','2013-08-21'),('Melba75','Shoes & Kids (281)','2014-07-09','2017-07-09'),('Milan.Ratke','Garden (260)','1993-12-28','1996-12-28'),('Miracle_Hilpert','Electronics & Jewelery (282)','1991-10-30','1994-10-30'),('Mireille_Streich','Toys (267)','2017-01-18','2020-01-18'),('Monty.Murphy93','Clothing, Electronics & Jewelery (253)','1996-11-06','1999-11-06'),('Nelson.Simonis18','Health, Toys & Outdoors (255)','2016-08-14','2019-08-14'),('Nichole_Stiedemann24','Baby, Home & Jewelery (254)','2019-01-30','2022-01-30'),('Nick.Boyle','Shoes & Kids (281)','1990-11-13','1993-11-13'),('Nina.Renner','Garden (262)','1985-11-07','1988-11-07'),('oktato','Programtervező informatikus Bsc','1995-09-01','2000-06-01'),('Pat_Nienow13','Garden (262)','1980-09-20','1983-09-20'),('Princess.Gerhold','Baby (283)','2008-12-25','2011-12-25'),('Rae87','Games & Toys (297)','2015-09-11','2018-09-11'),('Ricky_Haley30','Toys (259)','2021-12-05','2024-12-05'),('Rosa.Satterfield27','Books & Sports (273)','1997-06-27','2000-06-27'),('Rowena.Vandervort21','Beauty (296)','1996-01-12','1999-01-12'),('Ruben24','Clothing, Electronics & Jewelery (253)','2002-08-31','2005-08-31'),('Sally29','Computers & Health (285)','2020-11-04','2023-11-04'),('Sandy40','Beauty & Electronics (299)','1991-12-23','1994-12-23'),('Shanna_Abernathy41','Games & Toys (297)','2022-04-18','2025-04-18'),('Shirley17','Books, Garden & Garden (275)','2005-12-28','2008-12-28'),('Sophie_Marquardt76','Garden, Kids & Outdoors (289)','2019-06-08','2022-06-08'),('Stan.Nader','Baby (279)','1985-06-20','1988-06-20'),('Susan48','Electronics (251)','1999-11-17','2002-11-17'),('tanulo','Programtervező informatikus Bsc','2018-09-01',NULL),('Tito29','Kids, Electronics & Movies (288)','1994-05-21','1997-05-21'),('Tobin.Boyle','Baby (283)','2014-12-31','2017-12-31'),('Torey.Kohler48','Shoes & Tools (263)','2005-08-09','2008-08-09'),('Vance_Stehr','Automotive, Garden & Beauty (261)','2017-07-07','2020-07-07'),('Verna.Boehm12','Baby (283)','2013-01-25','2016-01-25'),('Viviane.Wiza','Sports, Computers & Electronics (277)','2000-12-07','2003-12-07'),('Wiley_Kohler','Industrial, Toys & Automotive (250)','2005-12-25','2008-12-25');
/*!40000 ALTER TABLE `degreeparticipations` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `examattendances`
--

DROP TABLE IF EXISTS `examattendances`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `examattendances` (
  `Username` varchar(32) NOT NULL,
  `CourseCode` varchar(15) NOT NULL,
  `CourseSemester` varchar(6) NOT NULL,
  `CourseStart` datetime(6) NOT NULL,
  `AttendanceType` int(11) NOT NULL COMMENT 'Vizsga részvétel típusa (hallgató, oktató)',
  `Grade` longtext DEFAULT NULL COMMENT 'Elért érdemjegy',
  PRIMARY KEY (`Username`,`CourseCode`,`CourseSemester`,`CourseStart`),
  KEY `IX_ExamAttendances_CourseCode_CourseSemester_CourseStart` (`CourseCode`,`CourseSemester`,`CourseStart`),
  CONSTRAINT `FK_ExamAttendances_Exams_CourseCode_CourseSemester_CourseStart` FOREIGN KEY (`CourseCode`, `CourseSemester`, `CourseStart`) REFERENCES `exams` (`CourseCode`, `CourseSemester`, `Start`) ON DELETE CASCADE,
  CONSTRAINT `FK_ExamAttendances_Users_Username` FOREIGN KEY (`Username`) REFERENCES `users` (`Username`) ON DELETE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `examattendances`
--

LOCK TABLES `examattendances` WRITE;
/*!40000 ALTER TABLE `examattendances` DISABLE KEYS */;
INSERT INTO `examattendances` VALUES ('abcdef','abc','2021/1','2023-11-15 18:44:00.000000',0,NULL),('oktato','A kurzus 2','2023/1','2023-11-16 17:43:00.000000',0,NULL),('oktato','abc','2023/1','2023-11-16 17:54:00.000000',0,NULL),('oktato','abc2','2023/1','2023-11-16 17:09:00.000000',0,NULL),('tanulo','abc','2021/1','2023-11-15 18:44:00.000000',1,NULL),('tanulo','abc','2021/1','2023-11-15 19:11:00.000000',1,NULL),('tanulo','abc','2021/1','2023-11-15 20:18:00.000000',1,NULL);
/*!40000 ALTER TABLE `examattendances` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `exams`
--

DROP TABLE IF EXISTS `exams`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `exams` (
  `CourseCode` varchar(15) NOT NULL,
  `CourseSemester` varchar(6) NOT NULL,
  `Start` datetime(6) NOT NULL COMMENT 'Vizsga kezdete',
  `End` datetime(6) NOT NULL COMMENT 'Vizsga vége',
  `ExamType` int(11) NOT NULL COMMENT 'Vizsga típusa',
  `ClassRoomAddress` varchar(100) NOT NULL,
  `ClassRoomRoomName` varchar(10) NOT NULL,
  PRIMARY KEY (`CourseCode`,`CourseSemester`,`Start`),
  KEY `IX_Exams_ClassRoomAddress_ClassRoomRoomName` (`ClassRoomAddress`,`ClassRoomRoomName`),
  CONSTRAINT `FK_Exams_ClassRooms_ClassRoomAddress_ClassRoomRoomName` FOREIGN KEY (`ClassRoomAddress`, `ClassRoomRoomName`) REFERENCES `classrooms` (`Address`, `RoomNumber`) ON DELETE CASCADE,
  CONSTRAINT `FK_Exams_Courses_CourseCode_CourseSemester` FOREIGN KEY (`CourseCode`, `CourseSemester`) REFERENCES `courses` (`CourseCode`, `Semester`) ON DELETE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `exams`
--

LOCK TABLES `exams` WRITE;
/*!40000 ALTER TABLE `exams` DISABLE KEYS */;
INSERT INTO `exams` VALUES ('A kurzus 2','2023/1','2023-11-16 17:43:00.000000','2023-11-16 18:43:00.000000',4,'03179 Bianka Mountains, Stefanville, Kazakhstan','47'),('abc','2021/1','2023-11-15 18:44:00.000000','2023-11-15 19:44:00.000000',4,'03179 Bianka Mountains, Stefanville, Kazakhstan','47'),('abc','2021/1','2023-11-15 19:11:00.000000','2023-11-15 20:11:00.000000',4,'7934 Adams Lodge, South Deronbury, Colombia','313'),('abc','2021/1','2023-11-15 20:18:00.000000','2023-11-15 21:02:00.000000',4,'0189 Kutch Haven, West Daynaborough, Brunei Darussalam','191'),('abc','2021/1','2023-11-15 20:19:00.000000','2023-11-15 21:19:00.000000',4,'03179 Bianka Mountains, Stefanville, Kazakhstan','47'),('abc','2023/1','2023-11-16 17:54:00.000000','2023-11-16 18:54:00.000000',4,'03179 Bianka Mountains, Stefanville, Kazakhstan','47'),('abc2','2023/1','2023-11-16 17:09:00.000000','2023-11-16 18:09:00.000000',4,'03179 Bianka Mountains, Stefanville, Kazakhstan','47');
/*!40000 ALTER TABLE `exams` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `userroles`
--

DROP TABLE IF EXISTS `userroles`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `userroles` (
  `UserType` int(11) NOT NULL COMMENT 'Felhasználó típusa',
  `Username` varchar(32) NOT NULL,
  PRIMARY KEY (`UserType`,`Username`),
  KEY `IX_UserRoles_Username` (`Username`),
  CONSTRAINT `FK_UserRoles_Users_Username` FOREIGN KEY (`Username`) REFERENCES `users` (`Username`) ON DELETE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `userroles`
--

LOCK TABLES `userroles` WRITE;
/*!40000 ALTER TABLE `userroles` DISABLE KEYS */;
INSERT INTO `userroles` VALUES (0,'Aaron79'),(0,'abcdef'),(0,'abcdef2'),(0,'abcdef3'),(0,'Allan_Dicki'),(0,'Amari.Cummerata0'),(0,'Amos28'),(0,'Annalise_Friesen'),(0,'Antonina92'),(0,'Benjamin93'),(0,'Chester.Bartoletti'),(0,'Cicero_VonRueden'),(0,'Daisha.Aufderhar'),(0,'Demarcus.Erdman85'),(0,'Demetris90'),(0,'Deon_Ziemann'),(0,'Dixie.Lueilwitz'),(0,'Eldora.OKon'),(0,'Elizabeth_Orn73'),(0,'Elsie_Breitenberg'),(0,'Elvera17'),(0,'Enrico97'),(0,'Eve_Champlin'),(0,'Fay_Jast43'),(0,'Finn_Stehr26'),(0,'Fletcher_McDermott46'),(0,'Francis.Kunze'),(0,'Genoveva_Volkman52'),(0,'Giovanny.Kuphal96'),(0,'Gladyce.Doyle2'),(0,'Grant68'),(0,'Hortense_Gerhold93'),(0,'Houston22'),(0,'Imelda.Sawayn26'),(0,'Jacynthe43'),(0,'Jakayla74'),(0,'Javier41'),(0,'Jenifer_Lueilwitz72'),(0,'Jordy_Bergstrom5'),(0,'Joshuah.Hagenes'),(0,'Kane14'),(0,'Katelynn.Abshire2'),(0,'Lenora77'),(0,'Leopoldo.Lesch'),(0,'Lexie_Lang'),(0,'Mack.Schiller'),(0,'Mariane0'),(0,'Melba75'),(0,'Milan.Ratke'),(0,'Miracle_Hilpert'),(0,'Mireille_Streich'),(0,'Nick.Boyle'),(0,'Nina.Renner'),(0,'Princess.Gerhold'),(0,'Rae87'),(0,'Ricky_Haley30'),(0,'Rosa.Satterfield27'),(0,'Sally29'),(0,'Sandy40'),(0,'Shanna_Abernathy41'),(0,'Shirley17'),(0,'Sophie_Marquardt76'),(0,'tanulo'),(0,'Tito29'),(0,'Tobin.Boyle'),(0,'Vance_Stehr'),(0,'Viviane.Wiza'),(0,'Wiley_Kohler'),(1,'Aaron79'),(1,'abcdef'),(1,'abcdef2'),(1,'Adriana.Koepp'),(1,'Agnes45'),(1,'Amari.Cummerata0'),(1,'Amos28'),(1,'Angelita.Dooley85'),(1,'Annalise_Friesen'),(1,'Antonina92'),(1,'Ayla.Reinger75'),(1,'Benjamin93'),(1,'Berenice28'),(1,'Betty.Cremin'),(1,'Chelsie_McClure'),(1,'Chester.Bartoletti'),(1,'Cicero_VonRueden'),(1,'Clay61'),(1,'Dahlia_Rodriguez47'),(1,'Demarcus.Erdman85'),(1,'Demetris90'),(1,'Deon_Ziemann'),(1,'Dixie.Lueilwitz'),(1,'Domingo.Watsica'),(1,'Dusty_Graham52'),(1,'Eldora.OKon'),(1,'Elizabeth_Orn73'),(1,'Elsie_Breitenberg'),(1,'Elvera17'),(1,'Elza.Wintheiser'),(1,'Enrico97'),(1,'Ewell_Yost'),(1,'Filiberto4'),(1,'Finn_Stehr26'),(1,'Fletcher_McDermott46'),(1,'Francis.Kunze'),(1,'Genoveva_Volkman52'),(1,'Gilberto.Ruecker89'),(1,'Gladyce.Doyle2'),(1,'Grant68'),(1,'Gregoria_Bailey'),(1,'Hector65'),(1,'Imelda.Sawayn26'),(1,'Jacynthe43'),(1,'Jakayla74'),(1,'Javier41'),(1,'Jenifer_Lueilwitz72'),(1,'Jessy.Lang61'),(1,'Jordy_Bergstrom5'),(1,'Jude_Simonis67'),(1,'Kane14'),(1,'Katelynn.Abshire2'),(1,'Katrine_Daniel22'),(1,'Kattie.Stracke74'),(1,'Koby_Erdman29'),(1,'Larue.Frami51'),(1,'Lenora77'),(1,'Leopoldo.Lesch'),(1,'Lexie_Lang'),(1,'Lilian.McKenzie43'),(1,'Mack.Schiller'),(1,'Margie.Klocko'),(1,'Mariane0'),(1,'Matteo15'),(1,'Miracle_Hilpert'),(1,'Mireille_Streich'),(1,'Monty.Murphy93'),(1,'Nelson.Simonis18'),(1,'Nichole_Stiedemann24'),(1,'Nick.Boyle'),(1,'Nina.Renner'),(1,'oktato'),(1,'Pat_Nienow13'),(1,'Princess.Gerhold'),(1,'Rae87'),(1,'Ricky_Haley30'),(1,'Rosa.Satterfield27'),(1,'Rowena.Vandervort21'),(1,'Ruben24'),(1,'Sally29'),(1,'Sandy40'),(1,'Shirley17'),(1,'Sophie_Marquardt76'),(1,'Stan.Nader'),(1,'Susan48'),(1,'Tobin.Boyle'),(1,'Torey.Kohler48'),(1,'Vance_Stehr'),(1,'Verna.Boehm12'),(1,'Viviane.Wiza');
/*!40000 ALTER TABLE `userroles` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `users`
--

DROP TABLE IF EXISTS `users`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `users` (
  `Username` varchar(32) NOT NULL COMMENT 'Felhasználónév',
  `Name` varchar(100) NOT NULL COMMENT 'Rendes név',
  `PasswordHash` longtext NOT NULL,
  `BirthDate` date NOT NULL COMMENT 'Születési dátum',
  `BirthLocation` varchar(100) NOT NULL COMMENT 'Születési hely',
  PRIMARY KEY (`Username`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `users`
--

LOCK TABLES `users` WRITE;
/*!40000 ALTER TABLE `users` DISABLE KEYS */;
INSERT INTO `users` VALUES ('Aaron79','Claudia Bogisich','AQAAAAIAAYagAAAAEPy0Sa3t+0fqE5iMzp1a5B7FRWSO31WJ37yCzKu2fXCjldLH0utein9gF7o23hnu5g==','1965-01-23','Hermistonside'),('abcdef','Sajtos Kenyér','AQAAAAIAAYagAAAAENzWQvr0bS0PsvTQeHIazLcN7h5dJAx4eh/jwhNriASdZtHaXbJoLEkS1QqtN4yIIw==','2014-02-21','Bukarest'),('abcdef2','Acd sajtoska','AQAAAAIAAYagAAAAEFKCJdxnxgvn+O/vRHNSqNS+cQunPv0iOAOU/fwjk6F17G/l4OsP+aneRC7idhQXBg==','2023-01-13','abc'),('abcdef3','asd','AQAAAAIAAYagAAAAEIMnRdWsJp+l6TKOXGGLeOVLBjF11gOnJlhVmvq+tcjFWUapZVwh0R0klm3oq5OgJQ==','2023-01-13','sajt'),('Adriana.Koepp','Curtis Lesch','AQAAAAIAAYagAAAAEPy0Sa3t+0fqE5iMzp1a5B7FRWSO31WJ37yCzKu2fXCjldLH0utein9gF7o23hnu5g==','1976-05-31','East Lorenzamouth'),('Agnes45','Laisha Satterfield','AQAAAAIAAYagAAAAEPy0Sa3t+0fqE5iMzp1a5B7FRWSO31WJ37yCzKu2fXCjldLH0utein9gF7o23hnu5g==','2001-06-03','Lake Maymie'),('Allan_Dicki','Ashton Hamill','AQAAAAIAAYagAAAAEPy0Sa3t+0fqE5iMzp1a5B7FRWSO31WJ37yCzKu2fXCjldLH0utein9gF7o23hnu5g==','1989-01-28','Port Whitney'),('Amari.Cummerata0','Vanessa Durgan','AQAAAAIAAYagAAAAEPy0Sa3t+0fqE5iMzp1a5B7FRWSO31WJ37yCzKu2fXCjldLH0utein9gF7o23hnu5g==','1994-05-08','West Isabelleport'),('Amos28','Willy Schneider','AQAAAAIAAYagAAAAEPy0Sa3t+0fqE5iMzp1a5B7FRWSO31WJ37yCzKu2fXCjldLH0utein9gF7o23hnu5g==','1978-08-07','New Ariel'),('Angelita.Dooley85','Helmer Gorczany','AQAAAAIAAYagAAAAEPy0Sa3t+0fqE5iMzp1a5B7FRWSO31WJ37yCzKu2fXCjldLH0utein9gF7o23hnu5g==','1978-10-22','New Jarodfurt'),('Annalise_Friesen','Nelle Donnelly','AQAAAAIAAYagAAAAEPy0Sa3t+0fqE5iMzp1a5B7FRWSO31WJ37yCzKu2fXCjldLH0utein9gF7o23hnu5g==','1996-04-04','New Carissa'),('Antonina92','Euna Mohr','AQAAAAIAAYagAAAAEPy0Sa3t+0fqE5iMzp1a5B7FRWSO31WJ37yCzKu2fXCjldLH0utein9gF7o23hnu5g==','1964-06-15','East Kathleen'),('Ayla.Reinger75','Pascale Howe','AQAAAAIAAYagAAAAEPy0Sa3t+0fqE5iMzp1a5B7FRWSO31WJ37yCzKu2fXCjldLH0utein9gF7o23hnu5g==','1990-05-04','Barrowsport'),('Benjamin93','Andreanne Lemke','AQAAAAIAAYagAAAAEPy0Sa3t+0fqE5iMzp1a5B7FRWSO31WJ37yCzKu2fXCjldLH0utein9gF7o23hnu5g==','1969-03-25','West Dereck'),('Berenice28','Luciano Wolf','AQAAAAIAAYagAAAAEPy0Sa3t+0fqE5iMzp1a5B7FRWSO31WJ37yCzKu2fXCjldLH0utein9gF7o23hnu5g==','1988-04-13','Ressieland'),('Betty.Cremin','Mason Ryan','AQAAAAIAAYagAAAAEPy0Sa3t+0fqE5iMzp1a5B7FRWSO31WJ37yCzKu2fXCjldLH0utein9gF7o23hnu5g==','1995-02-15','East Sanfordton'),('Chelsie_McClure','Rae Koelpin','AQAAAAIAAYagAAAAEPy0Sa3t+0fqE5iMzp1a5B7FRWSO31WJ37yCzKu2fXCjldLH0utein9gF7o23hnu5g==','2001-03-28','Joeton'),('Chester.Bartoletti','Ray Powlowski','AQAAAAIAAYagAAAAEPy0Sa3t+0fqE5iMzp1a5B7FRWSO31WJ37yCzKu2fXCjldLH0utein9gF7o23hnu5g==','1965-11-03','Brekkemouth'),('Cicero_VonRueden','Trace Terry','AQAAAAIAAYagAAAAEPy0Sa3t+0fqE5iMzp1a5B7FRWSO31WJ37yCzKu2fXCjldLH0utein9gF7o23hnu5g==','2001-08-01','Elmerside'),('Clay61','Eulah O\'Reilly','AQAAAAIAAYagAAAAEPy0Sa3t+0fqE5iMzp1a5B7FRWSO31WJ37yCzKu2fXCjldLH0utein9gF7o23hnu5g==','1980-07-10','Bryonborough'),('Dahlia_Rodriguez47','Jarod Weimann','AQAAAAIAAYagAAAAEPy0Sa3t+0fqE5iMzp1a5B7FRWSO31WJ37yCzKu2fXCjldLH0utein9gF7o23hnu5g==','1988-03-22','North Andreville'),('Daisha.Aufderhar','Patricia Kuphal','AQAAAAIAAYagAAAAEPy0Sa3t+0fqE5iMzp1a5B7FRWSO31WJ37yCzKu2fXCjldLH0utein9gF7o23hnu5g==','1977-01-18','Bechtelarside'),('Demarcus.Erdman85','Elmira Dietrich','AQAAAAIAAYagAAAAEPy0Sa3t+0fqE5iMzp1a5B7FRWSO31WJ37yCzKu2fXCjldLH0utein9gF7o23hnu5g==','1960-11-13','Tomburgh'),('Demetris90','Eryn Thiel','AQAAAAIAAYagAAAAEPy0Sa3t+0fqE5iMzp1a5B7FRWSO31WJ37yCzKu2fXCjldLH0utein9gF7o23hnu5g==','1982-05-20','Barrowsberg'),('Deon_Ziemann','Jannie Schuppe','AQAAAAIAAYagAAAAEPy0Sa3t+0fqE5iMzp1a5B7FRWSO31WJ37yCzKu2fXCjldLH0utein9gF7o23hnu5g==','2005-03-20','South Sanfordberg'),('Dixie.Lueilwitz','Rolando Johnson','AQAAAAIAAYagAAAAEPy0Sa3t+0fqE5iMzp1a5B7FRWSO31WJ37yCzKu2fXCjldLH0utein9gF7o23hnu5g==','1963-12-27','Othohaven'),('Domingo.Watsica','Justyn Hayes','AQAAAAIAAYagAAAAEPy0Sa3t+0fqE5iMzp1a5B7FRWSO31WJ37yCzKu2fXCjldLH0utein9gF7o23hnu5g==','2003-04-21','North Juliettown'),('Dusty_Graham52','Rubye Gorczany','AQAAAAIAAYagAAAAEPy0Sa3t+0fqE5iMzp1a5B7FRWSO31WJ37yCzKu2fXCjldLH0utein9gF7o23hnu5g==','1994-06-22','Port Jazmynmouth'),('Eldora.OKon','Coty Runolfsdottir','AQAAAAIAAYagAAAAEPy0Sa3t+0fqE5iMzp1a5B7FRWSO31WJ37yCzKu2fXCjldLH0utein9gF7o23hnu5g==','2004-03-05','North Imanishire'),('Elizabeth_Orn73','Myah Gaylord','AQAAAAIAAYagAAAAEPy0Sa3t+0fqE5iMzp1a5B7FRWSO31WJ37yCzKu2fXCjldLH0utein9gF7o23hnu5g==','1999-05-04','New Sherman'),('Elsie_Breitenberg','Malvina Reinger','AQAAAAIAAYagAAAAEPy0Sa3t+0fqE5iMzp1a5B7FRWSO31WJ37yCzKu2fXCjldLH0utein9gF7o23hnu5g==','1977-03-31','Effertzland'),('Elvera17','Alvah McGlynn','AQAAAAIAAYagAAAAEPy0Sa3t+0fqE5iMzp1a5B7FRWSO31WJ37yCzKu2fXCjldLH0utein9gF7o23hnu5g==','2005-03-22','Gradyburgh'),('Elza.Wintheiser','Kaelyn Smith','AQAAAAIAAYagAAAAEPy0Sa3t+0fqE5iMzp1a5B7FRWSO31WJ37yCzKu2fXCjldLH0utein9gF7o23hnu5g==','1980-08-13','Dallintown'),('Enrico97','Rhiannon Toy','AQAAAAIAAYagAAAAEPy0Sa3t+0fqE5iMzp1a5B7FRWSO31WJ37yCzKu2fXCjldLH0utein9gF7o23hnu5g==','1971-08-14','North Amelia'),('Eve_Champlin','Rosalyn Collins','AQAAAAIAAYagAAAAEPy0Sa3t+0fqE5iMzp1a5B7FRWSO31WJ37yCzKu2fXCjldLH0utein9gF7o23hnu5g==','2000-12-10','North Audra'),('Ewell_Yost','Misael Lebsack','AQAAAAIAAYagAAAAEPy0Sa3t+0fqE5iMzp1a5B7FRWSO31WJ37yCzKu2fXCjldLH0utein9gF7o23hnu5g==','2004-09-04','Stiedemannberg'),('Fay_Jast43','Shaun Haley','AQAAAAIAAYagAAAAEPy0Sa3t+0fqE5iMzp1a5B7FRWSO31WJ37yCzKu2fXCjldLH0utein9gF7o23hnu5g==','1992-11-23','New Seanshire'),('Filiberto4','Frederik Hane','AQAAAAIAAYagAAAAEPy0Sa3t+0fqE5iMzp1a5B7FRWSO31WJ37yCzKu2fXCjldLH0utein9gF7o23hnu5g==','1986-12-04','Elliotchester'),('Finn_Stehr26','Laverne Bernier','AQAAAAIAAYagAAAAEPy0Sa3t+0fqE5iMzp1a5B7FRWSO31WJ37yCzKu2fXCjldLH0utein9gF7o23hnu5g==','1967-03-12','Haydentown'),('Fletcher_McDermott46','Consuelo Kutch','AQAAAAIAAYagAAAAEPy0Sa3t+0fqE5iMzp1a5B7FRWSO31WJ37yCzKu2fXCjldLH0utein9gF7o23hnu5g==','1966-03-13','Fernandostad'),('Francis.Kunze','Caesar Huel','AQAAAAIAAYagAAAAEPy0Sa3t+0fqE5iMzp1a5B7FRWSO31WJ37yCzKu2fXCjldLH0utein9gF7o23hnu5g==','1991-08-13','Bretthaven'),('Genoveva_Volkman52','Lucie Wyman','AQAAAAIAAYagAAAAEPy0Sa3t+0fqE5iMzp1a5B7FRWSO31WJ37yCzKu2fXCjldLH0utein9gF7o23hnu5g==','1999-11-22','Petermouth'),('Gilberto.Ruecker89','Quinten Lynch','AQAAAAIAAYagAAAAEPy0Sa3t+0fqE5iMzp1a5B7FRWSO31WJ37yCzKu2fXCjldLH0utein9gF7o23hnu5g==','1986-12-08','North Vivienneburgh'),('Giovanny.Kuphal96','Hermann Carroll','AQAAAAIAAYagAAAAEPy0Sa3t+0fqE5iMzp1a5B7FRWSO31WJ37yCzKu2fXCjldLH0utein9gF7o23hnu5g==','2002-08-25','New Terrance'),('Gladyce.Doyle2','Cierra Jerde','AQAAAAIAAYagAAAAEPy0Sa3t+0fqE5iMzp1a5B7FRWSO31WJ37yCzKu2fXCjldLH0utein9gF7o23hnu5g==','1981-04-30','Port Garrymouth'),('Grant68','Gretchen Emmerich','AQAAAAIAAYagAAAAEPy0Sa3t+0fqE5iMzp1a5B7FRWSO31WJ37yCzKu2fXCjldLH0utein9gF7o23hnu5g==','1987-10-02','South Emelia'),('Gregoria_Bailey','Michelle O\'Connell','AQAAAAIAAYagAAAAEPy0Sa3t+0fqE5iMzp1a5B7FRWSO31WJ37yCzKu2fXCjldLH0utein9gF7o23hnu5g==','1971-09-06','Lake Ebony'),('Hector65','Alba Fisher','AQAAAAIAAYagAAAAEPy0Sa3t+0fqE5iMzp1a5B7FRWSO31WJ37yCzKu2fXCjldLH0utein9gF7o23hnu5g==','2003-03-15','Bernhardbury'),('Hortense_Gerhold93','Selmer Runolfsson','AQAAAAIAAYagAAAAEPy0Sa3t+0fqE5iMzp1a5B7FRWSO31WJ37yCzKu2fXCjldLH0utein9gF7o23hnu5g==','1973-08-19','North Hilbertshire'),('Houston22','Shakira Auer','AQAAAAIAAYagAAAAEPy0Sa3t+0fqE5iMzp1a5B7FRWSO31WJ37yCzKu2fXCjldLH0utein9gF7o23hnu5g==','1989-09-30','Port Keyonchester'),('Imelda.Sawayn26','Sydney Corwin','AQAAAAIAAYagAAAAEPy0Sa3t+0fqE5iMzp1a5B7FRWSO31WJ37yCzKu2fXCjldLH0utein9gF7o23hnu5g==','1969-07-31','West Beth'),('Jacynthe43','Arden Morissette','AQAAAAIAAYagAAAAEPy0Sa3t+0fqE5iMzp1a5B7FRWSO31WJ37yCzKu2fXCjldLH0utein9gF7o23hnu5g==','1983-05-22','West Saige'),('Jakayla74','Chandler Jacobi','AQAAAAIAAYagAAAAEPy0Sa3t+0fqE5iMzp1a5B7FRWSO31WJ37yCzKu2fXCjldLH0utein9gF7o23hnu5g==','1988-03-14','New Hilma'),('Javier41','Tanya Davis','AQAAAAIAAYagAAAAEPy0Sa3t+0fqE5iMzp1a5B7FRWSO31WJ37yCzKu2fXCjldLH0utein9gF7o23hnu5g==','1972-10-01','Florenceville'),('Jenifer_Lueilwitz72','Imelda Toy','AQAAAAIAAYagAAAAEPy0Sa3t+0fqE5iMzp1a5B7FRWSO31WJ37yCzKu2fXCjldLH0utein9gF7o23hnu5g==','1971-12-30','North Ludwig'),('Jessy.Lang61','Charles Metz','AQAAAAIAAYagAAAAEPy0Sa3t+0fqE5iMzp1a5B7FRWSO31WJ37yCzKu2fXCjldLH0utein9gF7o23hnu5g==','1986-09-26','Dillonhaven'),('Jordy_Bergstrom5','Margarete Friesen','AQAAAAIAAYagAAAAEPy0Sa3t+0fqE5iMzp1a5B7FRWSO31WJ37yCzKu2fXCjldLH0utein9gF7o23hnu5g==','1985-01-02','Binsland'),('Joshuah.Hagenes','Marion Murphy','AQAAAAIAAYagAAAAEPy0Sa3t+0fqE5iMzp1a5B7FRWSO31WJ37yCzKu2fXCjldLH0utein9gF7o23hnu5g==','1997-12-04','Cristobaltown'),('Jude_Simonis67','Rowland Hahn','AQAAAAIAAYagAAAAEPy0Sa3t+0fqE5iMzp1a5B7FRWSO31WJ37yCzKu2fXCjldLH0utein9gF7o23hnu5g==','1991-10-10','Sandraton'),('Kane14','Keara Abshire','AQAAAAIAAYagAAAAEPy0Sa3t+0fqE5iMzp1a5B7FRWSO31WJ37yCzKu2fXCjldLH0utein9gF7o23hnu5g==','1996-10-20','Schmidtmouth'),('Katelynn.Abshire2','Joaquin Jacobson','AQAAAAIAAYagAAAAEPy0Sa3t+0fqE5iMzp1a5B7FRWSO31WJ37yCzKu2fXCjldLH0utein9gF7o23hnu5g==','1999-09-24','Lake Aylin'),('Katrine_Daniel22','Asa Bogan','AQAAAAIAAYagAAAAEPy0Sa3t+0fqE5iMzp1a5B7FRWSO31WJ37yCzKu2fXCjldLH0utein9gF7o23hnu5g==','1999-07-29','North Kyler'),('Kattie.Stracke74','Jay Bayer','AQAAAAIAAYagAAAAEPy0Sa3t+0fqE5iMzp1a5B7FRWSO31WJ37yCzKu2fXCjldLH0utein9gF7o23hnu5g==','2001-11-04','South Judgehaven'),('Koby_Erdman29','Gordon Lemke','AQAAAAIAAYagAAAAEPy0Sa3t+0fqE5iMzp1a5B7FRWSO31WJ37yCzKu2fXCjldLH0utein9gF7o23hnu5g==','1967-08-14','Mikelstad'),('Larue.Frami51','Herminio Bernhard','AQAAAAIAAYagAAAAEPy0Sa3t+0fqE5iMzp1a5B7FRWSO31WJ37yCzKu2fXCjldLH0utein9gF7o23hnu5g==','2002-01-04','Arnaldoport'),('Lenora77','Cyril Rolfson','AQAAAAIAAYagAAAAEPy0Sa3t+0fqE5iMzp1a5B7FRWSO31WJ37yCzKu2fXCjldLH0utein9gF7o23hnu5g==','1985-04-27','Ivahland'),('Leopoldo.Lesch','Cecelia Kuvalis','AQAAAAIAAYagAAAAEPy0Sa3t+0fqE5iMzp1a5B7FRWSO31WJ37yCzKu2fXCjldLH0utein9gF7o23hnu5g==','2005-09-03','Port Eveline'),('Lexie_Lang','Burley Goyette','AQAAAAIAAYagAAAAEPy0Sa3t+0fqE5iMzp1a5B7FRWSO31WJ37yCzKu2fXCjldLH0utein9gF7o23hnu5g==','1990-06-20','Port Louveniaside'),('Lilian.McKenzie43','Vincenza Swaniawski','AQAAAAIAAYagAAAAEPy0Sa3t+0fqE5iMzp1a5B7FRWSO31WJ37yCzKu2fXCjldLH0utein9gF7o23hnu5g==','1979-05-10','Port Xanderport'),('Mack.Schiller','Dedric Wunsch','AQAAAAIAAYagAAAAEPy0Sa3t+0fqE5iMzp1a5B7FRWSO31WJ37yCzKu2fXCjldLH0utein9gF7o23hnu5g==','1975-05-25','Rebekafort'),('Margie.Klocko','Kathryn Funk','AQAAAAIAAYagAAAAEPy0Sa3t+0fqE5iMzp1a5B7FRWSO31WJ37yCzKu2fXCjldLH0utein9gF7o23hnu5g==','1984-01-31','Lake Clinton'),('Mariane0','Gunner Strosin','AQAAAAIAAYagAAAAEPy0Sa3t+0fqE5iMzp1a5B7FRWSO31WJ37yCzKu2fXCjldLH0utein9gF7o23hnu5g==','2004-03-12','New Charleymouth'),('Matteo15','Josefa Jast','AQAAAAIAAYagAAAAEPy0Sa3t+0fqE5iMzp1a5B7FRWSO31WJ37yCzKu2fXCjldLH0utein9gF7o23hnu5g==','1992-08-21','Kunzeton'),('Melba75','Monty Dibbert','AQAAAAIAAYagAAAAEPy0Sa3t+0fqE5iMzp1a5B7FRWSO31WJ37yCzKu2fXCjldLH0utein9gF7o23hnu5g==','1996-07-09','Thielburgh'),('Milan.Ratke','Edgardo Stamm','AQAAAAIAAYagAAAAEPy0Sa3t+0fqE5iMzp1a5B7FRWSO31WJ37yCzKu2fXCjldLH0utein9gF7o23hnu5g==','1975-12-28','Cassieton'),('Miracle_Hilpert','Alice Hilll','AQAAAAIAAYagAAAAEPy0Sa3t+0fqE5iMzp1a5B7FRWSO31WJ37yCzKu2fXCjldLH0utein9gF7o23hnu5g==','1973-10-30','Deckowtown'),('Mireille_Streich','Keegan MacGyver','AQAAAAIAAYagAAAAEPy0Sa3t+0fqE5iMzp1a5B7FRWSO31WJ37yCzKu2fXCjldLH0utein9gF7o23hnu5g==','1999-01-18','East Rosalind'),('Monty.Murphy93','Kamille Marks','AQAAAAIAAYagAAAAEPy0Sa3t+0fqE5iMzp1a5B7FRWSO31WJ37yCzKu2fXCjldLH0utein9gF7o23hnu5g==','1978-11-06','New Walton'),('Nelson.Simonis18','Edmund Gulgowski','AQAAAAIAAYagAAAAEPy0Sa3t+0fqE5iMzp1a5B7FRWSO31WJ37yCzKu2fXCjldLH0utein9gF7o23hnu5g==','1998-08-14','Riceshire'),('Nichole_Stiedemann24','Ciara Gleichner','AQAAAAIAAYagAAAAEPy0Sa3t+0fqE5iMzp1a5B7FRWSO31WJ37yCzKu2fXCjldLH0utein9gF7o23hnu5g==','2001-01-30','Gildamouth'),('Nick.Boyle','Lilla Schuster','AQAAAAIAAYagAAAAEPy0Sa3t+0fqE5iMzp1a5B7FRWSO31WJ37yCzKu2fXCjldLH0utein9gF7o23hnu5g==','1972-11-13','West Vernie'),('Nina.Renner','Bettye Lebsack','AQAAAAIAAYagAAAAEPy0Sa3t+0fqE5iMzp1a5B7FRWSO31WJ37yCzKu2fXCjldLH0utein9gF7o23hnu5g==','1967-11-07','Jodymouth'),('oktato','Doktor Doktor','AQAAAAIAAYagAAAAEGwWzLcK2LgEqebi3IQz3KDZalg30QuzeHZhqgav06HdMDPOVOm5CJ8u4IsOPjCFqw==','1980-01-02','Szeged'),('Pat_Nienow13','Presley Harris','AQAAAAIAAYagAAAAEPy0Sa3t+0fqE5iMzp1a5B7FRWSO31WJ37yCzKu2fXCjldLH0utein9gF7o23hnu5g==','1962-09-20','West Bette'),('Princess.Gerhold','Mortimer Ondricka','AQAAAAIAAYagAAAAEPy0Sa3t+0fqE5iMzp1a5B7FRWSO31WJ37yCzKu2fXCjldLH0utein9gF7o23hnu5g==','1990-12-25','East Kenyatta'),('Rae87','Dorothea Kunze','AQAAAAIAAYagAAAAEPy0Sa3t+0fqE5iMzp1a5B7FRWSO31WJ37yCzKu2fXCjldLH0utein9gF7o23hnu5g==','1997-09-11','Raetown'),('Ricky_Haley30','Nona Abernathy','AQAAAAIAAYagAAAAEPy0Sa3t+0fqE5iMzp1a5B7FRWSO31WJ37yCzKu2fXCjldLH0utein9gF7o23hnu5g==','2003-12-05','Charlottemouth'),('Rosa.Satterfield27','Arturo Ratke','AQAAAAIAAYagAAAAEPy0Sa3t+0fqE5iMzp1a5B7FRWSO31WJ37yCzKu2fXCjldLH0utein9gF7o23hnu5g==','1979-06-27','West Leefort'),('Rowena.Vandervort21','Sibyl Adams','AQAAAAIAAYagAAAAEPy0Sa3t+0fqE5iMzp1a5B7FRWSO31WJ37yCzKu2fXCjldLH0utein9gF7o23hnu5g==','1978-01-12','East Bridgetteberg'),('Ruben24','Zetta Hegmann','AQAAAAIAAYagAAAAEPy0Sa3t+0fqE5iMzp1a5B7FRWSO31WJ37yCzKu2fXCjldLH0utein9gF7o23hnu5g==','1984-08-31','New Angeline'),('Sally29','Rory Frami','AQAAAAIAAYagAAAAEPy0Sa3t+0fqE5iMzp1a5B7FRWSO31WJ37yCzKu2fXCjldLH0utein9gF7o23hnu5g==','2002-11-04','North Anissaport'),('Sandy40','Esmeralda Johnston','AQAAAAIAAYagAAAAEPy0Sa3t+0fqE5iMzp1a5B7FRWSO31WJ37yCzKu2fXCjldLH0utein9gF7o23hnu5g==','1973-12-23','Dejontown'),('Shanna_Abernathy41','Evert Ratke','AQAAAAIAAYagAAAAEPy0Sa3t+0fqE5iMzp1a5B7FRWSO31WJ37yCzKu2fXCjldLH0utein9gF7o23hnu5g==','2004-04-18','Mosesfort'),('Shirley17','Chet Larson','AQAAAAIAAYagAAAAEPy0Sa3t+0fqE5iMzp1a5B7FRWSO31WJ37yCzKu2fXCjldLH0utein9gF7o23hnu5g==','1987-12-28','Lafayettebury'),('Sophie_Marquardt76','Elmira McGlynn','AQAAAAIAAYagAAAAEPy0Sa3t+0fqE5iMzp1a5B7FRWSO31WJ37yCzKu2fXCjldLH0utein9gF7o23hnu5g==','2001-06-08','Lockmanside'),('Stan.Nader','Tianna Bayer','AQAAAAIAAYagAAAAEPy0Sa3t+0fqE5iMzp1a5B7FRWSO31WJ37yCzKu2fXCjldLH0utein9gF7o23hnu5g==','1967-06-20','Port Alvastad'),('Susan48','Reed Mayert','AQAAAAIAAYagAAAAEPy0Sa3t+0fqE5iMzp1a5B7FRWSO31WJ37yCzKu2fXCjldLH0utein9gF7o23hnu5g==','1981-11-17','West Marcelle'),('tanulo','Teszt Elek','AQAAAAIAAYagAAAAEPy0Sa3t+0fqE5iMzp1a5B7FRWSO31WJ37yCzKu2fXCjldLH0utein9gF7o23hnu5g==','2000-01-02','Szeged'),('Tito29','Kara Hand','AQAAAAIAAYagAAAAEPy0Sa3t+0fqE5iMzp1a5B7FRWSO31WJ37yCzKu2fXCjldLH0utein9gF7o23hnu5g==','1976-05-21','Lake Alvena'),('Tobin.Boyle','Letha Lemke','AQAAAAIAAYagAAAAEPy0Sa3t+0fqE5iMzp1a5B7FRWSO31WJ37yCzKu2fXCjldLH0utein9gF7o23hnu5g==','1996-12-31','North Liana'),('Torey.Kohler48','Alexandrine Cole','AQAAAAIAAYagAAAAEPy0Sa3t+0fqE5iMzp1a5B7FRWSO31WJ37yCzKu2fXCjldLH0utein9gF7o23hnu5g==','1987-08-09','Franeckibury'),('Vance_Stehr','Lilla Hoppe','AQAAAAIAAYagAAAAEPy0Sa3t+0fqE5iMzp1a5B7FRWSO31WJ37yCzKu2fXCjldLH0utein9gF7o23hnu5g==','1999-07-07','Stiedemannchester'),('Verna.Boehm12','Salvador O\'Kon','AQAAAAIAAYagAAAAEPy0Sa3t+0fqE5iMzp1a5B7FRWSO31WJ37yCzKu2fXCjldLH0utein9gF7o23hnu5g==','1995-01-25','Breanneland'),('Viviane.Wiza','Cullen Rodriguez','AQAAAAIAAYagAAAAEPy0Sa3t+0fqE5iMzp1a5B7FRWSO31WJ37yCzKu2fXCjldLH0utein9gF7o23hnu5g==','1982-12-07','Stanfordberg'),('Wiley_Kohler','Arne Tremblay','AQAAAAIAAYagAAAAEPy0Sa3t+0fqE5iMzp1a5B7FRWSO31WJ37yCzKu2fXCjldLH0utein9gF7o23hnu5g==','1987-12-25','Wunschville');
/*!40000 ALTER TABLE `users` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Dumping routines for database 'abbeadando'
--
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2023-11-18 10:24:01
