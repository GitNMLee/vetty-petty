CREATE TABLE [dbo].[Vet] (
    [VetID]           INT           IDENTITY (1, 1) NOT NULL,
    [FirstName]       NVARCHAR (32) NOT NULL,
    [LastName]        NVARCHAR (32) NOT NULL,
    [HireDate]        DATETIME      NOT NULL,
    [TerminationDate] DATETIME      NULL,
    PRIMARY KEY CLUSTERED ([VetID] ASC)
);

