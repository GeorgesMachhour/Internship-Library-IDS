CREATE PROCEDURE [dbo].[spLibrarian_Get]
	@LibrarianId int
AS
begin
	select LibrarianId, LibrarianFirstName, LibrarianLastName, LibrarianEmail, LibrarianPhone, LibrarianAddress
	from dbo.[Librarian]
	where LibrarianId = @LibrarianId;
end
