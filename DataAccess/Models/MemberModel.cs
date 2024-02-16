using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Models;

public class MemberModel
{
    public int MemberId { get; set; }
    public string MemberFirstName { get; set; }
    public string MemberLastName { get; set; }
    public string MemberEmail { get; set; }
    public long MemberPhone { get; set; }
    public string MemberAddress { get; set; }

public MemberModel()
        {
            MemberFirstName = string.Empty;
            MemberLastName = string.Empty;
            MemberEmail = string.Empty;
            MemberPhone = 0;
            MemberAddress = string.Empty;
        }

}
