using ProjectMyShop.DTO;
using ProjectMyShop.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
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

            reader.Close();
            return result;
        }

        public List<Category> getCategoryList()
        {
            var sql = "select * from Category;";

            var command = new SqlCommand(sql, _connection);

            var reader = command.ExecuteReader();

            var resultList = new List<Category>();
            while (reader.Read())
            {
                Category category = new Category()
                {
                    ID = (int)reader["ID"],
                    CatName = (string)reader["CatName"],
                };
                resultList.Add(category);
            }
            reader.Close();
            return resultList;
        }
        public void AddCategory(Category cat)
        {
            var sql = "insert into Category(CatName) " +
                "values (@CatName)"; //
            SqlCommand sqlCommand = new SqlCommand(sql, _connection);

            sqlCommand.Parameters.AddWithValue("@CatName", cat.CatName);

            try
            {
                sqlCommand.ExecuteNonQuery();
                System.Diagnostics.Debug.WriteLine($"Inserted {cat.ID} OK");
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine($"Inserted {cat.ID} Fail: " + ex.Message);
            }
        }
        public int GetLastestInsertID()
        {
            string sql = "select ident_current('Category')";
            SqlCommand sqlCommand = new SqlCommand(sql, _connection);
            var resutl = sqlCommand.ExecuteScalar();
            System.Diagnostics.Debug.WriteLine(resutl);
            return System.Convert.ToInt32(sqlCommand.ExecuteScalar());
        }
    }
}
