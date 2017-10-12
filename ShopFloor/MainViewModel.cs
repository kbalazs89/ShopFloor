using ShopFloor.dal;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopFloor
{
   public class MainViewModel : BaseModel
    {
       // public ObservableCollection<Product> ProductList { get; set; }
        //public IEnumerable<ProductDBModel> ProductList { get; set; }

        public Product SelectProduct { get; set; }
        public User User { get; set; }
        


        public MainViewModel()
        {
            /*ProductList = new ObservableCollection<Product>();
            var ctx = new Context();
            foreach (var product in ctx.Products)
            {
                ProductList.Add(new Product(product));
            }*/
            //var manager = new DataManager();
          
        }


    }
}
