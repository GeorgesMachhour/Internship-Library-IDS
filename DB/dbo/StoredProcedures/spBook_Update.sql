CREATE PROCEDURE [dbo].[spBook_Update]
    @BookId INT,
    @Title NVARCHAR(255),
    @AuthorFullName NVARCHAR(100),
    @Genre NVARCHAR(100),
    @ISBN NVARCHAR(20),
    @PublisherName NVARCHAR(100)
AS
BEGIN
    UPDATE dbo.[Book]
    SET Title = @Title,
        AuthorFullName = @AuthorFullName,
        Genre = @Genre,
        ISBN = @ISBN,
        PublisherName = @PublisherName
    WHERE BookId = @BookId;
END

