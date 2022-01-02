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
    public partial class ProductModuleForm : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-GGQR03C4;Initial Catalog=WarehouseManagmentSystem;Integrated Security=True");
        SqlCommand cmd = new SqlCommand();
        SqlDataReader sdr;
        public ProductModuleForm()
        {
            InitializeComponent();
            LoadCategory();
        }

        public void LoadCategory()
        {
            ComboBoxCategory.Items.Clear();
            cmd = new SqlCommand("SELECT CategoryName FROM Category", con);
            con.Open();
            sdr = cmd.ExecuteReader();
            while (sdr.Read())
            {
                ComboBoxCategory.Items.Add(sdr[0].ToString());
            }
            sdr.Close();
            con.Close();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show
                ("Ar tikrai norite išsaugoti šį produktą ?", "Saugomas produktas", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    cmd = new SqlCommand("INSERT INTO Product(ProductName,ProductQuantity,ProductPrice,ProductDescription,ProductCategory)VALUES(@ProductName, @ProductQuantity, @ProductPrice, @ProductDescription, @ProductCategory)", con);
                    cmd.Parameters.AddWithValue("@ProductName", ProductNameTextBox.Text);
                    cmd.Parameters.AddWithValue("@ProductQuantity", Convert.ToInt16(QuantityTextBox.Text));
                    cmd.Parameters.AddWithValue("@ProductPrice", Convert.ToInt16(PriceTextBox.Text));
                    cmd.Parameters.AddWithValue("@ProductDescription", DescriptionTextBox.Text);
                    cmd.Parameters.AddWithValue("@ProductCategory", ComboBoxCategory.Text);
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Produktas sėkmingai sukurtas.");
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
            ProductNameTextBox.Clear();
            QuantityTextBox.Clear();
            PriceTextBox.Clear();
            DescriptionTextBox.Clear();
            ComboBoxCategory.Text = "";
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            Clear();
            SaveButton.Enabled = true;
            UpdateButton.Enabled = false;
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show
                ("Ar tikrai norite atnaujinti šio produkto duomenis ?", "Atnaujinamas produktas", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    cmd = new SqlCommand("UPDATE Product SET ProductName = @ProductName,ProductQuantity = @ProductQuantity,ProductPrice = @ProductPrice, ProductDescription = @ProductDescription, ProductCategory = @ProductCategory WHERE ProductID LIKE '" + ProductID.Text + "' ", con);
                    cmd.Parameters.AddWithValue("@ProductName", ProductNameTextBox.Text);
                    cmd.Parameters.AddWithValue("@ProductQuantity", Convert.ToInt16(QuantityTextBox.Text));
                    cmd.Parameters.AddWithValue("@ProductPrice", Convert.ToInt16(PriceTextBox.Text));
                    cmd.Parameters.AddWithValue("@ProductDescription", DescriptionTextBox.Text);
                    cmd.Parameters.AddWithValue("@ProductCategory", ComboBoxCategory.Text);

                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Produkto duomenys sėkmingai atnaujinti.");
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
