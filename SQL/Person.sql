CREATE SCHEMA IF NOT EXISTS people;
USE people;
CREATE TABLE users(
Id int AUTO_INCREMENT PRIMARY KEY,
Name VARCHAR(200) NOT NULL,
Picture BLOB ,
Height DECIMAL(10,2),
Weight DECIMAL(10,2),
Gender CHAR(1) NOT NULL,
Birthday DATE NOT NULL,
Biography  TEXT
);
INSERT INTO users (Name, Picture, Height, Weight, Gender, Birthday, Biography)
VALUES
('Alice', NULL, 1.70, 65.5, 'F', '1990-01-15', 'Alice is a software developer who enjoys coding and coffee.'),
('Bob', NULL, 1.80, 75.0, 'M', '1985-03-22', 'Bob loves traveling and outdoor adventures.'),
('Charlie', NULL, 1.65, 70.0, 'M', '1992-07-05', 'Charlie is a graphic designer with a passion for digital art.'),
('Dana', NULL, 1.60, 55.5, 'F', '1994-10-30', 'Dana is a photographer who captures nature in her shots.'),
('Eva', NULL, 1.75, 60.0, 'F', '1988-11-05', 'Eva is a fitness trainer and health enthusiast.');
