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
        readonly CatMainModel _cmm;


        public CathegoryMain(Button sender)
        {
            var _sender = sender;
            string whoSent = sender.Content.ToString();
            InitializeComponent();
            _cmm = new CatMainModel(whoSent);
            DataContext = _cmm;
            MessageBox.Show(_cmm.User.Username);
        }
    }
}
