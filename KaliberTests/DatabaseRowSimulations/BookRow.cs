using System;
using System.Collections.Generic;
using System.Text;

namespace KaliberTests.DatabaseRowSimulations
{
    public class BookRow
    {
        public long ISBN { get; set; }
        public string Title { get; set; }
        public int AuhtorID { get; set; }
        public string publisher { get; set; }
        public string Subtitle { get; set; }
        public string Category { get; set; }
        public string Year_of_publication { get; set; }
        public BookRow(long ISBN, string title, int authorID, string publisher, string subtitle, string category, string year_of_publication)
        {
            this.ISBN = ISBN;
            this.Title = title;
            this.Subtitle = subtitle;
            this.AuhtorID = authorID;
            this.publisher = publisher;
            this.Category = category;
            this.Year_of_publication = year_of_publication;
        }
    }
}
