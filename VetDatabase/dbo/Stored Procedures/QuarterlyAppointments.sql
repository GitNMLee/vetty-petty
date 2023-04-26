CREATE PROCEDURE QuarterlyAppointments
@FirstDate DATETIME,
@LastDate DATETIME
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
)

SELECT 
    Q.[Year],
    Q.[Quarter],
    COUNT(DISTINCT Q.DateID) AS AppointmentCount
FROM quarter_cte Q
GROUP BY Q.[Quarter], Q.[Year]
ORDER BY Q.[Year] DESC, Q.[Quarter] ASC