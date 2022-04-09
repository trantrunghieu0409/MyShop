using ProjectMyShop.DTO;
using ProjectMyShop.Helpers;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
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
                // var VoucherID = (Voucher)reader["VoucherID"];

                Order order = new Order()
                {
                    ID = ID,
                    CustomerName = CustomerName,
                    OrderDate = OrderDate,
                    Status = Status,
                    Address = Address
                };

                if (CustomerName != "")
                    result.Add(order);
            }

            reader.Close();
            return result;
        }
        private void AddDetailOrder(DetailOrder detail)
        {
            var sql = "insert into DetailOrder(OrderID, PhoneID, Quantity) " +
                "values (@OrderID, @PhoneID, @Quantity)";
            SqlCommand sqlCommand = new SqlCommand(sql, _connection);

            sqlCommand.Parameters.AddWithValue("@OrderID", detail.Order.ID);
            sqlCommand.Parameters.AddWithValue("@PhoneID", detail.Phone.ID);
            sqlCommand.Parameters.AddWithValue("@Quantity", detail.Quantity);

            try
            {
                sqlCommand.ExecuteNonQuery();
                System.Diagnostics.Debug.WriteLine($"Inserted {detail.Order.ID} OK");
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine($"Inserted {detail.Order.ID} Fail: " + ex.Message);
            }
        }
        
        public void AddOrder(Order order)
        {
            // ID Auto Increment
            var sql = "insert into Orders(CustomerName, OrderDate, Status, Address) " +
                "values (@CustomerName, @OrderDate, @Status, @Address)"; // Them VoucherID sau
            SqlCommand sqlCommand = new SqlCommand(sql, _connection);

            sqlCommand.Parameters.AddWithValue("@CustomerName", order.CustomerName);
            sqlCommand.Parameters.AddWithValue("@OrderDate", DateTime.Parse(order.OrderDate.ToString()));
            sqlCommand.Parameters.AddWithValue("@Status", order.Status);
            sqlCommand.Parameters.AddWithValue("@Address", order.Address);
            
            try
            {
                sqlCommand.ExecuteNonQuery();
                System.Diagnostics.Debug.WriteLine($"Inserted {order.ID} OK");
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine($"Inserted {order.ID} Fail: " + ex.Message);
            }
        }

        public int GetLastestInsertID()
        {
            string sql = "select ident_current('Orders')";
            SqlCommand sqlCommand = new SqlCommand(sql, _connection);
            var resutl = sqlCommand.ExecuteScalar();
            System.Diagnostics.Debug.WriteLine(resutl);
            return System.Convert.ToInt32(sqlCommand.ExecuteScalar());
        }
        public void DeleteOrder(int orderID)
        {
            var sql = "delete from Orders where ID = @OrderID";
            SqlCommand sqlCommand = new SqlCommand(sql, _connection);

            sqlCommand.Parameters.AddWithValue("@OrderID", orderID);

            try
            {
                sqlCommand.ExecuteNonQuery();
                System.Diagnostics.Debug.WriteLine($"Deleted {orderID} OK");
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine($"Deleted {orderID} Fail: " + ex.Message);
            }
        }
        
        public int CountOrderByWeek()
        {
            string sql = "select count(*) as week from Orders where datediff(day, OrderDate, GETDATE()) < 7";
            var command = new SqlCommand(sql, _connection);

            var reader = command.ExecuteReader();

            int result = 0;

            if (reader.Read())
            {
                result = (int)reader["week"];
            }
            reader.Close();
            return result;
        }
        public int CountOrderByMonth()
        {
            string sql = "select count(*) as month from Orders where datediff(day, OrderDate, GETDATE()) < 30";
            var command = new SqlCommand(sql, _connection);

            var reader = command.ExecuteReader();

            int result = 0;

            if (reader.Read())
            {
                result = (int)reader["month"];
            }
            reader.Close();
            return result;
        }
    }
}
