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

namespace ProyectoBDNorthwind_Vacio_Yael_
{
    public partial class FormCustomerCustomerDemo : Form
    {
        public FormCustomerCustomerDemo()
        {
            InitializeComponent();
        }
        private void cerrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void refreshPantalla()
        {
            dataGridViewCCD.DataSource = CustomerCustomerDemoDAL.PresentarRegistroCustomerCustomerDemo();
        }

        private void FormCustomerCustomerDemo_Load(object sender, EventArgs e)
        {
            refreshPantalla();

            string query1 = "select CustomerID, CompanyName from Customers";

            using (SqlConnection conexion = BDGeneral.ObtenerConexion())
            {
                // Crear un adaptador de datos para llenar el DataTable
                SqlDataAdapter adapter = new SqlDataAdapter(query1, conexion);

                // Crear un DataTable para almacenar los resultados
                DataTable dtCategorias = new DataTable();

                // Llenar el DataTable con los resultados de la consulta
                adapter.Fill(dtCategorias);

                // Asignar el DataTable al ComboBox
                boxCustomerID.DataSource = dtCategorias;
                boxCustomerID.DisplayMember = "CompanyName"; // Columna que se muestra en el ComboBox
                boxCustomerID.ValueMember = "CustomerID"; // Valor interno que representa al ítem seleccionado
            }

            string query2 = "select customertypeid, customerdesc from customerdemographics";

            using (SqlConnection conexion = BDGeneral.ObtenerConexion())
            {
                // Crear un adaptador de datos para llenar el DataTable
                SqlDataAdapter adapter = new SqlDataAdapter(query2, conexion);

                // Crear un DataTable para almacenar los resultados
                DataTable dtCategorias = new DataTable();

                // Llenar el DataTable con los resultados de la consulta
                adapter.Fill(dtCategorias);

                // Asignar el DataTable al ComboBox
                boxCustomerTypeID.DataSource = dtCategorias;
                boxCustomerTypeID.DisplayMember = "customerdesc"; // Columna que se muestra en el ComboBox
                boxCustomerTypeID.ValueMember = "customertypeid"; // Valor interno que representa al ítem seleccionado
            }
        }

        private void dataGridViewCCD_SelectionChanged(object sender, EventArgs e)
        {
            boxCustomerID.Text = Convert.ToString(dataGridViewCCD.CurrentRow.Cells["CustomerID"].Value);
            boxCustomerTypeID.Text = Convert.ToString(dataGridViewCCD.CurrentRow.Cells["CustomerTypeID"].Value);
        }

        private void butGuardar_Click(object sender, EventArgs e)
        {
            // Creamos un objeto para la tabla CustomerCustomerDemo
            CustomerCustomerDemo customerCustomerDemo = new CustomerCustomerDemo();

            // Asignamos los valores de los campos del formulario al objeto
            customerCustomerDemo.CustomerID = Convert.ToString(boxCustomerID.SelectedValue); // Suponemos que txtCustomerID es el campo para CustomerID
            customerCustomerDemo.CustomerTypeID = Convert.ToString(boxCustomerTypeID.SelectedValue);  // Suponemos que txtCustomerTypeID es el campo para CustomerTypeID

            // Si se seleccionó una fila en el DataGridView
            if (dataGridViewCCD.SelectedRows.Count == 1)
            {
                string customerID = Convert.ToString(dataGridViewCCD.CurrentRow.Cells["CustomerID"].Value);
                string customerTypeID = Convert.ToString(dataGridViewCCD.CurrentRow.Cells["CustomerTypeID"].Value);

                // Verificamos que CustomerID y CustomerTypeID no sean nulos ni vacíos
                if (!string.IsNullOrEmpty(customerID) && !string.IsNullOrEmpty(customerTypeID))
                {
                    customerCustomerDemo.CustomerID = customerID;
                    customerCustomerDemo.CustomerTypeID = customerTypeID;

                    // Llamamos al método para modificar el registro de CustomerCustomerDemo
                    int result = CustomerCustomerDemoDAL.ModificarCustomerCustomerDemo(customerCustomerDemo);

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
                int result = CustomerCustomerDemoDAL.AgregarCustomerCustomerDemo(customerCustomerDemo);

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
            dataGridViewCCD.CurrentCell = null;
            boxCustomerID.Text = "";
            boxCustomerTypeID.Text = "";
        }

        private void butEliminar_Click(object sender, EventArgs e)
        {
            // Verificar si se ha seleccionado exactamente una fila en el DataGridView
            if (dataGridViewCCD.SelectedRows.Count == 1)
            {
                // Obtener el CustomerID y CustomerTypeID de la fila seleccionada
                string customerID = Convert.ToString(dataGridViewCCD.CurrentRow.Cells["CustomerID"].Value);
                string customerTypeID = Convert.ToString(dataGridViewCCD.CurrentRow.Cells["CustomerTypeID"].Value);

                // Validar si el CustomerID o CustomerTypeID son válidos
                if (string.IsNullOrEmpty(customerID) || string.IsNullOrEmpty(customerTypeID))
                {
                    MessageBox.Show("El CustomerID o CustomerTypeID seleccionado no es válido.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Confirmación antes de proceder con la eliminación
                DialogResult dialogResult = MessageBox.Show(
                    "¿Está seguro de que desea eliminar este cliente y su tipo de cliente?",
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
                        int resultado = CustomerCustomerDemoDAL.EliminarCustomerCustomerDemo(customerID, customerTypeID);

                        // Comprobar si la eliminación fue exitosa
                        if (resultado > 0)
                        {
                            MessageBox.Show("Cliente y tipo de cliente eliminados con éxito", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Error al eliminar el cliente y su tipo de cliente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    catch (Exception ex)
                    {
                        // Manejo de excepciones (por ejemplo, problemas de conexión a la base de datos)
                        MessageBox.Show("Se produjo un error al intentar eliminar el cliente y su tipo de cliente: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                // Mensaje si no se ha seleccionado ninguna fila
                MessageBox.Show("Debe seleccionar un cliente y su tipo de cliente para eliminar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                    case "CustomerID":
                        string customerID = txtBuscar.Text;
                        // Llamar al método en el DAL para buscar por CustomerID
                        dataGridViewCCD.DataSource = CustomerCustomerDemoDAL.BuscarRegistroCustomerID(customerID);
                        break;
                    case "CustomerTypeID":
                        string customerTypeID = txtBuscar.Text;
                        // Llamar al método en el DAL para buscar por CustomerTypeID
                        dataGridViewCCD.DataSource = CustomerCustomerDemoDAL.BuscarRegistroCustomerTypeID(customerTypeID);
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
                case "CustomerID":
                    txtBuscar.Text = "CustomerID";
                    txtBuscar.ForeColor = Color.Gray;
                    break;
                case "CustomerTypeID":
                    txtBuscar.Text = "CustomerTypeID";
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
