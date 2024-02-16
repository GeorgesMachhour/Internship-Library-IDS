using DataAccess.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DataAccess.Data;

public interface IAuthorData
{
    Task DeleteAuthor(int Author_id);
    Task<AuthorModel?> GetAuthor(int Author_id);
    Task<IEnumerable<AuthorModel>> GetAuthor();
    Task InsertAuthor(AuthorModel Author);
    Task UpdateAuthor(AuthorModel Author);
}