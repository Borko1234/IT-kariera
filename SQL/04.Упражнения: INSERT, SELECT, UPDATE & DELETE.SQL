/1
USE SOFTUNI;
INSERT INTO TOWNS(NAME)
VALUES ('Sofia'),
    ('Plovdiv'),
    ('Varna'),
    ('Burgas');


INSERT INTO DEPARTMENTS(NAME)
VALUES ('Engineering'),
    ('Sales'),
    ('Marketing'),
    ('Software'),
    ('Development'),
    ('Quality Assurance');


INSERT INTO Employees (FirstName, LastName, JobTitle, DepartmentID, TownID, HireDate, Salary)
VALUES 
    ('Ivan', 'Ivanov', 'Engineer', (SELECT DepartmentID FROM Departments WHERE Name = 'Engineering'), (SELECT TownID FROM Towns WHERE Name = 'Sofia'), '2020-05-15', 3000),
    ('Maria', 'Petrova', 'Sales Representative', (SELECT DepartmentID FROM Departments WHERE Name = 'Sales'), (SELECT TownID FROM Towns WHERE Name = 'Plovdiv'), '2018-09-10', 2800),
    ('Georgi', 'Dimitrov', 'Marketing Specialist', (SELECT DepartmentID FROM Departments WHERE Name = 'Marketing'), (SELECT TownID FROM Towns WHERE Name = 'Varna'), '2021-03-20', 2600),
    ('Elena', 'Georgieva', 'Software Developer', (SELECT DepartmentID FROM Departments WHERE Name = 'Software Development'), (SELECT TownID FROM Towns WHERE Name = 'Burgas'), '2019-11-01', 4000),
    ('Nikolay', 'Nikolov', 'QA Engineer', (SELECT DepartmentID FROM Departments WHERE Name = 'Quality Assurance'), (SELECT TownID FROM Towns WHERE Name = 'Sofia'), '2022-07-25', 3500);


/2

SELECT * FROM Towns;

SELECT * FROM Departments;

SELECT * FROM Employees;


/3

SELECT Name FROM Towns;

SELECT Name FROM Departments;

SELECT FirstName, LastName, JobTitle, Salary FROM Employees;

/4

UPDATE Employees
SET Salary = Salary * 1.10;

SELECT Salary FROM Employees;
