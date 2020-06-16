using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;


namespace Kaliber.Models
{
    public class BookView
    {
        public long ISBN { get; set; }
        public string Title { get; set; }
        public AuthorView author { get; set; }
        public string publisher { get; set; }
        public string Subtitle { get; set; }
        public string Category { get; set; }
        public string Book_Root { get; set; }
        public string Cover_Picture { get; set; }
        public string Year_of_publication { get; set; }
    }
}
