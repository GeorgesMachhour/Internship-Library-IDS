CREATE PROCEDURE [dbo].[spBook_Delete]
	@BookId int
AS
begin
	delete
	from dbo.[Book]
	where BookId = @BookId;
end

