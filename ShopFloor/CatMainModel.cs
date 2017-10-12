using ShopFloor.dal;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace ShopFloor
{
    public class CatMainModel : BaseModel
    {

        /* public CatMainModel(string whoSent)
         {
             var manager = new DataManager();
             string _whoSent = whoSent;
             ProductList = new ObservableCollection<Product>();
             var ctx = new Context();

             foreach (var product in ctx.Products)
             {
                 if (_whoSent == product.Cathegory)
                     ProductList.Add(new Product(product));
             }
         }*/

        public ObservableCollection<Product> ProductList { get; set; }
        //public ObservableCollection<Product> PurchasedProducts { get; set; } = new ObservableCollection<Product>();
        public Product SelectProduct { get; set; }
        public User UserInCat = StaticClass.LoggedUser;

        public CatMainModel(string whoSent)
        {
            ProductList = new ObservableCollection<Product>();
            var manager = new DataManager();
            foreach (var product in manager.GetProducts(whoSent))
            {
                if (whoSent == product.Cathegory)
                    ProductList.Add(new Product(product));
            }
        }

        public CatMainModel()
        { }


        public string AddToCart(Product selectedProduct)
        {
           
            if (selectedProduct.Quantity == 0)
                return "Not enough stock";
            var product = FindProduct(SelectProduct.Name);
            if(product == null)
            StaticClass.PurchasedProducts.Add(new Product
            {
                Name = selectedProduct.Name,
                Price = selectedProduct.Price,
                Quantity = 1,
                Cathegory = selectedProduct.Cathegory,
                NrOfSeats = selectedProduct.NrOfSeats,
                FlightRange = selectedProduct.FlightRange,
                NrOfEngines = selectedProduct.NrOfEngines
            });
            else
            {
                product.Quantity++;
            }
            foreach (var prod in ProductList)
            {
                if (selectedProduct.Name == prod.Name && selectedProduct.Price == prod.Price)
                    selectedProduct.Quantity--;
            }
            return null;

        }

        Product FindProduct(string name)
        {
            foreach (var product in StaticClass.PurchasedProducts)
                if (product.Name == name)
                    return product;
            return null;
        }

        public void DeleteProduct(Product selectedProduct)
        {
            var manager = new DataManager();
            manager.DeleteProduct(selectedProduct.Name, selectedProduct.Price, selectedProduct.NrOfSeats);
        }
    }
}
