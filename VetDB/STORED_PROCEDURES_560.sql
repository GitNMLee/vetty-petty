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

-- #1
CREATE PROCEDURE MonthlyAppointmentsByVet
@FirstDate DATETIME,
@LastDate DATETIME
AS

WITH appointment_count_cte AS (
    SELECT
        A.VetID,
        COUNT(A.DateID) OVER (PARTITION BY A.VetID, YEAR(A.Date), MONTH(A.Date)) AS AppointmentCount
    FROM Appointments A
)


SELECT YEAR(A.Date) AS [Year], MONTH(A.Date) AS [Month], V.LastName + N', ' + V.FirstName AS [VetName],
    ACNT.AppointmentCount,
    RANK() OVER (ORDER BY ACNT.AppointmentCount DESC) AS MonthlyRank
FROM Vets V
INNER JOIN appointment_count_cte ACNT ON ACNT.VetID = V.VetID
GROUP BY A.VetID
ORDER BY MonthlyRank ASC
GO;

-- #2
/* CREATE PROCEDURE CommonMedicationByBreed
AS

WITH breed_cnt_cte AS (
    SELECT B.BreedName, P.BreedID, COUNT(P.PetID) AS BreedCount
    FROM Breed B
    INNER JOIN Pets P ON B.BreedID = P.BreedID
    GROUP BY P.BreedID, B.BreedName
)

WITH med_cnt_cte AS (

)

SELECT

    BCTE.BreedName,
    BCTE.BreedCount

FROM breed_cnt_cte BCTE
INNER JOIN 

GO; */

-- #3
CREATE PROCEDURE CommonNamesByBreed
AS
SELECT P.PetFirstName AS [PetName], S.SpeciesName AS Species, B.BreedName AS Breed,
        RANK() OVER(PARTITION BY P.PetFirstName, B.BreedName) AS Rank
FROM Species S
INNER JOIN Breed B ON B.SpeciesID = S.SpeciesID
INNER JOIN Pets P ON P.BreedID = B.BreedID
ORDER BY Rank ASC
GO;

-- #4
CREATE PROCEDURE QuarterlyAppointments
@FirstDate DATETIME,
@LastDate DATETIME
AS

WITH quarter_cte AS (
    SELECT A.DateID, A.Date,
            CASE
                WHEN MONTH(A.Date) BETWEEN 1 AND 3 THEN 1
                WHEN MONTH(A.Date) BETWEEN 4 AND 6 THEN 2
                WHEN MONTH(A.Date) BETWEEN 7 AND 9 THEN 3
                ELSE 4
            END AS [Quarter]
    FROM Appointments A
)

SELECT 
    YEAR(Q.Date),
    Q.Quarter,
    COUNT(A.DateID) OVER (PARTITION BY YEAR(Q.Date), Q.Quarter) AS AppointmentCount
FROM quarter_cte Q
ORDER BY YEAR(Q.Date) DESC, Q.Quarter ASC
GO;