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
    public partial class FormOrderDetails : Form
    {
        public FormOrderDetails()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            panel3 = new Panel();
            panel1 = new Panel();
            label2 = new Label();
            label1 = new Label();
            txtProductID = new TextBox();
            txtOrderID = new TextBox();
            label32 = new Label();
            txtDiscount = new TextBox();
            label19 = new Label();
            butEliminarOrderDetails = new Button();
            butNuevoOrderDetails = new Button();
            butGuardarOrderDetails = new Button();
            txtQuantity = new TextBox();
            label30 = new Label();
            txtUnitPrice = new TextBox();
            label31 = new Label();
            label33 = new Label();
            panel4 = new Panel();
            butRefrescarOrderDetails = new Button();
            butBuscarOrderDetails = new Button();
            boxBuscarOrderDetails = new ComboBox();
            txtBuscarOrderDetails = new TextBox();
            label35 = new Label();
            label36 = new Label();
            dataGridViewOrderDetails = new DataGridView();
            menuStrip1 = new MenuStrip();
            archivoToolStripMenuItem = new ToolStripMenuItem();
            cerrarToolStripMenuItem = new ToolStripMenuItem();
            panel3.SuspendLayout();
            panel1.SuspendLayout();
            panel4.SuspendLayout();
            ((ISupportInitialize)dataGridViewOrderDetails).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // panel3
            // 
            panel3.BackColor = Color.LightSkyBlue;
            panel3.Controls.Add(panel1);
            panel3.Controls.Add(txtDiscount);
            panel3.Controls.Add(label19);
            panel3.Controls.Add(butEliminarOrderDetails);
            panel3.Controls.Add(butNuevoOrderDetails);
            panel3.Controls.Add(butGuardarOrderDetails);
            panel3.Controls.Add(txtQuantity);
            panel3.Controls.Add(label30);
            panel3.Controls.Add(txtUnitPrice);
            panel3.Controls.Add(label31);
            panel3.Controls.Add(label33);
            panel3.Location = new Point(12, 48);
            panel3.Name = "panel3";
            panel3.Size = new Size(445, 709);
            panel3.TabIndex = 51;
            // 
            // panel1
            // 
            panel1.BackColor = Color.SteelBlue;
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(txtProductID);
            panel1.Controls.Add(txtOrderID);
            panel1.Controls.Add(label32);
            panel1.Location = new Point(37, 90);
            panel1.Name = "panel1";
            panel1.Size = new Size(362, 169);
            panel1.TabIndex = 41;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(120, 10);
            label2.Name = "label2";
            label2.Size = new Size(115, 31);
            label2.TabIndex = 40;
            label2.Text = "Selección";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(45, 111);
            label1.Name = "label1";
            label1.Size = new Size(129, 31);
            label1.TabIndex = 39;
            label1.Text = "ProductID:";
            // 
            // txtProductID
            // 
            txtProductID.BackColor = SystemColors.Menu;
            txtProductID.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtProductID.Location = new Point(211, 111);
            txtProductID.Name = "txtProductID";
            txtProductID.Size = new Size(84, 38);
            txtProductID.TabIndex = 38;
            // 
            // txtOrderID
            // 
            txtOrderID.BackColor = SystemColors.Menu;
            txtOrderID.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtOrderID.Location = new Point(211, 54);
            txtOrderID.Name = "txtOrderID";
            txtOrderID.Size = new Size(84, 38);
            txtOrderID.TabIndex = 2;
            // 
            // label32
            // 
            label32.AutoSize = true;
            label32.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label32.Location = new Point(46, 57);
            label32.Name = "label32";
            label32.Size = new Size(105, 31);
            label32.TabIndex = 1;
            label32.Text = "OrderID:";
            // 
            // txtDiscount
            // 
            txtDiscount.BackColor = SystemColors.Menu;
            txtDiscount.Font = new Font("Segoe UI", 16.2F);
            txtDiscount.Location = new Point(188, 460);
            txtDiscount.Name = "txtDiscount";
            txtDiscount.Size = new Size(203, 43);
            txtDiscount.TabIndex = 33;
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold);
            label19.Location = new Point(26, 460);
            label19.Name = "label19";
            label19.Size = new Size(141, 38);
            label19.TabIndex = 32;
            label19.Text = "Discount:";
            // 
            // butEliminarOrderDetails
            // 
            butEliminarOrderDetails.Location = new Point(135, 633);
            butEliminarOrderDetails.Name = "butEliminarOrderDetails";
            butEliminarOrderDetails.Size = new Size(148, 61);
            butEliminarOrderDetails.TabIndex = 31;
            butEliminarOrderDetails.Text = "Eliminar";
            butEliminarOrderDetails.UseVisualStyleBackColor = true;
            butEliminarOrderDetails.Click += butEliminarOrderDetails_Click;
            // 
            // butNuevoOrderDetails
            // 
            butNuevoOrderDetails.Location = new Point(247, 556);
            butNuevoOrderDetails.Name = "butNuevoOrderDetails";
            butNuevoOrderDetails.Size = new Size(148, 61);
            butNuevoOrderDetails.TabIndex = 30;
            butNuevoOrderDetails.Text = "Nuevo Registro";
            butNuevoOrderDetails.UseVisualStyleBackColor = true;
            butNuevoOrderDetails.Click += butNuevoOrderDetails_Click;
            // 
            // butGuardarOrderDetails
            // 
            butGuardarOrderDetails.Location = new Point(40, 556);
            butGuardarOrderDetails.Name = "butGuardarOrderDetails";
            butGuardarOrderDetails.Size = new Size(148, 61);
            butGuardarOrderDetails.TabIndex = 29;
            butGuardarOrderDetails.Text = "Guardar/Modificar";
            butGuardarOrderDetails.UseVisualStyleBackColor = true;
            butGuardarOrderDetails.Click += butGuardarOrderDetails_Click;
            // 
            // txtQuantity
            // 
            txtQuantity.BackColor = SystemColors.Menu;
            txtQuantity.Font = new Font("Segoe UI", 16.2F);
            txtQuantity.Location = new Point(188, 373);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(203, 43);
            txtQuantity.TabIndex = 6;
            // 
            // label30
            // 
            label30.AutoSize = true;
            label30.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold);
            label30.Location = new Point(26, 373);
            label30.Name = "label30";
            label30.Size = new Size(140, 38);
            label30.TabIndex = 5;
            label30.Text = "Quantity:";
            // 
            // txtUnitPrice
            // 
            txtUnitPrice.BackColor = SystemColors.Menu;
            txtUnitPrice.Font = new Font("Segoe UI", 16.2F);
            txtUnitPrice.Location = new Point(188, 293);
            txtUnitPrice.Name = "txtUnitPrice";
            txtUnitPrice.Size = new Size(203, 43);
            txtUnitPrice.TabIndex = 4;
            // 
            // label31
            // 
            label31.AutoSize = true;
            label31.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold);
            label31.Location = new Point(26, 293);
            label31.Name = "label31";
            label31.Size = new Size(145, 38);
            label31.TabIndex = 3;
            label31.Text = "UnitPrice:";
            // 
            // label33
            // 
            label33.AutoSize = true;
            label33.Font = new Font("Sitka Banner", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label33.Location = new Point(55, 20);
            label33.Name = "label33";
            label33.Size = new Size(336, 53);
            label33.TabIndex = 0;
            label33.Text = "Datos - Order Details";
            // 
            // panel4
            // 
            panel4.BackColor = Color.LightSkyBlue;
            panel4.Controls.Add(butRefrescarOrderDetails);
            panel4.Controls.Add(butBuscarOrderDetails);
            panel4.Controls.Add(boxBuscarOrderDetails);
            panel4.Controls.Add(txtBuscarOrderDetails);
            panel4.Controls.Add(label35);
            panel4.Controls.Add(label36);
            panel4.Location = new Point(480, 48);
            panel4.Name = "panel4";
            panel4.Size = new Size(875, 103);
            panel4.TabIndex = 50;
            // 
            // butRefrescarOrderDetails
            // 
            butRefrescarOrderDetails.Location = new Point(760, 28);
            butRefrescarOrderDetails.Name = "butRefrescarOrderDetails";
            butRefrescarOrderDetails.Size = new Size(78, 61);
            butRefrescarOrderDetails.TabIndex = 39;
            butRefrescarOrderDetails.Text = "Refrescar";
            butRefrescarOrderDetails.UseVisualStyleBackColor = true;
            butRefrescarOrderDetails.Click += butRefrescarOrderDetails_Click;
            // 
            // butBuscarOrderDetails
            // 
            butBuscarOrderDetails.Location = new Point(657, 28);
            butBuscarOrderDetails.Name = "butBuscarOrderDetails";
            butBuscarOrderDetails.Size = new Size(78, 61);
            butBuscarOrderDetails.TabIndex = 38;
            butBuscarOrderDetails.Text = "Buscar";
            butBuscarOrderDetails.UseVisualStyleBackColor = true;
            butBuscarOrderDetails.Click += butBuscarOrderDetails_Click;
            // 
            // boxBuscarOrderDetails
            // 
            boxBuscarOrderDetails.BackColor = SystemColors.Menu;
            boxBuscarOrderDetails.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            boxBuscarOrderDetails.FormattingEnabled = true;
            boxBuscarOrderDetails.Items.AddRange(new object[] { "OrderID", "ProductID", "UnitPrice", "Quantity", "Discount" });
            boxBuscarOrderDetails.Location = new Point(148, 57);
            boxBuscarOrderDetails.Name = "boxBuscarOrderDetails";
            boxBuscarOrderDetails.Size = new Size(232, 36);
            boxBuscarOrderDetails.TabIndex = 37;
            boxBuscarOrderDetails.SelectedIndexChanged += boxBuscarOrderDetails_SelectedIndexChanged;
            // 
            // txtBuscarOrderDetails
            // 
            txtBuscarOrderDetails.BackColor = SystemColors.Menu;
            txtBuscarOrderDetails.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtBuscarOrderDetails.Location = new Point(410, 59);
            txtBuscarOrderDetails.Name = "txtBuscarOrderDetails";
            txtBuscarOrderDetails.Size = new Size(218, 34);
            txtBuscarOrderDetails.TabIndex = 35;
            txtBuscarOrderDetails.Enter += txtBuscarOrderDetails_Enter;
            // 
            // label35
            // 
            label35.AutoSize = true;
            label35.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label35.Location = new Point(7, 58);
            label35.Name = "label35";
            label35.Size = new Size(135, 31);
            label35.TabIndex = 34;
            label35.Text = "Buscar por:";
            // 
            // label36
            // 
            label36.AutoSize = true;
            label36.Font = new Font("Sitka Banner", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label36.Location = new Point(7, 1);
            label36.Name = "label36";
            label36.Size = new Size(298, 43);
            label36.TabIndex = 33;
            label36.Text = "Busqueda De Registros";
            // 
            // dataGridViewOrderDetails
            // 
            dataGridViewOrderDetails.BackgroundColor = SystemColors.ActiveCaption;
            dataGridViewOrderDetails.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewOrderDetails.Location = new Point(477, 177);
            dataGridViewOrderDetails.Name = "dataGridViewOrderDetails";
            dataGridViewOrderDetails.RowHeadersWidth = 51;
            dataGridViewOrderDetails.Size = new Size(878, 581);
            dataGridViewOrderDetails.TabIndex = 49;
            dataGridViewOrderDetails.SelectionChanged += dataGridViewOrderDetails_SelectionChanged;
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = SystemColors.GradientActiveCaption;
            menuStrip1.Font = new Font("Segoe UI Historic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { archivoToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1362, 36);
            menuStrip1.TabIndex = 52;
            menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            archivoToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { cerrarToolStripMenuItem });
            archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            archivoToolStripMenuItem.Size = new Size(100, 32);
            archivoToolStripMenuItem.Text = "Archivo";
            // 
            // cerrarToolStripMenuItem
            // 
            cerrarToolStripMenuItem.Name = "cerrarToolStripMenuItem";
            cerrarToolStripMenuItem.Size = new Size(157, 32);
            cerrarToolStripMenuItem.Text = "Cerrar";
            cerrarToolStripMenuItem.Click += cerrarToolStripMenuItem_Click;
            // 
            // FormOrderDetails
            // 
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(1362, 770);
            Controls.Add(panel3);
            Controls.Add(panel4);
            Controls.Add(dataGridViewOrderDetails);
            Controls.Add(menuStrip1);
            Name = "FormOrderDetails";
            Load += FormOrderDetails_Load;
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((ISupportInitialize)dataGridViewOrderDetails).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        private Panel panel3;
        private TextBox txtDiscount;
        private Label label19;
        private Button butEliminarOrderDetails;
        private Button butNuevoOrderDetails;
        private Button butGuardarOrderDetails;
        private TextBox txtQuantity;
        private Label label30;
        private TextBox txtUnitPrice;
        private Label label31;
        private TextBox txtOrderID;
        private Label label32;
        private Label label33;
        private Panel panel4;
        private Button butRefrescarOrderDetails;
        private Button butBuscarOrderDetails;
        private ComboBox boxBuscarOrderDetails;
        private TextBox txtBuscarOrderDetails;
        private Label label35;
        private Label label36;
        private DataGridView dataGridViewOrderDetails;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem archivoToolStripMenuItem;
        private Label label2;
        private Label label1;
        private TextBox txtProductID;
        private Panel panel1;
        private ToolStripMenuItem cerrarToolStripMenuItem;

        private void cerrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void refreshPantallaOrderDetails()
        {
            dataGridViewOrderDetails.DataSource = OrderDetailsDAL.PresentarRegistro();
        }

        private void FormOrderDetails_Load(object sender, EventArgs e)
        {
            refreshPantallaOrderDetails();
        }

        private void dataGridViewOrderDetails_SelectionChanged(object sender, EventArgs e)
        {
            txtOrderID.Text = Convert.ToString(dataGridViewOrderDetails.CurrentRow.Cells["OrderID"].Value);
            txtProductID.Text = Convert.ToString(dataGridViewOrderDetails.CurrentRow.Cells["ProductID"].Value);
            txtUnitPrice.Text = Convert.ToString(dataGridViewOrderDetails.CurrentRow.Cells["UnitPrice"].Value);
            txtQuantity.Text = Convert.ToString(dataGridViewOrderDetails.CurrentRow.Cells["Quantity"].Value);
            txtDiscount.Text = Convert.ToString(dataGridViewOrderDetails.CurrentRow.Cells["Discount"].Value);
        }

        private void butGuardarOrderDetails_Click(object sender, EventArgs e)
        {
            OrderDetails orderDetails = new OrderDetails();

            orderDetails.OrderID = Convert.ToInt32(txtOrderID.Text);
            orderDetails.ProductID = Convert.ToInt32(txtProductID.Text);
            orderDetails.UnitPrice = Convert.ToDecimal(txtUnitPrice.Text);
            orderDetails.Quantity = Convert.ToInt32(txtQuantity.Text);
            orderDetails.Discount = float.Parse(txtQuantity.Text);

            if (dataGridViewOrderDetails.SelectedRows.Count == 1)
            {

                int OrderID = Convert.ToInt32(dataGridViewOrderDetails.CurrentRow.Cells["OrderID"].Value);
                int ProductID = Convert.ToInt32(dataGridViewOrderDetails.CurrentRow.Cells["ProductID"].Value);

                if (OrderID != null)
                {
                    orderDetails.OrderID = OrderID;
                    orderDetails.ProductID = ProductID;
                    int result = OrderDetailsDAL.ModificarOrderDetails(orderDetails);

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
                int result = OrderDetailsDAL.AgregarOrderDetailsDAL(orderDetails);

                if (result > 0)
                {
                    MessageBox.Show("Exito al Guardar");
                }
            }
            refreshPantallaOrderDetails();
        }

        private void butNuevoOrderDetails_Click(object sender, EventArgs e)
        {
            dataGridViewOrderDetails.CurrentCell = null;
            txtOrderID.Clear();
            txtProductID.Clear();
            txtUnitPrice.Clear();
            txtQuantity.Clear();
            txtDiscount.Clear();
        }

        private void butEliminarOrderDetails_Click(object sender, EventArgs e)
        {
            // Verificar si se ha seleccionado exactamente una fila en el DataGridView
            if (dataGridViewOrderDetails.SelectedRows.Count == 1)
            {
                // Obtener OrderID y ProductID de la fila seleccionada
                int orderID = Convert.ToInt32(dataGridViewOrderDetails.CurrentRow.Cells["OrderID"].Value);
                int productID = Convert.ToInt32(dataGridViewOrderDetails.CurrentRow.Cells["ProductID"].Value);

                // Confirmación antes de proceder con la eliminación
                DialogResult dialogResult = MessageBox.Show(
                    "¿Está seguro de que desea eliminar este detalle de la orden?",
                    "Confirmar Eliminación",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning
                );

                // Si el usuario confirma la eliminación
                if (dialogResult == DialogResult.Yes)
                {
                    try
                    {
                        // Llamar al método para eliminar el detalle de la orden
                        int resultado = OrderDetailsDAL.EliminarOrderDetails(orderID, productID);

                        // Comprobar si la eliminación fue exitosa
                        if (resultado > 0)
                        {
                            MessageBox.Show("Detalle de la orden eliminado con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("No se pudo eliminar el detalle de la orden. Intente nuevamente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    catch (Exception ex)
                    {
                        // Manejo de excepciones
                        MessageBox.Show("Se produjo un error al intentar eliminar el detalle de la orden: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                // Si no se ha seleccionado ninguna fila
                MessageBox.Show("Debe seleccionar un detalle de la orden para eliminar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            // Refrescar la pantalla después de la eliminación para actualizar los datos en el DataGridView
            refreshPantallaOrderDetails();
        }

        private void butBuscarOrderDetails_Click(object sender, EventArgs e)
        {
            try
            {
                switch (boxBuscarOrderDetails.Text)
                {
                    case "OrderID":
                        int OrderID = Convert.ToInt32(txtBuscarOrderDetails.Text);
                        dataGridViewOrderDetails.DataSource = OrderDetailsDAL.BuscarRegistroOrderID(OrderID);
                        break;
                    case "ProductID":
                        int ProductID = Convert.ToInt32(txtBuscarOrderDetails.Text);
                        dataGridViewOrderDetails.DataSource = OrderDetailsDAL.BuscarRegistroProductID(ProductID);
                        break;
                    case "UnitPrice":
                        decimal UnitPrice = Convert.ToDecimal(txtBuscarOrderDetails.Text);
                        dataGridViewOrderDetails.DataSource = OrderDetailsDAL.BuscarRegistroUnitPrice(UnitPrice);
                        break;
                    case "Quantity":
                        int Quantity = Convert.ToInt32(txtBuscarOrderDetails.Text);
                        dataGridViewOrderDetails.DataSource = OrderDetailsDAL.BuscarRegistroQuantity(Quantity);
                        break;
                    case "Discount":
                        float Discount = float.Parse(txtBuscarOrderDetails.Text);
                        dataGridViewOrderDetails.DataSource = OrderDetailsDAL.BuscarRegistroDiscount(Discount);
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al Buscar");
            }
        }

        private void butRefrescarOrderDetails_Click(object sender, EventArgs e)
        {
            refreshPantallaOrderDetails();
        }

        private void boxBuscarOrderDetails_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (boxBuscarOrderDetails.Text)
            {
                case "OrderID":
                    txtBuscarOrderDetails.Text = "OrderID";
                    txtBuscarOrderDetails.ForeColor = Color.Gray;
                    break;
                case "ProductID":
                    txtBuscarOrderDetails.Text = "ProductID";
                    txtBuscarOrderDetails.ForeColor = Color.Gray;
                    break;
                case "UnitPrice":
                    txtBuscarOrderDetails.Text = "UnitPrice";
                    txtBuscarOrderDetails.ForeColor = Color.Gray;
                    break;
                case "Quantity":
                    txtBuscarOrderDetails.Text = "Quantity";
                    txtBuscarOrderDetails.ForeColor = Color.Gray;
                    break;
                case "Discount":
                    txtBuscarOrderDetails.Text = "Discount";
                    txtBuscarOrderDetails.ForeColor = Color.Gray;
                    break;
            }
        }

        private void txtBuscarOrderDetails_Enter(object sender, EventArgs e)
        {
            txtBuscarOrderDetails.Text = "";
            txtBuscarOrderDetails.ForeColor = Color.Black;
        }
    }
}

