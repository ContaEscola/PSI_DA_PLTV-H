using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
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
            fontsForControls.Add(TxtBox_NewWorkerSalary, FontLoader.RobotoSlabRegular);

            fontsForControls.Add(Lbl_NewWorkerPosition, FontLoader.RobotoSlabRegular);
            fontsForControls.Add(TxtBox_NewWorkerPosition, FontLoader.RobotoSlabRegular);

            fontsForControls.Add(Lbl_NewWorkerStreet, FontLoader.RobotoSlabRegular);
            fontsForControls.Add(TxtBox_NewWorkerStreet, FontLoader.RobotoSlabRegular);

            fontsForControls.Add(Lbl_NewWorkerCity, FontLoader.RobotoSlabRegular);
            fontsForControls.Add(TxtBox_NewWorkerCity, FontLoader.RobotoSlabRegular);

            fontsForControls.Add(Lbl_NewWorkerPostalCode, FontLoader.RobotoSlabRegular);
            fontsForControls.Add(MaskedTxtBox_NewWorkerPostalCode, FontLoader.RobotoSlabRegular);

            fontsForControls.Add(Lbl_NewWorkerCountry, FontLoader.RobotoSlabRegular);
            fontsForControls.Add(TxtBox_NewWorkerCountry, FontLoader.RobotoSlabRegular);

            fontsForControls.Add(Btn_AddWorker, FontLoader.RobotoSlabRegular);


            fontsForControls.Add(Lbl_EditWorker, FontLoader.RobotoSlabLight);

            fontsForControls.Add(Lbl_WorkerName, FontLoader.RobotoSlabRegular);
            fontsForControls.Add(TxtBox_WorkerName, FontLoader.RobotoSlabRegular);

            fontsForControls.Add(Lbl_WorkerPhone, FontLoader.RobotoSlabRegular);
            fontsForControls.Add(MaskedTxtBox_WorkerPhone, FontLoader.RobotoSlabRegular);

            fontsForControls.Add(Lbl_WorkerSalary, FontLoader.RobotoSlabRegular);
            fontsForControls.Add(TxtBox_WorkerSalary, FontLoader.RobotoSlabRegular);

            fontsForControls.Add(Lbl_WorkerPosition, FontLoader.RobotoSlabRegular);
            fontsForControls.Add(TxtBox_WorkerPosition, FontLoader.RobotoSlabRegular);

            fontsForControls.Add(Lbl_WorkerStreet, FontLoader.RobotoSlabRegular);
            fontsForControls.Add(TxtBox_WorkerStreet, FontLoader.RobotoSlabRegular);

            fontsForControls.Add(Lbl_WorkerCity, FontLoader.RobotoSlabRegular);
            fontsForControls.Add(TxtBox_WorkerCity, FontLoader.RobotoSlabRegular);

            fontsForControls.Add(Lbl_WorkerPostalCode, FontLoader.RobotoSlabRegular);
            fontsForControls.Add(MaskedTxtBox_WorkerPostalCode, FontLoader.RobotoSlabRegular);

            fontsForControls.Add(Lbl_WorkerCountry, FontLoader.RobotoSlabRegular);
            fontsForControls.Add(TxtBox_WorkerCountry, FontLoader.RobotoSlabRegular);


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
            DisableEditControls();
        }

        private void EnableEditControls()
        {
            TxtBox_WorkerName.Enabled = true;
            MaskedTxtBox_WorkerPhone.Enabled = true;
            TxtBox_WorkerSalary.Enabled = true;
            TxtBox_WorkerPosition.Enabled = true;
            TxtBox_WorkerStreet.Enabled = true;
            TxtBox_WorkerCity.Enabled = true;
            MaskedTxtBox_WorkerPostalCode.Enabled = true;
            TxtBox_WorkerCountry.Enabled = true;
            Btn_SaveChangesOnWorker.Enabled = true;

            Btn_RemoveWorker.Enabled = true;
        }

        private void DisableEditControls()
        {
            TxtBox_WorkerName.Enabled = false;
            MaskedTxtBox_WorkerPhone.Enabled = false;
            TxtBox_WorkerSalary.Enabled = false;
            TxtBox_WorkerPosition.Enabled = false;
            TxtBox_WorkerStreet.Enabled = false;
            TxtBox_WorkerCity.Enabled = false;
            MaskedTxtBox_WorkerPostalCode.Enabled = false;
            TxtBox_WorkerCountry.Enabled = false;
            Btn_SaveChangesOnWorker.Enabled = false;

            Btn_RemoveWorker.Enabled = false;
        }

        private void ResetAddControls()
        {
            TxtBox_NewWorkerName.ResetText();
            MaskedTxtBox_NewWorkerPhone.ResetText();
            TxtBox_NewWorkerSalary.ResetText();
            TxtBox_NewWorkerPosition.ResetText();
            TxtBox_NewWorkerStreet.ResetText();
            TxtBox_NewWorkerCity.ResetText();
            MaskedTxtBox_NewWorkerPostalCode.ResetText();
            TxtBox_NewWorkerCountry.ResetText();
        }

        private void PopulateEditControls()
        {
            TxtBox_WorkerName.Text = SingleTown.SelectedEmployee.Nome;
            MaskedTxtBox_WorkerPhone.Text = SingleTown.SelectedEmployee.Telemovel;
            TxtBox_WorkerSalary.Text = String.Format(CultureInfo.GetCultureInfo("pt-PT"), "{0:#,0.00}", SingleTown.SelectedEmployee.Salario);
            TxtBox_WorkerPosition.Text = SingleTown.SelectedEmployee.Posicao;
            TxtBox_WorkerStreet.Text = SingleTown.SelectedEmployee.Morada.Rua;
            TxtBox_WorkerCity.Text = SingleTown.SelectedEmployee.Morada.Cidade;
            MaskedTxtBox_WorkerPostalCode.Text = SingleTown.SelectedEmployee.Morada.CodPostal;
            TxtBox_WorkerCountry.Text = SingleTown.SelectedEmployee.Morada.Pais;
        }
        private void ResetEditControls()
        {
            TxtBox_WorkerName.ResetText();
            MaskedTxtBox_WorkerPhone.ResetText();
            TxtBox_WorkerSalary.ResetText();
            TxtBox_WorkerPosition.ResetText();
            TxtBox_WorkerStreet.ResetText();
            TxtBox_WorkerCity.ResetText();
            MaskedTxtBox_WorkerPostalCode.ResetText();
            TxtBox_WorkerCountry.ResetText();
            DisableEditControls();
        }

        private void RefreshDataGridView()
        {
            PopulateData.PopulateEmployeesIntoBindingSource(_restaurant,BindingSource_AllEmployees, DataGridView_Employees);
        }

        private void Btn_AddWorker_Click(object sender, EventArgs e)
        {
           if (StringHelper.IsEmptyOrNull(TxtBox_NewWorkerName,TxtBox_NewWorkerPosition, TxtBox_NewWorkerStreet, TxtBox_NewWorkerCity, TxtBox_NewWorkerCountry,MaskedTxtBox_NewWorkerPhone, MaskedTxtBox_NewWorkerPostalCode, TxtBox_NewWorkerSalary)) 
                return;

           try
           {
                string codPostal = MaskedTxtBox_NewWorkerPostalCode.Text;
                string telemovel = MaskedTxtBox_NewWorkerPhone.Text;

                string salario = TxtBox_NewWorkerSalary.Text;
                decimal salarioConverted = Decimal.Parse(salario,CultureInfo.GetCultureInfo("pt-PT"));

                StringHelper.RemoveEuroFromString(ref salario);
                StringHelper.TrimAllWhiteSpace(ref telemovel);
                StringHelper.TrimAllWhiteSpace(ref codPostal);
                

                if (codPostal.Length != 8) throw new Exception("O novo trabalhador tem um código postal inválido!");
                if (telemovel.Length != 11) throw new Exception("O novo trabalhador tem um número de telemóvel inválido!");

                Morada newMorada = new Morada
                {
                    Rua = TxtBox_NewWorkerStreet.Text,
                    Cidade = TxtBox_NewWorkerCity.Text,
                    CodPostal = codPostal,
                    Pais = TxtBox_NewWorkerCountry.Text
                };

                Trabalhador newEmployee = new Trabalhador
                {
                    Nome = TxtBox_NewWorkerName.Text,
                    Telemovel = telemovel,
                    Salario = salarioConverted,
                    Posicao = TxtBox_NewWorkerPosition.Text,
                    IdRestaurante = _restaurant.Id,
                    Ativo = "Ativo"
                };

                VerifyData.HasMoradaForPerson(newMorada);
                VerifyData.HasEmployee(newEmployee);

                CRUD.AddMorada(newMorada);
                Morada moradaInDB = CRUD.GetMorada(newMorada.Rua);

                newEmployee.IdMorada = moradaInDB.Id;

                CRUD.AddEmployee(newEmployee);
                RefreshDataGridView();
                ResetAddControls();
           }
           catch (FormatException)
           {
                MessageBox.Show("O salário inserido é inválido!");
           }
           catch (Exception ex)
           {
                MessageBox.Show(ex.Message);
           }
           
        }

        private void DataGridView_Employees_SelectionChanged(object sender, EventArgs e)
        {
            if(DataGridView_Employees.SelectedRows.Count > 0)
            {
                EnableEditControls();

                string employeeName = DataGridView_Employees.CurrentRow.Cells[0].Value.ToString();

                Trabalhador selectedEmployee = CRUD.GetEmployee(employeeName);

                SingleTown.SelectedEmployee = selectedEmployee;

                PopulateEditControls();

            } else
            {
                ResetEditControls();
            }
        }

        private void Btn_SaveChangesOnWorker_Click(object sender, EventArgs e)
        {
            if (StringHelper.IsEmptyOrNull(TxtBox_WorkerName, TxtBox_WorkerPosition, TxtBox_WorkerStreet, TxtBox_WorkerCity, TxtBox_WorkerCountry, MaskedTxtBox_WorkerPhone, MaskedTxtBox_WorkerPostalCode, TxtBox_WorkerSalary))
                return;
            try
            {
                string codPostal = MaskedTxtBox_WorkerPostalCode.Text;
                string telemovel = MaskedTxtBox_WorkerPhone.Text;
                string salario = TxtBox_WorkerSalary.Text;
                decimal salarioConverted = Decimal.Parse(salario);
                StringHelper.RemoveEuroFromString(ref salario);
                StringHelper.TrimAllWhiteSpace(ref telemovel);
                StringHelper.TrimAllWhiteSpace(ref codPostal);


                if (codPostal.Length != 8) throw new Exception("O trabalhador tem um código postal inválido!");
                if (telemovel.Length != 11) throw new Exception("O trabalhador tem um número de telemóvel inválido!");

                Morada updatedMorada = new Morada
                {
                    Rua = TxtBox_WorkerStreet.Text,
                    Cidade = TxtBox_WorkerCity.Text,
                    CodPostal = codPostal,
                    Pais = TxtBox_WorkerCountry.Text
                };

                Trabalhador updatedEmployee = new Trabalhador
                {
                    Nome = TxtBox_WorkerName.Text,
                    Telemovel = telemovel,
                    Salario = salarioConverted,
                    Posicao = TxtBox_WorkerPosition.Text,
                    Morada = updatedMorada
                };

                CRUD.EditEmployee(updatedEmployee);
                RefreshDataGridView();

            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Btn_RemoveWorker_Click(object sender, EventArgs e)
        {
            CRUD.RemoveEmployee();
            RefreshDataGridView();
        }
    }
}
