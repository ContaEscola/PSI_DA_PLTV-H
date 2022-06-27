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

        public static void PopulateOnlyActivePaymentMethodsIntoBindingSource(BindingSource sourceToPopulate, DataGridView gridViewToAdjustContents = null)
        {
            sourceToPopulate.DataSource = (from metodo in SingleTown.AppDB.MetodoPagamentoSet
                                           where metodo.Ativo == "Ativo"
                                           select metodo).ToList<MetodoPagamento>();

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


        public static void PopulateEmployeesIntoBindingSource(Restaurante restaurantAssociated,BindingSource sourceToPopulate, DataGridView gridViewToAdjustContents = null)
        {
            List<Trabalhador>  allEmployees = (from people in SingleTown.AppDB.PessoaSet
                               join employee in SingleTown.AppDB.TrabalhadorSet on people.Id equals employee.Id
                               where employee.IdRestaurante == restaurantAssociated.Id && employee.Ativo == "Ativo"
                               select employee).ToList<Trabalhador>();


            sourceToPopulate.DataSource = allEmployees;

            if (gridViewToAdjustContents != null)
            {
                gridViewToAdjustContents.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
                gridViewToAdjustContents.ClearSelection();
            }

        }

        public static void PopulateClientsIntoBindingSource(BindingSource sourceToPopulate, DataGridView gridViewToAdjustContents = null)
        {
            List<Cliente> allClients = (from client in SingleTown.AppDB.ClienteSet
                                        where client.Ativo == "Ativo"
                                        select client).ToList<Cliente>();


            sourceToPopulate.DataSource = allClients;

            if (gridViewToAdjustContents != null)
            {
                gridViewToAdjustContents.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
                gridViewToAdjustContents.ClearSelection();
            }

        }

        public static void PopulateMenuItemsIntoBindingSource(Restaurante selectedRestaurant,BindingSource sourceToPopulate, DataGridView gridViewToAdjustContents = null)
        {

            List<ItemMenu> allMenuItems = (from menuItem in SingleTown.AppDB.ItemMenuSet
                                           where menuItem.Ativo == "Ativo"
                                            select menuItem).ToList<ItemMenu>();

            List<ItemMenu> allItemsInRestaurante = new List<ItemMenu>();

            foreach (ItemMenu itemMenu in allMenuItems)
            {
                foreach (ItemMenu itemInRestaurant in selectedRestaurant.ItemMenu)
                {
                    if(itemMenu.Id == itemInRestaurant.Id)
                    {
                        allItemsInRestaurante.Add(itemMenu);
                    }
                }
            }

            sourceToPopulate.DataSource = allItemsInRestaurante;

            if (gridViewToAdjustContents != null)
            {
                gridViewToAdjustContents.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
                gridViewToAdjustContents.ClearSelection();
            }
        }

        public static void PopulateCategoriesIntoComboBox(ComboBox combobox)
        {

            List<Categoria> allCategories = (from categorie in SingleTown.AppDB.CategoriaSet
                                             where categorie.Ativo == "Ativo"
                                             select categorie).ToList<Categoria>();

            combobox.Items.Clear();
            foreach (Categoria categorie in allCategories)
            {
                combobox.Items.Add(categorie.Nome);
            }


            combobox.SelectedIndex = -1;
        }

        public static void PopulateItemStatesIntoComboBox(ComboBox comboBox)
        {

            comboBox.Items.Clear();

            comboBox.Items.Add("Ativo");
            comboBox.Items.Add("Inativo");

            comboBox.SelectedIndex = 0;
        }

        public static void PopulateAllItemsIntoBindingSource(BindingSource sourceToPopulate, DataGridView gridViewToAdjustContents = null)
        {
            List<ItemMenu> allMenuItems = (from menuItem in SingleTown.AppDB.ItemMenuSet
                                           where menuItem.Ativo == "Ativo"
                                           select menuItem).ToList<ItemMenu>();

            sourceToPopulate.DataSource = allMenuItems;

            if (gridViewToAdjustContents != null)
            {
                gridViewToAdjustContents.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
                gridViewToAdjustContents.ClearSelection();
            }

        }

        public static void PopulateOrdersIntoBindingSource(Restaurante restauranteToOrders,BindingSource sourceToPopulate, DataGridView gridViewToAdjustContents = null, bool clearSelection = true)
        {
            List<Pedido> allOrders = (from pedido in SingleTown.AppDB.PedidoSet
                                           where pedido.IdRestaurante == restauranteToOrders.Id
                                           select pedido).ToList<Pedido>();

            sourceToPopulate.DataSource = allOrders;

            if (gridViewToAdjustContents != null)
            {
                gridViewToAdjustContents.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);

                if(clearSelection)
                    gridViewToAdjustContents.ClearSelection();
            }

        }
    }
}
