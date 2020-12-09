CREATE TABLE [dbo].[MenuCategory]
(
	[inID] INT NOT NULL , 
    [itemID] INT NOT NULL, 
    [ID] INT NOT NULL IDENTITY, 
    CONSTRAINT [FK_MenuCategory_ToMenu] FOREIGN KEY ([inID]) REFERENCES [Menu]([ID]), 
    CONSTRAINT [FK_MenuCategory_ToCategory] FOREIGN KEY ([itemID]) REFERENCES [Category]([ID]), 
    CONSTRAINT [PK_MenuCategory] PRIMARY KEY ([ID])
)
