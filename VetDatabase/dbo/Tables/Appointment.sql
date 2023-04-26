CREATE TABLE [dbo].[Appointment] (
    [DateID] INT            IDENTITY (1, 1) NOT NULL,
    [VetID]  INT            NOT NULL,
    [PetID]  INT            NOT NULL,
    [Date]   DATE           NOT NULL,
    [Time]   TIME (7)       NOT NULL,
    [Reason] NVARCHAR (200) NOT NULL,
    PRIMARY KEY CLUSTERED ([DateID] ASC),
    FOREIGN KEY ([PetID]) REFERENCES [dbo].[Pet] ([PetID]),
    FOREIGN KEY ([VetID]) REFERENCES [dbo].[Vet] ([VetID]),
    UNIQUE NONCLUSTERED ([VetID] ASC, [Date] ASC, [Time] ASC)
);

