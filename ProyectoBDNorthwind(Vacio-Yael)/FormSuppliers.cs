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
    public partial class FormSuppliers : Form
    {
        public FormSuppliers()
        {
            InitializeComponent();
        }

        private Panel panel2;
        private TextBox txtFax;
        private Label label12;
        private TextBox txtPhone;
        private Label label13;
        private TextBox txtCountry;
        private Label label10;
        private TextBox txtPostalCode;
        private Label label11;
        private TextBox txtRegion;
        private Label label8;
        private TextBox txtCity;
        private Label label9;
        private TextBox txtAddress;
        private Label label6;
        private TextBox txtContactTitle;
        private Label label7;
        private Panel panel1;
        private TextBox txtSupplierID;
        private Label label2;
        private Button butEliminarSuppliers;
        private Button butNuevoSuppliers;
        private Button butGuardarSuppliers;
        private TextBox txtContactName;
        private Label label4;
        private TextBox txtCompanyName;
        private Label label3;
        private Label label1;
        private Panel panelP;
        private Button butRefrescarSuppliers;
        private Button butBuscarSuppliers;
        private ComboBox boxBuscarSuppliers;
        private TextBox txtBuscarSuppliers;
        private Label label17;
        private Label label16;
        private DataGridView dataGridViewSuppliers;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem archivoToolStripMenuItem;
        private TextBox txtHomePage;
        private Label label5;
        private Label label14;
        private ToolStripMenuItem cerrarToolStripMenuItem;

        private void InitializeComponent()
        {
            panel2 = new Panel();
            txtHomePage = new TextBox();
            label5 = new Label();
            txtFax = new TextBox();
            label12 = new Label();
            txtPhone = new TextBox();
            label13 = new Label();
            txtCountry = new TextBox();
            label10 = new Label();
            txtPostalCode = new TextBox();
            label11 = new Label();
            txtRegion = new TextBox();
            label8 = new Label();
            txtCity = new TextBox();
            label9 = new Label();
            txtAddress = new TextBox();
            label6 = new Label();
            txtContactTitle = new TextBox();
            label7 = new Label();
            panel1 = new Panel();
            label14 = new Label();
            txtSupplierID = new TextBox();
            label2 = new Label();
            butEliminarSuppliers = new Button();
            butNuevoSuppliers = new Button();
            butGuardarSuppliers = new Button();
            txtContactName = new TextBox();
            label4 = new Label();
            txtCompanyName = new TextBox();
            label3 = new Label();
            label1 = new Label();
            panelP = new Panel();
            butRefrescarSuppliers = new Button();
            butBuscarSuppliers = new Button();
            boxBuscarSuppliers = new ComboBox();
            txtBuscarSuppliers = new TextBox();
            label17 = new Label();
            label16 = new Label();
            dataGridViewSuppliers = new DataGridView();
            menuStrip1 = new MenuStrip();
            archivoToolStripMenuItem = new ToolStripMenuItem();
            cerrarToolStripMenuItem = new ToolStripMenuItem();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            panelP.SuspendLayout();
            ((ISupportInitialize)dataGridViewSuppliers).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = Color.LightSkyBlue;
            panel2.Controls.Add(txtHomePage);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(txtFax);
            panel2.Controls.Add(label12);
            panel2.Controls.Add(txtPhone);
            panel2.Controls.Add(label13);
            panel2.Controls.Add(txtCountry);
            panel2.Controls.Add(label10);
            panel2.Controls.Add(txtPostalCode);
            panel2.Controls.Add(label11);
            panel2.Controls.Add(txtRegion);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(txtCity);
            panel2.Controls.Add(label9);
            panel2.Controls.Add(txtAddress);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(txtContactTitle);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(panel1);
            panel2.Controls.Add(butEliminarSuppliers);
            panel2.Controls.Add(butNuevoSuppliers);
            panel2.Controls.Add(butGuardarSuppliers);
            panel2.Controls.Add(txtContactName);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(txtCompanyName);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label1);
            panel2.Location = new Point(12, 59);
            panel2.Name = "panel2";
            panel2.Size = new Size(414, 699);
            panel2.TabIndex = 48;
            // 
            // txtHomePage
            // 
            txtHomePage.BackColor = SystemColors.Menu;
            txtHomePage.Font = new Font("Segoe UI", 10.8F);
            txtHomePage.Location = new Point(187, 551);
            txtHomePage.Name = "txtHomePage";
            txtHomePage.Size = new Size(205, 31);
            txtHomePage.TabIndex = 50;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label5.Location = new Point(20, 551);
            label5.Name = "label5";
            label5.Size = new Size(119, 28);
            label5.TabIndex = 49;
            label5.Text = "HomePage:";
            // 
            // txtFax
            // 
            txtFax.BackColor = SystemColors.Menu;
            txtFax.Font = new Font("Segoe UI", 10.8F);
            txtFax.Location = new Point(187, 514);
            txtFax.Name = "txtFax";
            txtFax.Size = new Size(205, 31);
            txtFax.TabIndex = 48;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label12.Location = new Point(21, 480);
            label12.Name = "label12";
            label12.Size = new Size(48, 28);
            label12.TabIndex = 47;
            label12.Text = "Fax:";
            // 
            // txtPhone
            // 
            txtPhone.BackColor = SystemColors.Menu;
            txtPhone.Font = new Font("Segoe UI", 10.8F);
            txtPhone.Location = new Point(187, 477);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(205, 31);
            txtPhone.TabIndex = 46;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label13.Location = new Point(18, 514);
            label13.Name = "label13";
            label13.Size = new Size(76, 28);
            label13.TabIndex = 45;
            label13.Text = "Phone:";
            // 
            // txtCountry
            // 
            txtCountry.BackColor = SystemColors.Menu;
            txtCountry.Font = new Font("Segoe UI", 10.8F);
            txtCountry.Location = new Point(187, 440);
            txtCountry.Name = "txtCountry";
            txtCountry.Size = new Size(205, 31);
            txtCountry.TabIndex = 44;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label10.Location = new Point(20, 440);
            label10.Name = "label10";
            label10.Size = new Size(93, 28);
            label10.TabIndex = 43;
            label10.Text = "Country:";
            // 
            // txtPostalCode
            // 
            txtPostalCode.BackColor = SystemColors.Menu;
            txtPostalCode.Font = new Font("Segoe UI", 10.8F);
            txtPostalCode.Location = new Point(187, 403);
            txtPostalCode.Name = "txtPostalCode";
            txtPostalCode.Size = new Size(205, 31);
            txtPostalCode.TabIndex = 42;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label11.Location = new Point(18, 403);
            label11.Name = "label11";
            label11.Size = new Size(121, 28);
            label11.TabIndex = 41;
            label11.Text = "PostalCode:";
            // 
            // txtRegion
            // 
            txtRegion.BackColor = SystemColors.Menu;
            txtRegion.Font = new Font("Segoe UI", 10.8F);
            txtRegion.Location = new Point(187, 366);
            txtRegion.Name = "txtRegion";
            txtRegion.Size = new Size(205, 31);
            txtRegion.TabIndex = 40;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label8.Location = new Point(20, 366);
            label8.Name = "label8";
            label8.Size = new Size(83, 28);
            label8.TabIndex = 39;
            label8.Text = "Region:";
            // 
            // txtCity
            // 
            txtCity.BackColor = SystemColors.Menu;
            txtCity.Font = new Font("Segoe UI", 10.8F);
            txtCity.Location = new Point(187, 329);
            txtCity.Name = "txtCity";
            txtCity.Size = new Size(205, 31);
            txtCity.TabIndex = 38;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label9.Location = new Point(21, 329);
            label9.Name = "label9";
            label9.Size = new Size(54, 28);
            label9.TabIndex = 37;
            label9.Text = "City:";
            // 
            // txtAddress
            // 
            txtAddress.BackColor = SystemColors.Menu;
            txtAddress.Font = new Font("Segoe UI", 10.8F);
            txtAddress.Location = new Point(187, 292);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(205, 31);
            txtAddress.TabIndex = 36;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label6.Location = new Point(21, 292);
            label6.Name = "label6";
            label6.Size = new Size(92, 28);
            label6.TabIndex = 35;
            label6.Text = "Address:";
            // 
            // txtContactTitle
            // 
            txtContactTitle.BackColor = SystemColors.Menu;
            txtContactTitle.Font = new Font("Segoe UI", 10.8F);
            txtContactTitle.Location = new Point(187, 255);
            txtContactTitle.Name = "txtContactTitle";
            txtContactTitle.Size = new Size(205, 31);
            txtContactTitle.TabIndex = 34;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label7.Location = new Point(20, 255);
            label7.Name = "label7";
            label7.Size = new Size(133, 28);
            label7.TabIndex = 33;
            label7.Text = "ContactTitle:";
            // 
            // panel1
            // 
            panel1.BackColor = Color.SteelBlue;
            panel1.Controls.Add(label14);
            panel1.Controls.Add(txtSupplierID);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(42, 68);
            panel1.Name = "panel1";
            panel1.Size = new Size(335, 96);
            panel1.TabIndex = 32;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            label14.Location = new Point(30, 51);
            label14.Name = "label14";
            label14.Size = new Size(134, 31);
            label14.TabIndex = 51;
            label14.Text = "SupplierID:";
            // 
            // txtSupplierID
            // 
            txtSupplierID.BackColor = SystemColors.Menu;
            txtSupplierID.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtSupplierID.Location = new Point(206, 44);
            txtSupplierID.Name = "txtSupplierID";
            txtSupplierID.Size = new Size(91, 38);
            txtSupplierID.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(78, 4);
            label2.Name = "label2";
            label2.Size = new Size(147, 38);
            label2.TabIndex = 1;
            label2.Text = " Seleccion";
            // 
            // butEliminarSuppliers
            // 
            butEliminarSuppliers.BackColor = SystemColors.ButtonHighlight;
            butEliminarSuppliers.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            butEliminarSuppliers.Location = new Point(133, 643);
            butEliminarSuppliers.Name = "butEliminarSuppliers";
            butEliminarSuppliers.Size = new Size(148, 45);
            butEliminarSuppliers.TabIndex = 31;
            butEliminarSuppliers.Text = "Eliminar";
            butEliminarSuppliers.UseVisualStyleBackColor = false;
            butEliminarSuppliers.Click += butEliminarSuppliers_Click;
            // 
            // butNuevoSuppliers
            // 
            butNuevoSuppliers.BackColor = SystemColors.ButtonHighlight;
            butNuevoSuppliers.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            butNuevoSuppliers.Location = new Point(229, 592);
            butNuevoSuppliers.Name = "butNuevoSuppliers";
            butNuevoSuppliers.Size = new Size(148, 45);
            butNuevoSuppliers.TabIndex = 30;
            butNuevoSuppliers.Text = "Nuevo Registro";
            butNuevoSuppliers.UseVisualStyleBackColor = false;
            butNuevoSuppliers.Click += butNuevoSuppliers_Click;
            // 
            // butGuardarSuppliers
            // 
            butGuardarSuppliers.BackColor = SystemColors.ButtonHighlight;
            butGuardarSuppliers.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            butGuardarSuppliers.Location = new Point(33, 592);
            butGuardarSuppliers.Name = "butGuardarSuppliers";
            butGuardarSuppliers.Size = new Size(148, 45);
            butGuardarSuppliers.TabIndex = 29;
            butGuardarSuppliers.Text = "Guardar/Modificar";
            butGuardarSuppliers.UseVisualStyleBackColor = false;
            butGuardarSuppliers.Click += butGuardarSuppliers_Click;
            // 
            // txtContactName
            // 
            txtContactName.BackColor = SystemColors.Menu;
            txtContactName.Font = new Font("Segoe UI", 10.8F);
            txtContactName.Location = new Point(187, 215);
            txtContactName.Name = "txtContactName";
            txtContactName.Size = new Size(205, 31);
            txtContactName.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label4.Location = new Point(20, 216);
            label4.Name = "label4";
            label4.Size = new Size(146, 28);
            label4.TabIndex = 5;
            label4.Text = "ContactName:";
            // 
            // txtCompanyName
            // 
            txtCompanyName.BackColor = SystemColors.Menu;
            txtCompanyName.Font = new Font("Segoe UI", 10.8F);
            txtCompanyName.Location = new Point(187, 175);
            txtCompanyName.Name = "txtCompanyName";
            txtCompanyName.Size = new Size(205, 31);
            txtCompanyName.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label3.Location = new Point(20, 176);
            label3.Name = "label3";
            label3.Size = new Size(161, 28);
            label3.TabIndex = 3;
            label3.Text = "CompanyName:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Sitka Banner", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(77, 1);
            label1.Name = "label1";
            label1.Size = new Size(262, 49);
            label1.TabIndex = 0;
            label1.Text = "Datos - Suppliers";
            // 
            // panelP
            // 
            panelP.BackColor = Color.LightSkyBlue;
            panelP.Controls.Add(butRefrescarSuppliers);
            panelP.Controls.Add(butBuscarSuppliers);
            panelP.Controls.Add(boxBuscarSuppliers);
            panelP.Controls.Add(txtBuscarSuppliers);
            panelP.Controls.Add(label17);
            panelP.Controls.Add(label16);
            panelP.Location = new Point(452, 59);
            panelP.Name = "panelP";
            panelP.Size = new Size(1030, 103);
            panelP.TabIndex = 47;
            // 
            // butRefrescarSuppliers
            // 
            butRefrescarSuppliers.BackColor = SystemColors.ButtonHighlight;
            butRefrescarSuppliers.BackgroundImage = Properties.Resources.refresh_16dp_000000_FILL0_wght500_GRAD_25_opsz20__1_;
            butRefrescarSuppliers.BackgroundImageLayout = ImageLayout.Zoom;
            butRefrescarSuppliers.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            butRefrescarSuppliers.Location = new Point(876, 28);
            butRefrescarSuppliers.Name = "butRefrescarSuppliers";
            butRefrescarSuppliers.Size = new Size(127, 61);
            butRefrescarSuppliers.TabIndex = 39;
            butRefrescarSuppliers.UseVisualStyleBackColor = false;
            butRefrescarSuppliers.Click += butRefrescarSuppliers_Click;
            // 
            // butBuscarSuppliers
            // 
            butBuscarSuppliers.BackColor = SystemColors.ButtonHighlight;
            butBuscarSuppliers.BackgroundImage = Properties.Resources.search_16dp_000000_FILL0_wght500_GRAD0_opsz20;
            butBuscarSuppliers.BackgroundImageLayout = ImageLayout.Zoom;
            butBuscarSuppliers.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            butBuscarSuppliers.Location = new Point(717, 28);
            butBuscarSuppliers.Name = "butBuscarSuppliers";
            butBuscarSuppliers.Size = new Size(127, 61);
            butBuscarSuppliers.TabIndex = 38;
            butBuscarSuppliers.UseVisualStyleBackColor = false;
            butBuscarSuppliers.Click += butBuscarSuppliers_Click;
            // 
            // boxBuscarSuppliers
            // 
            boxBuscarSuppliers.BackColor = SystemColors.Menu;
            boxBuscarSuppliers.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            boxBuscarSuppliers.FormattingEnabled = true;
            boxBuscarSuppliers.Items.AddRange(new object[] { "SupplierID", "CompanyName", "ContactName", "ContactTitle", "Address", "City", "Region", "PostalCode", "Country", "Phone" });
            boxBuscarSuppliers.Location = new Point(169, 53);
            boxBuscarSuppliers.Name = "boxBuscarSuppliers";
            boxBuscarSuppliers.Size = new Size(232, 36);
            boxBuscarSuppliers.TabIndex = 37;
            boxBuscarSuppliers.SelectedIndexChanged += boxBuscarSuppliers_SelectedIndexChanged;
            // 
            // txtBuscarSuppliers
            // 
            txtBuscarSuppliers.BackColor = SystemColors.Menu;
            txtBuscarSuppliers.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtBuscarSuppliers.Location = new Point(429, 53);
            txtBuscarSuppliers.Name = "txtBuscarSuppliers";
            txtBuscarSuppliers.Size = new Size(218, 34);
            txtBuscarSuppliers.TabIndex = 35;
            txtBuscarSuppliers.Enter += txtBuscarSuppliers_Enter;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label17.Location = new Point(7, 58);
            label17.Name = "label17";
            label17.Size = new Size(135, 31);
            label17.TabIndex = 34;
            label17.Text = "Buscar por:";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Sitka Banner", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label16.Location = new Point(7, 1);
            label16.Name = "label16";
            label16.Size = new Size(298, 43);
            label16.TabIndex = 33;
            label16.Text = "Busqueda De Registros";
            // 
            // dataGridViewSuppliers
            // 
            dataGridViewSuppliers.BackgroundColor = SystemColors.ActiveCaption;
            dataGridViewSuppliers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewSuppliers.Location = new Point(450, 187);
            dataGridViewSuppliers.Name = "dataGridViewSuppliers";
            dataGridViewSuppliers.RowHeadersWidth = 51;
            dataGridViewSuppliers.Size = new Size(1035, 571);
            dataGridViewSuppliers.TabIndex = 46;
            dataGridViewSuppliers.SelectionChanged += dataGridViewSuppliers_SelectionChanged;
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = SystemColors.GradientActiveCaption;
            menuStrip1.Font = new Font("Segoe UI Symbol", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { archivoToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1492, 36);
            menuStrip1.TabIndex = 49;
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
            // FormSuppliers
            // 
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(1492, 770);
            Controls.Add(panel2);
            Controls.Add(panelP);
            Controls.Add(dataGridViewSuppliers);
            Controls.Add(menuStrip1);
            Name = "FormSuppliers";
            Load += FormSuppliers_Load;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panelP.ResumeLayout(false);
            panelP.PerformLayout();
            ((ISupportInitialize)dataGridViewSuppliers).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        private void cerrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Metodo refrescar
        public void refreshPantallaSuppliers()
        {
            dataGridViewSuppliers.DataSource = SuppliersDAL.PresentarRegistro();
        }

        // Codigo ejecutado a cargar el form, mostrar info
        private void FormSuppliers_Load(object sender, EventArgs e)
        {
            refreshPantallaSuppliers();
            txtSupplierID.Enabled = false;
        }

        private void dataGridViewSuppliers_SelectionChanged(object sender, EventArgs e)
        {
            txtSupplierID.Text = Convert.ToString(dataGridViewSuppliers.CurrentRow.Cells["SupplierID"].Value);
            txtCompanyName.Text = Convert.ToString(dataGridViewSuppliers.CurrentRow.Cells["CompanyName"].Value);
            txtContactName.Text = Convert.ToString(dataGridViewSuppliers.CurrentRow.Cells["ContactName"].Value);
            txtContactTitle.Text = Convert.ToString(dataGridViewSuppliers.CurrentRow.Cells["ContactTitle"].Value);
            txtAddress.Text = Convert.ToString(dataGridViewSuppliers.CurrentRow.Cells["Address"].Value);
            txtCity.Text = Convert.ToString(dataGridViewSuppliers.CurrentRow.Cells["City"].Value);
            txtRegion.Text = Convert.ToString(dataGridViewSuppliers.CurrentRow.Cells["Region"].Value);
            txtPostalCode.Text = Convert.ToString(dataGridViewSuppliers.CurrentRow.Cells["PostalCode"].Value);
            txtCountry.Text = Convert.ToString(dataGridViewSuppliers.CurrentRow.Cells["Country"].Value);
            txtPhone.Text = Convert.ToString(dataGridViewSuppliers.CurrentRow.Cells["Phone"].Value);
            txtFax.Text = Convert.ToString(dataGridViewSuppliers.CurrentRow.Cells["Fax"].Value);
            txtHomePage.Text = Convert.ToString(dataGridViewSuppliers.CurrentRow.Cells["HomePage"].Value);
        }

        private void butGuardarSuppliers_Click(object sender, EventArgs e)
        {
            Suppliers supplier = new Suppliers();

            // Asignamos los valores de los controles del formulario a la instancia de Supplier
            supplier.CompanyName = txtCompanyName.Text;
            supplier.ContactName = txtContactName.Text;
            supplier.ContactTitle = txtContactTitle.Text;
            supplier.Address = txtAddress.Text;
            supplier.City = txtCity.Text;
            supplier.Region = txtRegion.Text;
            supplier.PostalCode = txtPostalCode.Text;
            supplier.Country = txtCountry.Text;
            supplier.Phone = txtPhone.Text;
            supplier.Fax = txtFax.Text;
            supplier.HomePage = txtHomePage.Text;

            // Verificamos si se ha seleccionado una fila en el DataGridView
            if (dataGridViewSuppliers.SelectedRows.Count == 1)
            {
                // Si hay una fila seleccionada, obtenemos el SupplierID para modificar el proveedor
                int id = Convert.ToInt32(dataGridViewSuppliers.CurrentRow.Cells["SupplierID"].Value);

                if (id != null)
                {
                    supplier.SupplierID = id;

                    // Llamamos al método para modificar el proveedor
                    int result = SuppliersDAL.ModificarSupplier(supplier);

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
                // Si no hay ninguna fila seleccionada, agregamos un nuevo proveedor
                int result = SuppliersDAL.AgregarSupplier(supplier);

                if (result > 0)
                {
                    MessageBox.Show("Exito al Guardar");
                }
            }

            refreshPantallaSuppliers(); // Refresca la pantalla de los proveedores

        }

        private void butNuevoSuppliers_Click(object sender, EventArgs e)
        {
            dataGridViewSuppliers.CurrentCell = null;
            txtSupplierID.Clear();
            txtCompanyName.Clear();
            txtContactName.Clear();
            txtContactTitle.Clear();
            txtAddress.Clear();
            txtCity.Clear();
            txtRegion.Clear();
            txtPostalCode.Clear();
            txtCountry.Clear();
            txtPhone.Clear();
            txtFax.Clear();
            txtHomePage.Clear();
        }

        private void butEliminarSuppliers_Click(object sender, EventArgs e)
        {
            // Verificar si se ha seleccionado exactamente una fila en el DataGridView
            if (dataGridViewSuppliers.SelectedRows.Count == 1)
            {
                // Obtener el SupplierID de la fila seleccionada
                int supplierId = Convert.ToInt32(dataGridViewSuppliers.CurrentRow.Cells["SupplierID"].Value);

                // Confirmación antes de proceder con la eliminación
                DialogResult dialogResult = MessageBox.Show(
                    "¿Está seguro de que desea eliminar este proveedor?",
                    "Confirmar Eliminación",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning
                );

                // Si el usuario confirma la eliminación
                if (dialogResult == DialogResult.Yes)
                {
                    try
                    {
                        // Llamar al método para eliminar el proveedor
                        int resultado = SuppliersDAL.EliminarSupplier(supplierId);

                        // Comprobar si la eliminación fue exitosa
                        if (resultado > 0)
                        {
                            MessageBox.Show("Proveedor eliminado con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("No se pudo eliminar el proveedor. Intente nuevamente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    catch (Exception ex)
                    {
                        // Manejo de excepciones
                        MessageBox.Show("Se produjo un error al intentar eliminar el proveedor: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                // Si no se ha seleccionado ninguna fila
                MessageBox.Show("Debe seleccionar un proveedor para eliminar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            // Refrescar la pantalla después de la eliminación para actualizar los datos en el DataGridView
            refreshPantallaSuppliers();
        }

        private void butBuscarSuppliers_Click(object sender, EventArgs e)
        {
            try
            {
                switch (boxBuscarSuppliers.Text)
                {
                    case "SupplierID":
                        int supplierID = Convert.ToInt32(txtBuscarSuppliers.Text);
                        dataGridViewSuppliers.DataSource = SuppliersDAL.BuscarRegistroSupplierID(supplierID);
                        break;
                    case "CompanyName":
                        string companyName = txtBuscarSuppliers.Text;
                        dataGridViewSuppliers.DataSource = SuppliersDAL.BuscarRegistroCompanyName(companyName);
                        break;
                    case "ContactName":
                        string contactName = txtBuscarSuppliers.Text;
                        dataGridViewSuppliers.DataSource = SuppliersDAL.BuscarRegistroContactName(contactName);
                        break;
                    case "ContactTitle":
                        string contactTitle = txtBuscarSuppliers.Text;
                        dataGridViewSuppliers.DataSource = SuppliersDAL.BuscarRegistroContactTitle(contactTitle);
                        break;
                    case "Address":
                        string address = txtBuscarSuppliers.Text;
                        dataGridViewSuppliers.DataSource = SuppliersDAL.BuscarRegistroAddress(address);
                        break;
                    case "City":
                        string city = txtBuscarSuppliers.Text;
                        dataGridViewSuppliers.DataSource = SuppliersDAL.BuscarRegistroCity(city);
                        break;
                    case "Region":
                        string region = txtBuscarSuppliers.Text;
                        dataGridViewSuppliers.DataSource = SuppliersDAL.BuscarRegistroRegion(region);
                        break;
                    case "PostalCode":
                        string postalCode = txtBuscarSuppliers.Text;
                        dataGridViewSuppliers.DataSource = SuppliersDAL.BuscarRegistroPostalCode(postalCode);
                        break;
                    case "Country":
                        string country = txtBuscarSuppliers.Text;
                        dataGridViewSuppliers.DataSource = SuppliersDAL.BuscarRegistroCountry(country);
                        break;
                    case "Phone":
                        string phone = txtBuscarSuppliers.Text;
                        dataGridViewSuppliers.DataSource = SuppliersDAL.BuscarRegistroPhone(phone);
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

        private void butRefrescarSuppliers_Click(object sender, EventArgs e)
        {
            refreshPantallaSuppliers();
        }

        private void boxBuscarSuppliers_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (boxBuscarSuppliers.Text)
            {
                case "SupplierID":
                    txtBuscarSuppliers.Text = "SupplierID";
                    txtBuscarSuppliers.ForeColor = Color.Gray;
                    break;
                case "CompanyName":
                    txtBuscarSuppliers.Text = "CompanyName";
                    txtBuscarSuppliers.ForeColor = Color.Gray;
                    break;
                case "ContactName":
                    txtBuscarSuppliers.Text = "ContactName";
                    txtBuscarSuppliers.ForeColor = Color.Gray;
                    break;
                case "ContactTitle":
                    txtBuscarSuppliers.Text = "ContactTitle";
                    txtBuscarSuppliers.ForeColor = Color.Gray;
                    break;
                case "Address":
                    txtBuscarSuppliers.Text = "Address";
                    txtBuscarSuppliers.ForeColor = Color.Gray;
                    break;
                case "City":
                    txtBuscarSuppliers.Text = "City";
                    txtBuscarSuppliers.ForeColor = Color.Gray;
                    break;
                case "Region":
                    txtBuscarSuppliers.Text = "Region";
                    txtBuscarSuppliers.ForeColor = Color.Gray;
                    break;
                case "PostalCode":
                    txtBuscarSuppliers.Text = "PostalCode";
                    txtBuscarSuppliers.ForeColor = Color.Gray;
                    break;
                case "Country":
                    txtBuscarSuppliers.Text = "Country";
                    txtBuscarSuppliers.ForeColor = Color.Gray;
                    break;
                case "Phone":
                    txtBuscarSuppliers.Text = "Phone";
                    txtBuscarSuppliers.ForeColor = Color.Gray;
                    break;
                default:
                    MessageBox.Show("Seleccione un criterio de búsqueda válido.");
                    break;
            }
        }

        private void txtBuscarSuppliers_Enter(object sender, EventArgs e)
        {
            txtBuscarSuppliers.Text = "";
            txtBuscarSuppliers.ForeColor = Color.Black;
        }
    }
}


