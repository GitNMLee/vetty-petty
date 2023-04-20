-- BREED
CREATE PROCEDURE SelectBreed
@BreedName NVARCHAR(30)
AS
SELECT B.BreedID, B.SpeciesID, B.BreedName
FROM Breed B
WHERE B.BreedName = @BreedName OR @BreedName = N''
GO;

-- SPECIES
CREATE PROCEDURE SelectSpecies
@SpeciesName NVARCHAR(30)
AS
SELECT S.SpeciesID, S.SpeciesName
FROM Species S
WHERE S.SpeciesName = @SpeciesName OR @SpeciesName = N''
GO;

-- Medications
CREATE PROCEDURE SelectMedication
@MedicationName NVARCHAR(30)
AS
SELECT M.MedicationID, M.MedicationName, M.Purpose
FROM Medications M
WHERE M.MedicationName = @MedicationName OR @MedicationName = N''
GO;

-- PetsMeds
CREATE PROCEDURE SelectPetsMeds
@PetID INT,
@MedicationID INT
AS
SELECT PM.PetMed, PM.PetID, PM.MedicationID, PM.Instructions
FROM PetsMeds PM
WHERE (PM.PetID = @PetID AND PM.MedicationID = @MedicationID) OR (@PetID IS NULL AND @MedicationID IS NULL)
GO;

-- Vets
CREATE PROCEDURE SelectVet
@FirstName NVARCHAR(30),
@LastName NVARCHAR(30)
AS
SELECT V.VetID, V.FirstName, V.LastName, V.HireDate, V.TerminationDate
FROM Vets V
WHERE (V.FirstName = @FirstName AND V.LastName = @LastName) OR (@FirstName = N'' AND @LastName = N'')
GO;

-- Appointment
CREATE PROCEDURE SelectAppointment
@VetID INT,
@Date DATE,
@Time TIME
AS
SELECT A.DateID, A.VetID, A.PetID, A.Date, A.Time, A.Reason
FROM Appointments A
WHERE (A.VetID = @VetID AND A.Date = @Date AND A.Time = @Time) OR (@VetID IS NULL AND @Date IS NULL AND @Time IS NULL)
GO;

-- Owners
CREATE PROCEDURE SelectOwner
@EMail NVARCHAR(50)
AS
SELECT O.OwnerID, O.FirstName, O.LastName, O.EMail
FROM Owners O
WHERE O.EMail = @EMail OR @EMail = N''
GO;

-- Pets
CREATE PROCEDURE SelectPet
@PetID INT
AS
SELECT P.PetID, P.OwnerID, P.BreedID, P.PetFirstName, P.PetLastName, P.Description, P.DesceasedOn
FROM Pets P
WHERE P.PetID = @PetID OR @PetID IS NULL
GO;

-- This query can be split into two parts, first inserting an Owner, then a Pet
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