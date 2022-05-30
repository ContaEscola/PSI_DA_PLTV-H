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
    public partial class Categories : Form
    {
        private FontLoader _fontLoader;

        public Categories()
        {
            InitializeComponent();

            _fontLoader = new FontLoader();
        }

        //Irá dar load das fontes nos controlos
        private void Categories_Load(object sender, EventArgs e)
        {
            Dictionary<Control, string> fontsForControl = new Dictionary<Control, string>();

            fontsForControl.Add(Lbl_Categories, FontLoader.RobotoSlabBold);

            fontsForControl.Add(Lbl_AddCategorie, FontLoader.RobotoSlabLight);

            fontsForControl.Add(Lbl_NewCategorieName, FontLoader.RobotoSlabRegular);
            fontsForControl.Add(TxtBox_NewCategorieName, FontLoader.RobotoSlabRegular);

            fontsForControl.Add(Lbl_NewCategorieState, FontLoader.RobotoSlabRegular);
            fontsForControl.Add(ComboBox_NewCategorieState, FontLoader.RobotoSlabRegular);

            fontsForControl.Add(Btn_AddCategorie, FontLoader.RobotoSlabRegular);


            fontsForControl.Add(Lbl_EditCategorie, FontLoader.RobotoSlabLight);

            fontsForControl.Add(Lbl_CategorieName, FontLoader.RobotoSlabRegular);
            fontsForControl.Add(TxtBox_CategorieName, FontLoader.RobotoSlabRegular);

            fontsForControl.Add(Lbl_CategorieState, FontLoader.RobotoSlabRegular);
            fontsForControl.Add(ComboBox_CategorieState, FontLoader.RobotoSlabRegular);

            fontsForControl.Add(Btn_SaveChangesOnCategorie, FontLoader.RobotoSlabRegular);


            FontFamily fontForDataGrid = _fontLoader.GetFont(FontLoader.RobotoSlabRegular);
            DataGridView_Categories.ColumnHeadersDefaultCellStyle.Font = new Font(fontForDataGrid, DataGridView_Categories.ColumnHeadersDefaultCellStyle.Font.Size);
            DataGridView_Categories.DefaultCellStyle.Font = new Font(fontForDataGrid, DataGridView_Categories.DefaultCellStyle.Font.Size);

            _fontLoader.LoadFontToControls(fontsForControl);

            Lbl_AddCategorie.BringToFront();
            Lbl_EditCategorie.BringToFront();
        }
    }
}
