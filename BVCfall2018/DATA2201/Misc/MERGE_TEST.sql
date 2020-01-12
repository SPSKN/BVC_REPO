CREATE TABLE TSource (
	Id int NOT NULL DEFAULT 0,
	FruitName nvarchar(40) NOT NULL DEFAULT '',
	Cost money NOT NULL DEFAULT 0
)


CREATE TABLE TTarget(
	Id int NOT NULL DEFAULT 0,
	FruitName nvarchar(40) NOT NULL DEFAULT '',
	Cost money NOT NULL DEFAULT 0


)

INSERT INTO TSource
	VALUES
	(1,'Apple',5),
	(2,'Banana',10),
	(3,'Grapes',15),
	(4,'Kiwi',20)

INSERT INTO TTarget
	Values
	(1,'Apple',5),
	(2,'Banana',7),
	(3,'Orange',3),
	(5,'Tomatoe',8)

	SELECT * FROM TSource
	SELECT * FROM TTarget
	GO