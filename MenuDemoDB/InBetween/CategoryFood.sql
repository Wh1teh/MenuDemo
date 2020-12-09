CREATE TABLE [dbo].[CategoryFood]
(
	[inID] INT NOT NULL , 
    [itemID] INT NOT NULL, 
    [ID] INT NOT NULL IDENTITY, 
    CONSTRAINT [FK_CategoryFood_ToCategory] FOREIGN KEY ([inID]) REFERENCES [Category]([ID]), 
    CONSTRAINT [FK_CategoryFood_ToFood] FOREIGN KEY ([itemID]) REFERENCES [FoodItem]([ID]), 
    CONSTRAINT [PK_CategoryFood] PRIMARY KEY ([ID])
)
