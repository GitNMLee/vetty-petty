--CREATE PROCEDURE CommonMedicationByBreed
--AS

--WITH breed_count_cte(PetID, BreedID, BreedCount) AS (
--    SELECT P.PetID, P.BreedID, COUNT(P.PetID) AS BreedCount
--    FROM Pet P
--    GROUP BY P.BreedID
--),

--med_cte(PetID, MedicationID, MedCount) AS (
--    SELECT PM.PetID, PM.MedicationID, COUNT(PM.PetID) OVER (PARTITION BY P.BreedID) AS MedCount
--    FROM PetMed PM
--    INNER JOIN Pet P ON P.PetID = PM.PetID
--)

--SELECT
--    RANK() OVER (PARTITION BY B.BreedID, MCTE.MedCount ORDER BY MCTE.MedCount DESC) AS Rank,
--    B.BreedName,
--    BCTE.BreedCount,
--    M.MedicationName AS MostCommonMedicationName,
--    COUNT(MCTE.MedCount) OVER (PARTITION BY B.BreedID, MCTE.MedCount) AS TotalPrescribed 
--FROM breed_count_cte BCTE
--    INNER JOIN med_cte MCTE ON MCTE.PetID = BCTE.PetID
--    INNER JOIN Medication M ON MCTE.MedicationID = M.MedicationID
--    INNER JOIN Breed B ON B.BreedID = BCTE.BreedID

--GO;

CREATE PROCEDURE CommonMedicationByBreed
AS

WITH breed_count_cte(PetID, BreedID, BreedCount) AS (
    SELECT P.PetID, P.BreedID, COUNT(P.PetID) AS BreedCount
    FROM Pet P
    GROUP BY P.BreedID, P.PetID
),

med_cte(PetID, MedicationID, MedCount) AS (
    SELECT PM.PetID, PM.MedicationID, COUNT(PM.PetID) OVER (PARTITION BY P.BreedID) AS MedCount
    FROM PetMed PM
    INNER JOIN Pet P ON P.PetID = PM.PetID
)

SELECT
    RANK() OVER (PARTITION BY BCTE.BreedID, MCTE.MedCount ORDER BY MCTE.MedCount DESC) AS Rank,
    B.BreedName,
    BCTE.BreedCount,
    M.MedicationName AS MostCommonMedicationName,
    COUNT(MCTE.MedCount) OVER (PARTITION BY BCTE.BreedID, MCTE.MedCount) AS TotalPrescribed 
FROM breed_count_cte BCTE
INNER JOIN med_cte MCTE ON MCTE.PetID = BCTE.PetID
INNER JOIN Medication M ON MCTE.MedicationID = M.MedicationID
INNER JOIN Breed B ON B.BreedID = BCTE.BreedID