CREATE DATABASE  IF NOT EXISTS `itsurenglishlearn` /*!40100 DEFAULT CHARACTER SET utf8 */;
USE `itsurenglishlearn`;
-- MySQL dump 10.13  Distrib 5.7.9, for Win64 (x86_64)
--
-- Host: localhost    Database: itsurenglishlearn
-- ------------------------------------------------------
-- Server version	5.7.10-log

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
-- Table structure for table `estadistica`
--

DROP TABLE IF EXISTS `estadistica`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `estadistica` (
  `IdEstadistica` int(11) NOT NULL AUTO_INCREMENT,
  `User` varchar(20) NOT NULL,
  `FechaInicio` datetime NOT NULL,
  `Nivel` int(11) NOT NULL,
  PRIMARY KEY (`IdEstadistica`),
  KEY `User` (`User`),
  CONSTRAINT `estadistica_ibfk_1` FOREIGN KEY (`User`) REFERENCES `usuario` (`User`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `estadistica`
--

LOCK TABLES `estadistica` WRITE;
/*!40000 ALTER TABLE `estadistica` DISABLE KEYS */;
INSERT INTO `estadistica` VALUES (1,'Jose1','2019-02-02 00:00:00',1);
/*!40000 ALTER TABLE `estadistica` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `gramatica`
--

DROP TABLE IF EXISTS `gramatica`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `gramatica` (
  `IdGramatica` int(11) NOT NULL AUTO_INCREMENT,
  `Sujeto` varchar(50) DEFAULT NULL,
  `Verbo` varchar(50) DEFAULT NULL,
  `Complemento` varchar(50) DEFAULT NULL,
  `Tipo` enum('Afirmativo','Pregunta','Negativo') NOT NULL,
  PRIMARY KEY (`IdGramatica`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `gramatica`
--

LOCK TABLES `gramatica` WRITE;
/*!40000 ALTER TABLE `gramatica` DISABLE KEYS */;
INSERT INTO `gramatica` VALUES (1,'Sujeto','Simple present','Complement','Afirmativo'),(2,'Auxiliar-Sujeto','Simple present','Complemet','Pregunta'),(3,'Sujeto-Auxiliar-Negativo','Simple present','Complement','Negativo');
/*!40000 ALTER TABLE `gramatica` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `gramaticaportema`
--

DROP TABLE IF EXISTS `gramaticaportema`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `gramaticaportema` (
  `IdTema` int(11) NOT NULL,
  `IdGramatica` int(11) NOT NULL,
  PRIMARY KEY (`IdTema`,`IdGramatica`),
  KEY `IdGramatica` (`IdGramatica`),
  CONSTRAINT `gramaticaportema_ibfk_1` FOREIGN KEY (`IdGramatica`) REFERENCES `gramatica` (`IdGramatica`),
  CONSTRAINT `gramaticaportema_ibfk_2` FOREIGN KEY (`IdTema`) REFERENCES `tema` (`IdTema`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `gramaticaportema`
--

LOCK TABLES `gramaticaportema` WRITE;
/*!40000 ALTER TABLE `gramaticaportema` DISABLE KEYS */;
INSERT INTO `gramaticaportema` VALUES (1,1),(1,2),(1,3);
/*!40000 ALTER TABLE `gramaticaportema` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `practica`
--

DROP TABLE IF EXISTS `practica`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `practica` (
  `IdPractica` int(11) NOT NULL AUTO_INCREMENT,
  `Correctas` int(11) NOT NULL,
  `IdTema` int(11) DEFAULT NULL,
  `User` varchar(20) DEFAULT NULL,
  PRIMARY KEY (`IdPractica`),
  KEY `IdTema` (`IdTema`),
  KEY `User` (`User`),
  CONSTRAINT `practica_ibfk_1` FOREIGN KEY (`IdTema`) REFERENCES `tema` (`IdTema`),
  CONSTRAINT `practica_ibfk_2` FOREIGN KEY (`User`) REFERENCES `usuario` (`User`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `practica`
--

LOCK TABLES `practica` WRITE;
/*!40000 ALTER TABLE `practica` DISABLE KEYS */;
INSERT INTO `practica` VALUES (1,1,1,'Jose1');
/*!40000 ALTER TABLE `practica` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `pregunta`
--

DROP TABLE IF EXISTS `pregunta`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `pregunta` (
  `idPregunta` int(11) NOT NULL AUTO_INCREMENT,
  `Pregunta` varchar(150) NOT NULL,
  `RespuestaCorrecta` varchar(150) NOT NULL,
  `RespuestaIncorrecta1` varchar(150) NOT NULL,
  `RespuestaIncorrecta2` varchar(150) NOT NULL,
  `RespuestaIncorrecta3` varchar(150) NOT NULL,
  PRIMARY KEY (`idPregunta`)
) ENGINE=InnoDB AUTO_INCREMENT=19 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `pregunta`
--

LOCK TABLES `pregunta` WRITE;
/*!40000 ALTER TABLE `pregunta` DISABLE KEYS */;
INSERT INTO `pregunta` VALUES (1,'_____ is she?','Who','What','Which','Whose'),(2,'_____ you eat pizza?','Do','Does','are','___'),(3,'Where is David? _____ is at home.','He','His','she','him'),(4,'Can you help _____?','me','I','We','They'),(5,'Where is the book? ____ is on the table.','It','He','She','___'),(6,'____ house is blue.','Your','You','It','Yours'),(8,'Where ____ Sarah live?','does','is','do','are'),(9,'How many people ______ in your family?','are there','there are','is there','there'),(10,'Its Thursday today. Tomorrow it ___________ Friday.','will be','was','be','will'),(11,'\"Has Steve got a sister?\" \"No, he ___________, but he has got 2 brothers.\"','hasn´t','has','haven´t','not'),(12,' Complete the sentence: He _____ at the park','runs','run','ran','does run'),(13,'Complete the sentence: _____ He run at the park?','Does','Do','Did','Done'),(14,'What is the correct verb in past simple?','Ate','eat','eaten','eating'),(15,'He ____ pizza','ate','eat','eating','eaten'),(16,'We ____ run at the park','did not','does not','are not','do not'),(17,'Seleccione la traducción en Inglés del verbo \"escribir\" en tiempo pasado.','write','written','wrote','writing'),(18,'Selecccione la traducción de la palabra \"gato\".','Cat','Kitten','Dog','Lion');
/*!40000 ALTER TABLE `pregunta` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `preguntacontestadaporusuaruio`
--

DROP TABLE IF EXISTS `preguntacontestadaporusuaruio`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `preguntacontestadaporusuaruio` (
  `User` varchar(20) NOT NULL,
  `IdPregunta` int(11) NOT NULL,
  `Contesto` enum('Correcto','Incorrecto') DEFAULT NULL,
  PRIMARY KEY (`User`,`IdPregunta`),
  KEY `IdPregunta` (`IdPregunta`),
  CONSTRAINT `preguntacontestadaporusuaruio_ibfk_1` FOREIGN KEY (`IdPregunta`) REFERENCES `pregunta` (`idPregunta`),
  CONSTRAINT `preguntacontestadaporusuaruio_ibfk_2` FOREIGN KEY (`User`) REFERENCES `usuario` (`User`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `preguntacontestadaporusuaruio`
--

LOCK TABLES `preguntacontestadaporusuaruio` WRITE;
/*!40000 ALTER TABLE `preguntacontestadaporusuaruio` DISABLE KEYS */;
INSERT INTO `preguntacontestadaporusuaruio` VALUES ('Jose1',12,'Correcto'),('Jose1',13,'Correcto'),('Jose1',14,'Incorrecto'),('Jose1',15,'Correcto'),('Jose1',16,'Incorrecto'),('Jose1',17,'Correcto'),('Jose1',18,'Correcto');
/*!40000 ALTER TABLE `preguntacontestadaporusuaruio` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `preguntaporquiz`
--

DROP TABLE IF EXISTS `preguntaporquiz`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `preguntaporquiz` (
  `IdPreguntaQuiz` int(11) NOT NULL AUTO_INCREMENT,
  `IdPregunta` int(11) DEFAULT NULL,
  `IdQuiz` int(11) DEFAULT NULL,
  PRIMARY KEY (`IdPreguntaQuiz`),
  KEY `IdPregunta` (`IdPregunta`),
  KEY `IdQuiz` (`IdQuiz`),
  CONSTRAINT `preguntaporquiz_ibfk_1` FOREIGN KEY (`IdPregunta`) REFERENCES `pregunta` (`idPregunta`),
  CONSTRAINT `preguntaporquiz_ibfk_2` FOREIGN KEY (`IdQuiz`) REFERENCES `quiz` (`idQuiz`)
) ENGINE=InnoDB AUTO_INCREMENT=11 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `preguntaporquiz`
--

LOCK TABLES `preguntaporquiz` WRITE;
/*!40000 ALTER TABLE `preguntaporquiz` DISABLE KEYS */;
INSERT INTO `preguntaporquiz` VALUES (1,1,1),(2,3,1),(3,4,1),(4,2,1),(5,5,1),(6,6,1),(7,8,1),(8,9,1),(9,10,1),(10,11,1);
/*!40000 ALTER TABLE `preguntaporquiz` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `preguntaportema`
--

DROP TABLE IF EXISTS `preguntaportema`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `preguntaportema` (
  `IdPregunta` int(11) NOT NULL,
  `IdTema` int(11) NOT NULL,
  PRIMARY KEY (`IdPregunta`,`IdTema`),
  KEY `IdTema` (`IdTema`),
  CONSTRAINT `preguntaportema_ibfk_1` FOREIGN KEY (`IdPregunta`) REFERENCES `pregunta` (`idPregunta`),
  CONSTRAINT `preguntaportema_ibfk_2` FOREIGN KEY (`IdTema`) REFERENCES `tema` (`IdTema`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `preguntaportema`
--

LOCK TABLES `preguntaportema` WRITE;
/*!40000 ALTER TABLE `preguntaportema` DISABLE KEYS */;
INSERT INTO `preguntaportema` VALUES (12,1),(13,1),(14,1),(15,2),(16,2),(17,3),(18,4);
/*!40000 ALTER TABLE `preguntaportema` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `quiz`
--

DROP TABLE IF EXISTS `quiz`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `quiz` (
  `idQuiz` int(11) NOT NULL AUTO_INCREMENT,
  `Nombre` varchar(40) NOT NULL,
  PRIMARY KEY (`idQuiz`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `quiz`
--

LOCK TABLES `quiz` WRITE;
/*!40000 ALTER TABLE `quiz` DISABLE KEYS */;
INSERT INTO `quiz` VALUES (1,'Quiz Diagnostico 1');
/*!40000 ALTER TABLE `quiz` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `sujeto`
--

DROP TABLE IF EXISTS `sujeto`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `sujeto` (
  `IdSujeto` int(11) NOT NULL AUTO_INCREMENT,
  `SujetoTraducido` varchar(30) NOT NULL,
  `Sujeto` varchar(30) NOT NULL,
  `Objeto` varchar(30) DEFAULT NULL,
  `Posesivo` varchar(30) DEFAULT NULL,
  `Sucesivo` varchar(30) DEFAULT NULL,
  PRIMARY KEY (`IdSujeto`)
) ENGINE=InnoDB AUTO_INCREMENT=9 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `sujeto`
--

LOCK TABLES `sujeto` WRITE;
/*!40000 ALTER TABLE `sujeto` DISABLE KEYS */;
INSERT INTO `sujeto` VALUES (1,'Yo','I','Me','My','Myself'),(2,'Tú/Usted','You','You','Your','Yourself'),(3,'Él','He','Him','His','Himself'),(4,'Ella','She','Her','Her','Herself'),(5,'Eso','It','It','Its','Itself'),(6,'Nosotros/as','We','Us','Our','Ourselves'),(7,'Ustedes','You','You','Your','Yourselves'),(8,'Ellos/as','They','Them','Their','Themselves');
/*!40000 ALTER TABLE `sujeto` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tema`
--

DROP TABLE IF EXISTS `tema`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `tema` (
  `IdTema` int(11) NOT NULL AUTO_INCREMENT,
  `NombreTraduccion` varchar(100) DEFAULT NULL,
  `NombreIngles` varchar(100) NOT NULL,
  `ContenidoTraduccion` text,
  `ContenidoIngles` text,
  `Dificultad` int(11) DEFAULT NULL,
  PRIMARY KEY (`IdTema`,`NombreIngles`)
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tema`
--

LOCK TABLES `tema` WRITE;
/*!40000 ALTER TABLE `tema` DISABLE KEYS */;
INSERT INTO `tema` VALUES (1,'Presente simple','Simple present','Para conjugar el presente simple usamos el infinitivo para los sujetos “I”, “you”, “we” y “they” y para las terceras personas “he”, “she” y “it”, añadimos una “-s” al final del verbo.','To conjugate the present simple we use the infinitive for the subjects “I”, “you”, “we” y “they” and for the third persons “he”, “she” y “it”, we add a “-s” to the end of the verb.',1),(2,'Pasado Simple','Simple present','El pasado simple, es un verbo el cuál se usa para indicar que se completó una acción que tomó lugar en un tiempo especifico en el pasado','The simple past (also called past simple, past indefinite or preterite) is a verb tense which is used to show that a completed action took place at a specific time in the past.',1),(3,'Verbos','Verbos','.....','.....',1),(4,'Vocabulario','Vocabulary','...','...',1);
/*!40000 ALTER TABLE `tema` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `usuario`
--

DROP TABLE IF EXISTS `usuario`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `usuario` (
  `User` varchar(20) NOT NULL,
  `Password` char(128) NOT NULL,
  `Nombre` varchar(30) DEFAULT NULL,
  `ApellidoPaterno` varchar(40) DEFAULT NULL,
  `ApellidoMaterno` varchar(40) DEFAULT NULL,
  `Correo` varchar(50) NOT NULL,
  `Foto` varchar(100) DEFAULT NULL,
  `Privilegio` enum('Administrativo','Alumno') DEFAULT NULL,
  PRIMARY KEY (`User`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `usuario`
--

LOCK TABLES `usuario` WRITE;
/*!40000 ALTER TABLE `usuario` DISABLE KEYS */;
INSERT INTO `usuario` VALUES ('Eli123','99adc231b045331e514a516b4b7680f588e3823213abe901738bc3ad67b2f6fcb3c64efb93d18002588d3ccc1a49efbae1ce20cb43df36b38651f11fa75678e8','Elizabeth','González','Duran','eli@gmail.com','kjfkdjfkjdkf','Administrativo'),('Jose1','99adc231b045331e514a516b4b7680f588e3823213abe901738bc3ad67b2f6fcb3c64efb93d18002588d3ccc1a49efbae1ce20cb43df36b38651f11fa75678e8','José Jesús','García','Rojas','jj@gmail.com','ldjfldjf','Alumno'),('Paco','99adc231b045331e514a516b4b7680f588e3823213abe901738bc3ad67b2f6fcb3c64efb93d18002588d3ccc1a49efbae1ce20cb43df36b38651f11fa75678e8','Francisco','Paniagua','Zamora','paco@gmail.com','kjfkdjfkjdkf','Administrativo'),('Ruiz','99adc231b045331e514a516b4b7680f588e3823213abe901738bc3ad67b2f6fcb3c64efb93d18002588d3ccc1a49efbae1ce20cb43df36b38651f11fa75678e8','Jesús','Ruíz','Sánchez','ruiz@gmail.com','kjfkdjfkjdkf','Administrativo');
/*!40000 ALTER TABLE `usuario` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `verbo`
--

DROP TABLE IF EXISTS `verbo`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `verbo` (
  `IdVerbo` int(11) NOT NULL AUTO_INCREMENT,
  `VerboTraduccion` varchar(50) NOT NULL,
  `VerboPresenteSimple` varchar(50) NOT NULL,
  `VerboPasadoSimple` varchar(50) NOT NULL,
  `VerboPasadoParticipio` varchar(50) NOT NULL,
  PRIMARY KEY (`IdVerbo`)
) ENGINE=InnoDB AUTO_INCREMENT=36 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `verbo`
--

LOCK TABLES `verbo` WRITE;
/*!40000 ALTER TABLE `verbo` DISABLE KEYS */;
INSERT INTO `verbo` VALUES (1,'Ser/Estar','Be','Was/Were','Been'),(2,'Ganar (ganarle a alguien)','Beat','Beat','Beaten'),(3,'Empezar','Begin','Began','Begun'),(4,'Doblar','Bend','Bent','Bent'),(5,'Morder','Bite','Bit','Bitten'),(6,'Soplar','Blow','Blew','Blown'),(7,'Romper','Break','Broke','Broken'),(8,'Llevar/Traer','Bring','Brought','Brought'),(9,'Construir','Build','Built','Built'),(10,'Comprar','Buy','Bought','Bought'),(11,'Coger','Catch','Caught','Caught'),(12,'Elegir','Choose','Chose','Chosen'),(13,'Venir','Come','Came','Come'),(14,'Costar','Cost','Cost','Cost'),(15,'Hacer','Do','Did','Done'),(16,'Dibujar','Draw','Drew','Drew'),(17,'Soñar','Dream','Dreamed / Dreamt','Dreamed / Dreamt'),(18,'Conducir','Drive','Drove','Driven'),(19,'Beber','Drink','Drank','Drunk'),(20,'Comer','Eat','Ate','Eaten'),(21,'Caer','Fall','Fell','Fallen'),(22,'Sentir','Feel','Felt','Felt'),(23,'Luchar','Fight','Fought','Fought'),(24,'Encontrar','Find','Found','Found'),(25,'Volar','Fly','Flew','Flown'),(26,'Olvidar','Forget','Forgot','Forgotten'),(27,'Perdonar','Forgive','Forgave','Forgiven'),(28,'Conseguir','Get','Got','Gotten'),(29,'Dar','Give','Gave','Given'),(30,'Ir','Go','Went','Gone'),(31,'Crecer','Grow','Grew','Grown'),(32,'Tener','Have','Had','Had'),(33,'Oir','Hear','Heard','Heard'),(34,'Esconder','Hide','Hid','Hidden'),(35,'Golpear','Hit','Hit','Hit');
/*!40000 ALTER TABLE `verbo` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2019-04-10 17:21:10
