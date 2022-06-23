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
    public partial class SelectRestaurant : Form
    {

        private FontLoader _fontLoader;
        public SelectRestaurant()
        {
            InitializeComponent();

            _fontLoader = new FontLoader();
        }

        //Irá dar load das fontes nos controlos
        private void SelectRestaurant_Load(object sender, EventArgs e)
        {
            Dictionary<Control, string> fontsForControls = new Dictionary<Control, string>();

            fontsForControls.Add(Lbl_Title, FontLoader.RobotoSlabBold);

            fontsForControls.Add(Lbl_Name, FontLoader.RobotoSlabRegular);
            fontsForControls.Add(TxtBox_Name, FontLoader.RobotoSlabRegular);

            fontsForControls.Add(Btn_Filter, FontLoader.RobotoSlabRegular);

            fontsForControls.Add(Btn_CreateRestaurant, FontLoader.RobotoSlabRegular);
            fontsForControls.Add(Btn_Confirm, FontLoader.RobotoSlabRegular);

            FontFamily fontForDataGrid = _fontLoader.GetFont(FontLoader.RobotoSlabRegular);

            DataGridView_AvailableRestaurants.ColumnHeadersDefaultCellStyle.Font = new Font(fontForDataGrid, DataGridView_AvailableRestaurants.ColumnHeadersDefaultCellStyle.Font.Size);
            DataGridView_AvailableRestaurants.DefaultCellStyle.Font = new Font(fontForDataGrid, DataGridView_AvailableRestaurants.DefaultCellStyle.Font.Size);

            _fontLoader.LoadFontToControls(fontsForControls);


            RefreshDataGridView();


        }



        private void RefreshDataGridView()
        {
            PopulateData.PopulateRestaurantsIntoBindingSource(BindingSource_AllRestaurants);
        }

        private void Btn_CreateRestaurant_Click(object sender, EventArgs e)
        {
            AddEditRestaurant novorestaurante = new AddEditRestaurant();
            BaseController.RenderViewAsDialog(novorestaurante);
            RefreshDataGridView();
        }

        private void bindingSource1_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void DataGridView_AvailableRestaurants_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Btn_Confirm_Click(object sender, EventArgs e)
        {
            Restaurant selectedCategory = new Restaurant
            {
                Nome = DataGridView_AvailableRestaurants.CurrentRow.Cells[0].Value.ToString(),


            };



            Restaurant novorestaurante = new AddEditRestaurant();
            BaseController.RenderViewAsDialog(novorestaurante);


            






        }
    }
}
