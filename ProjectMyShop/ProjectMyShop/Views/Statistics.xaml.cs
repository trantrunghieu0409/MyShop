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

            revenueCombobox.ItemsSource = figureValues;
            revenueCombobox.SelectedIndex = figureValueIndex;

            profitCombobox.ItemsSource = figureValues;
            profitCombobox.SelectedIndex = figureValueProfitIndex;

            statisticsDatePicker.SelectedDate = selectedDate;
            chartTabControl.SelectedIndex = tabSelectedIndex;

            configureGeneral();
            configureRevenueCharts();

            DataContext = this;
        }

        private StatisticsBUS _statisticsBUS;

        public List<string> figureValues = new List<string>() { "Daily", "Weekly", "Monthly", "Yearly" };
        public int figureValueIndex { get; set; } = 0;
        public int figureValueProfitIndex { get; set; } = 0;
        public int tabSelectedIndex { get; set; } = 0;
        public DateTime selectedDate { get; set; } = DateTime.Now;
        public System.Globalization.CultureInfo info = System.Globalization.CultureInfo.GetCultureInfo("vi-VN");

        public void configureGeneral()
        {
            TotalRevenueTextBlock.Text = _statisticsBUS.getTotalRevenueUntilDate(selectedDate).ToString();
            TotalProfitTextBlock.Text = _statisticsBUS.getTotalProfitUntilDate(selectedDate).ToString();
            TotalOrdersTextBlock.Text = _statisticsBUS.getTotalOrdersUntilDate(selectedDate).ToString();
        }

        public void configureRevenueCharts()
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
                        Values = revenues,
                        LabelPoint = point => String.Format(info, "{0:c}", point.Y)
                    }
                    };


                    revenueChart.AxisX.Clear();
                    revenueChart.AxisX.Add(new LiveCharts.Wpf.Axis
                    {
                        Title = "Date",
                        Labels = dates
                    });

                    revenueChart.AxisY.Clear();
                    revenueChart.AxisY.Add(new LiveCharts.Wpf.Axis
                    {
                        Title = "Revenue",
                        LabelFormatter = x => String.Format(info, "{0:c}", x)
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
                        Values = monthlyRevenues,
                        LabelPoint = point => String.Format(info, "{0:c}", point.Y)
                    }
                    };

                    revenueChart.AxisX.Clear();
                    revenueChart.AxisX.Add(new LiveCharts.Wpf.Axis
                    {
                        Title = "Month",
                        Labels = months
                    });

                    revenueChart.AxisY.Clear();
                    revenueChart.AxisY.Add(new LiveCharts.Wpf.Axis
                    {
                        Title = "Revenue",
                        LabelFormatter = x => String.Format(info, "{0:c}", x)
                    });

                    revenueChart.Series = monthlyRevenueCollection;

                    break;
                case 3:
                    var yearlyRevenueResult = _statisticsBUS.getYearlyRevenue();

                    var yearlyRevenues = new ChartValues<double>();
                    var years = new List<string>();

                    foreach (var item in yearlyRevenueResult)
                    {
                        years.Add(item.Item1.ToString());
                        yearlyRevenues.Add((double)item.Item2);
                    }

                    var yearlyRevenueCollection = new SeriesCollection()
                    {
                    new ColumnSeries
                    {
                        Title = "Revenue: ",
                        Values = yearlyRevenues,
                        LabelPoint = point => String.Format(info, "{0:c}", point.Y)
                    }
                    };


                    revenueChart.AxisX.Clear();
                    revenueChart.AxisX.Add(new LiveCharts.Wpf.Axis
                    {
                        Title = "Year",
                        Labels = years
                    });

                    revenueChart.AxisY.Clear();
                    revenueChart.AxisY.Add(new LiveCharts.Wpf.Axis
                    {
                        Title = "Revenue",
                        LabelFormatter = x => String.Format(info, "{0:c}", x)
                    });

                    revenueChart.Series = yearlyRevenueCollection;

                    break;
            }
        }

        public void configureProfitCharts()
        {
            switch (figureValueProfitIndex)
            {
                case 0:
                    var profitResult = _statisticsBUS.getDailyProfit(selectedDate);

                    var profits = new ChartValues<double>();
                    var dates = new List<string>();

                    foreach (var item in profitResult)
                    {
                        profits.Add((double)item.Item2);
                        dates.Add(item.Item1.ToString());
                    }

                    var profitCollection = new SeriesCollection()
                    {
                    new LineSeries
                    {
                        Title = "Profit: ",
                        Values = profits,
                        LabelPoint = point => String.Format(info, "{0:c}", point.Y)
                    }
                    };


                    profitChart.AxisX.Clear();
                    profitChart.AxisX.Add(new LiveCharts.Wpf.Axis
                    {
                        Title = "Date",
                        Labels = dates
                    });

                    profitChart.AxisY.Clear();
                    profitChart.AxisY.Add(new LiveCharts.Wpf.Axis
                    {
                        Title = "Profit",
                        LabelFormatter = x => String.Format(info, "{0:c}", x)
                    });

                    profitChart.Series = profitCollection;
                    break;

                case 1:
                    break;

                case 2:
                    var monthlyProfitResult = _statisticsBUS.getMonthlyProfit(selectedDate);

                    var monthlyProfits = new ChartValues<double>();
                    var months = new List<string>();

                    foreach (var item in monthlyProfitResult)
                    {
                        months.Add(item.Item1.ToString());
                        monthlyProfits.Add((double)item.Item2);
                    }

                    var monthlyProfitCollection = new SeriesCollection()
                    {
                    new ColumnSeries
                    {
                        Title = "Revenue: ",
                        Values = monthlyProfits,
                        LabelPoint = point => String.Format(info, "{0:c}", point.Y)
                    }
                    };


                    profitChart.AxisX.Clear();
                    profitChart.AxisX.Add(new LiveCharts.Wpf.Axis
                    {
                        Title = "Month",
                        Labels = months
                    });

                    profitChart.AxisY.Clear();
                    profitChart.AxisY.Add(new LiveCharts.Wpf.Axis
                    {
                        Title = "Profit",
                        LabelFormatter = x => String.Format(info, "{0:c}", x)
                    });

                    profitChart.Series = monthlyProfitCollection;

                    break;
                case 3:
                    var yearlyProfitResult = _statisticsBUS.getYearlyProfit();

                    var yearlyProfits = new ChartValues<double>();
                    var years = new List<string>();

                    foreach (var item in yearlyProfitResult)
                    {
                        years.Add(item.Item1.ToString());
                        yearlyProfits.Add((double)item.Item2);
                    }

                    var yearlyProfitCollection = new SeriesCollection()
                    {
                    new ColumnSeries
                    {
                        Title = "Profit: ",
                        Values = yearlyProfits,
                        LabelPoint = point => String.Format(info, "{0:c}", point.Y)
                    }
                    };


                    profitChart.AxisX.Clear();
                    profitChart.AxisX.Add(new LiveCharts.Wpf.Axis
                    {
                        Title = "Year",
                        Labels = years
                    });

                    profitChart.AxisY.Clear();
                    profitChart.AxisY.Add(new LiveCharts.Wpf.Axis
                    {
                        Title = "Profit",
                        LabelFormatter = x => String.Format(info, "{0:c}", x)
                    });

                    profitChart.Series = yearlyProfitCollection;

                    break;
            }
        }

        private void revenueCombobox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            switch (tabSelectedIndex)
            {
                case 0:
                    configureGeneral();
                    configureRevenueCharts();
                    break;
                case 1:
                    configureGeneral();
                    configureProfitCharts();
                    break;
            }
        }

        private void statisticsDatePicker_SelectedDateChanged(object sender, SelectionChangedEventArgs e)
        {
            switch (tabSelectedIndex)
            {
                case 0:
                    configureGeneral();
                    configureRevenueCharts();
                    break;
                case 1:
                    configureGeneral();
                    configureProfitCharts();
                    break;
            }
        }

        private void chartTabControl_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            switch (tabSelectedIndex)
            {
                case 0:
                    configureGeneral();
                    configureRevenueCharts();
                    break;
                case 1:
                    configureGeneral();
                    configureProfitCharts();
                    break;
            }
        }

        private void profitCombobox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
