CREATE TABLE [Accounts].[AccountHolder] (
    [AccountHolderId] INT                IDENTITY (1, 1) NOT NULL,
    [Email]           NVARCHAR (128)     NOT NULL,
    [FirstName]       NVARCHAR (32)      NOT NULL,
    [LastName]        NVARCHAR (32)      NOT NULL,
    [CreatedOn]       DATETIMEOFFSET (7) DEFAULT (sysdatetimeoffset()) NOT NULL,
    [UpdatedOn]       DATETIMEOFFSET (7) DEFAULT (sysdatetimeoffset()) NOT NULL,
    PRIMARY KEY CLUSTERED ([AccountHolderId] ASC),
    CHECK ([FirstName]>N''),
    CHECK ([LastName]>N''),
    UNIQUE NONCLUSTERED ([Email] ASC)
);

