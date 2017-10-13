﻿using ShopFloor.dal;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopFloor
{
    public class CartViewModel : BaseModel
    {
        
        public ObservableCollection<Product> PurchasedProducts { get; set; } = StaticClass.PurchasedProducts;
        public User UserCart = StaticClass.LoggedUser;
        public int CartPrice { get; set; }

        /// <summary>
        /// Constructor, calculates the cart's current value
        /// </summary>
        public CartViewModel()
        {
            CartPrice = 0;
            foreach (var product in PurchasedProducts)
            {
                CartPrice += product.Price * product.Quantity;
            }
        }

        /// <summary>
        /// Empty Productlist and call DataManager's purchase-method
        /// </summary>
        public void Purchase()
        {
            var manager = new DataManager();
            foreach (var product in PurchasedProducts)
            {
                manager.BuyProduct(product.Name, product.Price, product.Quantity, product.NrOfSeats, product.FlightRange, UserCart.Username);
                UserCart.Cash -= manager.SumPrice;
            }
            
            PurchasedProducts = new ObservableCollection<Product>();
            StaticClass.PurchasedProducts = new ObservableCollection<Product>();
        }

        /// <summary>
        /// ClearCart
        /// </summary>
        public void ClearCart()
        {
            PurchasedProducts.Clear();
        }
    }
}
