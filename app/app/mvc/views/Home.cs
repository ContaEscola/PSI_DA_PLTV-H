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
    public partial class Home : Form
    {
        private FontLoader _fontLoader;

        public Home()
        {
            InitializeComponent();

            _fontLoader = new FontLoader();
        }

        private void Home_Load(object sender, EventArgs e)
        {
            ToolStripMenuItem[] toolStripItemsToLoadFont = 
            { 
                ToolStripMenuItem_Restaurants, ToolStripMenuItem_Clients, ToolStripMenuItem_Menu, ToolStripMenuItem_Orders,
                ToolStripMenuItem_ManageSingleRestaurant, ToolStripMenuItem_ManageSingleClient, ToolStripMenuItem_ManageSingleMenu, ToolStripMenuItem_ManageSingleOrder,
            };
            string[] fontsForToolStripItems =
            {
                FontLoader.RobotoSlabRegular, FontLoader.RobotoSlabRegular, FontLoader.RobotoSlabRegular, FontLoader.RobotoSlabRegular,
                FontLoader.RobotoSlabRegular, FontLoader.RobotoSlabRegular, FontLoader.RobotoSlabRegular, FontLoader.RobotoSlabRegular
            };

            _fontLoader.LoadFontToToolStrips(toolStripItemsToLoadFont, fontsForToolStripItems);

            Control[] controlsToLoadFont =
            {
                Lbl_ChooseFunctionalities,
                Lbl_Restaurantes, Lbl_Clientes,
                Btn_RestaurantGlobalManagement,Btn_ClientsGlobalManagement
            };

            string[] fontsForControls =
            {
                FontLoader.RobotoSlabBold,
                FontLoader.RobotoSlabLight, FontLoader.RobotoSlabLight,
                FontLoader.RobotoSlabRegular, FontLoader.RobotoSlabRegular
            };

            _fontLoader.LoadFontToControls(controlsToLoadFont, fontsForControls);



            Lbl_Restaurantes.BringToFront();
            Lbl_Clientes.BringToFront();

            Console.WriteLine(Btn_RestaurantGlobalManagement);
        }
    }
}
