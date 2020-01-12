--MERGE SQL statement - Part 1

--Create a target table
CREATE TABLE Products
(
ProductID INT PRIMARY KEY,
ProductName VARCHAR(100),
Rate MONEY
) 
GO

--Insert records into target table
INSERT INTO Products
VALUES
(1, 'Tea', 10.00),
(2, 'Coffee', 20.00),
(3, 'Muffin', 30.00),
(4, 'Biscuit', 40.00)
GO

--Create source table
CREATE TABLE UpdatedProducts
(
ProductID INT PRIMARY KEY,
ProductName VARCHAR(100),
Rate MONEY
) 
GO

--Insert records into source table
INSERT INTO UpdatedProducts
VALUES
(1, 'Tea', 10.00),
(2, 'Coffee', 25.00),
(3, 'Muffin', 35.00),
(5, 'Pizza', 60.00)
GO

SELECT * FROM Products
SELECT * FROM UpdatedProducts
GO