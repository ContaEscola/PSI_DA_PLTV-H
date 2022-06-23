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

            RefreshDataGridView();
            DisableEditControls();
        }
        
        private void EnableEditControls()
        {
            TxtBox_ClientName.Enabled = true;
            MaskedTxtBox_ClientPhone.Enabled = true;
            MaskedTxtBox_ClientNIF.Enabled = true;
            TxtBox_ClientCountry.Enabled = true;
            TxtBox_ClientStreet.Enabled = true;
            TxtBox_ClientCity.Enabled = true;
            MaskedTxtBox_ClientPostalCode.Enabled = true;


            Btn_SaveChangesOnClient.Enabled = true;

            Btn_RemoveClient.Enabled = true;
        }

        private void DisableEditControls()
        {
            TxtBox_ClientName.Enabled = false;
            MaskedTxtBox_ClientPhone.Enabled = false;
            MaskedTxtBox_ClientNIF.Enabled = false;
            TxtBox_ClientCountry.Enabled = false;
            TxtBox_ClientStreet.Enabled = false;
            TxtBox_ClientCity.Enabled = false;
            MaskedTxtBox_ClientPostalCode.Enabled = false;


            Btn_SaveChangesOnClient.Enabled = false;

            Btn_RemoveClient.Enabled = false;
        }

        private void ResetAddControls()
        {
            TxtBox_NewClientName.ResetText();
            MaskedTxtBox_NewClientPhone.ResetText();
            MaskedTxtBox_NewClientNIF.ResetText();
            TxtBox_NewClientCountry.ResetText();
            TxtBox_NewClientStreet.ResetText();
            TxtBox_NewClientCity.ResetText();
            MaskedTxtBox_NewClientPostalCode.ResetText();
        }

        private void PopulateEditControls()
        {
            TxtBox_ClientName.Text = SingleTown.SelectedClient.Nome;
            MaskedTxtBox_ClientPhone.Text = SingleTown.SelectedClient.Telemovel;
            MaskedTxtBox_ClientNIF.Text = SingleTown.SelectedClient.NumContribuinte;
            TxtBox_ClientCountry.Text = SingleTown.SelectedClient.Morada.Pais;
            TxtBox_ClientStreet.Text = SingleTown.SelectedClient.Morada.Rua;
            TxtBox_ClientCity.Text = SingleTown.SelectedClient.Morada.Cidade;
            MaskedTxtBox_ClientPostalCode.Text = SingleTown.SelectedClient.Morada.CodPostal;
        }

        private void ResetEditControls()
        {
            TxtBox_ClientName.ResetText();
            MaskedTxtBox_ClientPhone.ResetText();
            MaskedTxtBox_ClientNIF.ResetText();
            TxtBox_ClientCountry.ResetText();
            TxtBox_ClientStreet.ResetText();
            TxtBox_ClientCity.ResetText();
            MaskedTxtBox_ClientPostalCode.ResetText();
            DisableEditControls();
        }

        private void RefreshDataGridView()
        {
            PopulateData.PopulateClientsIntoBindingSource(BindingSource_AllClients, DataGridView_Clients);
        }

        private void Btn_AddClient_Click(object sender, EventArgs e)
        {
            if (StringHelper.IsEmptyOrNull(TxtBox_NewClientName, MaskedTxtBox_NewClientPhone, MaskedTxtBox_NewClientNIF, TxtBox_NewClientCountry, TxtBox_NewClientStreet, TxtBox_NewClientCity, MaskedTxtBox_NewClientPostalCode))
                return;

            try
            {
                string codPostal = MaskedTxtBox_NewClientPostalCode.Text;
                string telemovel = MaskedTxtBox_NewClientPhone.Text;
                string nif = MaskedTxtBox_NewClientNIF.Text;

                StringHelper.TrimAllWhiteSpace(ref telemovel);
                StringHelper.TrimAllWhiteSpace(ref codPostal);
                StringHelper.TrimAllWhiteSpace(ref nif);

                if (codPostal.Length != 8) throw new Exception("O novo cliente tem um código postal inválido!");
                if (telemovel.Length != 11) throw new Exception("O novo cliente tem um número de telemóvel inválido!");
                if (nif.Length != 9) throw new Exception("O novo cliente tem um nif inválido!");

                Morada newMorada = new Morada
                {
                    Rua = TxtBox_NewClientStreet.Text,
                    Cidade = TxtBox_NewClientCity.Text,
                    CodPostal = codPostal,
                    Pais = TxtBox_NewClientCountry.Text
                };

                Cliente newClient = new Cliente
                {
                    Nome = TxtBox_NewClientName.Text,
                    Telemovel = telemovel,
                    Ativo = "Ativo",
                    TotalGasto = 0,
                    NumContribuinte = nif

                };

                VerifyData.HasNIF(nif);
                VerifyData.HasMoradaForPerson(newMorada);
                VerifyData.HasCliente(newClient);

                CRUD.AddMorada(newMorada);
                Morada moradaInDB = CRUD.GetMorada(newMorada.Rua);

                newClient.IdMorada = moradaInDB.Id;

                CRUD.AddClient(newClient);
                RefreshDataGridView();
                ResetAddControls();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void DataGridView_Clients_SelectionChanged(object sender, EventArgs e)
        {
            if (DataGridView_Clients.SelectedRows.Count > 0)
            {
                EnableEditControls();

                string clientName = DataGridView_Clients.CurrentRow.Cells[0].Value.ToString();

                Cliente selectedClient = CRUD.GetClient(clientName);

                SingleTown.SelectedClient = selectedClient;

                PopulateEditControls();

            }
            else
            {
                ResetEditControls();
            }
        }

        private void Btn_SaveChangesOnClient_Click(object sender, EventArgs e)
        {
            if (StringHelper.IsEmptyOrNull(TxtBox_ClientName, MaskedTxtBox_ClientPhone, MaskedTxtBox_ClientNIF, TxtBox_ClientCountry, TxtBox_ClientStreet, TxtBox_ClientCity, MaskedTxtBox_ClientPostalCode))
                return;

            try
            {
                string codPostal = MaskedTxtBox_ClientPostalCode.Text;
                string telemovel = MaskedTxtBox_ClientPhone.Text;
                string nif = MaskedTxtBox_ClientNIF.Text;

                StringHelper.TrimAllWhiteSpace(ref telemovel);
                StringHelper.TrimAllWhiteSpace(ref codPostal);
                StringHelper.TrimAllWhiteSpace(ref nif);

                if (codPostal.Length != 8) throw new Exception("O cliente tem um código postal inválido!");
                if (telemovel.Length != 11) throw new Exception("O cliente tem um número de telemóvel inválido!");
                if (nif.Length != 9) throw new Exception("O cliente tem um nif inválido!");

                Morada updatedMorada = new Morada
                {
                    Rua = TxtBox_ClientStreet.Text,
                    Cidade = TxtBox_ClientCity.Text,
                    CodPostal = codPostal,
                    Pais = TxtBox_ClientCountry.Text
                };

                Cliente updatedClient = new Cliente
                {
                    Nome = TxtBox_ClientName.Text,
                    Telemovel = telemovel,
                    NumContribuinte = nif,
                    Morada = updatedMorada
                };

                CRUD.EditClient(updatedClient);
                RefreshDataGridView();
                 
            } 
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Btn_RemoveClient_Click(object sender, EventArgs e)
        {
            CRUD.RemoveClient();
            RefreshDataGridView();
        }
    }
}
