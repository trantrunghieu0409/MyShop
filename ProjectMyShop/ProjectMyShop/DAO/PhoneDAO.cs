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
        public PhoneDAO() : base() {}

        public int getTotalPhone()
        {
            var sql = "select count(*) as total from Phone";
            var command = new SqlCommand(sql, _connection);
            var reader = command.ExecuteReader();
            if (reader.Read())
            {
                return (int)reader["total"];
            }
            return 0;
        }
    }
}
