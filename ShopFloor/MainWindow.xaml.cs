using System;
using System.Windows;
using System.Windows.Controls;

namespace ShopFloor
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public  MainViewModel _vm;

        /// <summary>
        /// Constructor
        /// </summary>
        public MainWindow()
        {
            InitializeComponent();
            var loginView = new LoginView();
            loginView.ShowDialog();
            _vm = new MainViewModel
            {
                User = loginView.ViewModel.AuthenticatedUser
            };
            DataContext = _vm;
            try
            {
                if (!_vm.User.Admin)
                    AddProductButton.Visibility = Visibility.Hidden;
            }
            catch (NullReferenceException)
            {  }
        }

        /// <summary>
        /// To enter a category
        /// </summary>
        private void ClickOnCat(object sender, RoutedEventArgs e)
        {
            CathegoryMain cat = new CathegoryMain((Button)sender);
            cat.ShowDialog();
        }

        /// <summary>
        /// "Add product" button, to insert record to product DB. Open a new window with enabled "Name" textbox
        /// </summary>
        private void AddProductClick(object sender, RoutedEventArgs e)
        {
            ProductFormViewModel viewModel = new ProductFormViewModel(new Product()) { IsNew = true };
            NewProductView newProduct = new NewProductView(false) { DataContext = viewModel};
            newProduct.ShowDialog();
        }

        /// <summary>
        /// To check the cart with the currrent products. Cart is an interim location, not stored in database.
        /// </summary>
        private void ClickCart(object sender, RoutedEventArgs e)
        {
            CartView cart = new CartView();
            cart.ShowDialog();
        }
        /// <summary>
        /// To exit the prpogram from the Main Window
        /// </summary>
        private void OnClosing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            MessageBoxResult exit = MessageBox.Show("Are you sure?", "Logout", MessageBoxButton.YesNo, MessageBoxImage.Warning);
            if (exit == MessageBoxResult.Yes)
            {
                Application.Current.Shutdown();
            }
            else
            e.Cancel = true;
        }
    }
}
