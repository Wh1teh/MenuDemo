CREATE TABLE [dbo].[RestaurantMenu]
(
	[inID] INT NOT NULL , 
    [itemID] INT NOT NULL, 
    [ID] INT NOT NULL IDENTITY, 
    CONSTRAINT [FK_RestaurantMenu_ToRestaurant] FOREIGN KEY ([inID]) REFERENCES [Restaurant]([ID]), 
    CONSTRAINT [FK_RestaurantMenu_ToMenu] FOREIGN KEY ([itemID]) REFERENCES [Menu]([ID]), 
    CONSTRAINT [PK_RestaurantMenu] PRIMARY KEY ([ID])
)
