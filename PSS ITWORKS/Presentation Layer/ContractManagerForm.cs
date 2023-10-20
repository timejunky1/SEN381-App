using PSS_ITWORKS.LogicLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PSS_ITWORKS.Presentation_Layer
{
    public partial class ContractManagerForm : Form
    {
        StrategyContextManager context;
        public ContractManagerForm()
        {
            InitializeComponent();
            context = new StrategyContextManager(new StrategyContractManager());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            context.Update(new EntityContract(1,"ewqw",2,2,2,"unavailable"));
            context.Get();
        }
    }
}
