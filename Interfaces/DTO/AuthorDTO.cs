using System;
using System.Collections.Generic;
using System.Text;

namespace Interfaces.DTO
{
    public class AuthorDTO
    {

        public int AuthorID { get;  set; }
        public string Firstname { get;  set; }
        public string Preposition { get;  set; }
        public string Lastname { get;  set; }
        public string City { get;  set; }
        public int Year_of_birth { get;  set; }
        public int Year_of_death { get;  set; }
    }
}
