using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WarehouseManagmentSystem
{
    public partial class UserModuleForm : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-GGQR03C4;Initial Catalog=WarehouseManagmentSystem;Integrated Security=True");
        SqlCommand cmd = new SqlCommand();
        public UserModuleForm()
        {
            InitializeComponent();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            try
            {
                if(PasswordTextBox.Text != ReTypePasswordTextBox.Text)
                {
                    MessageBox.Show(" Įvesti slaptažodžiai nesutapo", "Perspėjimas", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }


                if(MessageBox.Show
                ("Ar tikrai norite išsaugoti šį naudotoją ?", "Saugomas naudotojas", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    cmd = new SqlCommand("INSERT INTO Users(username,fullname,password,phonenr,type)VALUES(@username,@fullname,@password,@phonenr,@type)", con);
                    cmd.Parameters.AddWithValue("@username", UserNameTextBox.Text);
                    cmd.Parameters.AddWithValue("@fullname", FullnameTextBox.Text);
                    cmd.Parameters.AddWithValue("@password", PasswordTextBox.Text);
                    cmd.Parameters.AddWithValue("@phonenr", PhoneNrTextBox.Text);
                    cmd.Parameters.AddWithValue("@type", ComboBoxType.Text);
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Naudotojas sėkmingai sukurtas.");
                    Clear();

                }

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            Clear();
            SaveButton.Enabled = true;
            UpdateButton.Enabled = false;
        }

        public void Clear ()
        {
            FullnameTextBox.Clear();
            PasswordTextBox.Clear();
            ReTypePasswordTextBox.Clear();
            PhoneNrTextBox.Clear();
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (PasswordTextBox.Text != ReTypePasswordTextBox.Text)
                {
                    MessageBox.Show(" Įvesti slaptažodžiai nesutapo", "Perspėjimas", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (MessageBox.Show
                ("Ar tikrai norite atnaujinti šio naudotojo duomenis ?", "Atnaujinamas naudotojas", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    cmd = new SqlCommand("UPDATE Users SET fullname = @fullname,password = @password,phonenr = @phonenr,type = @type WHERE username LIKE '"+ UserNameTextBox.Text +"' ", con);
                    cmd.Parameters.AddWithValue("@fullname", FullnameTextBox.Text);
                    cmd.Parameters.AddWithValue("@password", PasswordTextBox.Text);
                    cmd.Parameters.AddWithValue("@phonenr", PhoneNrTextBox.Text);
                    cmd.Parameters.AddWithValue("@type", ComboBoxType.Text);
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Naudotojo duomenys sėkmingai atnaujinti.");
                    this.Dispose();

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
