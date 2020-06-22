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
            if (!OnlyLetters(firstname))
            {
                Result = "Je kunt geen cijfers in je voornaam hebben!";
                return false;
            }
            else if (String.IsNullOrEmpty(firstname))
            {
                Result = "Vul een voornaam in!";
            }
            return true;
        }

        public bool ValidatePreposition(string prep)
        {
            if (!OnlyLetters(prep))
            {
                Result = "Je kunt geen cijfers in je tussenvoegsel hebben!";
                return false;
            }
            return true;
        }

        public bool ValidateLastname(string lastname)
        {
            if (!OnlyLetters(lastname))
            {
                Result = "Je kunt geen cijfers in je achternaam hebben!";
                return false;
            }
            else if (String.IsNullOrEmpty(lastname))
            {
                Result = "Vul een achternaam in!";
            }
            return true;
        }

        public bool ValidateCity(string city)
        {
            if (!OnlyLetters(city))
            {
                Result = "Je kunt geen getal als stad hebben!";
                return false;
            }
            return true;
        }

        public bool ValidateYearofbirth(int year)
        {
            if (!OnlyNumbers(Convert.ToString(year)))
            {
                Result = "Je kunt geen letters als geboortejaar hebben!";
                return false;
            }
            return true;
        }

        public bool ValidateYearofdeath(int year)
        {
            if (!OnlyNumbers(Convert.ToString(year)))
            {
                Result = "Je kunt geen letters als sterftejaar hebben!";
                return false;
            }
            return true;
        }

        private bool OnlyNumbers(string text)
        {
            Regex regex = new Regex("^[0-9]+$");
            if (regex.IsMatch(text))
            {
                return true;
            }
            return false;
        }

        private bool OnlyLetters(string text)
        {
            Regex regex = new Regex(@"^[a-zA-Z]+$");
            if (regex.IsMatch(text))
            {
                return true;
            }
            return false;
        }
    }
}
