using ProjectMyShop.DAO;
using ProjectMyShop.DTO;
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

        Account account = new Account();

        public Login()
        {
            InitializeComponent();
        }
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            string username = "username";
            string password = "password";

            bool canGetAccount = false;
            try
            {
                username = AppConfig.GetValue(key: AppConfig.Username);
                password = AppConfig.GetPassword();
                canGetAccount = true;
            }
            catch { System.Diagnostics.Debug.WriteLine("First time running - Cannot read username/password"); }   

            if (canGetAccount)
            {
                account.Username = username;
                PasswordBox.Password = password;
            }

            DataContext = account;
        }

        private void ButtonLogin_Click(object sender, RoutedEventArgs e)
        {
            account.Username = TextBoxEmail.Text;
            string password = PasswordBox.Password;


            if (account.Username != null && password != null)
            {

                // save username & password to config file for later sign in
                AppConfig.SetValue(AppConfig.Username, account.Username);
                AppConfig.SetPassword(password);


                // validate account
                string? connectionString = AppConfig.ConnectionString(account.Username, password);
                var dao = new SqlDataAccess(connectionString!);

                if (dao.CanConnect())
                {
                    DialogResult = true;
                }
                else
                {
                    MessageBox.Show("Wrong username or password", "Login", MessageBoxButton.OK, MessageBoxImage.Warning);

                    System.Diagnostics.Debug.WriteLine("Cannot connect to db");
                }
            }
            else
            {
                // gain focus 
            }

        }

    }
}
