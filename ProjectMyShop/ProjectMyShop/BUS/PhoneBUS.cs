using ProjectMyShop.DAO;
using ProjectMyShop.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectMyShop.BUS
{
    internal class PhoneBUS
    {
        private PhoneDAO _phoneDAO;

        public PhoneBUS() {
            _phoneDAO = new PhoneDAO();
            if (_phoneDAO.CanConnect())
            {
                _phoneDAO.Connect();
            }
        }

        public int GetTotalPhone()
        {
            return _phoneDAO.getTotalPhone();
        }
        public List<Phone> Top5OutStock()
        {
            return _phoneDAO.GetTop5OutStock();
        }

        public BindingList<Phone> getPhonesAccordingToSpecificCategory(int srcCategoryID)
        {
            return _phoneDAO.getPhonesAccordingToSpecificCategory(srcCategoryID);
        }

        public void addPhone(Phone phone)
        {
            _phoneDAO.addPhone(phone);
            phone.ID = _phoneDAO.GetLastestInsertID();
        }
    }
}
