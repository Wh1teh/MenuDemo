CREATE TABLE [dbo].[Allergen]
(
	[ID] INT NOT NULL PRIMARY KEY IDENTITY, 
    [AllergenName] NVARCHAR(50) NOT NULL, 
    [AllergenAcronym] NCHAR(10) NOT NULL
)
