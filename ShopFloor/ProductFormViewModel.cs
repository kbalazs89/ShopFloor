using ShopFloor.dal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopFloor
{
    class ProductFormViewModel : BaseModel
    {
        public Product Product { get; set; }
        public bool IsNew { get; set; }
        public bool Error { get; set; }

        /// <summary>
        /// Constructor 
        /// </summary>
        public ProductFormViewModel(Product Product)
        {
           this.Product = Product;
        }

        /// <summary>
        /// Call Validator method and DataManager's AddProduct method to insert record to DB. Called from MainWindow
        /// </summary>
        public bool AddProduct(Product Product)
        {
            var manager = new DataManager();
            if (ProductValidate())
            {
                if (manager.AddProduct(Product.Name, Product.Price, Product.Quantity, Product.Cathegory, Product.NrOfSeats, Product.FlightRange, Product.NrOfEngines))
                    return true;
                return false;
            }
            else
                return
                    false;
        }

        /// <summary>
        /// Call Data Manager to modify record
        /// </summary>
        public void ModifyProduct(Product Product)
        {
            if (ProductValidate())
            {
                var manager = new DataManager();
                manager.ModifyProduct(Product.Name, Product.Price, Product.Quantity, Product.Cathegory, Product.NrOfSeats, Product.FlightRange, Product.NrOfEngines);
                Error = false;
            }
            else
                Error = true;
        }

        public bool ProductValidate()
        {
            return !string.IsNullOrEmpty(Product.Name) && 
                Product.Name.Length > 2 && 
                (Product.Price % 1 != 0) &&
                Product.Price > 0 && 
                (Product.Quantity % 1 != 0) &&
                Product.Quantity > 0 && 
                !string.IsNullOrEmpty(Product.Cathegory) &&
                (Product.NrOfSeats % 1 != 0) &&
                Product.NrOfSeats > 0 &&
                (Product.FlightRange % 1 != 0) &&
                Product.FlightRange > 0 &&
                (Product.NrOfEngines % 1 != 0) &&
                Product.NrOfEngines > 0;
        }

    }
}
