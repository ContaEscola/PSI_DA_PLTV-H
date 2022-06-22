using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace app
{
    internal class PopulateData
    {
        public static void PopulateRestaurantsIntoBindingSource(BindingSource sourceToPopulate, DataGridView gridViewToAdjustContents = null)
        {
            sourceToPopulate.DataSource = SingleTown.AppDB.RestauranteSet.ToList<Restaurante>();

            if(gridViewToAdjustContents != null)
            {
                gridViewToAdjustContents.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
                gridViewToAdjustContents.ClearSelection();
            }
                
        }

        public static void PopulatePaymentMethodsIntoBindingSource(BindingSource sourceToPopulate, DataGridView gridViewToAdjustContents = null)
        {
            sourceToPopulate.DataSource = SingleTown.AppDB.MetodoPagamentoSet.ToList<MetodoPagamento>();

            if (gridViewToAdjustContents != null)
            {
                gridViewToAdjustContents.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
                gridViewToAdjustContents.ClearSelection();
            }
                
        }

        public static void PopulatePaymentMethodsStatesIntoComboBox(ComboBox comboBox)
        {
            comboBox.Items.Clear();

            comboBox.Items.Add("Ativo");
            comboBox.Items.Add("Inativo");

            comboBox.SelectedIndex = 0;
        }

        public static void PopulateCategoriesIntoBindingSource(BindingSource sourceToPopulate, DataGridView gridViewToAdjustContents = null)
        {
            sourceToPopulate.DataSource = SingleTown.AppDB.CategoriaSet.ToList<Categoria>();

            if (gridViewToAdjustContents != null)
            {
                gridViewToAdjustContents.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
                gridViewToAdjustContents.ClearSelection();
            }

        }


        public static void PopulateCategoriesStatesIntoComboBox(ComboBox comboBox)
        {
            comboBox.Items.Clear();

            comboBox.Items.Add("Ativo");
            comboBox.Items.Add("Inativo");

            comboBox.SelectedIndex = 0;
        }
    }
}
