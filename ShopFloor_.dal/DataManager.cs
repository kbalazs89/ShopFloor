using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopFloor.dal
{
    public class DataManager
    {
        readonly Cont _ctx;


        public DataManager()
        {
            _ctx = new Cont();
            /*if (!_ctx.Users.Any(x => x.Username == "asdf"))
            {
                _ctx.Users.Add(new UserDBModel
                {
                    Username = "asdf",
                    Password = "asdf",
                    Cash = 2500
                });
                _ctx.SaveChanges();
            }*/
        }



        public UserDBModel GetUser(string username, string password)
        {
            try
            {
                return _ctx.Users.SingleOrDefault
                    (x => x.Username == username && x.Password == password);
            }
            catch (InvalidOperationException)
            {
                return null;
            }
        }

        public IEnumerable<ProductDBModel> GetProducts(string sender)
        {

            return _ctx.Products.OrderBy(x => x.Name);
        }



        public IEnumerable<ProductDBModel> GetProducts()
        {

            return _ctx.Products.OrderBy(x => x.Name);
        }

        public void AddProduct(string name, int price, int quantity, string cathegory, int nrOfSeats, int flightRange, int nrOfEngines)
        {
            _ctx.Products.Add(new ProductDBModel
            {
                Name= name,
                Price= price,
                Quantity = quantity,
                Cathegory= cathegory,
                NrOfSeats = nrOfSeats,
                FlightRange = flightRange,
                NrOfEngines = nrOfEngines
            });
            _ctx.SaveChanges();
        }

        public void DeleteProduct(string name, int price, int nrOfSeats)
        {
            foreach (var prod in _ctx.Products)
            {
                if (name == prod.Name && price == prod.Price && nrOfSeats == prod.NrOfSeats)
                    _ctx.Products.Remove(prod);
            }
            _ctx.SaveChanges();
                      

        }

    }
}
