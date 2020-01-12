

 CREATE PROC GetStudentsName @StudentName nvarchar(80)
 AS
	SELECT TOP 100 StudentName
	FROM TStudents
	WHERE StudentName LIKE @StudentName