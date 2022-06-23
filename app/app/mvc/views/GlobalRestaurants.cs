using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
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
            Dictionary<Control, string> fontsForControls = new Dictionary<Control, string>();

            fontsForControls.Add(Lbl_Restaurantes, FontLoader.RobotoSlabBold);

            fontsForControls.Add( Btn_RegisterNewRestaurant, FontLoader.RobotoSlabRegular);
            fontsForControls.Add( Btn_ManageRestaurant, FontLoader.RobotoSlabRegular);
            fontsForControls.Add( Btn_EditRestaurant, FontLoader.RobotoSlabRegular);

            fontsForControls.Add( Btn_ManageCategories, FontLoader.RobotoSlabRegular);

            fontsForControls.Add( Btn_ManagePaymentMethods, FontLoader.RobotoSlabRegular);

            _fontLoader.LoadFontToControls(fontsForControls);

            FontFamily fontForDataGrid = _fontLoader.GetFont(FontLoader.RobotoSlabRegular);
            DataGridView_Restaurants.ColumnHeadersDefaultCellStyle.Font = new Font(fontForDataGrid, DataGridView_Restaurants.ColumnHeadersDefaultCellStyle.Font.Size);
            DataGridView_Restaurants.DefaultCellStyle.Font = new Font(fontForDataGrid, DataGridView_Restaurants.DefaultCellStyle.Font.Size);



            RefreshDataGridView();
            DisableEditControls();
        }

        private void EnableEditControls()
        {
            Btn_EditRestaurant.Enabled = true;
        }

        private void DisableEditControls()
        {
            Btn_EditRestaurant.Enabled = false;
        }

        private void RefreshDataGridView()
        {
            PopulateData.PopulateRestaurantsIntoBindingSource(BindingSource_AllRestaurants, DataGridView_Restaurants);
        }

        private void Btn_RegisterNewRestaurant_Click(object sender, EventArgs e)
        {
            BaseController.RenderViewAsDialog(new AddEditRestaurant());
            RefreshDataGridView();
        }

        private void Btn_EditRestaurant_Click(object sender, EventArgs e)
        {
            BaseController.RenderViewAsDialog(new AddEditRestaurant(true));
            RefreshDataGridView();
        }

        private void Btn_ManageRestaurant_Click(object sender, EventArgs e)
        {
            BaseController.RenderView(new Restaurant());
        }
        
        private void Btn_ManageCategories_Click(object sender, EventArgs e)
        {
            BaseController.RenderView(new Categories());
        }

        private void Btn_ManagePaymentMethods_Click(object sender, EventArgs e)
        {
            BaseController.RenderView(new PaymentMethods());
        }

        private void DataGridView_Restaurants_SelectionChanged(object sender, EventArgs e)
        {
            if (DataGridView_Restaurants.SelectedRows.Count > 0)
            {
                EnableEditControls();

                string restaurantName = DataGridView_Restaurants.CurrentRow.Cells[0].Value.ToString();

                Restaurante selectedRestaurant = CRUD.GetRestaurant(restaurantName);

                SingleTown.SelectedRestaurant = selectedRestaurant;

                EnableEditControls();
            }
            else
            {
                DisableEditControls();
            }
        }
    }
}
