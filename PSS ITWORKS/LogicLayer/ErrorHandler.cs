using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PSS_ITWORKS.LogicLayer
{
    static internal class ErrorHandler
    {
        internal static void DisplayError(Exception ex)
        {
            MessageBox.Show(ex.Message+ "\n"+ ex.TargetSite + "\n" + ex.StackTrace);
        }

        internal static void DisplayError(string message)
        {
            MessageBox.Show(message);
        }
    }
}
