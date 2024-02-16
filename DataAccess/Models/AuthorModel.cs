using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Models;

public class AuthorModel
{
    public int AuthorId { get; set; }
    public string AuthorFullName { get; set; }
    public string AuthorNationality { get; set; }
    public DateTime AuthorBirthdate { get; set; }

public AuthorModel()
        {
            AuthorFullName = string.Empty;
            AuthorNationality = string.Empty;
            AuthorBirthdate = DateTime.MinValue;
    
        }

}
