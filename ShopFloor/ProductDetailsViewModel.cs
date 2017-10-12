using ShopFloor.dal;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopFloor
{
    public class ProductDetailsViewModel
    {
        public Product SelectedProduct { get; set; }

        public ProductDetailsViewModel(string whoSent)
        {
            var manager = new DataManager();
            foreach (var product in manager.GetProducts(whoSent))
            {
                if (whoSent == product.Name)
                    SelectedProduct = new Product(product);
            }
        }


    }
}
