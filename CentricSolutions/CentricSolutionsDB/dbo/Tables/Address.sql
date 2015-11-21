CREATE TABLE [dbo].[Address]
(
	[AddressId] INT NOT NULL PRIMARY KEY IDENTITY, 
    [AddressLine1] NVARCHAR(50) NOT NULL, 
    [AddressLine2] NVARCHAR(50) NULL, 
    [City] NVARCHAR(50) NOT NULL, 
    [State] NCHAR(10) NOT NULL, 
    [PostalCode] NCHAR(10) NOT NULL, 
    [Country] NVARCHAR(50) NOT NULL
)
