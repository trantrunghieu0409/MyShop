using ProjectMyShop.DAO;
using ProjectMyShop.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectMyShop.BUS
{
    internal class OrderBUS
    {
        private OrderDAO _orderDAO;

        public OrderBUS()
        {
            _orderDAO = new OrderDAO();
            if (_orderDAO.CanConnect())
            {
                _orderDAO.Connect();
            }
        }

        public List<Order> GetAllOrders()
        {
            return _orderDAO.GetAllOrders();
        }

        public static string StatusOpen = "Open";
        public static string StatusClose = "Close";
        public static string StatusProgess = "Progress";

        public static string GetStatus(int status)
        {
            switch (status)
            {
                case 0: return OrderBUS.StatusOpen;
                case 1: return OrderBUS.StatusClose;
                default: return OrderBUS.StatusProgess;
            }
        }
        public int GetOrderByWeek()
        {
            return _orderDAO.GetOrderByWeek();
        }
        public int GetOrderByMonth()
        {
            return _orderDAO.GetOrderByMonth();
        }
    }
}
