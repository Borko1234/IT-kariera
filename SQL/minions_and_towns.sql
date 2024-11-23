CREATE SCHEMA IF NOT EXISTS minions;
USE minions;
CREATE TABLE IF NOT EXISTS Minions
(
	Id int auto_increment PRIMARY KEY,
    Name VARCHAR(50) NOT NULL,
    Age int NOT NULL
);
CREATE TABLE IF NOT EXISTS Towns
(
	Id int auto_increment PRIMARY KEY,
    Name VARCHAR(50) NOT NULL
);
ALTER TABLE Minions 
ADD COLUMN town_id INT;
ALTER TABLE Minions
ADD CONSTRAINT fk_minions_towns
    FOREIGN KEY (town_id)
    REFERENCES Towns(id);
INSERT INTO Towns(Name) VALUES ('Sofia');
INSERT INTO Towns(Name) VALUES('Plovdiv');
INSERT INTO Towns(Name) VALUES('Varna');
INSERT INTO Minions(Name,Age,town_id) VALUES('Kevin',22,1);
INSERT INTO Minions(Name,Age,town_id) VALUES('Bob',13,3);
INSERT INTO Minions(Name,Age,town_id) VALUES('Steward',10,2);
TRUNCATE Minions;