PART 2
/*Course code : DATA1201
Term/Year : Winter 2018
Assignment code: GLA 4
Author : Scott Patterson
BVC username : s.patterson528
Date created : 2018-03-22
Description :IRDB_GLA 4 SQL FILE
*/


a.
SELECT Title
FROM albums
ORDER BY length (Title) DESC

b.
SELECT UPPER (Title)
FROM albums

c.
SELECT Address
FROM employees
WHERE INSTR ( Address, "SW")

d.
SELECT ABS (-1254545)

e.
SELECT RANDOM() as 'Random Number', EmployeeId,LastName,FirstName,Title 
FROM employees