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
        }

        private string _reasonToOpen;
        private FontLoader _fontLoader;
       

        public GenericSelection(string reasonToOpen)
        {
            InitializeComponent();

            _reasonToOpen = reasonToOpen;
            _fontLoader = new FontLoader();
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

                    DataGridViewTextBoxColumn columnNome = new DataGridViewTextBoxColumn
                    {
                        HeaderText = "Nome",
                        DataPropertyName = "Nome",
                        ReadOnly = true
                    };

                    DataGridViewTextBoxColumn columnCategory = new DataGridViewTextBoxColumn
                    {
                        HeaderText = "Categoria",
                        DataPropertyName = "CategoriaFormated",
                        ReadOnly = true
                    };

                    allColumnsToDataGrid.Add(columnNome);
                    allColumnsToDataGrid.Add(columnCategory);

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
            }
        }
        private void Btn_Filter_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(TxtBox_Name.Text)) return;

            switch (_reasonToOpen)
            {
                case "AddExistentItem":

                    List<ItemMenu> allItems = SingleTown.AppDB.ItemMenuSet.ToList<ItemMenu>();
                    List<ItemMenu> correctItems = new List<ItemMenu>();

                    foreach(ItemMenu item in allItems)
                    {
                        if (item.Nome.Contains(TxtBox_Name.Text))
                            correctItems.Add(item);
                    }

                    BindingSource_AllStuff.DataSource = correctItems;
                    break;
            }
        }

        private void Btn_Confirm_Click(object sender, EventArgs e)
        {
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
                }
            else
            {
                _dataToReturn = null;
            }
                
        }

        
    }
}
