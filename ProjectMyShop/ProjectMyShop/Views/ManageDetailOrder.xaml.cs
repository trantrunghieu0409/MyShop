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
        private CategoryBUS _categoryBUS; 
        private PhoneBUS _phoneBUS;

        private List<Category> categories;
        private List<Phone> phones;


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





            PhoneDataGrid.ItemsSource = order.DetailOrderList;
            foreach (var detail in order.DetailOrderList)
                System.Diagnostics.Debug.WriteLine($"{detail.OrderID} - {detail.Phone.PhoneName} - {detail.Quantity}");
            


            /*
            _categoryBUS = new CategoryBUS();
            _phoneBUS = new PhoneBUS();

            categories = _categoryBUS.getCategoryList();
            categoriesComboBox.ItemsSource = categories;

            if (categories.Count() > 0)
                phones = _phoneBUS.getPhonesAccordingToSpecificCategory(categories[categoriesFigureIndex].ID);
            else
                phones = new List<Phone> { };

            productComboBox.ItemsSource = phones;
            */
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
            // date only cannot bound so have to do this 
            if (OrderDatePicker.SelectedDate != null)
                order.OrderDate = DateOnly.Parse(OrderDatePicker.SelectedDate.Value.Date.ToShortDateString());
            DialogResult=true;
        }

        private DateOnly ConvertDateTimeToDateOnly(DateTime dateTime)
        {
            return DateOnly.Parse(dateTime.Date.ToShortDateString());
        }
    }
}
