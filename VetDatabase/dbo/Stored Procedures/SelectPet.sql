CREATE PROCEDURE SelectPet
@PetName NVARCHAR
AS
SELECT P.PetID, P.OwnerID, P.BreedID, P.PetFirstName, P.PetLastName, P.Description, P.DeceasedOn
FROM Pet P
WHERE P.PetFirstName = @PetName OR P.PetLastName = @PetName OR @PetName = N''