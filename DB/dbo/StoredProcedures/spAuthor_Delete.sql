CREATE PROCEDURE [dbo].[spAuthor_Delete]
	@AuthorId int
AS
begin
	delete
	from dbo.[Author]
	where AuthorId = @AuthorId;
end
