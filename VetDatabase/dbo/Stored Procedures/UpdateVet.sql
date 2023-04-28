CREATE PROCEDURE [dbo].[UpdateVet]
	@FirstName NVARCHAR(30),
	@LastName NVARCHAR(30),
	@HireDate DATETIME,
	@TerminationDate DATETIME = NULL
AS
UPDATE V
SET V.FirstName = @FirstName,
V.LastName = @LastName,
V.HireDate = @HireDate,
V.TerminationDate = @TerminationDate
FROM Vet V
WHERE (V.FirstName = @FirstName OR V.LastName = @LastName) AND V.HireDate IS NOT NULL 
