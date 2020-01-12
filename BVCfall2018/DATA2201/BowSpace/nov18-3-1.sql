--3


CREATE PROCEDURE RegisterUser
--TUser
	@UserID	int,
	@FirstName nvarchar(40) ,
	@LastName nvarchar(40) ,
	@UserName nvarchar(80) ,
--TLogin
	@Email nvarchar(80),
	@PasswordID int,
--TPassword History
	@PasswordChar nvarchar(40),
	@ValidFrom datetime2,
	@ValidTo datetime2
AS
BEGIN TRANSACTION
INSERT INTO TPasswordHistory(PasswordID,PasswordChar,ValidFromUTC,ValidToUTC) 
VALUES (@PasswordID,@PasswordChar,@ValidFrom,@ValidTo)

INSERT INTO TUser (UserID,FirstName,LastName, UserName) 
VALUES (@UserId,@FirstName,@LastName,@UserName)

INSERT INTO TLogin(UserID,EmailAddress,PasswordID)
VALUES (@UserID,@Email,@PasswordID)

COMMIT


EXEC PROC RegisterUser