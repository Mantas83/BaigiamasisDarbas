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
    public partial class CustomerForm : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-GGQR03C4;Initial Catalog=WarehouseManagmentSystem;Integrated Security=True");
        SqlCommand cmd = new SqlCommand();
        SqlDataReader sdr;

        public CustomerForm()
        {
            InitializeComponent();
            LoadCustomer();
        }

        public void LoadCustomer()
        {
            int i = 0;
            DataGridCustomer.Rows.Clear();
            cmd = new SqlCommand("SELECT * FROM Customer", con);
            con.Open();
            sdr = cmd.ExecuteReader();
            while (sdr.Read())
            {
                i++;
                DataGridCustomer.Rows.Add(i, sdr[0].ToString(), sdr[1].ToString(), sdr[2].ToString(), sdr[3].ToString());
            }
            sdr.Close();
            con.Close();

        }
        private void AddButton_Click(object sender, EventArgs e)
        {
            CustomerModuleForm moduleForm = new CustomerModuleForm();
            moduleForm.SaveButton.Enabled = true;
            moduleForm.UpdateButton.Enabled = false;
            moduleForm.ShowDialog();
            LoadCustomer();
        }

        private void DataGridCustomer_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string colname = DataGridCustomer.Columns[e.ColumnIndex].Name;
            if (colname == "Edit")
            {
                CustomerModuleForm customermodule = new CustomerModuleForm();
                customermodule.CustomerLabel.Text = DataGridCustomer.Rows[e.RowIndex].Cells[1].Value.ToString();
                customermodule.CustomerNameTextBox.Text = DataGridCustomer.Rows[e.RowIndex].Cells[2].Value.ToString();
                customermodule.CustomerPhoneNrTextBox.Text = DataGridCustomer.Rows[e.RowIndex].Cells[3].Value.ToString();
                customermodule.CustomerEmailTextBox.Text = DataGridCustomer.Rows[e.RowIndex].Cells[4].Value.ToString();

                customermodule.SaveButton.Enabled = false;
                customermodule.UpdateButton.Enabled = true;
                customermodule.ShowDialog();
            }
            else if (colname == "Delete")
            {
                if (MessageBox.Show
                ("Ar tikrai norite ištrinti šį užsakovą ?", "Užsakovo ištrinimas", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    con.Open();
                    cmd = new SqlCommand("DELETE FROM Customer Where CustomerID LIKE'" + DataGridCustomer.Rows[e.RowIndex].Cells[1].Value.ToString() + "'", con);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Užsakovas sėkmingai ištrintas.");
                    LoadCustomer();
                }
            }

            LoadCustomer();
        }
    }
}
