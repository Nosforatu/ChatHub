CREATE TABLE [dbo].[Users]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [Name] VARCHAR(50) NOT NULL, 
    [Surname] VARCHAR(50) NULL, 
    [Username] VARCHAR(50) NOT NULL, 
    [Password] VARCHAR(500) NOT NULL
)
