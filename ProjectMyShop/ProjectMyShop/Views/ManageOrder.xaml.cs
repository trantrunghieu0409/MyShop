using ProjectMyShop.BUS;
using ProjectMyShop.DTO;
using ProjectMyShop.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
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
        private OrderBUS _orderBUS;

        OrderViewModel _vm;
        DateTime FromDate;
        DateTime ToDate;

        public ManageOrder()
        {
            InitializeComponent();
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            _vm = new OrderViewModel();
            _orderBUS = new OrderBUS();

            FromDate = DateTime.Parse("1/1/1970");
            ToDate = DateTime.Now;
            
            Reload();
            OrderDataGrid.ItemsSource = _vm.SelectedOrders;
        }


        private void OrderDataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
        int _totalItems = 0;
        int _currentPage = 1;
        int _totalPages = 0;
        int _rowsPerPage = 4; // 8

        void Reload()
        {
            _vm.Orders = new BindingList<Order>(_orderBUS.GetAllOrdersByDate(FromDate, ToDate));
            _vm.SelectedOrders = _vm.Orders.Skip((_currentPage - 1) * _rowsPerPage)
                .Take(_rowsPerPage).ToList();

            _totalItems = _vm.Orders.Count();
            _totalPages = _totalItems / _rowsPerPage +
                (_totalItems % _rowsPerPage == 0 ? 0 : 1);

            if (_currentPage > _totalPages) _currentPage = _totalPages;

            // control prev & next buttons
            if (_currentPage == 1) PreviousButton.IsEnabled = false;
            else
            {
                PreviousButton.IsEnabled = true;
            }
            if (_currentPage == _totalPages) NextButton.IsEnabled = false;
            else
            {
                NextButton.IsEnabled = true;
            }

            CurrentPageText.Text = _currentPage.ToString();
            TotalPageText.Text = _totalPages.ToString();

            OrderDataGrid.ItemsSource = _vm.SelectedOrders;
        }

        private void UpdateButton_Click(object sender, RoutedEventArgs e)
        {
            int i = OrderDataGrid.SelectedIndex;

            if (i != -1)
            {
                Order order = new Order()
                {
                    CustomerName = "Long Nguyen Van",
                    Address = "Ha Noi",
                    OrderDate = DateOnly.Parse("08/05/2022"),
                    Status = Order.OrderStatusEnum.Close
                };
                _orderBUS.UpdateOrder(_vm.SelectedOrders[i].ID, order);
                Reload();
            }
            {
                // do nothing
            }
        }

        private void AddButton_Click(object sender, RoutedEventArgs e)
        {
            Order order = new Order()
            {
                CustomerName = "Long",
                Address = "HCM",
                OrderDate = DateOnly.Parse("04/05/2022"),
                Status = Order.OrderStatusEnum.Open
            };
            _orderBUS.AddOrder(order);
            Reload();
        }

        private void DeleteButton_Click(object sender, RoutedEventArgs e)
        {
            int i = OrderDataGrid.SelectedIndex;

            if (i != - 1)
            {
                _orderBUS.DeleteOrder(_vm.SelectedOrders[i].ID);
                Reload();
                if (_vm.SelectedOrders.Count == 0)
                {
                    if (_currentPage > 1)
                    {
                        _currentPage--;
                        Reload();
                    }
                    else
                    {
                        // Empty Orders List -> Do nothing
                    }
                }
            }
            else
            {
                // do nothing
            }
        }

        private void SaveButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void DetailButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void NextButton_Click(object sender, RoutedEventArgs e)
        {
            _currentPage++;
            Reload();
        }

        private void PreviousButton_Click(object sender, RoutedEventArgs e)
        {
            _currentPage -= 1;
            Reload();
        }

        private void FilterButton_Click(object sender, RoutedEventArgs e)
        {
            if (FromDatePicker.SelectedDate != null)
            {
                FromDate = (DateTime)FromDatePicker.SelectedDate;
            }
            else
            {
                FromDate = DateTime.Parse("1/1/1970");
            }

            if (ToDatePicker.SelectedDate != null)
            {
                ToDate = (DateTime)ToDatePicker.SelectedDate;
            }
            else
            {
                ToDate= DateTime.Now;
            }

            if (FromDate <= ToDate)
            {
                Reload();
            }
            else
            {
                MessageBox.Show("Start Date cannot after End Date", "Date Filter", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }
    }
}
