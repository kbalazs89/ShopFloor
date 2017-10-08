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
        Context _ctx;

        Product product;
        public ProductFormNewModel(Product Product)
        {
            /*this.Product = Product;
            if (!IsNew)
                Save();*/

        }

        public bool ProductValidate()
        {
            return !string.IsNullOrEmpty(Product.Name) && Product.Name.Length > 3 && Product.Price > 0 && Product.Quantity >= 0;
        }

        public void AddProduct(ProductDBModel product)
        {
            _ctx = new Context();
            _ctx.Products.Add(product);

        }

        /*public void Save()
        {
            if (!IsNew)
                product = new Product { Name = Product.Name, Price = Product.Price, Quantity = Product.Quantity };
        }

        public void OriginalValue()
        {
            Product.Name = product.Name;
            Product.Price = product.Price;
            Product.Quantity = product.Quantity;
        }*/
    }
}
