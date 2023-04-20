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