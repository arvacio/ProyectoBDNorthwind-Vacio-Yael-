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
    public partial class FormProducts : Form
    {
        public FormProducts()
        {
            InitializeComponent();
        }

        private void cerrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void butGuardarProducts_Click(object sender, EventArgs e)
        {
            Products products = new Products();

            products.ProductName = txtProductName.Text;
            products.SupplierID = Convert.ToInt32(boxSupplierID.SelectedValue);
            products.CategoryID = Convert.ToInt32(boxCategoryID.SelectedValue);
            products.QuantityPerUnit = txtQuantityPerUnit.Text;
            products.UnitPrice = Convert.ToDecimal(txtUnitPrice.Text);
            products.UnitsInStock = Convert.ToInt16(txtUnitsInStock.Text);
            products.UnitsOnOrder = Convert.ToInt16(txtUnitsOnOrder.Text);
            products.ReorderLevel = Convert.ToInt16(txtReorderLevel.Text);

            if (BoxDiscontinued.Text == "Si")
                products.Discontinued = true;
            else
                products.Discontinued = false;

            if (dataGridViewProducts.SelectedRows.Count == 1)
            {

                int id = Convert.ToInt32(dataGridViewProducts.CurrentRow.Cells["ProductID"].Value);

                if (id != null)
                {
                    products.ProductID = id;
                    int result = ProductsDAL.ModificarProducts(products);

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
                int result = ProductsDAL.AgregarProducts(products);

                if (result > 0)
                {
                    MessageBox.Show("Exito al Guardar");
                }
            }
            refreshPantallaProducts();
        }

        public void refreshPantallaProducts()
        {
            dataGridViewProducts.DataSource = ProductsDAL.PresentarRegistro();
        }

        private void FormProducts_Load(object sender, EventArgs e)
        {
            refreshPantallaProducts();
            txtProductID.Enabled = false;

            string query1 = "select supplierid, companyname from suppliers";

            using (SqlConnection conexion = BDGeneral.ObtenerConexion())
            {
                // Crear un adaptador de datos para llenar el DataTable
                SqlDataAdapter adapter = new SqlDataAdapter(query1, conexion);

                // Crear un DataTable para almacenar los resultados
                DataTable dtCategorias = new DataTable();

                // Llenar el DataTable con los resultados de la consulta
                adapter.Fill(dtCategorias);

                // Asignar el DataTable al ComboBox
                boxSupplierID.DataSource = dtCategorias;
                boxSupplierID.DisplayMember = "companyname"; // Columna que se muestra en el ComboBox
                boxSupplierID.ValueMember = "supplierid"; // Valor interno que representa al ítem seleccionado
            }

            string query2 = "select categoryid, categoryname from categories";

            using (SqlConnection conexion = BDGeneral.ObtenerConexion())
            {
                // Crear un adaptador de datos para llenar el DataTable
                SqlDataAdapter adapter = new SqlDataAdapter(query2, conexion);

                // Crear un DataTable para almacenar los resultados
                DataTable dtCategorias = new DataTable();

                // Llenar el DataTable con los resultados de la consulta
                adapter.Fill(dtCategorias);

                // Asignar el DataTable al ComboBox
                boxCategoryID.DataSource = dtCategorias;
                boxCategoryID.DisplayMember = "categoryname"; // Columna que se muestra en el ComboBox
                boxCategoryID.ValueMember = "categoryid"; // Valor interno que representa al ítem seleccionado
            }

        }

        private void dataGridViewProducts_SelectionChanged(object sender, EventArgs e)
        {
            txtProductID.Text = Convert.ToString(dataGridViewProducts.CurrentRow.Cells["ProductID"].Value);
            txtProductName.Text = Convert.ToString(dataGridViewProducts.CurrentRow.Cells["ProductName"].Value);
            boxSupplierID.Text = Convert.ToString(dataGridViewProducts.CurrentRow.Cells["SupplierID"].Value);
            boxCategoryID.Text = Convert.ToString(dataGridViewProducts.CurrentRow.Cells["CategoryID"].Value);
            txtQuantityPerUnit.Text = Convert.ToString(dataGridViewProducts.CurrentRow.Cells["QuantityPerUnit"].Value);
            txtUnitPrice.Text = Convert.ToString(dataGridViewProducts.CurrentRow.Cells["UnitPrice"].Value);
            txtUnitsInStock.Text = Convert.ToString(dataGridViewProducts.CurrentRow.Cells["UnitsInStock"].Value);
            txtUnitsOnOrder.Text = Convert.ToString(dataGridViewProducts.CurrentRow.Cells["UnitsOnOrder"].Value);
            txtReorderLevel.Text = Convert.ToString(dataGridViewProducts.CurrentRow.Cells["ReorderLevel"].Value);
            BoxDiscontinued.Text = Convert.ToString(dataGridViewProducts.CurrentRow.Cells["Discontinued"].Value);
        }

        private void butNuevoProducts_Click(object sender, EventArgs e)
        {
            dataGridViewProducts.CurrentCell = null;
            txtProductID.Clear();
            txtProductName.Clear();
            boxSupplierID.Text = "";
            boxCategoryID.Text = "";
            txtQuantityPerUnit.Clear();
            txtUnitPrice.Clear();
            txtUnitsInStock.Clear();
            txtUnitsOnOrder.Clear();
            txtReorderLevel.Clear();
            BoxDiscontinued.Text = "";
        }

        private void butEliminarProducts_Click(object sender, EventArgs e)
        {
            // Verificar si se ha seleccionado exactamente una fila en el DataGridView
            if (dataGridViewProducts.SelectedRows.Count == 1)
            {
                // Obtener el ID del producto seleccionado
                int productId = Convert.ToInt32(dataGridViewProducts.CurrentRow.Cells["ProductID"].Value);

                // Confirmación antes de proceder con la eliminación
                DialogResult dialogResult = MessageBox.Show(
                    "¿Está seguro de que desea eliminar este producto?",
                    "Confirmar Eliminación",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning
                );

                // Si el usuario confirma la eliminación
                if (dialogResult == DialogResult.Yes)
                {
                    try
                    {
                        // Llamar al método para eliminar el producto
                        int resultado = ProductsDAL.EliminarProducts(productId);

                        // Comprobar si la eliminación fue exitosa
                        if (resultado > 0)
                        {
                            MessageBox.Show("Producto eliminado con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Error al eliminar el producto. Intente nuevamente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    catch (Exception ex)
                    {
                        // Manejo de excepciones
                        MessageBox.Show("Se produjo un error al intentar eliminar el producto: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                // Si no se ha seleccionado ninguna fila
                MessageBox.Show("Debe seleccionar un producto para eliminar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            // Refrescar la pantalla después de la eliminación para actualizar los datos en el DataGridView
            refreshPantallaProducts();
        }

        private void butBuscarProducts_Click(object sender, EventArgs e)
        {
            try
            {
                switch (boxBuscarProducts.Text)
                {
                    case "ProductID":
                        int ProductID = Convert.ToInt32(txtBuscarProducts.Text);
                        dataGridViewProducts.DataSource = ProductsDAL.BuscarRegistroProductID(ProductID);
                        break;
                    case "ProductName":
                        string ProductName = txtBuscarProducts.Text;
                        dataGridViewProducts.DataSource = ProductsDAL.BuscarRegistroProductName(ProductName);
                        break;
                    case "SupplierID":
                        int SupplierID = Convert.ToInt32(txtBuscarProducts.Text);
                        dataGridViewProducts.DataSource = ProductsDAL.BuscarRegistroSupplierID(SupplierID);
                        break;
                    case "CategoryID":
                        int CategoryID = Convert.ToInt32(txtBuscarProducts.Text);
                        dataGridViewProducts.DataSource = ProductsDAL.BuscarRegistroCategoryID(CategoryID);
                        break;
                    case "QuantityPerUnit":
                        string QuantityPerUnit = txtBuscarProducts.Text;
                        dataGridViewProducts.DataSource = ProductsDAL.BuscarRegistroQuantityPerUnit(QuantityPerUnit);
                        break;
                    case "UnitPrice":
                        Decimal UnitPrice = Convert.ToDecimal(txtBuscarProducts.Text);
                        dataGridViewProducts.DataSource = ProductsDAL.BuscarRegistroUnitPrice(UnitPrice);
                        break;
                    case "UnitsInStock":
                        int UnitsInStock = Convert.ToInt16(txtBuscarProducts.Text);
                        dataGridViewProducts.DataSource = ProductsDAL.BuscarRegistroUnitsInStock(UnitsInStock);
                        break;
                    case "UnitsOnOrder":
                        int UnitsOnOrder = Convert.ToInt16(txtBuscarProducts.Text);
                        dataGridViewProducts.DataSource = ProductsDAL.BuscarRegistroUnitsOnOrder(UnitsOnOrder);
                        break;
                    case "ReorderLevel":
                        int ReorderLevel = Convert.ToInt16(txtBuscarProducts.Text);
                        dataGridViewProducts.DataSource = ProductsDAL.BuscarRegistroReorderLevel(ReorderLevel);
                        break;
                    case "Discontinued":
                        string Discontinued = "1";
                        dataGridViewProducts.DataSource = ProductsDAL.BuscarRegistroDiscontinued(Discontinued);
                        break;
                    case "No Discontinued":
                        string NoDiscontinued = "0";
                        dataGridViewProducts.DataSource = ProductsDAL.BuscarRegistroNoDiscontinued(NoDiscontinued);
                        break;
                    case "CompanyName":
                        string CompanyName = txtBuscarProducts.Text;
                        dataGridViewProducts.DataSource = ProductsDAL.BuscarRegistroPorCompanyName(CompanyName);
                        break;
                    case "CategoryName":
                        string CategoryName = txtBuscarProducts.Text;
                        dataGridViewProducts.DataSource = ProductsDAL.BuscarRegistroPorCategoryName(CategoryName);
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

        private void butRefrescarProducts_Click(object sender, EventArgs e)
        {
            refreshPantallaProducts();
            txtBuscarProducts.Text = "";
            boxBuscarProducts.Text = "";
        }

        private void boxBuscarProducts_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtBuscarProducts.Enabled = true;
            switch (boxBuscarProducts.Text)
            {
                case "ProductID":
                    txtBuscarProducts.Text = "ProductID";
                    txtBuscarProducts.ForeColor = Color.Gray;
                    break;
                case "ProductName":
                    txtBuscarProducts.Text = "ProductName";
                    txtBuscarProducts.ForeColor = Color.Gray;
                    break;
                case "SupplierID":
                    txtBuscarProducts.Text = "SupplierID";
                    txtBuscarProducts.ForeColor = Color.Gray;
                    break;
                case "CategoryID":
                    txtBuscarProducts.Text = "CategoryID";
                    txtBuscarProducts.ForeColor = Color.Gray;
                    break;
                case "QuantityPerUnit":
                    txtBuscarProducts.Text = "QuantityPerUnit";
                    txtBuscarProducts.ForeColor = Color.Gray;
                    break;
                case "UnitPrice":
                    txtBuscarProducts.Text = "UnitPrice";
                    txtBuscarProducts.ForeColor = Color.Gray;
                    break;
                case "UnitsInStock":
                    txtBuscarProducts.Text = "UnitsInStock";
                    txtBuscarProducts.ForeColor = Color.Gray;
                    break;
                case "UnitsOnOrder":
                    txtBuscarProducts.Text = "UnitsOnOrder";
                    txtBuscarProducts.ForeColor = Color.Gray;
                    break;
                case "ReorderLevel":
                    txtBuscarProducts.Text = "ReorderLevel";
                    txtBuscarProducts.ForeColor = Color.Gray;
                    break;
                case "Discontinued":
                    txtBuscarProducts.Text = "";
                    txtBuscarProducts.Enabled = false;
                    txtBuscarProducts.ForeColor = Color.Gray;
                    break;
                case "No Discontinued":
                    txtBuscarProducts.Text = "";
                    txtBuscarProducts.Enabled = false;
                    txtBuscarProducts.ForeColor = Color.Gray;
                    break;
                case "CompanyName":
                    txtBuscarProducts.Text = "CompanyName";
                    txtBuscarProducts.ForeColor = Color.Gray;
                    break;
                case "CategoryName":
                    txtBuscarProducts.Text = "CategoryName";
                    txtBuscarProducts.ForeColor = Color.Gray;
                    break;
            }
        }

        private void txtBuscarProducts_Enter(object sender, EventArgs e)
        {
            txtBuscarProducts.Text = "";
            txtBuscarProducts.ForeColor = Color.Black;
        }


    }
}

