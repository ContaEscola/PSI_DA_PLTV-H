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
    public partial class Menu : Form
    {

        private FontLoader _fontLoader;
        private Restaurante _restaurant;


        public Menu(Restaurante restaurant)
        {
            InitializeComponent();

            _restaurant = restaurant;
            _fontLoader = new FontLoader();

        }

        //Irá dar load das fontes em todos os controlos do form
        private void Menu_Load(object sender, EventArgs e)
        {
            Dictionary<Control, string> fontsForControls = new Dictionary<Control, string>();

            fontsForControls.Add(Lbl_Menu, FontLoader.RobotoSlabBold);

            fontsForControls.Add(Lbl_Restaurant, FontLoader.RobotoSlabExtraLight);
            fontsForControls.Add(Lbl_RestaurantName, FontLoader.RobotoSlabRegular);

            fontsForControls.Add(Lbl_AddItem, FontLoader.RobotoSlabLight);
            
            fontsForControls.Add(Lbl_NewItemName, FontLoader.RobotoSlabRegular);
            fontsForControls.Add(TxtBox_NewItemName, FontLoader.RobotoSlabRegular);

            fontsForControls.Add(Lbl_NewItemPhotograph, FontLoader.RobotoSlabRegular);
            fontsForControls.Add(Btn_ChoosePhotographForNewItem, FontLoader.RobotoSlabRegular);

            fontsForControls.Add(Lbl_NewItemCategory, FontLoader.RobotoSlabRegular);
            fontsForControls.Add(ComboBox_NewItemCategory, FontLoader.RobotoSlabRegular);

            fontsForControls.Add(Lbl_NewItemIngredients, FontLoader.RobotoSlabRegular);
            fontsForControls.Add(RichTxtBox_NewItemIngredients, FontLoader.RobotoSlabRegular);

            fontsForControls.Add(Lbl_NewItemPrice, FontLoader.RobotoSlabRegular);
            fontsForControls.Add(MaskedTxtBox_NewItemPrice, FontLoader.RobotoSlabRegular);

            fontsForControls.Add(Lbl_NewItemState, FontLoader.RobotoSlabRegular);
            fontsForControls.Add(ComboBox_NewItemState, FontLoader.RobotoSlabRegular);

            fontsForControls.Add(Btn_AddExistentItem, FontLoader.RobotoSlabRegular);

            fontsForControls.Add(Btn_AddItem, FontLoader.RobotoSlabRegular);

            fontsForControls.Add(Lbl_EditItem, FontLoader.RobotoSlabLight);

            fontsForControls.Add(Lbl_SelectedItemName, FontLoader.RobotoSlabRegular);
            fontsForControls.Add(TxtBox_SelectedItemName, FontLoader.RobotoSlabRegular);

            fontsForControls.Add(Lbl_SelectedItemPhotograph, FontLoader.RobotoSlabRegular);
            fontsForControls.Add(Btn_SelectedItemPhotograph, FontLoader.RobotoSlabRegular);

            fontsForControls.Add(Lbl_SelectedItemCategory, FontLoader.RobotoSlabRegular);
            fontsForControls.Add(ComboBox_SelectedItemCategory, FontLoader.RobotoSlabRegular);

            fontsForControls.Add(Lbl_SelectedItemIngredients, FontLoader.RobotoSlabRegular);
            fontsForControls.Add(RichTxtBox_SelectedItemIngredients, FontLoader.RobotoSlabRegular);

            fontsForControls.Add(Lbl_SelectedItemPrice, FontLoader.RobotoSlabRegular);
            fontsForControls.Add(MaskedTxtBox_SelectedItemPrice, FontLoader.RobotoSlabRegular);

            fontsForControls.Add(Lbl_SelectedItemState, FontLoader.RobotoSlabRegular);
            fontsForControls.Add(ComboBox_SelectedItemState, FontLoader.RobotoSlabRegular);

            fontsForControls.Add(Btn_SaveChangesOnSelectedItem, FontLoader.RobotoSlabRegular);

            fontsForControls.Add(Btn_RemoveItem, FontLoader.RobotoSlabRegular);

            fontsForControls.Add(Btn_ChangeRestaurant, FontLoader.RobotoSlabRegular);

            fontsForControls.Add(Btn_ManageCategories, FontLoader.RobotoSlabRegular);

            FontFamily fontForDataGrid = _fontLoader.GetFont(FontLoader.RobotoSlabRegular);
            DataGridView_MenuItems.ColumnHeadersDefaultCellStyle.Font = new Font(fontForDataGrid, DataGridView_MenuItems.ColumnHeadersDefaultCellStyle.Font.Size);
            DataGridView_MenuItems.DefaultCellStyle.Font = new Font(fontForDataGrid, DataGridView_MenuItems.DefaultCellStyle.Font.Size);

            _fontLoader.LoadFontToControls(fontsForControls);

            Lbl_AddItem.BringToFront();
            Lbl_EditItem.BringToFront();


            this.Text = $"Menu: {_restaurant.Nome}";
            Lbl_RestaurantName.Text = _restaurant.Nome;

            // https://stackoverflow.com/questions/1706454/c-multiline-text-in-datagridview-control?answertab=trending#tab-top
            DataGridView_MenuItems.Columns[3].DefaultCellStyle.WrapMode = DataGridViewTriState.True;

            RefreshDataGridView();
            PopulateData.PopulateCategoriesIntoComboBox(ComboBox_NewItemCategory);
            PopulateData.PopulateItemStatesIntoComboBox(ComboBox_NewItemState);
            DisableEditControls();
        }

        private void SelectCurrentItemMenuCategory(ComboBox control, ItemMenu currentItemMenu)
        {
            string currentStateToSelect = currentItemMenu.Categoria.Nome;
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

        private void SelectCurrentItemMenuState(ComboBox control, ItemMenu currentItemMenu)
        {
            string currentStateToSelect = currentItemMenu.Ativo;
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
            TxtBox_SelectedItemName.Enabled = true;
            ComboBox_SelectedItemCategory.Enabled = true;
            RichTxtBox_SelectedItemIngredients.Enabled = true;
            MaskedTxtBox_SelectedItemPrice.Enabled = true;
            ComboBox_SelectedItemState.Enabled = true;
            Btn_SelectedItemPhotograph.Enabled = true;

            Btn_SaveChangesOnSelectedItem.Enabled = true;

            Btn_RemoveItem.Enabled = true;
        }

        private void DisableEditControls()
        {
            TxtBox_SelectedItemName.Enabled = false;
            ComboBox_SelectedItemCategory.Enabled = false;
            RichTxtBox_SelectedItemIngredients.Enabled = false;
            MaskedTxtBox_SelectedItemPrice.Enabled = false;
            ComboBox_SelectedItemState.Enabled = false;
            Btn_SelectedItemPhotograph.Enabled = false;

            Btn_SaveChangesOnSelectedItem.Enabled = false;

            Btn_RemoveItem.Enabled = false;
        }

        private void ResetAddControls()
        {
            TxtBox_NewItemName.ResetText();
            RichTxtBox_NewItemIngredients.ResetText();
            MaskedTxtBox_NewItemPrice.ResetText();

            Resets.ResetSelectedIndex(ComboBox_NewItemCategory);
            Resets.ResetSelectedIndex(ComboBox_NewItemState, 0);
        }

        private void PopulateEditControls()
        {
            TxtBox_SelectedItemName.Text = SingleTown.SelectedItemMenu.Nome;
            RichTxtBox_SelectedItemIngredients.Text = SingleTown.SelectedItemMenu.IngredientesFormated;
            MaskedTxtBox_SelectedItemPrice.Text = String.Format(CultureInfo.GetCultureInfo("pt-PT"), "{0:#,0.00}", SingleTown.SelectedItemMenu.Preco);
            
            SelectCurrentItemMenuState(ComboBox_SelectedItemState, SingleTown.SelectedItemMenu);
            SelectCurrentItemMenuCategory(ComboBox_SelectedItemCategory, SingleTown.SelectedItemMenu);
        }

        private void ResetEditControls()
        {
            TxtBox_SelectedItemName.ResetText();
            ComboBox_SelectedItemCategory.ResetText();
            RichTxtBox_SelectedItemIngredients.ResetText();
            MaskedTxtBox_SelectedItemPrice.ResetText();
            ComboBox_SelectedItemState.ResetText();

            DisableEditControls();
        }

        private void RefreshDataGridView()
        {
            PopulateData.PopulateMenuItemsIntoBindingSource(_restaurant,BindingSource_MenuItems, DataGridView_MenuItems);
        }

        private void Btn_AddItem_Click(object sender, EventArgs e)
        {
            if (StringHelper.IsEmptyOrNull(TxtBox_NewItemName, ComboBox_NewItemCategory, RichTxtBox_NewItemIngredients, MaskedTxtBox_NewItemPrice))
                return;

            try
            {
                string preco = MaskedTxtBox_NewItemPrice.Text;
                decimal precoConverted = Decimal.Parse(preco, CultureInfo.GetCultureInfo("pt-PT"));

                Categoria category = CRUD.GetCategory(ComboBox_NewItemCategory.Text);

                ItemMenu newItemMenu = new ItemMenu
                {
                    Nome = TxtBox_NewItemName.Text,
                    Ingredientes = RichTxtBox_NewItemIngredients.Text,
                    Preco = precoConverted,
                    Fotografia = "",
                    Categoria = category,
                    Ativo = ComboBox_NewItemState.Text
                };

                VerifyData.ExistsItemMenu(newItemMenu);

                CRUD.AddItemMenuToRestaurant(_restaurant, newItemMenu);

                RefreshDataGridView();
                ResetAddControls();
                
            }
            catch (FormatException)
            {
                MessageBox.Show("O preço inserido é inválido!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Btn_AddExistentItem_Click(object sender, EventArgs e)
        {
            ItemMenu itemWanted = (ItemMenu)BaseController.RenderViewAsDialogWithReturn(new GenericSelection(GenericSelection.Reasons.AddExistentItem));
            if (itemWanted == null) return;

            try 
            {
                VerifyData.HasItemOnMenu(itemWanted,_restaurant);

                CRUD.AddItemMenuToRestaurant(_restaurant, itemWanted);

                RefreshDataGridView();
                ResetAddControls();

            } catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            
        }

        private void Btn_ManageCategories_Click(object sender, EventArgs e)
        {
            BaseController.RenderView(new Categories());
        }

        private void DataGridView_MenuItems_SelectionChanged(object sender, EventArgs e)
        {
            if (DataGridView_MenuItems.SelectedRows.Count > 0)
            {
                EnableEditControls();
                string selectedItemName = DataGridView_MenuItems.CurrentRow.Cells[0].Value.ToString();

                ItemMenu selectedItem = CRUD.GetItem(selectedItemName);

                SingleTown.SelectedItemMenu = selectedItem;

                PopulateData.PopulateCategoriesIntoComboBox(ComboBox_SelectedItemCategory);
                PopulateData.PopulateItemStatesIntoComboBox(ComboBox_SelectedItemState);

                PopulateEditControls();
            }
            else
            {
                ResetEditControls();
            }
        }

        private void Btn_SaveChangesOnSelectedItem_Click(object sender, EventArgs e)
        {
            if (StringHelper.IsEmptyOrNull(TxtBox_SelectedItemName, ComboBox_SelectedItemCategory, RichTxtBox_SelectedItemIngredients, MaskedTxtBox_SelectedItemPrice))
                return;

            try
            {
                string preco = MaskedTxtBox_SelectedItemPrice.Text;
                decimal precoConverted = Decimal.Parse(preco, CultureInfo.GetCultureInfo("pt-PT"));

                Categoria category = CRUD.GetCategory(ComboBox_SelectedItemCategory.Text);

                ItemMenu updatedItemMenu = new ItemMenu
                {
                    Nome = TxtBox_SelectedItemName.Text,
                    Ingredientes = RichTxtBox_SelectedItemIngredients.Text,
                    Preco = precoConverted,
                    Fotografia = "",
                    Categoria = category,
                    Ativo = ComboBox_SelectedItemState.Text
                };

                CRUD.EditItemMenu(updatedItemMenu);

                RefreshDataGridView();
            }
            catch (FormatException)
            {
                MessageBox.Show("O preço inserido é inválido!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Btn_RemoveItem_Click(object sender, EventArgs e)
        {
            CRUD.RemoveItemFromMenu();
            RefreshDataGridView();
        }

        private void Btn_ChangeRestaurant_Click(object sender, EventArgs e)
        {
            Restaurante selectedRestaurante = (Restaurante)BaseController.RenderViewAsDialogWithReturn(new SelectRestaurant());
            BaseController.RenderView(new Menu(selectedRestaurante));
        }
    }
}
