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
        public int SumPrice2 { get; set; }

        /// <summary>
        /// Constructor, make instance of Cont class to connect the DB
        /// </summary>
        public DataManager()
        {
            _ctx = new Cont();

        }


        /// <summary>
        /// Retrieve single record from User DB
        /// </summary>
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

        /// <summary>
        /// Retrieve all products from DB. 1 overload. Called from CatMainModel and ProductDetailsViewModel
        /// </summary>
        public IEnumerable<ProductDBModel> GetProducts(string sender)
        {

            return _ctx.Products.OrderBy(x => x.Name);
        }

        /// <summary>
        /// Retrieve all products from DB, no overload
        /// </summary>
        public IEnumerable<ProductDBModel> GetProducts()
        {

            return _ctx.Products.OrderBy(x => x.Name);
        }

        /// <summary>
        /// Check if the record already exist, if not, add the requested record
        /// </summary>
        public bool AddProduct(string name, int price, int quantity, string cathegory, int nrOfSeats, int flightRange, int nrOfEngines)
        {
            foreach (var product in _ctx.Products)
            {
                if (name == product.Name)
                    return false;
            }
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
            return true;
        }

        /// <summary>
        /// Do not add new record, modify the selected one
        /// </summary>
        public void ModifyProduct(string name, int price, int quantity, string cathegory, int nrOfSeats, int flightRange, int nrOfEngines)
        {
            foreach (var product in _ctx.Products)
            {
                if(name == product.Name)
                {
                    product.Name = name;
                    product.Price = price;
                    product.Quantity = quantity;
                    product.Cathegory = cathegory;
                    product.NrOfSeats = nrOfSeats;
                    product.FlightRange = flightRange;
                    product.NrOfEngines = nrOfEngines;

                }
            }
            _ctx.SaveChanges();
        }

        /// <summary>
        /// Delete record from product DB
        /// </summary>
        public void DeleteProduct(string name)
        {
            foreach (var prod in _ctx.Products)
            {
                if (name == prod.Name)
                    _ctx.Products.Remove(prod);
            }
            _ctx.SaveChanges();
                      

        }

        public void BuyProduct(string name, int price, int quantity, int nrOfSeats, int flightRange, string username)
        {
            int sumPrice = 0;

            foreach (var prod in _ctx.Products)
            {
                if (name == prod.Name && price == prod.Price && nrOfSeats == prod.NrOfSeats && flightRange == prod.FlightRange)
                {
                    prod.Quantity -= quantity;
                    sumPrice = sumPrice + (price * quantity);
                }
            }

            foreach (var user in _ctx.Users)
            {
                if (username == user.Username)
                    user.Cash = user.Cash - sumPrice;
            }
            SumPrice2 = sumPrice;
            _ctx.SaveChanges();
        }

        /// <summary>
        /// RegistViewModel class calls the method to register new User in DB. Username must be unique
        /// </summary>
        public bool Regist(string username, string password)
        {
            if (!_ctx.Users.Any(x => x.Username == username))
            {
                _ctx.Users.Add(new UserDBModel
                {
                    Username = username,
                    Password = password,
                    Cash = 10000,
                    Admin = false
                });
                _ctx.SaveChanges();
                return true;
            }

            else
                return false;
        }


    }
}
