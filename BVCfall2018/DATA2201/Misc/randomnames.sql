-- -- Delete table(s) if they already exist. -- 
 
IF (EXISTS (SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_SCHEMA = 'dbo' AND TABLE_NAME = 'TStudents')) DROP TABLE TStudents 
GO 
 
-- -- Create TStudents table. -- 
 
CREATE TABLE TStudents (  StudentId int,  StudentName nvarchar(80) ) 
 
-- -- Populate TStudents by adding a whole bunch of random students. -- 

DECLARE @Counter int = 0 DECLARE @Iterations int = 10000000
 
WHILE @Counter < @Iterations BEGIN 
 
 DECLARE @StudentName nvarchar(80) = '';  DECLARE @StudentId int = CAST(RAND() * 1000000 as int);  DECLARE @NameLength int = 0; 
 
 SET @NameLength = CAST(RAND() * 10 as int) + 5  WHILE @NameLength <> 0  BEGIN   SELECT @StudentName = @StudentName + CHAR(CAST((RAND() * 24) + 65 as int))   SET @NameLength = @NameLength - 1  END 
 
 INSERT INTO TStudents (StudentId, StudentName) VALUES (@StudentId, @StudentName) 
 
 SET @Counter = @Counter + 10
 
END