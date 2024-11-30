CREATE SCHEMA STUDENTS;
USE STUDENTS;
CREATE TABLE Students (
    student_id INT NOT NULL,
    name VARCHAR(50) NOT NULL,
    PRIMARY KEY (student_id)
);
CREATE TABLE Exams (
    exam_id INT NOT NULL,
    subject VARCHAR(100), 
    PRIMARY KEY (exam_id) 
);
CREATE TABLE Students_Exams (
    student_id INT NOT NULL,
    exam_id INT NOT NULL,
    PRIMARY KEY (student_id, exam_id), 
    CONSTRAINT fk_student
        FOREIGN KEY (student_id) 
        REFERENCES Students(student_id), 
    CONSTRAINT fk_exam
        FOREIGN KEY (exam_id) 
        REFERENCES Exams(exam_id)
);

INSERT INTO Students (student_id, name)
VALUES
(1, 'Mila'),
(2, 'Toni'),
(3, 'Bob');
INSERT INTO Exams (exam_id, subject)
VALUES
(101, 'Mathematics'),
(102, 'Physics'),
(103, 'Chemistry');
INSERT INTO Students_Exams (student_id, exam_id)
VALUES
(1, 101),
(1, 102),
(2, 101),
(3, 103),
(2, 102),
(2, 103);
