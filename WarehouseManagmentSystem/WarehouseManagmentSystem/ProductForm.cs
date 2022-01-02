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
    public partial class ProductForm : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-GGQR03C4;Initial Catalog=WarehouseManagmentSystem;Integrated Security=True");
        SqlCommand cmd = new SqlCommand();
        SqlDataReader sdr;

        public ProductForm()
        {
            InitializeComponent();
            LoadProduct();
        }

        public void LoadProduct()
        {
            int i = 0;
            DataGridProduct.Rows.Clear();
            cmd = new SqlCommand("SELECT * FROM Product WHERE CONCAT(ProductID,ProductName,ProductPrice,ProductDescription,ProductCategory) LIKE '%" +SearchTextBox.Text+"%' ", con);
            con.Open();
            sdr = cmd.ExecuteReader();
            while (sdr.Read())
            {
                i++;
                DataGridProduct.Rows.Add(i, sdr[0].ToString(), sdr[1].ToString(), sdr[2].ToString(), sdr[3].ToString(), sdr[4].ToString(), sdr[5].ToString());
            }
            sdr.Close();
            con.Close();

        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            ProductModuleForm formModule = new ProductModuleForm();
            formModule.SaveButton.Enabled = true;
            formModule.UpdateButton.Enabled = false;
            formModule.ShowDialog();
            LoadProduct();
        }

        private void DataGridProduct_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string colname = DataGridProduct.Columns[e.ColumnIndex].Name;
            if (colname == "Edit")
            {
                ProductModuleForm productmodule = new ProductModuleForm();
                productmodule.ProductID.Text = DataGridProduct.Rows[e.RowIndex].Cells[1].Value.ToString();
                productmodule.ProductNameTextBox.Text = DataGridProduct.Rows[e.RowIndex].Cells[2].Value.ToString();
                productmodule.QuantityTextBox.Text = DataGridProduct.Rows[e.RowIndex].Cells[3].Value.ToString();
                productmodule.PriceTextBox.Text = DataGridProduct.Rows[e.RowIndex].Cells[4].Value.ToString();
                productmodule.DescriptionTextBox.Text = DataGridProduct.Rows[e.RowIndex].Cells[5].Value.ToString();
                productmodule.ComboBoxCategory.Text = DataGridProduct.Rows[e.RowIndex].Cells[6].Value.ToString();

                productmodule.SaveButton.Enabled = false;
                productmodule.UpdateButton.Enabled = true;
                productmodule.ShowDialog();
            }
            else if (colname == "Delete")
            {
                if (MessageBox.Show
                ("Ar tikrai norite ištrinti šį Produktą ?", "Produkto ištrinimas", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    con.Open();
                    cmd = new SqlCommand("DELETE FROM Product Where ProductID LIKE'" + DataGridProduct.Rows[e.RowIndex].Cells[1].Value.ToString() + "'", con);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Produktas sėkmingai ištrintas.");
                }
            }
            LoadProduct();
        }

        private void SearchTextBox_TextChanged(object sender, EventArgs e)
        {
            LoadProduct();
        }
    }
}
