CREATE TABLE [dbo].[DrinkAllergen]
(
	[inID] INT NOT NULL , 
    [itemID] INT NOT NULL, 
    [ID] INT NOT NULL IDENTITY, 
    CONSTRAINT [FK_DrinkAllergen_ToDrink] FOREIGN KEY ([inID]) REFERENCES [Drink]([ID]), 
    CONSTRAINT [FK_DrinkAllergen_ToAllergen] FOREIGN KEY ([itemID]) REFERENCES [Allergen]([ID]), 
    CONSTRAINT [PK_DrinkAllergen] PRIMARY KEY ([ID])
)
