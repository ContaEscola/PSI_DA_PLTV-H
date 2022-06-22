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
    public partial class Restaurant : Form
    {
        private FontLoader _fontLoader;
        private Restaurante _restaurant;

        public Restaurant(Restaurante restaurant)
        {
            InitializeComponent();

            _fontLoader = new FontLoader();
            _restaurant = restaurant;
        }


        //Irá dar load das fontes em todos os controlos do form
        private void Restaurant_Load(object sender, EventArgs e)
        {
            Dictionary<Control, string> fontsForControls = new Dictionary<Control, string>();

            fontsForControls.Add(Lbl_RestauranteName, FontLoader.RobotoSlabBold);

            fontsForControls.Add(Lbl_CodPostal, FontLoader.RobotoSlabExtraLight);
            fontsForControls.Add(Lbl_RestaurantCodPostal, FontLoader.RobotoSlabRegular);

            fontsForControls.Add(Lbl_City, FontLoader.RobotoSlabExtraLight);
            fontsForControls.Add(Lbl_RestaurantCity, FontLoader.RobotoSlabRegular);

            fontsForControls.Add(Lbl_Country, FontLoader.RobotoSlabExtraLight);
            fontsForControls.Add(Lbl_RestaurantCountry, FontLoader.RobotoSlabRegular);

            fontsForControls.Add(Lbl_Street, FontLoader.RobotoSlabExtraLight);
            fontsForControls.Add(Lbl_RestaurantStreet, FontLoader.RobotoSlabRegular);

            fontsForControls.Add(Lbl_AddWorker, FontLoader.RobotoSlabLight);

            fontsForControls.Add(Lbl_NewWorkerName, FontLoader.RobotoSlabRegular);
            fontsForControls.Add(TxtBox_NewWorkerName, FontLoader.RobotoSlabRegular);

            fontsForControls.Add(Lbl_NewWorkerPhone, FontLoader.RobotoSlabRegular);
            fontsForControls.Add(MaskedTxtBox_NewWorkerPhone, FontLoader.RobotoSlabRegular);

            fontsForControls.Add(Lbl_NewWorkerSalary, FontLoader.RobotoSlabRegular);
            fontsForControls.Add(MaskedTxtBox_NewWorkerSalary, FontLoader.RobotoSlabRegular);

            fontsForControls.Add(Lbl_NewWorkerPosition, FontLoader.RobotoSlabRegular);
            fontsForControls.Add(TxtBox_NewWorkerPosition, FontLoader.RobotoSlabRegular);

            fontsForControls.Add(Lbl_NewWorkerStreet, FontLoader.RobotoSlabRegular);
            fontsForControls.Add(TxtBox_NewWorkerStreet, FontLoader.RobotoSlabRegular);

            fontsForControls.Add(Lbl_NewWorkerCity, FontLoader.RobotoSlabRegular);
            fontsForControls.Add(TxtBox_NewWorkerCity, FontLoader.RobotoSlabRegular);

            fontsForControls.Add(Lbl_NewWorkerPostalCode, FontLoader.RobotoSlabRegular);
            fontsForControls.Add(MaskedTxtBox_NewWorkerPostalCode, FontLoader.RobotoSlabRegular);

            fontsForControls.Add(Btn_AddWorker, FontLoader.RobotoSlabRegular);


            fontsForControls.Add(Lbl_EditWorker, FontLoader.RobotoSlabLight);

            fontsForControls.Add(Lbl_WorkerName, FontLoader.RobotoSlabRegular);
            fontsForControls.Add(TxtBox_WorkerName, FontLoader.RobotoSlabRegular);

            fontsForControls.Add(Lbl_WorkerPhone, FontLoader.RobotoSlabRegular);
            fontsForControls.Add(MaskedTxtBox_WorkerPhone, FontLoader.RobotoSlabRegular);

            fontsForControls.Add(Lbl_WorkerSalary, FontLoader.RobotoSlabRegular);
            fontsForControls.Add(MaskedTxtBox_WorkerSalary, FontLoader.RobotoSlabRegular);

            fontsForControls.Add(Lbl_WorkerPosition, FontLoader.RobotoSlabRegular);
            fontsForControls.Add(TxtBox_WorkerPosition, FontLoader.RobotoSlabRegular);

            fontsForControls.Add(Lbl_WorkerStreet, FontLoader.RobotoSlabRegular);
            fontsForControls.Add(TxtBox_WorkerStreet, FontLoader.RobotoSlabRegular);

            fontsForControls.Add(Lbl_WorkerCity, FontLoader.RobotoSlabRegular);
            fontsForControls.Add(TxtBox_WorkerCity, FontLoader.RobotoSlabRegular);

            fontsForControls.Add(Lbl_WorkerPostalCode, FontLoader.RobotoSlabRegular);
            fontsForControls.Add(MaskedTxtBox_WorkerPostalCode, FontLoader.RobotoSlabRegular);

            fontsForControls.Add(Lbl_WorkerState, FontLoader.RobotoSlabRegular);
            fontsForControls.Add(ComboBox_WorkerState, FontLoader.RobotoSlabRegular);

            fontsForControls.Add(Btn_SaveChangesOnWorker, FontLoader.RobotoSlabRegular);

            fontsForControls.Add(Btn_RemoveWorker, FontLoader.RobotoSlabRegular);

            fontsForControls.Add(Btn_ManageMenu, FontLoader.RobotoSlabRegular);
            fontsForControls.Add(Btn_ManageOrders, FontLoader.RobotoSlabRegular);

            FontFamily fontForDataGrid = _fontLoader.GetFont(FontLoader.RobotoSlabRegular);
            DataGridView_Employees.ColumnHeadersDefaultCellStyle.Font = new Font(fontForDataGrid, DataGridView_Employees.ColumnHeadersDefaultCellStyle.Font.Size);
            DataGridView_Employees.DefaultCellStyle.Font = new Font(fontForDataGrid, DataGridView_Employees.DefaultCellStyle.Font.Size);

            _fontLoader.LoadFontToControls(fontsForControls);

            Lbl_AddWorker.BringToFront();
            Lbl_EditWorker.BringToFront();

            this.Text = $"Restaurante: {_restaurant.Nome}";
            Lbl_RestauranteName.Text = _restaurant.Nome;
            Lbl_RestaurantCodPostal.Text = _restaurant.Morada.CodPostal;
            Lbl_RestaurantCity.Text = _restaurant.Morada.Cidade;
            Lbl_RestaurantCountry.Text = _restaurant.Morada.Pais;
            Lbl_RestaurantStreet.Text = _restaurant.Morada.Rua;

            RefreshDataGridView();
        }


        private void RefreshDataGridView()
        {
            PopulateData.PopulateEmployeesIntoBindingSource(_restaurant,BindingSource_AllEmployees, DataGridView_Employees);
        }
    }
}
