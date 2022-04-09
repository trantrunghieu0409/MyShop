using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjectMyShop.Helpers;
using System.Data.SqlClient;

namespace ProjectMyShop.DAO
{
    internal class StatisticsDAO : SqlDataAccess
    {
        public string getTotalRevenueUntilDate(DateTime src)
        {
            string sqlFormattedDate = src.ToString("yyyy-MM-dd");

            var sql = "select convert(varchar,cast(SUM(do.Quantity * p.SoldPrice) as money), 1) as Revenue from DetailOrder do join Phone p on do.PhoneID = p.ID join Orders o on do.OrderID = o.ID where OrderDate < @SelectedDate;";
            var sqlParameter = new SqlParameter();
            sqlParameter.ParameterName = "@SelectedDate";
            sqlParameter.Value = sqlFormattedDate;

            var command = new SqlCommand(sql, _connection);
            command.Parameters.Add(sqlParameter);

            var reader = command.ExecuteReader();

            string result = "0";
            if (reader.Read())
            {
                result = (string)reader["Revenue"];
            }
            reader.Close();
            return result.ToString();
        }

        public string getTotalProfitUntilDate(DateTime src)
        {
            string sqlFormattedDate = src.ToString("yyyy-MM-dd");

            var sql = "select convert(varchar,cast(SUM(do.Quantity *(p.SoldPrice - p.BoughtPrice)) as money), 1) as Profit from DetailOrder do join Phone p on do.PhoneID = p.ID join Orders o on do.OrderID = o.ID where OrderDate < @SelectedDate;";
            var sqlParameter = new SqlParameter();
            sqlParameter.ParameterName = "@SelectedDate";
            sqlParameter.Value = sqlFormattedDate;

            var command = new SqlCommand(sql, _connection);
            command.Parameters.Add(sqlParameter);

            var reader = command.ExecuteReader();

            string result = "0";
            if (reader.Read())
            {
                result = (string)reader["Profit"];
            }
            reader.Close();
            return result.ToString();
        }

        public int getTotalOrdersUntilDate(DateTime src)
        {
            string sqlFormattedDate = src.ToString("yyyy-MM-dd");

            var sql = "select COUNT(ID) as Orders from Orders where OrderDate < @SelectedDate;";
            var sqlParameter = new SqlParameter();
            sqlParameter.ParameterName = "@SelectedDate";
            sqlParameter.Value = sqlFormattedDate;

            var command = new SqlCommand(sql, _connection);
            command.Parameters.Add(sqlParameter);

            var reader = command.ExecuteReader();

            int result = 0;
            if (reader.Read())
            {
                result = (int)reader["Orders"];
            }
            reader.Close();
            return result;
        }

        public List<Tuple<string, decimal>> getDailyRevenue(DateTime src)
        {
            string sqlFormattedDate = src.ToString("yyyy-MM-dd");

            //var sql = "select convert(varchar, o.OrderDate) as OrderDate, convert(varchar,cast(SUM(do.Quantity * p.SoldPrice) as money), 1) as Revenue from DetailOrder do join Phone p on do.PhoneID = p.ID join Orders o on do.OrderID = o.ID where OrderDate < @SelectedDate group by o.OrderDate order by o.OrderDate asc;";
            var sql = "select convert(varchar, o.OrderDate) as OrderDate, cast(SUM(do.Quantity * p.SoldPrice) AS decimal(13,4)) as Revenue from DetailOrder do join Phone p on do.PhoneID = p.ID join Orders o on do.OrderID = o.ID where OrderDate < @SelectedDate group by o.OrderDate order by o.OrderDate asc;";
            var sqlParameter = new SqlParameter();
            sqlParameter.ParameterName = "@SelectedDate";
            sqlParameter.Value = sqlFormattedDate;

            var command = new SqlCommand(sql, _connection);
            command.Parameters.Add(sqlParameter);

            var reader = command.ExecuteReader();

            var resultList = new List<Tuple<string, decimal>>();
            while (reader.Read())
            {
                var tuple = Tuple.Create((string)reader["OrderDate"], (decimal)reader["Revenue"]);
                resultList.Add(tuple);
            }
            reader.Close();
            return resultList;
        }

        //public Tuple<List<string>, List<string>> getDailyRevenue(DateTime src)
        //{
        //    string sqlFormattedDate = src.ToString("yyyy-MM-dd");

        //    var sql = "select convert(varchar, o.OrderDate) as OrderDate, convert(varchar, cast(SUM(do.Quantity) as money), 1) as Revenue from DetailOrder do join Phone p on do.PhoneID = p.ID join Orders o on do.OrderID = o.ID where OrderDate < @SelectedDate group by o.OrderDate order by o.OrderDate asc;";
        //    var sqlParameter = new SqlParameter();
        //    sqlParameter.ParameterName = "@SelectedDate";
        //    sqlParameter.Value = sqlFormattedDate;

        //    var command = new SqlCommand(sql, _connection);
        //    command.Parameters.Add(sqlParameter);

        //    var reader = command.ExecuteReader();

        //    List<string> dateList = new List<string>();
        //    List<string> revenueList = new List<string>();
            
            
        //    if (reader.Read())
        //    {
        //        dateList.Add((string)reader["OrderDate"]);
        //        revenueList.Add((string)reader["Revenue"]);
                
        //    }
        //    reader.Close();
        //    var mergedList = Tuple.Create(dateList, revenueList);
        //    return mergedList;
        //}
    }
}
