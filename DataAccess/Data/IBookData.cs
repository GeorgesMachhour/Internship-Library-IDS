using DataAccess.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DataAccess.Data;

public interface IBookData
{
    Task DeleteBook(int Book_id);
    Task<BookModel?> GetBook(int Book_id);
    Task<IEnumerable<BookModel>> GetBook();
    Task InsertBook(BookModel Book);
    Task UpdateBook(BookModel Book);
}