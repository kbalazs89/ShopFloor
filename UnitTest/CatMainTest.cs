using Microsoft.VisualStudio.TestTools.UnitTesting;
using ShopFloor;

namespace UnitTest
{

    [TestClass]
    public class CatMainTest
    {
        Product product = new Product
        {
            Name = "NagyGep",
            Price = 20,
            Quantity = 20,
            Cathegory = "AIRBUS",
            NrOfSeats = 30,
            FlightRange = 3000,
            NrOfEngines = 3
        };

        [TestMethod]
        public void AddToCart_Pass()
        {
            var catMain = new CatMainModel("AIRBUS");
            Assert.IsNull(catMain.AddToCart(product));
        }

        [TestMethod]
        public void AddToCart_No_Choice()
        {
            var catMain = new CatMainModel("AIRBUS");
            Product prod = null;
            string test = catMain.AddToCart(prod);
            Assert.AreEqual(test, "Please select a product first");
        }

        [TestMethod]
        public void AddToCart_No_Stock()
        {
            product.Quantity = 0;
            var catMain = new CatMainModel("AIRBUS");
            string test = catMain.AddToCart(product);
            Assert.AreEqual(test, "Not enough stock");
        }

        [TestMethod]
        public void Delete_No_Choice()
        {
            var catMain = new CatMainModel("AIRBUS");
            Product prod = null;
            string test = catMain.DeleteProduct(prod);
            Assert.AreEqual(test, "Please select a product first");
        }

        [TestMethod]
        public void Delete_Product_Pass()
        {
            var catMain = new CatMainModel("AIRBUS");
            Assert.IsNull(catMain.DeleteProduct(product));
        }

    }
}
