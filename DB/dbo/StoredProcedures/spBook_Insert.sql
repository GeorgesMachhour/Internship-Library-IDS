CREATE PROCEDURE [dbo].[spBook_Insert]
    @BookId INT,
    @Title VARCHAR(255),
    @AuthorFullName NVARCHAR(100),
    @Genre NVARCHAR(100),
    @ISBN NVARCHAR(20),
    @PublisherName NVARCHAR(100)
AS
BEGIN
 
    INSERT INTO dbo.[Book] (BookId, Title, AuthorFullName, Genre, ISBN, PublisherName)
    VALUES (@BookId, @Title, @AuthorFullName, @Genre, @ISBN, @PublisherName);
END
