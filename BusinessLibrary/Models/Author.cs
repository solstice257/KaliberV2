using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLibrary.Models
{
    class Author
    {
        public int AuthorID { get; private set; }
        public string Firstname { get; private set; }
        public string Preposition { get; private set; }
        public string Lastname { get; private set; }
        public string City { get; private set; }
        public int Year_of_birth { get; private set; }
        public int Year_of_death { get; private set; }
        public Author(int AuthorID, string Firstname, string Preposition, string Lastname, string City, int Year_of_birth, int Year_of_death )
        {
            this.AuthorID = AuthorID;
            this.Firstname = Firstname;
            this.Preposition = Preposition;
            this.Lastname = Lastname;
            this.City = City;
            this.Year_of_birth = Year_of_birth;
            this.Year_of_death = Year_of_death;
        }
    }
    
}
