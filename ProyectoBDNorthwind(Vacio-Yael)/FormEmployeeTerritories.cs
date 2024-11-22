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
    public partial class FormEmployeeTerritories : Form
    {
        public FormEmployeeTerritories()
        {
            InitializeComponent();
        }

        private void cerrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void refreshPantallaET()
        {
            dataGridViewET.DataSource = EmployeeTerritoriesDAL.PresentarRegistroEmployeeTerritories();
        }

        private void FormEmployeeTerritories_Load(object sender, EventArgs e)
        {
            refreshPantallaET();
        }

        private void dataGridViewET_SelectionChanged(object sender, EventArgs e)
        {
            txtEmployeeID.Text = Convert.ToString(dataGridViewET.CurrentRow.Cells["EmployeeID"].Value);
            txtTerritoryID.Text = Convert.ToString(dataGridViewET.CurrentRow.Cells["TerritoryID"].Value);
        }

        private void butGuardar_Click(object sender, EventArgs e)
        {
            EmployeeTerritories employeeTerritories = new EmployeeTerritories();

            employeeTerritories.EmployeeID = Convert.ToInt32(txtEmployeeID.Text);
            employeeTerritories.TerritoryID = txtTerritoryID.Text;


            if (dataGridViewET.SelectedRows.Count == 1)
            {

                int EmployeeID = Convert.ToInt32(dataGridViewET.CurrentRow.Cells["EmployeeID"].Value);
                string TerritoryID = Convert.ToString(dataGridViewET.CurrentRow.Cells["TerritoryID"].Value);

                if (EmployeeID != null)
                {
                    employeeTerritories.EmployeeID = EmployeeID;
                    employeeTerritories.TerritoryID = TerritoryID;
                    int result = EmployeeTerritoriesDAL.ModificarEmployeeTerritories(employeeTerritories);

                    if (result > 0)
                    {
                        MessageBox.Show("Exito al Modificar");
                    }
                    else
                    {
                        MessageBox.Show("Error al Modificar");
                    }
                }
            }

            else
            {
                int result = EmployeeTerritoriesDAL.AgregarEmployeeTerritories(employeeTerritories);

                if (result > 0)
                {
                    MessageBox.Show("Exito al Guardar");
                }
            }
            refreshPantallaET();
        }

        private void butNuevo_Click(object sender, EventArgs e)
        {
            dataGridViewET.CurrentCell = null;
            txtEmployeeID.Clear();
            txtTerritoryID.Clear();
        }

        private void butEliminar_Click(object sender, EventArgs e)
        {
            // Verificar si se ha seleccionado exactamente una fila en el DataGridView
            if (dataGridViewET.SelectedRows.Count == 1)
            {
                // Obtener el EmployeeID y TerritoryID de la fila seleccionada
                int employeeID = Convert.ToInt32(dataGridViewET.CurrentRow.Cells["EmployeeID"].Value);
                string territoryID = Convert.ToString(dataGridViewET.CurrentRow.Cells["TerritoryID"].Value);

                // Confirmación antes de proceder con la eliminación
                DialogResult dialogResult = MessageBox.Show(
                    "¿Está seguro de que desea eliminar esta asignación de territorio al empleado?",
                    "Confirmar Eliminación",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning
                );

                // Si el usuario confirma la eliminación
                if (dialogResult == DialogResult.Yes)
                {
                    try
                    {
                        // Llamar al método de eliminación en el DAL (Data Access Layer)
                        int resultado = EmployeeTerritoriesDAL.EliminarEmployeeTerritories(employeeID, territoryID);

                        // Comprobar si la eliminación fue exitosa
                        if (resultado > 0)
                        {
                            MessageBox.Show("Asignación eliminada con éxito", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Error al eliminar la asignación", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    catch (Exception ex)
                    {
                        // Manejo de excepciones (por ejemplo, problemas de conexión a la base de datos)
                        MessageBox.Show("Se produjo un error al intentar eliminar la asignación: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                // Mensaje si no se ha seleccionado ninguna fila
                MessageBox.Show("Debe seleccionar una asignación de empleado a territorio para eliminar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            // Refrescar la pantalla después de la eliminación para actualizar los datos en el DataGridView
            refreshPantallaET();
        }


        private void butBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                switch (boxBuscar.Text)
                {
                    case "EmployeeID":
                        int EmployeeID = Convert.ToInt32(txtBuscarET.Text);
                        dataGridViewET.DataSource = EmployeeTerritoriesDAL.BuscarRegistroEmployeeID(EmployeeID);
                        break;
                    case "TerritoryID":
                        string TerritoryID = txtBuscarET.Text;
                        dataGridViewET.DataSource = EmployeeTerritoriesDAL.BuscarRegistroTerritoryID(TerritoryID);
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al Buscar");
            }
        }

        private void butRefrescar_Click(object sender, EventArgs e)
        {
            refreshPantallaET();
        }

        private void boxBuscarET_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (boxBuscar.Text)
            {
                case "EmployeeID":
                    txtBuscarET.Text = "EmployeeID";
                    txtBuscarET.ForeColor = Color.Gray;
                    break;
                case "TerritoryID":
                    txtBuscarET.Text = "TerritoryID";
                    txtBuscarET.ForeColor = Color.Gray;
                    break;
            }
        }

        private void txtBuscarET_Enter(object sender, EventArgs e)
        {
            txtBuscarET.Text = "";
            txtBuscarET.ForeColor = Color.Black;
        }
    }
}

