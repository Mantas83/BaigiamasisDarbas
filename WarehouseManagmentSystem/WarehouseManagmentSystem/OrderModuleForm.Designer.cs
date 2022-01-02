
namespace WarehouseManagmentSystem
{
    partial class OrderModuleForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OrderModuleForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.CustomerNameTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.CustomerIDTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SearchCustomerTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.DataGridCustomer = new System.Windows.Forms.DataGridView();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel3 = new System.Windows.Forms.Panel();
            this.QuantityNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.ClearButton = new System.Windows.Forms.Button();
            this.InsertButton = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.OrderDatePicker = new System.Windows.Forms.DateTimePicker();
            this.ProductNameTextBox = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.TotalTextBox = new System.Windows.Forms.TextBox();
            this.PriceTextBox = new System.Windows.Forms.TextBox();
            this.ProductIDTextBox = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SearchProductTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.DataGridProduct = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OrderIDLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridCustomer)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.QuantityNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridProduct)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SeaGreen;
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(962, 48);
            this.panel1.TabIndex = 1;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(944, 3);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(15, 15);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 12;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(8, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Užsakymo modulis";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.OrderIDLabel);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.CustomerNameTextBox);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.CustomerIDTextBox);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.SearchCustomerTextBox);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.DataGridCustomer);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 48);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(289, 529);
            this.panel2.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(43, 363);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(165, 17);
            this.label7.TabIndex = 12;
            this.label7.Text = "Užsakovo Pavadinimas :";
            // 
            // CustomerNameTextBox
            // 
            this.CustomerNameTextBox.Enabled = false;
            this.CustomerNameTextBox.Location = new System.Drawing.Point(46, 392);
            this.CustomerNameTextBox.Name = "CustomerNameTextBox";
            this.CustomerNameTextBox.Size = new System.Drawing.Size(218, 23);
            this.CustomerNameTextBox.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(43, 298);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 17);
            this.label6.TabIndex = 10;
            this.label6.Text = "Užsakovo ID :";
            // 
            // CustomerIDTextBox
            // 
            this.CustomerIDTextBox.Enabled = false;
            this.CustomerIDTextBox.Location = new System.Drawing.Point(46, 327);
            this.CustomerIDTextBox.Name = "CustomerIDTextBox";
            this.CustomerIDTextBox.Size = new System.Drawing.Size(218, 23);
            this.CustomerIDTextBox.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(62, 234);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Paieška :";
            // 
            // SearchCustomerTextBox
            // 
            this.SearchCustomerTextBox.Location = new System.Drawing.Point(133, 231);
            this.SearchCustomerTextBox.Name = "SearchCustomerTextBox";
            this.SearchCustomerTextBox.Size = new System.Drawing.Size(153, 23);
            this.SearchCustomerTextBox.TabIndex = 7;
            this.SearchCustomerTextBox.TextChanged += new System.EventHandler(this.SearchCustomerTextBox_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.SeaGreen;
            this.label2.Location = new System.Drawing.Point(3, 269);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "UŽSAKOVAS";
            // 
            // DataGridCustomer
            // 
            this.DataGridCustomer.AllowUserToAddRows = false;
            this.DataGridCustomer.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(157)))), ((int)(((byte)(16)))));
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridCustomer.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.DataGridCustomer.ColumnHeadersHeight = 30;
            this.DataGridCustomer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.DataGridCustomer.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column7,
            this.Column1,
            this.Column2});
            this.DataGridCustomer.Dock = System.Windows.Forms.DockStyle.Top;
            this.DataGridCustomer.EnableHeadersVisualStyles = false;
            this.DataGridCustomer.Location = new System.Drawing.Point(0, 0);
            this.DataGridCustomer.Margin = new System.Windows.Forms.Padding(4);
            this.DataGridCustomer.Name = "DataGridCustomer";
            this.DataGridCustomer.RowHeadersVisible = false;
            this.DataGridCustomer.Size = new System.Drawing.Size(289, 224);
            this.DataGridCustomer.TabIndex = 5;
            this.DataGridCustomer.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridCustomer_CellClick);
            // 
            // Column7
            // 
            this.Column7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column7.HeaderText = "Nr.";
            this.Column7.Name = "Column7";
            this.Column7.Width = 51;
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column1.HeaderText = "Užsakovo ID";
            this.Column1.Name = "Column1";
            this.Column1.Width = 111;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column2.HeaderText = "Pavadinimas";
            this.Column2.Name = "Column2";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.QuantityNumericUpDown);
            this.panel3.Controls.Add(this.ClearButton);
            this.panel3.Controls.Add(this.InsertButton);
            this.panel3.Controls.Add(this.label13);
            this.panel3.Controls.Add(this.OrderDatePicker);
            this.panel3.Controls.Add(this.ProductNameTextBox);
            this.panel3.Controls.Add(this.label12);
            this.panel3.Controls.Add(this.TotalTextBox);
            this.panel3.Controls.Add(this.PriceTextBox);
            this.panel3.Controls.Add(this.ProductIDTextBox);
            this.panel3.Controls.Add(this.label11);
            this.panel3.Controls.Add(this.label10);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.SearchProductTextBox);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.DataGridProduct);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(296, 48);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(666, 529);
            this.panel3.TabIndex = 3;
            // 
            // QuantityNumericUpDown
            // 
            this.QuantityNumericUpDown.Location = new System.Drawing.Point(477, 358);
            this.QuantityNumericUpDown.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.QuantityNumericUpDown.Name = "QuantityNumericUpDown";
            this.QuantityNumericUpDown.Size = new System.Drawing.Size(177, 23);
            this.QuantityNumericUpDown.TabIndex = 25;
            this.QuantityNumericUpDown.ValueChanged += new System.EventHandler(this.QuantityNumericUpDown_ValueChanged);
            // 
            // ClearButton
            // 
            this.ClearButton.BackColor = System.Drawing.Color.DarkRed;
            this.ClearButton.FlatAppearance.BorderSize = 0;
            this.ClearButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ClearButton.ForeColor = System.Drawing.Color.White;
            this.ClearButton.Location = new System.Drawing.Point(512, 488);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(148, 29);
            this.ClearButton.TabIndex = 24;
            this.ClearButton.Text = "Išvalyti";
            this.ClearButton.UseVisualStyleBackColor = false;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // InsertButton
            // 
            this.InsertButton.BackColor = System.Drawing.Color.SeaGreen;
            this.InsertButton.FlatAppearance.BorderSize = 0;
            this.InsertButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.InsertButton.ForeColor = System.Drawing.Color.White;
            this.InsertButton.Location = new System.Drawing.Point(358, 488);
            this.InsertButton.Name = "InsertButton";
            this.InsertButton.Size = new System.Drawing.Size(148, 29);
            this.InsertButton.TabIndex = 22;
            this.InsertButton.Text = "Įvesti užsakymą";
            this.InsertButton.UseVisualStyleBackColor = false;
            this.InsertButton.Click += new System.EventHandler(this.InsertButton_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(3, 413);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(116, 17);
            this.label13.TabIndex = 21;
            this.label13.Text = "Užsakymo Data :";
            // 
            // OrderDatePicker
            // 
            this.OrderDatePicker.CustomFormat = "yyyy.MM.dd";
            this.OrderDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.OrderDatePicker.Location = new System.Drawing.Point(6, 433);
            this.OrderDatePicker.Name = "OrderDatePicker";
            this.OrderDatePicker.Size = new System.Drawing.Size(200, 23);
            this.OrderDatePicker.TabIndex = 20;
            // 
            // ProductNameTextBox
            // 
            this.ProductNameTextBox.Location = new System.Drawing.Point(6, 380);
            this.ProductNameTextBox.Name = "ProductNameTextBox";
            this.ProductNameTextBox.Size = new System.Drawing.Size(177, 23);
            this.ProductNameTextBox.TabIndex = 19;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(3, 357);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(163, 17);
            this.label12.TabIndex = 18;
            this.label12.Text = "Produkto Pavadinimas :";
            // 
            // TotalTextBox
            // 
            this.TotalTextBox.Location = new System.Drawing.Point(477, 392);
            this.TotalTextBox.Name = "TotalTextBox";
            this.TotalTextBox.Size = new System.Drawing.Size(177, 23);
            this.TotalTextBox.TabIndex = 17;
            // 
            // PriceTextBox
            // 
            this.PriceTextBox.Location = new System.Drawing.Point(477, 321);
            this.PriceTextBox.Name = "PriceTextBox";
            this.PriceTextBox.Size = new System.Drawing.Size(177, 23);
            this.PriceTextBox.TabIndex = 15;
            // 
            // ProductIDTextBox
            // 
            this.ProductIDTextBox.Location = new System.Drawing.Point(6, 321);
            this.ProductIDTextBox.Name = "ProductIDTextBox";
            this.ProductIDTextBox.Size = new System.Drawing.Size(177, 23);
            this.ProductIDTextBox.TabIndex = 14;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(416, 395);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(52, 17);
            this.label11.TabIndex = 13;
            this.label11.Text = "Suma :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(418, 360);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(50, 17);
            this.label10.TabIndex = 12;
            this.label10.Text = "Kiekis :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(415, 324);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 17);
            this.label9.TabIndex = 11;
            this.label9.Text = "Kaina :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(3, 298);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(92, 17);
            this.label8.TabIndex = 10;
            this.label8.Text = "Produkto ID :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(277, 234);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "Paieška :";
            // 
            // SearchProductTextBox
            // 
            this.SearchProductTextBox.Location = new System.Drawing.Point(348, 231);
            this.SearchProductTextBox.Name = "SearchProductTextBox";
            this.SearchProductTextBox.Size = new System.Drawing.Size(306, 23);
            this.SearchProductTextBox.TabIndex = 8;
            this.SearchProductTextBox.TextChanged += new System.EventHandler(this.SearchProductTextBox_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.SeaGreen;
            this.label3.Location = new System.Drawing.Point(3, 269);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "PRODUKTAS";
            // 
            // DataGridProduct
            // 
            this.DataGridProduct.AllowUserToAddRows = false;
            this.DataGridProduct.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(157)))), ((int)(((byte)(16)))));
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridProduct.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.DataGridProduct.ColumnHeadersHeight = 30;
            this.DataGridProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.DataGridProduct.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.Column3,
            this.Column5,
            this.Column4,
            this.Column6});
            this.DataGridProduct.Dock = System.Windows.Forms.DockStyle.Top;
            this.DataGridProduct.EnableHeadersVisualStyles = false;
            this.DataGridProduct.Location = new System.Drawing.Point(0, 0);
            this.DataGridProduct.Margin = new System.Windows.Forms.Padding(4);
            this.DataGridProduct.Name = "DataGridProduct";
            this.DataGridProduct.RowHeadersVisible = false;
            this.DataGridProduct.Size = new System.Drawing.Size(666, 224);
            this.DataGridProduct.TabIndex = 9;
            this.DataGridProduct.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridProduct_CellClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn1.HeaderText = "Nr.";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 51;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn2.HeaderText = "Produkto ID";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 109;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn3.HeaderText = "Pavadinimas";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 117;
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column3.HeaderText = "Kiekis";
            this.Column3.Name = "Column3";
            this.Column3.Width = 67;
            // 
            // Column5
            // 
            this.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column5.HeaderText = "Kaina";
            this.Column5.Name = "Column5";
            this.Column5.Width = 70;
            // 
            // Column4
            // 
            this.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column4.HeaderText = "Aprašymas";
            this.Column4.Name = "Column4";
            // 
            // Column6
            // 
            this.Column6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column6.HeaderText = "Kategorija";
            this.Column6.Name = "Column6";
            // 
            // OrderIDLabel
            // 
            this.OrderIDLabel.AutoSize = true;
            this.OrderIDLabel.Location = new System.Drawing.Point(13, 503);
            this.OrderIDLabel.Name = "OrderIDLabel";
            this.OrderIDLabel.Size = new System.Drawing.Size(54, 17);
            this.OrderIDLabel.TabIndex = 13;
            this.OrderIDLabel.Text = "label14";
            this.OrderIDLabel.Visible = false;
            // 
            // OrderModuleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(962, 577);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "OrderModuleForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OderModuleForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridCustomer)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.QuantityNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridProduct)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView DataGridCustomer;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox SearchCustomerTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView DataGridProduct;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label13;
        public System.Windows.Forms.Button ClearButton;
        public System.Windows.Forms.Button InsertButton;
        public System.Windows.Forms.Label OrderIDLabel;
        public System.Windows.Forms.TextBox SearchProductTextBox;
        public System.Windows.Forms.TextBox CustomerNameTextBox;
        public System.Windows.Forms.TextBox CustomerIDTextBox;
        public System.Windows.Forms.TextBox ProductNameTextBox;
        public System.Windows.Forms.TextBox TotalTextBox;
        public System.Windows.Forms.TextBox PriceTextBox;
        public System.Windows.Forms.TextBox ProductIDTextBox;
        public System.Windows.Forms.DateTimePicker OrderDatePicker;
        public System.Windows.Forms.NumericUpDown QuantityNumericUpDown;
    }
}