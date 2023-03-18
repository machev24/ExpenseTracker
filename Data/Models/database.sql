USE [ExpenseTracker];

-- Create table
CREATE TABLE [Category] 
(
	[id] INT, 
	[title] VARCHAR(50), 
	[icon] VARCHAR(50),
	[type] VARCHAR(50)
);

CREATE TABLE [Transaction] 
(
	[id] INT, 
	[category] INT, 
	[amount] DECIMAL,
	[note]VARCHAR(75),
	[date] DATETIME
);