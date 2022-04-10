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

        public List<Tuple<string, decimal>> getMonthlyRevenue(DateTime src)
        {
            string sqlFormattedDate = src.ToString("yyyy");

            var sql = "WITH Months as (select month(GETDATE()) as Monthnumber, datename(month, GETDATE()) as NameOfMonth, 1 as number union all select month(dateadd(month, number, (GETDATE()))) Monthnumber, datename(month, dateadd(month, number, (GETDATE()))) as NameOfMonth, number + 1  from Months  where number < 12) select NameOfMonth, Revenue from Months left join (select datepart(month, o.OrderDate) as OrderMonth, cast(SUM(do.Quantity * p.SoldPrice) AS decimal(13, 4)) as Revenue from DetailOrder do join Phone p on do.PhoneID = p.ID join Orders o on do.OrderID = o.ID where datepart(year, o.OrderDate) = @SelectedYear group by datepart(month, o.OrderDate)) MonthlyRevenue on Months.Monthnumber = MonthlyRevenue.OrderMonth order by Monthnumber;";
            var sqlParameter = new SqlParameter();
            sqlParameter.ParameterName = "@SelectedYear";
            sqlParameter.Value = sqlFormattedDate;

            var command = new SqlCommand(sql, _connection);
            command.Parameters.Add(sqlParameter);

            var reader = command.ExecuteReader();

            var resultList = new List<Tuple<string, decimal>>();
            while (reader.Read())
            {
                string monthName = (string)reader["NameOfMonth"];
                decimal monthValue = 0;
                
                if (reader["Revenue"].GetType() != typeof(DBNull))
                {
                    monthValue = (decimal)reader["Revenue"];
                }

                resultList.Add(Tuple.Create(monthName, (decimal)monthValue));
            }
            reader.Close();
            return resultList;
        }

        public List<Tuple<string, decimal>> getYearlyRevenue()
        {
            var sql = "select convert(varchar, datepart(year, o.OrderDate)) as OrderYear, cast(SUM(do.Quantity * SoldPrice) AS decimal(13,4)) as Revenue from DetailOrder do join Phone p on do.PhoneID = p.ID join Orders o on do.OrderID = o.ID group by datepart(year, o.OrderDate) order by datepart(year, o.OrderDate) asc;";

            var command = new SqlCommand(sql, _connection);

            var reader = command.ExecuteReader();

            var resultList = new List<Tuple<string, decimal>>();
            while (reader.Read())
            {
                var tuple = Tuple.Create((string)reader["OrderYear"], (decimal)reader["Revenue"]);
                resultList.Add(tuple);
            }
            reader.Close();
            return resultList;
        }

        public List<Tuple<string, decimal>> getDailyProfit(DateTime src)
        {
            string sqlFormattedDate = src.ToString("yyyy-MM-dd");

            var sql = "select convert(varchar, o.OrderDate) as OrderDate, cast(SUM(do.Quantity * (p.SoldPrice - p.BoughtPrice)) AS decimal(13,4)) as Profit from DetailOrder do join Phone p on do.PhoneID = p.ID join Orders o on do.OrderID = o.ID where OrderDate < @SelectedDate group by o.OrderDate order by o.OrderDate asc;";
            var sqlParameter = new SqlParameter();
            sqlParameter.ParameterName = "@SelectedDate";
            sqlParameter.Value = sqlFormattedDate;

            var command = new SqlCommand(sql, _connection);
            command.Parameters.Add(sqlParameter);

            var reader = command.ExecuteReader();

            var resultList = new List<Tuple<string, decimal>>();
            while (reader.Read())
            {
                var tuple = Tuple.Create((string)reader["OrderDate"], (decimal)reader["Profit"]);
                resultList.Add(tuple);
            }
            reader.Close();
            return resultList;
        }

        public List<Tuple<string, decimal>> getMonthlyProfit(DateTime src)
        {
            string sqlFormattedDate = src.ToString("yyyy");

            var sql = "WITH Months as (select month(GETDATE()) as Monthnumber, datename(month, GETDATE()) as NameOfMonth, 1 as number union all select month(dateadd(month, number, (GETDATE()))) Monthnumber, datename(month, dateadd(month, number, (GETDATE()))) as NameOfMonth, number + 1  from Months  where number < 12) select NameOfMonth, Profit from Months left join (select datepart(month, o.OrderDate) as OrderMonth, cast(SUM(do.Quantity * (p.SoldPrice - p.BoughtPrice)) AS decimal(13, 4)) as Profit from DetailOrder do join Phone p on do.PhoneID = p.ID join Orders o on do.OrderID = o.ID where datepart(year, o.OrderDate) = @SelectedYear group by datepart(month, o.OrderDate)) MonthlyProfit on Months.Monthnumber = MonthlyProfit.OrderMonth order by Monthnumber;";
            var sqlParameter = new SqlParameter();
            sqlParameter.ParameterName = "@SelectedYear";
            sqlParameter.Value = sqlFormattedDate;

            var command = new SqlCommand(sql, _connection);
            command.Parameters.Add(sqlParameter);

            var reader = command.ExecuteReader();

            var resultList = new List<Tuple<string, decimal>>();
            while (reader.Read())
            {
                string monthName = (string)reader["NameOfMonth"];
                decimal monthValue = 0;

                if (reader["Profit"].GetType() != typeof(DBNull))
                {
                    monthValue = (decimal)reader["Profit"];
                }

                resultList.Add(Tuple.Create(monthName, (decimal)monthValue));
            }
            reader.Close();
            return resultList;
        }

        public List<Tuple<string, decimal>> getYearlyProfit()
        {
            var sql = "select convert(varchar, datepart(year, o.OrderDate)) as OrderYear, cast(SUM(do.Quantity * (p.SoldPrice - p.BoughtPrice)) AS decimal(13,4)) as Profit from DetailOrder do join Phone p on do.PhoneID = p.ID join Orders o on do.OrderID = o.ID group by datepart(year, o.OrderDate) order by datepart(year, o.OrderDate) asc;";

            var command = new SqlCommand(sql, _connection);

            var reader = command.ExecuteReader();

            var resultList = new List<Tuple<string, decimal>>();
            while (reader.Read())
            {
                var tuple = Tuple.Create((string)reader["OrderYear"], (decimal)reader["Profit"]);
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
