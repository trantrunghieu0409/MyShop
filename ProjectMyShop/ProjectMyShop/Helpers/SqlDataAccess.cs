﻿using ProjectMyShop.Config;
using ProjectMyShop.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectMyShop.Helpers
{
    public class SqlDataAccess
    {
        protected SqlConnection _connection;
        public SqlDataAccess()
        {
            string? username = AppConfig.GetValue(AppConfig.Username);
            string password = AppConfig.GetPassword();

            string? connectionString = AppConfig.ConnectionString(username, password);
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

    }
}
