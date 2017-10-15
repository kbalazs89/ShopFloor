using System;
using System.Windows;


namespace ShopFloor
{
    public partial class CartView : Window
    {

        static Random R = new Random();
        int id = R.Next(0, 10000);

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
                MessageBox.Show("Success! Pick up your plane at the nearest airport! Refer your code: " +id);
                cartMM.ClearCart();
                Close();
            }
            else
                MessageBox.Show("Looks like something is missing. Either your cash or a product from your cart");
        }

        private void ClearClick(object sender, RoutedEventArgs e)
        {
            CartViewModel cartMM = new CartViewModel();
            cartMM.ClearCart();
            MessageBox.Show("No products in cart");
            Close();
        }
    }
}
