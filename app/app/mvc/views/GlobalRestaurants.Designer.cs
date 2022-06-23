
namespace app
{
    partial class GlobalRestaurants
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
            this.Lbl_Restaurantes = new System.Windows.Forms.Label();
            this.DataGridView_Restaurants = new System.Windows.Forms.DataGridView();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Morada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BindingSource_AllRestaurants = new System.Windows.Forms.BindingSource(this.components);
            this.Btn_RegisterNewRestaurant = new System.Windows.Forms.Button();
            this.Btn_ManageRestaurant = new System.Windows.Forms.Button();
            this.Btn_EditRestaurant = new System.Windows.Forms.Button();
            this.Btn_ManageCategories = new System.Windows.Forms.Button();
            this.Btn_ManagePaymentMethods = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView_Restaurants)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BindingSource_AllRestaurants)).BeginInit();
            this.SuspendLayout();
            // 
            // Lbl_Restaurantes
            // 
            this.Lbl_Restaurantes.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Lbl_Restaurantes.AutoSize = true;
            this.Lbl_Restaurantes.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Restaurantes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(52)))), ((int)(((byte)(22)))));
            this.Lbl_Restaurantes.Location = new System.Drawing.Point(121, 108);
            this.Lbl_Restaurantes.Margin = new System.Windows.Forms.Padding(0);
            this.Lbl_Restaurantes.Name = "Lbl_Restaurantes";
            this.Lbl_Restaurantes.Size = new System.Drawing.Size(206, 37);
            this.Lbl_Restaurantes.TabIndex = 0;
            this.Lbl_Restaurantes.Text = "Restaurantes";
            this.Lbl_Restaurantes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // DataGridView_Restaurants
            // 
            this.DataGridView_Restaurants.AllowUserToAddRows = false;
            this.DataGridView_Restaurants.AllowUserToDeleteRows = false;
            this.DataGridView_Restaurants.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.DataGridView_Restaurants.AutoGenerateColumns = false;
            this.DataGridView_Restaurants.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.DataGridView_Restaurants.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DataGridView_Restaurants.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridView_Restaurants.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nome,
            this.Morada});
            this.DataGridView_Restaurants.DataSource = this.BindingSource_AllRestaurants;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(52)))), ((int)(((byte)(22)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DataGridView_Restaurants.DefaultCellStyle = dataGridViewCellStyle3;
            this.DataGridView_Restaurants.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.DataGridView_Restaurants.Location = new System.Drawing.Point(128, 217);
            this.DataGridView_Restaurants.Margin = new System.Windows.Forms.Padding(0);
            this.DataGridView_Restaurants.MultiSelect = false;
            this.DataGridView_Restaurants.Name = "DataGridView_Restaurants";
            this.DataGridView_Restaurants.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(52)))), ((int)(((byte)(22)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridView_Restaurants.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.DataGridView_Restaurants.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGridView_Restaurants.Size = new System.Drawing.Size(1195, 404);
            this.DataGridView_Restaurants.TabIndex = 1;
            this.DataGridView_Restaurants.SelectionChanged += new System.EventHandler(this.DataGridView_Restaurants_SelectionChanged);
            // 
            // Nome
            // 
            this.Nome.DataPropertyName = "Nome";
            this.Nome.HeaderText = "Nome";
            this.Nome.Name = "Nome";
            this.Nome.ReadOnly = true;
            // 
            // Morada
            // 
            this.Morada.DataPropertyName = "Morada";
            this.Morada.HeaderText = "Morada";
            this.Morada.Name = "Morada";
            this.Morada.ReadOnly = true;
            // 
            // BindingSource_AllRestaurants
            // 
            this.BindingSource_AllRestaurants.CurrentChanged += new System.EventHandler(this.BindingSource_AllRestaurants_CurrentChanged);
            // 
            // Btn_RegisterNewRestaurant
            // 
            this.Btn_RegisterNewRestaurant.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Btn_RegisterNewRestaurant.AutoSize = true;
            this.Btn_RegisterNewRestaurant.BackColor = System.Drawing.Color.White;
            this.Btn_RegisterNewRestaurant.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_RegisterNewRestaurant.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_RegisterNewRestaurant.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(52)))), ((int)(((byte)(22)))));
            this.Btn_RegisterNewRestaurant.Location = new System.Drawing.Point(128, 688);
            this.Btn_RegisterNewRestaurant.Margin = new System.Windows.Forms.Padding(0);
            this.Btn_RegisterNewRestaurant.Name = "Btn_RegisterNewRestaurant";
            this.Btn_RegisterNewRestaurant.Size = new System.Drawing.Size(260, 51);
            this.Btn_RegisterNewRestaurant.TabIndex = 2;
            this.Btn_RegisterNewRestaurant.Text = "Registar Novo Restaurante";
            this.Btn_RegisterNewRestaurant.UseVisualStyleBackColor = false;
            this.Btn_RegisterNewRestaurant.Click += new System.EventHandler(this.Btn_RegisterNewRestaurant_Click);
            // 
            // Btn_ManageRestaurant
            // 
            this.Btn_ManageRestaurant.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Btn_ManageRestaurant.AutoSize = true;
            this.Btn_ManageRestaurant.BackColor = System.Drawing.Color.White;
            this.Btn_ManageRestaurant.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_ManageRestaurant.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_ManageRestaurant.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(52)))), ((int)(((byte)(22)))));
            this.Btn_ManageRestaurant.Location = new System.Drawing.Point(128, 806);
            this.Btn_ManageRestaurant.Margin = new System.Windows.Forms.Padding(0);
            this.Btn_ManageRestaurant.Name = "Btn_ManageRestaurant";
            this.Btn_ManageRestaurant.Size = new System.Drawing.Size(186, 51);
            this.Btn_ManageRestaurant.TabIndex = 3;
            this.Btn_ManageRestaurant.Text = "Gerir Restaurante";
            this.Btn_ManageRestaurant.UseVisualStyleBackColor = false;
            this.Btn_ManageRestaurant.Click += new System.EventHandler(this.Btn_ManageRestaurant_Click);
            // 
            // Btn_EditRestaurant
            // 
            this.Btn_EditRestaurant.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Btn_EditRestaurant.AutoSize = true;
            this.Btn_EditRestaurant.BackColor = System.Drawing.Color.White;
            this.Btn_EditRestaurant.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_EditRestaurant.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_EditRestaurant.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(52)))), ((int)(((byte)(22)))));
            this.Btn_EditRestaurant.Location = new System.Drawing.Point(388, 806);
            this.Btn_EditRestaurant.Margin = new System.Windows.Forms.Padding(0);
            this.Btn_EditRestaurant.Name = "Btn_EditRestaurant";
            this.Btn_EditRestaurant.Size = new System.Drawing.Size(203, 51);
            this.Btn_EditRestaurant.TabIndex = 4;
            this.Btn_EditRestaurant.Text = "Alterar Restaurante";
            this.Btn_EditRestaurant.UseVisualStyleBackColor = false;
            this.Btn_EditRestaurant.Click += new System.EventHandler(this.Btn_EditRestaurant_Click);
            // 
            // Btn_ManageCategories
            // 
            this.Btn_ManageCategories.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Btn_ManageCategories.AutoSize = true;
            this.Btn_ManageCategories.BackColor = System.Drawing.Color.White;
            this.Btn_ManageCategories.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_ManageCategories.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_ManageCategories.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(52)))), ((int)(((byte)(22)))));
            this.Btn_ManageCategories.Location = new System.Drawing.Point(1150, 688);
            this.Btn_ManageCategories.Margin = new System.Windows.Forms.Padding(0);
            this.Btn_ManageCategories.Name = "Btn_ManageCategories";
            this.Btn_ManageCategories.Size = new System.Drawing.Size(173, 51);
            this.Btn_ManageCategories.TabIndex = 5;
            this.Btn_ManageCategories.Text = "Gerir Categorias";
            this.Btn_ManageCategories.UseVisualStyleBackColor = false;
            this.Btn_ManageCategories.Click += new System.EventHandler(this.Btn_ManageCategories_Click);
            // 
            // Btn_ManagePaymentMethods
            // 
            this.Btn_ManagePaymentMethods.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Btn_ManagePaymentMethods.AutoSize = true;
            this.Btn_ManagePaymentMethods.BackColor = System.Drawing.Color.White;
            this.Btn_ManagePaymentMethods.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_ManagePaymentMethods.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_ManagePaymentMethods.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(52)))), ((int)(((byte)(22)))));
            this.Btn_ManagePaymentMethods.Location = new System.Drawing.Point(1037, 806);
            this.Btn_ManagePaymentMethods.Margin = new System.Windows.Forms.Padding(0);
            this.Btn_ManagePaymentMethods.Name = "Btn_ManagePaymentMethods";
            this.Btn_ManagePaymentMethods.Size = new System.Drawing.Size(286, 51);
            this.Btn_ManagePaymentMethods.TabIndex = 6;
            this.Btn_ManagePaymentMethods.Text = "Gerir Métodos de Pagamento";
            this.Btn_ManagePaymentMethods.UseVisualStyleBackColor = false;
            this.Btn_ManagePaymentMethods.Click += new System.EventHandler(this.Btn_ManagePaymentMethods_Click);
            // 
            // GlobalRestaurants
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.ClientSize = new System.Drawing.Size(1424, 881);
            this.Controls.Add(this.Btn_ManagePaymentMethods);
            this.Controls.Add(this.Btn_ManageCategories);
            this.Controls.Add(this.Btn_EditRestaurant);
            this.Controls.Add(this.Btn_ManageRestaurant);
            this.Controls.Add(this.Btn_RegisterNewRestaurant);
            this.Controls.Add(this.DataGridView_Restaurants);
            this.Controls.Add(this.Lbl_Restaurantes);
            this.Name = "GlobalRestaurants";
            this.Text = "Gestão Global de Restaurantes";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.GlobalRestaurants_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView_Restaurants)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BindingSource_AllRestaurants)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Lbl_Restaurantes;
        private System.Windows.Forms.DataGridView DataGridView_Restaurants;
        private System.Windows.Forms.Button Btn_RegisterNewRestaurant;
        private System.Windows.Forms.Button Btn_ManageRestaurant;
        private System.Windows.Forms.Button Btn_EditRestaurant;
        private System.Windows.Forms.Button Btn_ManageCategories;
        private System.Windows.Forms.Button Btn_ManagePaymentMethods;
        private System.Windows.Forms.BindingSource BindingSource_AllRestaurants;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn Morada;
    }
}