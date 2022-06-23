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
    public partial class Clients : Form
    {
        private FontLoader _fontLoader;

        public Clients()
        {
            InitializeComponent();

            _fontLoader = new FontLoader();
        }

        //Irá dar load das fontes em todos os controlos do form
        private void Clients_Load(object sender, EventArgs e)
        {
            Dictionary<Control, string> fontsForControls = new Dictionary<Control, string>();

            fontsForControls.Add(Lbl_Clients, FontLoader.RobotoSlabBold);

            fontsForControls.Add(Lbl_AddClient, FontLoader.RobotoSlabLight);

            fontsForControls.Add(Lbl_NewClientName, FontLoader.RobotoSlabRegular);
            fontsForControls.Add(TxtBox_NewClientName, FontLoader.RobotoSlabRegular);

            fontsForControls.Add(Lbl_NewClientPhone, FontLoader.RobotoSlabRegular);
            fontsForControls.Add(MaskedTxtBox_NewClientPhone, FontLoader.RobotoSlabRegular);

            fontsForControls.Add(Lbl_NewClientNIF, FontLoader.RobotoSlabRegular);
            fontsForControls.Add(MaskedTxtBox_NewClientNIF, FontLoader.RobotoSlabRegular);

            fontsForControls.Add(Lbl_NewClientCountry, FontLoader.RobotoSlabRegular);
            fontsForControls.Add(TxtBox_NewClientCountry, FontLoader.RobotoSlabRegular);

            fontsForControls.Add(Lbl_NewClientStreet, FontLoader.RobotoSlabRegular);
            fontsForControls.Add(TxtBox_NewClientStreet, FontLoader.RobotoSlabRegular);

            fontsForControls.Add(Lbl_NewClientCity, FontLoader.RobotoSlabRegular);
            fontsForControls.Add(TxtBox_NewClientCity, FontLoader.RobotoSlabRegular);

            fontsForControls.Add(Lbl_NewClientPostalCode, FontLoader.RobotoSlabRegular);
            fontsForControls.Add(MaskedTxtBox_NewClientPostalCode, FontLoader.RobotoSlabRegular);

            fontsForControls.Add(Btn_AddClient, FontLoader.RobotoSlabRegular);



            fontsForControls.Add(Lbl_EditClient, FontLoader.RobotoSlabLight);

            fontsForControls.Add(Lbl_ClientName, FontLoader.RobotoSlabRegular);
            fontsForControls.Add(TxtBox_ClientName, FontLoader.RobotoSlabRegular);

            fontsForControls.Add(Lbl_ClientPhone, FontLoader.RobotoSlabRegular);
            fontsForControls.Add(MaskedTxtBox_ClientPhone, FontLoader.RobotoSlabRegular);

            fontsForControls.Add(Lbl_ClientNIF, FontLoader.RobotoSlabRegular);
            fontsForControls.Add(MaskedTxtBox_ClientNIF, FontLoader.RobotoSlabRegular);

            fontsForControls.Add(Lbl_ClientCountry, FontLoader.RobotoSlabRegular);
            fontsForControls.Add(TxtBox_ClientCountry, FontLoader.RobotoSlabRegular);

            fontsForControls.Add(Lbl_ClientStreet, FontLoader.RobotoSlabRegular);
            fontsForControls.Add(TxtBox_ClientStreet, FontLoader.RobotoSlabRegular);

            fontsForControls.Add(Lbl_ClientCity, FontLoader.RobotoSlabRegular);
            fontsForControls.Add(TxtBox_ClientCity, FontLoader.RobotoSlabRegular);

            fontsForControls.Add(Lbl_ClientPostalCode, FontLoader.RobotoSlabRegular);
            fontsForControls.Add(MaskedTxtBox_ClientPostalCode, FontLoader.RobotoSlabRegular);

            fontsForControls.Add(Btn_SaveChangesOnClient, FontLoader.RobotoSlabRegular);

            fontsForControls.Add(Btn_RemoveClient, FontLoader.RobotoSlabRegular);

            FontFamily fontForDataGrid = _fontLoader.GetFont(FontLoader.RobotoSlabRegular);
            DataGridView_Clients.ColumnHeadersDefaultCellStyle.Font = new Font(fontForDataGrid, DataGridView_Clients.ColumnHeadersDefaultCellStyle.Font.Size);
            DataGridView_Clients.DefaultCellStyle.Font = new Font(fontForDataGrid, DataGridView_Clients.DefaultCellStyle.Font.Size);

            _fontLoader.LoadFontToControls(fontsForControls);

            Lbl_AddClient.BringToFront();
            Lbl_EditClient.BringToFront();
        }

        private void Btn_AddClient_Click(object sender, EventArgs e)
        {

        }
    }
}
