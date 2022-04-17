CREATE TABLE [dbo].[ims]
(
	[Product Number] INT NOT NULL PRIMARY KEY, 
    [Product Name] NCHAR(10) NOT NULL, 
    [Product Description] NCHAR(10) NOT NULL, 
    [Product Category] NCHAR(10) NOT NULL, 
    [Quantity] INT NOT NULL, 
    [On Order] INT NOT NULL, 
    [Price] INT NOT NULL
)
