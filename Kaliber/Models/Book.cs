using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Kaliber.Models
{
    public class Book
    {
        int ISBN;
        string Title;
        string Subtitle;
        string Category;
        string Book_Root;
        string Cover_Picture;
        string Year_Of_Publication;

        public Book(int ISBN, string Title, string Subtitle, string Category, string Book_Root, string Cover_Picture, string Year_Of_Publication)
        {
            this.ISBN = ISBN;
            this.Title = Title;
            this.Subtitle = Subtitle;
            this.Category = Category;
            this.Book_Root = Book_Root;
            this.Cover_Picture = Cover_Picture;
            this.Year_Of_Publication = Year_Of_Publication;
        }
    }
}
