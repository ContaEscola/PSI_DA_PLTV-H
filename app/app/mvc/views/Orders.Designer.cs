
namespace app
{
    partial class Orders
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Lbl_Orders = new System.Windows.Forms.Label();
            this.Lbl_Restaurant = new System.Windows.Forms.Label();
            this.Lbl_RestaurantName = new System.Windows.Forms.Label();
            this.Lbl_AddOrder = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.MaskedTxtBox_OrderPrice = new System.Windows.Forms.MaskedTextBox();
            this.Lbl_OrderPrice = new System.Windows.Forms.Label();
            this.Btn_AddNewOrder = new System.Windows.Forms.Button();
            this.Btn_ChooseClient = new System.Windows.Forms.Button();
            this.Lbl_Client = new System.Windows.Forms.Label();
            this.Btn_ChooseWorker = new System.Windows.Forms.Button();
            this.Lbl_Worker = new System.Windows.Forms.Label();
            this.Lbl_AddItem = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Btn_AddItem = new System.Windows.Forms.Button();
            this.Btn_ChooseItem = new System.Windows.Forms.Button();
            this.Lbl_Item = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.MaskedTxtBox_PaymentValue = new System.Windows.Forms.MaskedTextBox();
            this.Lbl_PaymentValue = new System.Windows.Forms.Label();
            this.Btn_AddPayment = new System.Windows.Forms.Button();
            this.Btn_ChoosePaymentMethod = new System.Windows.Forms.Button();
            this.Lbl_PaymentMethod = new System.Windows.Forms.Label();
            this.Lbl_AddPayment = new System.Windows.Forms.Label();
            this.Panel_PaddingBottom = new System.Windows.Forms.Panel();
            this.DataGridView_Orders = new System.Windows.Forms.DataGridView();
            this.BindingSource_AllOrders = new System.Windows.Forms.BindingSource(this.components);
            this.Btn_ChangeRestaurant = new System.Windows.Forms.Button();
            this.Btn_ProgressOrder = new System.Windows.Forms.Button();
            this.Btn_ExportOrder = new System.Windows.Forms.Button();
            this.Btn_ConcludeOrder = new System.Windows.Forms.Button();
            this.Btn_CancelOrder = new System.Windows.Forms.Button();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView_Orders)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BindingSource_AllOrders)).BeginInit();
            this.SuspendLayout();
            // 
            // Lbl_Orders
            // 
            this.Lbl_Orders.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Lbl_Orders.AutoSize = true;
            this.Lbl_Orders.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Orders.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(52)))), ((int)(((byte)(22)))));
            this.Lbl_Orders.Location = new System.Drawing.Point(37, 108);
            this.Lbl_Orders.Margin = new System.Windows.Forms.Padding(0);
            this.Lbl_Orders.Name = "Lbl_Orders";
            this.Lbl_Orders.Size = new System.Drawing.Size(132, 37);
            this.Lbl_Orders.TabIndex = 0;
            this.Lbl_Orders.Text = "Pedidos";
            // 
            // Lbl_Restaurant
            // 
            this.Lbl_Restaurant.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Lbl_Restaurant.AutoSize = true;
            this.Lbl_Restaurant.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Restaurant.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(52)))), ((int)(((byte)(22)))));
            this.Lbl_Restaurant.Location = new System.Drawing.Point(39, 150);
            this.Lbl_Restaurant.Margin = new System.Windows.Forms.Padding(0);
            this.Lbl_Restaurant.Name = "Lbl_Restaurant";
            this.Lbl_Restaurant.Size = new System.Drawing.Size(123, 25);
            this.Lbl_Restaurant.TabIndex = 1;
            this.Lbl_Restaurant.Text = "Restaurante:";
            this.Lbl_Restaurant.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Lbl_RestaurantName
            // 
            this.Lbl_RestaurantName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Lbl_RestaurantName.AutoSize = true;
            this.Lbl_RestaurantName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_RestaurantName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(52)))), ((int)(((byte)(22)))));
            this.Lbl_RestaurantName.Location = new System.Drawing.Point(162, 154);
            this.Lbl_RestaurantName.Margin = new System.Windows.Forms.Padding(0);
            this.Lbl_RestaurantName.Name = "Lbl_RestaurantName";
            this.Lbl_RestaurantName.Size = new System.Drawing.Size(63, 20);
            this.Lbl_RestaurantName.TabIndex = 2;
            this.Lbl_RestaurantName.Text = "######";
            // 
            // Lbl_AddOrder
            // 
            this.Lbl_AddOrder.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Lbl_AddOrder.AutoSize = true;
            this.Lbl_AddOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_AddOrder.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(52)))), ((int)(((byte)(22)))));
            this.Lbl_AddOrder.Location = new System.Drawing.Point(64, 217);
            this.Lbl_AddOrder.Margin = new System.Windows.Forms.Padding(0);
            this.Lbl_AddOrder.Name = "Lbl_AddOrder";
            this.Lbl_AddOrder.Size = new System.Drawing.Size(198, 29);
            this.Lbl_AddOrder.TabIndex = 3;
            this.Lbl_AddOrder.Text = "Adicionar Pedido";
            this.Lbl_AddOrder.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.panel1.Controls.Add(this.MaskedTxtBox_OrderPrice);
            this.panel1.Controls.Add(this.Lbl_OrderPrice);
            this.panel1.Controls.Add(this.Btn_AddNewOrder);
            this.panel1.Controls.Add(this.Btn_ChooseClient);
            this.panel1.Controls.Add(this.Lbl_Client);
            this.panel1.Controls.Add(this.Btn_ChooseWorker);
            this.panel1.Controls.Add(this.Lbl_Worker);
            this.panel1.Location = new System.Drawing.Point(44, 236);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(520, 171);
            this.panel1.TabIndex = 4;
            // 
            // MaskedTxtBox_OrderPrice
            // 
            this.MaskedTxtBox_OrderPrice.BackColor = System.Drawing.Color.White;
            this.MaskedTxtBox_OrderPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaskedTxtBox_OrderPrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(52)))), ((int)(((byte)(22)))));
            this.MaskedTxtBox_OrderPrice.Location = new System.Drawing.Point(83, 76);
            this.MaskedTxtBox_OrderPrice.Margin = new System.Windows.Forms.Padding(0);
            this.MaskedTxtBox_OrderPrice.Name = "MaskedTxtBox_OrderPrice";
            this.MaskedTxtBox_OrderPrice.Size = new System.Drawing.Size(182, 23);
            this.MaskedTxtBox_OrderPrice.TabIndex = 18;
            // 
            // Lbl_OrderPrice
            // 
            this.Lbl_OrderPrice.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Lbl_OrderPrice.AutoSize = true;
            this.Lbl_OrderPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_OrderPrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(52)))), ((int)(((byte)(22)))));
            this.Lbl_OrderPrice.Location = new System.Drawing.Point(21, 77);
            this.Lbl_OrderPrice.Margin = new System.Windows.Forms.Padding(0);
            this.Lbl_OrderPrice.Name = "Lbl_OrderPrice";
            this.Lbl_OrderPrice.Size = new System.Drawing.Size(50, 20);
            this.Lbl_OrderPrice.TabIndex = 8;
            this.Lbl_OrderPrice.Text = "Valor:";
            this.Lbl_OrderPrice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Btn_AddNewOrder
            // 
            this.Btn_AddNewOrder.AutoSize = true;
            this.Btn_AddNewOrder.BackColor = System.Drawing.Color.White;
            this.Btn_AddNewOrder.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_AddNewOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_AddNewOrder.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(52)))), ((int)(((byte)(22)))));
            this.Btn_AddNewOrder.Location = new System.Drawing.Point(20, 112);
            this.Btn_AddNewOrder.Margin = new System.Windows.Forms.Padding(0);
            this.Btn_AddNewOrder.Name = "Btn_AddNewOrder";
            this.Btn_AddNewOrder.Size = new System.Drawing.Size(480, 40);
            this.Btn_AddNewOrder.TabIndex = 5;
            this.Btn_AddNewOrder.Text = "Adicionar";
            this.Btn_AddNewOrder.UseVisualStyleBackColor = false;
            this.Btn_AddNewOrder.Click += new System.EventHandler(this.Btn_AddNewOrder_Click);
            // 
            // Btn_ChooseClient
            // 
            this.Btn_ChooseClient.AutoSize = true;
            this.Btn_ChooseClient.BackColor = System.Drawing.Color.White;
            this.Btn_ChooseClient.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_ChooseClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_ChooseClient.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(52)))), ((int)(((byte)(22)))));
            this.Btn_ChooseClient.Location = new System.Drawing.Point(356, 37);
            this.Btn_ChooseClient.Margin = new System.Windows.Forms.Padding(0);
            this.Btn_ChooseClient.Name = "Btn_ChooseClient";
            this.Btn_ChooseClient.Size = new System.Drawing.Size(144, 27);
            this.Btn_ChooseClient.TabIndex = 6;
            this.Btn_ChooseClient.Text = "escolher";
            this.Btn_ChooseClient.UseVisualStyleBackColor = false;
            this.Btn_ChooseClient.Click += new System.EventHandler(this.Btn_ChooseClient_Click);
            // 
            // Lbl_Client
            // 
            this.Lbl_Client.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Lbl_Client.AutoSize = true;
            this.Lbl_Client.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Client.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(52)))), ((int)(((byte)(22)))));
            this.Lbl_Client.Location = new System.Drawing.Point(284, 40);
            this.Lbl_Client.Margin = new System.Windows.Forms.Padding(0);
            this.Lbl_Client.Name = "Lbl_Client";
            this.Lbl_Client.Size = new System.Drawing.Size(62, 20);
            this.Lbl_Client.TabIndex = 7;
            this.Lbl_Client.Text = "Cliente:";
            this.Lbl_Client.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Btn_ChooseWorker
            // 
            this.Btn_ChooseWorker.AutoSize = true;
            this.Btn_ChooseWorker.BackColor = System.Drawing.Color.White;
            this.Btn_ChooseWorker.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_ChooseWorker.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_ChooseWorker.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(52)))), ((int)(((byte)(22)))));
            this.Btn_ChooseWorker.Location = new System.Drawing.Point(135, 37);
            this.Btn_ChooseWorker.Margin = new System.Windows.Forms.Padding(0);
            this.Btn_ChooseWorker.Name = "Btn_ChooseWorker";
            this.Btn_ChooseWorker.Size = new System.Drawing.Size(130, 27);
            this.Btn_ChooseWorker.TabIndex = 5;
            this.Btn_ChooseWorker.Text = "escolher";
            this.Btn_ChooseWorker.UseVisualStyleBackColor = false;
            this.Btn_ChooseWorker.Click += new System.EventHandler(this.Btn_ChooseWorker_Click);
            // 
            // Lbl_Worker
            // 
            this.Lbl_Worker.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Lbl_Worker.AutoSize = true;
            this.Lbl_Worker.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Worker.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(52)))), ((int)(((byte)(22)))));
            this.Lbl_Worker.Location = new System.Drawing.Point(20, 40);
            this.Lbl_Worker.Margin = new System.Windows.Forms.Padding(0);
            this.Lbl_Worker.Name = "Lbl_Worker";
            this.Lbl_Worker.Size = new System.Drawing.Size(98, 20);
            this.Lbl_Worker.TabIndex = 5;
            this.Lbl_Worker.Text = "Trabalhador:";
            this.Lbl_Worker.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Lbl_AddItem
            // 
            this.Lbl_AddItem.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Lbl_AddItem.AutoSize = true;
            this.Lbl_AddItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_AddItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(52)))), ((int)(((byte)(22)))));
            this.Lbl_AddItem.Location = new System.Drawing.Point(64, 473);
            this.Lbl_AddItem.Margin = new System.Windows.Forms.Padding(0);
            this.Lbl_AddItem.Name = "Lbl_AddItem";
            this.Lbl_AddItem.Size = new System.Drawing.Size(166, 29);
            this.Lbl_AddItem.TabIndex = 5;
            this.Lbl_AddItem.Text = "Adicionar Item";
            this.Lbl_AddItem.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.panel2.Controls.Add(this.Btn_AddItem);
            this.panel2.Controls.Add(this.Btn_ChooseItem);
            this.panel2.Controls.Add(this.Lbl_Item);
            this.panel2.Location = new System.Drawing.Point(44, 492);
            this.panel2.Margin = new System.Windows.Forms.Padding(0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(329, 171);
            this.panel2.TabIndex = 6;
            // 
            // Btn_AddItem
            // 
            this.Btn_AddItem.AutoSize = true;
            this.Btn_AddItem.BackColor = System.Drawing.Color.White;
            this.Btn_AddItem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_AddItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_AddItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(52)))), ((int)(((byte)(22)))));
            this.Btn_AddItem.Location = new System.Drawing.Point(20, 91);
            this.Btn_AddItem.Margin = new System.Windows.Forms.Padding(0);
            this.Btn_AddItem.Name = "Btn_AddItem";
            this.Btn_AddItem.Size = new System.Drawing.Size(289, 40);
            this.Btn_AddItem.TabIndex = 7;
            this.Btn_AddItem.Text = "Adicionar";
            this.Btn_AddItem.UseVisualStyleBackColor = false;
            // 
            // Btn_ChooseItem
            // 
            this.Btn_ChooseItem.AutoSize = true;
            this.Btn_ChooseItem.BackColor = System.Drawing.Color.White;
            this.Btn_ChooseItem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_ChooseItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_ChooseItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(52)))), ((int)(((byte)(22)))));
            this.Btn_ChooseItem.Location = new System.Drawing.Point(72, 37);
            this.Btn_ChooseItem.Margin = new System.Windows.Forms.Padding(0);
            this.Btn_ChooseItem.Name = "Btn_ChooseItem";
            this.Btn_ChooseItem.Size = new System.Drawing.Size(237, 27);
            this.Btn_ChooseItem.TabIndex = 7;
            this.Btn_ChooseItem.Text = "escolher";
            this.Btn_ChooseItem.UseVisualStyleBackColor = false;
            // 
            // Lbl_Item
            // 
            this.Lbl_Item.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Lbl_Item.AutoSize = true;
            this.Lbl_Item.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Item.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(52)))), ((int)(((byte)(22)))));
            this.Lbl_Item.Location = new System.Drawing.Point(20, 40);
            this.Lbl_Item.Margin = new System.Windows.Forms.Padding(0);
            this.Lbl_Item.Name = "Lbl_Item";
            this.Lbl_Item.Size = new System.Drawing.Size(45, 20);
            this.Lbl_Item.TabIndex = 8;
            this.Lbl_Item.Text = "Item:";
            this.Lbl_Item.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel3
            // 
            this.panel3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.panel3.Controls.Add(this.MaskedTxtBox_PaymentValue);
            this.panel3.Controls.Add(this.Lbl_PaymentValue);
            this.panel3.Controls.Add(this.Btn_AddPayment);
            this.panel3.Controls.Add(this.Btn_ChoosePaymentMethod);
            this.panel3.Controls.Add(this.Lbl_PaymentMethod);
            this.panel3.Location = new System.Drawing.Point(44, 747);
            this.panel3.Margin = new System.Windows.Forms.Padding(0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(402, 202);
            this.panel3.TabIndex = 8;
            // 
            // MaskedTxtBox_PaymentValue
            // 
            this.MaskedTxtBox_PaymentValue.BackColor = System.Drawing.Color.White;
            this.MaskedTxtBox_PaymentValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaskedTxtBox_PaymentValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(52)))), ((int)(((byte)(22)))));
            this.MaskedTxtBox_PaymentValue.Location = new System.Drawing.Point(80, 70);
            this.MaskedTxtBox_PaymentValue.Margin = new System.Windows.Forms.Padding(0);
            this.MaskedTxtBox_PaymentValue.Name = "MaskedTxtBox_PaymentValue";
            this.MaskedTxtBox_PaymentValue.Size = new System.Drawing.Size(112, 23);
            this.MaskedTxtBox_PaymentValue.TabIndex = 17;
            // 
            // Lbl_PaymentValue
            // 
            this.Lbl_PaymentValue.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Lbl_PaymentValue.AutoSize = true;
            this.Lbl_PaymentValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_PaymentValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(52)))), ((int)(((byte)(22)))));
            this.Lbl_PaymentValue.Location = new System.Drawing.Point(21, 71);
            this.Lbl_PaymentValue.Margin = new System.Windows.Forms.Padding(0);
            this.Lbl_PaymentValue.Name = "Lbl_PaymentValue";
            this.Lbl_PaymentValue.Size = new System.Drawing.Size(50, 20);
            this.Lbl_PaymentValue.TabIndex = 17;
            this.Lbl_PaymentValue.Text = "Valor:";
            this.Lbl_PaymentValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Btn_AddPayment
            // 
            this.Btn_AddPayment.AutoSize = true;
            this.Btn_AddPayment.BackColor = System.Drawing.Color.White;
            this.Btn_AddPayment.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_AddPayment.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_AddPayment.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(52)))), ((int)(((byte)(22)))));
            this.Btn_AddPayment.Location = new System.Drawing.Point(20, 122);
            this.Btn_AddPayment.Margin = new System.Windows.Forms.Padding(0);
            this.Btn_AddPayment.Name = "Btn_AddPayment";
            this.Btn_AddPayment.Size = new System.Drawing.Size(362, 40);
            this.Btn_AddPayment.TabIndex = 7;
            this.Btn_AddPayment.Text = "Adicionar";
            this.Btn_AddPayment.UseVisualStyleBackColor = false;
            this.Btn_AddPayment.Click += new System.EventHandler(this.Btn_AddPayment_Click);
            // 
            // Btn_ChoosePaymentMethod
            // 
            this.Btn_ChoosePaymentMethod.AutoSize = true;
            this.Btn_ChoosePaymentMethod.BackColor = System.Drawing.Color.White;
            this.Btn_ChoosePaymentMethod.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_ChoosePaymentMethod.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_ChoosePaymentMethod.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(52)))), ((int)(((byte)(22)))));
            this.Btn_ChoosePaymentMethod.Location = new System.Drawing.Point(213, 37);
            this.Btn_ChoosePaymentMethod.Margin = new System.Windows.Forms.Padding(0);
            this.Btn_ChoosePaymentMethod.Name = "Btn_ChoosePaymentMethod";
            this.Btn_ChoosePaymentMethod.Size = new System.Drawing.Size(169, 27);
            this.Btn_ChoosePaymentMethod.TabIndex = 7;
            this.Btn_ChoosePaymentMethod.Text = "escolher";
            this.Btn_ChoosePaymentMethod.UseVisualStyleBackColor = false;
            this.Btn_ChoosePaymentMethod.Click += new System.EventHandler(this.Btn_ChoosePaymentMethod_Click);
            // 
            // Lbl_PaymentMethod
            // 
            this.Lbl_PaymentMethod.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Lbl_PaymentMethod.AutoSize = true;
            this.Lbl_PaymentMethod.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_PaymentMethod.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(52)))), ((int)(((byte)(22)))));
            this.Lbl_PaymentMethod.Location = new System.Drawing.Point(20, 40);
            this.Lbl_PaymentMethod.Margin = new System.Windows.Forms.Padding(0);
            this.Lbl_PaymentMethod.Name = "Lbl_PaymentMethod";
            this.Lbl_PaymentMethod.Size = new System.Drawing.Size(175, 20);
            this.Lbl_PaymentMethod.TabIndex = 8;
            this.Lbl_PaymentMethod.Text = "Método de Pagamento:";
            this.Lbl_PaymentMethod.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Lbl_AddPayment
            // 
            this.Lbl_AddPayment.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Lbl_AddPayment.AutoSize = true;
            this.Lbl_AddPayment.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_AddPayment.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(52)))), ((int)(((byte)(22)))));
            this.Lbl_AddPayment.Location = new System.Drawing.Point(64, 728);
            this.Lbl_AddPayment.Margin = new System.Windows.Forms.Padding(0);
            this.Lbl_AddPayment.Name = "Lbl_AddPayment";
            this.Lbl_AddPayment.Size = new System.Drawing.Size(243, 29);
            this.Lbl_AddPayment.TabIndex = 7;
            this.Lbl_AddPayment.Text = "Adicionar Pagamento";
            this.Lbl_AddPayment.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Panel_PaddingBottom
            // 
            this.Panel_PaddingBottom.Location = new System.Drawing.Point(128, 949);
            this.Panel_PaddingBottom.Margin = new System.Windows.Forms.Padding(0);
            this.Panel_PaddingBottom.Name = "Panel_PaddingBottom";
            this.Panel_PaddingBottom.Size = new System.Drawing.Size(1, 75);
            this.Panel_PaddingBottom.TabIndex = 9;
            // 
            // DataGridView_Orders
            // 
            this.DataGridView_Orders.AllowUserToAddRows = false;
            this.DataGridView_Orders.AllowUserToDeleteRows = false;
            this.DataGridView_Orders.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.DataGridView_Orders.AutoGenerateColumns = false;
            this.DataGridView_Orders.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.DataGridView_Orders.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(52)))), ((int)(((byte)(22)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridView_Orders.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.DataGridView_Orders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridView_Orders.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column5,
            this.Column1,
            this.Column2,
            this.Column6,
            this.Column3,
            this.Column4});
            this.DataGridView_Orders.DataSource = this.BindingSource_AllOrders;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(52)))), ((int)(((byte)(22)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DataGridView_Orders.DefaultCellStyle = dataGridViewCellStyle4;
            this.DataGridView_Orders.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.DataGridView_Orders.Location = new System.Drawing.Point(617, 217);
            this.DataGridView_Orders.Margin = new System.Windows.Forms.Padding(0);
            this.DataGridView_Orders.MultiSelect = false;
            this.DataGridView_Orders.Name = "DataGridView_Orders";
            this.DataGridView_Orders.ReadOnly = true;
            this.DataGridView_Orders.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGridView_Orders.Size = new System.Drawing.Size(622, 601);
            this.DataGridView_Orders.TabIndex = 11;
            this.DataGridView_Orders.SelectionChanged += new System.EventHandler(this.DataGridView_Orders_SelectionChanged);
            // 
            // Btn_ChangeRestaurant
            // 
            this.Btn_ChangeRestaurant.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Btn_ChangeRestaurant.AutoSize = true;
            this.Btn_ChangeRestaurant.BackColor = System.Drawing.Color.White;
            this.Btn_ChangeRestaurant.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_ChangeRestaurant.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_ChangeRestaurant.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(52)))), ((int)(((byte)(22)))));
            this.Btn_ChangeRestaurant.Location = new System.Drawing.Point(1016, 108);
            this.Btn_ChangeRestaurant.Margin = new System.Windows.Forms.Padding(0);
            this.Btn_ChangeRestaurant.Name = "Btn_ChangeRestaurant";
            this.Btn_ChangeRestaurant.Size = new System.Drawing.Size(223, 51);
            this.Btn_ChangeRestaurant.TabIndex = 12;
            this.Btn_ChangeRestaurant.Text = "Mudar de Restaurante";
            this.Btn_ChangeRestaurant.UseVisualStyleBackColor = false;
            this.Btn_ChangeRestaurant.Click += new System.EventHandler(this.Btn_ChangeRestaurant_Click);
            // 
            // Btn_ProgressOrder
            // 
            this.Btn_ProgressOrder.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Btn_ProgressOrder.AutoSize = true;
            this.Btn_ProgressOrder.BackColor = System.Drawing.Color.White;
            this.Btn_ProgressOrder.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_ProgressOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_ProgressOrder.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(52)))), ((int)(((byte)(22)))));
            this.Btn_ProgressOrder.Location = new System.Drawing.Point(617, 839);
            this.Btn_ProgressOrder.Margin = new System.Windows.Forms.Padding(0);
            this.Btn_ProgressOrder.Name = "Btn_ProgressOrder";
            this.Btn_ProgressOrder.Size = new System.Drawing.Size(179, 51);
            this.Btn_ProgressOrder.TabIndex = 13;
            this.Btn_ProgressOrder.Text = "Progredir Pedido";
            this.Btn_ProgressOrder.UseVisualStyleBackColor = false;
            this.Btn_ProgressOrder.Click += new System.EventHandler(this.Btn_ProgressOrder_Click);
            // 
            // Btn_ExportOrder
            // 
            this.Btn_ExportOrder.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Btn_ExportOrder.AutoSize = true;
            this.Btn_ExportOrder.BackColor = System.Drawing.Color.White;
            this.Btn_ExportOrder.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_ExportOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_ExportOrder.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(52)))), ((int)(((byte)(22)))));
            this.Btn_ExportOrder.Location = new System.Drawing.Point(1066, 898);
            this.Btn_ExportOrder.Margin = new System.Windows.Forms.Padding(0);
            this.Btn_ExportOrder.Name = "Btn_ExportOrder";
            this.Btn_ExportOrder.Size = new System.Drawing.Size(173, 51);
            this.Btn_ExportOrder.TabIndex = 14;
            this.Btn_ExportOrder.Text = "Exportar Pedido";
            this.Btn_ExportOrder.UseVisualStyleBackColor = false;
            this.Btn_ExportOrder.Click += new System.EventHandler(this.Btn_ExportOrder_Click);
            // 
            // Btn_ConcludeOrder
            // 
            this.Btn_ConcludeOrder.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Btn_ConcludeOrder.AutoSize = true;
            this.Btn_ConcludeOrder.BackColor = System.Drawing.Color.White;
            this.Btn_ConcludeOrder.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_ConcludeOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_ConcludeOrder.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(52)))), ((int)(((byte)(22)))));
            this.Btn_ConcludeOrder.Location = new System.Drawing.Point(617, 898);
            this.Btn_ConcludeOrder.Margin = new System.Windows.Forms.Padding(0);
            this.Btn_ConcludeOrder.Name = "Btn_ConcludeOrder";
            this.Btn_ConcludeOrder.Size = new System.Drawing.Size(179, 51);
            this.Btn_ConcludeOrder.TabIndex = 15;
            this.Btn_ConcludeOrder.Text = "Concluir Pedido";
            this.Btn_ConcludeOrder.UseVisualStyleBackColor = false;
            this.Btn_ConcludeOrder.Click += new System.EventHandler(this.Btn_ConcludeOrder_Click);
            // 
            // Btn_CancelOrder
            // 
            this.Btn_CancelOrder.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Btn_CancelOrder.AutoSize = true;
            this.Btn_CancelOrder.BackColor = System.Drawing.Color.White;
            this.Btn_CancelOrder.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_CancelOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_CancelOrder.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(52)))), ((int)(((byte)(22)))));
            this.Btn_CancelOrder.Location = new System.Drawing.Point(822, 898);
            this.Btn_CancelOrder.Margin = new System.Windows.Forms.Padding(0);
            this.Btn_CancelOrder.Name = "Btn_CancelOrder";
            this.Btn_CancelOrder.Size = new System.Drawing.Size(174, 51);
            this.Btn_CancelOrder.TabIndex = 16;
            this.Btn_CancelOrder.Text = "Cancelar Pedido";
            this.Btn_CancelOrder.UseVisualStyleBackColor = false;
            this.Btn_CancelOrder.Click += new System.EventHandler(this.Btn_CancelOrder_Click);
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "Id";
            this.Column5.FillWeight = 49.56971F;
            this.Column5.HeaderText = "Id";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 48;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "ClienteFormated";
            this.Column1.FillWeight = 90.0349F;
            this.Column1.HeaderText = "Cliente";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 87;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "ValorTotalFormated";
            this.Column2.FillWeight = 117.3882F;
            this.Column2.HeaderText = "Valor Total";
            this.Column2.MinimumWidth = 140;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 140;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "ValorPorPagarFormated";
            this.Column6.FillWeight = 170.424F;
            this.Column6.HeaderText = "Valor Por Pagar";
            this.Column6.MinimumWidth = 165;
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Width = 165;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "EstadoFormated";
            this.Column3.FillWeight = 71.9558F;
            this.Column3.HeaderText = "Estado";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 70;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "TrabalhadorFormated";
            this.Column4.FillWeight = 100.6275F;
            this.Column4.HeaderText = "Funcionário";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 97;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "Id";
            this.Column5.HeaderText = "Id";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "ClienteFormated";
            this.Column1.HeaderText = "Cliente";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "ValorTotalFormated";
            this.Column2.HeaderText = "ValorTotal";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "EstadoFormated";
            this.Column3.HeaderText = "Estado";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "TrabalhadorFormated";
            this.Column4.HeaderText = "Funcionário";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Orders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.ClientSize = new System.Drawing.Size(1424, 881);
            this.Controls.Add(this.Btn_CancelOrder);
            this.Controls.Add(this.Btn_ConcludeOrder);
            this.Controls.Add(this.Btn_ExportOrder);
            this.Controls.Add(this.Btn_ProgressOrder);
            this.Controls.Add(this.Btn_ChangeRestaurant);
            this.Controls.Add(this.DataGridView_Orders);
            this.Controls.Add(this.Panel_PaddingBottom);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.Lbl_AddPayment);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.Lbl_AddItem);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Lbl_AddOrder);
            this.Controls.Add(this.Lbl_RestaurantName);
            this.Controls.Add(this.Lbl_Restaurant);
            this.Controls.Add(this.Lbl_Orders);
            this.Name = "Orders";
            this.Padding = new System.Windows.Forms.Padding(0, 0, 0, 20);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pedidos";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Orders_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView_Orders)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BindingSource_AllOrders)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Lbl_Orders;
        private System.Windows.Forms.Label Lbl_Restaurant;
        private System.Windows.Forms.Label Lbl_RestaurantName;
        private System.Windows.Forms.Label Lbl_AddOrder;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Btn_AddNewOrder;
        private System.Windows.Forms.Button Btn_ChooseClient;
        private System.Windows.Forms.Label Lbl_Client;
        private System.Windows.Forms.Button Btn_ChooseWorker;
        private System.Windows.Forms.Label Lbl_Worker;
        private System.Windows.Forms.Label Lbl_AddItem;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button Btn_AddItem;
        private System.Windows.Forms.Button Btn_ChooseItem;
        private System.Windows.Forms.Label Lbl_Item;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button Btn_AddPayment;
        private System.Windows.Forms.Button Btn_ChoosePaymentMethod;
        private System.Windows.Forms.Label Lbl_PaymentMethod;
        private System.Windows.Forms.Label Lbl_AddPayment;
        private System.Windows.Forms.Panel Panel_PaddingBottom;
        private System.Windows.Forms.DataGridView DataGridView_Orders;
        private System.Windows.Forms.Button Btn_ChangeRestaurant;
        private System.Windows.Forms.Button Btn_ProgressOrder;
        private System.Windows.Forms.Button Btn_ExportOrder;
        private System.Windows.Forms.Button Btn_ConcludeOrder;
        private System.Windows.Forms.Button Btn_CancelOrder;
        private System.Windows.Forms.MaskedTextBox MaskedTxtBox_PaymentValue;
        private System.Windows.Forms.Label Lbl_PaymentValue;
        private System.Windows.Forms.BindingSource BindingSource_AllOrders;
        private System.Windows.Forms.Label Lbl_OrderPrice;
        private System.Windows.Forms.MaskedTextBox MaskedTxtBox_OrderPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
    }
}