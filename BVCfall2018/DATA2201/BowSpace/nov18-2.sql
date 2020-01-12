-- DROP PROC SearchUser


--2



CREATE PROCEDURE SearchUser
@UserId int,
@UserName nvarchar(80)
AS
SELECT UserId, UserName FROM TUser
WHERE UserID LIKE '@UserId' OR UserName LIKE '@UserName'
FOR JSON AUTO


EXEC SearchUser @UserId=1,@UserName='%L'