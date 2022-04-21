using ProjectMyShop.BUS;
using ProjectMyShop.DTO;
using ProjectMyShop.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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

namespace ProjectMyShop.Views
{
    /// <summary>
    /// Interaction logic for ManageDetailOrder.xaml
    /// </summary>
    public partial class ManageDetailOrder : Window
    {
        public Order order;
        private OrderBUS _orderBUS;

        DetailOrderViewModel _vm;

        DetailOrder detailOrder;

        public ManageDetailOrder(Order order)
        {
            InitializeComponent();

            this.order = order;
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            if (order.OrderDate.Equals(DateOnly.Parse(DateTime.MinValue.Date.ToShortDateString()))) 
                order.OrderDate = DateOnly.Parse(DateTime.Now.Date.ToShortDateString());
            OrderDatePicker.SelectedDate = DateTime.Parse(order.OrderDate.ToString());
            StatusComboBox.ItemsSource = Order.GetAllStatusValues();
            DataContext = order;

            _vm = new DetailOrderViewModel();
            if (order.DetailOrderList != null)
            {
                _vm.detailOrders = new BindingList<DetailOrder>(order.DetailOrderList);
                PhoneDataGrid.ItemsSource = order.DetailOrderList;
            }

            _orderBUS = new OrderBUS();
            detailOrder = new DetailOrder();
            detailOrder.OrderID = order.ID;
        }

        private void ReturnButton_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = false;
        }

        private void SaveButton_Click(object sender, RoutedEventArgs e)
        {
            // date only cannot bound so have to do this 
            if (OrderDatePicker.SelectedDate != null)
                order.OrderDate = DateOnly.Parse(OrderDatePicker.SelectedDate.Value.Date.ToShortDateString());
            DialogResult = true;
        }

        private DateOnly ConvertDateTimeToDateOnly(DateTime dateTime)
        {
            return DateOnly.Parse(dateTime.Date.ToShortDateString());
        }

        private void ChoosePhoneButton_Click(object sender, RoutedEventArgs e)
        {
            detailOrder.Phone = new Phone();
            detailOrder.Phone.PhoneName = "Choose a phone";
            detailOrder.Quantity = 0;
            var screen = new AddPhoneOrder(detailOrder);
            if (screen.ShowDialog() == true)
            {
                if (order.DetailOrderList == null)
                    order.DetailOrderList = new List<DetailOrder>();

                order.DetailOrderList.Add(screen.detailOrder);
                _orderBUS.AddDetailOrder(screen.detailOrder);
                Reload();
            }
        }

        private void UpdateButton_Click(object sender, RoutedEventArgs e)
        {
            int i = PhoneDataGrid.SelectedIndex;

            if (i != -1)
            {
                var screen = new AddPhoneOrder(detailOrder);
                if (screen.ShowDialog() == true)
                {
                    if (order.DetailOrderList == null)
                        order.DetailOrderList = new List<DetailOrder>();

                    order.DetailOrderList[i] = (DetailOrder)screen.detailOrder.Clone();
                    _orderBUS.UpdateDetailOrder(screen.detailOrder);
                    Reload();
                }
            }
        }

        private void DeleteButton_Click(object sender, RoutedEventArgs e)
        {
            int i = PhoneDataGrid.SelectedIndex;

            if (i != -1)
            {
                var res = MessageBox.Show($"Are you sure to discard this phone: {order.DetailOrderList[i].Phone.PhoneName}?", "Delete phone from order", MessageBoxButton.YesNo, MessageBoxImage.Question);
                if (res == MessageBoxResult.Yes)
                {
                    order.DetailOrderList.RemoveAt(i);
                   _orderBUS.DeleteOrder(order.ID);
                   Reload();
                }
            }
            else
            {
                // do nothing
            }
        }

        void Reload()
        {

            if (order.DetailOrderList != null)
            {
                _vm.detailOrders = new BindingList<DetailOrder>(order.DetailOrderList);
                PhoneDataGrid.ItemsSource = _vm.detailOrders;
            }
        }


        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

            int i = PhoneDataGrid.SelectedIndex;
            if (i != -1)
            {
                var QuantityTextBox = e.OriginalSource as TextBox;

                if (QuantityTextBox != null)
                {
                    if (QuantityTextBox.Text == "")
                    {
                        QuantityTextBox.Text = "0";
                    }
                    else if ((order.DetailOrderList !=  null && (int.Parse(QuantityTextBox.Text)
                        > order.DetailOrderList[i].Phone.Stock)))
                    {
                        QuantityTextBox.Text = QuantityTextBox.Text.Remove(QuantityTextBox.Text.Length - 1);

                        if ((order.DetailOrderList != null && (int.Parse(QuantityTextBox.Text)
                            > order.DetailOrderList[i].Phone.Stock)))
                            QuantityTextBox.Text = order.DetailOrderList[i].Phone.Stock.ToString();
                    }
                }

            }
        }

        private new void PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            e.Handled = IsTextAllowed(e.Text);
        }

        private bool IsTextAllowed(string text)
        {
            Regex _regex = new Regex("[^0-9]+$"); //regex that matches disallowed text
            return _regex.IsMatch(text);
        }

    }
}
