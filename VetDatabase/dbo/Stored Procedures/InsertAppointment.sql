--Allows the user to create an appointment with a specified pet and vet
-- at a specified date and time and for a given reason
CREATE PROCEDURE InsertAppointment
-- GIVEN VARIABLES
@PetFirstName NVARCHAR(30),
@PetLastName NVARCHAR(30),
@OwnerEMail NVARCHAR(50),
@VetID INT,
@Date DATE,
@Time TIME,
@Reason NVARCHAR(50)
AS
-- Find PetID
DECLARE @SelectedPetID INT = -1
SET @SelectedPetID = (
    SELECT P.PetID FROM Pet P
    INNER JOIN [Owner] O ON O.Email = @OwnerEMail
    WHERE P.PetFirstName = @PetFirstName AND P.PetLastName = @PetLastName 
    )
-- Insert the Appointment
MERGE Appointment AS T
USING (SELECT @VetID, @SelectedPetID, @Date, @Time, @Reason) AS S(VetID, SelectedPetID, [Date], [Time], [Reason])
ON T.VetID = S.VetID AND T.[Date] = S.[Date] AND T.[Time] = S.[Time]
WHEN NOT MATCHED AND @SelectedPetID <> -1 THEN
    INSERT (VetID, PetID, [Date], [Time], Reason)
    VALUES (S.VetID, S.SelectedPetID, S.Date, S.Time, S.Reason);