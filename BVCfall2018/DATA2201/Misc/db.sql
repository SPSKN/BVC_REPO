--Product Table
CREATE TABLE TProduct (
	SKU nvarchar(60) NOT NULL Primary KEY,
	QuantityStock int NOT NULL DEFAULT 0,
	UnitPrice int NOT NULL DEFAULT 0,
	ItemDescription nvarchar(110) NOT NULL DEFAULT 'NA'
)
--Order Line Items
CREATE TABLE TOrderLineItems (
	SKU nvarchar(60) NOT NULL REFERENCES TProduct(SKU),
	Quantity int NOT NULL DEFAULT 0,
	OrderNo int NOT NULL DEFAULT 0,
	LineItemAmount int NOT NULL DEFAULT 0,
)

-- NEW LINE

CREaTE TABLE TTest (
	RowId int IDENTITY (1,1),
	Comments nvarchar(110) NOT NULL DEFAULT '',
	ValidFromUtc datetime2 NOT NULL DEFAULT GETUTCDATE()
	)

	InSERT INTO TTest (Comments)
	SELECT 'Hello Bow Valley College!'
	UNION
	SELECT 'This my SQL Server Sandbox'
	GO

	SELECT * FROM TTest


	
	--