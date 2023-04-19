CREATE TABLE [Clubs].[MeetingAttendee] (
    [MeetingId]  INT                NOT NULL,
    [AttendeeId] INT                NOT NULL,
    [CreatedOn]  DATETIMEOFFSET (7) DEFAULT (sysdatetimeoffset()) NOT NULL,
    PRIMARY KEY CLUSTERED ([MeetingId] ASC, [AttendeeId] ASC),
    FOREIGN KEY ([AttendeeId]) REFERENCES [Clubs].[Attendee] ([AttendeeId]),
    FOREIGN KEY ([MeetingId]) REFERENCES [Clubs].[Meeting] ([MeetingId])
);

