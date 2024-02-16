CREATE TABLE [dbo].[Book]
(
	[BookId] INT NOT NULL PRIMARY KEY IDENTITY,
    [Title] VARCHAR(255) NOT NULL,
    [AuthorId] INT NOT NULL ,
    [AuthorFullName] NVARCHAR(100) NOT NULL,
    [PublisherId] INT NOT NULL,
    [PublisherName] NVARCHAR(100) NOT NULL,
    [Genre] VARCHAR(100),
    [ISBN] VARCHAR(20),
    [Publisher] VARCHAR(255),
    [Type] VARCHAR(20) CHECK ([Type] IN ('Regular Book', 'E-book')),
    FOREIGN KEY ([AuthorId]) REFERENCES [dbo].[Author]([AuthorId]),
    FOREIGN KEY ([AuthorFullName]) REFERENCES [dbo].[Author]([AuthorFullName]),
    FOREIGN KEY ([PublisherId]) REFERENCES [dbo].[Publisher]([PublisherId]),
    FOREIGN KEY ([PublisherName]) REFERENCES [dbo].[Publisher]([PublisherName]),
)