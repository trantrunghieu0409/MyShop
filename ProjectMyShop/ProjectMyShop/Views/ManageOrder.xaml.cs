using ProjectMyShop.BUS;
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

namespace ProjectMyShop.Views
{
    /// <summary>
    /// Interaction logic for ManageOrder.xaml
    /// </summary>
    public partial class ManageOrder : Page
    {
        private List<Order> _listOrders;
        private OrderBUS _orderBUS;

        public ManageOrder()
        {
            InitializeComponent();
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            _orderBUS = new OrderBUS();

            _listOrders = _orderBUS.GetAllOrders();

            OrderDataGrid.ItemsSource = _listOrders;
        }

        private void AddMenuItem_Click(object sender, RoutedEventArgs e)
        {

        }

        private void UpdateMenuItem_Click(object sender, RoutedEventArgs e)
        {

        }

        private void DeleteMenuItem_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
