using System;
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
        public void ShowUserInterface(LogIn loginForm)
        {
            string name = loginController.Name;
            string surname = loginController.Surname;
            ContractManagerForm contractManagerForm = new ContractManagerForm();
            contractManagerForm.Show();
            loginForm.Close();
        }
    }
}
