
namespace app
{
    partial class SelectRestaurant
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Lbl_Title = new System.Windows.Forms.Label();
            this.Lbl_Name = new System.Windows.Forms.Label();
            this.TxtBox_Name = new System.Windows.Forms.TextBox();
            this.Btn_Filter = new System.Windows.Forms.Button();
            this.DataGridView_AvailableRestaurants = new System.Windows.Forms.DataGridView();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Morada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BindingSource_AllRestaurants = new System.Windows.Forms.BindingSource(this.components);
            this.Btn_CreateRestaurant = new System.Windows.Forms.Button();
            this.Btn_Confirm = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView_AvailableRestaurants)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BindingSource_AllRestaurants)).BeginInit();
            this.SuspendLayout();
            // 
            // Lbl_Title
            // 
            this.Lbl_Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.Lbl_Title.Location = new System.Drawing.Point(0, 107);
            this.Lbl_Title.Margin = new System.Windows.Forms.Padding(0);
            this.Lbl_Title.Name = "Lbl_Title";
            this.Lbl_Title.Size = new System.Drawing.Size(637, 42);
            this.Lbl_Title.TabIndex = 0;
            this.Lbl_Title.Text = "Selecione o restaurante!";
            this.Lbl_Title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Lbl_Name
            // 
            this.Lbl_Name.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Lbl_Name.AutoSize = true;
            this.Lbl_Name.Location = new System.Drawing.Point(98, 199);
            this.Lbl_Name.Margin = new System.Windows.Forms.Padding(0);
            this.Lbl_Name.Name = "Lbl_Name";
            this.Lbl_Name.Size = new System.Drawing.Size(55, 20);
            this.Lbl_Name.TabIndex = 1;
            this.Lbl_Name.Text = "Nome:";
            // 
            // TxtBox_Name
            // 
            this.TxtBox_Name.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.TxtBox_Name.BackColor = System.Drawing.Color.White;
            this.TxtBox_Name.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(52)))), ((int)(((byte)(22)))));
            this.TxtBox_Name.Location = new System.Drawing.Point(102, 230);
            this.TxtBox_Name.Margin = new System.Windows.Forms.Padding(0);
            this.TxtBox_Name.Name = "TxtBox_Name";
            this.TxtBox_Name.Size = new System.Drawing.Size(262, 26);
            this.TxtBox_Name.TabIndex = 2;
            // 
            // Btn_Filter
            // 
            this.Btn_Filter.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Btn_Filter.AutoSize = true;
            this.Btn_Filter.BackColor = System.Drawing.Color.White;
            this.Btn_Filter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Filter.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F);
            this.Btn_Filter.Location = new System.Drawing.Point(468, 230);
            this.Btn_Filter.Margin = new System.Windows.Forms.Padding(0);
            this.Btn_Filter.Name = "Btn_Filter";
            this.Btn_Filter.Size = new System.Drawing.Size(67, 27);
            this.Btn_Filter.TabIndex = 3;
            this.Btn_Filter.Text = "Filtrar";
            this.Btn_Filter.UseVisualStyleBackColor = false;
            this.Btn_Filter.Click += new System.EventHandler(this.Btn_Filter_Click);
            // 
            // DataGridView_AvailableRestaurants
            // 
            this.DataGridView_AvailableRestaurants.AllowUserToAddRows = false;
            this.DataGridView_AvailableRestaurants.AllowUserToDeleteRows = false;
            this.DataGridView_AvailableRestaurants.AutoGenerateColumns = false;
            this.DataGridView_AvailableRestaurants.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.DataGridView_AvailableRestaurants.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.DataGridView_AvailableRestaurants.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.DataGridView_AvailableRestaurants.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(52)))), ((int)(((byte)(22)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridView_AvailableRestaurants.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DataGridView_AvailableRestaurants.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridView_AvailableRestaurants.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nome,
            this.Morada});
            this.DataGridView_AvailableRestaurants.DataSource = this.BindingSource_AllRestaurants;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(52)))), ((int)(((byte)(22)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DataGridView_AvailableRestaurants.DefaultCellStyle = dataGridViewCellStyle2;
            this.DataGridView_AvailableRestaurants.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.DataGridView_AvailableRestaurants.Location = new System.Drawing.Point(102, 301);
            this.DataGridView_AvailableRestaurants.Margin = new System.Windows.Forms.Padding(0);
            this.DataGridView_AvailableRestaurants.MultiSelect = false;
            this.DataGridView_AvailableRestaurants.Name = "DataGridView_AvailableRestaurants";
            this.DataGridView_AvailableRestaurants.ReadOnly = true;
            this.DataGridView_AvailableRestaurants.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGridView_AvailableRestaurants.Size = new System.Drawing.Size(433, 203);
            this.DataGridView_AvailableRestaurants.TabIndex = 19;
            this.DataGridView_AvailableRestaurants.SelectionChanged += new System.EventHandler(this.DataGridView_AvailableRestaurants_SelectionChanged);
            // 
            // Nome
            // 
            this.Nome.DataPropertyName = "Nome";
            this.Nome.HeaderText = "Nome";
            this.Nome.Name = "Nome";
            this.Nome.ReadOnly = true;
            this.Nome.Width = 76;
            // 
            // Morada
            // 
            this.Morada.DataPropertyName = "Morada";
            this.Morada.HeaderText = "Morada";
            this.Morada.Name = "Morada";
            this.Morada.ReadOnly = true;
            this.Morada.Width = 88;
            // 
            // Btn_CreateRestaurant
            // 
            this.Btn_CreateRestaurant.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Btn_CreateRestaurant.AutoSize = true;
            this.Btn_CreateRestaurant.BackColor = System.Drawing.Color.White;
            this.Btn_CreateRestaurant.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_CreateRestaurant.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Btn_CreateRestaurant.Location = new System.Drawing.Point(102, 554);
            this.Btn_CreateRestaurant.Margin = new System.Windows.Forms.Padding(0);
            this.Btn_CreateRestaurant.Name = "Btn_CreateRestaurant";
            this.Btn_CreateRestaurant.Size = new System.Drawing.Size(128, 51);
            this.Btn_CreateRestaurant.TabIndex = 20;
            this.Btn_CreateRestaurant.Text = "Criar Novo";
            this.Btn_CreateRestaurant.UseVisualStyleBackColor = false;
            this.Btn_CreateRestaurant.Click += new System.EventHandler(this.Btn_CreateRestaurant_Click);
            // 
            // Btn_Confirm
            // 
            this.Btn_Confirm.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Btn_Confirm.AutoSize = true;
            this.Btn_Confirm.BackColor = System.Drawing.Color.White;
            this.Btn_Confirm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Confirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Btn_Confirm.Location = new System.Drawing.Point(407, 554);
            this.Btn_Confirm.Margin = new System.Windows.Forms.Padding(0);
            this.Btn_Confirm.Name = "Btn_Confirm";
            this.Btn_Confirm.Size = new System.Drawing.Size(128, 51);
            this.Btn_Confirm.TabIndex = 21;
            this.Btn_Confirm.Text = "Confirmar";
            this.Btn_Confirm.UseVisualStyleBackColor = false;
            this.Btn_Confirm.Click += new System.EventHandler(this.Btn_Confirm_Click);
            // 
            // SelectRestaurant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.ClientSize = new System.Drawing.Size(637, 712);
            this.Controls.Add(this.Btn_Confirm);
            this.Controls.Add(this.Btn_CreateRestaurant);
            this.Controls.Add(this.DataGridView_AvailableRestaurants);
            this.Controls.Add(this.Lbl_Title);
            this.Controls.Add(this.Btn_Filter);
            this.Controls.Add(this.Lbl_Name);
            this.Controls.Add(this.TxtBox_Name);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(52)))), ((int)(((byte)(22)))));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "SelectRestaurant";
            this.Padding = new System.Windows.Forms.Padding(0, 107, 0, 0);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Selecione o Restaurante";
            this.Load += new System.EventHandler(this.SelectRestaurant_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView_AvailableRestaurants)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BindingSource_AllRestaurants)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Lbl_Title;
        private System.Windows.Forms.Label Lbl_Name;
        private System.Windows.Forms.TextBox TxtBox_Name;
        private System.Windows.Forms.Button Btn_Filter;
        private System.Windows.Forms.DataGridView DataGridView_AvailableRestaurants;
        private System.Windows.Forms.Button Btn_CreateRestaurant;
        private System.Windows.Forms.Button Btn_Confirm;
        private System.Windows.Forms.BindingSource BindingSource_AllRestaurants;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn Morada;
    }
}