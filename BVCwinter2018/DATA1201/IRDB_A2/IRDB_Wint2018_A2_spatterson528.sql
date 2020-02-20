/*Course code : DATA1201
Term/Year : Winter 2018
Assignment code: A2
Author : Scott Patterson
BVC username : s.patterson528
Date created : 2018-02-27
Description :IRDB_Assignment #2 SQL FILE

*/


USE master;
GO

IF  DB_ID('IRDB_A2') IS NOT NULL
    DROP DATABASE IRDB_A2;
GO

CREATE DATABASE IRDB_A2;
GO

USE IRDB_A2;


CREATE TABLE Publications(
	PublicationID		INT				PRIMARY KEY IDENTITY,
	AuthorFirstName		VARCHAR(60)		NOT NULL,
	AuthorLastName		VARCHAR(60)		NOT NULL,
	Abstract			VARCHAR(255)	DEFAULT NULL
);
CREATE TABLE Institutions(
	InstitutionsID		INT				PRIMARY KEY IDENTITY,
	InstitutionName		VARCHAR(120)	NOT NULL,
	SchoolName			VARCHAR(120)	NOT NULL	UNIQUE,
	Country				VARCHAR(120)	NOT NULL,
	InaugurationYear	INT				NOT NULL,
);
CREATE TABLE ProjectTeam(
	TeamID				INT				PRIMARY KEY IDENTITY,
	ProjectID			INT				UNIQUE,
	GrantMoney			MONEY			NOT NULL,
	ProjectStart		DATE			NOT NULL,
	ProjectEnd			DATE			DEFAULT NULL
);

CREATE TABLE Project(
	ProjectID			INT				REFERENCES ProjectTeam (ProjectID),
	ResearchTitle		VARCHAR(120)	NOT NULL
);
CREATE TABLE Researchers(
	ResearcherID		INT				PRIMARY KEY	IDENTITY,
	TeamID				INT				REFERENCES ProjectTeam (TeamID),
	FirstName			VARCHAR(60)		NOT NULL,
	LastName			VARCHAR(60)		NOT NULL,
	InstitutionsID		INT				REFERENCES Institutions (InstitutionsID),
	CurrentPosition		VARCHAR(60)		DEFAULT NULL,
	YearOfBirth			INT				NOT NULL,
	HighestDegree		VARCHAR(3)		DEFAULT NULL	
);
CREATE TABLE Professors(
	ProfID				INT				PRIMARY KEY IDENTITY,
	TeamID				INT				REFERENCES ProjectTeam (TeamID),
	InstitutionsID		INT				REFERENCES Institutions (InstitutionsID),
	ProfFirstName		VARCHAR(60)		NOT NULL,
	ProfLastName		VARCHAR(60)		NOT NULL,
);
CREATE TABLE Collabs(
	PaperID				INT				PRIMARY KEY IDENTITY,
	PublicationID		INT				REFERENCES Publications (PublicationID),
	AuthorFirstName		VARCHAR(60)		NOT NULL,
	AuthorLastName		VARCHAR(60)		NOT NULL,
	CoAuthorFirstName	VARCHAR(60)		NOT NULL,
	CoAuthorLastName	VARCHAR(60)		NOT NULL,
);
CREATE TABLE School(
	ResearcherID		INT				REFERENCES Researchers (ResearcherID),
	InstitutionsID		INT				REFERENCES Institutions (InstitutionsID)

);
