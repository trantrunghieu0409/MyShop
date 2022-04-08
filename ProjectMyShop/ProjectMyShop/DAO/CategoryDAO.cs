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
    internal class CategoryDAO : SqlDataAccess
    {
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
