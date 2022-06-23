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
    public partial class PaymentMethods : Form
    {
        private FontLoader _fontLoader;

        public PaymentMethods()
        {
            InitializeComponent();

            _fontLoader = new FontLoader();
        }

        //Irá dar load das fontes nos controlos
        private void PaymentMethods_Load(object sender, EventArgs e)
        {
            Dictionary<Control, string> fontsForControls = new Dictionary<Control, string>();

            fontsForControls.Add(Lbl_PaymentMethods, FontLoader.RobotoSlabBold);

            fontsForControls.Add(Lbl_AddPaymentMethod, FontLoader.RobotoSlabLight);

            fontsForControls.Add(Lbl_NewPaymentMethodName, FontLoader.RobotoSlabRegular);
            fontsForControls.Add(TxtBox_NewPaymentMethodName, FontLoader.RobotoSlabRegular);

            fontsForControls.Add(Lbl_NewPaymentMethodState, FontLoader.RobotoSlabRegular);
            fontsForControls.Add(ComboBox_NewPaymentMethodState, FontLoader.RobotoSlabRegular);

            fontsForControls.Add(Btn_AddPaymentMethod, FontLoader.RobotoSlabRegular);



            fontsForControls.Add(Lbl_EditPaymentMethod, FontLoader.RobotoSlabLight);

            fontsForControls.Add(Lbl_PaymentMethodName, FontLoader.RobotoSlabRegular);
            fontsForControls.Add(TxtBox_PaymentMethodName, FontLoader.RobotoSlabRegular);

            fontsForControls.Add(Lbl_PaymentMethodState, FontLoader.RobotoSlabRegular);
            fontsForControls.Add(ComboBox_PaymentMethodState, FontLoader.RobotoSlabRegular);

            fontsForControls.Add(Btn_SaveChangesOnPaymentMethod, FontLoader.RobotoSlabRegular);

            
            
            FontFamily fontForDataGrid = _fontLoader.GetFont(FontLoader.RobotoSlabRegular);
            DataGridView_PaymentMethods.ColumnHeadersDefaultCellStyle.Font = new Font(fontForDataGrid, DataGridView_PaymentMethods.ColumnHeadersDefaultCellStyle.Font.Size);
            DataGridView_PaymentMethods.DefaultCellStyle.Font = new Font(fontForDataGrid, DataGridView_PaymentMethods.DefaultCellStyle.Font.Size);

            _fontLoader.LoadFontToControls(fontsForControls);

            Lbl_AddPaymentMethod.BringToFront();
            Lbl_EditPaymentMethod.BringToFront();


            RefreshDataGridView();
            PopulateData.PopulatePaymentMethodsStatesIntoComboBox(ComboBox_NewPaymentMethodState);
            DisableEditControls();
        }

        private void SelectCurrentPaymentMethodState(ComboBox control, MetodoPagamento currentPaymentMethod)
        {
            string currentStateToSelect = currentPaymentMethod.Ativo;
            int counter = -1;


            foreach(string state in control.Items)
            {
                counter++;
                if(state == currentStateToSelect)
                {
                    control.SelectedIndex = counter;
                }

            }
        }

        private void EnableEditControls()
        {
            TxtBox_PaymentMethodName.Enabled = true;
            ComboBox_PaymentMethodState.Enabled = true;
            Btn_SaveChangesOnPaymentMethod.Enabled = true;
        }

        private void DisableEditControls()
        {
            TxtBox_PaymentMethodName.Enabled = false;
            ComboBox_PaymentMethodState.Enabled = false;
            Btn_SaveChangesOnPaymentMethod.Enabled = false;
        }

        private void ResetEditControls()
        {
            TxtBox_PaymentMethodName.Text = String.Empty;
            ComboBox_PaymentMethodState.Items.Clear();
            ComboBox_PaymentMethodState.ResetText();
            DisableEditControls();
        }

        private void RefreshDataGridView()
        {
            PopulateData.PopulatePaymentMethodsIntoBindingSource(BindingSource_AllPaymentMethods, DataGridView_PaymentMethods);
        }

        private void Btn_AddPaymentMethod_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(TxtBox_NewPaymentMethodName.Text)) return;

            MetodoPagamento newPaymentMethod = new MetodoPagamento
            {
                Metodo = TxtBox_NewPaymentMethodName.Text.Trim(),
                Ativo = ComboBox_NewPaymentMethodState.SelectedItem.ToString()
            };

            try
            {
                CRUD.AddPaymentMethod(newPaymentMethod);
                RefreshDataGridView();
                TxtBox_NewPaymentMethodName.Text = String.Empty;
                Resets.ResetSelectedIndex(ComboBox_NewPaymentMethodState, 0);

            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void DataGridView_PaymentMethods_SelectionChanged(object sender, EventArgs e)
        {
            if (DataGridView_PaymentMethods.SelectedRows.Count > 0)
            {
                EnableEditControls();
                MetodoPagamento selectedPaymentMethod = new MetodoPagamento
                {
                    Metodo = DataGridView_PaymentMethods.CurrentRow.Cells[0].Value.ToString(),
                    Ativo = DataGridView_PaymentMethods.CurrentRow.Cells[1].Value.ToString()
                };

                SingleTown.SelectedPaymentMethod = selectedPaymentMethod;

                TxtBox_PaymentMethodName.Text = SingleTown.SelectedPaymentMethod.Metodo;
                PopulateData.PopulatePaymentMethodsStatesIntoComboBox(ComboBox_PaymentMethodState);
                SelectCurrentPaymentMethodState(ComboBox_PaymentMethodState, SingleTown.SelectedPaymentMethod);
            }      
            else
            {
                ResetEditControls();
            }
                
        }

        private void Btn_SaveChangesOnPaymentMethod_Click(object sender, EventArgs e)
        {
           if (String.IsNullOrEmpty(TxtBox_PaymentMethodName.Text)) return;

           try
           {
                MetodoPagamento updatedPaymentMethod = new MetodoPagamento
                {
                    Metodo = TxtBox_PaymentMethodName.Text.Trim(),
                    Ativo = ComboBox_PaymentMethodState.SelectedItem.ToString()
                };

                CRUD.EditPaymentMethod(updatedPaymentMethod);
                RefreshDataGridView();

           } catch (Exception ex)
           {
                MessageBox.Show(ex.Message);
           }
        }
    }
}
