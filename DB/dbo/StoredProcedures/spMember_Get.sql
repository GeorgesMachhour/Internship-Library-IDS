CREATE PROCEDURE [dbo].[spMember_Get]
	@MemberId int
AS
begin
	select MemberId, MemberFirstName, MemberLastName, MemberEmail, MemberPhone, MemberAddress
	from dbo.[Member]
	where MemberId = @MemberId;
end
