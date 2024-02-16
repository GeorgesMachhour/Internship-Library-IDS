CREATE TABLE [dbo].[Author]
(
	[AuthorId] INT NOT NULL PRIMARY KEY IDENTITY, 
    [AuthorFullName] NVARCHAR(100) NOT NULL, 
    [AuthorNationality] NVARCHAR(100) NOT NULL,
    [AuthorBithdate] DATE NOT NULL
)

