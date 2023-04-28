-- Selects an Appointment with a given VetID, Date, and Time
CREATE PROCEDURE SelectAppointment
@VetID INT,
@Date DATE,
@Time TIME
AS
SELECT A.DateID, A.VetID, A.PetID, A.[Date], A.[Time], A.Reason
FROM Appointment A
WHERE (A.VetID = @VetID AND A.[Date] = @Date AND A.[Time] = @Time) OR (@VetID IS NULL AND @Date IS NULL AND @Time IS NULL)