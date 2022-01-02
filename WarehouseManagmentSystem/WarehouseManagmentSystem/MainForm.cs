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
    public partial class MainForm : Form
    {

        public MainForm()
        {
            InitializeComponent();
        }

        // 12-01 Admin arba User tipas
        public static string type;

        // rodomi duomenis iš duomenų bazės
        private Form activeForm = null;
        private void OpenChildForm(Form childform)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childform;
            childform.TopLevel = false;
            childform.FormBorderStyle = FormBorderStyle.None;
            childform.Dock = DockStyle.Fill;
            panelMain.Controls.Add(childform);
            panelMain.Tag = childform;
            childform.BringToFront();
            childform.Show();


        }

        private void UsersButton_Click(object sender, EventArgs e)
        {
            if (type == "A")
            {
                OpenChildForm(new UserForm());
            }
            else if (type == "U")
            {
                MessageBox.Show("NETURITE ADMINISTRACINIŲ PRIVILEGIJŲ ", " PRIEIGA UŽDRAUSTA ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void CustomerButton_Click(object sender, EventArgs e)
        {
            OpenChildForm(new CustomerForm());
        }

        private void CategoriesButton_Click(object sender, EventArgs e)
        {
            OpenChildForm(new CategoryForm());
        }

        private void ProductButton_Click(object sender, EventArgs e)
        {
            OpenChildForm(new ProductForm());
        }

        private void OrdersButton_Click(object sender, EventArgs e)
        {
            OpenChildForm(new OrderForm());
        }

        private void Disconnect_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm login = new LoginForm();
            login.ShowDialog();
        }
    }
}
