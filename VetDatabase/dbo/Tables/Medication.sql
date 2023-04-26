CREATE TABLE [dbo].[Medication] (
    [MedicationID]   INT            IDENTITY (1, 1) NOT NULL,
    [MedicationName] NVARCHAR (64)  NOT NULL,
    [Purpose]        NVARCHAR (200) NOT NULL,
    PRIMARY KEY CLUSTERED ([MedicationID] ASC),
    UNIQUE NONCLUSTERED ([MedicationName] ASC)
);

