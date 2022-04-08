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
            if (_dao.CanConnect())
            {
                _dao.Connect();
            }
        }

        public Category GetCategoryById(int id)
        {
            Category result = _dao.GetCategoryById(id);

            return result;
        }
        public int GetTotalPhone()
        {
            return _dao.getTotalPhone();
        }
    }
}
