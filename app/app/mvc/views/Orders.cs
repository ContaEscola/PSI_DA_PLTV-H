using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace app
{
    public partial class Orders : Form
    {
        private struct Phase
        {
            public static string Received = "Received";
            public static string InProgress = "InProgress";
            public static string Completed = "Completed";
        }

        private FontLoader _fontLoader;
        private Restaurante _restaurant;

        private Trabalhador _selectedEmployee;
        private Cliente _selectedClient;
        private MetodoPagamento _selectedPagamento;

        public Orders(Restaurante restaurant)
        {
            InitializeComponent();

            _fontLoader = new FontLoader();
            _restaurant = restaurant;
        }

        //Irá dar load das fontes em todos os controlos do form
        private void Orders_Load(object sender, EventArgs e)
        {
            Dictionary<Control, string> fontsForControls = new Dictionary<Control, string>();

            fontsForControls.Add(Lbl_Orders, FontLoader.RobotoSlabBold);
            fontsForControls.Add(Lbl_Restaurant, FontLoader.RobotoSlabExtraLight);
            fontsForControls.Add(Lbl_RestaurantName, FontLoader.RobotoSlabRegular);
            fontsForControls.Add(Btn_ChangeRestaurant, FontLoader.RobotoSlabRegular);

            fontsForControls.Add(Lbl_AddOrder, FontLoader.RobotoSlabLight);
            fontsForControls.Add(Lbl_Worker, FontLoader.RobotoSlabRegular);
            fontsForControls.Add(Btn_ChooseWorker, FontLoader.RobotoSlabRegular);
            fontsForControls.Add(Lbl_Client, FontLoader.RobotoSlabRegular);
            fontsForControls.Add(Btn_ChooseClient, FontLoader.RobotoSlabRegular);
            fontsForControls.Add(Btn_AddNewOrder, FontLoader.RobotoSlabRegular);

            fontsForControls.Add(Lbl_AddItem, FontLoader.RobotoSlabLight);
            fontsForControls.Add(Lbl_Item, FontLoader.RobotoSlabRegular);
            fontsForControls.Add(Btn_ChooseItem, FontLoader.RobotoSlabRegular);
            fontsForControls.Add(Btn_AddItem, FontLoader.RobotoSlabRegular);

            fontsForControls.Add(Lbl_AddPayment, FontLoader.RobotoSlabRegular);
            fontsForControls.Add(Lbl_PaymentMethod, FontLoader.RobotoSlabRegular);
            fontsForControls.Add(Btn_ChoosePaymentMethod, FontLoader.RobotoSlabRegular);
            fontsForControls.Add(Lbl_PaymentValue, FontLoader.RobotoSlabRegular);
            fontsForControls.Add(MaskedTxtBox_PaymentValue, FontLoader.RobotoSlabRegular);

            fontsForControls.Add(Btn_ProgressOrder, FontLoader.RobotoSlabRegular);
            fontsForControls.Add(Btn_ConcludeOrder, FontLoader.RobotoSlabRegular);
            fontsForControls.Add(Btn_CancelOrder, FontLoader.RobotoSlabRegular);
            fontsForControls.Add(Btn_ExportOrder, FontLoader.RobotoSlabRegular);


            fontsForControls.Add(Lbl_OrderPrice, FontLoader.RobotoSlabRegular);
            fontsForControls.Add(MaskedTxtBox_OrderPrice, FontLoader.RobotoSlabRegular);

            _fontLoader.LoadFontToControls(fontsForControls);


            FontFamily fontForDataGrid = _fontLoader.GetFont(FontLoader.RobotoSlabRegular);
            DataGridView_Orders.ColumnHeadersDefaultCellStyle.Font = new Font(fontForDataGrid, DataGridView_Orders.ColumnHeadersDefaultCellStyle.Font.Size);
            DataGridView_Orders.DefaultCellStyle.Font = new Font(fontForDataGrid, DataGridView_Orders.DefaultCellStyle.Font.Size);


            Lbl_AddOrder.BringToFront();
            Lbl_AddItem.BringToFront();
            Lbl_AddPayment.BringToFront();

            this.Text = $"Pedidos: {_restaurant.Nome}";
            Lbl_RestaurantName.Text = _restaurant.Nome;

            RefreshDataGridView();
            DisableEditControls();
        }


        private void EnableEditControls(string phase)
        {
            switch (phase)
            {
                case "Received":
                    Btn_ProgressOrder.Enabled = true;

                    //Btn_ChooseItem.Enabled = true;
                    //Btn_AddItem.Enabled = true;

                    Btn_ChoosePaymentMethod.Enabled = false;
                    MaskedTxtBox_PaymentValue.Enabled = false;
                    Btn_AddPayment.Enabled = false;

                    Btn_CancelOrder.Enabled = false;
                    Btn_ConcludeOrder.Enabled = false;

                    Btn_ExportOrder.Enabled = false;

                    break;

                case "InProgress":

                    Btn_ProgressOrder.Enabled = false;

                    //Btn_ChooseItem.Enabled = true;
                    //Btn_AddItem.Enabled = true;

                    Btn_ChoosePaymentMethod.Enabled = true;
                    MaskedTxtBox_PaymentValue.Enabled = true;
                    Btn_AddPayment.Enabled = true;

                    Btn_CancelOrder.Enabled = true;
                    Btn_ConcludeOrder.Enabled = true;

                    Btn_ExportOrder.Enabled = false;

                    break;

                case "Completed":

                    Btn_ProgressOrder.Enabled = false;

                    //Btn_ChooseItem.Enabled = true;
                    //Btn_AddItem.Enabled = true;

                    Btn_ChoosePaymentMethod.Enabled = false;
                    MaskedTxtBox_PaymentValue.Enabled = false;
                    Btn_AddPayment.Enabled = false;

                    Btn_CancelOrder.Enabled = false;
                    Btn_ConcludeOrder.Enabled = false;

                    Btn_ExportOrder.Enabled = true;
                    break;

                default:
                    DisableEditControls();
                    break;
            } 
        }

        private string GetCurrentPhase (string estado)
        {
            switch(estado)
            {
                case "Recebido":
                    return Orders.Phase.Received;
                case "Em Processamento":
                    return Orders.Phase.InProgress;
                case "Concluído":
                    return Orders.Phase.Completed;
                default:
                    return "Cancelado";
            }
        }

        private void DisableEditControls()
        {
            Btn_ChooseItem.Enabled = false;
            Btn_AddItem.Enabled = false;

            Btn_ChoosePaymentMethod.Enabled = false;
            MaskedTxtBox_PaymentValue.Enabled = false;
            Btn_AddPayment.Enabled = false;


            Btn_ProgressOrder.Enabled = false;
            Btn_CancelOrder.Enabled = false;
            Btn_ConcludeOrder.Enabled = false;
            Btn_ExportOrder.Enabled = false;
        }

        private void ResetEditControls()
        {
            Btn_ChooseItem.Text = "escolher";
            Btn_ChoosePaymentMethod.Text = "escolher";
            MaskedTxtBox_PaymentValue.ResetText();
            _selectedPagamento = null;

            DisableEditControls();
        }

        private void ResetAddControls()
        {
            Btn_ChooseWorker.ResetText();
            Btn_ChooseClient.ResetText();
            MaskedTxtBox_OrderPrice.ResetText();
            _selectedClient = null;
            _selectedEmployee = null;
        }
        private void RefreshDataGridView(bool clearSelection = true)
        {
            PopulateData.PopulateOrdersIntoBindingSource(_restaurant, BindingSource_AllOrders, DataGridView_Orders, clearSelection);
        }

        private void Btn_ChangeRestaurant_Click(object sender, EventArgs e)
        {
            Restaurante selectedRestaurant = (Restaurante)BaseController.RenderViewAsDialogWithReturn(new GenericSelection(GenericSelection.Reasons.SelectMenu));
            if(selectedRestaurant != null)
                BaseController.RenderView(new Orders(selectedRestaurant));
        }

        private void Btn_ChooseWorker_Click(object sender, EventArgs e)
        {

            _selectedEmployee = (Trabalhador)BaseController.RenderViewAsDialogWithReturn(new GenericSelection(GenericSelection.Reasons.SelectEmployee,_restaurant));
            if(_selectedEmployee != null)
                Btn_ChooseWorker.Text = _selectedEmployee.Nome;
        }

        private void Btn_ChooseClient_Click(object sender, EventArgs e)
        {
            _selectedClient = (Cliente)BaseController.RenderViewAsDialogWithReturn(new GenericSelection(GenericSelection.Reasons.SelectClient));
            if(_selectedClient != null)
                Btn_ChooseClient.Text = _selectedClient.Nome;
        }

        private void Btn_AddNewOrder_Click(object sender, EventArgs e)
        {
            try
            {
                if (String.IsNullOrEmpty(MaskedTxtBox_OrderPrice.Text))
                    throw new Exception("Preço do pedido inválido!");

                if (_selectedClient == null)
                    throw new Exception("Escolha o cliente associado ao pedido!");
                

                if (_selectedEmployee == null)
                    throw new Exception("Escolha o funcionário associado ao pedido!");

                string orderPrice = MaskedTxtBox_OrderPrice.Text;
                decimal orderPriceConverted = Decimal.Parse(orderPrice, CultureInfo.GetCultureInfo("pt-PT"));

                Pedido newOrder = new Pedido
                {
                    ValorTotal = orderPriceConverted,
                    IdTrabalhador = _selectedEmployee.Id,
                    IdCliente = _selectedClient.Id,
                    IdRestaurante = _restaurant.Id,
                    IdEstado = 1,
                    Trabalhador = _selectedEmployee
                };

                CRUD.AddOrder(newOrder);
                RefreshDataGridView();
                ResetAddControls();

            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void DataGridView_Orders_SelectionChanged(object sender, EventArgs e)
        {
            if (DataGridView_Orders.SelectedRows.Count > 0)
            {
                

                int orderId = Convert.ToInt16(DataGridView_Orders.CurrentRow.Cells[0].Value.ToString());

                Pedido selectedOrder = CRUD.GetOrder(orderId);

                SingleTown.SelectedOrder = selectedOrder;

                string currentPhase = GetCurrentPhase(SingleTown.SelectedOrder.Estado.State);

                EnableEditControls(currentPhase);
            }
            else
            {
                ResetEditControls();
            }
        }

        private void Btn_ProgressOrder_Click(object sender, EventArgs e)
        {
            CRUD.ProgressOrder(SingleTown.SelectedOrder);
            RefreshDataGridView(false);
        }

        private void Btn_ChoosePaymentMethod_Click(object sender, EventArgs e)
        {
            _selectedPagamento = (MetodoPagamento)BaseController.RenderViewAsDialogWithReturn(new GenericSelection(GenericSelection.Reasons.SelectMetodoPagamento));
            if(_selectedPagamento != null)
                Btn_ChoosePaymentMethod.Text = _selectedPagamento.Metodo;
        }

        private void Btn_AddPayment_Click(object sender, EventArgs e)
        {
            try
            {
                if (_selectedPagamento == null)
                    throw new Exception("Escolha um método de pagamento!");

                string pagamentoValue = MaskedTxtBox_PaymentValue.Text;
                decimal pagamentoValueConverted = Decimal.Parse(pagamentoValue, CultureInfo.GetCultureInfo("pt-PT"));

                Pagamento newPagamento = new Pagamento
                {
                    Valor = pagamentoValueConverted,
                    IdPedido = SingleTown.SelectedOrder.Id,
                    IdMetodoPagamento = _selectedPagamento.Id
                };


                CRUD.AddPaymentToOrder(newPagamento);
                RefreshDataGridView(false);
            }
            catch (FormatException)
            {
                MessageBox.Show("O valor de pagamento inserido é inválido!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void Btn_ConcludeOrder_Click(object sender, EventArgs e)
        {
            CRUD.ConcludeOrder(SingleTown.SelectedOrder);
            RefreshDataGridView(false);
        }

        private void Btn_CancelOrder_Click(object sender, EventArgs e)
        {
            CRUD.CancelOrder(SingleTown.SelectedOrder);
            RefreshDataGridView();
        }

        private void Btn_ExportOrder_Click(object sender, EventArgs e)
        {
            try
            {
                var dirInfo = new DirectoryInfo(@"C:\PedidosExportados");

                if (!dirInfo.Exists)
                    dirInfo.Create();

                var fileName = $"{SingleTown.SelectedOrder.Id.ToString()}_{SingleTown.SelectedOrder.Cliente.Nome}";
                var directory = @"C:\PedidosExportados";

                string filePath = Path.Combine(directory, fileName);

                string formatedContent = $"Pedido: {SingleTown.SelectedOrder.Id};{Environment.NewLine}" +
                                         $"Cliente: {SingleTown.SelectedOrder.Cliente.Nome};{Environment.NewLine}" +
                                         $"Funcionário: {SingleTown.SelectedOrder.Trabalhador.Nome};{Environment.NewLine}" +
                                         $"------------------------------------------------------------------------------{Environment.NewLine}" +
                                         $"Valor Total: {SingleTown.SelectedOrder.ValorTotalFormated};{Environment.NewLine}";

                int counter = 0;
                foreach(Pagamento pagamento in SingleTown.SelectedOrder.Pagamento)
                {
                    counter++;
                    formatedContent += $"{counter}º Pagamento: {pagamento.MetodoPagamento.Metodo}; Valor: {pagamento.Valor};{Environment.NewLine}";
                }

                File.WriteAllText(filePath,formatedContent);

                MessageBox.Show("Pedido exportado com sucesso para: C:\\PedidosExportados");

            } catch(Exception)
            {
                MessageBox.Show("Não foi possível exportar o ficheiro txt para a localização C:\\PedidosExportados");

            }
        }
    }
}
