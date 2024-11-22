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
    public partial class FormCustomers : Form
    {
        public FormCustomers()
        {
            InitializeComponent();
        }

        private void cerrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void refreshPantallaCustomers()
        {
            dataGridViewCustomers.DataSource = CustomersDAL.PresentarRegistro();
        }

        private void FormCustomers_Load(object sender, EventArgs e)
        {
            refreshPantallaCustomers();
        }

        private void dataGridViewCustomers_SelectionChanged(object sender, EventArgs e)
        {
            txtCustomerID.Text = Convert.ToString(dataGridViewCustomers.CurrentRow.Cells["CustomerID"].Value ?? string.Empty);
            txtCompanyName.Text = Convert.ToString(dataGridViewCustomers.CurrentRow.Cells["CompanyName"].Value ?? string.Empty);
            txtContactName.Text = Convert.ToString(dataGridViewCustomers.CurrentRow.Cells["ContactName"].Value ?? string.Empty);
            txtContactTitle.Text = Convert.ToString(dataGridViewCustomers.CurrentRow.Cells["ContactTitle"].Value ?? string.Empty);
            txtAddress.Text = Convert.ToString(dataGridViewCustomers.CurrentRow.Cells["Address"].Value ?? string.Empty);
            txtCity.Text = Convert.ToString(dataGridViewCustomers.CurrentRow.Cells["City"].Value ?? string.Empty);
            txtRegion.Text = Convert.ToString(dataGridViewCustomers.CurrentRow.Cells["Region"].Value ?? string.Empty);
            txtPostalCode.Text = Convert.ToString(dataGridViewCustomers.CurrentRow.Cells["PostalCode"].Value ?? string.Empty);
            txtCountry.Text = Convert.ToString(dataGridViewCustomers.CurrentRow.Cells["Country"].Value ?? string.Empty);
            txtPhone.Text = Convert.ToString(dataGridViewCustomers.CurrentRow.Cells["Phone"].Value ?? string.Empty);
            txtFax.Text = Convert.ToString(dataGridViewCustomers.CurrentRow.Cells["Fax"].Value ?? string.Empty);
        }

        private void butGuardarCustomer_Click(object sender, EventArgs e)
        {
            // Creamos una nueva instancia de Customers
            Customers customer = new Customers();

            // Asignamos los valores de los controles del formulario a la instancia de Customer
            customer.CustomerID = txtCustomerID.Text;
            customer.CompanyName = txtCompanyName.Text;
            customer.ContactName = txtContactName.Text;
            customer.ContactTitle = txtContactTitle.Text;
            customer.Address = txtAddress.Text;
            customer.City = txtCity.Text;
            customer.Region = txtRegion.Text;
            customer.PostalCode = txtPostalCode.Text;
            customer.Country = txtCountry.Text;
            customer.Phone = txtPhone.Text;
            customer.Fax = txtFax.Text;

            // Verificamos si se ha seleccionado una fila en el DataGridView
            if (dataGridViewCustomers.SelectedRows.Count == 1)
            {
                // Si hay una fila seleccionada, obtenemos el CustomerID para modificar el cliente
                string customerID = Convert.ToString(dataGridViewCustomers.CurrentRow.Cells["CustomerID"].Value);

                if (!string.IsNullOrEmpty(customerID))
                {
                    customer.CustomerID = customerID;

                    // Llamamos al método para modificar el cliente
                    int result = CustomersDAL.ModificarCustomer(customer);

                    if (result > 0)
                    {
                        MessageBox.Show("Éxito al Modificar");
                    }
                    else
                    {
                        MessageBox.Show("Error al Modificar");
                    }
                }
            }
            else
            {
                // Si no hay ninguna fila seleccionada, agregamos un nuevo cliente
                int result = CustomersDAL.AgregarCustomer(customer);

                if (result > 0)
                {
                    MessageBox.Show("Éxito al Guardar");
                }
                else
                {
                    MessageBox.Show("Error al Guardar");
                }
            }

            // Refresca la pantalla de los clientes
            refreshPantallaCustomers();
        }

        private void butNuevoCustomer_Click(object sender, EventArgs e)
        {
            dataGridViewCustomers.CurrentCell = null;
            txtCustomerID.Clear();
            txtCompanyName.Clear();
            txtContactName.Clear();
            txtContactTitle.Clear();
            txtAddress.Clear();
            txtCity.Clear();
            txtRegion.Clear();
            txtPostalCode.Clear();
            txtCountry.Clear();
            txtPhone.Clear();
            txtFax.Clear();
        }

        private void butEliminarCustomer_Click(object sender, EventArgs e)
        {
            // Verificar si se ha seleccionado exactamente una fila en el DataGridView
            if (dataGridViewCustomers.SelectedRows.Count == 1)
            {
                // Obtener el CustomerID de la fila seleccionada
                string customerId = Convert.ToString(dataGridViewCustomers.CurrentRow.Cells["CustomerID"].Value);

                // Confirmación antes de proceder con la eliminación
                DialogResult dialogResult = MessageBox.Show(
                    "¿Está seguro de que desea eliminar este cliente?",
                    "Confirmar Eliminación",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning
                );

                // Si el usuario confirma la eliminación
                if (dialogResult == DialogResult.Yes)
                {
                    try
                    {
                        // Llamar al método para eliminar el cliente
                        int resultado = CustomersDAL.EliminarCustomer(customerId);

                        // Comprobar si la eliminación fue exitosa
                        if (resultado > 0)
                        {
                            MessageBox.Show("Cliente eliminado con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("No se pudo eliminar el cliente. Intente nuevamente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    catch (Exception ex)
                    {
                        // Manejo de excepciones
                        MessageBox.Show("Se produjo un error al intentar eliminar el cliente: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                // Si no se ha seleccionado ninguna fila
                MessageBox.Show("Debe seleccionar un cliente para eliminar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            // Refrescar la pantalla después de la eliminación para actualizar los datos en el DataGridView
            refreshPantallaCustomers();
        }

        private void butBuscarCustomer_Click(object sender, EventArgs e)
        {
            try
            {
                switch (boxBuscarCustomers.Text)
                {
                    case "CustomerID":
                        string customerID = txtBuscarCustomers.Text;
                        dataGridViewCustomers.DataSource = CustomersDAL.BuscarRegistroCustomerID(customerID);
                        break;
                    case "CompanyName":
                        string companyName = txtBuscarCustomers.Text;
                        dataGridViewCustomers.DataSource = CustomersDAL.BuscarRegistroCompanyName(companyName);
                        break;
                    case "ContactName":
                        string contactName = txtBuscarCustomers.Text;
                        dataGridViewCustomers.DataSource = CustomersDAL.BuscarRegistroContactName(contactName);
                        break;
                    case "ContactTitle":
                        string contactTitle = txtBuscarCustomers.Text;
                        dataGridViewCustomers.DataSource = CustomersDAL.BuscarRegistroContactTitle(contactTitle);
                        break;
                    case "Address":
                        string address = txtBuscarCustomers.Text;
                        dataGridViewCustomers.DataSource = CustomersDAL.BuscarRegistroAddress(address);
                        break;
                    case "City":
                        string city = txtBuscarCustomers.Text;
                        dataGridViewCustomers.DataSource = CustomersDAL.BuscarRegistroCity(city);
                        break;
                    case "Region":
                        string region = txtBuscarCustomers.Text;
                        dataGridViewCustomers.DataSource = CustomersDAL.BuscarRegistroRegion(region);
                        break;
                    case "PostalCode":
                        string postalCode = txtBuscarCustomers.Text;
                        dataGridViewCustomers.DataSource = CustomersDAL.BuscarRegistroPostalCode(postalCode);
                        break;
                    case "Country":
                        string country = txtBuscarCustomers.Text;
                        dataGridViewCustomers.DataSource = CustomersDAL.BuscarRegistroCountry(country);
                        break;
                    case "Phone":
                        string phone = txtBuscarCustomers.Text;
                        dataGridViewCustomers.DataSource = CustomersDAL.BuscarRegistroPhone(phone);
                        break;
                    default:
                        MessageBox.Show("Seleccione un criterio de búsqueda válido.");
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al Buscar: " + ex.Message);
            }
        }

        private void butRefrescarCustomer_Click(object sender, EventArgs e)
        {
            refreshPantallaCustomers();
        }
    }
}
