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
    public partial class GenericSelection : Form
    {

        private FontLoader _fontLoader;

        public GenericSelection()
        {
            InitializeComponent();

            _fontLoader = new FontLoader();
        }

        //Irá dar load das fontes nos controlos
        private void GenericSelection_Load(object sender, EventArgs e)
        {
            Dictionary<Control, string> fontsForControls = new Dictionary<Control, string>();

            fontsForControls.Add(Lbl_Title, FontLoader.RobotoSlabBold);

            fontsForControls.Add(Lbl_Name, FontLoader.RobotoSlabRegular);
            fontsForControls.Add(TxtBox_Name, FontLoader.RobotoSlabRegular);

            fontsForControls.Add(Btn_Filter, FontLoader.RobotoSlabRegular);

            fontsForControls.Add(Btn_Confirm, FontLoader.RobotoSlabRegular);

            FontFamily fontForDataGrid = _fontLoader.GetFont(FontLoader.RobotoSlabRegular);

            DataGridView_AvailableStuff.ColumnHeadersDefaultCellStyle.Font = new Font(fontForDataGrid, DataGridView_AvailableStuff.ColumnHeadersDefaultCellStyle.Font.Size);
            DataGridView_AvailableStuff.DefaultCellStyle.Font = new Font(fontForDataGrid, DataGridView_AvailableStuff.DefaultCellStyle.Font.Size);

            _fontLoader.LoadFontToControls(fontsForControls);
        }
    }
}
