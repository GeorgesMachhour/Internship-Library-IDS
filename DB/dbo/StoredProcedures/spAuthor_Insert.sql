CREATE PROCEDURE [dbo].[spAuthor_Insert]
	@AuthorFullName nvarchar(100),
	@AuthorNationality nvarchar(100),
	@AuthorBirthdate DATE,
	
AS
begin
	insert into dbo.[Author] (AuthorFullName, AuthorNationality, AuthorBirthdate)
	values (@AuthorFulltName, @AuthorNationality, @AuthorBirthdate);
end
