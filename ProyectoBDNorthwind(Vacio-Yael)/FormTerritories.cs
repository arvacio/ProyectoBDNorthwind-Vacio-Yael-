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
    public partial class FormTerritories : Form
    {
        public FormTerritories()
        {
            InitializeComponent();
        }

        private void cerrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void refreshPantalla()
        {
            dataGridViewTerritories.DataSource = TerritoriesDAL.PresentarRegistroTerritories();
        }

        private void FormTerritories_Load(object sender, EventArgs e)
        {
            refreshPantalla();
        }

        private void dataGridViewTerritory_SelectionChanged(object sender, EventArgs e)
        {
            txtTerritoryID.Text = Convert.ToString(dataGridViewTerritories.CurrentRow.Cells["TerritoryID"].Value);
            txtTerritoryDes.Text = Convert.ToString(dataGridViewTerritories.CurrentRow.Cells["TerritoryDescription"].Value);
            txtRegionID.Text = Convert.ToString(dataGridViewTerritories.CurrentRow.Cells["RegionID"].Value);
        }

        private void butGuardar_Click(object sender, EventArgs e)
        {
            // Creamos un objeto para la tabla Territories
            Territories territory = new Territories();

            // Asignamos los valores de los campos del formulario al objeto
            territory.TerritoryID = txtTerritoryID.Text;
            territory.TerritoryDescription = txtTerritoryDes.Text;
            territory.RegionID = Convert.ToInt32(txtRegionID.Text);

            // Si se seleccionó una fila en el DataGridView
            if (dataGridViewTerritories.SelectedRows.Count == 1)
            {
                string territoryID = Convert.ToString(dataGridViewTerritories.CurrentRow.Cells["TerritoryID"].Value);

                if (territoryID != null)
                {
                    territory.TerritoryID = territoryID;
                    int result = TerritoriesDAL.ModificarTerritories(territory);

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
                int result = TerritoriesDAL.AgregarTerritory(territory);

                if (result > 0)
                {
                    MessageBox.Show("Éxito al Guardar");
                }
            }
            refreshPantalla();
        }

        private void butNuevo_Click(object sender, EventArgs e)
        {
            dataGridViewTerritories.CurrentCell = null;
            txtTerritoryID.Clear();
            txtTerritoryDes.Clear();
            txtRegionID.Clear();
        }

        private void butEliminar_Click(object sender, EventArgs e)
        {
            // Verificar si se ha seleccionado exactamente una fila en el DataGridView
            if (dataGridViewTerritories.SelectedRows.Count == 1)
            {
                // Obtener el TerritoryID de la fila seleccionada
                string territoryID = Convert.ToString(dataGridViewTerritories.CurrentRow.Cells["TerritoryID"].Value);

                // Confirmación antes de proceder con la eliminación
                DialogResult dialogResult = MessageBox.Show(
                    "¿Está seguro de que desea eliminar este territorio?",
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
                        int resultado = TerritoriesDAL.EliminarTerritory(territoryID);

                        // Comprobar si la eliminación fue exitosa
                        if (resultado > 0)
                        {
                            MessageBox.Show("Territorio Eliminado con Éxito", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Error al Eliminar el Territorio", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    catch (Exception ex)
                    {
                        // Manejo de excepciones (por ejemplo, problemas de conexión a la base de datos)
                        MessageBox.Show("Se produjo un error al intentar eliminar el territorio: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                // Mensaje si no se ha seleccionado ninguna fila
                MessageBox.Show("Debe seleccionar un territorio para eliminar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            // Refrescar la pantalla después de la eliminación para actualizar los datos en el DataGridView
            refreshPantalla();
        }

        private void butBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                switch (boxBuscarTerritory.Text)
                {
                    case "TerritoryID":
                        string TerritoryID = txtBuscarTerritory.Text;
                        dataGridViewTerritories.DataSource = TerritoriesDAL.BuscarRegistroTerritoryID(TerritoryID);
                        break;
                    case "TerritoryDescription":
                        string TerritoryDescription = txtBuscarTerritory.Text;
                        dataGridViewTerritories.DataSource = TerritoriesDAL.BuscarRegistroTerritoryDescription(TerritoryDescription);
                        break;
                    case "RegionID":
                        int RegionID = Convert.ToInt32(txtBuscarTerritory.Text);
                        dataGridViewTerritories.DataSource = TerritoriesDAL.BuscarRegistroRegionID(RegionID);
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
            txtBuscarTerritory.Text = "";
            boxBuscarTerritory.Text = "";
        }

        private void boxBuscarTerritory_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (boxBuscarTerritory.Text)
            {
                case "TerritoryID":
                    txtBuscarTerritory.Text = "TerritoryID";
                    txtBuscarTerritory.ForeColor = Color.Gray;
                    break;
                case "TerritoryDescription":
                    txtBuscarTerritory.Text = "TerritoryDescription";
                    txtBuscarTerritory.ForeColor = Color.Gray;
                    break;
                case "RegionID":
                    txtBuscarTerritory.Text = "RegionID";
                    txtBuscarTerritory.ForeColor = Color.Gray;
                    break;
            }
        }

        private void txtBuscarTerritory_Enter(object sender, EventArgs e)
        {
            txtBuscarTerritory.Text = "";
            txtBuscarTerritory.ForeColor = Color.Black;
        }
    }
}
