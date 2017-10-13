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
    public partial class ProductDetailsView : Window
    {
        public ProductDetailsViewModel pDVM;
        
        /// <summary>
        /// Constructor with the selected product
        /// </summary>
        public ProductDetailsView(Product Product)
        {
            string whoSent = Product.Name;
            InitializeComponent();
            pDVM = new ProductDetailsViewModel(whoSent);
            
            DataContext = pDVM;

        }
    }
}
