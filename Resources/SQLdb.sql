CREATE DATABASE  IF NOT EXISTS `criadero` /*!40100 DEFAULT CHARACTER SET utf8 */;
USE `criadero`;
-- MySQL dump 10.13  Distrib 5.7.12, for Win32 (AMD64)
--
-- Host: localhost    Database: criadero
-- ------------------------------------------------------
-- Server version	5.7.14-log

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Table structure for table `colors`
--

DROP TABLE IF EXISTS `colors`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `colors` (
  `idColor` int(11) NOT NULL AUTO_INCREMENT,
  `description` varchar(45) NOT NULL,
  PRIMARY KEY (`idColor`)
) ENGINE=InnoDB AUTO_INCREMENT=7 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `colors`
--

LOCK TABLES `colors` WRITE;
/*!40000 ALTER TABLE `colors` DISABLE KEYS */;
INSERT INTO `colors` VALUES (1,'Blanco'),(2,'Negro'),(3,'Gris'),(4,'Chocolate'),(5,'Apricot'),(6,'Rojo');
/*!40000 ALTER TABLE `colors` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `dog_has_zeal`
--

DROP TABLE IF EXISTS `dog_has_zeal`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `dog_has_zeal` (
  `Dogs_idDogs` int(11) NOT NULL,
  `startDate` date NOT NULL,
  PRIMARY KEY (`Dogs_idDogs`,`startDate`),
  CONSTRAINT `dog_has_zeal_ibfk_1` FOREIGN KEY (`Dogs_idDogs`) REFERENCES `dogs` (`idDogs`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `dog_has_zeal`
--

LOCK TABLES `dog_has_zeal` WRITE;
/*!40000 ALTER TABLE `dog_has_zeal` DISABLE KEYS */;
INSERT INTO `dog_has_zeal` VALUES (2,'1999-12-31'),(2,'2014-07-28');
/*!40000 ALTER TABLE `dog_has_zeal` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `dogs`
--

DROP TABLE IF EXISTS `dogs`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `dogs` (
  `idDogs` int(11) NOT NULL AUTO_INCREMENT,
  `nameReal` varchar(45) NOT NULL COMMENT 'Nombre / Apodo / Alias',
  `nameFormal` varchar(45) DEFAULT NULL COMMENT 'Nombre registrado en los papeles',
  `birthDate` date DEFAULT NULL,
  `gender` varchar(20) NOT NULL,
  `Species_idSpecie` int(11) NOT NULL,
  `Color_idColor` int(11) NOT NULL,
  PRIMARY KEY (`idDogs`),
  KEY `fk_Dogs_Species_idx` (`Species_idSpecie`),
  KEY `fk_Dogs_Color1_idx` (`Color_idColor`),
  CONSTRAINT `fk_Dogs_Color1` FOREIGN KEY (`Color_idColor`) REFERENCES `colors` (`idColor`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `fk_Dogs_Species` FOREIGN KEY (`Species_idSpecie`) REFERENCES `species` (`idSpecie`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `dogs`
--

LOCK TABLES `dogs` WRITE;
/*!40000 ALTER TABLE `dogs` DISABLE KEYS */;
INSERT INTO `dogs` VALUES (1,'Enano','Apolo','2013-08-13','Macho',2,1),(2,'Génesis','Génesis','2013-08-15','Hembra',2,1);
/*!40000 ALTER TABLE `dogs` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `service_has_act`
--

DROP TABLE IF EXISTS `service_has_act`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `service_has_act` (
  `Services_idServices` int(11) NOT NULL,
  `actDate` date NOT NULL,
  PRIMARY KEY (`Services_idServices`,`actDate`),
  CONSTRAINT `Services_idServices` FOREIGN KEY (`Services_idServices`) REFERENCES `services` (`idService`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `service_has_act`
--

LOCK TABLES `service_has_act` WRITE;
/*!40000 ALTER TABLE `service_has_act` DISABLE KEYS */;
/*!40000 ALTER TABLE `service_has_act` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `services`
--

DROP TABLE IF EXISTS `services`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `services` (
  `idService` int(11) NOT NULL AUTO_INCREMENT,
  `idMale` int(11) NOT NULL,
  `idFemale` int(11) NOT NULL,
  `birthStart` date DEFAULT NULL,
  `birthEnd` date DEFAULT NULL,
  `Dog_has_Zeal_Dogs_idDogs` int(11) NOT NULL,
  `Dog_has_Zeal_Dogs_startDate` date NOT NULL,
  PRIMARY KEY (`Dog_has_Zeal_Dogs_startDate`,`idFemale`),
  UNIQUE KEY `idService_UNIQUE` (`idService`),
  KEY `idMale` (`idMale`),
  KEY `idFemale` (`idFemale`),
  KEY `services_ibfk_3` (`Dog_has_Zeal_Dogs_idDogs`,`Dog_has_Zeal_Dogs_startDate`),
  CONSTRAINT `services_ibfk_1` FOREIGN KEY (`idMale`) REFERENCES `dogs` (`idDogs`),
  CONSTRAINT `services_ibfk_2` FOREIGN KEY (`idFemale`) REFERENCES `dogs` (`idDogs`),
  CONSTRAINT `services_ibfk_3` FOREIGN KEY (`Dog_has_Zeal_Dogs_idDogs`, `Dog_has_Zeal_Dogs_startDate`) REFERENCES `dog_has_zeal` (`Dogs_idDogs`, `startDate`)
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `services`
--

LOCK TABLES `services` WRITE;
/*!40000 ALTER TABLE `services` DISABLE KEYS */;
INSERT INTO `services` VALUES (3,1,2,'2012-12-12','2012-12-28',2,'1999-12-31'),(4,1,2,'2012-12-12','2012-12-28',2,'2014-07-28');
/*!40000 ALTER TABLE `services` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `species`
--

DROP TABLE IF EXISTS `species`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `species` (
  `idSpecie` int(11) NOT NULL AUTO_INCREMENT,
  `description` varchar(45) NOT NULL,
  PRIMARY KEY (`idSpecie`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `species`
--

LOCK TABLES `species` WRITE;
/*!40000 ALTER TABLE `species` DISABLE KEYS */;
INSERT INTO `species` VALUES (1,'Caniche'),(2,'Maltes'),(3,'Bulldog Frances');
/*!40000 ALTER TABLE `species` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2016-08-23 23:58:20
