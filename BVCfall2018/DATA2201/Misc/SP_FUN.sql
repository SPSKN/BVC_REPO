USE spatterson528;
GO
----SP
CREATE PROC spGetStudents
AS

SELECT * FROM TStudents
WHERE StudentId = 1;


------ EXEC SP
EXEC spGetStudents

/* CHECKS


SELECT * FROM TCourses
SELECT * FROM TRegistrations


*/