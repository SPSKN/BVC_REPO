BEGIN TRANSACTION;
CREATE TABLE IF NOT EXISTS `orders` (
	`oid`	INTEGER,
	`order_name`	TEXT,
	`amount`	INTEGER,
	`customer_name`	TEXT,
	PRIMARY KEY(`oid`)
);
INSERT INTO `orders` (oid,order_name,amount,customer_name) VALUES (2,'TV',500,'Alex'),
 (3,'TV',450,'Adam'),
 (4,'Headphone',50,'Nour'),
 (5,'Mobile',300,'Jake'),
 (6,'Charger',20,'Hannah'),
 (7,'TV',300,'April'),
 (8,'Mobile ',600,'Kate');
COMMIT;
