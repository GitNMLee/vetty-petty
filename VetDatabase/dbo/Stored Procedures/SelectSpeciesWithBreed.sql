CREATE PROCEDURE SelectSpeciesWithBreed
@BreedID INT
AS
SELECT S.SpeciesID, S.SpeciesName
FROM Species S
WHERE S.SpeciesID = @BreedID
