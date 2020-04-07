using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Kaliber.Models
{
    public class Book
    {
        public int ISBN;
        public string Title;
        public Author author;
        public Publisher publisher;
        public string Subtitle;
        public string Category;
        public string Book_Root;
        public byte[] Cover_Picture;
        public string Year_Of_Publication;

        public Book(int ISBN, Author author, Publisher publisher, string Title, string Subtitle, string Category, string Book_Root, byte[] Cover_Picture, string Year_Of_Publication)
        {
            this.ISBN = ISBN;
            this.author = author;
            this.publisher = publisher;
            this.Title = Title;
            this.Subtitle = Subtitle;
            this.Category = Category;
            this.Book_Root = Book_Root;
            this.Cover_Picture = Cover_Picture;
            this.Year_Of_Publication = Year_Of_Publication;
        }
    }
}
