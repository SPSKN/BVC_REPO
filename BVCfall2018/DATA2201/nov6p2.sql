CREATE TYPE StudentBatch AS TABLE(
	StudentId int NOT NULL,
	StudentName nvarchar(80) NOT NULL
)
GO



CREATE PROC AddStudentBatch
	@LineItems StudentBatch READONLY
AS
	INSERT INTO TStudents
	SELECT * FROM @LineItems
GO



DECLARE @NewLineItems AS StudentBatch;
INSERT INTO @NewLineItems VALUES (1,'TREE');


EXEC AddStudentBatch @LineItems = @NewLineItems

SELECT * FROM TStudents
SELECT * FROM @NewLineItems
