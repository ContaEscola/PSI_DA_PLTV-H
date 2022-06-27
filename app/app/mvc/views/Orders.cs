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
        private Restaurante _restaurant;

        public Orders(Restaurante restaurant)
        {
            InitializeComponent();

            _fontLoader = new FontLoader();
            _restaurant = restaurant;
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

            this.Text = $"Pedidos: {_restaurant.Nome}";
            Lbl_RestaurantName.Text = _restaurant.Nome;

            RefreshDataGridView();
        }


        private void EnableEditControls()
        {
            Btn_ChooseItem.Enabled = true;
            Btn_AddItem.Enabled = true;

            Btn_ChoosePaymentMethod.Enabled = true;
            MaskedTxtBox_PaymentValue.Enabled = true;
            Btn_AddPayment.Enabled = true;


            Btn_ProgressOrder.Enabled = true;
            Btn_CancelOrder.Enabled = true;
            Btn_ConcludeOrder.Enabled = true;
            Btn_ExportOrder.Enabled = true;
            
        }

        private void DisableEditControls()
        {
            Btn_ChooseItem.Enabled = false;
            Btn_AddItem.Enabled = false;

            Btn_ChoosePaymentMethod.Enabled = false;
            MaskedTxtBox_PaymentValue.Enabled = false;
            Btn_AddPayment.Enabled = false;


            Btn_ProgressOrder.Enabled = false;
            Btn_CancelOrder.Enabled = false;
            Btn_ConcludeOrder.Enabled = false;
            Btn_ExportOrder.Enabled = false;
        }

        private void ResetAddControls()
        {
            Btn_ChooseWorker.ResetText();
            Btn_ChooseClient.ResetText();
        }
        private void RefreshDataGridView()
        {
            PopulateData.PopulateOrdersIntoBindingSource(_restaurant, BindingSource_AllOrders, DataGridView_Orders);
        }

        private void Btn_ChangeRestaurant_Click(object sender, EventArgs e)
        {
            Restaurante selectedRestaurant = (Restaurante)BaseController.RenderViewAsDialogWithReturn(new GenericSelection(GenericSelection.Reasons.SelectMenu));
            BaseController.RenderView(new Orders(selectedRestaurant));
        }
    }
}
