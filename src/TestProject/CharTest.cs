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
            char[] c = new char[] { 'a', 'e', 'i', 'o', 'u' }; // TODO: Initialize to an appropriate value
            bool expected = true; // TODO: Initialize to an appropriate value
            bool actual;

            foreach (char item in c)
            {
                actual = Extensions.IsVowel(item);
                Assert.AreEqual(expected, actual);
            }
        }

        /// <summary>
        ///A test for IsVowel
        ///</summary>
        [TestMethod()]
        public void IsVowelTestCaps()
        {
            char[] c = new char[] { 'A', 'E', 'I', 'O', 'U' }; // TODO: Initialize to an appropriate value
            bool expected = true; // TODO: Initialize to an appropriate value
            bool actual;

            foreach (char item in c)
            {
                actual = Extensions.IsVowel(item);
                Assert.AreEqual(expected, actual);
            }
        }

        /// <summary>
        ///A test for IsVowel
        ///</summary>
        [TestMethod()]
        public void IsVowelTestNo()
        {
            char[] c = new char[] { 'b', 'c', 'd', 'f', 'g', 'h', 'j', 'k', 'l', 'm', 'n', 'p', 'q', 'r', 's', 't', 'w', 'x', 'y', 'z' }; // TODO: Initialize to an appropriate value
            bool expected = false; // TODO: Initialize to an appropriate value
            bool actual;

            foreach (char item in c)
            {
                actual = Extensions.IsVowel(item);
                Assert.AreEqual(expected, actual);
            }
        }

        /// <summary>
        ///A test for IsVowel
        ///</summary>
        [TestMethod()]
        public void IsVowelTestCapsNo()
        {
            char[] c = new char[] { 'B', 'C', 'D', 'F', 'G', 'H', 'J', 'K', 'L', 'M', 'N', 'P', 'Q', 'R', 'S', 'T', 'W', 'X', 'Y', 'Z' }; // TODO: Initialize to an appropriate value
            bool expected = false; // TODO: Initialize to an appropriate value
            bool actual;

            foreach (char item in c)
            {
                actual = Extensions.IsVowel(item);
                Assert.AreEqual(expected, actual);
            }
        }
    }
}
