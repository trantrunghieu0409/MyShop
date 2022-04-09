using ProjectMyShop.BUS;
using ProjectMyShop.DTO;
using System.Collections.Generic;
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

        List<Phone> _phones = new List<Phone>();
        public Dashboard()
        {
            InitializeComponent();
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            var _phoneBUS = new PhoneBUS();
            var _orderBUS = new OrderBUS();
            totalPhone = _phoneBUS.GetTotalPhone();
            weekOrder = _orderBUS.GetOrderByWeek();
            monthOrder = _orderBUS.GetOrderByMonth();
            _phones = _phoneBUS.Top5OutStock();

            PhoneDataGrid.ItemsSource = _phones;
            DataContext = this;
        }

        private void PhoneDataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void AddStockButton_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
