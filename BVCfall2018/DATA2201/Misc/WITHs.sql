CREATE TABLE TEmployee(
EmployeeName nvarchar(60) NOT NULL,
ManagersName nvarchar(60) NOT NULL
)


INSERT INTO TEmployee (Employeename,ManagersName) VALUES('Annalee Amidon','Gisele Gordy')
INSERT INTO TEmployee (Employeename,ManagersName) VALUES('Katy Kroner','Tracy Teeter')
INSERT INTO TEmployee (Employeename,ManagersName) VALUES('Gisele Gordy','Nobody')
INSERT INTO TEmployee (Employeename,ManagersName) VALUES('Arnita Arias','Annalee Amidon')
INSERT INTO TEmployee (Employeename,ManagersName) VALUES('Tracy Teeter','Katherina Kensinger')
INSERT INTO TEmployee (Employeename,ManagersName) VALUES('Daniel Dossantos','Katherina Kensinger')
INSERT INTO TEmployee (Employeename,ManagersName) VALUES('Deandrea Defrancisco','Annalee Amidon')
INSERT INTO TEmployee (Employeename,ManagersName) VALUES('Sylvie Sae','Felice Finnell')
INSERT INTO TEmployee (Employeename,ManagersName) VALUES('Katherina Kensinger','Gisele Gordy')
INSERT INTO TEmployee (Employeename,ManagersName) VALUES('Cara Coney   ','Jacalyn Jeremiah')
INSERT INTO TEmployee (Employeename,ManagersName) VALUES('Jin Jusino','Felice Finnell')
INSERT INTO TEmployee (Employeename,ManagersName) VALUES('Felice Finnell','Annalee Amidon')
INSERT INTO TEmployee (Employeename,ManagersName) VALUES('Pura Peredo','Felice Finnell')
INSERT INTO TEmployee (Employeename,ManagersName) VALUES('Jacalyn Jeremiah','Gisele Gordy')
INSERT INTO TEmployee (Employeename,ManagersName) VALUES('Marge Milbourn','Tracy Teeter')
INSERT INTO TEmployee (Employeename,ManagersName) VALUES('Yang Yin','Annalee Amidon')
INSERT INTO TEmployee (Employeename,ManagersName) VALUES('Precious Precourt','Jacalyn Jeremiah')
INSERT INTO TEmployee (Employeename,ManagersName) VALUES('Oscar Ordaz','Georgette Gately')
INSERT INTO TEmployee (Employeename,ManagersName) VALUES('Georgette Gately','Gisele Gordy')
INSERT INTO TEmployee (Employeename,ManagersName) VALUES('Shanti Studley','Jacalyn Jeremiah')

SELECT * FROM TEmployee






;WITH OrgTrees (EmployeeName, ManagersName,Tree)
AS
(
   SELECT EmployeeName,ManagersName, 0 AS Tree 
   FROM TEmployee
   WHERE ManagersName = 'Nobody'
   UNION ALL
   SELECT TEmployee.EmployeeName, OrgTrees.Tree + 1
   FROM TEmployee
   JOIN OrgTrees ON TEmployee.EmployeeName = OrgTrees.EmployeeName
)
 
SELECT * FROM OrgTrees ORDER BY Tree