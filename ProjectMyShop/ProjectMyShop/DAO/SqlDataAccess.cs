using ProjectMyShop.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectMyShop.DAO
{
    public class SqlDataAccess
    {
        private SqlConnection _connection;
        public SqlDataAccess(string connectionString)
        {
            _connection = new SqlConnection(connectionString);
        }

        /// <summary>
        /// Kiểm tra xem có thể kết nối hay không
        /// </summary>
        /// <returns></returns>
        public bool CanConnect()
        {
            bool result = true;

            try
            {
                _connection.Open();
                _connection.Close();
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine(ex.Message); 
                result = false;
            }
            return result;
        }

        public void Connect()
        {
            _connection.Open();
        }

        public Category GetCategoryById(int id)
        {
            var sql = "select * from Category where category_id=@CatId";
            var command = new SqlCommand(sql, _connection);

            command.Parameters.Add("CatId", SqlDbType.Int).Value = id;

            var reader = command.ExecuteReader();

            Category? result = null;

            if (reader.Read()) // ORM - Object relational mapping
            {
                var catId = (int)reader["category_id"];
                var catName = (string)reader["category_name"];

                result = new Category()
                {
                    ID = catId,
                    CatName = catName,
                };
            }

            return result;
        }
    }
}
