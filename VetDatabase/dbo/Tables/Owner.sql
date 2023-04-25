CREATE TABLE [dbo].[Owner] (
    [OwnerID]   INT           IDENTITY (1, 1) NOT NULL,
    [FirstName] NVARCHAR (32) NOT NULL,
    [LastName]  NVARCHAR (32) NOT NULL,
    [Email]     NVARCHAR (64) NOT NULL,
    PRIMARY KEY CLUSTERED ([OwnerID] ASC),
    UNIQUE NONCLUSTERED ([Email] ASC)
);

