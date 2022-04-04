using ProjectMyShop.Pages;
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

namespace ProjectMyShop
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        Dashboard dashboard;
        ManageProduct manageProductPage;

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            dashboard = new Dashboard();
            pageNavigation.NavigationService.Navigate(dashboard);
            manageProductPage = new ManageProduct();
        }

        private void dashboardButton_Click(object sender, RoutedEventArgs e)
        {
            pageNavigation.NavigationService.Navigate(dashboard);
        }

        private void productButton_Click(object sender, RoutedEventArgs e)
        {
            pageNavigation.NavigationService.Navigate(manageProductPage);
        }

        private void orderButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void statButton_Click(object sender, RoutedEventArgs e)
        {
            Statistics statistics = new Statistics();
            pageNavigation.NavigationService.Navigate(statistics);
        }

        private void configButton_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
