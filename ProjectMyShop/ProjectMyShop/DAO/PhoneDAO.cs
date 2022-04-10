using ProjectMyShop.Helpers;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjectMyShop.DTO;

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

                var SoldPrice = (int)(decimal)reader["SoldPrice"];
                //var SoldPrice = (int)reader["SoldPrice"];
                var Stock = (int)reader["Stock"];

                Phone phone = new Phone()
                {
                    ID = ID,
                    PhoneName = PhoneName,
                    Manufacturer = Manufacturer,
                    SoldPrice = SoldPrice,
                    Stock = Stock,
                };
                if (phone.PhoneName != "")
                    list.Add(phone);
            }
            reader.Close();
            return list;
        }

        public List<Phone> getPhonesAccordingToSpecificCategory(int srcCategoryID)
        {
            var sql = "select * from Phone where CatID = @CategoryID";

            var sqlParameter = new SqlParameter();
            sqlParameter.ParameterName = "@CategoryID";
            sqlParameter.Value = srcCategoryID;

            var command = new SqlCommand(sql, _connection);
            command.Parameters.Add(sqlParameter);

            var reader = command.ExecuteReader();

            List<Phone> list = new List<Phone>();
            while (reader.Read())
            {
                var ID = (int)reader["ID"];
                var PhoneName = (String)reader["PhoneName"];
                var Manufacturer = (String)reader["Manufacturer"];

                var SoldPrice = (int)(decimal)reader["SoldPrice"];
                //var SoldPrice = (int)reader["SoldPrice"];
                var Stock = (int)reader["Stock"];

                Phone phone = new Phone()
                {
                    ID = ID,
                    PhoneName = PhoneName,
                    Manufacturer = Manufacturer,
                    SoldPrice = SoldPrice,
                    Stock = Stock,
                };
                if (phone.PhoneName != "")
                    list.Add(phone);
            }
            reader.Close();
            return list;
        }

        public void addPhone(Phone phone)
        {
            // ID Auto Increment
            var sql = "insert into Phones(PhoneName, Manufacturer, BoughtPrice, SoldPrice, Description) " +
                "values (@PhoneName, @Manufacturer, @BoughtPrice, @Description)"; //
            SqlCommand sqlCommand = new SqlCommand(sql, _connection);

            sqlCommand.Parameters.AddWithValue("@PhoneName", phone.PhoneName);
            sqlCommand.Parameters.AddWithValue("@Manufacturer", phone.Manufacturer);
            sqlCommand.Parameters.AddWithValue("@BoughtPrice", phone.BoughtPrice);
            sqlCommand.Parameters.AddWithValue("@Description", phone.Description);

            try
            {
                sqlCommand.ExecuteNonQuery();
                System.Diagnostics.Debug.WriteLine($"Inserted {phone.ID} OK");
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine($"Inserted {phone.ID} Fail: " + ex.Message);
            }
        }

        public int GetLastestInsertID()
        {
            string sql = "select ident_current('Phones')";
            SqlCommand sqlCommand = new SqlCommand(sql, _connection);
            var resutl = sqlCommand.ExecuteScalar();
            System.Diagnostics.Debug.WriteLine(resutl);
            return System.Convert.ToInt32(sqlCommand.ExecuteScalar());
        }
    }
}
