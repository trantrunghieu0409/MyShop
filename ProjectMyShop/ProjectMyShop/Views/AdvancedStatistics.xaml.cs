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
using ProjectMyShop.DTO;
using ProjectMyShop.BUS;

namespace ProjectMyShop.Views
{
    /// <summary>
    /// Interaction logic for AdvancedStatistics.xaml
    /// </summary>
    public partial class AdvancedStatistics : Page
    {
        public AdvancedStatistics(Statistics srcPage)
        {
            InitializeComponent();

            _statisticsPage = srcPage;

            statisticsDatePicker.SelectedDate = selectedDate;

            statisticsCombobox.ItemsSource = statisticsFigureValues;
            statisticsCombobox.SelectedIndex = statisticsFigureIndex;

            timeCombobox.ItemsSource = figureValues;
            timeCombobox.SelectedIndex = figureIndex;

            phones = _phoneBUS.getWeeklyBestSellingPhones();

            for (int i = 0; i < phones.Count(); i++)
            {
               System.Diagnostics.Debug.WriteLine(phones[i].PhoneName);
            }

            PhoneDataGrid.ItemsSource = phones;

            DataContext = this;
        }

        public void getSpecificStatistic(SpecificStatistics srcSpecificStatistics)
        {
            _specificPage = srcSpecificStatistics;
        }
        public DateTime selectedDate { get; set; } = DateTime.Now;
        public int figureIndex { get; set; } = 0;
        public List<string> figureValues = new List<string>() {"Weekly", "Monthly", "Yearly" };
        public List<string> statisticsFigureValues = new List<string>() { "General", "Specific", "Advanced" };
        public int statisticsFigureIndex { get; set; } = 2;
        public List<Phone> phones;
        private Statistics _statisticsPage;
        private SpecificStatistics _specificPage;
        PhoneBUS _phoneBUS = new PhoneBUS();

        private void statisticsCombobox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            switch (statisticsFigureIndex)
            {
                case 0:
                    NavigationService.Navigate(_statisticsPage);
                    statisticsFigureIndex = 0;
                    statisticsCombobox.SelectedIndex = statisticsFigureIndex;
                    break;
                case 1:
                    NavigationService.Navigate(_specificPage);
                    statisticsFigureIndex = 1;
                    statisticsCombobox.SelectedIndex = statisticsFigureIndex;
                    break;
                case 2:
                    break;
                default:
                    break;
            }
        }

        private void timeCombobox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            switch (figureIndex)
            {
                case 0:
                    phones = _phoneBUS.getWeeklyBestSellingPhones();
                    PhoneDataGrid.ItemsSource = phones;

                    for (int i = 0; i < phones.Count(); i++)
                    {
                        System.Diagnostics.Debug.WriteLine(phones[i].PhoneName);
                    }
                    break;
                case 1:
                    phones = _phoneBUS.getMonthlyBestSellingPhones();
                    PhoneDataGrid.ItemsSource = phones;

                    for (int i = 0; i < phones.Count(); i++)
                    {
                        System.Diagnostics.Debug.WriteLine(phones[i].PhoneName);
                    }
                    break;
                case 2:
                    phones = _phoneBUS.getYearlyBestSellingPhones();
                    PhoneDataGrid.ItemsSource = phones;

                    for (int i = 0; i < phones.Count(); i++)
                    {
                        System.Diagnostics.Debug.WriteLine(phones[i].PhoneName);
                    }
                    break;
                default:
                    phones = _phoneBUS.getWeeklyBestSellingPhones();
                    PhoneDataGrid.ItemsSource = phones;
                    break;
            }
        }

        private void statisticsDatePicker_SelectedDateChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
