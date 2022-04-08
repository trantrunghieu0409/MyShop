using ProjectMyShop.BUS;
using System.Windows;
using System.Windows.Controls;

namespace ProjectMyShop.Views
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
            var _phoneBUS = new PhoneBUS();

            totalPhone = _phoneBUS.GetTotalPhone();

            DataContext = this;
        }
    }
}
