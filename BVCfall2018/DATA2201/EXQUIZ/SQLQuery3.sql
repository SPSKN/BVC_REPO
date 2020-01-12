/*
CREATE TABLE DepartureFlights(

DepartureDate datetime2 NOT NULL,
TerminalId int FOREIGN KEY REFERENCES TerminalsGates(TerminalId),
NumberofDepartingFlights int NOT NULL DEFAULT 0
)

GO

CREATE TABLE AirlinesTerminals(

AirlineId nvarchar(10) NOT NULL DEFAULT ",
AirlineName nvarchar(100) NOT NULL DEFAULT ",
TerminalId int FOREIGN KEY REFERENCES TerminalsGates(TerminalId)
)

GO

CREATE TABLE TerminalsGates(

TerminalId int NOT NULL PRIMARY KEY,
NumberOfGates int NOT NULL DEFAULT 0
)

GO

*/