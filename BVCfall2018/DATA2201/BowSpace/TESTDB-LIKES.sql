CREATE DATABASE TestDB;

USE [TestDB]
GO

IF (EXISTS (SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_SCHEMA = 'dbo' AND TABLE_NAME = 'TLike')) DROP TABLE TLike
IF (EXISTS (SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_SCHEMA = 'dbo' AND TABLE_NAME = 'TPost')) DROP TABLE TPost 
IF (EXISTS (SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_SCHEMA = 'dbo' AND TABLE_NAME = 'TLogin')) DROP TABLE TLogin
IF (EXISTS (SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_SCHEMA = 'dbo' AND TABLE_NAME = 'TPasswordHistory')) DROP TABLE TPasswordHistory
IF (EXISTS (SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_SCHEMA = 'dbo' AND TABLE_NAME = 'TUser')) DROP TABLE TUser 
GO

CREATE TABLE TPasswordHistory(
	PasswordID		int IDENTITY (1, 1) UNIQUE,
	PasswordChar	nvarchar(40) NOT NULL,
	ValidFromUTC	datetime2 NOT NULL DEFAULT GETUTCDATE(),
	ValidToUTC		datetime2 DEFAULT NULL,
	PRIMARY KEY		(PasswordID)
)

CREATE TABLE TUser(
	UserID			int IDENTITY (1, 1) UNIQUE,
	FirstName		nvarchar(40) NOT NULL,
	LastName		nvarchar(40) NOT NULL,
	UserName		nvarchar(80) NOT NULL,
	PRIMARY KEY		(UserID)
)

CREATE TABLE TLogin(
	UserID			int FOREIGN KEY REFERENCES TUser(UserID),
	EmailAddress	nvarchar(80) UNIQUE NOT NULL,
	PasswordID		int FOREIGN KEY REFERENCES TPasswordHistory(PasswordID),
	PRIMARY KEY		(EmailAddress) 
)

CREATE TABLE TPost(
	PostID			int IDENTITY (1, 1) UNIQUE,
	SenderID		int FOREIGN KEY REFERENCES TUser(UserID),
	ReciepentID		int FOREIGN KEY REFERENCES TUser(UserID),
	TextPost		nvarchar(1000)NOT NULL, 
	DatePosted		datetime2 NOT NULL DEFAULT GETUTCDATE(),
	PRIMARY KEY		(PostID)
)

CREATE TABLE TLike(
	UserID			int FOREIGN KEY REFERENCES TUser(UserID),
	PostID			int FOREIGN KEY REFERENCES TPost(PostID),
	PRIMARY KEY		(UserId, PostID)
)

/*
INSERTS
*/

SET IDENTITY_INSERT dbo.TPasswordHistory ON;  
GO 

INSERT INTO TPasswordHistory(PasswordID,PasswordChar,ValidFromUTC) 
VALUES('3','123456','2/1/2018 10:27PM'),
	  ('5','areyouprofessional?','4/28/2018 6:27PM'),
	  ('6','science','10/18/2018 3:16AM'),
	  ('7','password','4/28/2018 6:27PM'),
	  ('8','password','4/28/2018 6:27PM'),
	  ('9','doggy','4/28/2018 6:27PM'),
	  ('11','HardestWorkerInTheRoom','11/18/2018 04:18AM')

INSERT INTO TPasswordHistory(PasswordID,PasswordChar,ValidFromUTC,ValidToUTC) 
VALUES ('1','123','1/1/2018 10:06AM','2/1/2018 10:06PM'),
	   ('2','abc','2/1/2018 10:07PM','2/1/2018 10:27PM'),
	   ('4','111','3/3/2012','4/28/2018 6:26PM'),
	   ('10','PassCheck','5/2/2018 4:00AM','11/18/2018 4:17AM')


SET IDENTITY_INSERT dbo.TPasswordHistory OFF;
GO

SET IDENTITY_INSERT dbo.TUser ON;  
GO 

INSERT INTO TUser (UserID,FirstName,LastName, UserName) 
VALUES('1','Liam','Neeson','LiamNeeson'),									
	  ('2','Christian','Bale','ChristianBale'),									
	  ('3','Tom','Cruise','TomCruise'),									
	  ('4','Jack','Nicholson','JackNicholson'),									
	  ('5','Denzel','Washington','DenzelWashington'),									
	  ('6','Brad','Pitt','BradPitt'),									
	  ('7','Dwayne','Johnson','DwayneJohnson')								
									
SET IDENTITY_INSERT dbo.TUser OFF;
GO

INSERT INTO TLogin(UserID,EmailAddress,PasswordID)
VALUES('1','liamneeson@hotmail.com','3'),									
	  ('2','christianbale@gmail.com','5'),									
	  ('3','tomcruise@yahoo.com','6'),									
	  ('4','jacknicholson@outlook.com','7'),									
	  ('5','denzelwashington@hotmail.com','8'),									
	  ('6','bradpitt@outlook.com','9'),									
	  ('7','therock@smellllllllllllll.com','11')		


SET IDENTITY_INSERT dbo.TPost ON;
GO


INSERT INTO TPost (PostID, SenderID, ReciepentID, TextPost, DatePosted) 
VALUES('1','1','6','I don''t know who you are Brad. I don''t know what you want. If you are looking for ransom I can tell you I do have money, but what I also have are a very particular set of skills. Skills I have acquired over a very long career. Skills that make me a nightmare for people like you. If you let my daughter go now that''ll be the end of it. I will not look for you, I will not pursue you, but if you don''t, I will look for you, I will find you and I will kill you.','11/01/2018  4:23:00 AM'),
	  ('2','4','1','Have you ever danced with the devil in the pale moonlight? I ask that of all my prey. I just like the sound of it.','11/03/2018 6:28:44 PM'),
	  ('3','2','3','Dear Mr.SCIENTOLIGIST It''s the second time that he doesn''t give a ---- about what is going on in front of the camera, all right? I''m trying to ------- do a scene here, and I am going ''Why the ---- is Shane walking in there? What is he doing there?'' Do you understand my mind is not in the scene if you''re doing that? You do it one more ------- time and I ain''t walking on this set if you''re still hired. I''m ------- serious. You''re a nice guy. You''re a nice guy, but that don''t ------- cut it when you''re ------- around like this on set.','11/04/2018 2:17:22 AM'),
	  ('4','2','7','HEY ROCKY!!!!! Am I going to walk around and rip your ------- lights down, in the middle of a scene? Then why the ---- are you walking right through? Ah-da-da-dah, like this in the background. What the ---- is it with you? What don''t you ------- understand? You got any ------- idea about, hey, it''s ------- distracting having somebody walking up behind Bryce in the middle of the ------- scene? Give me a ------- answer! What don''t you get about it?','11/04/2018 2:22:22 AM'),
	  ('5','7','7','Christian Bale; you have got three seconds, and The Rock means three seconds to get your monkey ass out here to The Rock''s ring, or the Rock is going to come back there, pull you out of your dressing room, and lay the smack down on your candy ass!','11/04/2018 4:42:52 AM')


SET IDENTITY_INSERT dbo.TPost OFF;
GO
/*
Procedures
*/




/*
Viewing
*/

SELECT * FROM TUser ;
SELECT * FROM TLogin ;
SELECT * FROM TPasswordHistory ;
SELECT * FROM TPost ;
SELECT * FROM TLike ;

---SELECT * FROM TLike ;
