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

        /// <summary>
        /// "Get on board" button, to log in
        /// </summary>
        private void LoginClick(object sender, RoutedEventArgs e)
        {
            ViewModel.Password = passwordTextbox.Password;
            if (ViewModel.Login())
                Close();
            else
                MessageBox.Show("Incorrect Username or Password");
        }

        /// <summary>
        /// "Get board" button to cancel log in and exit the application
        /// </summary>
        private void LogoutClick(object sender, RoutedEventArgs e)
        {
                Application.Current.Shutdown();
        }

        /// <summary>
        /// "First flyer" button
        /// </summary>
        private void RegisterClick(object sender, RoutedEventArgs e)
        {
            RegWindowView regView = new RegWindowView();
            regView.ShowDialog();
        }

        private void DragWindow(object sender, MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Left)
                DragMove();
        }
    }
    }
