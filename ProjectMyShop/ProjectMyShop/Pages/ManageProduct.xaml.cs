using Aspose.Cells;
using Microsoft.Win32;
using ProjectMyShop.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
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
    /// Interaction logic for ManageProduct.xaml
    /// </summary>
    public partial class ManageProduct : Page
    {
        public ManageProduct()
        {
            InitializeComponent();
        }

        private void searchTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
        ViewModel _vm = new ViewModel();
        List<Category> _categories = null;
        int _totalItems = 0;
        int _currentPage = 1;
        int _totalPages = 0;
        int _rowsPerPage = 10;
        int i = 0;

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            _categories = new List<Category>();
            System.Text.Encoding.RegisterProvider(System.Text.CodePagesEncodingProvider.Instance);
            var screen = new OpenFileDialog();

            if (screen.ShowDialog() == true)
            {
                string filename = screen.FileName;

                var workbook = new Workbook(filename);

                var tabs = workbook.Worksheets;
                // In ra các tab để d ebug
                foreach (var tab in tabs)
                {
                    Category cat = new Category()
                    {
                        CatName = tab.Name,
                        Phones = new BindingList<Phone>()
                    };

                    // Bắt đầu từ ô B3
                    var column = 'C';
                    var row = 4;

                    var cell = tab.Cells[$"{column}{row}"];

                    while (cell.Value != null)
                    {
                        string name = cell.StringValue;
                        string manu = tab.Cells[$"D{row}"].StringValue;
                        int boughtprice = tab.Cells[$"E{row}"].IntValue;
                        int soldprice = tab.Cells[$"F{row}"].IntValue;
                        int stock = tab.Cells[$"G{row}"].IntValue;
                        string desc = tab.Cells[$"H{row}"].StringValue;
                        string uploaddate = tab.Cells[$"I{row}"].StringValue;
                        string ava = tab.Cells[$"J{row}"].StringValue;

                        var p = new Phone()
                        {
                            PhoneName = name,
                            Manufacturer = manu,
                            BoughtPrice = boughtprice,
                            SoldPrice = soldprice,
                            Stock = stock,
                            Description = desc,
                            UploadDate = uploaddate,
                            Avatar = ava,
                            Category = cat,
                        };
                        cat.Phones.Add(p);

                        row++;
                        cell = tab.Cells[$"{column}{row}"];
                    }
                    _categories.Add(cat);
                }
                categoriesListView.ItemsSource = _categories;

            }
        }

        private void filterRangeComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void categoriesListView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            i = categoriesListView.SelectedIndex;
            previousButton.IsEnabled = false;
            nextButton.IsEnabled = true;

            if (i >= 0)
            {
                _currentPage = 1;

                _vm.Phones = _categories[i].Phones;
                _vm.SelectedPhones = new BindingList<Phone>(_vm.Phones
                    .Skip((_currentPage - 1) * _rowsPerPage)
                    .Take(_rowsPerPage).ToList());

                _totalItems = _vm.Phones.Count;
                _totalPages = _vm.Phones.Count / _rowsPerPage +
                    (_vm.Phones.Count % _rowsPerPage == 0 ? 0 : 1);

                currentPagingTextBlock.Text = $"{_currentPage}/{_totalPages}";

                phonesListView.ItemsSource = _vm.SelectedPhones;
            }
        }

        private void editMenuItem_Click(object sender, RoutedEventArgs e)
        {

        }

        private void deleteMenuItem_Click(object sender, RoutedEventArgs e)
        {

        }

        private void previousButton_Click(object sender, RoutedEventArgs e)
        {
            nextButton.IsEnabled = true;
            _currentPage--;
            _vm.SelectedPhones = new BindingList<Phone>(_vm.Phones
                .Skip((_currentPage - 1) * _rowsPerPage)
                .Take(_rowsPerPage)
                .ToList());

            // ép cập nhật giao diện
            phonesListView.ItemsSource = _vm.SelectedPhones;
            currentPagingTextBlock.Text = $"{_currentPage}/{_totalPages}";
            if (_currentPage - 1 < 1)
            {
                previousButton.IsEnabled = false;
            }
        }

        private void nextButton_Click(object sender, RoutedEventArgs e)
        {
            previousButton.IsEnabled = true;
            _currentPage++;
            _vm.SelectedPhones = new BindingList<Phone>(_vm.Phones
                    .Skip((_currentPage - 1) * _rowsPerPage)
                    .Take(_rowsPerPage)
                    .ToList());

            // ép cập nhật giao diện
            phonesListView.ItemsSource = _vm.SelectedPhones;
            currentPagingTextBlock.Text = $"{_currentPage}/{_totalPages}";

            if (_currentPage + 1 > _totalPages)
            {
                nextButton.IsEnabled = false;
            }
        }
    }
}
