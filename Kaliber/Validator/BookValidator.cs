using Kaliber.Models;
using Microsoft.VisualStudio.Web.CodeGenerators.Mvc;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Kaliber.Validator
{
    public class BookValidator
    {
        public string Result { get; private set; }

        public bool ValidateISBN(long ISBN)
        {
            if (ISBN.ToString().Length != 13)
            {
                Result = "Er is geen geldig ISBN ingevuld!";
                return false;
            }
            return true;
        }

        public bool ValidateTitle(string title)
        {
            if (String.IsNullOrEmpty(title))
            {
                Result = "Een boek moet een titel hebben!";
                return false;
            }
            return true;
        }

        public bool ValidateAuthor(string firstname)
        {
            if (String.IsNullOrEmpty(firstname))
            {
                Result = "Een boek moet een auteur hebben!";
                return false;
            }
            else if (!OnlyLetters(firstname))
            {
                Result = "Je kunt geen cijfers in je naam hebben!";
                return false;
            }
            return true;
        }

        public bool ValidateCategory(string category)
        {
            if (String.IsNullOrEmpty(category))
            {
                Result = "Een boek moet een category hebben!";
                return false;
            }
            else if(!OnlyLetters(category))
            {
                Result = "Je kunt geen cijfers in je categorie hebben!";
                return false;
            }
            return true;
        }

        public bool ValidateYear(string year)
        {
            if (String.IsNullOrEmpty(year))
            {
                return true;
            }
            if (!OnlyNumbers(year))
            {
                Result = "Je kunt geen letters in een jaartal zetten!";
                return false;
            }
            return true;
        }

        public bool OnlyLetters(string text)
        {
            Regex regex = new Regex(@"^[a-zA-Z]+$");
            if (regex.IsMatch(text))
            {
                return true;
            }
            return false;
        }

        public bool OnlyNumbers(string text)
        {
            Regex regex = new Regex("^[0-9]+$");
            if (regex.IsMatch(text))
            {
                return true;
            }
            return false;
        }
    }
}
