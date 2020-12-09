CREATE TABLE [dbo].[FoodAllergen]
(
	[inID] INT NOT NULL , 
    [itemID] INT NOT NULL, 
    [ID] INT NOT NULL IDENTITY, 
    CONSTRAINT [FK_FoodAllergen_ToFood] FOREIGN KEY ([inID]) REFERENCES [FoodItem]([ID]), 
    CONSTRAINT [FK_FoodAllergen_ToAllergen] FOREIGN KEY ([itemID]) REFERENCES [Allergen]([ID]), 
    CONSTRAINT [PK_FoodAllergen] PRIMARY KEY ([ID])
)
