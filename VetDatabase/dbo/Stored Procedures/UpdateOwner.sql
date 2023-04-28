--Allows the user to update an owner
CREATE PROCEDURE [dbo].[UpdateOwner]
	@OwnerID INT,
	@EMail NVARCHAR(50),
	@FirstName NVARCHAR(30),
	@LastName NVARCHAR(30)
AS
	UPDATE O
SET O.Email = @EMail,
O.FirstName = @FirstName,
O.LastName = @LastName
FROM [Owner] O
WHERE O.OwnerID = @OwnerID
