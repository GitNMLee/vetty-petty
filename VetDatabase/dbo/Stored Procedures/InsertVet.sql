﻿-- This allows the user to enter in a new vet
-- With variables of FirstName, LAstName and the current date and time as the HireDate
CREATE PROCEDURE InsertVet
@VetFirstName NVARCHAR(30),
@VetLastName NVARCHAR(30)
AS
DECLARE @HireDate DATETIME = SYSDATETIMEOFFSET();

MERGE Vet AS T
USING (SELECT @VetFirstName, @VetLastName, @HireDate) AS S(VetFirstName, VetLastName, HireDate)
ON T.FirstName = S.VetFirstName AND T.LastName = S.VetLastName
WHEN NOT MATCHED THEN
    INSERT (FirstName, LastName, HireDate)
    VALUES (S.VetFirstName, S.VetLastName, S.HireDate);

