using Microsoft.AspNetCore.Razor.TagHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Kaliber.Validator
{
    public class AuthorValidator
    {
        public string Result { get; private set; }

        public bool ValidateFirstname(string firstname)
        {
            if (String.IsNullOrEmpty(firstname))
            {
                Result = "Vul een voornaam in!";
                return false;
            }
            else if (!OnlyLetters(firstname))
            {
                Result = "Je kunt geen cijfers in je voornaam hebben!";
                return false;
            }
            return true;
        }

        public bool ValidatePreposition(string prep)
        {
            if (String.IsNullOrEmpty(prep))
            {
                return true;
            }
            else if (!OnlyLetters(prep))
            {
                Result = "Je kunt geen cijfers in je tussenvoegsel hebben!";
                return false;
            }
            return true;
        }

        public bool ValidateLastname(string lastname)
        {
            if (String.IsNullOrEmpty(lastname))
            {
                return true;
            }
            else if (!OnlyLetters(lastname))
            {
                Result = "Je kunt geen cijfers in je achternaam hebben!";
                return false;
            }
            return true;
        }

        public bool ValidateCity(string city)
        {
            if (String.IsNullOrEmpty(city))
            {
                return true;
            }
            else if (!OnlyLetters(city))
            {
                Result = "Je kunt geen getal als stad hebben!";
                return false;
            }
            return true;
        }

        public bool ValidateYearofbirth(string year)
        {
            if (String.IsNullOrEmpty(year))
            {
                return true;
            }
            else if (!OnlyNumbers(year))
            {
                Result = "Je kunt geen letters bij het geboortejaar invullen";
                return false;
            }
            return true;
        }

        public bool ValidateYearofdeath(string year)
        {
            if (String.IsNullOrEmpty(year))
            {
                return true;
            }
            else if (!OnlyNumbers(year))
            {
                Result = "Je kunt geen letters bij het sterftejaar invullen";
                return false;
            }
            return true;
        }

        private bool OnlyLetters(string text)
        {
            Regex regex = new Regex(@"^[a-z A-Z]*$");
            if (regex.IsMatch(text))
            {
                return true;
            }
            return false;
        }

        public bool OnlyNumbers(string text)
        {
            Regex regex = new Regex("^[0-9 ]*$");
            if (regex.IsMatch(text))
            {
                return true;
            }
            return false;
        }
    }
}
