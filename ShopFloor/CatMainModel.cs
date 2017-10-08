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
    class CatMainModel : MainViewModel
    {

        public CatMainModel(string whoSent)
        {
            string _whoSent = whoSent;
            ProductList = new ObservableCollection<Product>();
            var ctx = new Context();

            foreach (var product in ctx.Products)
            {
                if (_whoSent == product.Cathegory)
                    ProductList.Add(new Product(product));
            }
        }

    }
}
