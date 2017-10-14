using Microsoft.VisualStudio.TestTools.UnitTesting;
using ShopFloor;

namespace UnitTest
{
    [TestClass]
    public class CartTest
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
        public void Purchase_noProduct()
        {
            var cartVM = new CartViewModel();
            Assert.IsFalse(cartVM.Purchase());
        }

        [TestMethod]
        public void Purchase_Product_Valid()
        {
            var cartVM = new CartViewModel();
            cartVM.UserCart = new User
            {
                Username = "Feri",
                Password = "Feri",
                Cash = 10000,
                Admin = false
            };
            cartVM.PurchasedProducts.Add(product);
            Assert.IsTrue(cartVM.Purchase());
        }

        [TestMethod]
        public void DeleteCart_True()
        {
            var cartVM = new CartViewModel();
            cartVM.PurchasedProducts.Add(product);
            cartVM.ClearCart();
            Assert.AreEqual(0, cartVM.PurchasedProducts.Count);
        }

        [TestMethod]
        public void AddToCart_True()
        {
            var cartVM = new CartViewModel();
            cartVM.PurchasedProducts.Add(product);
            Assert.AreEqual(1, cartVM.PurchasedProducts.Count);
        }

    }
}
