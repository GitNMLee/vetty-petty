-- Selects a Breed with a given BreedName, and SpeciesID
CREATE PROCEDURE SelectBreed
@BreedName NVARCHAR(30),
@SpeciesID INT
AS
SELECT B.BreedID, B.SpeciesID, B.BreedName
FROM Breed B
WHERE (B.BreedName = @BreedName OR @BreedName = N'') AND (B.SpeciesID = @SpeciesID);
