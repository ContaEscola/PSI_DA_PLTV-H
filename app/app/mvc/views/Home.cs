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


        //Irá dar load das fontes em todos os controlos do form
        private void Home_Load(object sender, EventArgs e)
        {

            Dictionary<ToolStripMenuItem, string> fontsForToolStripItems = new Dictionary<ToolStripMenuItem, string>();

            fontsForToolStripItems.Add( ToolStripMenuItem_Restaurants, FontLoader.RobotoSlabRegular);
            fontsForToolStripItems.Add( ToolStripMenuItem_Clients, FontLoader.RobotoSlabRegular);
            fontsForToolStripItems.Add( ToolStripMenuItem_Menu, FontLoader.RobotoSlabRegular);
            fontsForToolStripItems.Add( ToolStripMenuItem_Orders, FontLoader.RobotoSlabRegular);

            fontsForToolStripItems.Add( ToolStripMenuItem_ManageSingleRestaurant, FontLoader.RobotoSlabRegular);
            fontsForToolStripItems.Add( ToolStripMenuItem_ManageAllClients, FontLoader.RobotoSlabRegular);
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

        private void Btn_RestaurantGlobalManagement_Click(object sender, EventArgs e)
        {
            GlobalRestaurants globalRestaurants = new GlobalRestaurants();
            BaseController.RenderView(globalRestaurants);
        }

        private void Btn_ClientsGlobalManagement_Click(object sender, EventArgs e)
        {
            Clients clientsView = new Clients();
            BaseController.RenderView(clientsView);
        }

        private void ToolStripMenuItem_ManageSingleRestaurant_Click(object sender, EventArgs e)
        {
            Restaurante selectedRestaurante = (Restaurante)BaseController.RenderViewAsDialogWithReturn(new SelectRestaurant());
            if(selectedRestaurante != null)
                BaseController.RenderView(new Restaurant(selectedRestaurante));
        }

        private void ToolStripMenuItem_ManageAllClients_Click(object sender, EventArgs e)
        {
            Clients globalClients = new Clients();
            BaseController.RenderView(globalClients);
        }

        private void ToolStripMenuItem_ManageSingleMenu_Click(object sender, EventArgs e)
        {
            Restaurante selectedRestaurant = (Restaurante)BaseController.RenderViewAsDialogWithReturn(new GenericSelection(GenericSelection.Reasons.SelectMenu));
            if(selectedRestaurant != null)
                BaseController.RenderView(new Menu(selectedRestaurant));
        }

        private void ToolStripMenuItem_ManageSingleOrder_Click(object sender, EventArgs e)
        {
            Restaurante selectedRestaurant = (Restaurante)BaseController.RenderViewAsDialogWithReturn(new GenericSelection(GenericSelection.Reasons.SelectMenu));
            if(selectedRestaurant != null)
                BaseController.RenderView(new Orders(selectedRestaurant));
        }
    }
}
