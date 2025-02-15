USE SOFTUNI;
/1
CREATE TABLE IF NOT EXISTS DEPRATMENTS_INFO(
SELECT * FROM DEPARTMENTS
);
--------------
/2
CREATE TABLE IF NOT EXISTS DEPRATMENTS_INFO(
SELECT NAME FROM DEPARTMENTS
);
--------------
/3
CREATE TABLE IF NOT EXISTS EMPLOYEE_INFO(
SELECT FIRST_NAME,LAST_NAME,SALARY FROM EMPLOYEES
);
--------------
/4
CREATE TABLE IF NOT EXISTS EMPLOYEE_INFO(
SELECT FIRST_NAME,MIDDLE_NAME,LAST_NAME FROM EMPLOYEES
);
--------------
/5
CREATE TABLE IF NOT EXISTS EMPLOYEE_EMAIL(
SELECT concat( FIRST_NAME,".",LAST_NAME,"@SOFTUNI.BG") FROM EMPLOYEES
);
-------------
/6
CREATE TABLE IF NOT EXISTS EMPLOYEE_SALARY(
SELECT distinct(SALARY) FROM EMPLOYEES
);
--------------
/7
CREATE TABLE IF NOT EXISTS EMPLOYEE_INFO(
SELECT *  FROM EMPLOYEES
);
---------------
/8
CREATE TABLE IF NOT EXISTS EMPLOYEE_SALARY_BETWEEN(
SELECT FIRST_NAME,LAST_NAME,JOB_TITLE
FROM EMPLOYEES
WHERE SALARY BETWEEN 20000 AND 30000
);
--------------
/9
CREATE TABLE IF NOT EXISTS EMPLOYEE_NAMES(
SELECT CONCAT (FIRST_NAME,' ',MIDDLE_NAME,' ',LAST_NAME)
FROM EMPLOYEES
);
--------------
/10
CREATE TABLE IF NOT EXISTS EMPLOYEES_WITHOUT_MANAGER(
SELECT FIRST_NAME,LAST_NAME
FROM EMPLOYEES
WHERE MANAGER_ID IS NULL
);
-------------
/11
CREATE TABLE IF NOT EXISTS EMPLOYEES_SALARY(
SELECT FIRST_NAME,LAST_NAME,SALARY
FROM EMPLOYEES
WHERE SALARY>50000
);
-------------
/12
CREATE TABLE IF NOT EXISTS EMPLOYEES_SALARY(
SELECT FIRST_NAME,LAST_NAME
FROM EMPLOYEES
ORDER BY SALARY DESC LIMIT 5
);
-------------
/13
CREATE TABLE IF NOT EXISTS EMPLOYEES_NOT_MARKETING(
SELECT FIRST_NAME,LAST_NAME
FROM EMPLOYEES
WHERE DEPARTMENT_id <>4
);
-------------
/14
USE SOFTUNI;
CREATE TABLE IF NOT EXISTS EMPLOYEES_JOBS(
SELECT distinct JOB_TITLE
FROM EMPLOYEES
);
--------------
/15
CREATE TABLE IF NOT EXISTS FIRST_10_PROJECTS(
SELECT PROJECT_ID,NAME,DESCRIPTION,START_DATE,END_DATE
FROM PROJECTS
ORDER BY START_DATE ASC LIMIT 10
);
----------------
/16
CREATE TABLE IF NOT EXISTS FIRST_7_EMPLOYEES(
SELECT FIRST_NAME,LAST_NAME,HIRE_DATE
FROM EMPLOYEES
ORDER BY HIRE_DATE ASC LIMIT 7
);
------------------
/17
UPDATE EMPLOYEES
SET SALARY=SALARY+SALARY*0.12
WHERE DEPARTMENT_ID IN (1,2,4,11);
--------------------
/18
USE GEOGRAPHY;
CREATE TABLE IF NOT EXISTS PEAKS_NAMES
(
SELECT PEAK_NAME FROM PEAKS
);
--------------------
/19
CREATE TABLE IF NOT EXISTS PEAK_POPULATION
(
SELECT COUNTRY_NAME,POPULATION FROM COUNTRIES
ORDER BY POPULATION DESC LIMIT 30
);
--------------------
/20
CREATE TABLE IF NOT EXISTS COUNTRIES_CURRENCY
(
SELECT COUNTRY_NAME,COUNTRY_CODE,(CASE WHEN currency_code='EUR' THEN 'Euro' ELSE 'Not Euro' END)
 FROM COUNTRIES
);
---------------------
/21
USE diablo;
CREATE TABLE IF NOT EXISTS CHARACTERS_ABC
(
SELECT NAME
 FROM CHARACTERS
ORDER BY NAME
);
