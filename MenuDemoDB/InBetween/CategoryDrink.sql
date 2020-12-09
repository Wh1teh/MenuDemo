CREATE TABLE [dbo].[CategoryDrink]
(
	[inID] INT NOT NULL , 
    [itemID] INT NOT NULL, 
    [ID] INT NOT NULL IDENTITY, 
    CONSTRAINT [FK_CategoryDrink_ToCategory] FOREIGN KEY ([inID]) REFERENCES [Category]([ID]), 
    CONSTRAINT [FK_CategoryDrink_ToDrink] FOREIGN KEY ([itemID]) REFERENCES [Drink]([ID]), 
    CONSTRAINT [PK_CategoryDrink] PRIMARY KEY ([ID])
)
