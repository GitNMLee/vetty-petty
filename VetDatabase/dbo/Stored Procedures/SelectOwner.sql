-- Selects an Owner given an Owner's Email
CREATE PROCEDURE SelectOwner
@Search NVARCHAR(50)
AS
SELECT O.OwnerID, O.FirstName, O.LastName, O.Email
FROM [Owner] O
WHERE O.Email = @Search OR O.FirstName = @Search OR O.LastName = @Search OR @Search = N''