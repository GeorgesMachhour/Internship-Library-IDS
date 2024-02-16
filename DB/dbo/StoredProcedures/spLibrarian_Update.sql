CREATE PROCEDURE [dbo].[spLibrarian_Update]
	@LibrarianId int,
	@LibrarianFirstName nvarchar(50),
	@LibrarianLastName nvarchar(50),
	@LibrarianEmail NVARCHAR(100),
    @LibrarianPhone BIGINT,
    @LibrarianAddress NVARCHAR(255)
AS
begin
	update dbo.[Librarian]
	set LibrarianFirstName = @LibrarianFirstName,
	LibrarianLastName = @LibrarianLastName,
	LibrarianEmail = @LibrarianEmail,
    LibrarianPhone = @LibrarianPhone,
    LibrarianAddress = @LibrarianAddress
	where LibrarianId = @LibrarianId;
end
