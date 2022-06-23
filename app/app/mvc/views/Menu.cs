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

            PopulateData.PopulateAllCategories(ComboBox_NewItemCategory);

        }

        private void Btn_AddItem_Click(object sender, EventArgs e)
        {
            if (StringHelper.IsEmptyOrNull(TxtBox_NewItemName, RichTxtBox_NewItemIngredients, MaskedTxtBox_NewItemPrice, ComboBox_NewItemState))
                return;

           /* try
            {
                string nome = TxtBox_NewItemName.Text;
                string ingredientes = RichTxtBox_NewItemIngredients.Text;
                string preco = MaskedTxtBox_NewItemPrice.Text;
                StringHelper.RemoveEuroFromString(ref preco);



            }*/


        }

        private void RefreshListview()
        {
            PopulateData.PopulateAllCategories(ComboBox_NewItemCategory);
        }

    }
}
