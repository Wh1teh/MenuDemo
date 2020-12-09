CREATE TABLE [dbo].[Drink]
(
	[ID] INT NOT NULL PRIMARY KEY IDENTITY, 
    [FoodItemOrder] INT NULL, 
    [FoodItemName] NVARCHAR(50) NOT NULL, 
    [FoodItemDescription] NVARCHAR(500) NULL, 
    [FoodItemPrice] DECIMAL(18, 2) NULL, 
    [DrinkSize] FLOAT NULL, 
    [DrinkAlcoholContent] FLOAT NULL 
)
