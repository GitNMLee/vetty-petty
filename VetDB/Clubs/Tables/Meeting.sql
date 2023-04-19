CREATE TABLE [Clubs].[Meeting] (
    [MeetingId]   INT                IDENTITY (1, 1) NOT NULL,
    [ClubId]      INT                NOT NULL,
    [MeetingTime] DATETIME2 (0)      NOT NULL,
    [Location]    NVARCHAR (64)      NOT NULL,
    [CreatedOn]   DATETIMEOFFSET (7) DEFAULT (sysdatetimeoffset()) NOT NULL,
    [UpdatedOn]   DATETIMEOFFSET (7) DEFAULT (sysdatetimeoffset()) NOT NULL,
    PRIMARY KEY CLUSTERED ([MeetingId] ASC),
    FOREIGN KEY ([ClubId]) REFERENCES [Clubs].[Club] ([ClubId]),
    UNIQUE NONCLUSTERED ([ClubId] ASC, [MeetingTime] ASC)
);

