﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopFloor
{
    public class CartViewModel
    {
        public static ObservableCollection<Product> PurchasedProducts { get; set; } = StaticClass.PurchasedProducts;



    }
}
