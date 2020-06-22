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
            Regex regex = new Regex("^[0-9]+$");
            if (String.IsNullOrEmpty(ISBN.ToString()))
            {
                Result = "Vul eerst een ISBN in!";
            }
            else if (ISBN.ToString().Length != 13)
            {
                Result = "Dit is geen geldig ISBN! ";
                return false;
            }
            else if (!OnlyNumbers(ISBN.ToString()))
            {
                Result = "Je kunt geen letters in je ISBN hebben!";
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
