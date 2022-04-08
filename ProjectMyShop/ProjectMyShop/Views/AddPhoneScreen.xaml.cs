using Microsoft.Win32;
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
using System.Windows.Shapes;

namespace ProjectMyShop.Views
{
    /// <summary>
    /// Interaction logic for AddPhoneScreen.xaml
    /// </summary>
    public partial class AddPhoneScreen : Window
    {
        public Phone newPhone { get; set; }
        public int catIndex { get; set; } = -1;
        public AddPhoneScreen(List<Category> category)
        {
            InitializeComponent();
            newPhone = new Phone();
            this.DataContext = newPhone;
            categoryCombobox.ItemsSource = category;
        }

        private void categoryCombobox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            catIndex = categoryCombobox.SelectedIndex;
        }

        private void cancelButton_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = false;
        }

        private void addButton_Click(object sender, RoutedEventArgs e)
        {
            // Check validity

            DialogResult = true;
        }

        private void chooseImageButton_Click(object sender, RoutedEventArgs e)
        {
            var screen = new OpenFileDialog();
            if(screen.ShowDialog() == true)
            {
                newPhone.Avatar = screen.FileName;
            }
        }
    }
}
