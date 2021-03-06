
namespace WarehouseManagmentSystem
{
    partial class UserModuleForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserModuleForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.UserNameTextBox = new System.Windows.Forms.TextBox();
            this.FullnameTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.PasswordTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.PhoneNrTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SaveButton = new System.Windows.Forms.Button();
            this.UpdateButton = new System.Windows.Forms.Button();
            this.ClearButton = new System.Windows.Forms.Button();
            this.ReTypePasswordTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.ComboBoxType = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
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
            this.panel1.Size = new System.Drawing.Size(467, 48);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(449, 3);
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
            this.label1.Size = new System.Drawing.Size(156, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Naudotojo modulis";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(46, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Naudotojo vardas :";
            // 
            // UserNameTextBox
            // 
            this.UserNameTextBox.Location = new System.Drawing.Point(194, 57);
            this.UserNameTextBox.Name = "UserNameTextBox";
            this.UserNameTextBox.Size = new System.Drawing.Size(249, 23);
            this.UserNameTextBox.TabIndex = 2;
            // 
            // FullnameTextBox
            // 
            this.FullnameTextBox.Location = new System.Drawing.Point(194, 92);
            this.FullnameTextBox.Name = "FullnameTextBox";
            this.FullnameTextBox.Size = new System.Drawing.Size(249, 23);
            this.FullnameTextBox.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(61, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Vardas Pavardė :";
            // 
            // PasswordTextBox
            // 
            this.PasswordTextBox.Location = new System.Drawing.Point(194, 130);
            this.PasswordTextBox.Name = "PasswordTextBox";
            this.PasswordTextBox.Size = new System.Drawing.Size(249, 23);
            this.PasswordTextBox.TabIndex = 6;
            this.PasswordTextBox.UseSystemPasswordChar = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(92, 133);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "Slaptažodis :";
            // 
            // PhoneNrTextBox
            // 
            this.PhoneNrTextBox.Location = new System.Drawing.Point(194, 204);
            this.PhoneNrTextBox.Name = "PhoneNrTextBox";
            this.PhoneNrTextBox.Size = new System.Drawing.Size(249, 23);
            this.PhoneNrTextBox.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(58, 204);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(123, 17);
            this.label5.TabIndex = 7;
            this.label5.Text = "Telefono numeris :";
            // 
            // SaveButton
            // 
            this.SaveButton.BackColor = System.Drawing.Color.SeaGreen;
            this.SaveButton.FlatAppearance.BorderSize = 0;
            this.SaveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SaveButton.ForeColor = System.Drawing.Color.White;
            this.SaveButton.Location = new System.Drawing.Point(153, 270);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(92, 29);
            this.SaveButton.TabIndex = 9;
            this.SaveButton.Text = "Išsaugoti";
            this.SaveButton.UseVisualStyleBackColor = false;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // UpdateButton
            // 
            this.UpdateButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(157)))), ((int)(((byte)(16)))));
            this.UpdateButton.FlatAppearance.BorderSize = 0;
            this.UpdateButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UpdateButton.ForeColor = System.Drawing.Color.White;
            this.UpdateButton.Location = new System.Drawing.Point(251, 270);
            this.UpdateButton.Name = "UpdateButton";
            this.UpdateButton.Size = new System.Drawing.Size(92, 29);
            this.UpdateButton.TabIndex = 10;
            this.UpdateButton.Text = "Atnaujinti";
            this.UpdateButton.UseVisualStyleBackColor = false;
            this.UpdateButton.Click += new System.EventHandler(this.UpdateButton_Click);
            // 
            // ClearButton
            // 
            this.ClearButton.BackColor = System.Drawing.Color.DarkRed;
            this.ClearButton.FlatAppearance.BorderSize = 0;
            this.ClearButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ClearButton.ForeColor = System.Drawing.Color.White;
            this.ClearButton.Location = new System.Drawing.Point(349, 270);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(92, 29);
            this.ClearButton.TabIndex = 11;
            this.ClearButton.Text = "Išvalyti";
            this.ClearButton.UseVisualStyleBackColor = false;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // ReTypePasswordTextBox
            // 
            this.ReTypePasswordTextBox.Location = new System.Drawing.Point(194, 166);
            this.ReTypePasswordTextBox.Name = "ReTypePasswordTextBox";
            this.ReTypePasswordTextBox.Size = new System.Drawing.Size(249, 23);
            this.ReTypePasswordTextBox.TabIndex = 13;
            this.ReTypePasswordTextBox.UseSystemPasswordChar = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 169);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(166, 17);
            this.label6.TabIndex = 12;
            this.label6.Text = "Pakartokite slaptažodis :";
            // 
            // ComboBoxType
            // 
            this.ComboBoxType.FormattingEnabled = true;
            this.ComboBoxType.Items.AddRange(new object[] {
            "Admin",
            "User"});
            this.ComboBoxType.Location = new System.Drawing.Point(194, 233);
            this.ComboBoxType.Name = "ComboBoxType";
            this.ComboBoxType.Size = new System.Drawing.Size(249, 25);
            this.ComboBoxType.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(63, 236);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(118, 17);
            this.label7.TabIndex = 15;
            this.label7.Text = "Naudotojo tipas:";
            // 
            // UserModuleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(467, 309);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.ComboBoxType);
            this.Controls.Add(this.ReTypePasswordTextBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.ClearButton);
            this.Controls.Add(this.UpdateButton);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.PhoneNrTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.PasswordTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.FullnameTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.UserNameTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "UserModuleForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UserModuleForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox3;
        public System.Windows.Forms.Button SaveButton;
        public System.Windows.Forms.Button UpdateButton;
        public System.Windows.Forms.Button ClearButton;
        public System.Windows.Forms.TextBox UserNameTextBox;
        public System.Windows.Forms.TextBox FullnameTextBox;
        public System.Windows.Forms.TextBox PasswordTextBox;
        public System.Windows.Forms.TextBox PhoneNrTextBox;
        public System.Windows.Forms.TextBox ReTypePasswordTextBox;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.ComboBox ComboBoxType;
        private System.Windows.Forms.Label label7;
    }
}