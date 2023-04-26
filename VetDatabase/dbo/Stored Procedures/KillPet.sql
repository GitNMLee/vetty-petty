
CREATE PROCEDURE KillPet
@PetFirstName NVARCHAR(30),
@PetLastName NVARCHAR(30),
@OwnerEMail NVARCHAR(50)
AS
DECLARE @CurrentTime DATETIME = SYSDATETIMEOFFSET();
DECLARE @OwnerID INT = (SELECT O.OwnerID FROM [Owner] O WHERE O.Email = @OwnerEMail)
MERGE Pet AS T
USING (SELECT @PetFirstName, @PetLastName, @OwnerID) AS S(PetFirstName, PetLastName, OwnerID)
ON T.OwnerID = S.OwnerID AND T.PetFirstName = S.PetFirstName AND T.PetLastName = S.PetLastName
WHEN MATCHED THEN
    UPDATE
    SET DeceasedOn = @CurrentTime;