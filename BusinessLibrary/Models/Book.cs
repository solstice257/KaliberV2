using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLibrary.Models
{
    class Book
    {
        public long ISBN { get; private set; }
        public string Title { get; private set; }
        public Author author { get; private set; }
        public Publisher publisher { get; private set; }
        public string Subtitle { get; private set; }
        public string Category { get; private set; }
        public string Book_Root { get; private set; }
        public string Cover_Picture { get; private set; }
        public DateTime Year_of_publication { get; private set; }

        public Book(long ISBN, string Title, Author author, Publisher publisher, string Subtitle, string Category, string Book_Root, string Cover_Picture, DateTime Year_of_publication )
        {
            this.ISBN = ISBN;
            this.Title = Title;
            this.author = author;
            this.publisher = publisher;
            this.Subtitle = Subtitle;
            this.Category = Category;
            this.Book_Root = Book_Root;
            this.Cover_Picture = Cover_Picture;
            this.Year_of_publication = Year_of_publication;
        }
    }
}
