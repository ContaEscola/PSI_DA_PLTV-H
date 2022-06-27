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
    public partial class SelectRestaurant : Dialog
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
            DisableConfirmControls();
        }

        private void EnableConfirmControls()
        {
            Btn_Confirm.Enabled = true;
        }

        private void DisableConfirmControls()
        {
            Btn_Confirm.Enabled = false;
        }

        private void RefreshDataGridView()
        {
            PopulateData.PopulateRestaurantsIntoBindingSource(BindingSource_AllRestaurants, DataGridView_AvailableRestaurants);
        }

        private void Btn_CreateRestaurant_Click(object sender, EventArgs e)
        {
            AddEditRestaurant novoRestaurante = new AddEditRestaurant();
            BaseController.RenderViewAsDialog(novoRestaurante);
            RefreshDataGridView();
        }

        private void Btn_Confirm_Click(object sender, EventArgs e)
        {

            if (_dataToReturn == null)
                MessageBox.Show("Escolha um restaurante primeiro!");
            else
                DialogResult = DialogResult.OK;
        }

        private void DataGridView_AvailableRestaurants_SelectionChanged(object sender, EventArgs e)
        {
            if (DataGridView_AvailableRestaurants.SelectedRows.Count > 0)
            {
                EnableConfirmControls();
                string selectedRestaurantName = DataGridView_AvailableRestaurants.CurrentRow.Cells[0].Value.ToString();

                _dataToReturn = CRUD.GetRestaurant(selectedRestaurantName);

            }       
            else
            {
                DisableConfirmControls();
                _dataToReturn = null;
            }
               
        }

        private void Btn_Filter_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(TxtBox_Name.Text)) { 
                RefreshDataGridView();
                return; 
            }

            List<Restaurante> allRestaurants = SingleTown.AppDB.RestauranteSet.ToList<Restaurante>();
            List<Restaurante> correctRestaurants = new List<Restaurante>();

            foreach (Restaurante restaurant in allRestaurants)
            {
                if (restaurant.Nome.Contains(TxtBox_Name.Text))
                    correctRestaurants.Add(restaurant);
            }

            BindingSource_AllRestaurants.DataSource = correctRestaurants;
        }
    }
}
