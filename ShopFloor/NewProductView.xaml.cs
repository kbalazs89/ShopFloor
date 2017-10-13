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
    /// Interaction logic for NewProductView.xaml
    /// </summary>
    public partial class NewProductView : Window
    {

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

            }
            else
            {
                productVM.ModifyProduct(productVM.Product);
                if (!productVM.Error)
                {
                    MessageBox.Show("Sikeres mentés");
                }
                else
                    MessageBox.Show("Invalid Data");
                return;
            }
            Close();
        }

    }
}
