/*
Course code : DATA1201
Term/Year : Wint2018
Assignment code: A4
Author : Scott Patterson, Skylar Balcom
BVC username :s.patterson528, s.balcom361
Date created : 2018-03-27
Description :A4
*/

--Q1

CREATE VIEW Q1View
AS
SELECT Id, OrderDate, TotalAmount
FROM [Order];
/*
SELECT * 
FROM Q1View;
*/
--Q2

CREATE VIEW Q2View 
AS
SELECT O.Id, Product.Id AS 'ProductId', ProductName, TotalAmount
FROM [Order] o, Product;
/*
SELECT *
FROM Q2View
*/
--Q3

CREATE VIEW Q3View
AS
SELECT ProductName, UnitPrice
FROM Product
WHERE (UnitPrice) >(SELECT AVG(UnitPrice) FROM Product)
/*
SELECT *
FROM Q3View
*/
--Q4

CREATE VIEW Q4View
AS
SELECT ProductId, ProductName, Oi.Quantity,
 (P.UnitPrice * Oi.Quantity) AS AmountPaid
FROM OrderItem Oi, Product P
GROUP BY ProductName, ProductId, Oi.Quantity, P.UnitPrice
/*
SELECT * 
FROM Q4View
*/
--Q5

CREATE VIEW Q5View
AS
SELECT O.CustomerId, CustomerName = (C.FirstName + ' ' + C.LastName), YEAR(O.OrderDate) AS OrderYear, 
              MONTH(O.OrderDate) AS OrderMonth, 
              SUM(O.TotalAmount) AS TotalAmount
 FROM [Order] O
 JOIN Customer C ON C.Id = O.CustomerId
 GROUP BY O.CustomerId, O.OrderDate, C.FirstName, C.LastName
 



 --SELECT COUNT(Customer.Id)
 --FROM Customer
 
 
 --Q6

CREATE VIEW Q6View
AS
 SELECT P.ProductName, MAX(O.OrderDate) AS LastOrderDate,
                      COUNT(Oi.Quantity) AS TotalOrders,
                      SUM(Oi.Quantity) AS QuantityTotal 

  FROM [Order] O 
  JOIN OrderItem Oi ON O.Id = Oi.OrderId 
  JOIN Product P ON P.Id = Oi.ProductId
GROUP BY  P.ProductName, P.id


--Q7
CREATE VIEW Q7View
AS
SELECT TOP 5 P.Id AS ProductId, P.ProductName, Sum(Quantity) AS QuantityOrdered, MAX(O.OrderDate) AS RecentSoldDate, MAX(C.FirstName + ' ' + C.LastName) AS LastClientName
    FROM Product P, OrderItem Oi, [Order] O, Customer C
        WHERE P.iD = Oi.ProductId
        AND Oi.OrderId = O.Id 
        AND C.Id = O.CustomerId
            GROUP BY P.Id, P.ProductName
            ORDER BY QuantityOrdered;

/*
Q8
***
CREATE a view to show the list of products
for the top  3 suppliers and list their products
***

CREATE VIEW Q8View
AS

SELECT S.id, S.CompanyName, TotalSales = (SUM(Oi.Quantity * (Oi.UnitPrice))), OrderItems = SUM(Oi.Quantity)
FROM Product P
JOIN Supplier S ON P.SupplierId = S.Id
JOIN OrderItem Oi ON P.UnitPrice = Oi.UnitPrice
WHERE P.SupplierId = S.Id
AND Oi.ProductId = P.Id
GROUP BY S.id, S.CompanyName
ORDER BY TotalSales DESC

***
SELECT P.Id AS ProductId, P.ProductName, P.UnitPrice, MAX(O.OrderDate) AS LastOrderDate
  FROM [Order] O 
  RIGHT JOIN OrderItem Oi ON O.Id = Oi.OrderId 
   RIGHT JOIN Product P ON P.Id = Oi.ProductId
GROUP BY  P.ProductName, P.id, P.UnitPrice

***
SELECT S.Id, P.Id AS ProductId, P.ProductName, P.UnitPrice, MAX(O.OrderDate) AS LastOrderDate,
                                                      MAX(C.Id) AS LastClientID,
                                                      MAX(C.FirstName + ' ' + C.LastName) AS LastClientName

  FROM [Order] O 
  RIGHT JOIN OrderItem Oi ON O.Id = Oi.OrderId 
   RIGHT JOIN Product P ON P.Id = Oi.ProductId
   RIGHT JOIN Customer C ON C.Id = O.CustomerId
    RIGHT JOIN Supplier S ON S.Id = P.SupplierId
	--WHERE P.SupplierId =(SELECT TOP 3 S.Id)

GROUP BY  P.ProductName, P.id, P.UnitPrice , S.Id
ORDER BY  P.ProductName, P.id, P.UnitPrice , S.Id

***

SELECT S.Id, P.Id AS ProductId, P.ProductName, P.UnitPrice, MAX(O.OrderDate) AS LastOrderDate,
                                                      MAX(C.Id) AS LastClientID,
                                                      MAX(C.FirstName + ' ' + C.LastName) AS LastClientName

  FROM Supplier S, [Order] O
  RIGHT JOIN OrderItem Oi ON O.Id = Oi.OrderId 
   RIGHT JOIN Product P ON Oi.ProductId = P.Id
   RIGHT JOIN Customer C ON C.Id = O.CustomerId
   WHERE S.Id IN
              (SELECT TOP 3 S.Id
                FROM OrderItem Oi
                WHERE Oi.ProductId = P.Id AND SupplierId = S.Id
				HAVING S.Id = P.SupplierId)
GROUP BY S.Id, P.ProductName, P.id, P.UnitPrice
ORDER BY P.Id

***

SELECT P.Id AS ProductId, P.ProductName, P.UnitPrice, MAX(O.OrderDate) AS LastOrderDate,
                                                      MAX(C.Id) AS LastClientID,
                                                      MAX(C.FirstName + ' ' + C.LastName) AS LastClientName

  FROM Supplier S, [Order] O
  RIGHT JOIN OrderItem Oi ON O.Id = Oi.OrderId 
   RIGHT JOIN Product P ON Oi.ProductId = P.Id
   RIGHT JOIN Customer C ON C.Id = O.CustomerId
   WHERE EXISTS 
              (SELECT TOP 3 S.Id, TotalSales = (SUM(Oi.Quantity * (Oi.UnitPrice)))
                FROM Supplier S
                GROUP BY S.Id
                HAVING S.Id = P.SupplierId
                )
GROUP BY  P.ProductName, P.id, P.UnitPrice

***Tried Different ways of run the Subquery and I could not get the Top 3 Suppliers

SELECT P.Id AS ProductId, P.ProductName, Sum(Quantity) AS QuantityOrdered, MAX(O.OrderDate) AS RecentSoldDate, MAX(C.FirstName + ' ' + C.LastName) AS LastClientName
    FROM Product P, OrderItem Oi, [Order] O, Customer C
        WHERE P.iD = Oi.ProductId(SELECT TOP S.Id
		FROM Supplier
        AND Oi.OrderId = O.Id 
        AND C.Id = O.CustomerId
            GROUP BY P.Id, P.ProductName
            ORDER BY QuantityOrdered;

*/

