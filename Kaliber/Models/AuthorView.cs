using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Kaliber.Models
{
    public class AuthorView
    {
        public int AuthorID { get; set; }
        public string Firstname { get; set; }
        public string Preposition { get; set; }
        public string Lastname { get; set; }
        public string City { get; set; }
        public string Year_of_birth { get; set; }
        public string Year_of_death { get; set; }
    }
}
