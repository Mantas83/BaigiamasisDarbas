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
    public partial class CategoryModuleForm : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-GGQR03C4;Initial Catalog=WarehouseManagmentSystem;Integrated Security=True");
        SqlCommand cmd = new SqlCommand();

        public CategoryModuleForm()
        {
            InitializeComponent();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show
                ("Ar tikrai norite išsaugoti šią kategoriją ?", "Saugoma kategorija", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    cmd = new SqlCommand("INSERT INTO Category(CategoryName)VALUES(@CategoryName)", con);
                    cmd.Parameters.AddWithValue("@CategoryName", CategoryNameTextBox.Text);
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Kategorija sėkmingai sukurta.");
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
            CategoryNameTextBox.Clear();
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
            try
            {
                if (MessageBox.Show
                ("Ar tikrai norite atnaujinti šią kategoriją ?", "Atnaujinama kategorija", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    cmd = new SqlCommand("UPDATE Category SET CategoryName = @CategoryName WHERE CategoryID LIKE '" + CategoryLabel.Text + "' ", con);
                    cmd.Parameters.AddWithValue("@CategoryName", CategoryNameTextBox.Text);
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Kategorija sėkmingai atnaujinta.");
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
