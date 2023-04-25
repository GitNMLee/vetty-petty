CREATE PROCEDURE SelectOwner
@EMail NVARCHAR(50)
AS
SELECT O.OwnerID, O.FirstName, O.LastName, O.Email
FROM [Owner] O
WHERE O.Email = @EMail OR @EMail = N''