CREATE TABLE [dbo].[Pet] (
    [PetID]        INT            IDENTITY (1, 1) NOT NULL,
    [OwnerID]      INT            NOT NULL,
    [BreedID]      INT            NOT NULL,
    [PetFirstName] NVARCHAR (32)  NOT NULL,
    [PetLastName]  NVARCHAR (32)  NOT NULL,
    [Description]  NVARCHAR (200) NOT NULL,
    [DeceasedOn]   DATETIME       NULL,
    PRIMARY KEY CLUSTERED ([PetID] ASC),
    FOREIGN KEY ([BreedID]) REFERENCES [dbo].[Breed] ([BreedID]),
    FOREIGN KEY ([OwnerID]) REFERENCES [dbo].[Owner] ([OwnerID])
);

