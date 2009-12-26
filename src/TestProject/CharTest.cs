using Helpers.Net.Extensions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace TestProject
{


    /// <summary>
    ///This is a test class for CharTest and is intended
    ///to contain all CharTest Unit Tests
    ///</summary>
    [TestClass()]
    public class CharTest
    {

        private char[] consonants = new char[] { 'b', 'c', 'd', 'f', 'g', 'h', 'j', 'k', 'l', 'm', 'n', 'p', 'q', 'r', 's', 't', 'w', 'x', 'y', 'z' };
        private char[] consonantsCaps = new char[] { 'B', 'C', 'D', 'F', 'G', 'H', 'J', 'K', 'L', 'M', 'N', 'P', 'Q', 'R', 'S', 'T', 'W', 'X', 'Y', 'Z' };
        private char[] vowels = new char[] { 'a', 'e', 'i', 'o', 'u' };
        private char[] vowelsCaps = new char[] { 'A', 'E', 'I', 'O', 'U' };

        private TestContext testContextInstance;

        /// <summary>
        ///Gets or sets the test context which provides
        ///information about and functionality for the current test run.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }

        #region Additional test attributes
        // 
        //You can use the following additional attributes as you write your tests:
        //
        //Use ClassInitialize to run code before running the first test in the class
        //[ClassInitialize()]
        //public static void MyClassInitialize(TestContext testContext)
        //{
        //}
        //
        //Use ClassCleanup to run code after all tests in a class have run
        //[ClassCleanup()]
        //public static void MyClassCleanup()
        //{
        //}
        //
        //Use TestInitialize to run code before running each test
        //[TestInitialize()]
        //public void MyTestInitialize()
        //{
        //}
        //
        //Use TestCleanup to run code after each test has run
        //[TestCleanup()]
        //public void MyTestCleanup()
        //{
        //}
        //
        #endregion


        /// <summary>
        ///A test for IsVowel
        ///</summary>
        [TestMethod()]
        public void IsVowelTest()
        {
            bool expected = true;
            bool actual;

            foreach (char item in vowels)
            {
                actual = item.IsVowel();
                Assert.AreEqual(expected, actual);
            }
        }

        /// <summary>
        ///A test for IsVowel
        ///</summary>
        [TestMethod()]
        public void IsVowelTestCaps()
        {
            bool expected = true;
            bool actual;

            foreach (char item in vowelsCaps)
            {
                actual = item.IsVowel();
                Assert.AreEqual(expected, actual);
            }
        }

        /// <summary>
        ///A test for IsVowel
        ///</summary>
        [TestMethod()]
        public void IsVowelTestNo()
        {
            
            bool expected = false;
            bool actual;

            foreach (char item in consonants)
            {
                actual = item.IsVowel();
                Assert.AreEqual(expected, actual);
            }
        }

        /// <summary>
        ///A test for IsVowel
        ///</summary>
        [TestMethod()]
        public void IsVowelTestCapsNo()
        {
            bool expected = false;
            bool actual;

            foreach (char item in consonantsCaps)
            {
                actual = item.IsVowel();
                Assert.AreEqual(expected, actual);
            }
        }

        /// <summary>
        ///A test for IsConsonant
        ///</summary>
        [TestMethod()]
        public void IsConsonantTest()
        {

            bool expected = true;
            bool actual;

            foreach (char item in consonants)
            {
                actual = item.IsConsonant();
                Assert.AreEqual(expected, actual);
            }
        }

        /// <summary>
        ///A test for IsConsonant
        ///</summary>
        [TestMethod()]
        public void IsConsonantTestCaps()
        {
            bool expected = true;
            bool actual;

            foreach (char item in consonants)
            {
                actual = item.IsConsonant();
                Assert.AreEqual(expected, actual);
            }
        }

        /// <summary>
        ///A test for IsConsonant
        ///</summary>
        [TestMethod()]
        public void IsConsonantTestNo()
        {

            bool expected = false;
            bool actual;

            foreach (char item in vowels)
            {
                actual = item.IsConsonant();
                Assert.AreEqual(expected, actual);
            }
        }

        /// <summary>
        ///A test for IsConsonant
        ///</summary>
        [TestMethod()]
        public void IsConsonantTestCapsNo()
        {
            bool expected = false;
            bool actual;

            foreach (char item in vowelsCaps)
            {
                actual = item.IsConsonant();
                Assert.AreEqual(expected, actual);
            }
        }
    }
}
