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
    public partial class GenericSelection : Dialog
    {

        public struct Reasons
        {
            public static string AddExistentItem = "AddExistentItem";
            public static string SelectMenu = "SelectMenu";
            public static string SelectEmployee = "SelectEmployee";
            public static string SelectClient = "SelectClient";
        }

        private string _reasonToOpen;
        private FontLoader _fontLoader;
        private Restaurante _restaurant;

        public GenericSelection(string reasonToOpen, Restaurante restaurant = null)
        {
            InitializeComponent();

            _reasonToOpen = reasonToOpen;
            _fontLoader = new FontLoader();
            _restaurant = restaurant;
        }

        //Irá dar load das fontes nos controlos
        private void GenericSelection_Load(object sender, EventArgs e)
        {
            Dictionary<Control, string> fontsForControls = new Dictionary<Control, string>();

            fontsForControls.Add(Lbl_Title, FontLoader.RobotoSlabBold);

            fontsForControls.Add(Lbl_Name, FontLoader.RobotoSlabRegular);
            fontsForControls.Add(TxtBox_Name, FontLoader.RobotoSlabRegular);

            fontsForControls.Add(Btn_Filter, FontLoader.RobotoSlabRegular);

            fontsForControls.Add(Btn_Confirm, FontLoader.RobotoSlabRegular);

            FontFamily fontForDataGrid = _fontLoader.GetFont(FontLoader.RobotoSlabRegular);

            DataGridView_AvailableStuff.ColumnHeadersDefaultCellStyle.Font = new Font(fontForDataGrid, DataGridView_AvailableStuff.ColumnHeadersDefaultCellStyle.Font.Size);
            DataGridView_AvailableStuff.DefaultCellStyle.Font = new Font(fontForDataGrid, DataGridView_AvailableStuff.DefaultCellStyle.Font.Size);

            _fontLoader.LoadFontToControls(fontsForControls);


            List<DataGridViewTextBoxColumn> allColumnsToDataGrid = new List<DataGridViewTextBoxColumn>();

            switch (_reasonToOpen)
            {
                case "AddExistentItem":

                    this.Text = "Selecione o item";
                    Lbl_Title.Text = "Selecione o item a adicionar!";

                    DataGridViewTextBoxColumn columnNomeItem = new DataGridViewTextBoxColumn
                    {
                        HeaderText = "Nome",
                        DataPropertyName = "Nome",
                        ReadOnly = true
                    };

                    DataGridViewTextBoxColumn columnCategoryItem = new DataGridViewTextBoxColumn
                    {
                        HeaderText = "Categoria",
                        DataPropertyName = "CategoriaFormated",
                        ReadOnly = true
                    };

                    allColumnsToDataGrid.Add(columnNomeItem);
                    allColumnsToDataGrid.Add(columnCategoryItem);

                    break;

                case "SelectMenu":

                    this.Text = "Selecione o restaurante";
                    Lbl_Title.Text = "Selecione o restaurante!";

                    DataGridViewTextBoxColumn columnNomeRestaurant = new DataGridViewTextBoxColumn
                    {
                        HeaderText = "Nome",
                        DataPropertyName = "Nome",
                        ReadOnly = true
                    };

                    DataGridViewTextBoxColumn columnCategoryRestaurant = new DataGridViewTextBoxColumn
                    {
                        HeaderText = "Morada",
                        DataPropertyName = "Morada",
                        ReadOnly = true
                    };

                    allColumnsToDataGrid.Add(columnNomeRestaurant);
                    allColumnsToDataGrid.Add(columnCategoryRestaurant);

                    break;

                case "SelectEmployee":

                    this.Text = "Selecione o funcionário";
                    Lbl_Title.Text = "Selecione o funcionário!";

                    DataGridViewTextBoxColumn columnNomeEmployee = new DataGridViewTextBoxColumn
                    {
                        HeaderText = "Nome",
                        DataPropertyName = "Nome",
                        ReadOnly = true
                    };

                    DataGridViewTextBoxColumn columnCategoryEmployee = new DataGridViewTextBoxColumn
                    {
                        HeaderText = "Morada",
                        DataPropertyName = "Morada",
                        ReadOnly = true
                    };

                    allColumnsToDataGrid.Add(columnNomeEmployee);
                    allColumnsToDataGrid.Add(columnCategoryEmployee);

                    break;
                case "SelectClient":

                    this.Text = "Selecione o cliente";
                    Lbl_Title.Text = "Selecione o cliente!";

                    DataGridViewTextBoxColumn columnNomeClient = new DataGridViewTextBoxColumn
                    {
                        HeaderText = "Nome",
                        DataPropertyName = "Nome",
                        ReadOnly = true
                    };

                    DataGridViewTextBoxColumn columnCategoryClient = new DataGridViewTextBoxColumn
                    {
                        HeaderText = "Morada",
                        DataPropertyName = "Morada",
                        ReadOnly = true
                    };

                    allColumnsToDataGrid.Add(columnNomeClient);
                    allColumnsToDataGrid.Add(columnCategoryClient);

                    break;

            }

            AddColumnsToDataGrid(allColumnsToDataGrid);
            RefreshDataGridView();
        }

        private void AddColumnsToDataGrid(List<DataGridViewTextBoxColumn> allColumns)
        {
            foreach (DataGridViewTextBoxColumn column in allColumns)
                DataGridView_AvailableStuff.Columns.Add(column);
        }

        private void RefreshDataGridView()
        {
            switch (_reasonToOpen)
            {
                case "AddExistentItem":
                    PopulateData.PopulateAllItemsIntoBindingSource(BindingSource_AllStuff, DataGridView_AvailableStuff);
                    break;

                case "SelectMenu":
                    PopulateData.PopulateRestaurantsIntoBindingSource(BindingSource_AllStuff, DataGridView_AvailableStuff);
                    break;

                case "SelectEmployee":
                    PopulateData.PopulateEmployeesIntoBindingSource(_restaurant,BindingSource_AllStuff, DataGridView_AvailableStuff);
                    break;

                case "SelectClient":
                    PopulateData.PopulateClientsIntoBindingSource(BindingSource_AllStuff, DataGridView_AvailableStuff);
                    break;
            }
        }
        private void Btn_Filter_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(TxtBox_Name.Text)) {
                RefreshDataGridView();
                return;
            }

                

            switch (_reasonToOpen)
            {
                case "AddExistentItem":

                    List<ItemMenu> allItems = (from menuItem in SingleTown.AppDB.ItemMenuSet
                                               where menuItem.Ativo == "Ativo"
                                               select menuItem).ToList<ItemMenu>();

                    List<ItemMenu> correctItems = new List<ItemMenu>();

                    foreach(ItemMenu item in allItems)
                    {
                        if (item.Nome.Contains(TxtBox_Name.Text))
                            correctItems.Add(item);
                    }

                    BindingSource_AllStuff.DataSource = correctItems;
                    break;

                case "SelectMenu":

                    List<Restaurante> allRestaurants = (from restaurante in SingleTown.AppDB.RestauranteSet
                                               select restaurante).ToList<Restaurante>();

                    List<Restaurante> correctRestaurants = new List<Restaurante>();

                    foreach (Restaurante restaurant in allRestaurants)
                    {
                        if (restaurant.Nome.Contains(TxtBox_Name.Text))
                            correctRestaurants.Add(restaurant);
                    }

                    BindingSource_AllStuff.DataSource = correctRestaurants;
                    break;

                case "SelectEmployee":

                    List<Trabalhador> allEmployees = (from trabalhador in SingleTown.AppDB.TrabalhadorSet
                                                      where trabalhador.Ativo == "Ativo"
                                                        select trabalhador).ToList<Trabalhador>();

                    List<Trabalhador> correctEmployees = new List<Trabalhador>();

                    foreach (Trabalhador trabalhador in allEmployees)
                    {
                        if (trabalhador.Nome.Contains(TxtBox_Name.Text))
                            correctEmployees.Add(trabalhador);
                    }

                    BindingSource_AllStuff.DataSource = correctEmployees;

                    break;

                case "SelectClient":

                    List<Cliente> allClients = (from cliente in SingleTown.AppDB.ClienteSet
                                                      where cliente.Ativo == "Ativo"
                                                      select cliente).ToList<Cliente>();

                    List<Cliente> correctClients = new List<Cliente>();

                    foreach (Cliente client in correctClients)
                    {
                        if (client.Nome.Contains(TxtBox_Name.Text))
                            correctClients.Add(client);
                    }

                    BindingSource_AllStuff.DataSource = correctClients;

                    break;
            }
        }

        private void Btn_Confirm_Click(object sender, EventArgs e)
        {
            if (_dataToReturn == null)
                MessageBox.Show("Escolha um item primeiro!");
            else
                DialogResult = DialogResult.OK;
        }

        private void DataGridView_AvailableStuff_SelectionChanged(object sender, EventArgs e)
        {
            if (DataGridView_AvailableStuff.SelectedRows.Count > 0)
                switch (_reasonToOpen)
                {
                    case "AddExistentItem":

                        string itemName = DataGridView_AvailableStuff.CurrentRow.Cells[0].Value.ToString();
                        ItemMenu item = CRUD.GetItem(itemName);

                        _dataToReturn = item;
                        break;

                    case "SelectMenu":
                        string restaurantName = DataGridView_AvailableStuff.CurrentRow.Cells[0].Value.ToString();
                        Restaurante restaurante = CRUD.GetRestaurant(restaurantName);

                        _dataToReturn = restaurante;
                        break;

                    case "SelectEmployee":
                        string employeeName = DataGridView_AvailableStuff.CurrentRow.Cells[0].Value.ToString();
                        Trabalhador employee = CRUD.GetEmployee(employeeName);

                        _dataToReturn = employee;
                        break;

                    case "SelectClient":
                        string clientName = DataGridView_AvailableStuff.CurrentRow.Cells[0].Value.ToString();
                        Cliente client = CRUD.GetClient(clientName);

                        _dataToReturn = client;
                        break;
                }
            else
            {
                _dataToReturn = null;
            }
                
        }

        
    }
}
