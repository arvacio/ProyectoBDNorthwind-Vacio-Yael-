using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoBDNorthwind_Vacio_Yael_
{
    public partial class FormEmployees : Form
    {
        public FormEmployees()
        {
            InitializeComponent();
        }

        private void cerrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void refreshPantallaEmployees()
        {
            dataGridViewEmployees.DataSource = EmployeesDAL.PresentarRegistro();
        }

        private void FormEmployees_Load(object sender, EventArgs e)
        {
            refreshPantallaEmployees();
            txtEmployeeID.Enabled = false;
        }


        private void dataGridViewEmployees_SelectionChanged(object sender, EventArgs e)
        {
            txtEmployeeID.Text = Convert.ToString(dataGridViewEmployees.CurrentRow.Cells["EmployeeID"].Value);
            txtLastName.Text = Convert.ToString(dataGridViewEmployees.CurrentRow.Cells["LastName"].Value);
            txtFirstName.Text = Convert.ToString(dataGridViewEmployees.CurrentRow.Cells["FirstName"].Value);
            txtTitle.Text = Convert.ToString(dataGridViewEmployees.CurrentRow.Cells["Title"].Value);
            boxTitleOfCourtesy.Text = Convert.ToString(dataGridViewEmployees.CurrentRow.Cells["TitleOfCourtesy"].Value);
            dtpBirthDate.Text = Convert.ToString(dataGridViewEmployees.CurrentRow.Cells["BirthDate"].Value);
            dtpHireDate.Text = Convert.ToString(dataGridViewEmployees.CurrentRow.Cells["HireDate"].Value);
            txtAddress.Text = Convert.ToString(dataGridViewEmployees.CurrentRow.Cells["Address"].Value);
            txtCity.Text = Convert.ToString(dataGridViewEmployees.CurrentRow.Cells["City"].Value);
            txtRegion.Text = Convert.ToString(dataGridViewEmployees.CurrentRow.Cells["Region"].Value);
            txtPostalCode.Text = Convert.ToString(dataGridViewEmployees.CurrentRow.Cells["PostalCode"].Value);
            txtCountry.Text = Convert.ToString(dataGridViewEmployees.CurrentRow.Cells["Country"].Value);
            txtHomePhone.Text = Convert.ToString(dataGridViewEmployees.CurrentRow.Cells["HomePhone"].Value);
            txtExtension.Text = Convert.ToString(dataGridViewEmployees.CurrentRow.Cells["Extension"].Value);
            txtNotes.Text = Convert.ToString(dataGridViewEmployees.CurrentRow.Cells["Notes"].Value);
            txtReportsTo.Text = Convert.ToString(dataGridViewEmployees.CurrentRow.Cells["ReportsTo"].Value);
            txtPhotoPath.Text = Convert.ToString(dataGridViewEmployees.CurrentRow.Cells["PhotoPath"].Value);
        }

        private void butAgregar_Click(object sender, EventArgs e)
        {
            Employees employee = new Employees();

            // Asignar los valores de los controles a los campos de la entidad Employees
            employee.LastName = txtLastName.Text;
            employee.FirstName = txtFirstName.Text;
            employee.Title = txtTitle.Text;
            employee.TitleOfCourtesy = boxTitleOfCourtesy.Text;

            // Asignamos las fechas con un formato adecuado
            DateTime birthDate = dtpBirthDate.Value;
            DateTime hireDate = dtpHireDate.Value;

            employee.BirthDate = birthDate.ToString("yyyy-MM-dd");
            employee.HireDate = hireDate.ToString("yyyy-MM-dd");

            // Asignamos los valores de los campos de dirección
            employee.Address = txtAddress.Text;
            employee.City = txtCity.Text;
            employee.Region = txtRegion.Text;
            employee.PostalCode = txtPostalCode.Text;
            employee.Country = txtCountry.Text;

            employee.HomePhone = txtHomePhone.Text;
            employee.Extension = txtExtension.Text;

            //// Para la foto, verificamos si hay una imagen y la convertimos a bytes
            //if (pictureBoxPhoto.Image != null)
            //{
            //    using (MemoryStream ms = new MemoryStream())
            //    {
            //        pictureBoxPhoto.Image.Save(ms, pictureBoxPhoto.Image.RawFormat);
            //        employee.Photo = ms.ToArray();  // Convertimos la imagen a byte[]
            //    }
            //}
            //else
            //{
            //    employee.Photo = null;  // Si no hay imagen, dejamos el valor como null
            //}

            employee.Notes = txtNotes.Text;

            //// Asignamos el valor de ReportsTo (si hay) - podríamos necesitar usar un combo o validación
            employee.ReportsTo = string.IsNullOrEmpty(txtReportsTo.Text) ? (int?)null : Convert.ToInt32(txtReportsTo.Text);
            employee.PhotoPath = txtPhotoPath.Text;

            // Verificar si estamos modificando o agregando un nuevo registro
            if (dataGridViewEmployees.SelectedRows.Count == 1)
            {
                // Obtener el ID del empleado seleccionado
                int id = Convert.ToInt32(dataGridViewEmployees.CurrentRow.Cells["EmployeeID"].Value);

                if (id != null)
                {
                    employee.EmployeeID = id;

                    // Llamar a la función de modificación de la base de datos
                    int result = EmployeesDAL.ModificarEmployee(employee);

                    if (result > 0)
                    {
                        MessageBox.Show("¡Éxito al Modificar!");
                    }
                    else
                    {
                        MessageBox.Show("Error al Modificar");
                    }
                }
            }
            else
            {
                // Llamar a la función para agregar el nuevo empleado
                int result = EmployeesDAL.AgregarEmployee(employee);

                if (result > 0)
                {
                    MessageBox.Show("¡Éxito al Guardar!");
                }
            }

            // Llamar a una función para refrescar la pantalla después de guardar o modificar
            refreshPantallaEmployees();
        }

        private void butNuevo_Click(object sender, EventArgs e)
        {
            dataGridViewEmployees.CurrentCell = null;

            txtEmployeeID.Clear();
            txtLastName.Clear();
            txtFirstName.Clear();
            txtTitle.Clear();
            boxTitleOfCourtesy.Text = "";
            dtpBirthDate.Value = DateTime.Today;
            dtpHireDate.Value = DateTime.Today;
            txtAddress.Clear();
            txtCity.Clear();
            txtRegion.Clear();
            txtPostalCode.Clear();
            txtCountry.Clear();
            txtHomePhone.Clear();
            txtExtension.Clear();
            txtNotes.Clear();
            txtReportsTo.Clear();
            txtPhotoPath.Clear();
        }

        private void butEliminar_Click(object sender, EventArgs e)
        {
            // Verificar si se ha seleccionado exactamente una fila en el DataGridView
            if (dataGridViewEmployees.SelectedRows.Count == 1)
            {
                // Obtener el EmployeeID de la fila seleccionada
                int id = Convert.ToInt32(dataGridViewEmployees.CurrentRow.Cells["EmployeeID"].Value);

                // Confirmación antes de proceder con la eliminación
                DialogResult dialogResult = MessageBox.Show(
                    "¿Está seguro de que desea eliminar este empleado?",
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
                        int resultado = EmployeesDAL.EliminarEmployee(id);

                        // Comprobar si la eliminación fue exitosa
                        if (resultado > 0)
                        {
                            MessageBox.Show("Empleado Eliminado con Éxito", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Error al Eliminar el Empleado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    catch (Exception ex)
                    {
                        // Manejo de excepciones (por ejemplo, problemas de conexión a la base de datos)
                        MessageBox.Show("Se produjo un error al intentar eliminar el empleado: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                // Mensaje si no se ha seleccionado ninguna fila
                MessageBox.Show("Debe seleccionar un empleado para eliminar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            // Refrescar la pantalla después de la eliminación para actualizar los datos en el DataGridView
            refreshPantallaEmployees();
        }



        private void butBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                switch (BoxBuscarEmployees.Text)
                {
                    case "EmployeeID":
                        int EmployeeID = Convert.ToInt32(txtBuscarEmployees.Text);
                        dataGridViewEmployees.DataSource = EmployeesDAL.BuscarRegistroEmployeeID(EmployeeID);
                        break;
                    case "LastName":
                        string LastName = txtBuscarEmployees.Text;
                        dataGridViewEmployees.DataSource = EmployeesDAL.BuscarRegistroLastName(LastName);
                        break;
                    case "FirstName":
                        string FirstName = txtBuscarEmployees.Text;
                        dataGridViewEmployees.DataSource = EmployeesDAL.BuscarRegistroFirstName(FirstName);
                        break;
                    case "Title":
                        string Title = txtBuscarEmployees.Text;
                        dataGridViewEmployees.DataSource = EmployeesDAL.BuscarRegistroTitle(Title);
                        break;
                    case "BirthDate":
                        string BirthDate = txtBuscarEmployees.Text;
                        dataGridViewEmployees.DataSource = EmployeesDAL.BuscarRegistroBirthDate(BirthDate);
                        break;
                    case "HireDate":
                        string HireDate = txtBuscarEmployees.Text;
                        dataGridViewEmployees.DataSource = EmployeesDAL.BuscarRegistroHireDate(HireDate);
                        break;
                    case "Address":
                        string Address = txtBuscarEmployees.Text;
                        dataGridViewEmployees.DataSource = EmployeesDAL.BuscarRegistroAddress(Address);
                        break;
                    case "City":
                        string City = txtBuscarEmployees.Text;
                        dataGridViewEmployees.DataSource = EmployeesDAL.BuscarRegistroCity(City);
                        break;
                    case "Region":
                        string Region = txtBuscarEmployees.Text;
                        dataGridViewEmployees.DataSource = EmployeesDAL.BuscarRegistroRegion(Region);
                        break;
                    case "PostalCode":
                        string PostalCode = txtBuscarEmployees.Text;
                        dataGridViewEmployees.DataSource = EmployeesDAL.BuscarRegistroPostalCode(PostalCode);
                        break;
                    case "Country":
                        string Country = txtBuscarEmployees.Text;
                        dataGridViewEmployees.DataSource = EmployeesDAL.BuscarRegistroCountry(Country);
                        break;
                    case "HomePhone":
                        string HomePhone = txtBuscarEmployees.Text;
                        dataGridViewEmployees.DataSource = EmployeesDAL.BuscarRegistroHomePhone(HomePhone);
                        break;
                    case "Extension":
                        string Extension = txtBuscarEmployees.Text;
                        dataGridViewEmployees.DataSource = EmployeesDAL.BuscarRegistroExtension(Extension);
                        break;
                    default:
                        MessageBox.Show("Seleccione un criterio de búsqueda válido.");
                        break;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error al Buscar");
            }
        }

        private void butRefrescar_Click(object sender, EventArgs e)
        {
            refreshPantallaEmployees();
            txtBuscarEmployees.Text = "";
            BoxBuscarEmployees.Text = "";
        }

        private void BoxBuscarEmployees_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (BoxBuscarEmployees.Text)
            {
                case "EmployeeID":
                    txtBuscarEmployees.Text = "EmployeeID";
                    txtBuscarEmployees.ForeColor = Color.Gray;
                    break;
                case "LastName":
                    txtBuscarEmployees.Text = "LastName";
                    txtBuscarEmployees.ForeColor = Color.Gray;
                    break;
                case "FirstName":
                    txtBuscarEmployees.Text = "FirstName";
                    txtBuscarEmployees.ForeColor = Color.Gray;
                    break;
                case "Title":
                    txtBuscarEmployees.Text = "Title";
                    txtBuscarEmployees.ForeColor = Color.Gray;
                    break;
                case "BirthDate":
                    txtBuscarEmployees.Text = "Mes/Dia/Año";
                    txtBuscarEmployees.ForeColor = Color.Gray;
                    break;
                case "HireDate":
                    txtBuscarEmployees.Text = "Mes/Dia/Año";
                    txtBuscarEmployees.ForeColor = Color.Gray;
                    break;
                case "Address":
                    txtBuscarEmployees.Text = "Address";
                    txtBuscarEmployees.ForeColor = Color.Gray;
                    break;
                case "City":
                    txtBuscarEmployees.Text = "City";
                    txtBuscarEmployees.ForeColor = Color.Gray;
                    break;
                case "Region":
                    txtBuscarEmployees.Text = "Region";
                    txtBuscarEmployees.ForeColor = Color.Gray;
                    break;
                case "PostalCode":
                    txtBuscarEmployees.Text = "PostalCode";
                    txtBuscarEmployees.ForeColor = Color.Gray;
                    break;
                case "Country":
                    txtBuscarEmployees.Text = "Country";
                    txtBuscarEmployees.ForeColor = Color.Gray;
                    break;
                case "HomePhone":
                    txtBuscarEmployees.Text = "HomePhone";
                    txtBuscarEmployees.ForeColor = Color.Gray;
                    break;
                case "Extension":
                    txtBuscarEmployees.Text = "Extension";
                    txtBuscarEmployees.ForeColor = Color.Gray;
                    break;
            }
        }

        private void txtBuscarEmployees_Enter(object sender, EventArgs e)
        {
            txtBuscarEmployees.Text = "";
            txtBuscarEmployees.ForeColor = Color.Black;
        }

    }
}
