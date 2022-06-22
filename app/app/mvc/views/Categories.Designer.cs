namespace app
{
    partial class Categories
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
            this.Lbl_Categories = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Btn_AddCategorie = new System.Windows.Forms.Button();
            this.ComboBox_NewCategorieState = new System.Windows.Forms.ComboBox();
            this.Lbl_NewCategorieState = new System.Windows.Forms.Label();
            this.TxtBox_NewCategorieName = new System.Windows.Forms.TextBox();
            this.Lbl_NewCategorieName = new System.Windows.Forms.Label();
            this.Lbl_AddCategorie = new System.Windows.Forms.Label();
            this.Lbl_EditCategorie = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Btn_SaveChangesOnCategorie = new System.Windows.Forms.Button();
            this.ComboBox_CategorieState = new System.Windows.Forms.ComboBox();
            this.Lbl_CategorieState = new System.Windows.Forms.Label();
            this.TxtBox_CategorieName = new System.Windows.Forms.TextBox();
            this.Lbl_CategorieName = new System.Windows.Forms.Label();
            this.DataGridView_Categories = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BindingSource_AllCategories = new System.Windows.Forms.BindingSource(this.components);
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView_Categories)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BindingSource_AllCategories)).BeginInit();
            this.SuspendLayout();
            // 
            // Lbl_Categories
            // 
            this.Lbl_Categories.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Lbl_Categories.AutoSize = true;
            this.Lbl_Categories.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Categories.Location = new System.Drawing.Point(121, 108);
            this.Lbl_Categories.Margin = new System.Windows.Forms.Padding(0);
            this.Lbl_Categories.Name = "Lbl_Categories";
            this.Lbl_Categories.Size = new System.Drawing.Size(343, 37);
            this.Lbl_Categories.TabIndex = 0;
            this.Lbl_Categories.Text = "Categorias Disponíveis";
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.panel1.Controls.Add(this.Btn_AddCategorie);
            this.panel1.Controls.Add(this.ComboBox_NewCategorieState);
            this.panel1.Controls.Add(this.Lbl_NewCategorieState);
            this.panel1.Controls.Add(this.TxtBox_NewCategorieName);
            this.panel1.Controls.Add(this.Lbl_NewCategorieName);
            this.panel1.Location = new System.Drawing.Point(128, 233);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(386, 143);
            this.panel1.TabIndex = 1;
            // 
            // Btn_AddCategorie
            // 
            this.Btn_AddCategorie.AutoSize = true;
            this.Btn_AddCategorie.BackColor = System.Drawing.Color.White;
            this.Btn_AddCategorie.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_AddCategorie.Location = new System.Drawing.Point(275, 76);
            this.Btn_AddCategorie.Margin = new System.Windows.Forms.Padding(0);
            this.Btn_AddCategorie.Name = "Btn_AddCategorie";
            this.Btn_AddCategorie.Size = new System.Drawing.Size(91, 30);
            this.Btn_AddCategorie.TabIndex = 3;
            this.Btn_AddCategorie.Text = "Adicionar";
            this.Btn_AddCategorie.UseVisualStyleBackColor = false;
            this.Btn_AddCategorie.Click += new System.EventHandler(this.Btn_AddCategorie_Click);
            // 
            // ComboBox_NewCategorieState
            // 
            this.ComboBox_NewCategorieState.BackColor = System.Drawing.Color.White;
            this.ComboBox_NewCategorieState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(52)))), ((int)(((byte)(22)))));
            this.ComboBox_NewCategorieState.FormattingEnabled = true;
            this.ComboBox_NewCategorieState.Location = new System.Drawing.Point(89, 78);
            this.ComboBox_NewCategorieState.Margin = new System.Windows.Forms.Padding(0);
            this.ComboBox_NewCategorieState.Name = "ComboBox_NewCategorieState";
            this.ComboBox_NewCategorieState.Size = new System.Drawing.Size(121, 28);
            this.ComboBox_NewCategorieState.TabIndex = 3;
            // 
            // Lbl_NewCategorieState
            // 
            this.Lbl_NewCategorieState.AutoSize = true;
            this.Lbl_NewCategorieState.Location = new System.Drawing.Point(20, 81);
            this.Lbl_NewCategorieState.Margin = new System.Windows.Forms.Padding(0);
            this.Lbl_NewCategorieState.Name = "Lbl_NewCategorieState";
            this.Lbl_NewCategorieState.Size = new System.Drawing.Size(64, 20);
            this.Lbl_NewCategorieState.TabIndex = 2;
            this.Lbl_NewCategorieState.Text = "Estado:";
            // 
            // TxtBox_NewCategorieName
            // 
            this.TxtBox_NewCategorieName.BackColor = System.Drawing.Color.White;
            this.TxtBox_NewCategorieName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(52)))), ((int)(((byte)(22)))));
            this.TxtBox_NewCategorieName.Location = new System.Drawing.Point(80, 37);
            this.TxtBox_NewCategorieName.Margin = new System.Windows.Forms.Padding(0);
            this.TxtBox_NewCategorieName.Name = "TxtBox_NewCategorieName";
            this.TxtBox_NewCategorieName.Size = new System.Drawing.Size(286, 26);
            this.TxtBox_NewCategorieName.TabIndex = 1;
            // 
            // Lbl_NewCategorieName
            // 
            this.Lbl_NewCategorieName.AutoSize = true;
            this.Lbl_NewCategorieName.Location = new System.Drawing.Point(20, 40);
            this.Lbl_NewCategorieName.Margin = new System.Windows.Forms.Padding(0);
            this.Lbl_NewCategorieName.Name = "Lbl_NewCategorieName";
            this.Lbl_NewCategorieName.Size = new System.Drawing.Size(55, 20);
            this.Lbl_NewCategorieName.TabIndex = 0;
            this.Lbl_NewCategorieName.Text = "Nome:";
            // 
            // Lbl_AddCategorie
            // 
            this.Lbl_AddCategorie.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Lbl_AddCategorie.AutoSize = true;
            this.Lbl_AddCategorie.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_AddCategorie.Location = new System.Drawing.Point(148, 217);
            this.Lbl_AddCategorie.Margin = new System.Windows.Forms.Padding(0);
            this.Lbl_AddCategorie.Name = "Lbl_AddCategorie";
            this.Lbl_AddCategorie.Size = new System.Drawing.Size(225, 29);
            this.Lbl_AddCategorie.TabIndex = 2;
            this.Lbl_AddCategorie.Text = "Adicionar Categoria";
            // 
            // Lbl_EditCategorie
            // 
            this.Lbl_EditCategorie.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Lbl_EditCategorie.AutoSize = true;
            this.Lbl_EditCategorie.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_EditCategorie.Location = new System.Drawing.Point(147, 396);
            this.Lbl_EditCategorie.Margin = new System.Windows.Forms.Padding(0);
            this.Lbl_EditCategorie.Name = "Lbl_EditCategorie";
            this.Lbl_EditCategorie.Size = new System.Drawing.Size(187, 29);
            this.Lbl_EditCategorie.TabIndex = 4;
            this.Lbl_EditCategorie.Text = "Editar Categoria";
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.panel2.Controls.Add(this.Btn_SaveChangesOnCategorie);
            this.panel2.Controls.Add(this.ComboBox_CategorieState);
            this.panel2.Controls.Add(this.Lbl_CategorieState);
            this.panel2.Controls.Add(this.TxtBox_CategorieName);
            this.panel2.Controls.Add(this.Lbl_CategorieName);
            this.panel2.Location = new System.Drawing.Point(128, 412);
            this.panel2.Margin = new System.Windows.Forms.Padding(0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(386, 143);
            this.panel2.TabIndex = 3;
            // 
            // Btn_SaveChangesOnCategorie
            // 
            this.Btn_SaveChangesOnCategorie.AutoSize = true;
            this.Btn_SaveChangesOnCategorie.BackColor = System.Drawing.Color.White;
            this.Btn_SaveChangesOnCategorie.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_SaveChangesOnCategorie.Location = new System.Drawing.Point(288, 76);
            this.Btn_SaveChangesOnCategorie.Margin = new System.Windows.Forms.Padding(0);
            this.Btn_SaveChangesOnCategorie.Name = "Btn_SaveChangesOnCategorie";
            this.Btn_SaveChangesOnCategorie.Size = new System.Drawing.Size(78, 30);
            this.Btn_SaveChangesOnCategorie.TabIndex = 3;
            this.Btn_SaveChangesOnCategorie.Text = "Guardar";
            this.Btn_SaveChangesOnCategorie.UseVisualStyleBackColor = false;
            // 
            // ComboBox_CategorieState
            // 
            this.ComboBox_CategorieState.BackColor = System.Drawing.Color.White;
            this.ComboBox_CategorieState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(52)))), ((int)(((byte)(22)))));
            this.ComboBox_CategorieState.FormattingEnabled = true;
            this.ComboBox_CategorieState.Location = new System.Drawing.Point(89, 78);
            this.ComboBox_CategorieState.Margin = new System.Windows.Forms.Padding(0);
            this.ComboBox_CategorieState.Name = "ComboBox_CategorieState";
            this.ComboBox_CategorieState.Size = new System.Drawing.Size(121, 28);
            this.ComboBox_CategorieState.TabIndex = 3;
            // 
            // Lbl_CategorieState
            // 
            this.Lbl_CategorieState.AutoSize = true;
            this.Lbl_CategorieState.Location = new System.Drawing.Point(20, 81);
            this.Lbl_CategorieState.Margin = new System.Windows.Forms.Padding(0);
            this.Lbl_CategorieState.Name = "Lbl_CategorieState";
            this.Lbl_CategorieState.Size = new System.Drawing.Size(64, 20);
            this.Lbl_CategorieState.TabIndex = 2;
            this.Lbl_CategorieState.Text = "Estado:";
            // 
            // TxtBox_CategorieName
            // 
            this.TxtBox_CategorieName.BackColor = System.Drawing.Color.White;
            this.TxtBox_CategorieName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(52)))), ((int)(((byte)(22)))));
            this.TxtBox_CategorieName.Location = new System.Drawing.Point(80, 37);
            this.TxtBox_CategorieName.Margin = new System.Windows.Forms.Padding(0);
            this.TxtBox_CategorieName.Name = "TxtBox_CategorieName";
            this.TxtBox_CategorieName.Size = new System.Drawing.Size(286, 26);
            this.TxtBox_CategorieName.TabIndex = 1;
            // 
            // Lbl_CategorieName
            // 
            this.Lbl_CategorieName.AutoSize = true;
            this.Lbl_CategorieName.Location = new System.Drawing.Point(20, 40);
            this.Lbl_CategorieName.Margin = new System.Windows.Forms.Padding(0);
            this.Lbl_CategorieName.Name = "Lbl_CategorieName";
            this.Lbl_CategorieName.Size = new System.Drawing.Size(55, 20);
            this.Lbl_CategorieName.TabIndex = 0;
            this.Lbl_CategorieName.Text = "Nome:";
            // 
            // DataGridView_Categories
            // 
            this.DataGridView_Categories.AllowUserToAddRows = false;
            this.DataGridView_Categories.AllowUserToDeleteRows = false;
            this.DataGridView_Categories.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.DataGridView_Categories.AutoGenerateColumns = false;
            this.DataGridView_Categories.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.DataGridView_Categories.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(52)))), ((int)(((byte)(22)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridView_Categories.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.DataGridView_Categories.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridView_Categories.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.DataGridView_Categories.DataSource = this.BindingSource_AllCategories;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(52)))), ((int)(((byte)(22)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DataGridView_Categories.DefaultCellStyle = dataGridViewCellStyle4;
            this.DataGridView_Categories.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.DataGridView_Categories.Location = new System.Drawing.Point(625, 108);
            this.DataGridView_Categories.Margin = new System.Windows.Forms.Padding(0);
            this.DataGridView_Categories.MultiSelect = false;
            this.DataGridView_Categories.Name = "DataGridView_Categories";
            this.DataGridView_Categories.ReadOnly = true;
            this.DataGridView_Categories.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGridView_Categories.Size = new System.Drawing.Size(622, 447);
            this.DataGridView_Categories.TabIndex = 12;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "Nome";
            this.Column1.HeaderText = "Nome";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "Ativo";
            this.Column2.HeaderText = "Estado";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Categories
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.ClientSize = new System.Drawing.Size(1376, 663);
            this.Controls.Add(this.DataGridView_Categories);
            this.Controls.Add(this.Lbl_EditCategorie);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.Lbl_AddCategorie);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Lbl_Categories);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(52)))), ((int)(((byte)(22)))));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Categories";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Categories";
            this.Load += new System.EventHandler(this.Categories_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView_Categories)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BindingSource_AllCategories)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Lbl_Categories;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Btn_AddCategorie;
        private System.Windows.Forms.ComboBox ComboBox_NewCategorieState;
        private System.Windows.Forms.Label Lbl_NewCategorieState;
        private System.Windows.Forms.TextBox TxtBox_NewCategorieName;
        private System.Windows.Forms.Label Lbl_NewCategorieName;
        private System.Windows.Forms.Label Lbl_AddCategorie;
        private System.Windows.Forms.Label Lbl_EditCategorie;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button Btn_SaveChangesOnCategorie;
        private System.Windows.Forms.ComboBox ComboBox_CategorieState;
        private System.Windows.Forms.Label Lbl_CategorieState;
        private System.Windows.Forms.TextBox TxtBox_CategorieName;
        private System.Windows.Forms.Label Lbl_CategorieName;
        private System.Windows.Forms.DataGridView DataGridView_Categories;
        private System.Windows.Forms.BindingSource BindingSource_AllCategories;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
    }
}