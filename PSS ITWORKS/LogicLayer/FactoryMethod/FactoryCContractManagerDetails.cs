﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PSS_ITWORKS.Presentation_Layer;

namespace PSS_ITWORKS.LogicLayer.FactoryMethod
{
    class FactoryCContractManagerDetails : FactoryIUser
    {
        private LoginController loginController;

        public FactoryCContractManagerDetails(LoginController loginController)
        {
            this.loginController = loginController;
        }
        public void ShowUserInterface(Dashboard dashboard, LoginController.UserInfo userInfo)
        {
            string name = loginController.GetUserInfo().Name;
            string surname = loginController.GetUserInfo().Surname;
            ContractManagerForm contractManagerForm = new ContractManagerForm(dashboard, userInfo);
            contractManagerForm.Show();
            dashboard.Hide();
        }
    }
}
