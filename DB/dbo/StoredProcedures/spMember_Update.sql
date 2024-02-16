CREATE PROCEDURE [dbo].[spMember_Update]
	@MemberId int,
	@MemberFirstName nvarchar(50),
	@MemberLastName nvarchar(50),
	@MemberEmail NVARCHAR(100),
    @MemberPhone BIGINT,
    @MemberAddress NVARCHAR(255)
AS
begin
	update dbo.[Member]
	set MemberFirstName = @MemberFirstName,
	MemberLastName = @MemberLastName,
	MemberEmail = @MemberEmail,
    MemberPhone = @MemberPhone,
    MemberAddress = @MemberAddress
	where MemberId = @MemberId;
end
