using DataAccess.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DataAccess.Data;

public interface IPublisherData
{
    Task DeletePublisher(int Publisher_id);
    Task<PublisherModel?> GetPublisher(int Publisher_id);
    Task<IEnumerable<PublisherModel>> GetPublisher();
    Task InsertPublisher(PublisherModel Publisher);
    Task UpdatePublisher(PublisherModel Publisher);
}