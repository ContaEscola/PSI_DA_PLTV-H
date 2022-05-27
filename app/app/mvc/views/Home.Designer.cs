
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
            this.clienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pedidosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.Lbl_Restaurantes = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.Btn_RestaurantGlobalManagent = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.Btn_ClientsGlobalManagement = new System.Windows.Forms.Button();
            this.Lbl_Clientes = new System.Windows.Forms.Label();
            this.gerirIndividualmenteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gerirIndividualmenteToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.gerirIndividualmenteToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.gerirIndividualmenteToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
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
            this.clienteToolStripMenuItem,
            this.clientesToolStripMenuItem,
            this.menuToolStripMenuItem,
            this.pedidosToolStripMenuItem});
            this.menuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(0);
            this.menuStrip1.Size = new System.Drawing.Size(1424, 45);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // clienteToolStripMenuItem
            // 
            this.clienteToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gerirIndividualmenteToolStripMenuItem});
            this.clienteToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.clienteToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(52)))), ((int)(((byte)(22)))));
            this.clienteToolStripMenuItem.Name = "clienteToolStripMenuItem";
            this.clienteToolStripMenuItem.Padding = new System.Windows.Forms.Padding(10);
            this.clienteToolStripMenuItem.Size = new System.Drawing.Size(124, 45);
            this.clienteToolStripMenuItem.Text = "Restaurantes";
            // 
            // clientesToolStripMenuItem
            // 
            this.clientesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gerirIndividualmenteToolStripMenuItem1});
            this.clientesToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.clientesToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(52)))), ((int)(((byte)(22)))));
            this.clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            this.clientesToolStripMenuItem.Size = new System.Drawing.Size(77, 45);
            this.clientesToolStripMenuItem.Text = "Clientes";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gerirIndividualmenteToolStripMenuItem2});
            this.menuToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.menuToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(52)))), ((int)(((byte)(22)))));
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(62, 45);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // pedidosToolStripMenuItem
            // 
            this.pedidosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gerirIndividualmenteToolStripMenuItem3});
            this.pedidosToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.pedidosToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(52)))), ((int)(((byte)(22)))));
            this.pedidosToolStripMenuItem.Name = "pedidosToolStripMenuItem";
            this.pedidosToolStripMenuItem.Size = new System.Drawing.Size(76, 45);
            this.pedidosToolStripMenuItem.Text = "Pedidos";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 32F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(52)))), ((int)(((byte)(22)))));
            this.label1.Location = new System.Drawing.Point(128, 108);
            this.label1.Margin = new System.Windows.Forms.Padding(0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(496, 37);
            this.label1.TabIndex = 1;
            this.label1.Text = "Escolha uma das funcionalidades";
            // 
            // Lbl_Restaurantes
            // 
            this.Lbl_Restaurantes.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Lbl_Restaurantes.AutoSize = true;
            this.Lbl_Restaurantes.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
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
            this.tableLayoutPanel1.Controls.Add(this.Btn_RestaurantGlobalManagent, 0, 1);
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
            // Btn_RestaurantGlobalManagent
            // 
            this.Btn_RestaurantGlobalManagent.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.Btn_RestaurantGlobalManagent.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.Btn_RestaurantGlobalManagent.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(52)))), ((int)(((byte)(22)))));
            this.Btn_RestaurantGlobalManagent.Location = new System.Drawing.Point(50, 50);
            this.Btn_RestaurantGlobalManagent.Margin = new System.Windows.Forms.Padding(0);
            this.Btn_RestaurantGlobalManagent.Name = "Btn_RestaurantGlobalManagent";
            this.Btn_RestaurantGlobalManagent.Padding = new System.Windows.Forms.Padding(20, 15, 20, 15);
            this.Btn_RestaurantGlobalManagent.Size = new System.Drawing.Size(152, 51);
            this.Btn_RestaurantGlobalManagent.TabIndex = 4;
            this.Btn_RestaurantGlobalManagent.Text = "Gestão Global";
            this.Btn_RestaurantGlobalManagent.UseVisualStyleBackColor = true;
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
            this.Btn_ClientsGlobalManagement.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.Btn_ClientsGlobalManagement.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.Btn_ClientsGlobalManagement.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(52)))), ((int)(((byte)(22)))));
            this.Btn_ClientsGlobalManagement.Location = new System.Drawing.Point(50, 50);
            this.Btn_ClientsGlobalManagement.Margin = new System.Windows.Forms.Padding(0);
            this.Btn_ClientsGlobalManagement.Name = "Btn_ClientsGlobalManagement";
            this.Btn_ClientsGlobalManagement.Padding = new System.Windows.Forms.Padding(20, 15, 20, 15);
            this.Btn_ClientsGlobalManagement.Size = new System.Drawing.Size(152, 51);
            this.Btn_ClientsGlobalManagement.TabIndex = 4;
            this.Btn_ClientsGlobalManagement.Text = "Gestão Global";
            this.Btn_ClientsGlobalManagement.UseVisualStyleBackColor = true;
            // 
            // Lbl_Clientes
            // 
            this.Lbl_Clientes.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Lbl_Clientes.AutoSize = true;
            this.Lbl_Clientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.Lbl_Clientes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(52)))), ((int)(((byte)(22)))));
            this.Lbl_Clientes.Location = new System.Drawing.Point(563, 217);
            this.Lbl_Clientes.Name = "Lbl_Clientes";
            this.Lbl_Clientes.Size = new System.Drawing.Size(101, 29);
            this.Lbl_Clientes.TabIndex = 4;
            this.Lbl_Clientes.Text = "Clientes";
            // 
            // gerirIndividualmenteToolStripMenuItem
            // 
            this.gerirIndividualmenteToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.gerirIndividualmenteToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(52)))), ((int)(((byte)(22)))));
            this.gerirIndividualmenteToolStripMenuItem.Name = "gerirIndividualmenteToolStripMenuItem";
            this.gerirIndividualmenteToolStripMenuItem.Size = new System.Drawing.Size(231, 26);
            this.gerirIndividualmenteToolStripMenuItem.Text = "Gerir individualmente";
            // 
            // gerirIndividualmenteToolStripMenuItem1
            // 
            this.gerirIndividualmenteToolStripMenuItem1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.gerirIndividualmenteToolStripMenuItem1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(52)))), ((int)(((byte)(22)))));
            this.gerirIndividualmenteToolStripMenuItem1.Name = "gerirIndividualmenteToolStripMenuItem1";
            this.gerirIndividualmenteToolStripMenuItem1.Size = new System.Drawing.Size(231, 26);
            this.gerirIndividualmenteToolStripMenuItem1.Text = "Gerir individualmente";
            // 
            // gerirIndividualmenteToolStripMenuItem2
            // 
            this.gerirIndividualmenteToolStripMenuItem2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.gerirIndividualmenteToolStripMenuItem2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(52)))), ((int)(((byte)(22)))));
            this.gerirIndividualmenteToolStripMenuItem2.Name = "gerirIndividualmenteToolStripMenuItem2";
            this.gerirIndividualmenteToolStripMenuItem2.Size = new System.Drawing.Size(231, 26);
            this.gerirIndividualmenteToolStripMenuItem2.Text = "Gerir individualmente";
            // 
            // gerirIndividualmenteToolStripMenuItem3
            // 
            this.gerirIndividualmenteToolStripMenuItem3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.gerirIndividualmenteToolStripMenuItem3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(52)))), ((int)(((byte)(22)))));
            this.gerirIndividualmenteToolStripMenuItem3.Name = "gerirIndividualmenteToolStripMenuItem3";
            this.gerirIndividualmenteToolStripMenuItem3.Size = new System.Drawing.Size(231, 26);
            this.gerirIndividualmenteToolStripMenuItem3.Text = "Gerir individualmente";
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.ClientSize = new System.Drawing.Size(1424, 881);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.Lbl_Clientes);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.Lbl_Restaurantes);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem clienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pedidosToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Lbl_Restaurantes;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button Btn_RestaurantGlobalManagent;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button Btn_ClientsGlobalManagement;
        private System.Windows.Forms.Label Lbl_Clientes;
        private System.Windows.Forms.ToolStripMenuItem gerirIndividualmenteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gerirIndividualmenteToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem gerirIndividualmenteToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem gerirIndividualmenteToolStripMenuItem3;
    }
}

