using ShopFloor.dal;

namespace ShopFloor
{
    public class ProductDetailsViewModel
    {
       public Product SelectedProduct { get; set; }

        /// <summary>
        /// Constructor, selected product name loaded
        /// </summary>
        public ProductDetailsViewModel(string whoSent)
        {
            var manager = new DataManager();
            foreach (var product in manager.GetProducts())
            {
                if (whoSent == product.Name)
                    SelectedProduct = new Product(product);
            }
        }
    }
}
