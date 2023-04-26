CREATE TABLE [dbo].[Species] (
    [SpeciesID]   INT           IDENTITY (1, 1) NOT NULL,
    [SpeciesName] NVARCHAR (32) NOT NULL,
    PRIMARY KEY CLUSTERED ([SpeciesID] ASC),
    UNIQUE NONCLUSTERED ([SpeciesName] ASC)
);

