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
    public partial class Form_Inicio_Admin : Form
    {
        public Form_Inicio_Admin()
        {
            InitializeComponent();
        }



        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cerrarSesionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormLOGIN formLOGIN = new FormLOGIN();
            formLOGIN.Show();
        }

        private void ordersToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            FormOrders formOrders = new FormOrders();
            formOrders.Show();
        }

        private void orderDetailsToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            FormOrderDetails formOrderDetails = new FormOrderDetails();
            formOrderDetails.Show();
        }

        private void productsToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            FormProducts formProducts = new FormProducts();
            formProducts.Show();
        }

        private void categoriesToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            FormCategory formCategories = new FormCategory();
            formCategories.Show();
        }

        private void employeesToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            FormEmployees formEmployees = new FormEmployees();
            formEmployees.Show();
        }

        private void employeeTerritoriesToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            FormEmployeeTerritories formEmployeeTerritories = new FormEmployeeTerritories();
            formEmployeeTerritories.Show();
        }

        private void suppliersToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            FormSuppliers formSuppliers = new FormSuppliers();
            formSuppliers.Show();
        }

        private void shippersToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            FormShippers formShippers = new FormShippers();
            formShippers.Show();
        }

        private void territoriesToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            FormTerritories formTerritories = new FormTerritories();
            formTerritories.Show();
        }

        private void regionToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            FormRegion formRegion = new FormRegion();
            formRegion.Show();
        }

        private void customersToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            FormCustomers formCustomers = new FormCustomers();
            formCustomers.Show();
        }

        private void customerDemographicsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormCustomerDemographics formCustomerDemographics = new FormCustomerDemographics();
            formCustomerDemographics.Show();
        }

        private void customerCustomerDemoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormCustomerCustomerDemo formCustomerCustomerDemo = new FormCustomerCustomerDemo();
            formCustomerCustomerDemo.Show();
        }
    }
}
