CREATE TABLE [dbo].[user]
(
	[Id] VARCHAR(50) NOT NULL PRIMARY KEY, 
    [name] VARCHAR(50) NULL, 
    [sec] INT NULL, 
    [branch] VARCHAR(50) NULL, 
    [dob] VARCHAR(50) NULL, 
    [img] IMAGE NULL
)
