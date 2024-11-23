CREATE SCHEMA IF NOT EXISTS car_rental;
USE car_rental;
CREATE TABLE categories(
id INT AUTO_INCREMENT PRIMARY KEY,
category VARCHAR(50) NOT NULL,
daily_rate INT,
weekly_rate INT,
monthly_rate INT,
weekend_rate INT
);
CREATE TABLE cars(
id INT AUTO_INCREMENT PRIMARY KEY,
 plate_number VARCHAR(10), 
 make VARCHAR(50), 
 model VARCHAR(50), car_year DATE, 
 category_id INT NOT NULL,
 doors INT , picture BLOB,
car_condition VARCHAR(50),
 available BOOL
);
ALTER TABLE cars
ADD CONSTRAINT fk_car_categories
    FOREIGN KEY (category_id)
    REFERENCES categories(id);
CREATE TABLE employees(
id INT AUTO_INCREMENT PRIMARY KEY,
first_name VARCHAR(50) NOT NULL, 
last_name VARCHAR(50) NOT NULL,
title VARCHAR(50) NOT NULL,
notes VARCHAR(500)
);
CREATE TABLE customers(
id INT AUTO_INCREMENT PRIMARY KEY,
 driver_licence_number VARCHAR(10),
 full_name VARCHAR (150),
 address VARCHAR(500),
 city VARCHAR(500) NOT NULL,
 zip_code VARCHAR(10) NOT NULL,
 notes TEXT 
);
CREATE TABLE rental_order(
id INT AUTO_INCREMENT PRIMARY KEY,
employee_id INT NOT NULL,
customer_id INT NOT NULL,
 car_id INT NOT NULL, 
 car_condition VARCHAR(500), 
 tank_level DOUBLE(10,2),
kilometrage_start INT NOT NULL, 
kilometrage_end INT NOT NULL,
 start_date DATE NOT NULL,
 end_date DATE NOT NULL,
 rate_applied VARCHAR(500),
 tax_rate INT NOT NULL,
 order_status BOOL, notes TEXT
);
ALTER TABLE rental_orders
ADD CONSTRAINT fk_order_employees
 FOREIGN KEY (order_employees_id)
 REFERENCES employee(id);
 ALTER TABLE rental_orders
ADD CONSTRAINT fk_order_customers
 FOREIGN KEY (order_customer_id)
 REFERENCES customers(id);
ALTER TABLE rental_orders
ADD CONSTRAINT fk_order_car
 FOREIGN KEY (car_id)
 REFERENCES cars(id);
 
 INSERT INTO cars (plate_number, make, model, car_year, category_id, doors, picture, car_condition, available)
VALUES
    ('AB123CD', 'Toyota', 'Corolla', '2019-01-01', 1, 4, NULL, 'OLD', TRUE),
    ('EF456GH', 'Honda', 'CR-V', '2020-05-10', 2, 5, NULL, 'NEW', TRUE),
    ('IJ789KL', 'BMW', 'X5', '2022-03-15', 3, 5, NULL, 'NEW', TRUE),
    ('MN012OP', 'Ford', 'Mustang', '2021-07-20', 4, 2, NULL, 'New', TRUE); 


INSERT INTO categories (category, daily_rate, weekly_rate, monthly_rate, weekend_rate)
VALUES
    ('Economy', 30, 180, 600, 50),
    ('SUV', 60, 360, 1200, 100),
    ('Luxury', 120, 720, 2400, 200),
    ('Convertible', 90, 540, 1800, 150);
    INSERT INTO customers (driver_licence_number, full_name, address, city, zip_code, notes)
VALUES
    ('A123456789', 'Robert Brown', '123 Elm Street', 'Los Angeles', '90001', 'Frequent customer'),
    ('B987654321', 'Maria Garcia', '456 Maple Avenue', 'San Francisco', '94101', 'First-time renter');
INSERT INTO employees (first_name, last_name, title, notes)
VALUES
    ('John', 'Doe', 'Manager', 'Experienced in car rental management'),
    ('Jane', 'Smith', 'Sales Associate', 'Focuses on customer service and sales'),
    ('Alice', 'Johnson', 'Mechanic', 'Specializes in car repairs and maintenance');
    INSERT INTO rental_order (employee_id, customer_id, car_id, car_condition, tank_level, kilometrage_start, kilometrage_end, start_date, end_date, rate_applied, tax_rate, order_status, notes)
VALUES
    (1, 1, 1, 'Clean', 100.00, 1000, 1200, '2024-11-01', '2024-11-05', 'Economy Daily Rate', 15, TRUE, 'Customer rented for a business trip'),
    (2, 2, 3, 'New', 90.00, 500, 650, '2024-11-03', '2024-11-10', 'Luxury Weekly Rate', 10, TRUE, 'Customer rented for vacation');
    




