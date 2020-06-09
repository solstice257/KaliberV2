using System;
using System.Collections.Generic;
using System.Text;
using Interfaces.DTO;


namespace BusinessLibrary.Models
{
    public class Book
    {
        public long ISBN { get; private set; }
        public string Title { get; private set; }
        public AuthorDTO author { get; private set; }
        public string publisher { get; private set; }
        public string Subtitle { get; private set; }
        public string Category { get; private set; }
        public string Book_Root { get; private set; }
        public string Cover_Picture { get; private set; }
        public string Year_of_publication { get; private set; }

        public Book()
        {

        }

        public Book(BookDTO bookDTO)
        {
            this.ISBN = bookDTO.ISBN;
            this.Title = bookDTO.Title;
            this.author = bookDTO.author;
            this.publisher = bookDTO.publisher;
            this.Subtitle = bookDTO.Subtitle;
            this.Category = bookDTO.Category;
            this.Book_Root = bookDTO.Book_Root;
            this.Cover_Picture = bookDTO.Cover_Picture;
            this.Year_of_publication = bookDTO.Year_of_publication;
        }
    }
}
