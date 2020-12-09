CREATE TABLE [dbo].[FoodItem]
(
	[ID] INT NOT NULL PRIMARY KEY IDENTITY, 
    [FoodItemOrder] INT NULL, 
    [FoodItemName] NVARCHAR(50) NOT NULL, 
    [FoodItemDescription] NVARCHAR(50) NULL, 
    [FoodItemPrice] NUMERIC(18, 2) NULL, 
    [FoodItemType] BIT NULL, 
    [FoodItemDrinkSize] FLOAT NULL, 
    [FoodItemAlcohol] FLOAT NULL 
)
