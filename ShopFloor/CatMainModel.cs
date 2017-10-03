using ShopFloor.dal;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace ShopFloor
{
    class CatMainModel : BaseModel
    {
        public ObservableCollection<Product> ProductList { get; set; }
        public Product SelectProduct { get; set; }
        public User User { get; set; }


        public CatMainModel(string whoSent)
        {
            string _whoSent = whoSent;
            ProductList = new ObservableCollection<Product>();
            var ctx = new Context();
            foreach (var product in ctx.Products)
            {
                if(_whoSent == product.Cathegory)
                ProductList.Add(new Product(product));
            }
        }
    }
}
