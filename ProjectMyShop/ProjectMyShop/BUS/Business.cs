using ProjectMyShop.DAO;
using ProjectMyShop.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectMyShop.BUS
{
    public class Business
    {

        SqlDataAccess _dao;

        public Business(SqlDataAccess dao)
        {
            _dao = dao;
        }

        public Category GetCategoryById(int id)
        {
            Category result = _dao.GetCategoryById(id);

            return result;
        }
    }
}
