using System;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ShopFloor
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
       public  MainViewModel _vm;
        public User UserX;
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
        }



        private void ClickOnCat(object sender, RoutedEventArgs e)
        {
            CathegoryMain Cat = new CathegoryMain((Button)sender);
            Cat.ShowDialog();
        }

        private void AddProductClick(object sender, RoutedEventArgs e)
        {
            ProductFormViewModel viewModel = new ProductFormViewModel(new Product());
            NewProductView newProduct = new NewProductView { DataContext = viewModel };
            newProduct.ShowDialog();
        }

        private void ClickCart(object sender, RoutedEventArgs e)
        {

        }
    }
}
