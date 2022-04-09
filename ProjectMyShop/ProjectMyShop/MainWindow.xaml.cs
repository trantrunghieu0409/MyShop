﻿using ProjectMyShop.Views;
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
        ManageOrder _manageOrderPage;
        Statistics statisticsPage;
        Login login;

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            login = new Login();
            login.Owner = this;
            if (login.ShowDialog() == true)
            {
                dashboard = new Dashboard();
                manageProductPage = new ManageProduct();
                _manageOrderPage = new ManageOrder();

                pageNavigation.NavigationService.Navigate(dashboard);
            }
            else
            {
                // quit
                this.Close();
            }
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
            pageNavigation.NavigationService.Navigate(_manageOrderPage);
        }

        private void statButton_Click(object sender, RoutedEventArgs e)
        {
            statisticsPage = new Statistics();
            pageNavigation.NavigationService.Navigate(statisticsPage);
        }

        private void configButton_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
