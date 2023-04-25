CREATE PROCEDURE SelectBreed
@BreedName NVARCHAR(30)
AS
SELECT B.BreedID, B.SpeciesID, B.BreedName
FROM Breed B
WHERE B.BreedName = @BreedName OR @BreedName = N'';
