using ProjectMyShop.DTO;
using ProjectMyShop.Helpers;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectMyShop.DAO
{
    internal class PhoneDAO : SqlDataAccess
    {
        public int getTotalPhone()
        {
            var sql = "select count(*) as total from Phone";
            var command = new SqlCommand(sql, _connection);
            var reader = command.ExecuteReader();
            int result = 0;
            if (reader.Read())
            {
                result = (int)reader["total"];
            }
            reader.Close();
            return result;
        }

        public List<Phone> GetTop5OutStock()
        {
            var sql = "select top(5) * from Phone order by stock desc";
            var command = new SqlCommand(sql, _connection);
            var reader = command.ExecuteReader();

            List<Phone> list = new List<Phone>();
            while (reader.Read())
            {
                var ID = (int)reader["ID"];
                var PhoneName = (String)reader["PhoneName"];
                var Manufacturer = (String)reader["Manufacturer"];
                var SoldPrice = (int)reader["SoldPrice"];
                var Stock = (int)reader["Stock"];

                Phone phone = new Phone()
                {
                    ID = ID,
                    PhoneName = PhoneName,
                    Manufacturer = Manufacturer,
                    SoldPrice = SoldPrice,
                    Stock = Stock,
                };
                if(phone.PhoneName != "")
                    list.Add(phone);
            }
            reader.Close();
            return list;
        }
    }
}
