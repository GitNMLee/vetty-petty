CREATE PROCEDURE QuarterlyAppointments
@FirstDate DATETIME2 = '01-01-2000 12:00:00 AM',
@LastDate DATETIME2 = '01-01-2000 12:00:00 AM'
AS

WITH quarter_cte(DateID, [Date], [Quarter]) AS (
    SELECT A.DateID, A.[Date],
            CASE
                WHEN MONTH(A.[Date]) BETWEEN 1 AND 3 THEN 1
                WHEN MONTH(A.[Date]) BETWEEN 4 AND 6 THEN 2
                WHEN MONTH(A.[Date]) BETWEEN 7 AND 9 THEN 3
                ELSE 4
            END AS [Quarter]
    FROM Appointment A
)

SELECT 
    YEAR(Q.[Date]),
    Q.[Quarter],
    COUNT(Q.DateID) OVER (PARTITION BY YEAR(Q.[Date]), Q.[Quarter]) AS AppointmentCount
FROM quarter_cte Q
ORDER BY YEAR(Q.[Date]) DESC, Q.[Quarter] ASC