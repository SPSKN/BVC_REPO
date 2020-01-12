Course code : DATA1201
Term/Year : TermYear
Assignment code: A3
Author : Scott Patterson	
BVC username :s.patterson528
Date created : 2018-03-26
Description :A3 SQL file

--Q1 List all Orders with Customers Information
SELECT O.OrderNumber, Customer.FirstName, Customer.LastName, Customer.Id
FROM [Order] O JOIN Customer
ON O.CustomerId = Customer.Id
ORDER BY O.OrderNumber

--Q2 List all Order with Product name, quantities, and price
SELECT OrderItem.OrderId, OrderItem.ProductId, Product.ProductName, OrderItem.Quantity, OrderItem.UnitPrice
FROM OrderItem JOIN Product
	ON OrderItem.ProductId = Product.Id

--Q3List All Customers
SELECT FirstName, LastName, City, Country, Phone
FROM Customer

--Q4 List All Customer With Orders
SELECT Id
FROM Customer
UNION
SELECT CustomerId
FROM [Order] O
WHERE OrderNumber IS NOT NULL
ORDER BY (Id) DESC

--Q5 List All Contacts As Customer OR Supplier
SELECT 'Customer' AS TYPE, FirstName + ' '  + LastName AS ContactName
FROM Customer
UNION
SELECT 'Supplier',
	ContactName
FROM Supplier

--Q6
SELECT ProductName
FROM Product
WHERE Id IN 
	(SELECT ProductId
	FROM OrderItem
	WHERE Quantity > 50)
--Q7
SELECT FirstName, LastName,
	TotalOrders = (SELECT COUNT(O.Id) FROM [Order] O WHERE O.CustomerId = Customer.Id)
FROM Customer

--Q8
SELECT ProductName
FROM Product
WHERE Id IN 
	(SELECT ProductId
	FROM OrderItem
	WHERE Quantity > 100)
	
--Q9
SELECT Total_Customers = (SELECT COUNT(Id) FROM Customer)

--Q10
SELECT Total_2014 = (SELECT SUM(TotalAmount) FROM [Order] WHERE YEAR(OrderDate) = 2014)

--Q11
SELECT AVERAGE_ORDER = (SELECT AVG(TotalAmount) FROM [Order])

--Q12
SELECT Id, CompanyName, ContactName,City,Country,Phone,Fax INTO SupplierUSA
FROM Supplier
SELECT Id, CompanyName, ContactName,City,Country,Phone,Fax INTO SupplierUSA
FROM Supplier