CREATE PROCEDURE [dbo].[spMember_Delete]
	@MemberId int
AS
begin
	delete
	from dbo.[Member]
	where MemberId = @MemberId;
end
