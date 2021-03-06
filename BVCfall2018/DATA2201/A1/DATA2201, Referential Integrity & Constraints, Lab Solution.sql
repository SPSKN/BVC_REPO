--
-- Solution for DATA2201 Constraints Lab
--
-- You can run this entire script because it is intended to be deterministic.  Note that some errors will show
-- as the queries near the end of the lab try to violate constraints.  This is intentional and you can see
-- that the constraints you've added actually work to protect referential integrity in your database.
--

USE [spatterson528] -- Change to match your database.
GO

--
-- Delete tables if they already exist.
--

IF (EXISTS (SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_SCHEMA = 'dbo' AND TABLE_NAME = 'TRegistrations')) DROP TABLE TRegistrations
IF (EXISTS (SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_SCHEMA = 'dbo' AND TABLE_NAME = 'TStudents')) DROP TABLE TStudents
IF (EXISTS (SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_SCHEMA = 'dbo' AND TABLE_NAME = 'TCourses')) DROP TABLE TCourses
GO

--
-- Create TStudents table.
--

CREATE TABLE TStudents (
	StudentId int PRIMARY KEY,																							-- Item #10
	StudentName nvarchar(80) NOT NULL																					-- Item #9
)

--
-- Create TCourses table.
--

CREATE TABLE TCourses (
	CourseId int PRIMARY KEY,																							-- Item #11
	CourseName nvarchar(80) NOT NULL UNIQUE																				-- Item #12, Item #13
)

--
-- Create TRegistrations table.
--

CREATE TABLE TRegistrations (
	CourseId int FOREIGN KEY REFERENCES TCourses(CourseId),																-- Item #15
	StudentId int FOREIGN KEY REFERENCES TStudents(StudentId) ON DELETE CASCADE,										-- Item #14, Item #23
	RegistrationDateUtc datetime2 NOT NULL DEFAULT GETUTCDATE(),														-- Item #6
	FinalGrade int NOT NULL DEFAULT 0 CHECK (FinalGrade >= 0 AND FinalGrade <= 100),									-- Item #7, Item #17
	CONSTRAINT PK_Registrations PRIMARY KEY (CourseId, StudentId),														-- Item #5, Item #16
	CONSTRAINT CheckDate CHECK (RegistrationDateUtc >= CONVERT(datetime2, '2018-09-01T08:00:00'))						-- Item #8
)
GO

--
-- Populate tables.
--

INSERT INTO TStudents (StudentId, StudentName) 
SELECT 1, N'Student #1'
UNION
SELECT 2, N'Student #2'
UNION
SELECT 3, N'Student #3'
GO

INSERT INTO TCourses (CourseId, CourseName) 
SELECT 1001, N'Course A'
UNION
SELECT 1002, N'Course B'
UNION
SELECT 1003, N'Course C'
UNION
SELECT 1004, N'Course D'
UNION
SELECT 1005, N'Course E'
GO

INSERT INTO TRegistrations (StudentId, CourseId) 
SELECT 1, 1001
UNION
SELECT 1, 1002
UNION
SELECT 1, 1003
UNION
SELECT 1, 1004
UNION
SELECT 2, 1003
UNION
SELECT 2, 1004
UNION
SELECT 2, 1005
UNION
SELECT 3, 1001
UNION
SELECT 3, 1003
UNION
SELECT 3, 1005
GO

--
-- Test Queries
--

INSERT INTO TRegistrations (StudentId, CourseId) SELECT 9999, 1001																-- Item #18 fails
INSERT INTO TRegistrations (StudentId, CourseId) SELECT 1, 9999																	-- Item #19 fails
INSERT INTO TRegistrations (StudentId, CourseId) SELECT 1, 1001																	-- Item #20 fails
UPDATE TRegistrations SET FinalGrade=125 WHERE StudentId=2 AND CourseId=1004													-- Item #21 fails
UPDATE TRegistrations SET RegistrationDateUtc=CONVERT(datetime2, '2018-07-01T08:00:00') WHERE StudentId=3 AND CourseId=1003		-- Item #22 fails
DELETE FROM TStudents WHERE StudentId = 1																						-- Item #23 cascades
GO

--
-- Generate report of courses, students, dates, grades.
--

SELECT R.CourseId, C.CourseName, R.StudentId, S.StudentName, R.RegistrationDateUtc, R.FinalGrade FROM TRegistrations R
	LEFT JOIN TCourses C ON R.CourseId = C.CourseId
	LEFT JOIN TStudents S ON R.StudentId = S.StudentId

--
-- Generate summary report of courses and total students registered.
--

SELECT R.CourseId, C.CourseName, COUNT(R.StudentId) AS TotalStudentsRegistered FROM TRegistrations R
	LEFT JOIN TCourses C ON R.CourseId = C.CourseId
	GROUP BY R.CourseId, C.CourseName

SELECT * FROM  INFORMATION_SCHEMA.TABLE_CONSTRAINTS 
