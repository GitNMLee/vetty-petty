CREATE PROCEDURE CommonNamesByBreed
AS
SELECT P.PetFirstName AS [PetName], S.SpeciesName AS Species, B.BreedName AS Breed,
        RANK() OVER(PARTITION BY P.PetFirstName, B.BreedName) AS Rank
FROM Species S
    INNER JOIN Breed B ON B.SpeciesID = S.SpeciesID
    INNER JOIN Pet P ON P.BreedID = B.BreedID
ORDER BY Rank ASC
GO;