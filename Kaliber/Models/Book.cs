using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Kaliber.Models
{
    public class Book
    {
        public int ISBN { get; set; }
        public string Title { get; set; }
        public Author author { get; set; }
        public Publisher publisher { get; set; }
        public string Subtitle { get; set; }
        public string Category { get; set; }
        public string Book_Root { get; set; }
        public byte[] Cover_Picture { get; set; }
        public string Year_Of_Publication { get; set; }
    }
}
