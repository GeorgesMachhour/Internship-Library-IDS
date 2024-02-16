CREATE PROCEDURE [dbo].[spLibrarian_Insert]
	@LibrarianFirstName nvarchar(50),
	@LibrarianLastName nvarchar(50),
	@LibrarianEmail nvarchar(100),
	@LibrarianPhone BIGINT,
	@LibrarianAddress nvarchar(255)
AS
begin
	insert into dbo.[Librarian] (LibrarianFirstName, LibrarianLastName, LibrarianEmail, 
	LibrarianPhone, LibrarianAddress)
	values (@LibrarianFirstName, @LibrarianLastName, @LibrarianEmail, @LibrarianPhone, @LibrarianAddress);
end
