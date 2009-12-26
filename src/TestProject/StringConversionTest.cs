using Helpers.Net.Extensions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace TestProject
{


    /// <summary>
    ///This is a test class for StringConversionTest and is intended
    ///to contain all StringConversionTest Unit Tests
    ///</summary>
    [TestClass()]
    public class StringConversionTest
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
        ///A test for ToDecimal
        ///</summary>
        [TestMethod()]
        public void ToDecimalTest()
        {
            string s = "1.0";
            decimal expected = 1.0M;
            decimal actual = s.ToDecimal();
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        ///A test for ToChar
        ///</summary>
        [TestMethod()]
        public void ToCharTest()
        {
            string s = "a";
            char expected = 'a';
            decimal actual = s.ToChar();
            Assert.AreEqual(expected, actual);
        }
    }
}
