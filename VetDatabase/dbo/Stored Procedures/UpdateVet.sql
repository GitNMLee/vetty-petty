--Allows an entry of the Vet table to be updated
-- The updatable bits are FirstName, LastName, and HireDate
CREATE PROCEDURE [dbo].[UpdateVet]
	@VetID	   INT,
	@FirstName NVARCHAR(30),
	@LastName NVARCHAR(30)
AS
UPDATE V
SET V.FirstName = @FirstName,
V.LastName = @LastName
FROM Vet V
WHERE V.VetID = @VetID
