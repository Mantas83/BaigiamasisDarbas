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
    public partial class CustomerModuleForm : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-GGQR03C4;Initial Catalog=WarehouseManagmentSystem;Integrated Security=True");
        SqlCommand cmd = new SqlCommand();

        public CustomerModuleForm()
        {
            InitializeComponent();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (CustomerPhoneNrTextBox.TextLength > 12)
                {
                    MessageBox.Show(" Įvestas telefono numeris nėra tinkamas", "Perspėjimas", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (!CustomerEmailTextBox.Text.Contains("@"))
                {
                    MessageBox.Show(" Neteisingai įvestas el.paštas", "Perspėjimas", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }



                    if (MessageBox.Show
                    ("Ar tikrai norite išsaugoti šį užsakovą ?", "Saugomas užsakovas", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        cmd = new SqlCommand("INSERT INTO Customer(CustomerName, CustomerPhoneNr, CustomerEmail)VALUES(@CustomerName, @CustomerPhoneNr, @CustomerEmail)", con);
                        cmd.Parameters.AddWithValue("@CustomerName", CustomerNameTextBox.Text);
                        cmd.Parameters.AddWithValue("@CustomerPhoneNr", CustomerPhoneNrTextBox.Text);
                        cmd.Parameters.AddWithValue("@CustomerEmail", CustomerEmailTextBox.Text);
                        con.Open();
                        cmd.ExecuteNonQuery();
                        con.Close();
                        MessageBox.Show("Užsakovas sėkmingai sukurtas.");
                        Clear();

                    }
               

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void Clear()
        {
            CustomerEmailTextBox.Clear();
            CustomerNameTextBox.Clear();
            CustomerPhoneNrTextBox.Clear();
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            Clear();
            SaveButton.Enabled = true;
            UpdateButton.Enabled = false;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            CustumerUpdate();
        }

        public void CustumerUpdate()
        {
            try
            {
                if (CustomerPhoneNrTextBox.TextLength > 12)
                {
                    MessageBox.Show(" Įvestas telefono numeris nėra tinkamas", "Perspėjimas", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (!CustomerEmailTextBox.Text.Contains("@"))
                {
                    MessageBox.Show(" Neteisingai įvestas el.paštas", "Perspėjimas", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (MessageBox.Show
                ("Ar tikrai norite atnaujinti šio užsakovo duomenis ?", "Atnaujinamas užsakovas", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    cmd = new SqlCommand("UPDATE Customer SET CustomerName = @CustomerName,CustomerPhoneNr =" + " @CustomerPhoneNr, CustomerEmail = @CustomerEmail WHERE CustomerID LIKE '" + CustomerLabel.Text + "' ", con);
                    cmd.Parameters.AddWithValue("@CustomerName", CustomerNameTextBox.Text);
                    cmd.Parameters.AddWithValue("@CustomerPhoneNr", CustomerPhoneNrTextBox.Text);
                    cmd.Parameters.AddWithValue("@CustomerEmail", CustomerEmailTextBox.Text);
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Užsakovo duomenys sėkmingai atnaujinti.");
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
