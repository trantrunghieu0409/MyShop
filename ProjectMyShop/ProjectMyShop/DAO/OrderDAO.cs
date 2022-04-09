using ProjectMyShop.DTO;
using ProjectMyShop.Helpers;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectMyShop.DAO
{
    internal class OrderDAO: SqlDataAccess
    {
        public List<Order> GetAllOrders()
        {
            var sql = "select * from Orders";
            var command = new SqlCommand(sql, _connection);

            var reader = command.ExecuteReader();

            List<Order>? result = new List<Order>();

            while (reader.Read())
            {
                var ID = (int)reader["ID"];    
                var CustomerName = (String)reader["CustomerName"];
                var OrderDate = DateOnly.Parse(DateTime.Parse(reader["OrderDate"].ToString()).Date.ToShortDateString());
                var Status = (System.Int16)reader["Status"];
                var Address = (String)reader["Address"];
                var OrderMethod = (System.Int16)reader["OrderMethod"];
                // var VoucherID = (Voucher)reader["VoucherID"];

                Order order = new Order()
                {
                    ID = ID,
                    CustomerName = CustomerName,
                    OrderDate = OrderDate,
                    OrderMethod = OrderMethod,
                    Status = Status,
                    Address = Address
                };

                if (CustomerName != "")
                    result.Add(order);
            }

            reader.Close();
            return result;
        }
    }
}
