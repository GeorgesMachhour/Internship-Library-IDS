using DataAccess.Models;

namespace DataAccess.Data;

public interface ILibrarianData
{
    Task DeleteLibrarian(int Librarian_id);
    Task<LibrarianModel?> GetLibrarian(int Librarian_id);
    Task<IEnumerable<LibrarianModel>> GetLibrarian();
    Task InsertLibrarian(LibrarianModel Librarian);
    Task UpdateLibrarian(LibrarianModel Librarian);
}