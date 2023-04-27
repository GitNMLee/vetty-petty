CREATE PROCEDURE SelectSpeciesWithBreed
@BreedID INT
AS
SELECT S.SpeciesID, S.SpeciesName
FROM Species S
	INNER JOIN Breed B ON B.SpeciesID = S.SpeciesID
WHERE B.BreedID = @BreedID
