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
    public partial class UserForm : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-GGQR03C4;Initial Catalog=WarehouseManagmentSystem;Integrated Security=True");
        SqlCommand cmd = new SqlCommand();
        SqlDataReader sdr;
        public UserForm()
        {
            InitializeComponent();
            LoadUser();
        }

        public void LoadUser()
        {
            int i = 0;
            DataGridUser.Rows.Clear();
            cmd = new SqlCommand("SELECT * FROM Users", con);
            con.Open();
            sdr = cmd.ExecuteReader();
            while (sdr.Read())
            {
                i++;
                DataGridUser.Rows.Add(i, sdr[0].ToString(), sdr[1].ToString(), sdr[2].ToString(), sdr[3].ToString(), sdr[4].ToString());
            }
            sdr.Close();
            con.Close();

        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            UserModuleForm usermodule = new UserModuleForm();
            usermodule.SaveButton.Enabled = true;
            usermodule.UpdateButton.Enabled = false;
            usermodule.ShowDialog();
            LoadUser();
        }

        private void DataGridUser_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string colname = DataGridUser.Columns[e.ColumnIndex].Name;
            if(colname == "Edit")
            {
                UserModuleForm usermodule = new UserModuleForm();
                usermodule.UserNameTextBox.Text = DataGridUser.Rows[e.RowIndex].Cells[1].Value.ToString();
                usermodule.FullnameTextBox.Text = DataGridUser.Rows[e.RowIndex].Cells[2].Value.ToString();
                usermodule.PasswordTextBox.Text = DataGridUser.Rows[e.RowIndex].Cells[3].Value.ToString();
                usermodule.ReTypePasswordTextBox.Text = DataGridUser.Rows[e.RowIndex].Cells[3].Value.ToString();
                usermodule.PhoneNrTextBox.Text = DataGridUser.Rows[e.RowIndex].Cells[4].Value.ToString();


                usermodule.SaveButton.Enabled = false;
                usermodule.UpdateButton.Enabled = true;
                usermodule.UserNameTextBox.Enabled = false;
                usermodule.ShowDialog();
            }
            else if (colname == "Delete")
            {
                if(MessageBox.Show
                ("Ar tikrai norite ištrinti šį naudotoją ?", "Naudotojo ištrinimas",MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    con.Open();
                    cmd = new SqlCommand("DELETE FROM Users Where username LIKE'" + DataGridUser.Rows[e.RowIndex].Cells[1].Value.ToString() + "'", con);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Naudotojas sėkmingai ištrintas.");
                    LoadUser();
                }
            }

            LoadUser();
        }
    }
}
