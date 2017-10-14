using ShopFloor.dal;
using System.Collections.ObjectModel;

namespace ShopFloor
{
    public class CartViewModel : BaseModel
    {
        
        public ObservableCollection<Product> PurchasedProducts { get; set; } = StaticClass.PurchasedProducts;
        public User UserCart = StaticClass.LoggedUser;
        public int CartPrice { get; set; }

        /// <summary>
        /// Constructor, calculates the cart's current value
        /// </summary>
        public CartViewModel()
        {
            CartPrice = 0;
            foreach (var product in PurchasedProducts)
            {
                CartPrice += product.Price * product.Quantity;
            }
        }
        
        public CartViewModel(string alter)
        {
        }

        /// <summary>
        /// Empty Productlist and call DataManager's purchase-method
        /// </summary>
        public bool Purchase()
        {
            var manager = new DataManager();
            if (PurchasedProducts.Count > 0)
            {
                foreach (var product in PurchasedProducts)
                {
                    if (manager.BuyProduct(product.Name, product.Quantity, UserCart.Username))
                        UserCart.Cash -= manager.SumPrice;
                    else
                        return false;
                }

                PurchasedProducts = new ObservableCollection<Product>();
                StaticClass.PurchasedProducts = new ObservableCollection<Product>();
                return true;
            }
            return false;
        }

        /// <summary>
        /// ClearCart
        /// </summary>
        public void ClearCart()
        {
            PurchasedProducts.Clear();
        }
    }
}
