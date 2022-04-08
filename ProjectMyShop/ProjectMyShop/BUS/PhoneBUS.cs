﻿using ProjectMyShop.DAO;
using System;
using System.Collections.Generic;
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
    }
}
