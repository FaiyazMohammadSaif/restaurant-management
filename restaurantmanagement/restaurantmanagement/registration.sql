CREATE TABLE [dbo].[Table]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [Name] VARCHAR(50) NOT NULL, 
    [Address] VARCHAR(MAX) NOT NULL, 
    [Contact] INT NOT NULL, 
    [Designation] VARCHAR(50) NOT NULL, 
    [Salary] MONEY NOT NULL
)
