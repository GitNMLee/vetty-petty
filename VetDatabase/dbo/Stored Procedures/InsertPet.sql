
CREATE PROCEDURE InsertPet
-- GIVEN VARIABLES
@OwnerFirstName NVARCHAR(30),
@OwnerLastName NVARCHAR(30),
@OwnerEMail NVARCHAR(30),
@PetFirstName NVARCHAR(30),
@PetLastName NVARCHAR(30),
@PetSpecies NVARCHAR(30),
@PetBreed NVARCHAR(30),
@PetDescription NVARCHAR(30),

-- QUERY VARIABLES
@SelectedOwnerID INT,
@SelectedBreedID INT

AS

-- First Insert into owners if necessary
MERGE [Owner] AS [Target]
USING (SELECT @OwnerFirstName, @OwnerLastName, @OwnerEMail) AS [Source](OwnerFirstName, OwnerLastName, OwnerEMail)
ON [Target].Email = [Source].OwnerEMail
WHEN NOT MATCHED THEN
    INSERT (FirstName, LastName, Email)
    VALUES ([Source].OwnerFirstName, [Source].OwnerLastName, [Source].OwnerEMail);

-- Select OwnerID
SET @SelectedOwnerID = (SELECT O.OwnerID FROM [Owner] O WHERE O.Email = @OwnerEMail)

-- Select BreedID
SET @SelectedBreedID = (SELECT B.BreedID FROM Breed B WHERE B.BreedName = @PetBreed)

-- Insert Pet
MERGE Pet AS [Target]
USING (SELECT @SelectedOwnerID, @SelectedBreedID, @PetFirstName, @PetLastName, @PetDescription) AS [Source](SelectedOwnerID, SelectedBreedID, PetFirstName, PetLastName, PetDescription)
ON [Target].PetFirstName = [Source].PetFirstName AND [Target].PetLastName = [Source].PetLastName
WHEN NOT MATCHED THEN
    INSERT (OwnerID, BreedID, PetFirstName, PetLastName, [Description])
    VALUES ([Source].SelectedOwnerID, [Source].SelectedBreedID, [Source].PetFirstName, [Source].PetLastName, [Source].PetDescription);