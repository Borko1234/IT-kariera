CREATE TABLE Manufacturers (
    manufacturer_id INT NOT NULL,
    name VARCHAR(50) NOT NULL,
    established_on DATE NOT NULL,
    PRIMARY KEY (manufacturer_id)
);

INSERT INTO Manufacturers (manufacturer_id, name, established_on)
VALUES
(1, 'BMW', '1916-03-01'),
(2, 'Tesla', '2003-01-01'),
(3, 'Lada', '1966-05-01');
CREATE TABLE Cars (
    car_id INT NOT NULL,
    model_name VARCHAR(50) NOT NULL,
    manufacturer_id INT NOT NULL,
    PRIMARY KEY (car_id),
    CONSTRAINT fk_manufacturer
        FOREIGN KEY (manufacturer_id) REFERENCES Manufacturers(manufacturer_id) 
);

INSERT INTO Cars (car_id, model_name, manufacturer_id)
VALUES
(1, 'i8', 1), 
(2, 'Model S', 2), 
(3, 'Niva', 3); 
