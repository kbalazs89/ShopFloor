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
    public class CatMainModel : MainViewModel
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
}
}
