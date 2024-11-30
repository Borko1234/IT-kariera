CREATE TABLE Persons (
    person_id INT NOT NULL,
    first_name VARCHAR(50),
    salary DECIMAL(10, 2),
    passport_id INT,
    PRIMARY KEY (person_id) 
);
INSERT INTO Persons (person_id, first_name, salary, passport_id)
VALUES
(1, 'Roberto', 43300.00, 102),
(2, 'Tom', 56100.00, 103),
(3, 'Yana', 60200.00, 101);
CREATE TABLE Passports (
    passport_id INT NOT NULL,
    passport_number VARCHAR(20),
    PRIMARY KEY (passport_id)
);
INSERT INTO Passports (passport_id, passport_number)
VALUES
(101, 'BG123456'),
(102, 'US654321'),
(103, 'UK987654');
ALTER TABLE Persons
ADD CONSTRAINT fk_passport
FOREIGN KEY (passport_id)
REFERENCES Passports(passport_id);
