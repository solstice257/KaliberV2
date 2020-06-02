﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;


namespace Kaliber.Models
{
    public class BookView
    {

        [Required]
        public long ISBN { get; set; }
        [Required]
        public string Title { get; set; }
        public AuthorView author { get; set; }
        public string publisher { get; set; }
        public string Subtitle { get; set; }
        [Required]
        public string Category { get; set; }
        [Required]
        public string Book_Root { get; set; }
        [Required]
        public string Cover_Picture { get; set; }
        public string Year_Of_Publication { get; set; }
    }
}
