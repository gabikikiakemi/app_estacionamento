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
CREATE SCHEMA IF NOT EXISTS mydb DEFAULT CHARACTER SET utf8 ;
USE mydb ;

-- -----------------------------------------------------
-- Table mydb.carro
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS mydb.carro (
  idcarro INT NOT NULL,
  modelo VARCHAR(45) NULL,
  placa VARCHAR(45) NULL,
  cor VARCHAR(45) NULL,
  PRIMARY KEY (idcarro))
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table mydb.vaga
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS mydb.vaga (
  idvaga INT NOT NULL,
  numero INT NULL,
  horario DATETIME(24) NULL,
  status VARCHAR(45) NULL,
  PRIMARY KEY (idvaga))
ENGINE = InnoDB;


SET SQL_MODE=@OLD_SQL_MODE;
SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS;
SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS;