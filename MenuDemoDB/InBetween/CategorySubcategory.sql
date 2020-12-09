CREATE TABLE [dbo].[CategorySubcategory]
(
	[inID] INT NOT NULL , 
    [itemID] INT NOT NULL, 
    [ID] INT NOT NULL IDENTITY, 
    CONSTRAINT [FK_CategorySubcategory_ToCategory] FOREIGN KEY ([inID]) REFERENCES [Category]([ID]), 
    CONSTRAINT [FK_CategorySubcategory_ToSubcategory] FOREIGN KEY ([itemID]) REFERENCES [Subcategory]([ID]), 
    CONSTRAINT [PK_CategorySubcategory] PRIMARY KEY ([ID])
)
