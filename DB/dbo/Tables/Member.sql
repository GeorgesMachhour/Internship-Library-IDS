CREATE TABLE [dbo].[Member]
(
	[MemberId] INT NOT NULL PRIMARY KEY IDENTITY, 
    [MemberFirstName] NVARCHAR(50) NOT NULL, 
    [MemberLastName] NVARCHAR(50) NOT NULL,
    [MemberEmail] NVARCHAR(100) NOT NULL,
    [MemberPhone] BIGINT NOT NULL,
    [MemberAddress] NVARCHAR(255) NOT NULL
)
--member aka client
