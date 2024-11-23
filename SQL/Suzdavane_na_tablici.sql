CREATE SCHEMA minions;
use minions;
CREATE TABLE minions
(
Id INT AUTO_INCREMENT,
name VARCHAR(50) NOT NULL,
age INT NOT NULL,
PRIMARY KEY(Id)
);
INSERT INTO minions(name,age) VALUES('gosho',10);
INSERT INTO minions(name,age) VALUES('misho',14);
INSERT INTO minions(name,age) VALUES('ivan',17);
INSERT INTO minions(name,age) VALUES ('pesho',23);
INSERT INTO minions(name,age) VALUES('petko',4);
INSERT INTO minions(name,age) VALUES('aleks',4);
CREATE TABLE town
(
Id INT AUTO_INCREMENT,
name VARCHAR(50) NOT NULL,
PRIMARY KEY(Id)
);
INSERT INTO town (name) VALUES ('SigmaTown');
INSERT INTO town (name) VALUES ('SkibidiTown');
INSERT INTO town (name) VALUES('TiltedTowers');
