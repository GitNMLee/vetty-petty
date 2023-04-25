CREATE PROCEDURE SelectMedication
@MedicationName NVARCHAR(30)
AS
SELECT M.MedicationID, M.MedicationName, M.Purpose
FROM Medication M
WHERE M.MedicationName = @MedicationName OR @MedicationName = N'';
