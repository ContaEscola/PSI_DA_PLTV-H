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
        private List<ItemMenu> lista;

        public Menu(Restaurante restaurant)
        {
            InitializeComponent();

            _restaurant = restaurant;
            _fontLoader = new FontLoader();



            lista = new List<ItemMenu>();

            lista.Add(new ItemMenu()
            {
                Nome = RichTxtBox_SelectedItemIngredients.Text,
                Ingredientes = RichTxtBox_NewItemIngredients.Text,
            });



            // Ba listView não é possível carregar por DataSource
            refreshlistcomida();

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

            _fontLoader.LoadFontToControls(fontsForControls);

            FontFamily fontForListView = _fontLoader.GetFont(FontLoader.RobotoSlabRegular);
            ListView_MenuItems.Font = new Font(fontForListView, ListView_MenuItems.Font.Size);

            Lbl_AddItem.BringToFront();
            Lbl_EditItem.BringToFront();


            this.Text = $"Restaurante: {_restaurant.Nome}";
            Lbl_RestaurantName.Text = _restaurant.Nome;

            refreshlistcomida();
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
        private void refreshlistcomida()
        {
            ListView_MenuItems.Items.Clear();
            int i = 0;
            foreach (ItemMenu itemMenu in lista)
            {
                var linha = new string[]
                {
                    itemMenu.Nome,
                    string.Format("{0} TEST", itemMenu.Nome),
                    string.Format("{0} CV", itemMenu.Ingredientes),
                };

                ListViewItem lvi = new ListViewItem(linha, i++);
                lvi.Tag = itemMenu;
                ListView_MenuItems.Items.Add(lvi);
            }
        }



        private void RefreshListview()
        {
            PopulateData.PopulateAllCategories(ComboBox_NewItemCategory);
        }

    }
}
