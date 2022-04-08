using ProjectMyShop.BUS;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ProjectMyShop.Pages
{
    /// <summary>
    /// Interaction logic for Dashboard.xaml
    /// </summary>
    public partial class Dashboard : Page
    {
        public int totalPhone { get; set; } = 0;
        public int weekOrder { get; set; } = 0;
        public int monthOrder { get; set; } = 0;
        public Dashboard()
        {
            InitializeComponent();
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            var connectionString =
                "Server=.\\sqlexpress;Database=PremiumPhoneShop;Trusted_Connection=True;";
            var bus = new Business(new DAO.SqlDataAccess(connectionString));
            totalPhone = bus.GetTotalPhone();

            DataContext = this;
        }
    }
}
