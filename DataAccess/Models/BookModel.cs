using System;

namespace DataAccess.Models
{
    public class BookModel
    {
        public int BookId { get; set; }
        public string Title { get; set; }
        public int AuthorId { get; set; }
        public string AuthorFullName { get; set; }
        public int PublisherId { get; set; }
        public string PublisherName { get; set; }
        public string Genre { get; set; }
        public string ISBN { get; set; }
        public string Publisher { get; set; }
        public string Type { get; set; }

        public BookModel()
        {
            BookId = 0;
            Title = string.Empty;
            AuthorId = 0;
            AuthorFullName = string.Empty;
            PublisherId = 0;
            PublisherName = string.Empty;
            Genre = string.Empty;
            ISBN = string.Empty;
            Publisher = string.Empty;
            Type = string.Empty;
        }
    }
}
