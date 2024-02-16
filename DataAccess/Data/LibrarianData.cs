using DataAccess.DbAccess;
using DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Data;

public class LibrarianData : ILibrarianData
{
    private readonly ISqlDataAccess _db;

    public LibrarianData(ISqlDataAccess db)
    {
        _db = db;
    }

    public Task<IEnumerable<LibrarianModel>> GetLibrarian() =>
        _db.LoadData<LibrarianModel, dynamic>("dbo.spLibrarian_GetAll", new { });

    public async Task<LibrarianModel?> GetLibrarian(int Librarian_id)
    {
        var results = await _db.LoadData<LibrarianModel, dynamic>(
            "dbo.spLibrarian_Get",
            new { LibrarianId = Librarian_id });
        return results.FirstOrDefault();
    }

    public Task InsertLibrarian(LibrarianModel Librarian) =>
        _db.SaveData("dbo.spLibrarian_Insert", new { Librarian.LibrarianFirstName, 
            Librarian.LibrarianLastName,
            Librarian.LibrarianEmail, Librarian.LibrarianPhone, Librarian.LibrarianAddress,
        });

    public Task UpdateLibrarian(LibrarianModel Librarian) =>
        _db.SaveData("dbo.spLibrarian_Update", Librarian);

    public Task DeleteLibrarian(int Librarian_id) =>
        _db.SaveData("dbo.spLibrarian_Delete", new { LibrarianId = Librarian_id });
}
