CREATE TABLE [dbo].[Employe]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [Nom] VARCHAR(50) NOT NULL, 
    [Prenom] VARCHAR(50) NULL, 
    [CIN] VARCHAR(50) NOT NULL, 
    [CNSS] VARCHAR(50) NULL, 
    [Date] DATE NULL, 
    [Matricule] VARCHAR(50) NULL, 
    [JourDeConge] INT NULL
)
