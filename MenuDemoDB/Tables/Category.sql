CREATE TABLE [dbo].[Category]
(
	[ID] INT NOT NULL PRIMARY KEY IDENTITY, 
    [CategoryOrder] INT NULL, 
    [CategoryName] NVARCHAR(50) NOT NULL 
)
