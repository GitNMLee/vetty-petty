CREATE PROCEDURE SelectSpecies
@SpeciesName NVARCHAR(30)
AS
SELECT S.SpeciesID, S.SpeciesName
FROM Species S
WHERE S.SpeciesName = @SpeciesName OR @SpeciesName = N''