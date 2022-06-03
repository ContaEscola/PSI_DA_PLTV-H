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
        private FontLoader _fontLoader;

        public Orders()
        {
            InitializeComponent();

            _fontLoader = new FontLoader();

            
        }

        //Irá dar load das fontes em todos os controlos do form
        private void Orders_Load(object sender, EventArgs e)
        {
            Dictionary<Control, string> fontsForControls = new Dictionary<Control, string>();

            fontsForControls.Add(Lbl_Orders, FontLoader.RobotoSlabBold);
            fontsForControls.Add(Lbl_Restaurant, FontLoader.RobotoSlabExtraLight);
            fontsForControls.Add(Lbl_RestaurantName, FontLoader.RobotoSlabRegular);
            fontsForControls.Add(Btn_ChangeRestaurant, FontLoader.RobotoSlabRegular);

            fontsForControls.Add(Lbl_AddOrder, FontLoader.RobotoSlabLight);
            fontsForControls.Add(Lbl_Worker, FontLoader.RobotoSlabRegular);
            fontsForControls.Add(Btn_ChooseWorker, FontLoader.RobotoSlabRegular);
            fontsForControls.Add(Lbl_Client, FontLoader.RobotoSlabRegular);
            fontsForControls.Add(Btn_ChooseClient, FontLoader.RobotoSlabRegular);
            fontsForControls.Add(Btn_AddNewOrder, FontLoader.RobotoSlabRegular);

            fontsForControls.Add(Lbl_AddItem, FontLoader.RobotoSlabLight);
            fontsForControls.Add(Lbl_Item, FontLoader.RobotoSlabRegular);
            fontsForControls.Add(Btn_ChooseItem, FontLoader.RobotoSlabRegular);
            fontsForControls.Add(Btn_AddItem, FontLoader.RobotoSlabRegular);

            fontsForControls.Add(Lbl_AddPayment, FontLoader.RobotoSlabRegular);
            fontsForControls.Add(Lbl_PaymentMethod, FontLoader.RobotoSlabRegular);
            fontsForControls.Add(Btn_ChoosePaymentMethod, FontLoader.RobotoSlabRegular);
            fontsForControls.Add(Lbl_PaymentValue, FontLoader.RobotoSlabRegular);
            fontsForControls.Add(MaskedTxtBox_PaymentValue, FontLoader.RobotoSlabRegular);

            fontsForControls.Add(Btn_ProgressOrder, FontLoader.RobotoSlabRegular);
            fontsForControls.Add(Btn_ConcludeOrder, FontLoader.RobotoSlabRegular);
            fontsForControls.Add(Btn_CancelOrder, FontLoader.RobotoSlabRegular);
            fontsForControls.Add(Btn_ExportOrder, FontLoader.RobotoSlabRegular);


            _fontLoader.LoadFontToControls(fontsForControls);


            FontFamily fontForDataGrid = _fontLoader.GetFont(FontLoader.RobotoSlabRegular);
            DataGridView_Orders.ColumnHeadersDefaultCellStyle.Font = new Font(fontForDataGrid, DataGridView_Orders.ColumnHeadersDefaultCellStyle.Font.Size);
            DataGridView_Orders.DefaultCellStyle.Font = new Font(fontForDataGrid, DataGridView_Orders.DefaultCellStyle.Font.Size);


            Lbl_AddOrder.BringToFront();
            Lbl_AddItem.BringToFront();
            Lbl_AddPayment.BringToFront();
        }
    }
}
