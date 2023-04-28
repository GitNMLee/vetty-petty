-- Selects a PetMed record, given a PetID and MedicationID
CREATE PROCEDURE SelectPetMed
@PetID INT,
@MedicationID INT
AS
SELECT PM.PetMedID, PM.PetID, PM.MedicationID, PM.Instructions
FROM PetMed PM
WHERE (PM.PetID = @PetID AND PM.MedicationID = @MedicationID) OR (@PetID IS NULL AND @MedicationID IS NULL);
