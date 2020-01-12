/*Question 5*Worked*/
ALTER TABLE TRegistrations
ADD PK_Reg INT PRIMARY KEY(CourseId, StudentId);

/*Question 6 Worked*/
ALTER TABLE TRegistrations
ADD date_time datetime2;

/*Question 7 Worked*/
ALTER TABLE TRegistrations
ADD CONSTRAINT FinalGrade DEFAULT 0;

/*Question8*/
ALTER TABLE TRegistrations
ADD CHECK (date_time >=2018-09-01 AND 08:00:00);

/*Question 9 Worked*/
ALTER TABLE TStudents
ALTER COLUMN StudentName nvarchar(80) NOT NULL ;

/*Question 10 Worked*/
ALTER TABLE TStudents
ADD CONSTRAINT StudentId UNIQUE(StudentId);

/*QUESTION 11 Worked*/
ALTER TABLE TCourses
ADD CONSTRAINT CourseId UNIQUE(CourseId);

/*QUESTION 12 Worked*/
ALTER TABLE TCourses
ALTER COLUMN CourseName nvarchar(80)  NOT NULL;

/*Question 13 Worked*/
ALTER TABLE TCourses
ADD CONSTRAINT CourseName UNIQUE(CourseName);

/*Question 14 Worked*/
ALTER TABLE TRegistrations
/*ALTER COLUMN StudentId INT NOT NULL*/
ADD FOREIGN KEY (StudentId) REFERENCES TStudents(StudentId);

 /*Question 15 worked*/

 ALTER TABLE TRegistrations
 ADD FOREIGN KEY (CourseId) REFERENCES TCourses(CourseId);
 /*Question 16*/
 /*
 ALTER TABLE TRegistrations
 ADD CHECK
 */
