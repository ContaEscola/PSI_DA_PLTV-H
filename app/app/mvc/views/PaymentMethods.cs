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
    public partial class PaymentMethods : Form
    {
        private FontLoader _fontLoader;

        public PaymentMethods()
        {
            InitializeComponent();

            _fontLoader = new FontLoader();
        }

        //Irá dar load das fontes nos controlos
        private void PaymentMethods_Load(object sender, EventArgs e)
        {
            Dictionary<Control, string> fontsForControls = new Dictionary<Control, string>();

            fontsForControls.Add(Lbl_PaymentMethods, FontLoader.RobotoSlabBold);

            fontsForControls.Add(Lbl_AddPaymentMethod, FontLoader.RobotoSlabLight);

            fontsForControls.Add(Lbl_NewPaymentMethodName, FontLoader.RobotoSlabRegular);
            fontsForControls.Add(TxtBox_NewPaymentMethodName, FontLoader.RobotoSlabRegular);

            fontsForControls.Add(Lbl_NewPaymentMethodState, FontLoader.RobotoSlabRegular);
            fontsForControls.Add(ComboBox_NewPaymentMethodState, FontLoader.RobotoSlabRegular);

            fontsForControls.Add(Btn_AddPaymentMethod, FontLoader.RobotoSlabRegular);



            fontsForControls.Add(Lbl_EditPaymentMethod, FontLoader.RobotoSlabLight);

            fontsForControls.Add(Lbl_PaymentMethodName, FontLoader.RobotoSlabRegular);
            fontsForControls.Add(TxtBox_PaymentMethodName, FontLoader.RobotoSlabRegular);

            fontsForControls.Add(Lbl_PaymentMethodState, FontLoader.RobotoSlabRegular);
            fontsForControls.Add(ComboBox_PaymentMethodState, FontLoader.RobotoSlabRegular);

            fontsForControls.Add(Btn_SaveChangesOnPaymentMethod, FontLoader.RobotoSlabRegular);

            
            
            FontFamily fontForDataGrid = _fontLoader.GetFont(FontLoader.RobotoSlabRegular);
            DataGridView_PaymentMethods.ColumnHeadersDefaultCellStyle.Font = new Font(fontForDataGrid, DataGridView_PaymentMethods.ColumnHeadersDefaultCellStyle.Font.Size);
            DataGridView_PaymentMethods.DefaultCellStyle.Font = new Font(fontForDataGrid, DataGridView_PaymentMethods.DefaultCellStyle.Font.Size);

            _fontLoader.LoadFontToControls(fontsForControls);

            Lbl_AddPaymentMethod.BringToFront();
            Lbl_EditPaymentMethod.BringToFront();



        }
    }
}
