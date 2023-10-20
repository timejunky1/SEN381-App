using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PSS_ITWORKS.LogicLayer
{
    static internal class ErrorHandler
    {
        internal static void DisplayError(string message)
        {
            MessageBox.Show(message);
        }
    }
}
