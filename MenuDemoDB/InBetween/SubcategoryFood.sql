CREATE TABLE [dbo].[SubcategoryFood]
(
	[inID] INT NOT NULL , 
    [itemID] INT NOT NULL, 
    [ID] INT NOT NULL IDENTITY, 
    CONSTRAINT [FK_SubcategoryFood_ToSubcategory] FOREIGN KEY ([inID]) REFERENCES [Subcategory]([ID]), 
    CONSTRAINT [FK_SubcategoryFood_ToFood] FOREIGN KEY ([itemID]) REFERENCES [FoodItem]([ID]), 
    CONSTRAINT [PK_SubcategoryFood] PRIMARY KEY ([ID])
)
