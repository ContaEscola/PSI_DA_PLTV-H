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

            RefreshDataGridView();
            PopulateData.PopulateCategoriesStatesIntoComboBox(ComboBox_NewCategorieState);
            DisableEditControls();
        }

        private void SelectCurrentCategoryState(ComboBox control, Categoria currentCategory)
        {
            string currentStateToSelect = currentCategory.Ativo;
            int counter = -1;


            foreach (string state in control.Items)
            {
                counter++;
                if (state == currentStateToSelect)
                {
                    control.SelectedIndex = counter;
                }

            }
        }
        private void EnableEditControls()
        {
            TxtBox_CategorieName.Enabled = true;
            ComboBox_CategorieState.Enabled = true;
            Btn_SaveChangesOnCategorie.Enabled = true;
        }

        private void DisableEditControls()
        {
            TxtBox_CategorieName.Enabled = false;
            ComboBox_CategorieState.Enabled = false;
            Btn_SaveChangesOnCategorie.Enabled = false;
        }

        private void ResetEditControls()
        {
            TxtBox_CategorieName.Text = String.Empty;
            ComboBox_CategorieState.Items.Clear();
            ComboBox_CategorieState.ResetText();
            DisableEditControls();
        }

        private void RefreshDataGridView()
        {
            PopulateData.PopulateCategoriesIntoBindingSource(BindingSource_AllCategories, DataGridView_Categories);
        }

        private void Btn_AddCategorie_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(TxtBox_NewCategorieName.Text)) return;

            Categoria newCategorie = new Categoria
            {
                Nome = TxtBox_NewCategorieName.Text.Trim(),
                Ativo = ComboBox_NewCategorieState.SelectedItem.ToString()
            };

            try
            {
                CRUD.AddCategory(newCategorie);
                RefreshDataGridView();
                TxtBox_NewCategorieName.Text = String.Empty;
                Resets.ResetSelectedIndex(ComboBox_NewCategorieState, 0);


            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void DataGridView_Categories_SelectionChanged(object sender, EventArgs e)
        {
            if (DataGridView_Categories.SelectedRows.Count > 0)
            {
                EnableEditControls();
                Categoria selectedCategory = new Categoria
                {
                    Nome = DataGridView_Categories.CurrentRow.Cells[0].Value.ToString(),
                    Ativo = DataGridView_Categories.CurrentRow.Cells[1].Value.ToString()
                };

                SingleTown.SelectedCategory = selectedCategory;

                TxtBox_CategorieName.Text = SingleTown.SelectedCategory.Nome;
                PopulateData.PopulateCategoriesStatesIntoComboBox(ComboBox_CategorieState);
                SelectCurrentCategoryState(ComboBox_CategorieState, SingleTown.SelectedCategory);
            }
            else
            {
                ResetEditControls();
            }
                
        }

        private void Btn_SaveChangesOnCategorie_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(TxtBox_CategorieName.Text)) return;

            try
            {
                Categoria updatedCategory = new Categoria
                {
                    Nome = TxtBox_CategorieName.Text.Trim(),
                    Ativo = ComboBox_CategorieState.SelectedItem.ToString()
                };

                CRUD.EditCategory(updatedCategory);
                RefreshDataGridView();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
