namespace app
{
    partial class AddEditRestaurant
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
            this.Lbl_Title = new System.Windows.Forms.Label();
            this.Lbl_RestaurantName = new System.Windows.Forms.Label();
            this.TxtBox_RestaurantName = new System.Windows.Forms.TextBox();
            this.Lbl_RestaurantAddress = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.TxtBox_RestaurantCountry = new System.Windows.Forms.TextBox();
            this.Lbl_RestaurantCountry = new System.Windows.Forms.Label();
            this.MaskedTxtBox_RestaurantPostalCode = new System.Windows.Forms.MaskedTextBox();
            this.Lbl_RestaurantPostalCode = new System.Windows.Forms.Label();
            this.TxtBox_RestaurantCity = new System.Windows.Forms.TextBox();
            this.Lbl_RestaurantCity = new System.Windows.Forms.Label();
            this.TxtBox_RestaurantStreet = new System.Windows.Forms.TextBox();
            this.Lbl_RestaurantStreet = new System.Windows.Forms.Label();
            this.Btn_Conclude = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Lbl_Title
            // 
            this.Lbl_Title.Dock = System.Windows.Forms.DockStyle.Top;
            this.Lbl_Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Title.Location = new System.Drawing.Point(0, 123);
            this.Lbl_Title.Margin = new System.Windows.Forms.Padding(0);
            this.Lbl_Title.Name = "Lbl_Title";
            this.Lbl_Title.Size = new System.Drawing.Size(637, 42);
            this.Lbl_Title.TabIndex = 0;
            this.Lbl_Title.Text = "Novo Restaurante";
            this.Lbl_Title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Lbl_RestaurantName
            // 
            this.Lbl_RestaurantName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Lbl_RestaurantName.AutoSize = true;
            this.Lbl_RestaurantName.Location = new System.Drawing.Point(146, 218);
            this.Lbl_RestaurantName.Margin = new System.Windows.Forms.Padding(0);
            this.Lbl_RestaurantName.Name = "Lbl_RestaurantName";
            this.Lbl_RestaurantName.Size = new System.Drawing.Size(55, 20);
            this.Lbl_RestaurantName.TabIndex = 1;
            this.Lbl_RestaurantName.Text = "Nome:";
            // 
            // TxtBox_RestaurantName
            // 
            this.TxtBox_RestaurantName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.TxtBox_RestaurantName.BackColor = System.Drawing.Color.White;
            this.TxtBox_RestaurantName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(52)))), ((int)(((byte)(22)))));
            this.TxtBox_RestaurantName.Location = new System.Drawing.Point(211, 215);
            this.TxtBox_RestaurantName.Margin = new System.Windows.Forms.Padding(0);
            this.TxtBox_RestaurantName.Name = "TxtBox_RestaurantName";
            this.TxtBox_RestaurantName.Size = new System.Drawing.Size(281, 26);
            this.TxtBox_RestaurantName.TabIndex = 2;
            // 
            // Lbl_RestaurantAddress
            // 
            this.Lbl_RestaurantAddress.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Lbl_RestaurantAddress.AutoSize = true;
            this.Lbl_RestaurantAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_RestaurantAddress.Location = new System.Drawing.Point(272, 291);
            this.Lbl_RestaurantAddress.Margin = new System.Windows.Forms.Padding(0);
            this.Lbl_RestaurantAddress.Name = "Lbl_RestaurantAddress";
            this.Lbl_RestaurantAddress.Size = new System.Drawing.Size(95, 29);
            this.Lbl_RestaurantAddress.TabIndex = 3;
            this.Lbl_RestaurantAddress.Text = "Morada";
            this.Lbl_RestaurantAddress.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.panel1.Controls.Add(this.TxtBox_RestaurantCountry);
            this.panel1.Controls.Add(this.Lbl_RestaurantCountry);
            this.panel1.Controls.Add(this.MaskedTxtBox_RestaurantPostalCode);
            this.panel1.Controls.Add(this.Lbl_RestaurantPostalCode);
            this.panel1.Controls.Add(this.TxtBox_RestaurantCity);
            this.panel1.Controls.Add(this.Lbl_RestaurantCity);
            this.panel1.Controls.Add(this.TxtBox_RestaurantStreet);
            this.panel1.Controls.Add(this.Lbl_RestaurantStreet);
            this.panel1.Location = new System.Drawing.Point(126, 310);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(386, 234);
            this.panel1.TabIndex = 4;
            // 
            // TxtBox_RestaurantCountry
            // 
            this.TxtBox_RestaurantCountry.BackColor = System.Drawing.Color.White;
            this.TxtBox_RestaurantCountry.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(52)))), ((int)(((byte)(22)))));
            this.TxtBox_RestaurantCountry.Location = new System.Drawing.Point(73, 173);
            this.TxtBox_RestaurantCountry.Margin = new System.Windows.Forms.Padding(0);
            this.TxtBox_RestaurantCountry.Name = "TxtBox_RestaurantCountry";
            this.TxtBox_RestaurantCountry.Size = new System.Drawing.Size(293, 26);
            this.TxtBox_RestaurantCountry.TabIndex = 26;
            // 
            // Lbl_RestaurantCountry
            // 
            this.Lbl_RestaurantCountry.AutoSize = true;
            this.Lbl_RestaurantCountry.Location = new System.Drawing.Point(20, 176);
            this.Lbl_RestaurantCountry.Margin = new System.Windows.Forms.Padding(0);
            this.Lbl_RestaurantCountry.Name = "Lbl_RestaurantCountry";
            this.Lbl_RestaurantCountry.Size = new System.Drawing.Size(43, 20);
            this.Lbl_RestaurantCountry.TabIndex = 25;
            this.Lbl_RestaurantCountry.Text = "Pais:";
            // 
            // MaskedTxtBox_RestaurantPostalCode
            // 
            this.MaskedTxtBox_RestaurantPostalCode.BackColor = System.Drawing.Color.White;
            this.MaskedTxtBox_RestaurantPostalCode.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(52)))), ((int)(((byte)(22)))));
            this.MaskedTxtBox_RestaurantPostalCode.Location = new System.Drawing.Point(141, 127);
            this.MaskedTxtBox_RestaurantPostalCode.Margin = new System.Windows.Forms.Padding(0);
            this.MaskedTxtBox_RestaurantPostalCode.Mask = "0000 - 000";
            this.MaskedTxtBox_RestaurantPostalCode.Name = "MaskedTxtBox_RestaurantPostalCode";
            this.MaskedTxtBox_RestaurantPostalCode.PromptChar = '0';
            this.MaskedTxtBox_RestaurantPostalCode.Size = new System.Drawing.Size(120, 26);
            this.MaskedTxtBox_RestaurantPostalCode.TabIndex = 24;
            this.MaskedTxtBox_RestaurantPostalCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Lbl_RestaurantPostalCode
            // 
            this.Lbl_RestaurantPostalCode.AutoSize = true;
            this.Lbl_RestaurantPostalCode.Location = new System.Drawing.Point(20, 130);
            this.Lbl_RestaurantPostalCode.Margin = new System.Windows.Forms.Padding(0);
            this.Lbl_RestaurantPostalCode.Name = "Lbl_RestaurantPostalCode";
            this.Lbl_RestaurantPostalCode.Size = new System.Drawing.Size(111, 20);
            this.Lbl_RestaurantPostalCode.TabIndex = 6;
            this.Lbl_RestaurantPostalCode.Text = "Código Postal:";
            // 
            // TxtBox_RestaurantCity
            // 
            this.TxtBox_RestaurantCity.BackColor = System.Drawing.Color.White;
            this.TxtBox_RestaurantCity.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(52)))), ((int)(((byte)(22)))));
            this.TxtBox_RestaurantCity.Location = new System.Drawing.Point(93, 81);
            this.TxtBox_RestaurantCity.Margin = new System.Windows.Forms.Padding(0);
            this.TxtBox_RestaurantCity.Name = "TxtBox_RestaurantCity";
            this.TxtBox_RestaurantCity.Size = new System.Drawing.Size(273, 26);
            this.TxtBox_RestaurantCity.TabIndex = 5;
            // 
            // Lbl_RestaurantCity
            // 
            this.Lbl_RestaurantCity.AutoSize = true;
            this.Lbl_RestaurantCity.Location = new System.Drawing.Point(20, 84);
            this.Lbl_RestaurantCity.Margin = new System.Windows.Forms.Padding(0);
            this.Lbl_RestaurantCity.Name = "Lbl_RestaurantCity";
            this.Lbl_RestaurantCity.Size = new System.Drawing.Size(63, 20);
            this.Lbl_RestaurantCity.TabIndex = 4;
            this.Lbl_RestaurantCity.Text = "Cidade:";
            // 
            // TxtBox_RestaurantStreet
            // 
            this.TxtBox_RestaurantStreet.BackColor = System.Drawing.Color.White;
            this.TxtBox_RestaurantStreet.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(52)))), ((int)(((byte)(22)))));
            this.TxtBox_RestaurantStreet.Location = new System.Drawing.Point(73, 35);
            this.TxtBox_RestaurantStreet.Margin = new System.Windows.Forms.Padding(0);
            this.TxtBox_RestaurantStreet.Name = "TxtBox_RestaurantStreet";
            this.TxtBox_RestaurantStreet.Size = new System.Drawing.Size(293, 26);
            this.TxtBox_RestaurantStreet.TabIndex = 3;
            // 
            // Lbl_RestaurantStreet
            // 
            this.Lbl_RestaurantStreet.AutoSize = true;
            this.Lbl_RestaurantStreet.Location = new System.Drawing.Point(20, 38);
            this.Lbl_RestaurantStreet.Margin = new System.Windows.Forms.Padding(0);
            this.Lbl_RestaurantStreet.Name = "Lbl_RestaurantStreet";
            this.Lbl_RestaurantStreet.Size = new System.Drawing.Size(43, 20);
            this.Lbl_RestaurantStreet.TabIndex = 2;
            this.Lbl_RestaurantStreet.Text = "Rua:";
            // 
            // Btn_Conclude
            // 
            this.Btn_Conclude.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Btn_Conclude.AutoSize = true;
            this.Btn_Conclude.BackColor = System.Drawing.Color.White;
            this.Btn_Conclude.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.Btn_Conclude.Location = new System.Drawing.Point(264, 594);
            this.Btn_Conclude.Margin = new System.Windows.Forms.Padding(0);
            this.Btn_Conclude.Name = "Btn_Conclude";
            this.Btn_Conclude.Size = new System.Drawing.Size(110, 51);
            this.Btn_Conclude.TabIndex = 5;
            this.Btn_Conclude.Text = "Concluir";
            this.Btn_Conclude.UseVisualStyleBackColor = false;
            // 
            // AddEditRestaurant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.ClientSize = new System.Drawing.Size(637, 768);
            this.Controls.Add(this.Btn_Conclude);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Lbl_RestaurantAddress);
            this.Controls.Add(this.TxtBox_RestaurantName);
            this.Controls.Add(this.Lbl_RestaurantName);
            this.Controls.Add(this.Lbl_Title);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(52)))), ((int)(((byte)(22)))));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "AddEditRestaurant";
            this.Padding = new System.Windows.Forms.Padding(0, 123, 0, 0);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Novo Restaurante";
            this.Load += new System.EventHandler(this.AddEditRestaurant_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Lbl_Title;
        private System.Windows.Forms.Label Lbl_RestaurantName;
        private System.Windows.Forms.TextBox TxtBox_RestaurantName;
        private System.Windows.Forms.Label Lbl_RestaurantAddress;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label Lbl_RestaurantPostalCode;
        private System.Windows.Forms.TextBox TxtBox_RestaurantCity;
        private System.Windows.Forms.Label Lbl_RestaurantCity;
        private System.Windows.Forms.TextBox TxtBox_RestaurantStreet;
        private System.Windows.Forms.Label Lbl_RestaurantStreet;
        private System.Windows.Forms.TextBox TxtBox_RestaurantCountry;
        private System.Windows.Forms.Label Lbl_RestaurantCountry;
        private System.Windows.Forms.MaskedTextBox MaskedTxtBox_RestaurantPostalCode;
        private System.Windows.Forms.Button Btn_Conclude;
    }
}