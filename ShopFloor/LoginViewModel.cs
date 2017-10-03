using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShopFloor.dal;

namespace ShopFloor
{
    public class LoginViewModel
    {
        public string Username { get; set; }
        public string Password { get; set; }

        public User AuthenticatedUser { get; private set; }

        public bool Login()
        {
            var ctx = new Context();
            foreach (var user in ctx.Users)
                if (user.Username == Username &&
                    user.Password == Password)
                {
                    AuthenticatedUser = new User(user);
                    return true;
                }
            return false;
        }
    }
}
