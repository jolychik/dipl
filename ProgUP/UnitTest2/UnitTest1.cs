using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTest2
{
    [TestClass]
    public class UnitTest1
    {
        #region SQL
        [TestMethod]
        public void TestMethodAuth()
        {
            string login = "UnitTestEnter";
            string password = "UnitTestEnter";

            ProgUP.classes.MySQLconnect.BDConnect();

            ProgUP.classes.Autorisation.Autoriz(login, password);
            string actual = ProgUP.classes.Autorisation.user;

            ProgUP.classes.MySQLconnect.closeBD();

            Assert.AreEqual(null, actual);
        }

        [TestMethod]
        public void TestMethodAuth1()
        {
            string login = "owner1";
            string password = "qwerty";

            ProgUP.classes.MySQLconnect.BDConnect();

            ProgUP.classes.Autorisation.Autoriz(login, password);
            string actual = ProgUP.classes.Autorisation.role;

            ProgUP.classes.MySQLconnect.closeBD();

            Assert.AreEqual("owner", actual);
        }

        [TestMethod]
        public void TestMethodAuth2()
        {
            string login = "owner1";
            string password = "";

            ProgUP.classes.MySQLconnect.BDConnect();

            ProgUP.classes.Autorisation.Autoriz(login, password);
            string actual = ProgUP.classes.Autorisation.role;

            ProgUP.classes.MySQLconnect.closeBD();

            Assert.AreEqual(null, actual);
        }

        [TestMethod]
        public void AddTable()
        {
            ProgUP.classes.MySQLconnect.BDConnect();

            bool actual = ProgUP.classes.AddTable.AddInpector("Тест", "Тестовый адрес", "8800553535", "2021-01-01");

            ProgUP.classes.MySQLconnect.closeBD();

            Assert.AreEqual(true, actual);
        }

        [TestMethod]
        public void AddTable2()
        {
            ProgUP.classes.MySQLconnect.BDConnect();

            bool actual = ProgUP.classes.AddTable.AddFine("11111", "Описание", "Адм.", "Да", "Нет", "1 год");

            ProgUP.classes.MySQLconnect.closeBD();

            Assert.AreEqual(true, actual);
        }

        [TestMethod]
        public void DeleteTable()
        {
            ProgUP.classes.MySQLconnect.BDConnect();

            bool actual = ProgUP.classes.DeleteTable.FineDelete("11111");

            ProgUP.classes.MySQLconnect.closeBD();

            Assert.AreEqual(true, actual);
        }
        #endregion

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
