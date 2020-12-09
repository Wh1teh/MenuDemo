CREATE TABLE [dbo].[Restaurant]
(
	[ID] INT NOT NULL PRIMARY KEY IDENTITY, 
    [RestaurantName] NVARCHAR(50) NOT NULL, 
    [RestaurantPhone] NVARCHAR(50) NULL, 
    [RestaurantAddress] NVARCHAR(100) NULL, 
    [RestaurantOperational] BIT NULL 
)
