﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PSS_ITWORKS.Presentation_Layer;

namespace PSS_ITWORKS.LogicLayer.FactoryMethod
{
    class FactoryCClientManagerDetails : FactoryIUser
    {
        private LoginController loginController;

        public FactoryCClientManagerDetails(LoginController loginController)
        {
            this.loginController = loginController;
        }
        public void ShowUserInterface(Dashboard dashboard, LoginController.UserInfo userInfo)
        {
            string name = loginController.GetUserInfo().Name;
            string surname = loginController.GetUserInfo().Surname;
            ClientManagerForm clientManagerForm = new ClientManagerForm(dashboard, userInfo);
            clientManagerForm.Show();
            dashboard.Hide();
        }
    }
}
