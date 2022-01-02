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
    public partial class OrderModuleForm : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-GGQR03C4;Initial Catalog=WarehouseManagmentSystem;Integrated Security=True");
        SqlCommand cmd = new SqlCommand();
        SqlDataReader sdr;
        int quantity = 0;
        public OrderModuleForm()
        {
            InitializeComponent();
            LoadCustomer();
            LoadProduct();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        public void LoadCustomer()
        {
            int i = 0;
            DataGridCustomer.Rows.Clear();
            cmd = new SqlCommand("SELECT CustomerID, CustomerName FROM Customer WHERE CONCAT (CustomerID, CustomerName) LIKE '%"+SearchCustomerTextBox.Text+"%'", con);
            con.Open();
            sdr = cmd.ExecuteReader();
            while (sdr.Read())
            {
                i++;
                DataGridCustomer.Rows.Add(i, sdr[0].ToString(), sdr[1].ToString());
            }
            sdr.Close();
            con.Close();

        }

        public void LoadProduct()
        {
            int i = 0;
            DataGridProduct.Rows.Clear();
            cmd = new SqlCommand("SELECT * FROM Product WHERE CONCAT(ProductID,ProductName,ProductPrice,ProductDescription,ProductCategory) LIKE '%" + SearchProductTextBox.Text + "%' ", con);
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

        private void SearchCustomerTextBox_TextChanged(object sender, EventArgs e)
        {
            LoadCustomer();
        }

        private void SearchProductTextBox_TextChanged(object sender, EventArgs e)
        {
            LoadProduct();
        }


        private void QuantityNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            GetQuantity();

            if (Convert.ToInt16(QuantityNumericUpDown.Value)> quantity)
            {
                MessageBox.Show("Neturite tokio prekės kiekio.", "Perspėjimas", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                QuantityNumericUpDown.Value = QuantityNumericUpDown.Value - 1;
                return;
            }
            if (Convert.ToInt16(QuantityNumericUpDown.Value) > 0)
            {
                int total = Convert.ToInt16(PriceTextBox.Text) * Convert.ToInt16(QuantityNumericUpDown.Value);
                TotalTextBox.Text = total.ToString();
            }
            TotalTextBox.ReadOnly = true;
        }

        private void DataGridCustomer_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            CustomerIDTextBox.Text = DataGridCustomer.Rows[e.RowIndex].Cells[1].Value.ToString();
            CustomerNameTextBox.Text = DataGridCustomer.Rows[e.RowIndex].Cells[2].Value.ToString();
        }

        private void DataGridProduct_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            ProductIDTextBox.Text = DataGridProduct.Rows[e.RowIndex].Cells[1].Value.ToString();
            ProductNameTextBox.Text = DataGridProduct.Rows[e.RowIndex].Cells[2].Value.ToString();
            PriceTextBox.Text = DataGridProduct.Rows[e.RowIndex].Cells[4].Value.ToString();
            ProductIDTextBox.ReadOnly = true;
            ProductNameTextBox.ReadOnly = true;
            PriceTextBox.ReadOnly = true;
        }

        private void InsertButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (CustomerIDTextBox.Text == "")
                {
                    MessageBox.Show(" Pasirinkite užsakovą", "Perspėjimas", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (ProductIDTextBox.Text == "")
                {
                    MessageBox.Show(" Pasirinkite produktą", "Perspėjimas", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (MessageBox.Show
                ("Ar tikrai norite įvesti šį užsakymą ?", "Įvedamas užsakymas", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    cmd = new SqlCommand("INSERT INTO tbOrder(orderDate, prodID, custID, quantity, price, total)VALUES(@orderDate, @prodID, @custID, @quantity, @price, @total)", con);
                    cmd.Parameters.AddWithValue("@orderDate", OrderDatePicker.Value);
                    cmd.Parameters.AddWithValue("@prodID", Convert.ToInt16(ProductIDTextBox.Text));
                    cmd.Parameters.AddWithValue("@custID", Convert.ToInt16(CustomerIDTextBox.Text));
                    cmd.Parameters.AddWithValue("@quantity", Convert.ToInt16(QuantityNumericUpDown.Value));
                    cmd.Parameters.AddWithValue("@price", Convert.ToInt16(PriceTextBox.Text));
                    cmd.Parameters.AddWithValue("@total", Convert.ToInt16(TotalTextBox.Text));
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Užsakymas sėkmingai įvestas.");

                    cmd = new SqlCommand("UPDATE Product SET ProductQuantity = (ProductQuantity - @ProductQuantity) WHERE ProductID LIKE '" + ProductIDTextBox.Text + "' ", con);
                    cmd.Parameters.AddWithValue("@ProductQuantity", Convert.ToInt16(QuantityNumericUpDown.Value));


                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                    Clear();
                    LoadProduct();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void Clear()
        {
            CustomerIDTextBox.Clear();
            CustomerNameTextBox.Clear();

            ProductIDTextBox.Clear();
            ProductNameTextBox.Clear();

            PriceTextBox.Clear();
            QuantityNumericUpDown.Value = 0;
            TotalTextBox.Clear();
            OrderDatePicker.Value = DateTime.Now;

        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            Clear();
        }

        public void GetQuantity()
        {
            cmd = new SqlCommand("SELECT ProductQuantity FROM Product WHERE ProductID = '" + ProductIDTextBox.Text + "' ", con);
            con.Open();
            sdr = cmd.ExecuteReader();
            while (sdr.Read())
            {
                quantity = Convert.ToInt32(sdr[0].ToString());
            }
            sdr.Close();
            con.Close();
        }
    }
}
