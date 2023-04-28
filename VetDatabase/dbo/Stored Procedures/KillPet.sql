-- This allows a "soft delete" of a pet, which is essentially saying that this pet died
CREATE PROCEDURE KillPet
@PetFirstName NVARCHAR(30),
@PetLastName NVARCHAR(30),
@OwnerID INT
AS
DECLARE @CurrentTime DATETIME = SYSDATETIMEOFFSET();
MERGE Pet AS T
USING (SELECT @PetFirstName, @PetLastName, @OwnerID) AS S(PetFirstName, PetLastName, OwnerID)
ON T.OwnerID = S.OwnerID AND T.PetFirstName = S.PetFirstName AND T.PetLastName = S.PetLastName
WHEN MATCHED THEN
    UPDATE
    SET DeceasedOn = @CurrentTime;