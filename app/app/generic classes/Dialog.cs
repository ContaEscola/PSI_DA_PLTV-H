using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace app
{
    public class Dialog : Form
    {
        protected object _dataToReturn;

        public  object GetData()
        {
            return _dataToReturn;
        }
    }
}
