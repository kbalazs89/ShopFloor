using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopFloor.dal
{
    public class DataManager
    {
        readonly Context _ctx;

        public DataManager()
        {
            _ctx = new Context();
            /*if (!_ctx.Users.Any(x => x.Username == "asdf"))
            {
                _ctx.Users.Add(new UserDBModel
                {
                    Username = "asdf",
                    Password = "asdf",
                    Cash = 500
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



    }
}
