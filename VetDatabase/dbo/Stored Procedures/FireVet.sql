--This allows the user to fire a vet, which is essentially a soft delete of that vet.
CREATE PROCEDURE FireVet
@VetFirstName NVARCHAR(30),
@VetLastName NVARCHAR(30)
AS
DECLARE @VetID INT = (SELECT V.VetID FROM Vet V WHERE V.FirstName = @VetFirstName AND V.LastName = @VetLastName);
DECLARE @TermDate DATETIME = SYSDATETIMEOFFSET();

MERGE Vet AS T
USING (SELECT @VetID) AS S(VetID)
ON T.VetID = S.VetID
WHEN MATCHED THEN
    UPDATE
    SET TerminationDate = @TermDate;