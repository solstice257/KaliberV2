﻿using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using Interfaces.DTO;


namespace BusinessLibrary.Models
{
    public class Author
    {
        public int AuthorID { get; private set; }
        public string Firstname { get; private set; }
        public string Preposition { get; private set; }
        public string Lastname { get; private set; }
        public string City { get; private set; }
        public int Year_of_birth { get; private set; }
        public int Year_of_death { get; private set; }
        public Author(AuthorDTO authorDTO)
        {
            this.AuthorID = authorDTO.AuthorID;
            this.Firstname = authorDTO.Firstname;
            this.Preposition = authorDTO.Preposition;
            this.Lastname = authorDTO.Lastname;
            this.City = authorDTO.City;
            this.Year_of_birth = authorDTO.Year_of_birth;
            this.Year_of_death = authorDTO.Year_of_death;
        }

        public Author(int ID, string firstname, string prep, string lastname, string city, int birth, int death )
        {
            this.AuthorID = ID;
            this.Firstname = firstname;
            this.Preposition = prep;
            this.Lastname = lastname;
            this.City = city;
            this.Year_of_birth = birth;
            this.Year_of_death = death;
        }
        public Author()
        {

        }
    }
    
}
