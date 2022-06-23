namespace app
{
    partial class Clients
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
            this.Btn_RemoveClient = new System.Windows.Forms.Button();
            this.DataGridView_Clients = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BindingSource_AllClients = new System.Windows.Forms.BindingSource(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.Btn_AddClient = new System.Windows.Forms.Button();
            this.MaskedTxtBox_NewClientPostalCode = new System.Windows.Forms.MaskedTextBox();
            this.Lbl_NewClientPostalCode = new System.Windows.Forms.Label();
            this.TxtBox_NewClientCity = new System.Windows.Forms.TextBox();
            this.Lbl_NewClientCity = new System.Windows.Forms.Label();
            this.TxtBox_NewClientStreet = new System.Windows.Forms.TextBox();
            this.Lbl_NewClientStreet = new System.Windows.Forms.Label();
            this.TxtBox_NewClientCountry = new System.Windows.Forms.TextBox();
            this.Lbl_NewClientCountry = new System.Windows.Forms.Label();
            this.MaskedTxtBox_NewClientNIF = new System.Windows.Forms.MaskedTextBox();
            this.Lbl_NewClientNIF = new System.Windows.Forms.Label();
            this.MaskedTxtBox_NewClientPhone = new System.Windows.Forms.MaskedTextBox();
            this.Lbl_NewClientPhone = new System.Windows.Forms.Label();
            this.TxtBox_NewClientName = new System.Windows.Forms.TextBox();
            this.Lbl_NewClientName = new System.Windows.Forms.Label();
            this.Lbl_AddClient = new System.Windows.Forms.Label();
            this.Lbl_Clients = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Btn_SaveChangesOnClient = new System.Windows.Forms.Button();
            this.MaskedTxtBox_ClientPostalCode = new System.Windows.Forms.MaskedTextBox();
            this.Lbl_ClientPostalCode = new System.Windows.Forms.Label();
            this.TxtBox_ClientCity = new System.Windows.Forms.TextBox();
            this.Lbl_ClientCity = new System.Windows.Forms.Label();
            this.TxtBox_ClientStreet = new System.Windows.Forms.TextBox();
            this.Lbl_ClientStreet = new System.Windows.Forms.Label();
            this.TxtBox_ClientCountry = new System.Windows.Forms.TextBox();
            this.Lbl_ClientCountry = new System.Windows.Forms.Label();
            this.MaskedTxtBox_ClientNIF = new System.Windows.Forms.MaskedTextBox();
            this.Lbl_ClientNIF = new System.Windows.Forms.Label();
            this.MaskedTxtBox_ClientPhone = new System.Windows.Forms.MaskedTextBox();
            this.Lbl_ClientPhone = new System.Windows.Forms.Label();
            this.TxtBox_ClientName = new System.Windows.Forms.TextBox();
            this.Lbl_ClientName = new System.Windows.Forms.Label();
            this.Lbl_EditClient = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView_Clients)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BindingSource_AllClients)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // Btn_RemoveClient
            // 
            this.Btn_RemoveClient.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Btn_RemoveClient.AutoSize = true;
            this.Btn_RemoveClient.BackColor = System.Drawing.Color.White;
            this.Btn_RemoveClient.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_RemoveClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_RemoveClient.Location = new System.Drawing.Point(701, 774);
            this.Btn_RemoveClient.Margin = new System.Windows.Forms.Padding(0);
            this.Btn_RemoveClient.Name = "Btn_RemoveClient";
            this.Btn_RemoveClient.Size = new System.Drawing.Size(175, 51);
            this.Btn_RemoveClient.TabIndex = 31;
            this.Btn_RemoveClient.Text = "Remover Cliente";
            this.Btn_RemoveClient.UseVisualStyleBackColor = false;
            // 
            // DataGridView_Clients
            // 
            this.DataGridView_Clients.AllowUserToAddRows = false;
            this.DataGridView_Clients.AllowUserToDeleteRows = false;
            this.DataGridView_Clients.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.DataGridView_Clients.AutoGenerateColumns = false;
            this.DataGridView_Clients.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.DataGridView_Clients.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(52)))), ((int)(((byte)(22)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridView_Clients.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.DataGridView_Clients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridView_Clients.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column5,
            this.Column4,
            this.Column2,
            this.Column3});
            this.DataGridView_Clients.DataSource = this.BindingSource_AllClients;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(52)))), ((int)(((byte)(22)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DataGridView_Clients.DefaultCellStyle = dataGridViewCellStyle4;
            this.DataGridView_Clients.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.DataGridView_Clients.Location = new System.Drawing.Point(701, 217);
            this.DataGridView_Clients.Margin = new System.Windows.Forms.Padding(0);
            this.DataGridView_Clients.MultiSelect = false;
            this.DataGridView_Clients.Name = "DataGridView_Clients";
            this.DataGridView_Clients.ReadOnly = true;
            this.DataGridView_Clients.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGridView_Clients.Size = new System.Drawing.Size(622, 475);
            this.DataGridView_Clients.TabIndex = 30;
            this.DataGridView_Clients.SelectionChanged += new System.EventHandler(this.DataGridView_Clients_SelectionChanged);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "Nome";
            this.Column1.HeaderText = "Nome";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "NumContribuinte";
            this.Column5.HeaderText = "Num. Contribuinte";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 200;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "Telemovel";
            this.Column4.HeaderText = "Telemovel";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "Morada";
            this.Column2.HeaderText = "Morada";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "PaisExtracted";
            this.Column3.HeaderText = "Pais";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.panel1.Controls.Add(this.Btn_AddClient);
            this.panel1.Controls.Add(this.MaskedTxtBox_NewClientPostalCode);
            this.panel1.Controls.Add(this.Lbl_NewClientPostalCode);
            this.panel1.Controls.Add(this.TxtBox_NewClientCity);
            this.panel1.Controls.Add(this.Lbl_NewClientCity);
            this.panel1.Controls.Add(this.TxtBox_NewClientStreet);
            this.panel1.Controls.Add(this.Lbl_NewClientStreet);
            this.panel1.Controls.Add(this.TxtBox_NewClientCountry);
            this.panel1.Controls.Add(this.Lbl_NewClientCountry);
            this.panel1.Controls.Add(this.MaskedTxtBox_NewClientNIF);
            this.panel1.Controls.Add(this.Lbl_NewClientNIF);
            this.panel1.Controls.Add(this.MaskedTxtBox_NewClientPhone);
            this.panel1.Controls.Add(this.Lbl_NewClientPhone);
            this.panel1.Controls.Add(this.TxtBox_NewClientName);
            this.panel1.Controls.Add(this.Lbl_NewClientName);
            this.panel1.Location = new System.Drawing.Point(128, 233);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(520, 278);
            this.panel1.TabIndex = 27;
            // 
            // Btn_AddClient
            // 
            this.Btn_AddClient.AutoSize = true;
            this.Btn_AddClient.BackColor = System.Drawing.Color.White;
            this.Btn_AddClient.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_AddClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_AddClient.Location = new System.Drawing.Point(24, 201);
            this.Btn_AddClient.Margin = new System.Windows.Forms.Padding(0);
            this.Btn_AddClient.Name = "Btn_AddClient";
            this.Btn_AddClient.Size = new System.Drawing.Size(476, 40);
            this.Btn_AddClient.TabIndex = 11;
            this.Btn_AddClient.Text = "Adicionar";
            this.Btn_AddClient.UseVisualStyleBackColor = false;
            this.Btn_AddClient.Click += new System.EventHandler(this.Btn_AddClient_Click);
            // 
            // MaskedTxtBox_NewClientPostalCode
            // 
            this.MaskedTxtBox_NewClientPostalCode.BackColor = System.Drawing.Color.White;
            this.MaskedTxtBox_NewClientPostalCode.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(52)))), ((int)(((byte)(22)))));
            this.MaskedTxtBox_NewClientPostalCode.Location = new System.Drawing.Point(383, 160);
            this.MaskedTxtBox_NewClientPostalCode.Margin = new System.Windows.Forms.Padding(0);
            this.MaskedTxtBox_NewClientPostalCode.Mask = "0000 - 000";
            this.MaskedTxtBox_NewClientPostalCode.Name = "MaskedTxtBox_NewClientPostalCode";
            this.MaskedTxtBox_NewClientPostalCode.Size = new System.Drawing.Size(117, 26);
            this.MaskedTxtBox_NewClientPostalCode.TabIndex = 23;
            this.MaskedTxtBox_NewClientPostalCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Lbl_NewClientPostalCode
            // 
            this.Lbl_NewClientPostalCode.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Lbl_NewClientPostalCode.AutoSize = true;
            this.Lbl_NewClientPostalCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_NewClientPostalCode.Location = new System.Drawing.Point(284, 163);
            this.Lbl_NewClientPostalCode.Margin = new System.Windows.Forms.Padding(0);
            this.Lbl_NewClientPostalCode.Name = "Lbl_NewClientPostalCode";
            this.Lbl_NewClientPostalCode.Size = new System.Drawing.Size(94, 20);
            this.Lbl_NewClientPostalCode.TabIndex = 22;
            this.Lbl_NewClientPostalCode.Text = "Cód. Postal:";
            // 
            // TxtBox_NewClientCity
            // 
            this.TxtBox_NewClientCity.BackColor = System.Drawing.Color.White;
            this.TxtBox_NewClientCity.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(52)))), ((int)(((byte)(22)))));
            this.TxtBox_NewClientCity.Location = new System.Drawing.Point(88, 160);
            this.TxtBox_NewClientCity.Margin = new System.Windows.Forms.Padding(0);
            this.TxtBox_NewClientCity.Name = "TxtBox_NewClientCity";
            this.TxtBox_NewClientCity.Size = new System.Drawing.Size(121, 26);
            this.TxtBox_NewClientCity.TabIndex = 21;
            // 
            // Lbl_NewClientCity
            // 
            this.Lbl_NewClientCity.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Lbl_NewClientCity.AutoSize = true;
            this.Lbl_NewClientCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_NewClientCity.Location = new System.Drawing.Point(20, 163);
            this.Lbl_NewClientCity.Margin = new System.Windows.Forms.Padding(0);
            this.Lbl_NewClientCity.Name = "Lbl_NewClientCity";
            this.Lbl_NewClientCity.Size = new System.Drawing.Size(63, 20);
            this.Lbl_NewClientCity.TabIndex = 20;
            this.Lbl_NewClientCity.Text = "Cidade:";
            // 
            // TxtBox_NewClientStreet
            // 
            this.TxtBox_NewClientStreet.BackColor = System.Drawing.Color.White;
            this.TxtBox_NewClientStreet.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(52)))), ((int)(((byte)(22)))));
            this.TxtBox_NewClientStreet.Location = new System.Drawing.Point(68, 119);
            this.TxtBox_NewClientStreet.Margin = new System.Windows.Forms.Padding(0);
            this.TxtBox_NewClientStreet.Name = "TxtBox_NewClientStreet";
            this.TxtBox_NewClientStreet.Size = new System.Drawing.Size(432, 26);
            this.TxtBox_NewClientStreet.TabIndex = 19;
            // 
            // Lbl_NewClientStreet
            // 
            this.Lbl_NewClientStreet.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Lbl_NewClientStreet.AutoSize = true;
            this.Lbl_NewClientStreet.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_NewClientStreet.Location = new System.Drawing.Point(20, 122);
            this.Lbl_NewClientStreet.Margin = new System.Windows.Forms.Padding(0);
            this.Lbl_NewClientStreet.Name = "Lbl_NewClientStreet";
            this.Lbl_NewClientStreet.Size = new System.Drawing.Size(43, 20);
            this.Lbl_NewClientStreet.TabIndex = 18;
            this.Lbl_NewClientStreet.Text = "Rua:";
            // 
            // TxtBox_NewClientCountry
            // 
            this.TxtBox_NewClientCountry.BackColor = System.Drawing.Color.White;
            this.TxtBox_NewClientCountry.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(52)))), ((int)(((byte)(22)))));
            this.TxtBox_NewClientCountry.Location = new System.Drawing.Point(383, 78);
            this.TxtBox_NewClientCountry.Margin = new System.Windows.Forms.Padding(0);
            this.TxtBox_NewClientCountry.Name = "TxtBox_NewClientCountry";
            this.TxtBox_NewClientCountry.Size = new System.Drawing.Size(117, 26);
            this.TxtBox_NewClientCountry.TabIndex = 17;
            // 
            // Lbl_NewClientCountry
            // 
            this.Lbl_NewClientCountry.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Lbl_NewClientCountry.AutoSize = true;
            this.Lbl_NewClientCountry.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_NewClientCountry.Location = new System.Drawing.Point(335, 81);
            this.Lbl_NewClientCountry.Margin = new System.Windows.Forms.Padding(0);
            this.Lbl_NewClientCountry.Name = "Lbl_NewClientCountry";
            this.Lbl_NewClientCountry.Size = new System.Drawing.Size(43, 20);
            this.Lbl_NewClientCountry.TabIndex = 15;
            this.Lbl_NewClientCountry.Text = "Pais:";
            // 
            // MaskedTxtBox_NewClientNIF
            // 
            this.MaskedTxtBox_NewClientNIF.BackColor = System.Drawing.Color.White;
            this.MaskedTxtBox_NewClientNIF.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(52)))), ((int)(((byte)(22)))));
            this.MaskedTxtBox_NewClientNIF.Location = new System.Drawing.Point(175, 78);
            this.MaskedTxtBox_NewClientNIF.Margin = new System.Windows.Forms.Padding(0);
            this.MaskedTxtBox_NewClientNIF.Mask = "000000000";
            this.MaskedTxtBox_NewClientNIF.Name = "MaskedTxtBox_NewClientNIF";
            this.MaskedTxtBox_NewClientNIF.Size = new System.Drawing.Size(119, 26);
            this.MaskedTxtBox_NewClientNIF.TabIndex = 11;
            this.MaskedTxtBox_NewClientNIF.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Lbl_NewClientNIF
            // 
            this.Lbl_NewClientNIF.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Lbl_NewClientNIF.AutoSize = true;
            this.Lbl_NewClientNIF.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_NewClientNIF.Location = new System.Drawing.Point(20, 81);
            this.Lbl_NewClientNIF.Margin = new System.Windows.Forms.Padding(0);
            this.Lbl_NewClientNIF.Name = "Lbl_NewClientNIF";
            this.Lbl_NewClientNIF.Size = new System.Drawing.Size(140, 20);
            this.Lbl_NewClientNIF.TabIndex = 14;
            this.Lbl_NewClientNIF.Text = "Num. Contribuinte:";
            // 
            // MaskedTxtBox_NewClientPhone
            // 
            this.MaskedTxtBox_NewClientPhone.BackColor = System.Drawing.Color.White;
            this.MaskedTxtBox_NewClientPhone.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(52)))), ((int)(((byte)(22)))));
            this.MaskedTxtBox_NewClientPhone.Location = new System.Drawing.Point(383, 37);
            this.MaskedTxtBox_NewClientPhone.Margin = new System.Windows.Forms.Padding(0);
            this.MaskedTxtBox_NewClientPhone.Mask = "000 - 000 - 000";
            this.MaskedTxtBox_NewClientPhone.Name = "MaskedTxtBox_NewClientPhone";
            this.MaskedTxtBox_NewClientPhone.Size = new System.Drawing.Size(117, 26);
            this.MaskedTxtBox_NewClientPhone.TabIndex = 13;
            this.MaskedTxtBox_NewClientPhone.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Lbl_NewClientPhone
            // 
            this.Lbl_NewClientPhone.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Lbl_NewClientPhone.AutoSize = true;
            this.Lbl_NewClientPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_NewClientPhone.Location = new System.Drawing.Point(294, 40);
            this.Lbl_NewClientPhone.Margin = new System.Windows.Forms.Padding(0);
            this.Lbl_NewClientPhone.Name = "Lbl_NewClientPhone";
            this.Lbl_NewClientPhone.Size = new System.Drawing.Size(84, 20);
            this.Lbl_NewClientPhone.TabIndex = 12;
            this.Lbl_NewClientPhone.Text = "Telemóvel:";
            // 
            // TxtBox_NewClientName
            // 
            this.TxtBox_NewClientName.BackColor = System.Drawing.Color.White;
            this.TxtBox_NewClientName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(52)))), ((int)(((byte)(22)))));
            this.TxtBox_NewClientName.Location = new System.Drawing.Point(80, 37);
            this.TxtBox_NewClientName.Margin = new System.Windows.Forms.Padding(0);
            this.TxtBox_NewClientName.Name = "TxtBox_NewClientName";
            this.TxtBox_NewClientName.Size = new System.Drawing.Size(183, 26);
            this.TxtBox_NewClientName.TabIndex = 11;
            // 
            // Lbl_NewClientName
            // 
            this.Lbl_NewClientName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Lbl_NewClientName.AutoSize = true;
            this.Lbl_NewClientName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_NewClientName.Location = new System.Drawing.Point(20, 40);
            this.Lbl_NewClientName.Margin = new System.Windows.Forms.Padding(0);
            this.Lbl_NewClientName.Name = "Lbl_NewClientName";
            this.Lbl_NewClientName.Size = new System.Drawing.Size(55, 20);
            this.Lbl_NewClientName.TabIndex = 11;
            this.Lbl_NewClientName.Text = "Nome:";
            // 
            // Lbl_AddClient
            // 
            this.Lbl_AddClient.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Lbl_AddClient.AutoSize = true;
            this.Lbl_AddClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_AddClient.Location = new System.Drawing.Point(160, 217);
            this.Lbl_AddClient.Margin = new System.Windows.Forms.Padding(0);
            this.Lbl_AddClient.Name = "Lbl_AddClient";
            this.Lbl_AddClient.Size = new System.Drawing.Size(196, 29);
            this.Lbl_AddClient.TabIndex = 26;
            this.Lbl_AddClient.Text = "Adicionar Cliente";
            // 
            // Lbl_Clients
            // 
            this.Lbl_Clients.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Lbl_Clients.AutoSize = true;
            this.Lbl_Clients.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Clients.Location = new System.Drawing.Point(121, 108);
            this.Lbl_Clients.Margin = new System.Windows.Forms.Padding(0);
            this.Lbl_Clients.Name = "Lbl_Clients";
            this.Lbl_Clients.Size = new System.Drawing.Size(131, 37);
            this.Lbl_Clients.TabIndex = 17;
            this.Lbl_Clients.Text = "Clientes";
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.panel2.Controls.Add(this.Btn_SaveChangesOnClient);
            this.panel2.Controls.Add(this.MaskedTxtBox_ClientPostalCode);
            this.panel2.Controls.Add(this.Lbl_ClientPostalCode);
            this.panel2.Controls.Add(this.TxtBox_ClientCity);
            this.panel2.Controls.Add(this.Lbl_ClientCity);
            this.panel2.Controls.Add(this.TxtBox_ClientStreet);
            this.panel2.Controls.Add(this.Lbl_ClientStreet);
            this.panel2.Controls.Add(this.TxtBox_ClientCountry);
            this.panel2.Controls.Add(this.Lbl_ClientCountry);
            this.panel2.Controls.Add(this.MaskedTxtBox_ClientNIF);
            this.panel2.Controls.Add(this.Lbl_ClientNIF);
            this.panel2.Controls.Add(this.MaskedTxtBox_ClientPhone);
            this.panel2.Controls.Add(this.Lbl_ClientPhone);
            this.panel2.Controls.Add(this.TxtBox_ClientName);
            this.panel2.Controls.Add(this.Lbl_ClientName);
            this.panel2.Location = new System.Drawing.Point(128, 547);
            this.panel2.Margin = new System.Windows.Forms.Padding(0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(520, 278);
            this.panel2.TabIndex = 35;
            // 
            // Btn_SaveChangesOnClient
            // 
            this.Btn_SaveChangesOnClient.AutoSize = true;
            this.Btn_SaveChangesOnClient.BackColor = System.Drawing.Color.White;
            this.Btn_SaveChangesOnClient.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_SaveChangesOnClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_SaveChangesOnClient.Location = new System.Drawing.Point(24, 201);
            this.Btn_SaveChangesOnClient.Margin = new System.Windows.Forms.Padding(0);
            this.Btn_SaveChangesOnClient.Name = "Btn_SaveChangesOnClient";
            this.Btn_SaveChangesOnClient.Size = new System.Drawing.Size(476, 40);
            this.Btn_SaveChangesOnClient.TabIndex = 11;
            this.Btn_SaveChangesOnClient.Text = "Guardar";
            this.Btn_SaveChangesOnClient.UseVisualStyleBackColor = false;
            this.Btn_SaveChangesOnClient.Click += new System.EventHandler(this.Btn_SaveChangesOnClient_Click);
            // 
            // MaskedTxtBox_ClientPostalCode
            // 
            this.MaskedTxtBox_ClientPostalCode.BackColor = System.Drawing.Color.White;
            this.MaskedTxtBox_ClientPostalCode.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(52)))), ((int)(((byte)(22)))));
            this.MaskedTxtBox_ClientPostalCode.Location = new System.Drawing.Point(383, 160);
            this.MaskedTxtBox_ClientPostalCode.Margin = new System.Windows.Forms.Padding(0);
            this.MaskedTxtBox_ClientPostalCode.Mask = "0000 - 000";
            this.MaskedTxtBox_ClientPostalCode.Name = "MaskedTxtBox_ClientPostalCode";
            this.MaskedTxtBox_ClientPostalCode.Size = new System.Drawing.Size(117, 26);
            this.MaskedTxtBox_ClientPostalCode.TabIndex = 23;
            this.MaskedTxtBox_ClientPostalCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Lbl_ClientPostalCode
            // 
            this.Lbl_ClientPostalCode.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Lbl_ClientPostalCode.AutoSize = true;
            this.Lbl_ClientPostalCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_ClientPostalCode.Location = new System.Drawing.Point(284, 163);
            this.Lbl_ClientPostalCode.Margin = new System.Windows.Forms.Padding(0);
            this.Lbl_ClientPostalCode.Name = "Lbl_ClientPostalCode";
            this.Lbl_ClientPostalCode.Size = new System.Drawing.Size(94, 20);
            this.Lbl_ClientPostalCode.TabIndex = 22;
            this.Lbl_ClientPostalCode.Text = "Cód. Postal:";
            // 
            // TxtBox_ClientCity
            // 
            this.TxtBox_ClientCity.BackColor = System.Drawing.Color.White;
            this.TxtBox_ClientCity.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(52)))), ((int)(((byte)(22)))));
            this.TxtBox_ClientCity.Location = new System.Drawing.Point(88, 160);
            this.TxtBox_ClientCity.Margin = new System.Windows.Forms.Padding(0);
            this.TxtBox_ClientCity.Name = "TxtBox_ClientCity";
            this.TxtBox_ClientCity.Size = new System.Drawing.Size(121, 26);
            this.TxtBox_ClientCity.TabIndex = 21;
            // 
            // Lbl_ClientCity
            // 
            this.Lbl_ClientCity.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Lbl_ClientCity.AutoSize = true;
            this.Lbl_ClientCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_ClientCity.Location = new System.Drawing.Point(20, 163);
            this.Lbl_ClientCity.Margin = new System.Windows.Forms.Padding(0);
            this.Lbl_ClientCity.Name = "Lbl_ClientCity";
            this.Lbl_ClientCity.Size = new System.Drawing.Size(63, 20);
            this.Lbl_ClientCity.TabIndex = 20;
            this.Lbl_ClientCity.Text = "Cidade:";
            // 
            // TxtBox_ClientStreet
            // 
            this.TxtBox_ClientStreet.BackColor = System.Drawing.Color.White;
            this.TxtBox_ClientStreet.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(52)))), ((int)(((byte)(22)))));
            this.TxtBox_ClientStreet.Location = new System.Drawing.Point(68, 119);
            this.TxtBox_ClientStreet.Margin = new System.Windows.Forms.Padding(0);
            this.TxtBox_ClientStreet.Name = "TxtBox_ClientStreet";
            this.TxtBox_ClientStreet.Size = new System.Drawing.Size(432, 26);
            this.TxtBox_ClientStreet.TabIndex = 19;
            // 
            // Lbl_ClientStreet
            // 
            this.Lbl_ClientStreet.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Lbl_ClientStreet.AutoSize = true;
            this.Lbl_ClientStreet.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_ClientStreet.Location = new System.Drawing.Point(20, 122);
            this.Lbl_ClientStreet.Margin = new System.Windows.Forms.Padding(0);
            this.Lbl_ClientStreet.Name = "Lbl_ClientStreet";
            this.Lbl_ClientStreet.Size = new System.Drawing.Size(43, 20);
            this.Lbl_ClientStreet.TabIndex = 18;
            this.Lbl_ClientStreet.Text = "Rua:";
            // 
            // TxtBox_ClientCountry
            // 
            this.TxtBox_ClientCountry.BackColor = System.Drawing.Color.White;
            this.TxtBox_ClientCountry.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(52)))), ((int)(((byte)(22)))));
            this.TxtBox_ClientCountry.Location = new System.Drawing.Point(383, 78);
            this.TxtBox_ClientCountry.Margin = new System.Windows.Forms.Padding(0);
            this.TxtBox_ClientCountry.Name = "TxtBox_ClientCountry";
            this.TxtBox_ClientCountry.Size = new System.Drawing.Size(117, 26);
            this.TxtBox_ClientCountry.TabIndex = 17;
            // 
            // Lbl_ClientCountry
            // 
            this.Lbl_ClientCountry.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Lbl_ClientCountry.AutoSize = true;
            this.Lbl_ClientCountry.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_ClientCountry.Location = new System.Drawing.Point(335, 81);
            this.Lbl_ClientCountry.Margin = new System.Windows.Forms.Padding(0);
            this.Lbl_ClientCountry.Name = "Lbl_ClientCountry";
            this.Lbl_ClientCountry.Size = new System.Drawing.Size(43, 20);
            this.Lbl_ClientCountry.TabIndex = 15;
            this.Lbl_ClientCountry.Text = "Pais:";
            // 
            // MaskedTxtBox_ClientNIF
            // 
            this.MaskedTxtBox_ClientNIF.BackColor = System.Drawing.Color.White;
            this.MaskedTxtBox_ClientNIF.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(52)))), ((int)(((byte)(22)))));
            this.MaskedTxtBox_ClientNIF.Location = new System.Drawing.Point(175, 78);
            this.MaskedTxtBox_ClientNIF.Margin = new System.Windows.Forms.Padding(0);
            this.MaskedTxtBox_ClientNIF.Mask = "000000000";
            this.MaskedTxtBox_ClientNIF.Name = "MaskedTxtBox_ClientNIF";
            this.MaskedTxtBox_ClientNIF.Size = new System.Drawing.Size(119, 26);
            this.MaskedTxtBox_ClientNIF.TabIndex = 11;
            this.MaskedTxtBox_ClientNIF.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Lbl_ClientNIF
            // 
            this.Lbl_ClientNIF.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Lbl_ClientNIF.AutoSize = true;
            this.Lbl_ClientNIF.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_ClientNIF.Location = new System.Drawing.Point(20, 81);
            this.Lbl_ClientNIF.Margin = new System.Windows.Forms.Padding(0);
            this.Lbl_ClientNIF.Name = "Lbl_ClientNIF";
            this.Lbl_ClientNIF.Size = new System.Drawing.Size(140, 20);
            this.Lbl_ClientNIF.TabIndex = 14;
            this.Lbl_ClientNIF.Text = "Num. Contribuinte:";
            // 
            // MaskedTxtBox_ClientPhone
            // 
            this.MaskedTxtBox_ClientPhone.BackColor = System.Drawing.Color.White;
            this.MaskedTxtBox_ClientPhone.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(52)))), ((int)(((byte)(22)))));
            this.MaskedTxtBox_ClientPhone.Location = new System.Drawing.Point(383, 37);
            this.MaskedTxtBox_ClientPhone.Margin = new System.Windows.Forms.Padding(0);
            this.MaskedTxtBox_ClientPhone.Mask = "000 - 000 - 000";
            this.MaskedTxtBox_ClientPhone.Name = "MaskedTxtBox_ClientPhone";
            this.MaskedTxtBox_ClientPhone.Size = new System.Drawing.Size(117, 26);
            this.MaskedTxtBox_ClientPhone.TabIndex = 13;
            this.MaskedTxtBox_ClientPhone.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Lbl_ClientPhone
            // 
            this.Lbl_ClientPhone.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Lbl_ClientPhone.AutoSize = true;
            this.Lbl_ClientPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_ClientPhone.Location = new System.Drawing.Point(294, 40);
            this.Lbl_ClientPhone.Margin = new System.Windows.Forms.Padding(0);
            this.Lbl_ClientPhone.Name = "Lbl_ClientPhone";
            this.Lbl_ClientPhone.Size = new System.Drawing.Size(84, 20);
            this.Lbl_ClientPhone.TabIndex = 12;
            this.Lbl_ClientPhone.Text = "Telemóvel:";
            // 
            // TxtBox_ClientName
            // 
            this.TxtBox_ClientName.BackColor = System.Drawing.Color.White;
            this.TxtBox_ClientName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(52)))), ((int)(((byte)(22)))));
            this.TxtBox_ClientName.Location = new System.Drawing.Point(80, 37);
            this.TxtBox_ClientName.Margin = new System.Windows.Forms.Padding(0);
            this.TxtBox_ClientName.Name = "TxtBox_ClientName";
            this.TxtBox_ClientName.Size = new System.Drawing.Size(183, 26);
            this.TxtBox_ClientName.TabIndex = 11;
            // 
            // Lbl_ClientName
            // 
            this.Lbl_ClientName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Lbl_ClientName.AutoSize = true;
            this.Lbl_ClientName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_ClientName.Location = new System.Drawing.Point(20, 40);
            this.Lbl_ClientName.Margin = new System.Windows.Forms.Padding(0);
            this.Lbl_ClientName.Name = "Lbl_ClientName";
            this.Lbl_ClientName.Size = new System.Drawing.Size(55, 20);
            this.Lbl_ClientName.TabIndex = 11;
            this.Lbl_ClientName.Text = "Nome:";
            // 
            // Lbl_EditClient
            // 
            this.Lbl_EditClient.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Lbl_EditClient.AutoSize = true;
            this.Lbl_EditClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_EditClient.Location = new System.Drawing.Point(160, 531);
            this.Lbl_EditClient.Margin = new System.Windows.Forms.Padding(0);
            this.Lbl_EditClient.Name = "Lbl_EditClient";
            this.Lbl_EditClient.Size = new System.Drawing.Size(158, 29);
            this.Lbl_EditClient.TabIndex = 34;
            this.Lbl_EditClient.Text = "Editar Cliente";
            // 
            // Clients
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.ClientSize = new System.Drawing.Size(1424, 985);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.Lbl_EditClient);
            this.Controls.Add(this.Btn_RemoveClient);
            this.Controls.Add(this.DataGridView_Clients);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Lbl_AddClient);
            this.Controls.Add(this.Lbl_Clients);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(52)))), ((int)(((byte)(22)))));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Clients";
            this.Text = "Clientes";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Clients_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView_Clients)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BindingSource_AllClients)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Btn_RemoveClient;
        private System.Windows.Forms.DataGridView DataGridView_Clients;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Btn_AddClient;
        private System.Windows.Forms.MaskedTextBox MaskedTxtBox_NewClientPostalCode;
        private System.Windows.Forms.Label Lbl_NewClientPostalCode;
        private System.Windows.Forms.TextBox TxtBox_NewClientCity;
        private System.Windows.Forms.Label Lbl_NewClientCity;
        private System.Windows.Forms.TextBox TxtBox_NewClientStreet;
        private System.Windows.Forms.Label Lbl_NewClientStreet;
        private System.Windows.Forms.TextBox TxtBox_NewClientCountry;
        private System.Windows.Forms.Label Lbl_NewClientCountry;
        private System.Windows.Forms.MaskedTextBox MaskedTxtBox_NewClientNIF;
        private System.Windows.Forms.Label Lbl_NewClientNIF;
        private System.Windows.Forms.MaskedTextBox MaskedTxtBox_NewClientPhone;
        private System.Windows.Forms.Label Lbl_NewClientPhone;
        private System.Windows.Forms.TextBox TxtBox_NewClientName;
        private System.Windows.Forms.Label Lbl_NewClientName;
        private System.Windows.Forms.Label Lbl_AddClient;
        private System.Windows.Forms.Label Lbl_Clients;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button Btn_SaveChangesOnClient;
        private System.Windows.Forms.MaskedTextBox MaskedTxtBox_ClientPostalCode;
        private System.Windows.Forms.Label Lbl_ClientPostalCode;
        private System.Windows.Forms.TextBox TxtBox_ClientCity;
        private System.Windows.Forms.Label Lbl_ClientCity;
        private System.Windows.Forms.TextBox TxtBox_ClientStreet;
        private System.Windows.Forms.Label Lbl_ClientStreet;
        private System.Windows.Forms.TextBox TxtBox_ClientCountry;
        private System.Windows.Forms.Label Lbl_ClientCountry;
        private System.Windows.Forms.MaskedTextBox MaskedTxtBox_ClientNIF;
        private System.Windows.Forms.Label Lbl_ClientNIF;
        private System.Windows.Forms.MaskedTextBox MaskedTxtBox_ClientPhone;
        private System.Windows.Forms.Label Lbl_ClientPhone;
        private System.Windows.Forms.TextBox TxtBox_ClientName;
        private System.Windows.Forms.Label Lbl_ClientName;
        private System.Windows.Forms.Label Lbl_EditClient;
        private System.Windows.Forms.BindingSource BindingSource_AllClients;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
    }
}