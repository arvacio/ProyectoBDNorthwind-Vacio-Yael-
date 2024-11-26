using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoBDNorthwind_Vacio_Yael_
{
    public partial class FormProductsToOrders : Form
    {
        public FormProductsToOrders()
        {
            InitializeComponent();
        }

        private void cerrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormOrderDetails formOrderDetails = new FormOrderDetails();
            formOrderDetails.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (boxNumProducts.Text != "0" && boxNumProducts.Text != "0")
            {
                boxNumProducts.Enabled = false;
                lblContador.Text = "Producto = 1  / " + boxNumProducts.Text;
                butGuardarOrderDetails.Enabled = true;
            }
            else MessageBox.Show("Agrega un Numero de Productos a Agregar");
        }

        private void FormProductsToOrders_Load(object sender, EventArgs e)
        {

            boxOrderID.Enabled = false;
            butGuardarOrderDetails.Enabled = false;

            string query1 = "select productid, productname from products";

            using (SqlConnection conexion = BDGeneral.ObtenerConexion())
            {
                // Crear un adaptador de datos para llenar el DataTable
                SqlDataAdapter adapter = new SqlDataAdapter(query1, conexion);

                // Crear un DataTable para almacenar los resultados
                DataTable dtCategorias = new DataTable();

                // Llenar el DataTable con los resultados de la consulta
                adapter.Fill(dtCategorias);

                // Asignar el DataTable al ComboBox
                boxProductID.DataSource = dtCategorias;
                boxProductID.DisplayMember = "productname"; // Columna que se muestra en el ComboBox
                boxProductID.ValueMember = "productid"; // Valor interno que representa al ítem seleccionado
            }

            string query = "SELECT IDENT_CURRENT('Orders') AS ProximoOrderID;";

            try
            {
                // Crear una conexión con la base de datos
                using (SqlConnection conn = BDGeneral.ObtenerConexion())
                {
                    // Crear un comando SQL
                    SqlCommand cmd = new SqlCommand(query, conn);

                    // Ejecutar el comando y obtener el próximo OrderID
                    var result = cmd.ExecuteScalar();

                    // Asignar el resultado al TextBox (convertir a string)
                    boxOrderID.Text = result.ToString();
                }
            }
            catch (Exception ex)
            {
                // Manejar errores en caso de que haya un problema con la conexión o la consulta
                MessageBox.Show("Error al obtener el próximo OrderID: " + ex.Message);
            }
        }

        int cont = 1;
        private void butGuardarOrderDetails_Click(object sender, EventArgs e)
        {
            int orderID = Convert.ToInt32(boxOrderID.Text);
            int numProducts = Convert.ToInt32(boxNumProducts.Text);
            OrderDetails orderDetails = new OrderDetails();

                try
                {
                    orderDetails.OrderID = orderID;
                    orderDetails.ProductID = Convert.ToInt32(boxProductID.SelectedValue);
                    orderDetails.UnitPrice = Convert.ToDecimal(txtUnitPrice.Text);
                    orderDetails.Quantity = Convert.ToInt32(txtQuantity.Text);
                    orderDetails.Discount = Convert.ToSingle(txtDiscount.Text);
                }
                catch { MessageBox.Show("Datos Invalidos"); }

                int result = OrderDetailsDAL.AgregarOrderDetailsDAL(orderDetails);

                if (result > 0)
                {
                    boxProductID.Text = "";
                    txtUnitPrice.Text = "";
                    txtQuantity.Text = "";
                    txtDiscount.Text = "";
                    MessageBox.Show("Exito al Guardar Producto = " + cont);
                    cont++;
                    lblContador.Text = "Producto = " + cont + " / " + numProducts;
            }

            if (cont > numProducts)
            {
                lblContador.Text = "Producto = " + (cont-1) + " / " + numProducts;
                MessageBox.Show("Productos Guardados con Exito");
                cont = 0;
                this.Close();
            }
        }
    }
}
