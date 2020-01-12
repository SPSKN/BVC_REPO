USE master

go

/* Database IRDB_LA5 */
IF DB_ID('IRDB_A1') IS NOT NULL

	DROP DATABASE IRDB_LA5
GO

CREATE DATABASE IRDB_LA5
GO

USE IRDB_LA5
GO

/*Creating the table */
CREATE TABLE Users(
	EmailAddress varchar(50) NOT NULL,
	FirstName varchar(50) NOT NULL,
	LastName varchar(50) NOT NULL
	)
	GO