﻿using ProjectMyShop.DAO;
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
        public List<Order> GetOrders(int offset, int size)
        {
            return _orderDAO.GetOrders(offset, size);
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

        public void AddOrder(Order order)
        {
            _orderDAO.AddOrder(order);
            order.ID = _orderDAO.GetLastestInsertID();
        }

        public void DeleteOrder(int orderID)
        {
            if (orderID > -1)
            {
                _orderDAO.DeleteOrder(orderID);
            }
        }

        public int CountOrders()
        {
            return _orderDAO.CountOrders();
        }
        public int CountOrderByWeek()
        {
            return _orderDAO.CountOrderByWeek();
        }
        public int CountOrderByMonth()
        {
            return _orderDAO.CountOrderByMonth();
        }
    }
}
