using System;
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
        public void ShowUserInterface(LogIn loginForm)
        {
            string name = loginController.GetUserInfo().Name;
            string surname = loginController.GetUserInfo().Surname;
            ClientManagerForm clientManagerForm = new ClientManagerForm();
            clientManagerForm.Show();
            loginForm.Close();
        }
    }
}
