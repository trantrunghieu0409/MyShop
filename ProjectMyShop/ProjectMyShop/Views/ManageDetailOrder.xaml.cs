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
        public ManageDetailOrder(Order order)
        {
            InitializeComponent();

            this.order = order;
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            OrderDatePicker.SelectedDate = DateTime.Parse(order.OrderDate.ToString());
            StatusComboBox.ItemsSource = Order.GetAllStatusValues();
            DataContext = order;
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void ReturnButton_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = false;
        }

        private void SaveButton_Click(object sender, RoutedEventArgs e)
        {
            DialogResult=true;
        }
    }
}
