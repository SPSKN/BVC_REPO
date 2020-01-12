--4
DROP PROCEDURE AuthenticateUser
CREATE PROCEDURE dbo.AuthenticateUser
@Email nvarchar(80),
@Password nvarchar(40)
AS
BEGIN
SELECT * FROM TUser WHERE Email = @Email AND [Password] = PWDENCRYPT(@Password)
END

EXEC AuthenticateUser