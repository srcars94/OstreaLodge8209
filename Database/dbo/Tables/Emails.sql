CREATE TABLE [dbo].[Emails] (
    [EmailId] INT            IDENTITY (1, 1) NOT NULL,
    [From]    VARCHAR (50)   NOT NULL,
    [Subject] VARCHAR (150)  NOT NULL,
    [Details] VARCHAR (4000) NOT NULL,
    [SentOn]  DATETIME       NOT NULL
);

