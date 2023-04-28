--Allows an entry of the Vet table to be updated
-- The updatable bits are FirstName, LastName, and HireDate
CREATE PROCEDURE [dbo].[UpdateVet]
	@VetID	   INT,
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
WHERE V.VetID = @VetID AND (V.FirstName = @FirstName AND V.LastName = @LastName) AND V.HireDate IS NOT NULL
