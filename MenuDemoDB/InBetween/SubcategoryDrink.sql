CREATE TABLE [dbo].[SubcategoryDrink]
(
	[inID] INT NOT NULL , 
    [itemID] INT NOT NULL, 
    [ID] INT NOT NULL IDENTITY, 
    CONSTRAINT [FK_SubcategoryDrink_ToSubcategory] FOREIGN KEY ([inID]) REFERENCES [Subcategory]([ID]), 
    CONSTRAINT [FK_SubcategoryDrink_ToDrink] FOREIGN KEY ([itemID]) REFERENCES [Drink]([ID]), 
    CONSTRAINT [PK_SubcategoryDrink] PRIMARY KEY ([ID])
)
