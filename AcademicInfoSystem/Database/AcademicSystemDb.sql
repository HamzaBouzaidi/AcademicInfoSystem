-- MySQL dump 10.13  Distrib 8.0.43, for Win64 (x86_64)
--
-- Host: localhost    Database: academicsystem
-- ------------------------------------------------------
-- Server version	8.0.43

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!50503 SET NAMES utf8 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Table structure for table `grade`
--

DROP TABLE IF EXISTS `grade`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `grade` (
  `GradeId` int NOT NULL AUTO_INCREMENT,
  `StudentId` int NOT NULL,
  `SubjectId` int NOT NULL,
  `Value` varchar(10) NOT NULL,
  `Date` date NOT NULL,
  `Comment` varchar(255) DEFAULT NULL,
  PRIMARY KEY (`GradeId`),
  KEY `StudentId` (`StudentId`),
  KEY `SubjectId` (`SubjectId`),
  CONSTRAINT `grade_ibfk_1` FOREIGN KEY (`StudentId`) REFERENCES `student` (`StudentId`),
  CONSTRAINT `grade_ibfk_2` FOREIGN KEY (`SubjectId`) REFERENCES `subject` (`SubjectId`)
) ENGINE=InnoDB AUTO_INCREMENT=11 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `grade`
--

LOCK TABLES `grade` WRITE;
/*!40000 ALTER TABLE `grade` DISABLE KEYS */;
INSERT INTO `grade` VALUES (3,18,6,'7','2025-12-03','good'),(4,21,9,'8','2025-12-01','nice'),(5,18,5,'9','2025-12-03','hhah'),(10,18,5,'3','2025-12-03','bad');
/*!40000 ALTER TABLE `grade` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `student`
--

DROP TABLE IF EXISTS `student`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `student` (
  `StudentId` int NOT NULL AUTO_INCREMENT,
  `FirstName` varchar(50) NOT NULL,
  `LastName` varchar(50) NOT NULL,
  `UserId` int NOT NULL,
  `GroupId` int DEFAULT NULL,
  `StudentGroup` varchar(50) DEFAULT NULL,
  PRIMARY KEY (`StudentId`),
  KEY `UserId` (`UserId`),
  KEY `GroupId` (`GroupId`),
  CONSTRAINT `student_ibfk_1` FOREIGN KEY (`UserId`) REFERENCES `user` (`UserId`) ON DELETE CASCADE,
  CONSTRAINT `student_ibfk_2` FOREIGN KEY (`GroupId`) REFERENCES `studentgroup` (`GroupId`) ON DELETE SET NULL
) ENGINE=InnoDB AUTO_INCREMENT=26 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `student`
--

LOCK TABLES `student` WRITE;
/*!40000 ALTER TABLE `student` DISABLE KEYS */;
INSERT INTO `student` VALUES (18,'Nelli','Romania ',1,1,'Group C'),(19,'arvydas','vanagas',1,1,'Group B'),(21,'lucas','Romania',1,1,'Pi24E'),(23,'imad','kabil',1,1,'pi12'),(24,'hamza','shelly',1,5,'pi56'),(25,'Maria','CLara',1,1,'pi24E');
/*!40000 ALTER TABLE `student` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `studentgroup`
--

DROP TABLE IF EXISTS `studentgroup`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `studentgroup` (
  `GroupId` int NOT NULL AUTO_INCREMENT,
  `Name` varchar(50) NOT NULL,
  PRIMARY KEY (`GroupId`)
) ENGINE=InnoDB AUTO_INCREMENT=11 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `studentgroup`
--

LOCK TABLES `studentgroup` WRITE;
/*!40000 ALTER TABLE `studentgroup` DISABLE KEYS */;
INSERT INTO `studentgroup` VALUES (1,'Group A'),(5,'Group A'),(10,'gROUP Y');
/*!40000 ALTER TABLE `studentgroup` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `subject`
--

DROP TABLE IF EXISTS `subject`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `subject` (
  `SubjectId` int NOT NULL AUTO_INCREMENT,
  `Name` varchar(100) NOT NULL,
  `TeacherId` int DEFAULT NULL,
  PRIMARY KEY (`SubjectId`),
  KEY `TeacherId` (`TeacherId`),
  CONSTRAINT `subject_ibfk_1` FOREIGN KEY (`TeacherId`) REFERENCES `teacher` (`TeacherId`) ON DELETE SET NULL
) ENGINE=InnoDB AUTO_INCREMENT=12 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `subject`
--

LOCK TABLES `subject` WRITE;
/*!40000 ALTER TABLE `subject` DISABLE KEYS */;
INSERT INTO `subject` VALUES (5,'Math',NULL),(6,'OOp',2),(9,'java',2),(11,'hgs',2);
/*!40000 ALTER TABLE `subject` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `subjectgroup`
--

DROP TABLE IF EXISTS `subjectgroup`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `subjectgroup` (
  `SubjectId` int NOT NULL,
  `GroupId` int NOT NULL,
  PRIMARY KEY (`SubjectId`,`GroupId`),
  KEY `GroupId` (`GroupId`),
  CONSTRAINT `subjectgroup_ibfk_1` FOREIGN KEY (`SubjectId`) REFERENCES `subject` (`SubjectId`) ON DELETE CASCADE,
  CONSTRAINT `subjectgroup_ibfk_2` FOREIGN KEY (`GroupId`) REFERENCES `studentgroup` (`GroupId`) ON DELETE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `subjectgroup`
--

LOCK TABLES `subjectgroup` WRITE;
/*!40000 ALTER TABLE `subjectgroup` DISABLE KEYS */;
/*!40000 ALTER TABLE `subjectgroup` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `teacher`
--

DROP TABLE IF EXISTS `teacher`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `teacher` (
  `TeacherId` int NOT NULL AUTO_INCREMENT,
  `UserId` int NOT NULL,
  PRIMARY KEY (`TeacherId`),
  KEY `UserId` (`UserId`),
  CONSTRAINT `teacher_ibfk_1` FOREIGN KEY (`UserId`) REFERENCES `user` (`UserId`) ON DELETE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=10 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `teacher`
--

LOCK TABLES `teacher` WRITE;
/*!40000 ALTER TABLE `teacher` DISABLE KEYS */;
INSERT INTO `teacher` VALUES (1,3),(4,3),(2,7),(9,8);
/*!40000 ALTER TABLE `teacher` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `user`
--

DROP TABLE IF EXISTS `user`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `user` (
  `UserId` int NOT NULL AUTO_INCREMENT,
  `FirstName` varchar(50) NOT NULL,
  `LastName` varchar(50) NOT NULL,
  `Login` varchar(50) NOT NULL,
  `Password` varchar(255) NOT NULL,
  `Role` enum('Admin','Teacher','Student') NOT NULL,
  PRIMARY KEY (`UserId`),
  UNIQUE KEY `Login` (`Login`)
) ENGINE=InnoDB AUTO_INCREMENT=9 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `user`
--

LOCK TABLES `user` WRITE;
/*!40000 ALTER TABLE `user` DISABLE KEYS */;
INSERT INTO `user` VALUES (1,'Admin','Admin','Admin','Admin','Admin'),(2,'Hamza','Bouzaidi','Hamza','Bouzaidi','Student'),(3,'John','Smith','jsmith','password123','Teacher'),(7,'anyone','shelly','anyone','shelly','Teacher'),(8,'Patrcija ','Vanagaite','Patrcija','Vanagaite','Teacher');
/*!40000 ALTER TABLE `user` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2025-12-03 23:46:24
