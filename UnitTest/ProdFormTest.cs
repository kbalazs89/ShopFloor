using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ShopFloor;

namespace UnitTest
{
    [TestClass]
    public class ProdFormTest
    {
        static Random R = new Random();

        [TestMethod]
        public void AddProductTest_new()
        {
            Product product = new Product
            {
                Name = R.Next(0, 10000000).ToString(),
                Price = 20,
                Quantity = 20,
                Cathegory = "AIRBUS",
                NrOfSeats = 30,
                FlightRange = 3000,
                NrOfEngines = 3
            };
            var productForm = new ProductFormViewModel(product);
            productForm.Product = product;
            bool added = productForm.AddProduct();
            Assert.IsTrue(added);
        }

        [TestMethod]
        public void AddProductTest_Already_exist()
        {
            Product product = new Product
            {
                Name = "Jani",
                Price = 20,
                Quantity = 20,
                Cathegory = "AIRBUS",
                NrOfSeats = 30,
                FlightRange = 3000,
                NrOfEngines = 3
            };
            var productForm = new ProductFormViewModel(product);
            productForm.Product = product;
            bool added = productForm.AddProduct();
            Assert.IsFalse(added);

        }

        [TestMethod]
        public void AddProductTest_Cat_Null()
        {
            Product product = new Product
            {
                Name = "NagyGep",
                Price = 20,
                Quantity = 20,
                Cathegory = "",
                NrOfSeats = 30,
                FlightRange = 3000,
                NrOfEngines = 3
            };
            var productForm = new ProductFormViewModel(product);
            productForm.Product = product;
            bool added = productForm.AddProduct();
            Assert.IsFalse(added);
        }

        [TestMethod]
        public void ModifyProduct_HigherQuantity()
        {
            Product product = new Product
            {
                Name = "Jani",
                Price = 20,
                Quantity = 20000,
                Cathegory = "AIRBUS",
                NrOfSeats = 30,
                FlightRange = 3000,
                NrOfEngines = 3
            };

            var productFrom = new ProductFormViewModel(product);
            productFrom.ModifyProduct(product);
            Assert.IsTrue(productFrom.Error);
        }

        [TestMethod]
        public void ModifyProduct_Valid()
        {
            Product product = new Product
            {
                Name = "Jani",
                Price = 20,
                Quantity = 200,
                Cathegory = "AIRBUS",
                NrOfSeats = 30,
                FlightRange = 3000,
                NrOfEngines = 3
            };

            var productFrom = new ProductFormViewModel(product);
            productFrom.ModifyProduct(product);
            Assert.IsFalse(productFrom.Error);

        }

        [TestMethod]
        public void Validate_TooExpensive()
        {
            Product product = new Product
            {
                Name = "Jani",
                Price = 20000,
                Quantity = 200,
                Cathegory = "AIRBUS",
                NrOfSeats = 30,
                FlightRange = 3000,
                NrOfEngines = 3
            };
            var productFrom = new ProductFormViewModel(product);
            bool result = productFrom.ProductValidate();
            Assert.IsFalse(result);
        }
    }
}
