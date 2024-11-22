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
    public partial class FormShippers : Form
    {
        public FormShippers()
        {
            InitializeComponent();
        }

        private void cerrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void refreshPantalla()
        {
            dataGridViewShippers.DataSource = ShippersDAL.PresentarRegistroShippers();
        }

        private void FormShippers_Load(object sender, EventArgs e)
        {
            refreshPantalla();
            txtShipperID.Enabled = false;
        }

        private void dataGridViewShippers_SelectionChanged(object sender, EventArgs e)
        {
            txtShipperID.Text = Convert.ToString(dataGridViewShippers.CurrentRow.Cells["ShipperID"].Value);
            txtCompanyName.Text = Convert.ToString(dataGridViewShippers.CurrentRow.Cells["CompanyName"].Value);
            txtPhone.Text = Convert.ToString(dataGridViewShippers.CurrentRow.Cells["Phone"].Value);
        }



        private void butNuevo_Click(object sender, EventArgs e)
        {
            dataGridViewShippers.CurrentCell = null;
            txtShipperID.Clear();
            txtCompanyName.Clear();
            txtPhone.Clear();

        }

        private void butGuardar_Click(object sender, EventArgs e)
        {
            // Creamos un objeto para la tabla Shippers
            Shippers shipper = new Shippers();

            // Asignamos los valores de los campos del formulario al objeto
            shipper.CompanyName = txtCompanyName.Text;
            shipper.Phone = txtPhone.Text;

            // Si se seleccionó una fila en el DataGridView
            if (dataGridViewShippers.SelectedRows.Count == 1)
            {
                // Obtenemos el ShipperID de la fila seleccionada
                int shipperID = Convert.ToInt32(dataGridViewShippers.CurrentRow.Cells["ShipperID"].Value);

                if (shipperID != 0)
                {
                    // Modificamos el ShipperID del objeto para la modificación
                    shipper.ShipperID = shipperID;

                    // Llamamos al método ModificarShipper para actualizar el registro
                    int result = ShippersDAL.ModificarShippers(shipper);

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
                // Si no hay fila seleccionada, agregamos un nuevo registro
                int result = ShippersDAL.AgregarShipper(shipper);

                if (result > 0)
                {
                    MessageBox.Show("Éxito al Guardar");
                }
                else
                {
                    MessageBox.Show("Error al Guardar");
                }
            }

            // Llamamos a un método para refrescar los controles (opcional)
            refreshPantalla();
        }

        private void butEliminar_Click(object sender, EventArgs e)
        {
            // Verificar si se ha seleccionado exactamente una fila en el DataGridView
            if (dataGridViewShippers.SelectedRows.Count == 1)
            {
                // Obtener el ShipperID de la fila seleccionada
                int shipperID = Convert.ToInt32(dataGridViewShippers.CurrentRow.Cells["ShipperID"].Value);

                // Confirmación antes de proceder con la eliminación
                DialogResult dialogResult = MessageBox.Show(
                    "¿Está seguro de que desea eliminar este transportista?",
                    "Confirmar Eliminación",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning
                );

                // Si el usuario confirma la eliminación
                if (dialogResult == DialogResult.Yes)
                {
                    try
                    {
                        // Llamar al método de eliminación en el DAL (capa de acceso a datos)
                        int resultado = ShippersDAL.EliminarShipper(shipperID);

                        // Comprobar si la eliminación fue exitosa
                        if (resultado > 0)
                        {
                            MessageBox.Show("Transportista Eliminado con Éxito", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Error al Eliminar el Transportista", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    catch (Exception ex)
                    {
                        // Manejo de excepciones (por ejemplo, problemas de conexión a la base de datos)
                        MessageBox.Show("Se produjo un error al intentar eliminar el transportista: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                // Mensaje si no se ha seleccionado ninguna fila o si se seleccionaron varias
                MessageBox.Show("Debe seleccionar un transportista para eliminar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            // Refrescar la pantalla después de la eliminación para actualizar los datos en el DataGridView
            refreshPantalla();
        }

        private void butBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                switch (boxBuscarShippers.Text)
                {
                    case "ShipperID":
                        int shipperID = Convert.ToInt32(txtBuscarShippers.Text);
                        dataGridViewShippers.DataSource = ShippersDAL.BuscarRegistroShipperID(shipperID);
                        break;

                    case "CompanyName":
                        string companyName = txtBuscarShippers.Text;
                        dataGridViewShippers.DataSource = ShippersDAL.BuscarRegistroCompanyName(companyName);
                        break;

                    case "Phone":
                        string phone = txtBuscarShippers.Text;
                        dataGridViewShippers.DataSource = ShippersDAL.BuscarRegistroPhone(phone);
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

        private void butRefrescar_Click(object sender, EventArgs e)
        {
            refreshPantalla();
            txtBuscarShippers.Text = "";
            boxBuscarShippers.Text = "";
        }

        private void boxBuscarShippers_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (boxBuscarShippers.Text)
            {
                case "ShipperID":
                    txtBuscarShippers.Text = "ShipperID";
                    txtBuscarShippers.ForeColor = Color.Gray;
                    break;

                case "CompanyName":
                    txtBuscarShippers.Text = "CompanyName";
                    txtBuscarShippers.ForeColor = Color.Gray;
                    break;

                case "Phone":
                    txtBuscarShippers.Text = "Phone";
                    txtBuscarShippers.ForeColor = Color.Gray;
                    break;
            }
        }

        private void txtBuscarShippers_Enter(object sender, EventArgs e)
        {
            txtBuscarShippers.Text = "";
            txtBuscarShippers.ForeColor = Color.Black;
        }
    }
}
