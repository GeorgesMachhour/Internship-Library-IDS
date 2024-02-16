CREATE TABLE [dbo].[Publisher]
(
	[PublisherId] INT NOT NULL PRIMARY KEY IDENTITY, 
    [PublisherName] NVARCHAR(100) NOT NULL, 
    [PublisherEmail] NVARCHAR(100) NOT NULL,
    [PublisherPhone] BIGINT NOT NULL,
)

