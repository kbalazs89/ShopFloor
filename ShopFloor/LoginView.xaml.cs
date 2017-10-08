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
    /// Interaction logic for LoginView.xaml
    /// </summary>
    public partial class LoginView : Window
    {
        readonly bool _onLogout;
        public LoginViewModel ViewModel { get; }

        public LoginView(bool onLogout = false)
        {
            _onLogout = onLogout;
            InitializeComponent();
            ViewModel = new LoginViewModel();
            DataContext = ViewModel;
        }

        private void LoginClick(object sender, RoutedEventArgs e)
        {
            ViewModel.Password = passwordTextbox.Password;
            if (ViewModel.Login())
                Close();
            else
                MessageBox.Show("Incorrect Username or Password");
        }

        private void LogoutClick(object sender, RoutedEventArgs e)
        {
            MessageBoxResult exit = MessageBox.Show("Forgot your passport?", "Logout", MessageBoxButton.YesNo, MessageBoxImage.Exclamation);
            if (exit == MessageBoxResult.Yes)
            {
                System.Windows.Application.Current.Shutdown();
            }
            else return;



        }

        private void OnClosing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            e.Cancel = ViewModel.AuthenticatedUser == null
                    && !_onLogout;
        }
        }
    }
