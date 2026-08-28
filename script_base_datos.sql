-- MySQL Workbench Forward Engineering

SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0;
SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0;
SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION';

-- -----------------------------------------------------
-- Schema mydb
-- -----------------------------------------------------

-- -----------------------------------------------------
-- Schema mydb
-- -----------------------------------------------------
CREATE SCHEMA IF NOT EXISTS `mydb` DEFAULT CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci ;
USE `mydb` ;

-- -----------------------------------------------------
-- Table `mydb`.`entidad_detalle`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `mydb`.`entidad_detalle` (
  `identidad_detalle` INT NOT NULL AUTO_INCREMENT,
  `entidad_detallecol` VARCHAR(45) NULL DEFAULT NULL,
  `fecha` DATE NULL DEFAULT NULL,
  PRIMARY KEY (`identidad_detalle`))
ENGINE = InnoDB
DEFAULT CHARACTER SET = utf8mb4
COLLATE = utf8mb4_0900_ai_ci;


-- -----------------------------------------------------
-- Table `mydb`.`proveedor`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `mydb`.`proveedor` (
  `idProveedor` INT NOT NULL,
  `nombre` VARCHAR(60) NULL DEFAULT NULL,
  `direccion` VARCHAR(50) NULL DEFAULT NULL,
  `telefono` INT NULL DEFAULT NULL,
  `fecha_fundacion` DATE NULL DEFAULT NULL,
  `anos` INT NULL DEFAULT NULL,
  PRIMARY KEY (`idProveedor`))
ENGINE = InnoDB
DEFAULT CHARACTER SET = utf8mb3;


-- -----------------------------------------------------
-- Table `mydb`.`t_entidad`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `mydb`.`t_entidad` (
  `identidad` INT NOT NULL AUTO_INCREMENT,
  `codigo_entidad` VARCHAR(20) NOT NULL,
  `nombre` VARCHAR(150) NOT NULL,
  `activo` TINYINT NULL DEFAULT '1',
  PRIMARY KEY (`identidad`),
  UNIQUE INDEX `codigo_entidad` (`codigo_entidad` ASC) VISIBLE)
ENGINE = InnoDB
DEFAULT CHARACTER SET = utf8mb4
COLLATE = utf8mb4_0900_ai_ci;


-- -----------------------------------------------------
-- Table `mydb`.`tcompra`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `mydb`.`tcompra` (
  `idcompra` INT NOT NULL AUTO_INCREMENT,
  `idproveedor` INT NULL DEFAULT NULL,
  `descripcion` VARCHAR(45) NULL DEFAULT NULL,
  `fecha` DATE NULL DEFAULT NULL,
  PRIMARY KEY (`idcompra`),
  INDEX `idproveedor_idx` (`idproveedor` ASC) VISIBLE,
  CONSTRAINT `idproveedor`
    FOREIGN KEY (`idproveedor`)
    REFERENCES `mydb`.`proveedor` (`idProveedor`))
ENGINE = InnoDB
DEFAULT CHARACTER SET = utf8mb4
COLLATE = utf8mb4_0900_ai_ci;


-- -----------------------------------------------------
-- Table `mydb`.`tpago`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `mydb`.`tpago` (
  `idpago` INT NOT NULL AUTO_INCREMENT,
  `idcompra` INT NULL DEFAULT NULL,
  `fechaPago` DATE NULL DEFAULT NULL,
  `monto` INT NULL DEFAULT NULL,
  PRIMARY KEY (`idpago`),
  INDEX `idcompra_idx` (`idcompra` ASC) VISIBLE,
  CONSTRAINT `idcompra`
    FOREIGN KEY (`idcompra`)
    REFERENCES `mydb`.`tcompra` (`idcompra`))
ENGINE = InnoDB
DEFAULT CHARACTER SET = utf8mb4
COLLATE = utf8mb4_0900_ai_ci;


-- -----------------------------------------------------
-- Table `mydb`.`t_historial_estado`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `mydb`.`t_historial_estado` (
  `idhistorial` INT NOT NULL AUTO_INCREMENT,
  `idpago` INT NULL DEFAULT NULL,
  `descripcion` VARCHAR(45) NULL DEFAULT NULL,
  `fecha` DATE NULL DEFAULT NULL,
  PRIMARY KEY (`idhistorial`),
  INDEX `idpago_idx` (`idpago` ASC) VISIBLE,
  CONSTRAINT `idpago`
    FOREIGN KEY (`idpago`)
    REFERENCES `mydb`.`tpago` (`idpago`))
ENGINE = InnoDB
DEFAULT CHARACTER SET = utf8mb4
COLLATE = utf8mb4_0900_ai_ci;


-- -----------------------------------------------------
-- Table `mydb`.`t_unidad_ejecutora`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `mydb`.`t_unidad_ejecutora` (
  `idunidadejecutora` INT NOT NULL AUTO_INCREMENT,
  `identidad` INT NULL DEFAULT NULL,
  `descripcion` VARCHAR(45) NULL DEFAULT NULL,
  `estado` VARCHAR(45) NULL DEFAULT NULL,
  PRIMARY KEY (`idunidadejecutora`),
  INDEX `identidad_idx` (`identidad` ASC) VISIBLE,
  CONSTRAINT `identidad`
    FOREIGN KEY (`identidad`)
    REFERENCES `mydb`.`t_entidad` (`identidad`))
ENGINE = InnoDB
DEFAULT CHARACTER SET = utf8mb4
COLLATE = utf8mb4_0900_ai_ci;


-- -----------------------------------------------------
-- Table `mydb`.`tcliente`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `mydb`.`tcliente` (
  `idtcliente` INT NOT NULL AUTO_INCREMENT,
  `nombre` VARCHAR(45) NULL DEFAULT NULL,
  `apellido` VARCHAR(45) NULL DEFAULT NULL,
  `direccion` VARCHAR(45) NULL DEFAULT NULL,
  `telefono` INT NULL DEFAULT NULL,
  `numero_cuenta` INT NULL DEFAULT NULL,
  PRIMARY KEY (`idtcliente`))
ENGINE = InnoDB
AUTO_INCREMENT = 14
DEFAULT CHARACTER SET = utf8mb4
COLLATE = utf8mb4_0900_ai_ci;


-- -----------------------------------------------------
-- Table `mydb`.`tcuenta`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `mydb`.`tcuenta` (
  `idcuenta` INT NOT NULL AUTO_INCREMENT,
  `idtcliente` INT NULL DEFAULT NULL,
  `banco_nombre` VARCHAR(45) NULL DEFAULT NULL,
  `tipo_cuenta` VARCHAR(45) NULL DEFAULT NULL,
  PRIMARY KEY (`idcuenta`),
  INDEX `idcuenta_idx` (`idtcliente` ASC) VISIBLE,
  CONSTRAINT `idcuenta`
    FOREIGN KEY (`idtcliente`)
    REFERENCES `mydb`.`tcliente` (`idtcliente`))
ENGINE = InnoDB
DEFAULT CHARACTER SET = utf8mb4
COLLATE = utf8mb4_0900_ai_ci;


-- -----------------------------------------------------
-- Table `mydb`.`tfactura`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `mydb`.`tfactura` (
  `idfactura` INT NOT NULL AUTO_INCREMENT,
  `fechaFactura` VARCHAR(45) NULL DEFAULT NULL,
  `idtcliente` INT NULL DEFAULT NULL,
  `serie` VARCHAR(45) NULL DEFAULT NULL,
  `tipo` VARCHAR(45) NULL DEFAULT NULL,
  PRIMARY KEY (`idfactura`),
  INDEX `idtcliente_idx` (`idtcliente` ASC) VISIBLE,
  CONSTRAINT `idtcliente`
    FOREIGN KEY (`idtcliente`)
    REFERENCES `mydb`.`tcliente` (`idtcliente`))
ENGINE = InnoDB
DEFAULT CHARACTER SET = utf8mb4
COLLATE = utf8mb4_0900_ai_ci;


-- -----------------------------------------------------
-- Table `mydb`.`tproducto`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `mydb`.`tproducto` (
  `idproducto` INT NOT NULL AUTO_INCREMENT,
  `descripcion` VARCHAR(45) NULL DEFAULT NULL,
  `precio` INT NULL DEFAULT NULL,
  `marca` VARCHAR(45) NULL DEFAULT NULL,
  `fechaVencimiento` DATE NULL DEFAULT NULL,
  PRIMARY KEY (`idproducto`))
ENGINE = InnoDB
DEFAULT CHARACTER SET = utf8mb4
COLLATE = utf8mb4_0900_ai_ci;


-- -----------------------------------------------------
-- Table `mydb`.`tdetalle_factura`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `mydb`.`tdetalle_factura` (
  `idtdetalle_factura` INT NOT NULL AUTO_INCREMENT,
  `total` INT NULL DEFAULT NULL,
  `idproducto` INT NULL DEFAULT NULL,
  `cantidad` INT NULL DEFAULT NULL,
  `idfactura` INT NULL DEFAULT NULL,
  PRIMARY KEY (`idtdetalle_factura`),
  INDEX `idproducto_idx` (`idproducto` ASC) VISIBLE,
  INDEX `idfactura_idx` (`idfactura` ASC) VISIBLE,
  CONSTRAINT `idfactura`
    FOREIGN KEY (`idfactura`)
    REFERENCES `mydb`.`tfactura` (`idfactura`),
  CONSTRAINT `idproducto`
    FOREIGN KEY (`idproducto`)
    REFERENCES `mydb`.`tproducto` (`idproducto`))
ENGINE = InnoDB
DEFAULT CHARACTER SET = utf8mb4
COLLATE = utf8mb4_0900_ai_ci;


-- -----------------------------------------------------
-- Table `mydb`.`tproveedor`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `mydb`.`tproveedor` (
  `idproveedor` INT NOT NULL AUTO_INCREMENT,
  `nombre` VARCHAR(45) NULL DEFAULT NULL,
  `direccion` VARCHAR(45) NULL DEFAULT NULL,
  `telefono` INT NULL DEFAULT NULL,
  PRIMARY KEY (`idproveedor`))
ENGINE = InnoDB
DEFAULT CHARACTER SET = utf8mb4
COLLATE = utf8mb4_0900_ai_ci;


SET SQL_MODE=@OLD_SQL_MODE;
SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS;
SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS;
