CREATE PROCEDURE [dbo].[spMember_GetAll]
AS
begin
	select MemberId, MemberFirstName, MemberLastName, MemberEmail, MemberPhone, MemberAddress
	from dbo.[Member];
end
