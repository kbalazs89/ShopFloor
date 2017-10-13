﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace ShopFloor
{
    public partial class CartView : Window
    {
        /// <summary>
        /// Constructor
        /// </summary>
        public CartView()
        {
            CartViewModel cartMM = new CartViewModel();
            InitializeComponent();
            DataContext = cartMM;
        }

        private void PurchaseClick(object sender, RoutedEventArgs e)
        {
            CartViewModel cartMM = new CartViewModel();
            if (cartMM.Purchase())
            {
                MessageBox.Show("Sikeres vásárlás");
                Close();
            }
            else
                MessageBox.Show("Not enough cash :( ");
        }

        private void ClearClick(object sender, RoutedEventArgs e)
        {
            CartViewModel cartMM = new CartViewModel();
            cartMM.ClearCart();
            MessageBox.Show("Kosár ürítve!");
            Close();

        }
    }
}
