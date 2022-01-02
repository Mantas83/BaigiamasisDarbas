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
    public partial class CategoryForm : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-GGQR03C4;Initial Catalog=WarehouseManagmentSystem;Integrated Security=True");
        SqlCommand cmd = new SqlCommand();
        SqlDataReader sdr;

        public CategoryForm()
        {
            InitializeComponent();
            LoadCategory();
        }

        public void LoadCategory()
        {
            int i = 0;
            DataGridCategory.Rows.Clear();
            cmd = new SqlCommand("SELECT * FROM Category", con);
            con.Open();
            sdr = cmd.ExecuteReader();
            while (sdr.Read())
            {
                i++;
                DataGridCategory.Rows.Add(i, sdr[0].ToString(), sdr[1].ToString());
            }
            sdr.Close();
            con.Close();

        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            CategoryModuleForm formModule = new CategoryModuleForm();
            formModule.SaveButton.Enabled = true;
            formModule.UpdateButton.Enabled = false;
            formModule.ShowDialog();
            LoadCategory();
        }

        private void DataGridCategory_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string colname = DataGridCategory.Columns[e.ColumnIndex].Name;
            if (colname == "Edit")
            {
                CategoryModuleForm formmodule = new CategoryModuleForm();
                formmodule.CategoryLabel.Text = DataGridCategory.Rows[e.RowIndex].Cells[1].Value.ToString();
                formmodule.CategoryNameTextBox.Text = DataGridCategory.Rows[e.RowIndex].Cells[2].Value.ToString();

                formmodule.SaveButton.Enabled = false;
                formmodule.UpdateButton.Enabled = true;
                formmodule.ShowDialog();
            }
            else if (colname == "Delete")
            {
                if (MessageBox.Show
                ("Ar tikrai norite ištrinti šią kategoriją ?", "Kategorijos ištrinimas", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    con.Open();
                    cmd = new SqlCommand("DELETE FROM Category Where CategoryID LIKE'" + DataGridCategory.Rows[e.RowIndex].Cells[1].Value.ToString() + "'", con);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Kategorija sėkmingai ištrinta.");
                    LoadCategory();
                }
            }

            LoadCategory();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
