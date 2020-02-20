--3A

 DATA1201_Winter2018_project2_ScottNick_3A

CREATE VIEW CustomerAddresses AS 
SELECT custo.CustomerID, custo.EmailAddress, custo.LastName,custo.FirstName, bill.Line1 AS BillLine1, 
bill.Line2 AS BillLine2,bill.City AS BillCity, bill.State AS BillState, bill.ZipCode AS BillZip, 
ship.Line1 AS ShipLine1,ship.Line2 AS ShipLine2, ship.City AS ShipCity,ship.State AS ShipSate, 
ship.ZipCode AS ShipZip
FROM Customers custo, Addresses ship, Addresses bill 
WHERE custo.BillingAddressID = bill.AddressID AND custo.ShippingAddressID = ship.AddressID;


--SELECT * FROM CustomerAddresses;

--3B


SELECT CustomerID, LastName, FirstName, BillLine1 
FROM CustomerAddresses;
 
 
--3C


UPDATE CustomerAddresses
SET ShipLine1 = '1990 Westwood Bvld'
WHERE CustomerID = 8;

/*
SELECT CustomerID, ShipLine1
 FROM CustomerAddresses 
 WHERE CustomerID = 8;
 */

 
--3D

CREATE VIEW OrderItemProducts
AS
SELECT O.OrderID AS OrderID, O.OrderDate AS OrderDate, O.TaxAmount AS TaxAmount, O.ShipDate AS ShipDate,
Oi.ItemPrice AS ItemPrice, Oi.DiscountAmount AS DiscountAmount, (Oi.ItemPrice - Oi.DiscountAmount) AS FinalPrice, Oi.Quantity, 
(Oi.Quantity * (Oi.ItemPrice - Oi.DiscountAmount)) AS ItemTotal, P.ProductName
FROM Orders O 
JOIN OrderItems Oi ON O.OrderID = Oi.OrderID 
JOIN Products P ON Oi.ProductID = P.ProductID;


--SELECT * FROM OrderItemProducts;

--3E

SELECT ProductName, SUM(Quantity) AS OrderCount, SUM(ItemTotal) AS OrderTotal
FROM OrderItemProducts
GROUP BY ProductName

-- SELECT * FROM ProductSummary