using Microsoft.VisualStudio.TestTools.UnitTesting;
using MySql.Data.MySqlClient;

namespace UnitTest
{
    [TestClass]
    public class UnitTests
    {
        #region Email
        [TestMethod]
        public void TestMethodEmailCheck0()
        {
            string email = "TestMail@gmail.com";

            bool expected = true;

            bool actual = ProgUP.classes.CheckStuff.EmailCorrect(email);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestMethodEmailCheck1()
        {
            string email = "TestMail.com";

            bool expected = false;

            bool actual = ProgUP.classes.CheckStuff.EmailCorrect(email);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestMethodEmailCheck2()
        {
            string email = "TestMail.com";

            bool expected = false;

            bool actual = ProgUP.classes.CheckStuff.EmailCorrect(email);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestMethodEmailCheck3()
        {
            string email = "TestMail@email";

            bool expected = false;

            bool actual = ProgUP.classes.CheckStuff.EmailCorrect(email);

            Assert.AreEqual(expected, actual);
        }
        #endregion
    }
}