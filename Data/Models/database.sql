USE [ExpenseTracker];

-- Create table
CREATE TABLE [Categories] 
(
	[id] INT IDENTITY PRIMARY KEY NOT NULL, 
	[title] VARCHAR(50), 
	[icon] VARCHAR(50),
	[type] VARCHAR(50)
);

CREATE TABLE [Transactions] 
(
	[id] INT IDENTITY PRIMARY KEY NOT NULL, 
	[category] INT, 
	[amount] DECIMAL,
	[note]VARCHAR(75),
	[date] DATETIME
);