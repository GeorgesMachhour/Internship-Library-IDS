CREATE PROCEDURE [dbo].[spMember_Insert]
	@MemberFirstName nvarchar(50),
	@MemberLastName nvarchar(50),
	@MemberEmail nvarchar(100),
	@MemberPhone BIGINT,
	@MemberAddress nvarchar(255)
AS
begin
	insert into dbo.[Member] (MemberFirstName, MemberLastName, MemberEmail, 
	MemberPhone, MemberAddress)
	values (@MemberFirstName, @MemberLastName, @MemberEmail, @MemberPhone, @MemberAddress);
end
