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
    }
}
