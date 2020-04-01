CREATE TABLE [dbo].[Articles] (
    [ArticleId]      INT            NOT NULL,
    [ArticleSubject] VARCHAR (500)  NOT NULL,
    [ArticleDetails] VARCHAR (4000) NOT NULL,
    [CreatedOn]      DATETIME       NOT NULL,
    [CreatedBy]      VARCHAR (50)   NOT NULL,
    CONSTRAINT [ArticleId] PRIMARY KEY CLUSTERED ([ArticleId] ASC)
);

