using System;
using System.Windows;
using System.Windows.Input;

namespace ShopFloor
{
    public partial class LoginView : Window
    {
        //readonly bool _onLogout;
        public LoginViewModel ViewModel { get; }

        /// <summary>
        /// Constructor
        /// </summary>
        public LoginView(/*bool onLogout = false*/)
        {
            //_onLogout = onLogout;
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
            MessageBoxResult exit = MessageBox.Show("Are you sure?", "Logout", MessageBoxButton.YesNo, MessageBoxImage.Warning);
            if (exit == MessageBoxResult.Yes)
            {
                Environment.Exit(0);
            }
            else
                return;
        }

        /// <summary>
        /// "First flyer" button
        /// </summary>
        private void RegisterClick(object sender, RoutedEventArgs e)
        {
            RegWindowView regView = new RegWindowView();
            regView.ShowDialog();
        }

        /// <summary>
        /// To drag the window
        /// </summary>
        private void DragWindow(object sender, MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Left)
                DragMove();
        }
    }
    }
