using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Kaliber
{
    public class Author
    {
        public int AuthorID;
        public string Firstname;
        public string Preposition;
        public string Lastname;
        public string City;
        public int Year_of_birth;
        public int Year_of_death;

        public Author(int AuthorID, string Firstname, string Lastname, string City, int Year_of_birth, int Year_of_death)
        {
            this.AuthorID = AuthorID;
            this.Firstname = Firstname;
            this.Lastname = Lastname;
            this.City = City;
            this.Year_of_birth = Year_of_birth;
            this.Year_of_death = Year_of_death;

        }
    }
}
