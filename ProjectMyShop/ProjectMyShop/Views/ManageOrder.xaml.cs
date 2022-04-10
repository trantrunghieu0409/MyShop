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


        public ManageOrder()
        {
            InitializeComponent();
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            _vm = new OrderViewModel();
            
            _orderBUS = new OrderBUS();

            _vm.Orders = _orders;

            Reload();
            OrderDataGrid.ItemsSource = _vm.SelectedOrders;
        }


        private void OrderDataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        BindingList<Order> _orders;
        int _totalItems = 0;
        int _currentPage = 1;
        int _totalPages = 0;
        int _rowsPerPage = 4; // 8

        void Reload()
        {
            _vm.SelectedOrders = _orderBUS.GetOrders((_currentPage - 1) * _rowsPerPage, _rowsPerPage);

            _totalItems = _orderBUS.CountOrders();
            _totalPages = _totalItems / _rowsPerPage +
                (_totalItems % _rowsPerPage == 0 ? 0 : 1);

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

        private void SearchButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void UpdateButton_Click(object sender, RoutedEventArgs e)
        {
            /*
            var p = (Phone)phonesListView.SelectedItem;
            var screen = new EditPhoneScreen(p);
            var result = screen.ShowDialog();
            if (result == true)
            {
                var info = screen.EditedPhone;
                p.PhoneName = info.PhoneName;
                p.Manufacturer = info.Manufacturer;
                p.SoldPrice = info.SoldPrice;
                p.BoughtPrice = info.BoughtPrice;
                p.Description = info.Description;
                p.Avatar = info.Avatar;

                _vm.Phones = _categories[i].Phones;
                _vm.SelectedPhones = _vm.Phones
                    .Skip((_currentPage - 1) * _rowsPerPage)
                    .Take(_rowsPerPage).ToList();

                phonesListView.ItemsSource = _vm.SelectedPhones;
            }
            */
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
            var index = OrderDataGrid.SelectedIndex;

            if (index != -1)
            {
                _orderBUS.DeleteOrder(_vm.SelectedOrders[index].ID);
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
               // Do nothing
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
    }
}
