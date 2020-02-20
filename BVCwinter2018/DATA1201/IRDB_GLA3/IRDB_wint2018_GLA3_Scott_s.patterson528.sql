/*Course code : DATA1201
Term/Year : Winter 2018
Assignment code: GLA 3
Author : Scott Patterson
BVC username : s.patterson528
Date created : 2018-03-13
Description :IRDB_GLA 3 SQL FILE
*/


--1. Putting Bud Powell into artists 
INSERT INTO artists (name)
VALUES
	('Bud Powell');
	
SELECT name
FROM artists
WHERE name IS 'Bud Powell'
--2.
INSERT INTO artists (name)
VALUES
	("Buddy Rich"),
	("Candido"),
	("Charlie Byrd");
SELECT *
FROM artists
WHERE NAME IS
	"Buddy Rich"
	 OR name LIKE
	"Candido"
	OR name LIKE
	"Charlie Byrd";
--3.

CREATE TABLE artists_backup(
	artistid INTEGER PRIMARY KEY AUTOINCREMENT,
	name NVARCHAR
);
INSERT INTO artists_backup SELECT
	artistid,
	name
FROM
	artists;
	
SELECT *
FROM artists_backup;

-- 4.
UPDATE employees
SET lastname = 'Smith'
WHERE
	employeeid = 3;
	
SELECT * 
FROM employees
WHERE employeeid = 3;

--5.

UPDATE employees
SET city ='Toronto',
	state = 'ON',
	postalcode = 'M5P 2N7'
WHERE
	employeeid = 4;
	
SELECT *
FROM employees
WHERE employeeid = 4;

--6

UPDATE employees
SET email = LOWER(
	firstname || "." || lastname || "@chinookcorp.com");
	
SELECT email
FROM employees

--7

DELETE 
FROM 
	artists_backup 
WHERE 
	artistid = 1;
	
SELECT *
FROM artists_backup;

--8

DELETE 
FROM 
	artists_backup;

SELECT *
FROM artists_backup

--9.1

INSERT INTO employees 
	(firstname, lastname, title)
VALUES 
	('April', 'Jones', 'Administrator');
	
	
	
SELECT *
FROM employees
WHERE firstname = 'April';

--9.2
SELECT *
FROM employees
WHERE firstname = 'April';

--9.3

CREATE TABLE employees_copy
AS SELECT * 
FROM employees

SELECT * 
FROM employees_copy

--9.4

UPDATE employees_copy
SET email = 'april@chinookcorp.com'
WHERE employeeid = 9;

SELECT * 
FROM employees_copy
WHERE employeeid =9;

--9.5

DELETE 
FROM employees_copy
WHERE employeeid = 9;


SELECT * 
FROM employees_copy