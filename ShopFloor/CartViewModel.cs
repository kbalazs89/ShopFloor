using ShopFloor.dal;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopFloor
{
    public class CartViewModel : BaseModel
    {
        
        public ObservableCollection<Product> PurchasedProducts { get; set; } = StaticClass.PurchasedProducts;
        public User UserCart = StaticClass.LoggedUser;

        public void Purchase()
        {
            var manager = new DataManager();
            foreach (var product in PurchasedProducts)
            {
                manager.BuyProduct(product.Name, product.Price, product.Quantity, product.NrOfSeats, product.FlightRange, UserCart.Username);
            }

            PurchasedProducts = new ObservableCollection<Product>();
            StaticClass.PurchasedProducts = new ObservableCollection<Product>();
        }


    }
}
