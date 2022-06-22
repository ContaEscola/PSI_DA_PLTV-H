using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace app
{
    internal class Resets
    {
        public static void ResetSelectedIndex(Control control, int overrideSelectedIndex = -2)
        {
            int defaultIndex = -1;
            if (overrideSelectedIndex != -2)
                defaultIndex = overrideSelectedIndex;

            if(control is ComboBox)
                    ((ComboBox)control).SelectedIndex = defaultIndex;
            else if (control is ListBox)
                    ((ListBox)control).SelectedIndex = defaultIndex;
          
        
        }
    }
}
