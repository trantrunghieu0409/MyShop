using ProjectMyShop.DAO;
using ProjectMyShop.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectMyShop.BUS
{
    internal class CategoryBUS
    {

        private CategoryDAO _categoryDAO;

        public CategoryBUS()
        {
            _categoryDAO = new CategoryDAO();
            if (_categoryDAO.CanConnect())
            {
                _categoryDAO.Connect();
            }
        }

        public Category GetCategoryById(int id)
        {
            Category result = _categoryDAO.GetCategoryById(id);

            return result;
        }

        public List<Category> getCategoryList()
        {
            return _categoryDAO.getCategoryList();
        }
    }
}
