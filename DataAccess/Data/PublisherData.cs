using DataAccess.DbAccess;
using DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Data;

public class PublisherData : IPublisherData
{
    private readonly ISqlDataAccess _db;

    public PublisherData(ISqlDataAccess db)
    {
        _db = db;
    }

    public Task<IEnumerable<PublisherModel>> GetPublisher() =>
        _db.LoadData<PublisherModel, dynamic>("dbo.spPublisher_GetAll", new { });

    public async Task<PublisherModel?> GetPublisher(int Publisher_id)
    {
        var results = await _db.LoadData<PublisherModel, dynamic>(
            "dbo.spPublisher_Get",
            new { PublisherId = Publisher_id });
        return results.FirstOrDefault();
    }

    public Task InsertPublisher(PublisherModel Publisher) =>
        _db.SaveData("dbo.spPublisher_Insert", new { Publisher.PublisherName, 
             Publisher.PublisherEmail, Publisher.PublisherPhone
        });

    public Task UpdatePublisher(PublisherModel Publisher) =>
        _db.SaveData("dbo.spPublisher_Update", Publisher);

    public Task DeletePublisher(int Publisher_id) =>
        _db.SaveData("dbo.spPublisher_Delete", new { PublisherId = Publisher_id });
}
