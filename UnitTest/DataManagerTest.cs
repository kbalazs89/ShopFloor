using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ShopFloor.dal;

namespace UnitTest
{
    [TestClass]
    public class DataManagerTest
    {
        static Random R = new Random();

        /// <summary>
        /// LinQ miatt nem megy
        /// </summary>
        [TestMethod]
        public void GetUserTest_With_User()
        {
            var manager = new DataManager();
            var userDBM = manager.GetUser("kutya", "malac");
            Assert.IsNotNull(userDBM);
        }

        [TestMethod]
        public void AddProduct_Already_exist()
        {
            var manager = new DataManager();
            bool result = manager.AddProduct("Jani", 20, 20, "AIRBUS", 30, 3000, 3);
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void AddProduct_New()
        {
            string name = R.Next(0, 10000000).ToString();
            var manager = new DataManager();
            bool result = manager.AddProduct(name, 20, 20, "AIRBUS", 30, 3000, 3);
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void Purchase_Valid()
        {
            var manager = new DataManager();
            bool result = manager.BuyProduct("Jani", 1, "Feri");
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void Purchase_NotEnoughCash()
        {
            var manager = new DataManager();
            bool result = manager.BuyProduct("Jani", 2000, "Feri");
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void Regist()
        {
            var manager = new DataManager();
            string username = R.Next(0, 100000).ToString();
            manager.Regist(username, "Feri");
        }
    }
}
