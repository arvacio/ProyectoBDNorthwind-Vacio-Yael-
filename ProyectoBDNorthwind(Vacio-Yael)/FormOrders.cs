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
    public partial class FormOrders : Form
    {
        public FormOrders()
        {
            InitializeComponent();
        }


        // Codigo de cerrar form
        private void cerrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Metodo refrescar
        public void refreshPantallaOrders()
        {
            dataGridViewOrders.DataSource = OrdersDAL.PresentarRegistro();
        }

        // Codigo ejecutado a cargar el form, mostrar info
        private void FormOrders_Load(object sender, EventArgs e)
        {
            refreshPantallaOrders();
            txtOrderID.Enabled = false;

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

            string query2 = "select EmployeeID, FirstName from Employees";

            using (SqlConnection conexion = BDGeneral.ObtenerConexion())
            {
                // Crear un adaptador de datos para llenar el DataTable
                SqlDataAdapter adapter = new SqlDataAdapter(query2, conexion);

                // Crear un DataTable para almacenar los resultados
                DataTable dtCategorias2 = new DataTable();

                // Llenar el DataTable con los resultados de la consulta
                adapter.Fill(dtCategorias2);

                // Asignar el DataTable al ComboBox
                boxEmployeeID.DataSource = dtCategorias2;
                boxEmployeeID.DisplayMember = "FirstName"; // Columna que se muestra en el ComboBox
                boxEmployeeID.ValueMember = "EmployeeID"; // Valor interno que representa al ítem seleccionado
            }
        }

        // Codigo de seleccion dentro del grid
        private void dataGridViewOrders_SelectionChanged(object sender, EventArgs e)
        {
            txtOrderID.Text = Convert.ToString(dataGridViewOrders.CurrentRow.Cells["OrderID"].Value);
            boxCustomerID.Text = Convert.ToString(dataGridViewOrders.CurrentRow.Cells["CustomerID"].Value);
            boxEmployeeID.Text = Convert.ToString(dataGridViewOrders.CurrentRow.Cells["EmployeeID"].Value);
            dtpOrderDate.Text = Convert.ToString(dataGridViewOrders.CurrentRow.Cells["OrderDate"].Value);
            dtpRequiredDate.Text = Convert.ToString(dataGridViewOrders.CurrentRow.Cells["RequiredDate"].Value);
            dtpShippedDate.Text = Convert.ToString(dataGridViewOrders.CurrentRow.Cells["ShippedDate"].Value);
            txtShipVia.Text = Convert.ToString(dataGridViewOrders.CurrentRow.Cells["ShipVia"].Value);
            txtFreight.Text = Convert.ToString(dataGridViewOrders.CurrentRow.Cells["Freight"].Value);
            txtShipName.Text = Convert.ToString(dataGridViewOrders.CurrentRow.Cells["ShipName"].Value);
            txtShipAddress.Text = Convert.ToString(dataGridViewOrders.CurrentRow.Cells["ShipAddress"].Value);
            txtShipCity.Text = Convert.ToString(dataGridViewOrders.CurrentRow.Cells["ShipCity"].Value);
            txtShipRegion.Text = Convert.ToString(dataGridViewOrders.CurrentRow.Cells["ShipRegion"].Value);
            txtShipPostalCode.Text = Convert.ToString(dataGridViewOrders.CurrentRow.Cells["ShipPostalCode"].Value);
            txtShipCountry.Text = Convert.ToString(dataGridViewOrders.CurrentRow.Cells["ShipCountry"].Value);
        }

        // Codigo de boton guardar
        private void butGuardarOrders_Click(object sender, EventArgs e)
        {
            Orders orders = new Orders();

            orders.CustomerID = Convert.ToString(boxCustomerID.SelectedValue);
            orders.EmployeeID = Convert.ToInt32(boxEmployeeID.SelectedValue);

            DateTime sD = dtpOrderDate.Value;
            DateTime sD1 = dtpRequiredDate.Value;
            DateTime sD2 = dtpShippedDate.Value;

            orders.OrderDate = sD.ToString("yyyy-MM-dd");
            orders.RequiredDate = sD1.ToString("yyyy-MM-dd");
            orders.ShippedDate = sD2.ToString("yyyy-MM-dd");

            orders.ShipVia = Convert.ToInt32(txtShipVia.Text);
            orders.Freight = Convert.ToDecimal(txtFreight.Text);
            orders.ShipName = txtShipName.Text;
            orders.ShipAddress = txtShipAddress.Text;
            orders.ShipCity = txtShipCity.Text;
            orders.ShipRegion = txtShipRegion.Text;
            orders.ShipPostalCode = txtShipPostalCode.Text;
            orders.ShipCountry = txtShipCountry.Text;

            if (dataGridViewOrders.SelectedRows.Count == 1)
            {

                int id = Convert.ToInt32(dataGridViewOrders.CurrentRow.Cells["OrderID"].Value);

                if (id != null)
                {
                    orders.OrderID = id;
                    int result = OrdersDAL.ModificarOrders(orders);

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
                int result = OrdersDAL.AgregarOrders(orders);

                if (result > 0)
                {
                    MessageBox.Show("Exito al Guardar");
                }
            }
            refreshPantallaOrders();
        }


        // Codigo de boton Nuevo
        private void butNuevoOrders_Click(object sender, EventArgs e)
        {
            dataGridViewOrders.CurrentCell = null;
            txtOrderID.Clear();
            boxCustomerID.Text = "";
            boxEmployeeID.Text = "";
            dtpOrderDate.Value = DateTime.Today;
            dtpRequiredDate.Value = DateTime.Today;
            dtpShippedDate.Value = DateTime.Today;
            txtShipVia.Clear();
            txtFreight.Clear();
            txtShipName.Clear();
            txtShipAddress.Clear();
            txtShipCity.Clear();
            txtShipRegion.Clear();
            txtShipPostalCode.Clear();
            txtShipCountry.Clear();
        }


        // Codigo de boton eliminar
        private void butEliminarOrders_Click(object sender, EventArgs e)
        {
            // Verificar si se ha seleccionado exactamente una fila en el DataGridView
            if (dataGridViewOrders.SelectedRows.Count == 1)
            {
                // Obtener el OrderID de la fila seleccionada
                int id = Convert.ToInt32(dataGridViewOrders.CurrentRow.Cells["OrderID"].Value);

                // Confirmación antes de proceder con la eliminación
                DialogResult dialogResult = MessageBox.Show(
                    "¿Está seguro de que desea eliminar este pedido?",
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
                        int resultado = OrdersDAL.EliminarOrders(id);

                        // Comprobar si la eliminación fue exitosa
                        if (resultado > 0)
                        {
                            MessageBox.Show("Pedido Eliminado con Éxito", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Error al Eliminar el Pedido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    catch (Exception ex)
                    {
                        // Manejo de excepciones (por ejemplo, problemas de conexión a la base de datos)
                        MessageBox.Show("Se produjo un error al intentar eliminar el pedido: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                // Mensaje si no se ha seleccionado ninguna fila
                MessageBox.Show("Debe seleccionar un pedido para eliminar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            // Refrescar la pantalla después de la eliminación para actualizar los datos en el DataGridView
            refreshPantallaOrders();
        }


        // Codigo de boton de buscar
        private void butBuscarOrders_Click(object sender, EventArgs e)
        {
            try
            {
                switch (boxBuscarOrders.Text)
                {
                    case "OrderID":
                        int OrderID = Convert.ToInt32(txtBuscarOrders.Text);
                        dataGridViewOrders.DataSource = OrdersDAL.BuscarRegistroOrderID(OrderID);
                        break;
                    case "CustomerID":
                        string CustomerID = txtBuscarOrders.Text;
                        dataGridViewOrders.DataSource = OrdersDAL.BuscarRegistroCustomerID(CustomerID);
                        break;
                    case "EmployeeID":
                        int EmployeeID = Convert.ToInt32(txtBuscarOrders.Text);
                        dataGridViewOrders.DataSource = OrdersDAL.BuscarRegistroEmployeeID(EmployeeID);
                        break;
                    case "OrderDate":
                        string OrderDate = txtBuscarOrders.Text;
                        dataGridViewOrders.DataSource = OrdersDAL.BuscarRegistroOrderDate(OrderDate);
                        break;
                    case "RequiredDate":
                        string RequiredDate = txtBuscarOrders.Text;
                        dataGridViewOrders.DataSource = OrdersDAL.BuscarRegistroRequiredDate(RequiredDate);
                        break;
                    case "ShippedDate":
                        string ShippedDate = txtBuscarOrders.Text;
                        dataGridViewOrders.DataSource = OrdersDAL.BuscarRegistroShippedDate(ShippedDate);
                        break;
                    case "ShipVia":
                        int ShipVia = Convert.ToInt32(txtBuscarOrders.Text);
                        dataGridViewOrders.DataSource = OrdersDAL.BuscarRegistroShipVia(ShipVia);
                        break;
                    case "Freight":
                        double Freight = Convert.ToDouble(txtBuscarOrders.Text);
                        dataGridViewOrders.DataSource = OrdersDAL.BuscarRegistroFreight(Freight);
                        break;
                    case "ShipName":
                        string ShipName = txtBuscarOrders.Text;
                        dataGridViewOrders.DataSource = OrdersDAL.BuscarRegistroShipName(ShipName);
                        break;
                    case "ShipAddress":
                        string ShipAddress = txtBuscarOrders.Text;
                        dataGridViewOrders.DataSource = OrdersDAL.BuscarRegistroShipAddress(ShipAddress);
                        break;
                    case "ShipCity":
                        string ShipCity = txtBuscarOrders.Text;
                        dataGridViewOrders.DataSource = OrdersDAL.BuscarRegistroShipCity(ShipCity);
                        break;
                    case "ShipRegion":
                        string ShipRegion = txtBuscarOrders.Text;
                        dataGridViewOrders.DataSource = OrdersDAL.BuscarRegistroShipRegion(ShipRegion);
                        break;
                    case "ShipPostalCode":
                        string ShipPostalCode = txtBuscarOrders.Text;
                        dataGridViewOrders.DataSource = OrdersDAL.BuscarRegistroShipPostalCode(ShipPostalCode);
                        break;
                    case "ShipCountry":
                        string ShipCountry = txtBuscarOrders.Text;
                        dataGridViewOrders.DataSource = OrdersDAL.BuscarRegistroShipCountry(ShipCountry);
                        break;
                    default:
                        MessageBox.Show("Seleccione un criterio de búsqueda válido.");
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al Buscar");
            }
        }

        // Codigo refrescar en busqueda
        private void butRefrescarOrders_Click(object sender, EventArgs e)
        {
            refreshPantallaOrders();
            txtBuscarOrders.Text = "";
            boxBuscarOrders.Text = "";
        }

        // Seleccion de Box diseño en el text
        private void boxBuscarOrders_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (boxBuscarOrders.Text)
            {
                case "OrderID":
                    txtBuscarOrders.Text = "OrderID";
                    txtBuscarOrders.ForeColor = Color.Gray;
                    break;
                case "CustomerID":
                    txtBuscarOrders.Text = "CustomerID";
                    txtBuscarOrders.ForeColor = Color.Gray;
                    break;
                case "EmployeeID":
                    txtBuscarOrders.Text = "EmployeeID";
                    txtBuscarOrders.ForeColor = Color.Gray;
                    break;
                case "OrderDate":
                    txtBuscarOrders.Text = "Mes/Dia/Año";
                    txtBuscarOrders.ForeColor = Color.Gray;
                    break;
                case "RequiredDate":
                    txtBuscarOrders.Text = "Mes/Dia/Año";
                    txtBuscarOrders.ForeColor = Color.Gray;
                    break;
                case "ShippedDate":
                    txtBuscarOrders.Text = "Mes/Dia/Año";
                    txtBuscarOrders.ForeColor = Color.Gray;
                    break;
                case "ShipVia":
                    txtBuscarOrders.Text = "ShipVia";
                    txtBuscarOrders.ForeColor = Color.Gray;
                    break;
                case "Freight":
                    txtBuscarOrders.Text = "Freight";
                    txtBuscarOrders.ForeColor = Color.Gray;
                    break;
                case "ShipName":
                    txtBuscarOrders.Text = "ShipName";
                    txtBuscarOrders.ForeColor = Color.Gray;
                    break;
                case "ShipAddress":
                    txtBuscarOrders.Text = "ShipAddress";
                    txtBuscarOrders.ForeColor = Color.Gray;
                    break;
                case "ShipCity":
                    txtBuscarOrders.Text = "ShipCity";
                    txtBuscarOrders.ForeColor = Color.Gray;
                    break;
                case "ShipRegion":
                    txtBuscarOrders.Text = "ShipRegion";
                    txtBuscarOrders.ForeColor = Color.Gray;
                    break;
                case "ShipPostalCode":
                    txtBuscarOrders.Text = "ShipPostalCode";
                    txtBuscarOrders.ForeColor = Color.Gray;
                    break;
                case "ShipCountry":
                    txtBuscarOrders.Text = "ShipCountry";
                    txtBuscarOrders.ForeColor = Color.Gray;
                    break;
            }
        }
        private void txtBuscarOrders_Enter(object sender, EventArgs e)
        {
            txtBuscarOrders.Text = "";
            txtBuscarOrders.ForeColor = Color.Black;
        }




    }
}
