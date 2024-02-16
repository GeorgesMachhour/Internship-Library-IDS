CREATE PROCEDURE [dbo].[spAuthor_Update]
	@AuthorId int,
	@AuthorFullName nvarchar(100),
	@AuthorNationality NVARCHAR(100),
    @AuthorBirthdate DATE
AS
begin
	update dbo.[Author]
	set AuthorFullName = @AuthorFullName,
	AuthorNationality = @AuthorNationality,
    AuthorBirthdate = @AuthorBirthdate
	where AuthorId = @AuthorId;
end
