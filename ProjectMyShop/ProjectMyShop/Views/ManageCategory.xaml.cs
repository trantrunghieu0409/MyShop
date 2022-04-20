using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using Aspose.Cells;
using Microsoft.Win32;
using ProjectMyShop.BUS;
using ProjectMyShop.DTO;
using ProjectMyShop.ViewModels;
using System.ComponentModel;
using System.Diagnostics;
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
    /// Interaction logic for ManageCategory.xaml
    /// </summary>
    public partial class ManageCategory : Page
    {

        List<Category>? _categories = null;        
        CategoryViewModel CategoryViewModel = new CategoryViewModel();

        public ManageCategory()
        {
            InitializeComponent();
            
            
        }

        private void AddButton_Click(object sender, RoutedEventArgs e)
        {
            var screen = new AddCategoryScreen();
            var result = screen.ShowDialog();
            if (result == true)
            {
/*                var newPhone = screen.newPhone;
                Debug.WriteLine(newPhone.PhoneName);
                var catIndex = screen.catIndex;
                if (catIndex >= 0)
                {
                    try
                    {
                        newPhone.Category = _categories[catIndex];
                        _phoneBus.addPhone(newPhone);
                        _categories[catIndex].Phones.Add(newPhone);
                        loadPhones();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(screen, ex.Message);
                    }
                }*/
            }
            
        }

        private void EditButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void DeleteButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
                      
            var catBUS = new CategoryBUS();            
            _categories = catBUS.getCategoryList();

            categoriesListView.ItemsSource = _categories;
        }

        private void nextButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void deleteMenuItemClick(object sender, RoutedEventArgs e)
        {

        }

        private void editMenuItemClick(object sender, RoutedEventArgs e)
        {

        }

        private void previousButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void categoriesListView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

       
    }
}
