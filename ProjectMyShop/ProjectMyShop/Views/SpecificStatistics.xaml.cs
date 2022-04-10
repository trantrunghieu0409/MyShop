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
using ProjectMyShop.BUS;
using ProjectMyShop.DTO;

namespace ProjectMyShop.Views
{
    /// <summary>
    /// Interaction logic for SpecificStatistics.xaml
    /// </summary>
    public partial class SpecificStatistics : Page
    {
        public SpecificStatistics(DateTime srcSelectedDate)
        {
            InitializeComponent();

            selectedDate = srcSelectedDate;

            _statisticsBUS = new StatisticsBUS();
            _categoryBUS = new CategoryBUS();
            _phoneBUS = new PhoneBUS();

            statisticsCombobox.ItemsSource = statisticsFigureValues;
            statisticsCombobox.SelectedIndex = statisticsFigureIndex;

            bargraphCombobox.ItemsSource = figureValues;
            bargraphCombobox.SelectedIndex = bargraphFigureIndex;

            piechartCombobox.ItemsSource = figureValues;
            piechartCombobox.SelectedIndex = bargraphFigureIndex;

            statisticsDatePicker.SelectedDate = selectedDate;

            chartTabControl.SelectedIndex = tabSelectedIndex;

            categories = _categoryBUS.getCategoryList();
            categoriesCombobox.ItemsSource = categories;
            categoriesCombobox.SelectedIndex = categoriesFigureIndex;

            phones = _phoneBUS.getPhonesAccordingToSpecificCategory(categories[categoriesFigureIndex].ID);
            productCombobox.ItemsSource = phones;
            productCombobox.SelectedIndex = productFigureIndex;

            DataContext = this;
        }

        private StatisticsBUS _statisticsBUS;
        private CategoryBUS _categoryBUS;
        private PhoneBUS _phoneBUS;
        public int statisticsFigureIndex { get; set; } = 1;
        public int bargraphFigureIndex { get; set; } = 0;
        public int piechartFigureIndex { get; set; } = 0;
        public int tabSelectedIndex { get; set; } = 0;
        public int categoriesFigureIndex { get; set; } = 0;
        public int productFigureIndex { get; set; } = 0;
        public DateTime selectedDate { get; set; }
        public List<string> figureValues = new List<string>() { "Daily", "Weekly", "Monthly", "Yearly" };
        public List<string> statisticsFigureValues = new List<string>() { "General", "Specific", "Advanced" };
        public List<Category> categories;
        public List<Phone> phones;

        private void categoriesCombobox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            phones = _phoneBUS.getPhonesAccordingToSpecificCategory(categories[categoriesFigureIndex].ID);
            productCombobox.ItemsSource = phones;
            productFigureIndex = 0;
            productCombobox.SelectedIndex = productFigureIndex;
        }

        private void productCombobox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
