CREATE TABLE [Accounts].[Account] (
    [AccountId]       INT                IDENTITY (1, 1) NOT NULL,
    [AccountHolderId] INT                NOT NULL,
    [AccountNumber]   INT                NOT NULL,
    [Nickname]        NVARCHAR (32)      NOT NULL,
    [CreatedOn]       DATETIMEOFFSET (7) DEFAULT (sysdatetimeoffset()) NOT NULL,
    [UpdatedOn]       DATETIMEOFFSET (7) DEFAULT (sysdatetimeoffset()) NOT NULL,
    [ClosedOn]        DATETIMEOFFSET (7) NULL,
    PRIMARY KEY CLUSTERED ([AccountId] ASC),
    FOREIGN KEY ([AccountHolderId]) REFERENCES [Accounts].[AccountHolder] ([AccountHolderId]),
    UNIQUE NONCLUSTERED ([AccountNumber] ASC),
    UNIQUE NONCLUSTERED ([AccountHolderId] ASC, [Nickname] ASC)
);

