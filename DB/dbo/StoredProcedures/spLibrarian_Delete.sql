CREATE PROCEDURE [dbo].[spLibrarian_Delete]
	@LibrarianId int
AS
begin
	delete
	from dbo.[Librarian]
	where LibrarianId = @LibrarianId;
end
