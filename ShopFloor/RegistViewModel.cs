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

        /// <summary>
        /// Username validation
        /// </summary>
        public bool Validate()
        {
            return Username != null && Username.Length > 3;
        }
        /// <summary>
        /// Validates the password, run Data manager's Regist method and return with a string to notify user
        /// </summary>
        public string Reg(string password1, string password2)
        {
            if (password1 == password2 && password1.Length > 3)
            {
                if (!Validate())
                    return "Username must be 4 characters at least";
                else
                {
                    Password = password1;
                    var manager = new DataManager();
                    if (!manager.Regist(Username, Password))
                        return "User already exist";
                }
                return "Successfully registered";
            }
            return "Incorrect data";
        }
    }
}
