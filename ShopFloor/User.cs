﻿using ShopFloor.dal;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopFloor
{
    public class User : BaseModel
    {
        public User(UserDBModel user)
        {
            Username = user.Username;
            Password = user.Password;
            Cash = user.Cash;
            Admin = user.Admin;
        }
        public User()
        {

        }

        int _cash;
        public int Cash { get { return _cash; } set { _cash = value; OnPropertyChange(); } }
        public string Password { get; set; }
        public string Username { get; set; }
        public bool Admin { get; set; }
        public ObservableCollection<Product> PurchasedProducts { get; set; } = new ObservableCollection<Product>();
    }
}
