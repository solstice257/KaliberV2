using System;
using System.Collections.Generic;
using System.Text;

namespace Interfaces.DTO
{
    public class AuthorDTO
    {
        public int AuthorID { get; private set; }
        public string Firstname { get; set; }
        public string Preposition { get; set; }
        public string Lastname { get; set; }
        public string City { get; private set; }
        public int Year_of_birth { get; private set; }
        public int Year_of_death { get; private set; }
        public AuthorDTO(int AuthorID, string Firstname, string Preposition, string Lastname, string City, int Year_of_birth, int Year_of_death)
        {
            this.AuthorID = AuthorID;
            this.Firstname = Firstname;
            this.Preposition = Preposition;
            this.Lastname = Lastname;
            this.City = City;
            this.Year_of_birth = Year_of_birth;
            this.Year_of_death = Year_of_death;
        }
        public AuthorDTO()
        {

        }

    }
}
