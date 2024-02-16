using System;

namespace DataAccess.Models
{
    public class PurchaseModel
    {
        public int ID { get; set; }
        public int MemberId { get; set; }
        public int BookId { get; set; }
        public int LibrarianId { get; set; }
        public DateTime PurchaseDate { get; set; }
        public string Status { get; set; }

        public PurchaseModel()
        {
            ID = 0;
            MemberId = 0;
            BookId = 0;
            LibrarianId = 0;
            PurchaseDate = DateTime.MinValue;
            Status = string.Empty;
        }
    }
}
