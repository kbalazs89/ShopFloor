using ShopFloor.dal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopFloor
{
    public class RegistViewModel
    {
        public string Username { get; set; }
        public string Password { get; set; }

        public bool Validate()
        {
            return Username != null && Username.Length > 0;
        }

        public void Reg(string password1, string password2)
        {
            if (password1 == password2)
            {
                if (Validate())
                {
                    Password = password1;
                    var manager = new DataManager();
                    manager.Regist(Username, Password);
                }
            }
        }
    }
}
