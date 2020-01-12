--q1
--SELECT BranchName.Branch,BranchCity.Branch

--q2
SELECT Balance -25,AccountType
FROM Accounts
WHERE AccountType ='Chequing'


--q3
SELECT * FROM Accounts
WHERE Balance < 500.00
GO

--q4
SELECT Balance,
CASE 
	WHEN AccountType ='Chequing' THEN Balance*1.01
	WHEN AccountType ='Savings'  THEN Balance*1.04
	
END
FROM Accounts

--q5
SELECT Balance -25
FROM Accounts
WHERE Balance < 500

