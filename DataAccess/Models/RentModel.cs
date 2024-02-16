using System;

namespace DataAccess.Models
{
    public class RentalModel
    {
        public int ID { get; set; }
        public int MemberId { get; set; }
        public int BookId { get; set; }
        public int LibrarianId { get; set; }
        public DateTime RentalDate { get; set; }
        public DateTime ReturnDate { get; set; }
        public string Status { get; set; }

        public RentalModel()
        {
            ID = 0;
            MemberId = 0;
            BookId = 0;
            LibrarianId = 0;
            RentalDate = DateTime.MinValue;
            ReturnDate = DateTime.MinValue;
            Status = string.Empty;
        }
    }
}
