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
    public partial class OrderForm : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-GGQR03C4;Initial Catalog=WarehouseManagmentSystem;Integrated Security=True");
        SqlCommand cmd = new SqlCommand();
        SqlDataReader sdr;

        public OrderForm()
        {
            InitializeComponent();
            LoadOrder();
        }

        public void LoadOrder()
        {
            double total = 0;
            int i = 0;
            DataGridOrder.Rows.Clear();
            cmd = new SqlCommand("SELECT OrderID, orderDate, O.prodID, P.ProductName, O.custId, C.CustomerName, quantity, price, total FROM tbOrder AS O JOIN Customer AS C ON O.custId=C.CustomerID JOIN Product AS P ON O.prodID = P.ProductID WHERE CONCAT(OrderID, orderDate, O.prodID, P.ProductName, O.custId, C.CustomerName, quantity, price, total) LIKE '%"+SearchTextBox.Text+"%'", con);
            con.Open();
            sdr = cmd.ExecuteReader();
            while (sdr.Read())
            {
                i++;
                DataGridOrder.Rows.Add(i, sdr[0].ToString(), Convert.ToDateTime(sdr[1].ToString()).ToString("yyyy-MM-dd"), sdr[2].ToString(), sdr[3].ToString(), sdr[4].ToString(), sdr[5].ToString(), sdr[6].ToString(), sdr[7].ToString(), sdr[8].ToString());
                total += Convert.ToInt32(sdr[8].ToString());
            }
            sdr.Close();
            con.Close();

            QuantityLabel.Text = i.ToString();
            TotalLabel.Text = total.ToString();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            OrderModuleForm moduleForm = new OrderModuleForm();
            moduleForm.ShowDialog();
            LoadOrder();
        }

        private void DataGridOrder_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string colname = DataGridOrder.Columns[e.ColumnIndex].Name;
           
            if (colname == "Delete")
            {
                if (MessageBox.Show
                ("Ar tikrai norite ištrinti šį užsakymą ?", "Užsakymo ištrinimas", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    con.Open();
                    cmd = new SqlCommand("DELETE FROM tbOrder Where OrderID LIKE'" + DataGridOrder.Rows[e.RowIndex].Cells[1].Value.ToString() + "'", con);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Užsakymas sėkmingai ištrintas.");

                    cmd = new SqlCommand("UPDATE Product SET ProductQuantity = (ProductQuantity + @ProductQuantity) WHERE ProductID LIKE '" + DataGridOrder.Rows[e.RowIndex].Cells[3].Value.ToString() + "' ", con);
                    cmd.Parameters.AddWithValue("@ProductQuantity", Convert.ToInt16(DataGridOrder.Rows[e.RowIndex].Cells[5].Value.ToString()));


                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();

                }
            }
            LoadOrder();
        }

        private void SearchTextBox_TextChanged(object sender, EventArgs e)
        {
            LoadOrder();
        }

        private void PrintButton_Click(object sender, EventArgs e)
        {
            // Atidaro spausdinamo puslapio moduli
            PrintPreviewDialog dialog = new PrintPreviewDialog();
            dialog.Document = printDocument;
            dialog.ShowDialog();

        }

        private void printDocument_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            // Titulinis
            e.Graphics.DrawString("SANDĖLIO VALDYMO SISTEMA", new Font("Century Gothic", 25, FontStyle.Bold), Brushes.SeaGreen, new Point(230, 10));
            e.Graphics.DrawString("UŽSAKYMO SANTRAUKA", new Font("Century Gothic", 18, FontStyle.Bold), Brushes.SeaGreen, new Point(300, 45));

            e.Graphics.DrawString("___________________________________________________________________________________________________________________________________________________________________", new Font("Century Gothic", 18, FontStyle.Bold), Brushes.Black, new Point(0, 70));

            e.Graphics.DrawString("Užsakymo ID: " + DataGridOrder.CurrentRow.Cells[1].Value.ToString(), new Font("Century Gothic", 15, FontStyle.Regular), Brushes.Black, new Point(250, 160));
            e.Graphics.DrawString("Data: " + DataGridOrder.CurrentRow.Cells[2].Value.ToString(), new Font("Century Gothic", 15, FontStyle.Regular), Brushes.Black, new Point(25, 160));
            e.Graphics.DrawString("Užsakovo ID: " + DataGridOrder.CurrentRow.Cells[5].Value.ToString(), new Font("Century Gothic", 15, FontStyle.Regular), Brushes.Black, new Point(25, 200));
            e.Graphics.DrawString("Užsakovo Vardas/Pavadinimas: " + DataGridOrder.CurrentRow.Cells[6].Value.ToString(), new Font("Century Gothic", 15, FontStyle.Regular), Brushes.Black, new Point(250, 200));

            e.Graphics.DrawString("-------------------------------------------------------------------------------------------------------------------------------------------------------------------", new Font("Century Gothic", 18, FontStyle.Regular), Brushes.Black, new Point(0, 230));
            e.Graphics.DrawString("Produkto ID |", new Font("Century Gothic", 15, FontStyle.Bold), Brushes.Black, new Point(25, 255));
            e.Graphics.DrawString("Produkto pavadinimas |", new Font("Century Gothic", 15, FontStyle.Bold), Brushes.Black, new Point(160, 255));
            e.Graphics.DrawString("Kiekis |", new Font("Century Gothic", 15, FontStyle.Bold), Brushes.Black, new Point(670, 255));
            e.Graphics.DrawString("Kaina |", new Font("Century Gothic", 15, FontStyle.Bold), Brushes.Black, new Point(750, 255));
            e.Graphics.DrawString("-------------------------------------------------------------------------------------------------------------------------------------------------------------------", new Font("Century Gothic", 18, FontStyle.Regular), Brushes.Black, new Point(0, 270));
            //ProdID
            e.Graphics.DrawString(DataGridOrder.CurrentRow.Cells[3].Value.ToString(), new Font("Century Gothic", 15, FontStyle.Regular), Brushes.Black, new Point(80, 300));
            //Prod Pav.
            e.Graphics.DrawString(DataGridOrder.CurrentRow.Cells[4].Value.ToString(), new Font("Century Gothic", 15, FontStyle.Regular), Brushes.Black, new Point(160, 300));
            //Kiekis
            e.Graphics.DrawString(DataGridOrder.CurrentRow.Cells[7].Value.ToString(), new Font("Century Gothic", 15, FontStyle.Regular), Brushes.Black, new Point(690, 300));
            //Kaina
            e.Graphics.DrawString(DataGridOrder.CurrentRow.Cells[8].Value.ToString() + "€", new Font("Century Gothic", 15, FontStyle.Regular), Brushes.Black, new Point(760, 300));

            e.Graphics.DrawString("-----------------------------------", new Font("Century Gothic", 18, FontStyle.Regular), Brushes.Black, new Point(540, 340));
            e.Graphics.DrawString("Suma: ", new Font("Century Gothic", 15, FontStyle.Bold), Brushes.Black, new Point(660, 375));
            e.Graphics.DrawString(DataGridOrder.CurrentRow.Cells[9].Value.ToString() + "€", new Font("Century Gothic", 15, FontStyle.Regular), Brushes.Black, new Point(760, 375));
            e.Graphics.DrawString("-----------------------------------", new Font("Century Gothic", 18, FontStyle.Regular), Brushes.Black, new Point(540, 400));


            e.Graphics.DrawString("___________________________________________________________________________________________________________________________________________________________________", new Font("Century Gothic", 18, FontStyle.Regular), Brushes.Black, new Point(0, 1050));
            e.Graphics.DrawString("@ Sandėlio Valdymo Sistema, Vilnius", new Font("Century Gothic", 10, FontStyle.Regular), Brushes.Black, new Point(0, 1080));
        }

    }
}
