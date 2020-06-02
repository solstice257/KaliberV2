using System;
using System.Collections.Generic;
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
    }
}
