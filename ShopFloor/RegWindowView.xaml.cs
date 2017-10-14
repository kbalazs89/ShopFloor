using System.Windows;

namespace ShopFloor
{
    /// <summary>
    /// Interaction logic for RegWindowView.xaml
    /// </summary>
    public partial class RegWindowView : Window
    {
        RegistViewModel regView = new RegistViewModel();
        public RegWindowView()
        {
            DataContext = regView;
            InitializeComponent();
        }

        /// <summary>
        /// Submit registration
        /// </summary
        private void ClickRegister(object sender, RoutedEventArgs e)
        {
            string password = PasswordReg.Password;
            string password2 = PasswordReg2.Password;
            string result = regView.Reg(password, password2);
            MessageBox.Show(result);
            Close();
        }
    }
}
