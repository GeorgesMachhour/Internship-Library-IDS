using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Models;

public class PublisherModel
{
    public int PublisherId { get; set; }
    public string PublisherName { get; set; }
    public string PublisherEmail { get; set; }
    public long PublisherPhone { get; set; }

public PublisherModel()
        {
            PublisherName = string.Empty;
            PublisherEmail = string.Empty;
            PublisherPhone = 0;
    
        }

}
