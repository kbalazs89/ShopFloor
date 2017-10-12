﻿using System;
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
            _ctx.SaveChanges();
        }

        public void Regist(string username, string password)
        {
            if (!_ctx.Users.Any(x => x.Username == username))
                _ctx.Users.Add(new UserDBModel
                {
                    Username = username,
                    Password = password,
                    Cash = 10000,
                    Admin = true
                });
            _ctx.SaveChanges();
        }


    }
}
