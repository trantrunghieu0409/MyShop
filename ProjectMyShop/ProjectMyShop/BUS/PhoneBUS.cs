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

        public List<Phone> getPhonesAccordingToSpecificCategory(int srcCategoryID)
        {
            return _phoneDAO.getPhonesAccordingToSpecificCategory(srcCategoryID);
        }

        public void addPhone(Phone phone)
        {
            phone.UploadDate = DateTime.Now.Date;
            _phoneDAO.addPhone(phone);
            phone.ID = _phoneDAO.GetLastestInsertID();
        }
        public void removePhone(Phone phone)
        {
            _phoneDAO.deletePhone(phone.ID);
        }
        public void updatePhone(int ID, Phone phone)
        {
            _phoneDAO.updatePhone(ID, phone);
        }
    }
}
