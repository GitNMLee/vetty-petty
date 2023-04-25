CREATE PROCEDURE SelectOwner
@EMail NVARCHAR(50)
AS
SELECT O.OwnerID, O.FirstName, O.LastName, O.EMail
FROM [Owner] O
WHERE O.EMail = @EMail OR @EMail = N''