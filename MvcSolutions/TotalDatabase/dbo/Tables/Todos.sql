CREATE TABLE [dbo].[Todos] (
    [Id]           INT            IDENTITY (1, 1) NOT NULL,
    [Title]        NVARCHAR (150) NOT NULL,
    [IsDone]       BIT            NULL,
    [CreationDate] DATETIME       DEFAULT (getdate()) NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

