CREATE PROCEDURE [dbo].[spPurchaseBook]
    @MemberId INT,
    @BookId INT,
    @LibrarianId INT,
    @PurchaseDate DATETIME,
    @Status VARCHAR(255)
AS
BEGIN
    
    INSERT INTO dbo.[Purchase] (MemberId, BookId, LibrarianId, PurchaseDate, Status)
    VALUES (@MemberId, @BookId, @LibrarianId, @PurchaseDate, @Status);
END
