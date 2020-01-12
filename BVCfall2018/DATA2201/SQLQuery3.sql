USE spatterson528
GO
IF (EXISTS (SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_SCHEMA = 'dbo' AND TABLE_NAME = 'Customer')) DROP TABLE Customer
IF (EXISTS (SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_SCHEMA = 'dbo' AND TABLE_NAME = 'Loan')) DROP TABLE Loan
IF (EXISTS (SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_SCHEMA = 'dbo' AND TABLE_NAME = 'TransactionAccount')) DROP TABLE TransactionAccount
IF (EXISTS (SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_SCHEMA = 'dbo' AND TABLE_NAME = 'Fees')) DROP TABLE Fees
IF (EXISTS (SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_SCHEMA = 'dbo' AND TABLE_NAME = 'Location')) DROP TABLE [Location]
IF (EXISTS (SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_SCHEMA = 'dbo' AND TABLE_NAME = 'Accounts')) DROP TABLE Accounts
IF (EXISTS (SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_SCHEMA = 'dbo' AND TABLE_NAME = 'Branch')) DROP TABLE Branch
IF (EXISTS (SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_SCHEMA = 'dbo' AND TABLE_NAME = 'Transaction')) DROP TABLE [Transaction]
IF (EXISTS (SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_SCHEMA = 'dbo' AND TABLE_NAME = 'Employees')) DROP TABLE Employees
GO

CREATE TABLE Employees
(
EmployeeId INT NOT NULL,
EmployeeName varchar(20),
StartDate date,
Managers varchar(20),

PRIMARY KEY (EmployeeId)
)

CREATE TABLE [Transaction] 
(
TransactionId INT NOT NULL PRIMARY KEY,
DepOrWith varchar(1),
CheckNumber INT,
Amount money
)

CREATE TABLE Branch
(
BranchId INT  NOT NULL PRIMARY KEY,
BranchName varchar(40),
BranchCity varchar(80),
)

CREATE TABLE Accounts 
(
AccountId INT   NOT NULL PRIMARY KEY,
AccountType varchar(20),
Balance decimal,
BranchId INT NOT NULL,

FOREIGN KEY (BranchId) REFERENCES Branch(BranchId)
)

---LINKING---

CREATE TABLE [Location]
(
EmployeeBranch varchar(20) NOT NULL PRIMARY KEY,
EmployeeId INT NOT NULL,
BranchId INT NOT NULL,

FOREIGN KEY (EmployeeId) REFERENCES Employees(EmployeeId),
FOREIGN KEY (BranchId) REFERENCES Branch(BranchId),
)

CREATE TABLE Fees
(
AccountFeeRates INT NOT NULL PRIMARY KEY,
AccountId INT NOT NULL ,
MonthlyFee INT,
InterestRate INT,

FOREIGN KEY (AccountId) REFERENCES Accounts(AccountId),
)

CREATE TABLE TransactionAccount
(
TransactionAccount INT   NOT NULL PRIMARY KEY,
TransactionId INT NOT NULL,
AccountId INT NOT NULL,

FOREIGN KEY (AccountId) REFERENCES Accounts(AccountId),
FOREIGN KEY (TransactionId) REFERENCES [Transaction](TransactionId),

)

CREATE TABLE Loan
(
AccountBranch varchar(20) NOT NULL PRIMARY KEY,
BranchId INT,
AccountId INT,
AmountOwed decimal,
LoanPayment decimal,
PaymentDate date,
LoanNumber INT,

FOREIGN KEY (AccountId) REFERENCES Accounts(AccountId),
FOREIGN KEY (BranchId) REFERENCES Branch(BranchId),
)

CREATE TABLE Customer
(
NameBranchAccount varchar(20) NOT NULL PRIMARY KEY,
BranchId INT,
AccountId INT,
CustomerName varchar(20),
HomeAddress varchar(40),
EmployeeId INT,

FOREIGN KEY (BranchId) REFERENCES Branch(BranchId),
FOREIGN KEY (AccountId) REFERENCES Accounts(AccountId),
FOREIGN KEY (EmployeeId) REFERENCES Employees(EmployeeId),
)
GO



---INSERTS TEST DATA---


INSERT INTO Branch
VALUES
('1', 'Ottawa Centre', '2701 Riverside Dr
Ottawa, ON K1A 0B1'),
('2', 'Montreal Centre', '12860 Rue de Montigny apartement 8, Montréal, QC H1A 4S9'),
('3', 'Vancouver Centre', '2497 E Hastings St, Vancouver, BC V5K 1Y8'),
('4', 'Winnipeg Centre', '517 Pandora Ave E, Winnipeg, MB R2C 0A5'),
('5', 'Calgary Centre', '6208 Rundlehorn Dr NE, Calgary, AB T1Y 2X1');
GO

/*
SELECT * FROM Branch
*/

INSERT INTO Accounts
VALUES
('1', 'Chequing', '250000.00', '1'),
('2', 'Savings', '420.69', '2'),
('3', 'Savings', '0.92', '3'),
('4', 'Chequing', '600.41','4'),
('5', 'Chequing', '70.25','5');
GO

/*
SELECT * FROM Accounts
*/
INSERT INTO Employees
VALUES
('1','Ben Han','2018-10-01','Self'),
('2','Benni Hanni','2018-11-11','Brenda Patterson'),
('3','Benno Hanno','2018-12-02','Brenda Patterson'),
('4','Brenda Patterson','2017-09-01','Ben Han'),
('5','Dennis Curran','2017-06-03','Brenda Patterson'),
('6','Sarah Dion','2016-10-04','Ben Han');
GO

/*
SELECT * FROM Employees
*/


INSERT INTO [Transaction]
VALUES
('1', 'W', '0001', '1'),
('2', 'W', '0002', '90'),
('3', 'D', '', '300'),
('4', 'D', '','100'),
('5', 'W', '0001','20');
GO

/*
SELECT * FROM [Transaction]
*/


INSERT INTO [TransactionAccount]
VALUES
('1', '1', '1'),
('2', '2', '2'),
('3', '3', '3'),
('4', '4', '4'),
('5', '5', '5');
GO

/*
SELECT * FROM [TransactionAccount]
*/

INSERT INTO [Location]
VALUES
('11', '1', '1'),
('22', '2', '2'),
('33', '3', '3'),
('44', '4', '4'),
('54', '5', '4'),
('65', '6', '5');

GO

/*
SELECT * FROM [Location]
*/

INSERT INTO [Fees]
VALUES
('1', '1','' ,'' ),
('2', '2', '', ''),
('3', '3', '', ''),
('4', '4', '',''),
('5', '5', '','');
GO

/*
SELECT * FROM [Fees]
*/


INSERT INTO [Loan]
VALUES
('a', 1, '1','0','0','','0'),
('b', 2,'2','0','0','','0'),
('c', 3, '3','0','0','','0'),
('d', 4, '4','0','0','','0'),
('e', 5, '5','0','0','','0');
GO

/*
SELECT * FROM Loan
*/

INSERT INTO [Customer]
VALUES
('1', 1, '1','John Cena','','1'),
('2', 2,'2','Marky Mark','','2'),
('3', 3, '3','Will Smith','','3'),
('4', 4, '4','50 Cent','','4'),
('5', 5, '5','T Pain','','5');
GO

/*
SELECT * FROM Customer
*/