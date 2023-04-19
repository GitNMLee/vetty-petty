

DROP TABLE IF EXISTS Species;
DROP TABLE IF EXISTS Breed;
DROP TABLE IF EXISTS Medication;
DROP TABLE IF EXISTS Vet;
DROP TABLE IF EXISTS [Owner];
DROP TABLE IF EXISTS Pet;
DROP TABLE IF EXISTS PetMed;
DROP TABLE IF EXISTS Appointment;

CREATE TABLE Species
(
	SpeciesId INT NOT NULL PRIMARY KEY IDENTITY(1,1),
	SpeciesName NVARCHAR(32) NOT NULL UNIQUE
);

CREATE TABLE Breed
(
	BreedId INT NOT NULL PRIMARY KEY IDENTITY(1,1),
	SpeciesId INT NOT NULL REFERENCES Species(SpeciesId),
	BreedName NVARCHAR(32) NOT NULL UNIQUE
);

CREATE TABLE Medication
(
	MedicationId INT NOT NULL PRIMARY KEY IDENTITY(1,1),
	MedicationName NVARCHAR(64) NOT NULL UNIQUE,
	Purpose NVARCHAR(200) NOT NULL
);

CREATE TABLE Vet
(
	VetId INT NOT NULL PRIMARY KEY IDENTITY(1,1),
	FirstName NVARCHAR(32) NOT NULL,
	LastName NVARCHAR(32) NOT NULL,
	HireDate DATETIME NOT NULL,
	TerminationDate DATETIME NULL
);

CREATE TABLE [Owner]
(
	OwnerId INT NOT NULL PRIMARY KEY IDENTITY(1,1),
	FirstName NVARCHAR(32) NOT NULL,
	LastName NVARCHAR(32) NOT NULL,
	Email NVARCHAR(64) NOT NULL UNIQUE
);

CREATE TABLE Pet
(
	PetId INT NOT NULL PRIMARY KEY IDENTITY(1,1),
	OwnerId INT NOT NULL REFERENCES [Owner](OwnerId),
	BreedId INT NOT NULL REFERENCES Breed(BreedId),
	PetFirstName NVARCHAR(32) NOT NULL,
	PetLastName NVARCHAR(32) NOT NULL,
	[Description] NVARCHAR(200) NOT NULL,
	DeceasedOn DATETIME NULL
);

CREATE TABLE PetMed
(
	PetMedId INT NOT NULL PRIMARY KEY IDENTITY(1,1),
	PetId INT NOT NULL REFERENCES Pet(PetId),
	MedicationId INT NOT NULL REFERENCES Medication(MedicationId),
	Instructions NVARCHAR(200) NOT NULL,

	UNIQUE(PetId, MedicationId)
);

CREATE TABLE Appointment
(
	DateId INT NOT NULL PRIMARY KEY IDENTITY(1,1),
	VetId INT NOT NULL REFERENCES Vet(VetId),
	PetId INT NOT NULL REFERENCES Pet(PetId),
	[Date] DATE NOT NULL,
	[Time] TIME NOT NULL,
	Reason NVARCHAR(200) NOT NULL,

	UNIQUE(VetId, [Date], [Time])
);

--INSERT pets, owners, appointments, vets, petmeds, --
--?--
INSERT Species(SpeciesName)
VALUES
	('Cat'),
	('Dog'),
	('Bird'),
	('Small Mammal'),
	('Reptile'),
	('Fish'),
	('Amphibian'),
	('Wildlife');

 

--SELECT pet, owner, appointment, vet, petmed, medication, species, breed--


--UPDATE pet, owner, appointment, vet, petmed--



GO
