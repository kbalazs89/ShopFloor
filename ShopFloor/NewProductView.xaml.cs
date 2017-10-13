using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
                if (!productVM.AddProduct(productVM.Product))
                {
                    MessageBox.Show("Incorrect data. Check your entries again");
                    return;
                }
                MessageBox.Show("Sikeres mentés");
                Close();
            }
            else
            {
                productVM.ModifyProduct(productVM.Product);
                if (!productVM.Error)
                {
                    MessageBox.Show("Sikeres mentés");
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
