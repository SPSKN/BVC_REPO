DROP PROC AddUser

CREATE PROCEDURE AddUser
(
@FirstName nvarchar(40), 
@LastName nvarchar(40), 
@Password nvarchar(40), 
@EmailAddress nvarchar(80)
)
 
AS 

INSERT INTO [TUser] ( [FirstName], [LastName], [UserName])
 VALUES (@FirstName, @LastName, CONCAT(@FirstName, @LastName))
 INSERT INTO [TPasswordHistory] ([PasswordChar])
 VALUES (@Password)
 INSERT INTO [TLogin] ([EmailAddress])
 VALUES (@EmailAddress)

GO


EXEC AddUser @FirstName='Scott',@LastName='Patterson',@Password='water',@EmailAddress='hotdog@hotmail.com'