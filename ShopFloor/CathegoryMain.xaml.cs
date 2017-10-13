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
    public partial class CathegoryMain : Window
    {
        public CatMainModel catMain;
        public Product selectedProduct;

        /// <summary>
        /// Constructor with the sender to filter for categories
        /// </summary>
        public CathegoryMain(Button sender)
        {
            string whoSent = sender.Content.ToString();
            InitializeComponent();
            catMain = new CatMainModel(whoSent);
            DataContext = catMain;
            if (!catMain.UserInCat.Admin)
                DeleteButton.Visibility = Visibility.Hidden;
        }

        /// <summary>
        /// Call CatMainModel class AddToCart method with the overload of selected item
        /// </summary>
        private void AddCartClick(object sender, RoutedEventArgs e)
        {
            string error = catMain.AddToCart(selectedProduct);
            if (error != null)
                MessageBox.Show(error);

        }

        /// <summary>
        /// Capture the selected item to use it in other methods
        /// </summary>
        private void SelectedClick(object sender, SelectionChangedEventArgs e)
        {
            selectedProduct = catMain.SelectProduct;
        }

        /// <summary>
        /// Delete the selected record from DB
        /// </summary>
        private void DeleteClick(object sender, RoutedEventArgs e)
        {
            string error = catMain.DeleteProduct(selectedProduct);
            if (error != null)
                MessageBox.Show(error);
            else
                MessageBox.Show("Successfully deleted!");
            
        }

        /// <summary>
        /// To watch all attributes of a record from product DB
        /// </summary>
        private void WatchProductDetails(object sender, MouseButtonEventArgs e)
        {
            selectedProduct = catMain.SelectProduct;
            ProductDetailsView productDetails = new ProductDetailsView(selectedProduct);
            productDetails.ShowDialog();
        }

        /// <summary>
        /// Similar to AddProduct in MainWindow. Difference: IsNew property = false, and give true overload to disable "Name" textbox when NewProductView opens
        /// </summary>
        private void ClickModify(object sender, RoutedEventArgs e)
        {
            if (selectedProduct != null)
            {
                ProductFormViewModel viewModel = new ProductFormViewModel(selectedProduct) { IsNew = false };
                NewProductView newProduct = new NewProductView(true) { DataContext = viewModel };
                newProduct.ShowDialog();
            }
            else
                MessageBox.Show("Please select a product first");
        }
    }
}
