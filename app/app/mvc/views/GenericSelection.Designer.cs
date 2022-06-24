
namespace app
{
    partial class GenericSelection
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
            this.Btn_Confirm = new System.Windows.Forms.Button();
            this.DataGridView_AvailableStuff = new System.Windows.Forms.DataGridView();
            this.BindingSource_AllStuff = new System.Windows.Forms.BindingSource(this.components);
            this.Lbl_Title = new System.Windows.Forms.Label();
            this.Btn_Filter = new System.Windows.Forms.Button();
            this.Lbl_Name = new System.Windows.Forms.Label();
            this.TxtBox_Name = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView_AvailableStuff)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BindingSource_AllStuff)).BeginInit();
            this.SuspendLayout();
            // 
            // Btn_Confirm
            // 
            this.Btn_Confirm.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Btn_Confirm.AutoSize = true;
            this.Btn_Confirm.BackColor = System.Drawing.Color.White;
            this.Btn_Confirm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Confirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Btn_Confirm.Location = new System.Drawing.Point(257, 554);
            this.Btn_Confirm.Margin = new System.Windows.Forms.Padding(0);
            this.Btn_Confirm.Name = "Btn_Confirm";
            this.Btn_Confirm.Size = new System.Drawing.Size(128, 51);
            this.Btn_Confirm.TabIndex = 28;
            this.Btn_Confirm.Text = "Confirmar";
            this.Btn_Confirm.UseVisualStyleBackColor = false;
            this.Btn_Confirm.Click += new System.EventHandler(this.Btn_Confirm_Click);
            // 
            // DataGridView_AvailableStuff
            // 
            this.DataGridView_AvailableStuff.AllowUserToAddRows = false;
            this.DataGridView_AvailableStuff.AllowUserToDeleteRows = false;
            this.DataGridView_AvailableStuff.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.DataGridView_AvailableStuff.AutoGenerateColumns = false;
            this.DataGridView_AvailableStuff.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.DataGridView_AvailableStuff.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(52)))), ((int)(((byte)(22)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridView_AvailableStuff.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DataGridView_AvailableStuff.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridView_AvailableStuff.DataSource = this.BindingSource_AllStuff;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(52)))), ((int)(((byte)(22)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DataGridView_AvailableStuff.DefaultCellStyle = dataGridViewCellStyle2;
            this.DataGridView_AvailableStuff.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.DataGridView_AvailableStuff.Location = new System.Drawing.Point(102, 301);
            this.DataGridView_AvailableStuff.Margin = new System.Windows.Forms.Padding(0);
            this.DataGridView_AvailableStuff.MultiSelect = false;
            this.DataGridView_AvailableStuff.Name = "DataGridView_AvailableStuff";
            this.DataGridView_AvailableStuff.ReadOnly = true;
            this.DataGridView_AvailableStuff.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGridView_AvailableStuff.Size = new System.Drawing.Size(433, 203);
            this.DataGridView_AvailableStuff.TabIndex = 26;
            this.DataGridView_AvailableStuff.SelectionChanged += new System.EventHandler(this.DataGridView_AvailableStuff_SelectionChanged);
            // 
            // Lbl_Title
            // 
            this.Lbl_Title.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Lbl_Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.Lbl_Title.Location = new System.Drawing.Point(0, 107);
            this.Lbl_Title.Margin = new System.Windows.Forms.Padding(0);
            this.Lbl_Title.Name = "Lbl_Title";
            this.Lbl_Title.Size = new System.Drawing.Size(637, 42);
            this.Lbl_Title.TabIndex = 22;
            this.Lbl_Title.Text = "Selecione ####!";
            this.Lbl_Title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.Btn_Filter.TabIndex = 25;
            this.Btn_Filter.Text = "Filtrar";
            this.Btn_Filter.UseVisualStyleBackColor = false;
            this.Btn_Filter.Click += new System.EventHandler(this.Btn_Filter_Click);
            // 
            // Lbl_Name
            // 
            this.Lbl_Name.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Lbl_Name.AutoSize = true;
            this.Lbl_Name.Location = new System.Drawing.Point(98, 199);
            this.Lbl_Name.Margin = new System.Windows.Forms.Padding(0);
            this.Lbl_Name.Name = "Lbl_Name";
            this.Lbl_Name.Size = new System.Drawing.Size(55, 20);
            this.Lbl_Name.TabIndex = 23;
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
            this.TxtBox_Name.TabIndex = 24;
            // 
            // GenericSelection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.ClientSize = new System.Drawing.Size(637, 712);
            this.Controls.Add(this.Btn_Confirm);
            this.Controls.Add(this.DataGridView_AvailableStuff);
            this.Controls.Add(this.Lbl_Title);
            this.Controls.Add(this.Btn_Filter);
            this.Controls.Add(this.Lbl_Name);
            this.Controls.Add(this.TxtBox_Name);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(52)))), ((int)(((byte)(22)))));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "GenericSelection";
            this.Padding = new System.Windows.Forms.Padding(0, 107, 0, 0);
            this.Text = "Secione o";
            this.Load += new System.EventHandler(this.GenericSelection_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView_AvailableStuff)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BindingSource_AllStuff)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Btn_Confirm;
        private System.Windows.Forms.DataGridView DataGridView_AvailableStuff;
        private System.Windows.Forms.Label Lbl_Title;
        private System.Windows.Forms.Button Btn_Filter;
        private System.Windows.Forms.Label Lbl_Name;
        private System.Windows.Forms.TextBox TxtBox_Name;
        private System.Windows.Forms.BindingSource BindingSource_AllStuff;
    }
}