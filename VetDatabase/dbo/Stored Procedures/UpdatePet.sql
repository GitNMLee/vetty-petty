--Allows the user to update any or all of the following attributes of a Pet:
-- Breed, Description and/or Deceased On Date
CREATE PROCEDURE [dbo].[UpdatePet] 
	@PetID		  INT,       
	@BreedID      INT,        
	@PetFirstName NVARCHAR (32),
	@PetLastName  NVARCHAR (32),
	@Description  NVARCHAR (200)
AS
UPDATE P
SET P.PetFirstName = @PetFirstName,
P.PetLastName = @PetLastName, 
P.BreedID = @BreedID,
P.[Description] = @Description
FROM Pet P
WHERE P.PetID = @PetID
