--Creates a list of breeds that have been prescribed medications and the most common med that that breed has been prescribed
CREATE PROCEDURE CommonMedicationByBreed
AS
WITH med_cte(BreedID, MedicationID, MedCount) AS (
    SELECT P.BreedID, PM.MedicationID, COUNT(*) AS MedCount
    FROM PetMed PM
    INNER JOIN Pet P ON P.PetID = PM.PetID
	GROUP BY P.BreedID, PM.MedicationID
)

SELECT
    RANK() OVER (ORDER BY MCTE.MedCount DESC) AS [Rank],
    B.BreedName,
    M.MedicationName AS MostCommonMedicationName,
	MCTE.MedCount AS TotalPrescribed
FROM med_cte MCTE
INNER JOIN Medication M ON MCTE.MedicationID = M.MedicationID
INNER JOIN Breed B ON B.BreedID = MCTE.BreedID