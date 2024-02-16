using DataAccess.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DataAccess.Data;

public interface IMemberData
{
    Task DeleteMember(int Member_id);
    Task<MemberModel?> GetMember(int Member_id);
    Task<IEnumerable<MemberModel>> GetMember();
    Task InsertMember(MemberModel Member);
    Task UpdateMember(MemberModel Member);
}