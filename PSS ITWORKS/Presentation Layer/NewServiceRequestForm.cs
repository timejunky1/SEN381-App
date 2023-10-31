using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PSS_ITWORKS.LogicLayer;
using PSS_ITWORKS.Presentation_Layer;

namespace PSS_ITWORKS.Presentation_Layer
{
    public partial class ServiceRequestForm : Form
    {
        StrategyCallManagement callManagement;
        EntityJob job;
        BindingSource bs;

        public ServiceRequestForm()
        {
            InitializeComponent();
        }

        private void ServiceRequestForm_Load(object sender, EventArgs e)
        {

        }

        private void Submit_btn_Click(object sender, EventArgs e)
        {
            int customerID = int.Parse(CustomerID_txt.Text);
            int contractNumber = int.Parse(ContactNumber_txt.Text);
            string email = EmailAddress_txt.Text;
            string equipSerialNo = EquipmentSerialNumber_txt.Text;
            int selectedIndex = PriorityLevel__cbx.SelectedIndex;
            PriorityLevel__cbx.SelectedItem.ToString();
            int priority = (int)PriorityLevel__cbx.Items[selectedIndex];
            int ServiceTypeIndex = ServiceType_cbx.SelectedIndex;
            ServiceType_cbx.SelectedItem.ToString();
            int serviceType = (int)ServiceType_cbx.Items[ServiceTypeIndex];
            string desc = "Equipment Serial Number: " + equipSerialNo + " " + Description_rbx.Text;


            job = new EntityJob(customerID, serviceType, desc);
            callManagement.Create(job);

            MessageBox.Show("Service Request successfully created");

        }

        private void Close_btn_Click(object sender, EventArgs e)
        {
            this.Close();
            CallForm callForm = new CallForm();
            callForm.ShowDialog();
        }
    }
}
