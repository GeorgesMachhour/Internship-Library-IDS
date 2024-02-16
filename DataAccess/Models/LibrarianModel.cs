using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Models;

public class LibrarianModel
{
    public int LibrarianId { get; set; }
    public string LibrarianFirstName { get; set; }
    public string LibrarianLastName { get; set; }
    public string LibrarianEmail { get; set; }
    public long LibrarianPhone { get; set; }
    public string LibrarianAddress { get; set; }

public LibrarianModel()
        {
            LibrarianFirstName = string.Empty;
            LibrarianLastName = string.Empty;
            LibrarianEmail = string.Empty;
            LibrarianPhone = 0;
            LibrarianAddress = string.Empty;
        }

}
