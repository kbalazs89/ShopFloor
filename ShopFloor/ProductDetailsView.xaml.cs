using System.Windows;

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
