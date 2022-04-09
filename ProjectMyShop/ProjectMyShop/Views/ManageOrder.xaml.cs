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
            _orders = new BindingList<Order>(_orderBUS.GetAllOrders());

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
        int _rowsPerPage = 10;

        void Reload()
        {
            _currentPage = 1;

            _vm.Orders = _orders;
            _vm.SelectedOrders = _vm.Orders
               .Skip((_currentPage - 1) * _rowsPerPage)
               .Take(_rowsPerPage).ToList();

            _totalItems = _vm.Orders.Count;
            _totalPages = _vm.Orders.Count / _rowsPerPage +
                (_vm.Orders.Count % _rowsPerPage == 0 ? 0 : 1);


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
                Status = 2
            };
            _orderBUS.AddOrder(order);
            _orders.Add(order);
            Reload();
        }

        private void DeleteButton_Click(object sender, RoutedEventArgs e)
        {
            var index = OrderDataGrid.SelectedIndex;

            if (index != -1)
            {
                _orderBUS.DeleteOrder(_orders[index].ID);
                _orders.RemoveAt(index);
                Reload();
            }
            else
            {
               // Do nothing
            }


            /*
            var p = (Phone)phonesListView.SelectedItem;
            var result = MessageBox.Show($"Bạn thật sự muốn xóa điện thoại {p.PhoneName} - {p.Manufacturer}?",
                "Xác nhận xóa", MessageBoxButton.YesNo, MessageBoxImage.Question);
            if (MessageBoxResult.Yes == result)
            {
                //_phones.Remove(p);
                _vm.Phones.Remove(p);
                _categories[i].Phones.Remove(p);
                //_vm.SelectedPhones.Remove(p);

                _vm.SelectedPhones = _vm.Phones
                    .Skip((_currentPage - 1) * _rowsPerPage)
                    .Take(_rowsPerPage).ToList();


                // Tính toán lại thông số phân trang
                _totalItems = _vm.Phones.Count;
                _totalPages = _vm.Phones.Count / _rowsPerPage +
                    (_vm.Phones.Count % _rowsPerPage == 0 ? 0 : 1);

                currentPagingTextBlock.Text = $"{_currentPage}/{_totalPages}";
                if (_currentPage + 1 > _totalPages)
                {
                    nextButton.IsEnabled = false;
                }

                phonesListView.ItemsSource = _vm.SelectedPhones;
            }
            */
        }

        private void OrderDataGrid_SelectionChanged_1(object sender, SelectionChangedEventArgs e)
        {

        }

        private void SaveButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void DetailButton_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
