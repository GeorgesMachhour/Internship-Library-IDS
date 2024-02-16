CREATE TABLE [dbo].[Librarian]
(
	[LibrarianId] INT NOT NULL PRIMARY KEY IDENTITY, 
    [LibrarianFirstName] NVARCHAR(50) NOT NULL, 
    [LibrarianLastName] NVARCHAR(50) NOT NULL,
    [LibrarianEmail] NVARCHAR(100) NOT NULL,
    [LibrarianPhone] BIGINT NOT NULL,
    [LibrarianAddress] NVARCHAR(255) NOT NULL
)
--librarian aka employee
