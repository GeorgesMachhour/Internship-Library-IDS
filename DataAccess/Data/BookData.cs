using DataAccess.DbAccess;
using DataAccess.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DataAccess.Data
{
    public class BookData : IBookData
    {
        private readonly ISqlDataAccess _db;

        public BookData(ISqlDataAccess db)
        {
            _db = db;
        }

        public Task<IEnumerable<BookModel>> GetBooks() =>
            _db.LoadData<BookModel, dynamic>("dbo.spBook_GetAll", new { });

        public async Task<BookModel?> GetBook(int bookId)
        {
            var results = await _db.LoadData<BookModel, dynamic>(
                "dbo.spBook_Get",
                new { BookId = bookId });
            return results.FirstOrDefault();
        }

        public Task InsertBook(BookModel book) =>
            _db.SaveData("dbo.spBook_Insert", new
            {
                book.Title,
                book.AuthorId,
                book.AuthorFullName,
                book.PublisherId,
                book.PublisherName,
                book.Genre,
                book.ISBN,
                book.Publisher,
                book.Type
            });

        public Task UpdateBook(BookModel book) =>
            _db.SaveData("dbo.spBook_Update", new
            {
                book.BookId,
                book.Title,
                book.AuthorId,
                book.AuthorFullName,
                book.PublisherId,
                book.PublisherName,
                book.Genre,
                book.ISBN,
                book.Publisher,
                book.Type
            });

        public Task DeleteBook(int bookId) =>
            _db.SaveData("dbo.spBook_Delete", new { BookId = bookId });

        public Task<IEnumerable<BookModel>> GetBook()
        {
            throw new NotImplementedException();
        }
    }
}
