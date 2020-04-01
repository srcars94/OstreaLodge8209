CREATE TABLE [dbo].[Events] (
    [EventId]   INT           IDENTITY (1, 1) NOT NULL,
    [EventName] VARCHAR (150) NOT NULL,
    [EventDate] DATETIME      NOT NULL
);

