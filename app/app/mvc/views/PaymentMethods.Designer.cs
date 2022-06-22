namespace app
{
    partial class PaymentMethods
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
            this.DataGridView_PaymentMethods = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BindingSource_AllPaymentMethods = new System.Windows.Forms.BindingSource(this.components);
            this.Lbl_EditPaymentMethod = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Btn_SaveChangesOnPaymentMethod = new System.Windows.Forms.Button();
            this.ComboBox_PaymentMethodState = new System.Windows.Forms.ComboBox();
            this.Lbl_PaymentMethodState = new System.Windows.Forms.Label();
            this.TxtBox_PaymentMethodName = new System.Windows.Forms.TextBox();
            this.Lbl_PaymentMethodName = new System.Windows.Forms.Label();
            this.Lbl_AddPaymentMethod = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Btn_AddPaymentMethod = new System.Windows.Forms.Button();
            this.ComboBox_NewPaymentMethodState = new System.Windows.Forms.ComboBox();
            this.Lbl_NewPaymentMethodState = new System.Windows.Forms.Label();
            this.TxtBox_NewPaymentMethodName = new System.Windows.Forms.TextBox();
            this.Lbl_NewPaymentMethodName = new System.Windows.Forms.Label();
            this.Lbl_PaymentMethods = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView_PaymentMethods)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BindingSource_AllPaymentMethods)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // DataGridView_PaymentMethods
            // 
            this.DataGridView_PaymentMethods.AllowUserToAddRows = false;
            this.DataGridView_PaymentMethods.AllowUserToDeleteRows = false;
            this.DataGridView_PaymentMethods.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.DataGridView_PaymentMethods.AutoGenerateColumns = false;
            this.DataGridView_PaymentMethods.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.DataGridView_PaymentMethods.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(52)))), ((int)(((byte)(22)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridView_PaymentMethods.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.DataGridView_PaymentMethods.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridView_PaymentMethods.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.DataGridView_PaymentMethods.DataSource = this.BindingSource_AllPaymentMethods;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(52)))), ((int)(((byte)(22)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DataGridView_PaymentMethods.DefaultCellStyle = dataGridViewCellStyle4;
            this.DataGridView_PaymentMethods.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.DataGridView_PaymentMethods.Location = new System.Drawing.Point(626, 108);
            this.DataGridView_PaymentMethods.Margin = new System.Windows.Forms.Padding(0);
            this.DataGridView_PaymentMethods.MultiSelect = false;
            this.DataGridView_PaymentMethods.Name = "DataGridView_PaymentMethods";
            this.DataGridView_PaymentMethods.ReadOnly = true;
            this.DataGridView_PaymentMethods.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGridView_PaymentMethods.Size = new System.Drawing.Size(622, 447);
            this.DataGridView_PaymentMethods.TabIndex = 18;
            this.DataGridView_PaymentMethods.SelectionChanged += new System.EventHandler(this.DataGridView_PaymentMethods_SelectionChanged);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "Metodo";
            this.Column1.HeaderText = "Método Pagamento";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 180;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "Ativo";
            this.Column2.HeaderText = "Estado";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Lbl_EditPaymentMethod
            // 
            this.Lbl_EditPaymentMethod.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Lbl_EditPaymentMethod.AutoSize = true;
            this.Lbl_EditPaymentMethod.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_EditPaymentMethod.Location = new System.Drawing.Point(148, 396);
            this.Lbl_EditPaymentMethod.Margin = new System.Windows.Forms.Padding(0);
            this.Lbl_EditPaymentMethod.Name = "Lbl_EditPaymentMethod";
            this.Lbl_EditPaymentMethod.Size = new System.Drawing.Size(327, 29);
            this.Lbl_EditPaymentMethod.TabIndex = 17;
            this.Lbl_EditPaymentMethod.Text = "Editar Método de Pagamento";
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.panel2.Controls.Add(this.Btn_SaveChangesOnPaymentMethod);
            this.panel2.Controls.Add(this.ComboBox_PaymentMethodState);
            this.panel2.Controls.Add(this.Lbl_PaymentMethodState);
            this.panel2.Controls.Add(this.TxtBox_PaymentMethodName);
            this.panel2.Controls.Add(this.Lbl_PaymentMethodName);
            this.panel2.Location = new System.Drawing.Point(128, 412);
            this.panel2.Margin = new System.Windows.Forms.Padding(0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(466, 143);
            this.panel2.TabIndex = 16;
            // 
            // Btn_SaveChangesOnPaymentMethod
            // 
            this.Btn_SaveChangesOnPaymentMethod.AutoSize = true;
            this.Btn_SaveChangesOnPaymentMethod.BackColor = System.Drawing.Color.White;
            this.Btn_SaveChangesOnPaymentMethod.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_SaveChangesOnPaymentMethod.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_SaveChangesOnPaymentMethod.Location = new System.Drawing.Point(368, 76);
            this.Btn_SaveChangesOnPaymentMethod.Margin = new System.Windows.Forms.Padding(0);
            this.Btn_SaveChangesOnPaymentMethod.Name = "Btn_SaveChangesOnPaymentMethod";
            this.Btn_SaveChangesOnPaymentMethod.Size = new System.Drawing.Size(78, 30);
            this.Btn_SaveChangesOnPaymentMethod.TabIndex = 3;
            this.Btn_SaveChangesOnPaymentMethod.Text = "Guardar";
            this.Btn_SaveChangesOnPaymentMethod.UseVisualStyleBackColor = false;
            this.Btn_SaveChangesOnPaymentMethod.Click += new System.EventHandler(this.Btn_SaveChangesOnPaymentMethod_Click);
            // 
            // ComboBox_PaymentMethodState
            // 
            this.ComboBox_PaymentMethodState.BackColor = System.Drawing.Color.White;
            this.ComboBox_PaymentMethodState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(52)))), ((int)(((byte)(22)))));
            this.ComboBox_PaymentMethodState.FormattingEnabled = true;
            this.ComboBox_PaymentMethodState.Location = new System.Drawing.Point(89, 78);
            this.ComboBox_PaymentMethodState.Margin = new System.Windows.Forms.Padding(0);
            this.ComboBox_PaymentMethodState.Name = "ComboBox_PaymentMethodState";
            this.ComboBox_PaymentMethodState.Size = new System.Drawing.Size(121, 28);
            this.ComboBox_PaymentMethodState.TabIndex = 3;
            // 
            // Lbl_PaymentMethodState
            // 
            this.Lbl_PaymentMethodState.AutoSize = true;
            this.Lbl_PaymentMethodState.Location = new System.Drawing.Point(20, 81);
            this.Lbl_PaymentMethodState.Margin = new System.Windows.Forms.Padding(0);
            this.Lbl_PaymentMethodState.Name = "Lbl_PaymentMethodState";
            this.Lbl_PaymentMethodState.Size = new System.Drawing.Size(64, 20);
            this.Lbl_PaymentMethodState.TabIndex = 2;
            this.Lbl_PaymentMethodState.Text = "Estado:";
            // 
            // TxtBox_PaymentMethodName
            // 
            this.TxtBox_PaymentMethodName.BackColor = System.Drawing.Color.White;
            this.TxtBox_PaymentMethodName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(52)))), ((int)(((byte)(22)))));
            this.TxtBox_PaymentMethodName.Location = new System.Drawing.Point(80, 37);
            this.TxtBox_PaymentMethodName.Margin = new System.Windows.Forms.Padding(0);
            this.TxtBox_PaymentMethodName.Name = "TxtBox_PaymentMethodName";
            this.TxtBox_PaymentMethodName.Size = new System.Drawing.Size(366, 26);
            this.TxtBox_PaymentMethodName.TabIndex = 1;
            // 
            // Lbl_PaymentMethodName
            // 
            this.Lbl_PaymentMethodName.AutoSize = true;
            this.Lbl_PaymentMethodName.Location = new System.Drawing.Point(20, 40);
            this.Lbl_PaymentMethodName.Margin = new System.Windows.Forms.Padding(0);
            this.Lbl_PaymentMethodName.Name = "Lbl_PaymentMethodName";
            this.Lbl_PaymentMethodName.Size = new System.Drawing.Size(55, 20);
            this.Lbl_PaymentMethodName.TabIndex = 0;
            this.Lbl_PaymentMethodName.Text = "Nome:";
            // 
            // Lbl_AddPaymentMethod
            // 
            this.Lbl_AddPaymentMethod.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Lbl_AddPaymentMethod.AutoSize = true;
            this.Lbl_AddPaymentMethod.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_AddPaymentMethod.Location = new System.Drawing.Point(148, 217);
            this.Lbl_AddPaymentMethod.Margin = new System.Windows.Forms.Padding(0);
            this.Lbl_AddPaymentMethod.Name = "Lbl_AddPaymentMethod";
            this.Lbl_AddPaymentMethod.Size = new System.Drawing.Size(365, 29);
            this.Lbl_AddPaymentMethod.TabIndex = 15;
            this.Lbl_AddPaymentMethod.Text = "Adicionar Método de Pagamento";
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.panel1.Controls.Add(this.Btn_AddPaymentMethod);
            this.panel1.Controls.Add(this.ComboBox_NewPaymentMethodState);
            this.panel1.Controls.Add(this.Lbl_NewPaymentMethodState);
            this.panel1.Controls.Add(this.TxtBox_NewPaymentMethodName);
            this.panel1.Controls.Add(this.Lbl_NewPaymentMethodName);
            this.panel1.Location = new System.Drawing.Point(128, 233);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(466, 143);
            this.panel1.TabIndex = 14;
            // 
            // Btn_AddPaymentMethod
            // 
            this.Btn_AddPaymentMethod.AutoSize = true;
            this.Btn_AddPaymentMethod.BackColor = System.Drawing.Color.White;
            this.Btn_AddPaymentMethod.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_AddPaymentMethod.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_AddPaymentMethod.Location = new System.Drawing.Point(355, 76);
            this.Btn_AddPaymentMethod.Margin = new System.Windows.Forms.Padding(0);
            this.Btn_AddPaymentMethod.Name = "Btn_AddPaymentMethod";
            this.Btn_AddPaymentMethod.Size = new System.Drawing.Size(91, 30);
            this.Btn_AddPaymentMethod.TabIndex = 3;
            this.Btn_AddPaymentMethod.Text = "Adicionar";
            this.Btn_AddPaymentMethod.UseVisualStyleBackColor = false;
            this.Btn_AddPaymentMethod.Click += new System.EventHandler(this.Btn_AddPaymentMethod_Click);
            // 
            // ComboBox_NewPaymentMethodState
            // 
            this.ComboBox_NewPaymentMethodState.BackColor = System.Drawing.Color.White;
            this.ComboBox_NewPaymentMethodState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(52)))), ((int)(((byte)(22)))));
            this.ComboBox_NewPaymentMethodState.FormattingEnabled = true;
            this.ComboBox_NewPaymentMethodState.Location = new System.Drawing.Point(89, 78);
            this.ComboBox_NewPaymentMethodState.Margin = new System.Windows.Forms.Padding(0);
            this.ComboBox_NewPaymentMethodState.Name = "ComboBox_NewPaymentMethodState";
            this.ComboBox_NewPaymentMethodState.Size = new System.Drawing.Size(121, 28);
            this.ComboBox_NewPaymentMethodState.TabIndex = 3;
            // 
            // Lbl_NewPaymentMethodState
            // 
            this.Lbl_NewPaymentMethodState.AutoSize = true;
            this.Lbl_NewPaymentMethodState.Location = new System.Drawing.Point(20, 81);
            this.Lbl_NewPaymentMethodState.Margin = new System.Windows.Forms.Padding(0);
            this.Lbl_NewPaymentMethodState.Name = "Lbl_NewPaymentMethodState";
            this.Lbl_NewPaymentMethodState.Size = new System.Drawing.Size(64, 20);
            this.Lbl_NewPaymentMethodState.TabIndex = 2;
            this.Lbl_NewPaymentMethodState.Text = "Estado:";
            // 
            // TxtBox_NewPaymentMethodName
            // 
            this.TxtBox_NewPaymentMethodName.BackColor = System.Drawing.Color.White;
            this.TxtBox_NewPaymentMethodName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(52)))), ((int)(((byte)(22)))));
            this.TxtBox_NewPaymentMethodName.Location = new System.Drawing.Point(80, 37);
            this.TxtBox_NewPaymentMethodName.Margin = new System.Windows.Forms.Padding(0);
            this.TxtBox_NewPaymentMethodName.Name = "TxtBox_NewPaymentMethodName";
            this.TxtBox_NewPaymentMethodName.Size = new System.Drawing.Size(366, 26);
            this.TxtBox_NewPaymentMethodName.TabIndex = 1;
            // 
            // Lbl_NewPaymentMethodName
            // 
            this.Lbl_NewPaymentMethodName.AutoSize = true;
            this.Lbl_NewPaymentMethodName.Location = new System.Drawing.Point(20, 40);
            this.Lbl_NewPaymentMethodName.Margin = new System.Windows.Forms.Padding(0);
            this.Lbl_NewPaymentMethodName.Name = "Lbl_NewPaymentMethodName";
            this.Lbl_NewPaymentMethodName.Size = new System.Drawing.Size(55, 20);
            this.Lbl_NewPaymentMethodName.TabIndex = 0;
            this.Lbl_NewPaymentMethodName.Text = "Nome:";
            // 
            // Lbl_PaymentMethods
            // 
            this.Lbl_PaymentMethods.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Lbl_PaymentMethods.AutoSize = true;
            this.Lbl_PaymentMethods.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_PaymentMethods.Location = new System.Drawing.Point(121, 108);
            this.Lbl_PaymentMethods.Margin = new System.Windows.Forms.Padding(0);
            this.Lbl_PaymentMethods.Name = "Lbl_PaymentMethods";
            this.Lbl_PaymentMethods.Size = new System.Drawing.Size(372, 37);
            this.Lbl_PaymentMethods.TabIndex = 13;
            this.Lbl_PaymentMethods.Text = "Métodos de Pagamentos";
            // 
            // PaymentMethods
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.ClientSize = new System.Drawing.Size(1376, 663);
            this.Controls.Add(this.DataGridView_PaymentMethods);
            this.Controls.Add(this.Lbl_EditPaymentMethod);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.Lbl_AddPaymentMethod);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Lbl_PaymentMethods);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(52)))), ((int)(((byte)(22)))));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "PaymentMethods";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Métodos de Pagamentos";
            this.Load += new System.EventHandler(this.PaymentMethods_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView_PaymentMethods)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BindingSource_AllPaymentMethods)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DataGridView_PaymentMethods;
        private System.Windows.Forms.Label Lbl_EditPaymentMethod;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button Btn_SaveChangesOnPaymentMethod;
        private System.Windows.Forms.ComboBox ComboBox_PaymentMethodState;
        private System.Windows.Forms.Label Lbl_PaymentMethodState;
        private System.Windows.Forms.TextBox TxtBox_PaymentMethodName;
        private System.Windows.Forms.Label Lbl_PaymentMethodName;
        private System.Windows.Forms.Label Lbl_AddPaymentMethod;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Btn_AddPaymentMethod;
        private System.Windows.Forms.ComboBox ComboBox_NewPaymentMethodState;
        private System.Windows.Forms.Label Lbl_NewPaymentMethodState;
        private System.Windows.Forms.TextBox TxtBox_NewPaymentMethodName;
        private System.Windows.Forms.Label Lbl_NewPaymentMethodName;
        private System.Windows.Forms.Label Lbl_PaymentMethods;
        private System.Windows.Forms.BindingSource BindingSource_AllPaymentMethods;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
    }
}