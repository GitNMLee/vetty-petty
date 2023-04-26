--CREATE PROCEDURE MonthlyAppointmentsByVet
--@FirstDate DATETIME,
--@LastDate DATETIME
--AS

--WITH appointment_count_cte(VetID, AppointmentCount) AS (
--    SELECT
--        A.VetID,
--        COUNT(A.DateID) OVER (PARTITION BY A.VetID, YEAR(A.Date), MONTH(A.Date)) AS AppointmentCount
--    FROM Appointment A
--)


--SELECT YEAR(A.[Date]) AS [Year], MONTH(A.[Date]) AS [Month], V.LastName + N', ' + V.FirstName AS [VetName],
--    ACNT.AppointmentCount,
--    RANK() OVER (ORDER BY ACNT.AppointmentCount DESC) AS MonthlyRank
--FROM Vet V
--INNER JOIN appointment_count_cte ACNT ON ACNT.VetID = V.VetID
--GROUP BY ACNT.VetID
--ORDER BY MonthlyRank ASC
--GO;

CREATE PROCEDURE MonthlyAppointmentsByVet
@FirstDate DATETIME,
@LastDate DATETIME
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