using DataAccess.DbAccess;
using DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Data;

public class MemberData : IMemberData
{
    private readonly ISqlDataAccess _db;

    public MemberData(ISqlDataAccess db)
    {
        _db = db;
    }

    public Task<IEnumerable<MemberModel>> GetMember() =>
        _db.LoadData<MemberModel, dynamic>("dbo.spMember_GetAll", new { });

    public async Task<MemberModel?> GetMember(int Member_id)
    {
        var results = await _db.LoadData<MemberModel, dynamic>(
            "dbo.spMember_Get",
            new { MemberId = Member_id });
        return results.FirstOrDefault();
    }

    public Task InsertMember(MemberModel Member) =>
        _db.SaveData("dbo.spMember_Insert", new
        {
            Member.MemberFirstName,
            Member.MemberLastName,
            Member.MemberEmail,
            Member.MemberPhone,
            Member.MemberAddress,
        });

    public Task UpdateMember(MemberModel Member) =>
        _db.SaveData("dbo.spMember_Update", Member);

    public Task DeleteMember(int Member_id) =>
        _db.SaveData("dbo.spMember_Delete", new { MemberId = Member_id });
}
