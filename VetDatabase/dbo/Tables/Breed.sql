CREATE TABLE [dbo].[Breed] (
    [BreedID]   INT           IDENTITY (1, 1) NOT NULL,
    [SpeciesID] INT           NOT NULL,
    [BreedName] NVARCHAR (32) NOT NULL,
    PRIMARY KEY CLUSTERED ([BreedID] ASC),
    FOREIGN KEY ([SpeciesID]) REFERENCES [dbo].[Species] ([SpeciesID]),
    UNIQUE NONCLUSTERED ([BreedName] ASC)
);

