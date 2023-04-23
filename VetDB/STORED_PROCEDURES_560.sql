-------------- BREED --------------
CREATE PROCEDURE SelectBreed
@BreedName NVARCHAR(30)
AS
SELECT B.BreedID, B.SpeciesID, B.BreedName
FROM Breed B
WHERE B.BreedName = @BreedName OR @BreedName = N''
GO;


-------------- SPECIES --------------
CREATE PROCEDURE SelectSpecies
@SpeciesName NVARCHAR(30)
AS
SELECT S.SpeciesID, S.SpeciesName
FROM Species S
WHERE S.SpeciesName = @SpeciesName OR @SpeciesName = N''
GO;


-------------- MEDICATIONS --------------
CREATE PROCEDURE SelectMedication
@MedicationName NVARCHAR(30)
AS
SELECT M.MedicationID, M.MedicationName, M.Purpose
FROM Medications M
WHERE M.MedicationName = @MedicationName OR @MedicationName = N''
GO;


-------------- PETSMEDS --------------
CREATE PROCEDURE SelectPetsMeds
@PetID INT,
@MedicationID INT
AS
SELECT PM.PetMed, PM.PetID, PM.MedicationID, PM.Instructions
FROM PetsMeds PM
WHERE (PM.PetID = @PetID AND PM.MedicationID = @MedicationID) OR (@PetID IS NULL AND @MedicationID IS NULL)
GO;

CREATE PROCEDURE InsertPetsMeds
@OwnerEMail NVARCHAR(50),
@PetFirstName NVARCHAR(30),
@PetLastName NVARCHAR(30),
@MedicationID INT,
@Instructions NVARCHAR(120)
AS
DECLARE @OwnerID INT = (SELECT O.OwnerID FROM Owners O WHERE O.EMail = @OwnerEMail);
DECLARE @PetID INT = (SELECT P.PetID FROM Pets P WHERE P.PetFirstName = @PetFirstName AND P.PetLastName = @PetLastName AND P.OwnerID = @OwnerID);

MERGE PetsMeds AS T
USING (SELECT @PetID, @MedicationID, @Instructions) AS S
ON T.PetID = @PetID AND T.MedicationID = @MedicationID
WHEN NOT MATCHED THEN
    INSERT (PetID, MedicationID, Instructions)
    VALUES (S.PetID, S.MedicationID, S.Instructions);
GO;


-------------- VETS --------------
CREATE PROCEDURE SelectVet
@FirstName NVARCHAR(30),
@LastName NVARCHAR(30)
AS
SELECT V.VetID, V.FirstName, V.LastName, V.HireDate, V.TerminationDate
FROM Vets V
WHERE (V.FirstName = @FirstName AND V.LastName = @LastName) OR (@FirstName = N'' AND @LastName = N'')
GO;

CREATE PROCEDURE InsertVet
@VetFirstName NVARCHAR(30),
@VetLastName NVARCHAR(30)
AS
DECLARE @HireDate DATETIME = SYSDATETIMEOFFSET();

MERGE Vets AS T
USING (SELECT @VetFirstName, @VetLastName, @HireDate) AS S
ON T.FirstName = S.VetFirstName AND T.LastName = S.VetLastName
WHEN NOT MATCHED THEN
    INSERT (FirstName, LastName, HireDate)
    VALUES (S.VetFirstName, S.VetLastName, S.HireDate);

GO;

CREATE PROCEDURE FireVet
@VetFirstName NVARCHAR(30),
@VetLastName NVARCHAR(30)
AS
DECLARE @VetID INT = (SELECT V.VetID FROM Vets V WHERE V.FirstName = @VetFirstName AND V.LastName = @VetLastName);
DECLARE @TermDate DATETIME = SYSDATETIMEOFFSET();

MERGE Vets AS T
USING (SELECT @VetID) AS S
ON T.VetID = S.VetID
WHEN MATCHED THEN
    UPDATE
    SET TerminationDate = @TermDate;
GO;


-------------- APPOINTMENTS --------------
CREATE PROCEDURE SelectAppointment
@VetID INT,
@Date DATE,
@Time TIME
AS
SELECT A.DateID, A.VetID, A.PetID, A.Date, A.Time, A.Reason
FROM Appointments A
WHERE (A.VetID = @VetID AND A.Date = @Date AND A.Time = @Time) OR (@VetID IS NULL AND @Date IS NULL AND @Time IS NULL)
GO;

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
    SELECT P.PetID FROM Pets P
    INNER JOIN Owners O ON O.EMail = @OwnerEMail
    WHERE P.PetFirstName = @PetFirstName AND P.PetLastName = @PetLastName 
    )
-- Insert the Appointment
MERGE Appointments AS T
USING (SELECT @VetID, @SelectedPetID, @Date, @Time, @Reason) AS S
ON T.VetID = S.VetID AND T.Date = S.Date AND T.Time = S.Time
WHEN NOT MATCHED AND @SelectedPetID <> -1 THEN
    INSERT (VetID, PetID, [Date], [Time], Reason)
    VALUES (S.VetID, S.SelectedPetID, S.Date, S.Time, S.Reason);
GO;


-------------- OWNERS --------------
CREATE PROCEDURE SelectOwner
@EMail NVARCHAR(50)
AS
SELECT O.OwnerID, O.FirstName, O.LastName, O.EMail
FROM Owners O
WHERE O.EMail = @EMail OR @EMail = N''
GO;


-------------- PETS --------------
CREATE PROCEDURE SelectPet
@PetID INT
AS
SELECT P.PetID, P.OwnerID, P.BreedID, P.PetFirstName, P.PetLastName, P.Description, P.DesceasedOn
FROM Pets P
WHERE P.PetID = @PetID OR @PetID IS NULL
GO;

CREATE PROCEDURE InsertPet
-- GIVEN VARIABLES
@OwnerFirstName NVARCHAR(30),
@OwnerLastName NVARCHAR(30),
@OwnerEMail NVARCHAR(30),
@PetFirstName NVARCHAR(30),
@PetLastName NVARCHAR(30),
@PetSpecies NVARCHAR(30),
@PetBreed NVARCHAR(30),
@PetDescription NVARCHAR(30),

-- QUERY VARIABLES
@SelectedOwnerID INT,
@SelectedBreedID INT

AS

-- First Insert into owners if necessary
MERGE Owners AS [Target]
USING (SELECT @OwnerFirstName, @OwnerLastName, @OwnerEMail) AS [Source]
ON [Target].EMail = [Source].EMail
WHEN NOT MATCHED THEN
    INSERT (FirstName, LastName, EMail)
    VALUES ([Source].OwnerFirstName, [Source].OwnerLastName, [Source].OwnerEMail);

-- Select OwnerID
SET @SelectedOwnerID = (SELECT O.OwnerID FROM Owners O WHERE O.EMail = @OwnerEMail)

-- Select BreedID
SET @SelectedBreedID = (SELECT B.BreedID FROM Breed B WHERE B.BreedName = @PetBreed)

-- Insert Pet
MERGE Pets AS [Target]
USING (SELECT @SelectedOwnerID, @SelectedBreedID, @PetFirstName, @PetLastName, @PetDescription) AS [Source]
ON [Target].PetFirstName = [Source].PetFirstName AND [Target].PetLastName = [Source].PetLastName
WHEN NOT MATCHED THEN
    INSERT (OwnerID, BreedID, PetFirstName, PetLastName, [Description])
    VALUES ([Source].SelectedOwnerID, [Source].SelectedBreedID, [Source].PetFirstName, [Source].PetLastName, [Source].PetDescription);

GO;


CREATE PROCEDURE KillPet
@PetFirstName NVARCHAR(30),
@PetLastName NVARCHAR(30),
@OwnerEMail NVARCHAR(50)
AS
DECLARE @CurrentTime DATETIME = SYSDATETIMEOFFSET();
DECLARE @OwnerID INT = (SELECT O.OwnerID FROM Owners O WHERE O.EMail = @OwnerEMail)
MERGE Pets AS T
USING (SELECT @PetFirstName, @PetLastName, @OwnerID) AS S
ON T.OwnerID = S.OwnerID AND T.PetFirstName = S.PetFirstName AND T.PetLastName = S.PetLastName
WHEN MATCHED THEN
    UPDATE
    SET DeceasedOn = @CurrentTime;
GO;


-------------- AGGREGATED QUERIES --------------