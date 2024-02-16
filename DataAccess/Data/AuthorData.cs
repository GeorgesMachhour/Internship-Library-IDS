using DataAccess.DbAccess;
using DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Data;

public class AuthorData : IAuthorData
{
    private readonly ISqlDataAccess _db;

    public AuthorData(ISqlDataAccess db)
    {
        _db = db;
    }

    public Task<IEnumerable<AuthorModel>> GetAuthor() =>
        _db.LoadData<AuthorModel, dynamic>("dbo.spAuthor_GetAll", new { });

    public async Task<AuthorModel?> GetAuthor(int Author_id)
    {
        var results = await _db.LoadData<AuthorModel, dynamic>(
            "dbo.spAuthor_Get",
            new { AuthorId = Author_id });
        return results.FirstOrDefault();
    }

    public Task InsertAuthor(AuthorModel Author) =>
        _db.SaveData("dbo.spAuthor_Insert", new { Author.AuthorFullName, 
             Author.AuthorNationality, Author.AuthorBirthdate
        });

    public Task UpdateAuthor(AuthorModel Author) =>
        _db.SaveData("dbo.spAuthor_Update", Author);

    public Task DeleteAuthor(int Author_id) =>
        _db.SaveData("dbo.spAuthor_Delete", new { AuthorId = Author_id });
}
