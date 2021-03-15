CREATE TABLE [dbo].[Table]
(
	[Id] INT NOT NULL, 
    [Name] NVARCHAR(50) NOT NULL, 
    [Price] MONEY NOT NULL, 
    [Article] NVARCHAR(50) NOT NULL, 
    CONSTRAINT [PK_Table] PRIMARY KEY ([Id])  
)
