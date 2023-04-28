--This will return the number of appointments that are in a quarter (Jan-Mar = 1, April-June = 2, July-Sep = 3, Oct-Dec = 4)
-- only the quarters within a specified date are shown.
-- The quarters are in order of year (descending) and then quarter

CREATE PROCEDURE QuarterlyAppointments
@FirstDate DATETIME2 = '01-01-2000 12:00:00 AM',
@LastDate DATETIME2 = '01-01-2999 12:00:00 AM'
AS

WITH quarter_cte(DateID, [Year], [Quarter]) AS (
    SELECT A.DateID, YEAR(A.[Date]),
            CASE
                WHEN MONTH(A.[Date]) BETWEEN 1 AND 3 THEN 1
                WHEN MONTH(A.[Date]) BETWEEN 4 AND 6 THEN 2
                WHEN MONTH(A.[Date]) BETWEEN 7 AND 9 THEN 3
                ELSE 4
            END AS [Quarter]
    FROM Appointment A
    WHERE A.[Date] <= @LastDate AND A.[Date] >= @FirstDate
)

SELECT 
    Q.[Year],
    Q.[Quarter],
    COUNT(DISTINCT Q.DateID) AS AppointmentCount
FROM quarter_cte Q
GROUP BY Q.[Quarter], Q.[Year]
ORDER BY Q.[Year] DESC, Q.[Quarter] ASC