CREATE PROCEDURE SelectVet
@Search NVARCHAR(30)
AS
SELECT V.VetID, V.FirstName, V.LastName, V.HireDate, V.TerminationDate
FROM Vet V
WHERE (V.FirstName = @Search OR V.LastName = @Search OR @Search = N'')
	AND V.TerminationDate IS NULL