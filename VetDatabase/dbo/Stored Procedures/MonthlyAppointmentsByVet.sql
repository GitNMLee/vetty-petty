CREATE PROCEDURE MonthlyAppointmentsByVet
@FirstDate AS DATETIME2 = '01-01-2000 12:00:00 AM',
@LastDate AS DATETIME2 = '01-01-2000 12:00:00 AM'
AS

WITH appointment_count_cte(VetID, AppointmentCount, AppointmentYear, AppointmentMonth) AS (
    SELECT
        A.VetID,
        COUNT(A.DateID) OVER (PARTITION BY A.VetID, YEAR(A.Date), MONTH(A.Date)),
        YEAR(A.[Date]),
        MONTH(A.[Date])
    FROM Appointment A
)


SELECT ACNT.AppointmentYear AS [Year], ACNT.AppointmentMonth AS [Month],
    V.LastName + N', ' + V.FirstName AS [VetName],
    ACNT.AppointmentCount,
    RANK() OVER (ORDER BY ACNT.AppointmentCount DESC) AS MonthlyRank
FROM Vet V
INNER JOIN appointment_count_cte ACNT ON ACNT.VetID = V.VetID
ORDER BY MonthlyRank ASC, [Year] ASC, [Month] ASC