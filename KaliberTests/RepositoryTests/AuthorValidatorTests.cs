using BusinessLibrary.Models;
using Kaliber.Validator;
using Microsoft.AspNetCore.Authentication;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace KaliberTests.RepositoryTests
{
    [TestClass]
    public class AuthorValidatorTests
    {
        AuthorValidator authorValidator;
        string TestResult;

        [TestInitialize]
        public void TestInitialize()
        {
            TestResult = null;
            authorValidator = new AuthorValidator();
        }

        [TestMethod]
        public void ValidateFirstnameEmpty()
        {
            TestResult = "Vul een voornaam in!";
            string firstname = "";
            authorValidator.ValidateFirstname(firstname);
            Assert.AreEqual(TestResult, authorValidator.Result);
        }

        [TestMethod]
        public void ValidateFirstnameNumbers()
        {
            TestResult = "Je kunt geen cijfers in je voornaam hebben!";
            string firstname = "1234";
            authorValidator.ValidateFirstname(firstname);
            Assert.AreEqual(TestResult, authorValidator.Result);
        }

        [TestMethod]
        public void ValidateFirstnameNumbersAndLetters()
        {
            TestResult = "Je kunt geen cijfers in je voornaam hebben!";
            string firstname = "1234abcd";
            authorValidator.ValidateFirstname(firstname);
            Assert.AreEqual(TestResult, authorValidator.Result);
        }

        [TestMethod]
        public void ValidateFirstnameLetters()
        { 
            string firstname = "hans";
            authorValidator.ValidateFirstname(firstname);
            Assert.AreEqual(TestResult, authorValidator.Result);
        }

        [TestMethod]
        public void ValidatePrepositionNumbers()
        {
            TestResult = "Je kunt geen cijfers in je tussenvoegsel hebben!";
            string prep = "1234";
            authorValidator.ValidatePreposition(prep);
            Assert.AreEqual(TestResult, authorValidator.Result);
        }

        [TestMethod]
        public void ValidatePrepositionNumbersAndLetters()
        {
            TestResult = "Je kunt geen cijfers in je tussenvoegsel hebben!";
            string prep = "1234abcd";
            authorValidator.ValidatePreposition(prep);
            Assert.AreEqual(TestResult, authorValidator.Result);
        }

        [TestMethod]
        public void ValidatePrepositionLetters()
        {
            string prep = "van";
            authorValidator.ValidatePreposition(prep);
            Assert.AreEqual(TestResult, authorValidator.Result);
        }

        [TestMethod]
        public void ValidatePrepositionEmpty()
        {
            string prep = "";
            authorValidator.ValidatePreposition(prep);
            Assert.AreEqual(TestResult, authorValidator.Result);
        }

        [TestMethod]
        public void ValidateLastnameNumbers()
        {
            TestResult = "Je kunt geen cijfers in je achternaam hebben!";
            string lastname = "1234";
            authorValidator.ValidateLastname(lastname);
            Assert.AreEqual(TestResult, authorValidator.Result);
        }

        [TestMethod]
        public void ValidateLastnameNumbersAndLetters()
        {
            TestResult = "Je kunt geen cijfers in je achternaam hebben!";
            string lastname = "1234abcd";
            authorValidator.ValidateLastname(lastname);
            Assert.AreEqual(TestResult, authorValidator.Result);
        }

        [TestMethod]
        public void ValidateLastnameLetters()
        {
            string lastname = "Hannes";
            authorValidator.ValidateLastname(lastname);
            Assert.AreEqual(TestResult, authorValidator.Result);
        }

        [TestMethod]
        public void ValidateLastnameEmpty()
        {
            string lastname = "";
            authorValidator.ValidateLastname(lastname);
            Assert.AreEqual(TestResult, authorValidator.Result);
        }

        [TestMethod]
        public void ValidateCityNumbers()
        {
            TestResult = "Je kunt geen getal als stad hebben!";
            string city = "1234";
            authorValidator.ValidateCity(city);
            Assert.AreEqual(TestResult, authorValidator.Result);
        }

        [TestMethod]
        public void ValidateCityNumbersAndLetters()
        {
            TestResult = "Je kunt geen getal als stad hebben!";
            string city = "1234abcd";
            authorValidator.ValidateCity(city);
            Assert.AreEqual(TestResult, authorValidator.Result);
        }

        [TestMethod]
        public void ValidateCityLetters()
        {
            string city = "Tilburg";
            authorValidator.ValidateCity(city);
            Assert.AreEqual(TestResult, authorValidator.Result);
        }

        [TestMethod]
        public void ValidateCityEmpty()
        {
            string city = "";
            authorValidator.ValidateCity(city);
            Assert.AreEqual(TestResult, authorValidator.Result);
        }

        [TestMethod]
        public void ValidateYearofbirthLetters()
        {
            TestResult = "Je kunt geen letters bij het geboortejaar invullen";
            string year = "abcd"; 
            authorValidator.ValidateYearofbirth(year);
            Assert.AreEqual(TestResult, authorValidator.Result);
        }

        [TestMethod]
        public void ValidateYearofbirthLettersAndNumbers()
        {
            TestResult = "Je kunt geen letters bij het geboortejaar invullen";
            string year = "1234abcd";
            authorValidator.ValidateYearofbirth(year);
            Assert.AreEqual(TestResult, authorValidator.Result);
        }

        [TestMethod]
        public void ValidateYearofbirthNumbers()
        {
            string year = "1234";
            authorValidator.ValidateYearofbirth(year);
            Assert.AreEqual(TestResult, authorValidator.Result);
        }

        [TestMethod]
        public void ValidateYearofbirthEmpty()
        {
            string year = ""; 
            authorValidator.ValidateYearofbirth(year);
            Assert.AreEqual(TestResult, authorValidator.Result);
        }

        [TestMethod]
        public void ValidateYearofdeathLetters()
        {
            TestResult = "Je kunt geen letters bij het sterftejaar invullen";
            string year = "abcd";
            authorValidator.ValidateYearofdeath(year);
            Assert.AreEqual(TestResult, authorValidator.Result);
        }

        [TestMethod]
        public void ValidateYearofdeathLettersAndNumbers()
        {
            TestResult = "Je kunt geen letters bij het sterftejaar invullen";
            string year = "abcd1234";
            authorValidator.ValidateYearofdeath(year);
            Assert.AreEqual(TestResult, authorValidator.Result);
        }

        [TestMethod]
        public void ValidateYearofdeathNumbers()
        {
            string year = "1234";
            authorValidator.ValidateYearofdeath(year);
            Assert.AreEqual(TestResult, authorValidator.Result);
        }

        [TestMethod]
        public void ValidateYearofdeathEmpty()
        {
            string year = "";
            authorValidator.ValidateYearofdeath(year);
            Assert.AreEqual(TestResult, authorValidator.Result);
        }
    }
}
