using ShopFloor.dal;
using System.Collections.ObjectModel;

namespace ShopFloor
{
    public class CatMainModel : BaseModel
    {
        public ObservableCollection<Product> ProductList { get; set; }
        public Product SelectProduct { get; set; }
        public User UserInCat = StaticClass.LoggedUser;

        /// <summary>
        /// Constructor, called from Main Window code-behind. List the products with Datamanager's GetProduct method and filter them
        /// </summary>
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
        /// <summary>
        /// Add product to productlist and call DataManager to insert new record to DB. Validation: item must be selected and stock must be > 0
        /// </summary>
        public string AddToCart(Product selectedProduct)
        {
            if (selectedProduct == null)
                return "Please select a product first";
            if (selectedProduct.Quantity <= 0)
                return "Not enough stock";
            var product = FindProduct(selectedProduct.Name);
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

        /// <summary>
        /// Check if the product is already in the cart. AddToCart method use it
        /// </summary>
        Product FindProduct(string name)
        {
            foreach (var product in StaticClass.PurchasedProducts)
                if (product.Name == name)
                    return product;
            return null;
        }

        /// <summary>
        /// Delete product from list and call DataManager to delete record from database
        /// </summary>
        public string DeleteProduct(Product selectedProduct)
        {
            if (selectedProduct == null)
                return "Please select a product first";
            var manager = new DataManager();
            manager.DeleteProduct(selectedProduct.Name);
            ProductList.Remove(SelectProduct);
            return null;
        }

    }
}
