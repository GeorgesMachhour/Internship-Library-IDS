CREATE PROCEDURE [dbo].[spRentBook]
    @MemberId INT,
    @BookId INT,
    @LibrarianId INT,
    @RentalDate DATETIME,
    @ReturnDate DATETIME,
    @Status VARCHAR(255)
AS
BEGIN
    
    INSERT INTO dbo.[Rental] (MemberId, BookId, LibrarianId, RentalDate, ReturnDate, Status)
    VALUES (@MemberId, @BookId, @LibrarianId, @RentalDate, @ReturnDate, @Status);
END
