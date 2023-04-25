CREATE PROCEDURE SelectVet
@FirstName NVARCHAR(30),
@LastName NVARCHAR(30)
AS
SELECT V.VetID, V.FirstName, V.LastName, V.HireDate, V.TerminationDate
FROM Vet V
WHERE (V.FirstName = @FirstName AND V.LastName = @LastName) OR (@FirstName = N'' AND @LastName = N'')