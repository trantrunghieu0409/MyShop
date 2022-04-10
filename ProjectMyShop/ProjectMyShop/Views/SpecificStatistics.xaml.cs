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
using LiveCharts;
using LiveCharts.Wpf;
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

            categories = _categoryBUS.getCategoryList();
            categoriesCombobox.ItemsSource = categories;

            phones = _phoneBUS.getPhonesAccordingToSpecificCategory(categories[categoriesFigureIndex].ID);
            productCombobox.ItemsSource = phones;

            statisticsCombobox.ItemsSource = statisticsFigureValues;
            statisticsCombobox.SelectedIndex = statisticsFigureIndex;

            bargraphCombobox.ItemsSource = figureValues;
            bargraphCombobox.SelectedIndex = bargraphFigureIndex;

            piechartCombobox.ItemsSource = figureValues;
            piechartCombobox.SelectedIndex = bargraphFigureIndex;

            statisticsDatePicker.SelectedDate = selectedDate;

            chartTabControl.SelectedIndex = tabSelectedIndex;

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

        public void configureBarGraphs()
        {
            switch (bargraphFigureIndex)
            {
                case 0:
                    var productResult = _statisticsBUS.getDailyQuantityOfSpecificProduct(phones[productFigureIndex].ID, categories[categoriesFigureIndex].ID, selectedDate);

                    var quantity = new ChartValues<int>();
                    var dates = new List<string>();

                    foreach (var item in productResult)
                    {
                        quantity.Add((int)item.Item2);
                        dates.Add(item.Item1.ToString());
                    }

                    var quantityCollection = new SeriesCollection()
                    {
                    new RowSeries
                    {
                        Title = "Quantity: ",
                        Values = quantity,
                    }
                    };


                    productBarGraph.AxisY.Clear();
                    productBarGraph.AxisY.Add(new LiveCharts.Wpf.Axis
                    {
                        Title = "Date",
                        Labels = dates
                    });

                    productBarGraph.AxisX.Clear();
                    productBarGraph.AxisX.Add(new LiveCharts.Wpf.Axis
                    {
                        Title = "Quantity",
                        LabelFormatter = x => x.ToString("N0")

                    });

                    productBarGraph.Series = quantityCollection;
                    break;
                case 1:
                    break;
                case 2:
                    var monthlyProductResult = _statisticsBUS.getMonthlyQuantityOfSpecificProduct(phones[productFigureIndex].ID, categories[categoriesFigureIndex].ID, selectedDate);

                    var monthlyQuantity = new ChartValues<int>();
                    var months = new List<string>();

                    foreach (var item in monthlyProductResult)
                    {
                        monthlyQuantity.Add((int)item.Item2);
                        months.Add(item.Item1.ToString());
                    }

                    var monthlyQuantityCollection = new SeriesCollection()
                    {
                    new ColumnSeries
                    {
                        Title = "Quantity: ",
                        Values = monthlyQuantity,
                    }
                    };


                    productBarGraph.AxisX.Clear();
                    productBarGraph.AxisX.Add(new LiveCharts.Wpf.Axis
                    {
                        Title = "Month",
                        Labels = months
                    });

                    productBarGraph.AxisY.Clear();
                    productBarGraph.AxisY.Add(new LiveCharts.Wpf.Axis
                    {
                        Title = "Quantity",
                        LabelFormatter = x => x.ToString("N0")

                    });

                    productBarGraph.Series = monthlyQuantityCollection;
                    break;
                case 3:
                    break;
            }
        }

        private void categoriesCombobox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            phones = _phoneBUS.getPhonesAccordingToSpecificCategory(categories[categoriesFigureIndex].ID);
            productCombobox.ItemsSource = phones;

            if (phones.Count > 0)
            {
                productFigureIndex = 0;
                productCombobox.SelectedIndex = productFigureIndex;
            }
        }

        private void productCombobox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (productFigureIndex != -1)
            {
                configureBarGraphs();
            }
        }

        private void bargraphCombobox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (categoriesFigureIndex != -1 && productFigureIndex != -1)
            {
                configureBarGraphs();
            }
        }

        private void statisticsDatePicker_SelectedDateChanged(object sender, SelectionChangedEventArgs e)
        {
            configureBarGraphs();
        }
    }
}
