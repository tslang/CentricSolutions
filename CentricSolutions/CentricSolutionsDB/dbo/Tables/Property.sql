CREATE TABLE [dbo].[Property]
(
	[PropertyId] INT NOT NULL PRIMARY KEY IDENTITY, 
    [Name] NVARCHAR(50) NULL, 
    [RentalRate] MONEY NULL, 
    [Expenses] MONEY NULL, 
    [RBA] INT NULL, 
    [Stories] INT NULL, 
    [AddressId] INT NULL
)
