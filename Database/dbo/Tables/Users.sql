CREATE TABLE [dbo].[Users] (
    [UserId]    INT          IDENTITY (1, 1) NOT NULL,
    [UserName]  VARCHAR (50) NOT NULL,
    [Email]     VARCHAR (50) NOT NULL,
    [LastLogin] DATETIME     NOT NULL,
    [CreatedOn] DATETIME     NOT NULL,
    [Approved]  INT          NOT NULL
);

