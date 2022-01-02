using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WarehouseManagmentSystem
{
    public partial class LoginForm : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-GGQR03C4;Initial Catalog=WarehouseManagmentSystem;Integrated Security=True");
        SqlCommand cmd = new SqlCommand();
        SqlDataReader sdr;

        public LoginForm()
        {
            InitializeComponent();
        }

        private void ShowPasswordBox_CheckedChanged(object sender, EventArgs e)
        {
            if (ShowPasswordBox.Checked == false)
                LoginPassword.UseSystemPasswordChar = true;
            else
                LoginPassword.UseSystemPasswordChar = false;
        }

        private void LabelClear_Click(object sender, EventArgs e)
        {
            LoginUserName.Clear();
            LoginPassword.Clear();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Ar norite išeiti iš programos?", "Patvirtinimas" , MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            try
            {
                cmd = new SqlCommand("SELECT * FROM Users WHERE username=@username AND password = @password", con);
                cmd.Parameters.AddWithValue("@username", LoginUserName.Text);
                cmd.Parameters.AddWithValue("@password", LoginPassword.Text);
                con.Open();
                sdr = cmd.ExecuteReader();
                sdr.Read();
                if (sdr.HasRows)
                {
                    if (sdr[4].ToString() == "Admin")
                    {
                        MainForm.type = "A";
                    }
                    else if (sdr[4].ToString() == "User")
                    {
                        MainForm.type = "U";
                    }
                    MessageBox.Show("Sveiki " + sdr["fullname"].ToString() + " | ", " PRISIJUNGĖTE", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    MainForm main = new MainForm();
                    this.Hide();
                    main.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Netinkamas Prisijungimo Vardas arba Slaptažodis ", " NEPRISIJUNGĖTE ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
