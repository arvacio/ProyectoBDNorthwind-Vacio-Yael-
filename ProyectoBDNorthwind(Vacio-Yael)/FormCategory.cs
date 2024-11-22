using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoBDNorthwind_Vacio_Yael_
{
    public partial class FormCategory : Form
    {
        public FormCategory()
        {
            InitializeComponent();
        }

        private void cerrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void refreshPantalla()
        {
            dataGridViewCategories.DataSource = CategoriesDAL.PresentarRegistro();
        }

        private void FormCategory_Load(object sender, EventArgs e)
        {
            refreshPantalla();
            txtCategoryID.Enabled = false;
        }

        private void dataGridViewCategories_SelectionChanged(object sender, EventArgs e)
        {
            txtCategoryID.Text = Convert.ToString(dataGridViewCategories.CurrentRow.Cells["CategoryID"].Value);
            txtCategoryName.Text = Convert.ToString(dataGridViewCategories.CurrentRow.Cells["CategoryName"].Value);
            txtDescription.Text = Convert.ToString(dataGridViewCategories.CurrentRow.Cells["Description"].Value);

            //// Si la columna "Picture" contiene una imagen, la asignamos a un PictureBox (o similar)
            //if (dataGridViewCategories.CurrentRow.Cells["Picture"].Value != DBNull.Value)
            //{
            //    byte[] imageBytes = (byte[])dataGridViewCategories.CurrentRow.Cells["Picture"].Value;
            //    MemoryStream ms = new MemoryStream(imageBytes);
            //    picCategoryPicture.Image = Image.FromStream(ms);  // Asumiendo un PictureBox llamado 'picCategoryPicture'
            //}
            //else
            //{
            //    picCategoryPicture.Image = null;  // Si no hay imagen, dejamos el PictureBox vacío
            //}
        }

        private void butGuardar_Click(object sender, EventArgs e)
        {
            // Crear una nueva instancia de la clase Categories
            Categories category = new Categories();

            // Asignar los valores desde los controles del formulario a la instancia de Categories
            category.CategoryName = txtCategoryName.Text;
            category.Description = txtDescription.Text;
            /* category.Picture = pictureBox.Image != null ? ImageToByteArray(pictureBox.Image) : null;*/ // Convertir la imagen a bytes, si existe

            // Verificar si la categoría ya existe
            if (dataGridViewCategories.SelectedRows.Count == 1)
            {
                int id = Convert.ToInt32(dataGridViewCategories.CurrentRow.Cells["CategoryID"].Value);

                if (id != null)
                {
                    category.CategoryID = id;

                    // Llamar al método para modificar la categoría
                    int result = CategoriesDAL.ModificarCategory(category);

                    if (result > 0)
                    {
                        MessageBox.Show("Categoría modificada con éxito.");
                    }
                    else
                    {
                        MessageBox.Show("Error al modificar la categoría.");
                    }
                }
            }
            else
            {
                // Si no hay fila seleccionada, agregamos una nueva categoría
                int result = CategoriesDAL.AgregarCategories(category);

                if (result > 0)
                {
                    MessageBox.Show("Categoría agregada con éxito.");
                }
                else
                {
                    MessageBox.Show("Error al agregar la categoría.");
                }
            }

            // Refrescar la pantalla (o realizar otras acciones necesarias)
            refreshPantalla();
        }

        private void butNuevo_Click(object sender, EventArgs e)
        {
            dataGridViewCategories.CurrentCell = null;
            txtCategoryID.Clear();
            txtCategoryName.Clear();
            txtDescription.Clear();
        }

        private void butEliminar_Click(object sender, EventArgs e)
        {
            // Verificar si se ha seleccionado exactamente una fila en el DataGridView
            if (dataGridViewCategories.SelectedRows.Count == 1)
            {
                // Obtener el CategoryID de la fila seleccionada
                int categoryId = Convert.ToInt32(dataGridViewCategories.CurrentRow.Cells["CategoryID"].Value);

                // Confirmación antes de proceder con la eliminación
                DialogResult dialogResult = MessageBox.Show(
                    "¿Está seguro de que desea eliminar esta categoría?",
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
                        int resultado = CategoriesDAL.EliminarCategory(categoryId);

                        // Comprobar si la eliminación fue exitosa
                        if (resultado > 0)
                        {
                            MessageBox.Show("Categoría eliminada con éxito", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Error al eliminar la categoría", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    catch (Exception ex)
                    {
                        // Manejo de excepciones (por ejemplo, problemas de conexión a la base de datos)
                        MessageBox.Show("Se produjo un error al intentar eliminar la categoría: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                // Mensaje si no se ha seleccionado ninguna fila
                MessageBox.Show("Debe seleccionar una categoría para eliminar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            // Refrescar la pantalla después de la eliminación para actualizar los datos en el DataGridView
            refreshPantalla();
        }

        private void butBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                switch (BoxBuscarCategories.Text)
                {
                    case "CategoryID":
                        int categoryID = Convert.ToInt32(txtBuscarCategories.Text);
                        dataGridViewCategories.DataSource = CategoriesDAL.BuscarRegistroCategoryID(categoryID);
                        break;
                    case "CategoryName":
                        string categoryName = txtBuscarCategories.Text;
                        dataGridViewCategories.DataSource = CategoriesDAL.BuscarRegistroCategoryName(categoryName);
                        break;
                    case "Description":
                        string description = txtBuscarCategories.Text;
                        dataGridViewCategories.DataSource = CategoriesDAL.BuscarRegistroDescription(description);
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
            txtBuscarCategories.Text = "";
            BoxBuscarCategories.Text = "";
        }

        private void BoxBuscarCategories_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (BoxBuscarCategories.Text)
            {
                case "CategoryID":
                    txtBuscarCategories.Text = "CategoryID";
                    txtBuscarCategories.ForeColor = Color.Gray;
                    break;
                case "CategoryName":
                    txtBuscarCategories.Text = "CategoryName";
                    txtBuscarCategories.ForeColor = Color.Gray;
                    break;
                case "Description":
                    txtBuscarCategories.Text = "Description";
                    txtBuscarCategories.ForeColor = Color.Gray;
                    break;
                default:
                    MessageBox.Show("Seleccione un criterio de búsqueda válido.");
                    break;
            }
        }

        private void txtBuscarCategories_Enter(object sender, EventArgs e)
        {
            txtBuscarCategories.Text = "";
            txtBuscarCategories.ForeColor = Color.Black;
        }
    }
}

