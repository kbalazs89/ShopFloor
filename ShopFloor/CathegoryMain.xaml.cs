using ShopFloor.dal;
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
using System.Windows.Shapes;

namespace ShopFloor
{
    /// <summary>
    /// Interaction logic for CathegoryMain.xaml
    /// </summary>
    public partial class CathegoryMain : Window
    {
        public CatMainModel catMain;
        public Product selectedProduct;
        //public ProductDetailsViewModel pDVM;

        public CathegoryMain(Button sender)
        {
            //var _sender = sender;
            string whoSent = sender.Content.ToString();
            InitializeComponent();
            catMain = new CatMainModel(whoSent);
            DataContext = catMain;
            //MessageBox.Show(catMain.UserInCat.Username);
            if (!catMain.UserInCat.Admin)
                DeleteButton.Visibility = Visibility.Hidden;
        }

        private void AddCartClick(object sender, RoutedEventArgs e)
        {
            catMain.AddToCart(selectedProduct);
        }

        private void SelectedClick(object sender, SelectionChangedEventArgs e)
        {
            selectedProduct = catMain.SelectProduct;
            
        }

        private void DeleteClick(object sender, RoutedEventArgs e)
        {
            catMain.DeleteProduct(selectedProduct);
            MessageBox.Show("Successful!");
            
        }

        private void WatchProductDetails(object sender, MouseButtonEventArgs e)
        {
            selectedProduct = catMain.SelectProduct;
            ProductDetailsView productDetails = new ProductDetailsView(selectedProduct);
            productDetails.ShowDialog();
        }

        private void ClickModify(object sender, RoutedEventArgs e)
        {
            ProductFormViewModel viewModel = new ProductFormViewModel(selectedProduct) { IsNew = false };
            NewProductView newProduct = new NewProductView(true) { DataContext = viewModel };
            newProduct.ShowDialog();
        }



        /*private void Check(object sender, RoutedEventArgs e)
        {
            foreach (var products in catMain.PurchasedProducts)
            {
                MessageBox.Show(products.Name);
            }
        }*/
    }
}
