CREATE TABLE [Clubs].[Club] (
    [ClubId]    INT                IDENTITY (1, 1) NOT NULL,
    [Name]      NVARCHAR (64)      NOT NULL,
    [Purpose]   NVARCHAR (1024)    NOT NULL,
    [CreatedOn] DATETIMEOFFSET (7) DEFAULT (sysdatetimeoffset()) NOT NULL,
    [UpdatedOn] DATETIMEOFFSET (7) DEFAULT (sysdatetimeoffset()) NOT NULL,
    PRIMARY KEY CLUSTERED ([ClubId] ASC),
    UNIQUE NONCLUSTERED ([Name] ASC)
);

