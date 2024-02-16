CREATE PROCEDURE [dbo].[spAuthor_Get]
	@AuthorId int
AS
begin
	select AuthorId, AuthorFullName, AuthorNationality, AuthorBirthdate
	from dbo.[Author]
	where AuthorId = @AuthorId;
end
