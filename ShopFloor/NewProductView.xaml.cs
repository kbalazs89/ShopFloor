using System.Text.RegularExpressions;
using System.Windows;
using System.Windows.Input;

namespace ShopFloor
{
    public partial class NewProductView : Window
    {
        /// <summary>
        /// Constructor
        /// </summary>
        public NewProductView(bool changed)
        {
            if (!changed)
            {
                InitializeComponent();
                NameText.IsEnabled = true;
            }
            else
            {
                InitializeComponent();
                NameText.IsEnabled = false;
            }

        }

        /// <summary>
        /// Call different methods of DataManager
        /// </summary>
        private void SubmitClick(object sender, RoutedEventArgs e)
        {
            var productVM = (ProductFormViewModel)DataContext;
            if (productVM.IsNew)
            {
                if (!productVM.AddProduct())
                {
                    MessageBox.Show("Incorrect data. Check your entries again");
                    return;
                }
                MessageBox.Show("Product successfully added");
                Close();
            }
            else
            {
                productVM.ModifyProduct(productVM.Product);
                if (!productVM.Error)
                {
                    MessageBox.Show("Product successfully modified");
                    Close();
                }
                else
                    MessageBox.Show("Invalid Data");
                return;
            }
        }

        /// <summary>
        /// Int textboxes can be numbers only
        /// </summary>
        private void InstantValid(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^0-9]+");
            e.Handled = regex.IsMatch(e.Text);
        }
    }
}
