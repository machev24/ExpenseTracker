USE [ExpenseTracker];

-- Create table
CREATE TABLE [Categories] 
(
	[Id] INT IDENTITY PRIMARY KEY NOT NULL, 
	[Title] VARCHAR(50), 
	[Icon] VARCHAR(50),
	[Type] VARCHAR(50)
);

CREATE TABLE [Transactions] 
(
	[Id] INT IDENTITY PRIMARY KEY NOT NULL, 
	[Category] INT, 
	[Amount] DECIMAL,
	[Note]VARCHAR(75),
	[Date] DATETIME
);