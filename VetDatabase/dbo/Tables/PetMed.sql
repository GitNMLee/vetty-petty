CREATE TABLE [dbo].[PetMed] (
    [PetMedID]     INT            IDENTITY (1, 1) NOT NULL,
    [PetID]        INT            NOT NULL,
    [MedicationID] INT            NOT NULL,
    [Instructions] NVARCHAR (200) NOT NULL,
    PRIMARY KEY CLUSTERED ([PetMedID] ASC),
    FOREIGN KEY ([MedicationID]) REFERENCES [dbo].[Medication] ([MedicationID]),
    FOREIGN KEY ([PetID]) REFERENCES [dbo].[Pet] ([PetID]),
    UNIQUE NONCLUSTERED ([PetID] ASC, [MedicationID] ASC)
);

