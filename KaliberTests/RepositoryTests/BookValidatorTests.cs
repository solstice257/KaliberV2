using Kaliber.Validator;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace KaliberTests.RepositoryTests
{
    [TestClass]
    public class BookValidatorTests
    {
        BookValidator bookValidator;
        string TestResult;

        [TestInitialize]
        public void TestInitialize()
        {
            TestResult = null;
            bookValidator = new BookValidator();
        }

        [TestMethod]
        public void ValidateISBNEmpty()
        {
            TestResult = "Er is geen geldig ISBN ingevuld!";
            long ISBN = 0; // null wordt omgezet naar 0
            bookValidator.ValidateISBN(ISBN);
            Assert.AreEqual(TestResult, bookValidator.Result);
        }

        [TestMethod]
        public void ValidateISBNTooShort()
        {
            TestResult = "Er is geen geldig ISBN ingevuld!";
            long ISBN = 123456789011; // 12 cijfers
            bookValidator.ValidateISBN(ISBN);
            Assert.AreEqual(TestResult, bookValidator.Result);
        }

        [TestMethod]
        public void ValidateISBNTooLong()
        {
            TestResult = "Er is geen geldig ISBN ingevuld!";
            long ISBN = 12345678901112; // 14 cijfers
            bookValidator.ValidateISBN(ISBN);
            Assert.AreEqual(TestResult, bookValidator.Result);
        }

        [TestMethod]
        public void ValidateISBNSucces()
        {
            long ISBN = 1234567890111; // 13 cijfers
            bookValidator.ValidateISBN(ISBN);
            Assert.AreEqual(TestResult, bookValidator.Result);
        }

        [TestMethod]
        public void ValidateTitleEmpty()
        {
            TestResult = "Een boek moet een titel hebben!";
            string title = "";
            bookValidator.ValidateTitle(title);
            Assert.AreEqual(TestResult, bookValidator.Result);
        }

        [TestMethod]
        public void ValidateTitleLetters()
        {
            string title = "De wereld zoals hij is"; // alleen letters
            bookValidator.ValidateTitle(title);
            Assert.AreEqual(TestResult, bookValidator.Result);
        }

        [TestMethod]
        public void ValidateTitleNumbersAndLetters()
        {
            string title = "13 jaar samen"; // met cijfers
            bookValidator.ValidateTitle(title);
            Assert.AreEqual(TestResult, bookValidator.Result);
        }

        [TestMethod]
        public void ValidateAuthorEmpty()
        {
            TestResult = "Een boek moet een auteur hebben!";
            string firstname = "";
            bookValidator.ValidateAuthor(firstname);
            Assert.AreEqual(TestResult, bookValidator.Result);
        }

        [TestMethod]
        public void ValidateAuthorNumbers()
        {
            TestResult = "Je kunt geen cijfers in je naam hebben!";
            string firstname = "1234";
            bookValidator.ValidateAuthor(firstname);
            Assert.AreEqual(TestResult, bookValidator.Result);
        }

        [TestMethod]
        public void ValidateAuthorNumbersAndLetters()
        {
            TestResult = "Je kunt geen cijfers in je naam hebben!";
            string firstname = "1234abcd";
            bookValidator.ValidateAuthor(firstname);
            Assert.AreEqual(TestResult, bookValidator.Result);
        }

        [TestMethod]
        public void ValidateAuthorLetters()
        {
            string firstname = "abcd";
            bookValidator.ValidateAuthor(firstname);
            Assert.AreEqual(TestResult, bookValidator.Result);
        }

        [TestMethod]
        public void ValidateCategoryEmpty()
        {
            TestResult = "Een boek moet een category hebben!";
            string Category = ""; 
            bookValidator.ValidateCategory(Category);
            Assert.AreEqual(TestResult, bookValidator.Result);
        }

        [TestMethod]
        public void ValidateCategoryNumbers()
        {
            TestResult = "Je kunt geen cijfers in je categorie hebben!";
            string Category = "1234";
            bookValidator.ValidateCategory(Category);
            Assert.AreEqual(TestResult, bookValidator.Result);
        }

        [TestMethod]
        public void ValidateCategoryNumbersAndLetters()
        {
            TestResult = "Je kunt geen cijfers in je categorie hebben!";
            string Category = "1234ABCD";
            bookValidator.ValidateCategory(Category);
            Assert.AreEqual(TestResult, bookValidator.Result);
        }

        [TestMethod]
        public void ValidateCategorySucces()
        {
            string Category = "Thriller";
            bookValidator.ValidateCategory(Category);
            Assert.AreEqual(TestResult, bookValidator.Result);
        }

        [TestMethod]
        public void ValidateYearEmpty()
        {
            string year = "";
            bookValidator.ValidateYear(year);
            Assert.AreEqual(TestResult, bookValidator.Result);
        }

        [TestMethod]
        public void ValidateYearLetters()
        {
            TestResult = "Je kunt geen letters in een jaartal zetten!";
            string year = "abcd";
            bookValidator.ValidateYear(year);
            Assert.AreEqual(TestResult, bookValidator.Result);
        }

        [TestMethod]
        public void ValidateYearLettersAndNumbers()
        {
            TestResult = "Je kunt geen letters in een jaartal zetten!";
            string year = "1234abcd";
            bookValidator.ValidateYear(year);
            Assert.AreEqual(TestResult, bookValidator.Result);
        }

        [TestMethod]
        public void ValidateYearSucces()
        {
            string year = "1902";
            bookValidator.ValidateYear(year);
            Assert.AreEqual(TestResult, bookValidator.Result);
        }

        [TestMethod]
        public void OnlylettersSucces()
        {
            string text = "abcd";
            Assert.IsTrue(bookValidator.OnlyLetters(text));
        }

        [TestMethod]
        public void OnlylettersFailed()
        {
            string text = "1234";
            Assert.IsFalse(bookValidator.OnlyLetters(text));
        }

        [TestMethod]
        public void OnlylettersFailed2()
        {
            string text = "1234abcd";
            Assert.IsFalse(bookValidator.OnlyLetters(text));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException),
        "Invalid use of stub code. First set field existsReturnValue.")]
        public void OnlylettersNull()
        {
            string text = null;
            Assert.IsFalse(bookValidator.OnlyLetters(text));
        }

        [TestMethod]
        public void OnlyNumbersSucces()
        {
            string text = "1234";
            Assert.IsTrue(bookValidator.OnlyNumbers(text));
        }

        [TestMethod]
        public void OnlyNumbersFailed()
        {
            string text = "abcd";
            Assert.IsFalse(bookValidator.OnlyNumbers(text));
        }

        [TestMethod]
        public void OnlyNumbersFailed2()
        {
            string text = "1234abcd";
            Assert.IsFalse(bookValidator.OnlyNumbers(text));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException),
        "Invalid use of stub code. First set field existsReturnValue.")]
        public void OnlyNumbersNull()
        {
            string text = null;
            Assert.IsFalse(bookValidator.OnlyNumbers(text));
        }

    }
}
