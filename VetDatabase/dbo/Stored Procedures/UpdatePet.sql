--Allows the user to update any or all of the following attributes of a Pet:
-- Breed, Description and/or Deceased On Date
CREATE PROCEDURE [dbo].[UpdatePet] 
	@PetID		  INT  ,
	@OwnerID      INT  ,        
	@BreedID      INT  ,        
	@PetFirstName NVARCHAR (32),
	@PetLastName  NVARCHAR (32),
	@Description  NVARCHAR (200),
	@DeceasedOn   DATETIME = NULL
AS
UPDATE P
SET P.PetFirstName = @PetFirstName,
P.PetLastName = @PetLastName, 
P.BreedID = @BreedID,
P.Description = @Description,
P.DeceasedOn = @DeceasedOn
FROM Pet P
WHERE (P.PetID = @PetID AND P.OwnerID = @OwnerID AND P.PetFirstName = @PetFirstName AND P.PetLastName = @PetLastName)
