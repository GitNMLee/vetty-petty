CREATE PROCEDURE SelectPet
@PetID INT
AS
SELECT P.PetID, P.OwnerID, P.BreedID, P.PetFirstName, P.PetLastName, P.Description, P.DeceasedOn
FROM Pet P
WHERE P.PetID = @PetID OR @PetID IS NULL