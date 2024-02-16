CREATE PROCEDURE [dbo].[spAuthor_GetAll]
AS
begin
	select AuthorId, AuthorFullName, AuthorNationality, AuthorBirthdate 
	from dbo.[Author];
end
