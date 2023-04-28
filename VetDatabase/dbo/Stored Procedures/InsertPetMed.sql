--Allows the user to prescribe a medication to a pet. T
--This acts as a prescription slip would in real life.
-- It is a connection table between Pet and Medication
CREATE PROCEDURE InsertPetMed
@OwnerEMail NVARCHAR(50),
@PetFirstName NVARCHAR(30),
@PetLastName NVARCHAR(30),
@MedicationID INT,
@Instructions NVARCHAR(120)
AS
DECLARE @OwnerID INT = (SELECT O.OwnerID FROM [Owner] O WHERE O.Email = @OwnerEMail);
DECLARE @PetID INT = (SELECT P.PetID FROM Pet P WHERE P.PetFirstName = @PetFirstName AND P.PetLastName = @PetLastName AND P.OwnerID = @OwnerID);

MERGE PetMed AS T
USING (SELECT @PetID, @MedicationID, @Instructions) AS S(PetID, MedicationID, Instructions)
ON T.PetID = @PetID AND T.MedicationID = @MedicationID
WHEN NOT MATCHED THEN
    INSERT (PetID, MedicationID, Instructions)
    VALUES (S.PetID, S.MedicationID, S.Instructions);
