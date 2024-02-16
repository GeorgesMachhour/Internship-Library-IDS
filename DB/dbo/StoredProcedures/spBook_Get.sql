CREATE PROCEDURE [dbo].[spBook_Get]
    @BookId INT
AS
BEGIN
    SELECT BookId, Title, AuthorFullName AS Author, Genre, ISBN, PublisherName AS Publisher
    FROM dbo.[Book]
    INNER JOIN dbo.[Author] ON [Book].AuthorId = [Author].AuthorId
    INNER JOIN dbo.[Publisher] ON [Book].PublisherId = [Publisher].PublisherId
    WHERE BookId = @BookId;
END
