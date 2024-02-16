CREATE PROCEDURE [dbo].[spLibrarian_GetAll]
AS
begin
	select LibrarianId, LibrarianFirstName, LibrarianLastName, LibrarianEmail, LibrarianPhone, LibrarianAddress
	from dbo.[Librarian];
end
