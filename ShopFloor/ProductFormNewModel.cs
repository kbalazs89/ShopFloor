using ShopFloor.dal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopFloor
{
    class ProductFormNewModel : BaseModel
    {
        public Product Product { get; set; }
        public bool IsNew { get; set; }
        //Context _ctx;

        public ProductFormNewModel(Product Product)
        {
           /* this.Product = Product;
            if (!IsNew)
                Save();*/
            var manager = new DataManager();
            manager.AddProduct(Product.Name, Product.Price, Product.Quantity, Product.Cathegory, Product.NrOfSeats, Product.FlightRange, Product.NrOfEngines);

        }

        public bool ProductValidate()
        {
            return !string.IsNullOrEmpty(Product.Name) && Product.Name.Length > 3 && Product.Price > 0 && Product.Quantity >= 0;
        }




    }
}
