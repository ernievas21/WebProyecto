-- 1. Crear la base de datos si no existe
CREATE DATABASE IF NOT EXISTS `mydb`;
USE `mydb`;

-- 2. Tu tabla original de Clientes (Lo que copiaste de Workbench)
CREATE TABLE `tcliente` (
  `idtcliente` int NOT NULL AUTO_INCREMENT,
  `nombre` varchar(45) DEFAULT NULL,
  `apellido` varchar(45) DEFAULT NULL,
  `direccion` varchar(45) DEFAULT NULL,
  `telefono` int DEFAULT NULL,
  `edad` int DEFAULT NULL,
  PRIMARY KEY (`idtcliente`)
) ENGINE=InnoDB AUTO_INCREMENT=11 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
