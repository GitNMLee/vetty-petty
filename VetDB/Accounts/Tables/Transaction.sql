CREATE TABLE [Accounts].[Transaction] (
    [TransactionId] INT                IDENTITY (1, 1) NOT NULL,
    [AccountId]     INT                NOT NULL,
    [Amount]        DECIMAL (12, 2)    NOT NULL,
    [CreatedOn]     DATETIMEOFFSET (7) DEFAULT (sysdatetimeoffset()) NOT NULL,
    PRIMARY KEY CLUSTERED ([TransactionId] ASC),
    FOREIGN KEY ([AccountId]) REFERENCES [Accounts].[Account] ([AccountId])
);

