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
            /*
            string? connectionString = AppConfig.ConnectionString();
            var dao = new SqlDataAccess(connectionString!);

            if (dao.CanConnect())
            {
                dao.Connect();

            }
            else
            {
                MessageBox.Show("Cannot connect to db");
            }
            */
            string? username = "admin";
            string password = "admin";

            bool canGetAccount = false;
            try
            {
                username = AppConfig.GetValue(key: AppConfig.Username);
                password = AppConfig.GetPassword();
                canGetAccount = true;
            }
            catch { }   

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
                AppConfig.SetValue(AppConfig.Username, account.Username);
                AppConfig.SetPassword(password);


                if (account.Username.Equals("admin", StringComparison.Ordinal) && password.Equals("admin"))
                {
                    DialogResult = true;

                }
                else
                {
                    MessageBox.Show("Wrong username or password", "Login", MessageBoxButton.OK, MessageBoxImage.Warning);
                }
            }
            else
            {
                // gain focus 
            }

        }

    }
}
