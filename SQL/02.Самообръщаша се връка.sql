CREATE SCHEMA TEACHERS;
USE TEACHERS;
CREATE TABLE TEACHERS
(
    teacher_id INT AUTO_INCREMENT PRIMARY KEY,
    teacher_name VARCHAR(50) NOT NULL,
    manager_id INT NULL
) AUTO_INCREMENT=100;
ALTER TABLE TEACHER
ADD CONSTRAINT fk_manager_id
FOREIGN KEY (manager_id) 
REFERENCES TEACHER(teacher_id);

INSERT INTO TEACHER (teacher_name, manager_id)
VALUES
('John', NULL),
('Maya', NULL),
('Silvia', NULL),
('Ted', NULL),
('Mark', NULL),
('Greta', NULL);

update  TEACHER set manager_id = 106
where teacher_id=100;
update  TEACHER set manager_id = 106
where teacher_id=101;
update  TEACHER set manager_id = 105
where teacher_id=102;
update  TEACHER set manager_id = 104
where teacher_id=103;
update  TEACHER set manager_id = 103
where teacher_id=105;



