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
