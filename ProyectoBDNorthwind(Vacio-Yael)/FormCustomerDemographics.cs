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
    public partial class FormCustomerDemographics : Form
    {
        public FormCustomerDemographics()
        {
            InitializeComponent();
        }

        private void cerrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void refreshPantalla()
        {
            dataGridViewCD.DataSource = CustomerDemographicsDAL.PresentarRegistroCustomerDemographics();
        }

        private void FormCustomerDemographics_Load(object sender, EventArgs e)
        {
            refreshPantalla();
        }

        private void dataGridViewCD_SelectionChanged(object sender, EventArgs e)
        {
            txtCTID.Text = Convert.ToString(dataGridViewCD.CurrentRow.Cells["CustomerTypeID"].Value);
            txtCDES.Text = Convert.ToString(dataGridViewCD.CurrentRow.Cells["CustomerDesc"].Value);
        }

        private void butGuardar_Click(object sender, EventArgs e)
        {
            // Creamos un objeto para la tabla CustomerDemographics
            CustomerDemographics customerDemographics = new CustomerDemographics();

            // Asignamos los valores de los campos del formulario al objeto
            customerDemographics.CustomerTypeID = txtCTID.Text;
            customerDemographics.CustomerDesc = txtCDES.Text;

            // Si se seleccionó una fila en el DataGridView
            if (dataGridViewCD.SelectedRows.Count == 1)
            {
                string customerTypeID = Convert.ToString(dataGridViewCD.CurrentRow.Cells["CustomerTypeID"].Value);

                // Verificamos que el CustomerTypeID no sea nulo
                if (!string.IsNullOrEmpty(customerTypeID))
                {
                    customerDemographics.CustomerTypeID = customerTypeID;

                    // Llamamos al método para modificar el registro de CustomerDemographics
                    int result = CustomerDemographicsDAL.ModificarCustomerDemographics(customerDemographics);

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
                // Si no se seleccionó ninguna fila, agregamos un nuevo registro
                int result = CustomerDemographicsDAL.AgregarCustomerDemographics(customerDemographics);

                if (result > 0)
                {
                    MessageBox.Show("Éxito al Guardar");
                }
                else
                {
                    MessageBox.Show("Error al Guardar");
                }
            }

            // Refrescamos la pantalla para actualizar el DataGridView
            refreshPantalla();
        }

        private void butNuevo_Click(object sender, EventArgs e)
        {
            dataGridViewCD.CurrentCell = null;
            txtCTID.Clear();
            txtCDES.Clear();
        }

        private void butEliminar_Click(object sender, EventArgs e)
        {
            // Verificar si se ha seleccionado exactamente una fila en el DataGridView
            if (dataGridViewCD.SelectedRows.Count == 1)
            {
                // Obtener el CustomerTypeID de la fila seleccionada
                string customerTypeID = Convert.ToString(dataGridViewCD.CurrentRow.Cells["CustomerTypeID"].Value);

                // Validar si el CustomerTypeID es válido
                if (string.IsNullOrEmpty(customerTypeID))
                {
                    MessageBox.Show("El CustomerTypeID seleccionado no es válido.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Confirmación antes de proceder con la eliminación
                DialogResult dialogResult = MessageBox.Show(
                    "¿Está seguro de que desea eliminar este tipo de cliente?",
                    "Confirmar Eliminación",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning
                );

                // Si el usuario confirma la eliminación
                if (dialogResult == DialogResult.Yes)
                {
                    try
                    {
                        // Llamar al método de eliminación en el DAL
                        int resultado = CustomerDemographicsDAL.EliminarCustomerDemographics(customerTypeID);

                        // Comprobar si la eliminación fue exitosa
                        if (resultado > 0)
                        {
                            MessageBox.Show("Tipo de cliente eliminado con éxito", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Error al eliminar el tipo de cliente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    catch (Exception ex)
                    {
                        // Manejo de excepciones (por ejemplo, problemas de conexión a la base de datos)
                        MessageBox.Show("Se produjo un error al intentar eliminar el tipo de cliente: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                // Mensaje si no se ha seleccionado ninguna fila
                MessageBox.Show("Debe seleccionar un tipo de cliente para eliminar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            // Refrescar la pantalla después de la eliminación para actualizar los datos en el DataGridView
            refreshPantalla();
        }

        private void butBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                // Verificar el criterio de búsqueda seleccionado
                switch (boxBuscar.Text)
                {
                    case "CustomerTypeID":
                        string CustomerTypeID = txtBuscar.Text;
                        dataGridViewCD.DataSource = CustomerDemographicsDAL.BuscarRegistroCustomerTypeID(CustomerTypeID);
                        break;
                    case "CustomerDescription":
                        string CustomerDesc = txtBuscar.Text;
                        dataGridViewCD.DataSource = CustomerDemographicsDAL.BuscarRegistroCustomerTypeID(CustomerDesc);
                        break;
                    default:
                        MessageBox.Show("Seleccione un criterio de búsqueda válido.");
                        break;
                }
            }
            catch (Exception ex)
            {
                // Manejo de excepciones
                MessageBox.Show("Error al Buscar: " + ex.Message);
            }
        }

        private void boxBuscar_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (boxBuscar.Text)
            {
                case "CustomerTypeID":
                    txtBuscar.Text = "CustomerTypeID";
                    txtBuscar.ForeColor = Color.Gray;
                    break;
                case "CustomerDescription":
                    txtBuscar.Text = "CustomerDescription";
                    txtBuscar.ForeColor = Color.Gray;
                    break;
            }
        }

        private void butRefrescar_Click(object sender, EventArgs e)
        {
            refreshPantalla();
            txtBuscar.Text = "";
            txtBuscar.ForeColor = Color.Black;
        }

        private void txtBuscar_Enter(object sender, EventArgs e)
        {
            txtBuscar.Text = "";
            txtBuscar.ForeColor = Color.Black;
        }
    }
}
