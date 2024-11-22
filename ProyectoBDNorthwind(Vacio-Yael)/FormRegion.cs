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
    public partial class FormRegion : Form
    {
        public FormRegion()
        {
            InitializeComponent();
        }

        private void cerrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void refreshPantalla()
        {
            dataGridViewRegion.DataSource = RegionDAL.PresentarRegistroRegion();
        }

        private void FormRegion_Load(object sender, EventArgs e)
        {
            refreshPantalla();
        }

        private void dataGridViewRegion_SelectionChanged(object sender, EventArgs e)
        {
            txtRegionID.Text = Convert.ToString(dataGridViewRegion.CurrentRow.Cells["RegionID"].Value);
            txtRegionDescription.Text = Convert.ToString(dataGridViewRegion.CurrentRow.Cells["RegionDescription"].Value);
        }

        private void butGuardar_Click(object sender, EventArgs e)
        {
            // Creamos un objeto para la tabla Region
            Region region = new Region();

            // Asignamos los valores de los campos del formulario al objeto
            region.RegionID = Convert.ToInt32(txtRegionID.Text);
            region.RegionDescription = txtRegionDescription.Text;

            // Si se seleccionó una fila en el DataGridView
            if (dataGridViewRegion.SelectedRows.Count == 1)
            {
                int regionID = Convert.ToInt32(dataGridViewRegion.CurrentRow.Cells["RegionID"].Value);

                // Verificamos que el ID de la región no sea nulo
                if (regionID > 0)
                {
                    region.RegionID = regionID;

                    // Llamamos al método para modificar el registro de la región
                    int result = RegionDAL.ModificarRegion(region);

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
                int result = RegionDAL.AgregarRegion(region);

                if (result > 0)
                {
                    MessageBox.Show("Éxito al Guardar");
                }
                else
                {
                    MessageBox.Show("Error al Guardar");
                }
            }
            refreshPantalla();
        }

        private void butNuevo_Click(object sender, EventArgs e)
        {
            dataGridViewRegion.CurrentCell = null;
            txtRegionID.Clear();
            txtRegionDescription.Clear();
        }

        private void butEliminar_Click(object sender, EventArgs e)
        {
            // Verificar si se ha seleccionado exactamente una fila en el DataGridView
            if (dataGridViewRegion.SelectedRows.Count == 1)
            {
                // Obtener el RegionID de la fila seleccionada
                int regionID = Convert.ToInt32(dataGridViewRegion.CurrentRow.Cells["RegionID"].Value);

                // Confirmación antes de proceder con la eliminación
                DialogResult dialogResult = MessageBox.Show(
                    "¿Está seguro de que desea eliminar esta región?",
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
                        int resultado = RegionDAL.EliminarRegion(regionID);

                        // Comprobar si la eliminación fue exitosa
                        if (resultado > 0)
                        {
                            MessageBox.Show("Región Eliminada con Éxito", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Error al Eliminar la Región", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    catch (Exception ex)
                    {
                        // Manejo de excepciones (por ejemplo, problemas de conexión a la base de datos)
                        MessageBox.Show("Se produjo un error al intentar eliminar la región: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                // Mensaje si no se ha seleccionado ninguna fila
                MessageBox.Show("Debe seleccionar una región para eliminar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            // Refrescar la pantalla después de la eliminación para actualizar los datos en el DataGridView
            refreshPantalla();
        }

        private void butBuscar_Click_1(object sender, EventArgs e)
        {
            try
            {
                // Verificar el criterio de búsqueda seleccionado
                switch (boxBuscarRegion.Text)
                {
                    case "RegionID":
                        // Buscar por RegionID
                        int regionID = Convert.ToInt32(txtBuscarRegion.Text);
                        dataGridViewRegion.DataSource = RegionDAL.BuscarRegistroRegionID(regionID);
                        break;
                    case "RegionDescription":
                        // Buscar por RegionDescription
                        string regionDescription = txtBuscarRegion.Text;
                        dataGridViewRegion.DataSource = RegionDAL.BuscarRegistroRegionDescription(regionDescription);
                        break;
                    default:
                        // Mensaje si no se ha seleccionado un criterio válido
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
        private void butRefrescar_Click(object sender, EventArgs e)
        {
            refreshPantalla();
            txtBuscarRegion.Text = "";
            boxBuscarRegion.Text = "";
        }

        private void boxBuscarRegion_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (boxBuscarRegion.Text)
            {
                case "RegionID":
                    txtBuscarRegion.Text = "RegionID";
                    txtBuscarRegion.ForeColor = Color.Gray;
                    break;
                case "RegionDescription":
                    txtBuscarRegion.Text = "RegionDescription";
                    txtBuscarRegion.ForeColor = Color.Gray;
                    break;
            }
        }

        private void txtBuscarRegion_Enter(object sender, EventArgs e)
        {
            txtBuscarRegion.Text = "";
            txtBuscarRegion.ForeColor = Color.Black;
        }

    }
}
