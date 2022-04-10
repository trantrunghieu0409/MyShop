using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjectMyShop.DAO;

namespace ProjectMyShop.BUS
{
    internal class StatisticsBUS
    {
        private StatisticsDAO _statisticsDAO;

        public StatisticsBUS()
        {
            _statisticsDAO = new StatisticsDAO();
            if (_statisticsDAO.CanConnect())
            {
                _statisticsDAO.Connect();
            }
        }

        public string getTotalRevenueUntilDate(DateTime src)
        {
            return _statisticsDAO.getTotalRevenueUntilDate(src);
        }

        public string getTotalProfitUntilDate(DateTime src)
        {
            return _statisticsDAO.getTotalProfitUntilDate(src);
        }

        public int getTotalOrdersUntilDate(DateTime src)
        {
            return _statisticsDAO.getTotalOrdersUntilDate(src);
        }

        public List<Tuple<string, decimal>> getDailyRevenue(DateTime src)
        {
            return _statisticsDAO.getDailyRevenue(src);
        }

        public List<Tuple<string, decimal>> getMonthlyRevenue(DateTime src)
        {
            return _statisticsDAO.getMonthlyRevenue(src);
        }

        public List<Tuple<string, decimal>> getYearlyRevenue()
        {
            return _statisticsDAO.getYearlyRevenue();
        }

        //public Tuple<List<string>, List<string>> getDailyRevenue(DateTime src)
        //{
        //    return _statisticsDAO.getDailyRevenue(src);
        //}
    }
}
