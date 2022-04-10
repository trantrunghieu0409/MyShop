using System;
using System.Collections.Generic;
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

namespace ProjectMyShop.Views
{
    /// <summary>
    /// Interaction logic for Statistics.xaml
    /// </summary>
    public partial class Statistics : Page
    {
        public Statistics()
        {
            InitializeComponent();

            _statisticsBUS = new StatisticsBUS();

            typeCombobox.ItemsSource = figureValues;
            typeCombobox.SelectedIndex = figureValueIndex;

            statisticsDatePicker.SelectedDate = selectedDate;

            configureGeneral();
            configureCharts();

            DataContext = this;
        }

        private StatisticsBUS _statisticsBUS;

        public List<string> figureValues = new List<string>() { "Daily", "Weekly", "Monthly", "Yearly" };
        public int figureValueIndex { get; set; } = 0;
        public DateTime selectedDate { get; set; } = DateTime.Now;

        public void configureGeneral()
        {
            TotalRevenueTextBlock.Text = _statisticsBUS.getTotalRevenueUntilDate(selectedDate).ToString();
            TotalProfitTextBlock.Text = _statisticsBUS.getTotalProfitUntilDate(selectedDate).ToString();
            TotalOrdersTextBlock.Text = _statisticsBUS.getTotalOrdersUntilDate(selectedDate).ToString();
        }

        public void configureCharts()
        {
            switch (figureValueIndex)
            {
                case 0:
                    var revenueResult = _statisticsBUS.getDailyRevenue(selectedDate);

                    var revenues = new ChartValues<double>();
                    var dates = new List<string>();

                    foreach (var item in revenueResult)
                    {
                        revenues.Add((double)item.Item2);
                        dates.Add(item.Item1.ToString());
                    }

                    var revenueCollection = new SeriesCollection()
                    {
                    new LineSeries
                    {
                        Title = "Revenue: ",
                        Values = revenues
                    }
                    };


                    revenueChart.AxisX.Clear();
                    revenueChart.AxisX.Add(new LiveCharts.Wpf.Axis
                    {
                        Title = "Date",
                        Labels = dates
                    });

                    revenueChart.Series = revenueCollection;
                    break;

                case 1:
                    break;

                case 2:
                    var monthlyRevenueResult = _statisticsBUS.getMonthlyRevenue(selectedDate);

                    var monthlyRevenues = new ChartValues<double>();
                    var months = new List<string>();

                    foreach (var item in monthlyRevenueResult)
                    {
                        months.Add(item.Item1.ToString());
                        monthlyRevenues.Add((double)item.Item2);
                    }

                    var monthlyRevenueCollection = new SeriesCollection()
                    {
                    new ColumnSeries
                    {
                        Title = "Revenue: ",
                        Values = monthlyRevenues
                    }
                    };


                    revenueChart.AxisX.Clear();
                    revenueChart.AxisX.Add(new LiveCharts.Wpf.Axis
                    {
                        Title = "Date",
                        Labels = months
                    });

                    revenueChart.Series = monthlyRevenueCollection;

                    break;
            }
        }

        private void typeCombobox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            configureGeneral();
            configureCharts();
        }

        private void statisticsDatePicker_SelectedDateChanged(object sender, SelectionChangedEventArgs e)
        {
            configureGeneral();
            configureCharts();
        }
    }
}
