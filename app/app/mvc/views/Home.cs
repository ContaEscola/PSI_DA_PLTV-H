﻿using System;
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
        private SingleTown _singleTownManager;
        private HomeController _myController;
        private FontLoader _fontLoader;

        internal SingleTown SingleTownManager { get { return _singleTownManager; } }

        public Home()
        {
            InitializeComponent();

            _singleTownManager = new SingleTown();
            _myController = new HomeController(this);
            _fontLoader = new FontLoader();
        }


        //Irá dar load das fontes em todos os controlos do form
        private void Home_Load(object sender, EventArgs e)
        {

            Dictionary<ToolStripMenuItem, string> fontsForToolStripItems = new Dictionary<ToolStripMenuItem, string>();

            fontsForToolStripItems.Add( ToolStripMenuItem_Restaurants, FontLoader.RobotoSlabRegular);
            fontsForToolStripItems.Add( ToolStripMenuItem_Clients, FontLoader.RobotoSlabRegular);
            fontsForToolStripItems.Add( ToolStripMenuItem_Menu, FontLoader.RobotoSlabRegular);
            fontsForToolStripItems.Add( ToolStripMenuItem_Orders, FontLoader.RobotoSlabRegular);

            fontsForToolStripItems.Add( ToolStripMenuItem_ManageSingleRestaurant, FontLoader.RobotoSlabRegular);
            fontsForToolStripItems.Add( ToolStripMenuItem_ManageSingleClient, FontLoader.RobotoSlabRegular);
            fontsForToolStripItems.Add( ToolStripMenuItem_ManageSingleMenu, FontLoader.RobotoSlabRegular);
            fontsForToolStripItems.Add( ToolStripMenuItem_ManageSingleOrder, FontLoader.RobotoSlabRegular);

            _fontLoader.LoadFontToToolStrips(fontsForToolStripItems);



            Dictionary<Control, string> fontsForControls = new Dictionary<Control, string>();

            fontsForControls.Add( Lbl_ChooseFunctionalities, FontLoader.RobotoSlabBold);

            fontsForControls.Add( Lbl_Restaurantes, FontLoader.RobotoSlabLight);
            fontsForControls.Add( Btn_RestaurantGlobalManagement, FontLoader.RobotoSlabRegular);

            fontsForControls.Add( Lbl_Clientes, FontLoader.RobotoSlabLight);
            fontsForControls.Add( Btn_ClientsGlobalManagement, FontLoader.RobotoSlabRegular);


            _fontLoader.LoadFontToControls(fontsForControls);



            Lbl_Restaurantes.BringToFront();
            Lbl_Clientes.BringToFront();

        }
    }
}
