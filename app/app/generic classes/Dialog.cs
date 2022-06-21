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
        private Hashtable _dataToReturn;

        public Dialog()
        {
            _dataToReturn = new Hashtable();
        }

        public  Hashtable GetData()
        {
            return _dataToReturn;
        }
    }
}
