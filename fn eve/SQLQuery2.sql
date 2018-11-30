CREATE TABLE [dbo].[tab1] (
    [Id]     VARCHAR (50) NOT NULL,
    [name]   VARCHAR (50) NULL,
    [sec]    INT          NULL,
    [branch] VARCHAR (50) NULL,
    [dob]    VARCHAR (MAX) NULL,
    [img]    IMAGE        NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

