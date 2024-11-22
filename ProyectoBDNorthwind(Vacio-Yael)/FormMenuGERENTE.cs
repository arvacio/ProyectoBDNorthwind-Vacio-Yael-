using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoBDNorthwind_Vacio_Yael_
{
    public partial class FormMenuGERENTE : Form
    {
        public FormMenuGERENTE()
        {
            InitializeComponent();
        }


        private void customersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormCustomers formCustomers = new FormCustomers();
            formCustomers.ShowDialog();
        }

        private void ordersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormOrders formOrders = new FormOrders();
            formOrders.ShowDialog();
        }

        private void productsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormProducts formProducts = new FormProducts();
            formProducts.ShowDialog();
        }

        private void territoriesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormTerritories formTerritories = new FormTerritories();
            formTerritories.ShowDialog();
        }

        private void employeesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormEmployees formEmployees = new FormEmployees();
            formEmployees.ShowDialog();
        }

        private void regionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormRegion formRegion = new FormRegion();
            formRegion.ShowDialog();
        }

        private void categoriesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormCategory formCategory = new FormCategory();
            formCategory.ShowDialog();
        }

        private void shippersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormShippers formShippers = new FormShippers();
            formShippers.ShowDialog();
        }


        private void salirToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cerrarSesionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormLOGIN formLOGIN = new FormLOGIN();
            formLOGIN.ShowDialog();
        }
    }
}
