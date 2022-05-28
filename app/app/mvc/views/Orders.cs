using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace app
{
    public partial class Orders : Form
    {
        public Orders()
        {
            InitializeComponent();

            Lbl_AddOrder.BringToFront();
            Lbl_AddItem.BringToFront();
            Lbl_AddPaymentMethod.BringToFront();
        }
    }
}
