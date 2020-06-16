using System;
using System.Collections.Generic;
using System.Diagnostics.SymbolStore;
using System.Text;

namespace Interfaces.DTO
{
     public class BookDTO
    {
        public long ISBN { get; set; }
        public string Title { get; set; }
        public AuthorDTO author { get; set; }
        public string publisher { get; set; }
        public string Subtitle { get; set; }
        public string Category { get; set; }
        public string Book_Root { get; set; }
        public string Cover_Picture { get; set; }
        public string Year_of_publication { get; set; }

        public BookDTO(long ISBN, string title, AuthorDTO author, string publisher, string subtitle, string category, string book_root, string cover_picture, string year_of_publication)
        {
            this.ISBN = ISBN;
            this.Title = title;
            this.author = author;
            this.publisher = publisher;
            this.Subtitle = subtitle;
            this.Category = category;
            this.Book_Root = book_root;
            this.Cover_Picture = cover_picture;
            this.Year_of_publication = year_of_publication;
        }

        public BookDTO()
        {

        }
    }
}
