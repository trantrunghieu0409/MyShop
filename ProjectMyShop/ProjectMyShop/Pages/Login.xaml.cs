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

namespace ProjectMyShop.Pages
{
    /// <summary>
    /// Interaction logic for Login.xaml
    /// </summary>
    public partial class Login : Window
    {
        public Login()
        {
            InitializeComponent();
        }

        private void ButtonLogin_Click(object sender, RoutedEventArgs e)
        {
            String username = TextBoxEmail.Text;
            String password = PasswordBox.Password;
            if (username.Equals("admin") && password.Equals("admin"))
            {
                MessageBox.Show("Login Successful", "Login", MessageBoxButton.OK, MessageBoxImage.Information);
                DialogResult = true;
               
            }
            else
            {
                MessageBox.Show("Wrong username or password", "Login", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }
    }
}
