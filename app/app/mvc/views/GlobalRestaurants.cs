using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace app
{
    public partial class GlobalRestaurants : Form
    {
        private FontLoader _fontLoader;

        public GlobalRestaurants()
        {
            InitializeComponent();

            _fontLoader = new FontLoader();
        }


        //Irá dar load das fontes em todos os controlos do form
        private void GlobalRestaurants_Load(object sender, EventArgs e)
        {
            Control[] controlsToLoadFont =
            {
                Lbl_Restaurantes,
                Btn_RegisterNewRestaurant, Btn_ManageRestaurant, Btn_EditRestaurant,
                Btn_ManageCategories,
                Btn_ManagePaymentMethods
            };

            string[] fontsForControls =
            {
                FontLoader.RobotoSlabBold,
                FontLoader.RobotoSlabRegular,FontLoader.RobotoSlabRegular, FontLoader.RobotoSlabRegular,
                FontLoader.RobotoSlabRegular,
                FontLoader.RobotoSlabRegular,

            };

            _fontLoader.LoadFontToControls(controlsToLoadFont, fontsForControls);

            FontFamily fontForDataGrid = _fontLoader.GetFont(FontLoader.RobotoSlabRegular);
            DataGridView_Restaurants.ColumnHeadersDefaultCellStyle.Font = new Font(fontForDataGrid, DataGridView_Restaurants.ColumnHeadersDefaultCellStyle.Font.Size);
            DataGridView_Restaurants.DefaultCellStyle.Font = new Font(fontForDataGrid, DataGridView_Restaurants.DefaultCellStyle.Font.Size);
        }
    }
}
