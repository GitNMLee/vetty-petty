--A ranked list is returned which shows the most common names by breed
--Ordered by rank, then species then breed
CREATE PROCEDURE CommonNamesByBreed
AS
WITH name_rank_cte AS
(
	SELECT
	P.PetFirstName AS [PetName], S.SpeciesName AS Species, B.BreedName AS Breed,
	COUNT(P.PetFirstName) AS [Count]
	FROM Species S
    INNER JOIN Breed B ON B.SpeciesID = S.SpeciesID
    INNER JOIN Pet P ON P.BreedID = B.BreedID
	GROUP BY P.PetFirstName, S.SpeciesName, B.BreedName
)
SELECT RCTE.[PetName], RCTE.Species, RCTE.Breed,
        RANK() OVER(ORDER BY RCTE.[Count] DESC) AS [Rank]
FROM name_rank_cte RCTE
ORDER BY [Rank] ASC, RCTE.Species ASC, RCTE.Breed ASC