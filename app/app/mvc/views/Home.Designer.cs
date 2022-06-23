
namespace app
{
    partial class Home
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ToolStripMenuItem_Restaurants = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_ManageSingleRestaurant = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_Clients = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_ManageSingleClient = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_Menu = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_ManageSingleMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_Orders = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_ManageSingleOrder = new System.Windows.Forms.ToolStripMenuItem();
            this.Lbl_ChooseFunctionalities = new System.Windows.Forms.Label();
            this.Lbl_Restaurantes = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.Btn_RestaurantGlobalManagement = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.Btn_ClientsGlobalManagement = new System.Windows.Forms.Button();
            this.Lbl_Clientes = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(0);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItem_Restaurants,
            this.ToolStripMenuItem_Clients,
            this.ToolStripMenuItem_Menu,
            this.ToolStripMenuItem_Orders});
            this.menuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(0);
            this.menuStrip1.Size = new System.Drawing.Size(1424, 45);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ToolStripMenuItem_Restaurants
            // 
            this.ToolStripMenuItem_Restaurants.BackColor = System.Drawing.Color.White;
            this.ToolStripMenuItem_Restaurants.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItem_ManageSingleRestaurant});
            this.ToolStripMenuItem_Restaurants.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.ToolStripMenuItem_Restaurants.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(52)))), ((int)(((byte)(22)))));
            this.ToolStripMenuItem_Restaurants.Name = "ToolStripMenuItem_Restaurants";
            this.ToolStripMenuItem_Restaurants.Padding = new System.Windows.Forms.Padding(10);
            this.ToolStripMenuItem_Restaurants.Size = new System.Drawing.Size(124, 45);
            this.ToolStripMenuItem_Restaurants.Text = "Restaurantes";
            // 
            // ToolStripMenuItem_ManageSingleRestaurant
            // 
            this.ToolStripMenuItem_ManageSingleRestaurant.BackColor = System.Drawing.Color.White;
            this.ToolStripMenuItem_ManageSingleRestaurant.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.ToolStripMenuItem_ManageSingleRestaurant.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(52)))), ((int)(((byte)(22)))));
            this.ToolStripMenuItem_ManageSingleRestaurant.Name = "ToolStripMenuItem_ManageSingleRestaurant";
            this.ToolStripMenuItem_ManageSingleRestaurant.Padding = new System.Windows.Forms.Padding(0, 0, 0, 2);
            this.ToolStripMenuItem_ManageSingleRestaurant.Size = new System.Drawing.Size(210, 24);
            this.ToolStripMenuItem_ManageSingleRestaurant.Text = "Gerir individualmente";
            this.ToolStripMenuItem_ManageSingleRestaurant.Click += new System.EventHandler(this.ToolStripMenuItem_ManageSingleRestaurant_Click);
            // 
            // ToolStripMenuItem_Clients
            // 
            this.ToolStripMenuItem_Clients.BackColor = System.Drawing.Color.White;
            this.ToolStripMenuItem_Clients.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItem_ManageSingleClient});
            this.ToolStripMenuItem_Clients.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.ToolStripMenuItem_Clients.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(52)))), ((int)(((byte)(22)))));
            this.ToolStripMenuItem_Clients.Name = "ToolStripMenuItem_Clients";
            this.ToolStripMenuItem_Clients.Padding = new System.Windows.Forms.Padding(10);
            this.ToolStripMenuItem_Clients.Size = new System.Drawing.Size(89, 45);
            this.ToolStripMenuItem_Clients.Text = "Clientes";
            // 
            // ToolStripMenuItem_ManageSingleClient
            // 
            this.ToolStripMenuItem_ManageSingleClient.BackColor = System.Drawing.Color.White;
            this.ToolStripMenuItem_ManageSingleClient.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.ToolStripMenuItem_ManageSingleClient.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(52)))), ((int)(((byte)(22)))));
            this.ToolStripMenuItem_ManageSingleClient.Name = "ToolStripMenuItem_ManageSingleClient";
            this.ToolStripMenuItem_ManageSingleClient.Padding = new System.Windows.Forms.Padding(0, 0, 0, 2);
            this.ToolStripMenuItem_ManageSingleClient.Size = new System.Drawing.Size(210, 24);
            this.ToolStripMenuItem_ManageSingleClient.Text = "Gerir individualmente";
            this.ToolStripMenuItem_ManageSingleClient.Click += new System.EventHandler(this.ToolStripMenuItem_ManageSingleClient_Click);
            // 
            // ToolStripMenuItem_Menu
            // 
            this.ToolStripMenuItem_Menu.BackColor = System.Drawing.Color.White;
            this.ToolStripMenuItem_Menu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItem_ManageSingleMenu});
            this.ToolStripMenuItem_Menu.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.ToolStripMenuItem_Menu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(52)))), ((int)(((byte)(22)))));
            this.ToolStripMenuItem_Menu.Name = "ToolStripMenuItem_Menu";
            this.ToolStripMenuItem_Menu.Padding = new System.Windows.Forms.Padding(10);
            this.ToolStripMenuItem_Menu.Size = new System.Drawing.Size(74, 45);
            this.ToolStripMenuItem_Menu.Text = "Menu";
            // 
            // ToolStripMenuItem_ManageSingleMenu
            // 
            this.ToolStripMenuItem_ManageSingleMenu.BackColor = System.Drawing.Color.White;
            this.ToolStripMenuItem_ManageSingleMenu.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.ToolStripMenuItem_ManageSingleMenu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(52)))), ((int)(((byte)(22)))));
            this.ToolStripMenuItem_ManageSingleMenu.Name = "ToolStripMenuItem_ManageSingleMenu";
            this.ToolStripMenuItem_ManageSingleMenu.Padding = new System.Windows.Forms.Padding(0, 0, 0, 2);
            this.ToolStripMenuItem_ManageSingleMenu.Size = new System.Drawing.Size(210, 24);
            this.ToolStripMenuItem_ManageSingleMenu.Text = "Gerir individualmente";
            // 
            // ToolStripMenuItem_Orders
            // 
            this.ToolStripMenuItem_Orders.BackColor = System.Drawing.Color.White;
            this.ToolStripMenuItem_Orders.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItem_ManageSingleOrder});
            this.ToolStripMenuItem_Orders.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.ToolStripMenuItem_Orders.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(52)))), ((int)(((byte)(22)))));
            this.ToolStripMenuItem_Orders.Name = "ToolStripMenuItem_Orders";
            this.ToolStripMenuItem_Orders.Padding = new System.Windows.Forms.Padding(10);
            this.ToolStripMenuItem_Orders.Size = new System.Drawing.Size(88, 45);
            this.ToolStripMenuItem_Orders.Text = "Pedidos";
            // 
            // ToolStripMenuItem_ManageSingleOrder
            // 
            this.ToolStripMenuItem_ManageSingleOrder.BackColor = System.Drawing.Color.White;
            this.ToolStripMenuItem_ManageSingleOrder.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.ToolStripMenuItem_ManageSingleOrder.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(52)))), ((int)(((byte)(22)))));
            this.ToolStripMenuItem_ManageSingleOrder.Name = "ToolStripMenuItem_ManageSingleOrder";
            this.ToolStripMenuItem_ManageSingleOrder.Padding = new System.Windows.Forms.Padding(0, 0, 0, 2);
            this.ToolStripMenuItem_ManageSingleOrder.Size = new System.Drawing.Size(210, 24);
            this.ToolStripMenuItem_ManageSingleOrder.Text = "Gerir individualmente";
            // 
            // Lbl_ChooseFunctionalities
            // 
            this.Lbl_ChooseFunctionalities.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Lbl_ChooseFunctionalities.AutoSize = true;
            this.Lbl_ChooseFunctionalities.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_ChooseFunctionalities.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(52)))), ((int)(((byte)(22)))));
            this.Lbl_ChooseFunctionalities.Location = new System.Drawing.Point(128, 108);
            this.Lbl_ChooseFunctionalities.Margin = new System.Windows.Forms.Padding(0);
            this.Lbl_ChooseFunctionalities.Name = "Lbl_ChooseFunctionalities";
            this.Lbl_ChooseFunctionalities.Size = new System.Drawing.Size(496, 37);
            this.Lbl_ChooseFunctionalities.TabIndex = 1;
            this.Lbl_ChooseFunctionalities.Text = "Escolha uma das funcionalidades";
            // 
            // Lbl_Restaurantes
            // 
            this.Lbl_Restaurantes.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Lbl_Restaurantes.AutoSize = true;
            this.Lbl_Restaurantes.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Restaurantes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(52)))), ((int)(((byte)(22)))));
            this.Lbl_Restaurantes.Location = new System.Drawing.Point(139, 217);
            this.Lbl_Restaurantes.Name = "Lbl_Restaurantes";
            this.Lbl_Restaurantes.Size = new System.Drawing.Size(154, 29);
            this.Lbl_Restaurantes.TabIndex = 2;
            this.Lbl_Restaurantes.Text = "Restaurantes";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.Btn_RestaurantGlobalManagement, 0, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(128, 236);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.Padding = new System.Windows.Forms.Padding(50, 0, 50, 0);
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(252, 151);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // Btn_RestaurantGlobalManagement
            // 
            this.Btn_RestaurantGlobalManagement.BackColor = System.Drawing.Color.White;
            this.Btn_RestaurantGlobalManagement.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_RestaurantGlobalManagement.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.Btn_RestaurantGlobalManagement.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_RestaurantGlobalManagement.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(52)))), ((int)(((byte)(22)))));
            this.Btn_RestaurantGlobalManagement.Location = new System.Drawing.Point(50, 50);
            this.Btn_RestaurantGlobalManagement.Margin = new System.Windows.Forms.Padding(0);
            this.Btn_RestaurantGlobalManagement.Name = "Btn_RestaurantGlobalManagement";
            this.Btn_RestaurantGlobalManagement.Padding = new System.Windows.Forms.Padding(20, 15, 20, 15);
            this.Btn_RestaurantGlobalManagement.Size = new System.Drawing.Size(152, 51);
            this.Btn_RestaurantGlobalManagement.TabIndex = 4;
            this.Btn_RestaurantGlobalManagement.Text = "Gestão Global";
            this.Btn_RestaurantGlobalManagement.UseVisualStyleBackColor = false;
            this.Btn_RestaurantGlobalManagement.Click += new System.EventHandler(this.Btn_RestaurantGlobalManagement_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tableLayoutPanel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.Controls.Add(this.Btn_ClientsGlobalManagement, 0, 1);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(553, 236);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.Padding = new System.Windows.Forms.Padding(50, 0, 50, 0);
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(252, 151);
            this.tableLayoutPanel2.TabIndex = 5;
            // 
            // Btn_ClientsGlobalManagement
            // 
            this.Btn_ClientsGlobalManagement.BackColor = System.Drawing.Color.White;
            this.Btn_ClientsGlobalManagement.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_ClientsGlobalManagement.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.Btn_ClientsGlobalManagement.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_ClientsGlobalManagement.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(52)))), ((int)(((byte)(22)))));
            this.Btn_ClientsGlobalManagement.Location = new System.Drawing.Point(50, 50);
            this.Btn_ClientsGlobalManagement.Margin = new System.Windows.Forms.Padding(0);
            this.Btn_ClientsGlobalManagement.Name = "Btn_ClientsGlobalManagement";
            this.Btn_ClientsGlobalManagement.Padding = new System.Windows.Forms.Padding(20, 15, 20, 15);
            this.Btn_ClientsGlobalManagement.Size = new System.Drawing.Size(152, 51);
            this.Btn_ClientsGlobalManagement.TabIndex = 4;
            this.Btn_ClientsGlobalManagement.Text = "Gestão Global";
            this.Btn_ClientsGlobalManagement.UseVisualStyleBackColor = false;
            this.Btn_ClientsGlobalManagement.Click += new System.EventHandler(this.Btn_ClientsGlobalManagement_Click);
            // 
            // Lbl_Clientes
            // 
            this.Lbl_Clientes.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Lbl_Clientes.AutoSize = true;
            this.Lbl_Clientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Clientes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(52)))), ((int)(((byte)(22)))));
            this.Lbl_Clientes.Location = new System.Drawing.Point(563, 217);
            this.Lbl_Clientes.Name = "Lbl_Clientes";
            this.Lbl_Clientes.Size = new System.Drawing.Size(101, 29);
            this.Lbl_Clientes.TabIndex = 4;
            this.Lbl_Clientes.Text = "Clientes";
            // 
            // Home
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.ClientSize = new System.Drawing.Size(1424, 881);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.Lbl_Clientes);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.Lbl_Restaurantes);
            this.Controls.Add(this.Lbl_ChooseFunctionalities);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Home";
            this.Text = "Home";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Home_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_Restaurants;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_Clients;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_Menu;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_Orders;
        private System.Windows.Forms.Label Lbl_ChooseFunctionalities;
        private System.Windows.Forms.Label Lbl_Restaurantes;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button Btn_RestaurantGlobalManagement;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button Btn_ClientsGlobalManagement;
        private System.Windows.Forms.Label Lbl_Clientes;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_ManageSingleRestaurant;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_ManageSingleClient;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_ManageSingleMenu;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_ManageSingleOrder;
    }
}

