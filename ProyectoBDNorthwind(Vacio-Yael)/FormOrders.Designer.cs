namespace ProyectoBDNorthwind_Vacio_Yael_
{
    partial class FormOrders
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel2 = new Panel();
            boxEmployeeID = new ComboBox();
            boxCustomerID = new ComboBox();
            panel1 = new Panel();
            txtOrderID = new TextBox();
            label2 = new Label();
            butEliminarOrders = new Button();
            butNuevoOrders = new Button();
            butGuardarOrders = new Button();
            txtShipCountry = new TextBox();
            label15 = new Label();
            txtShipPostalCode = new TextBox();
            label14 = new Label();
            txtShipRegion = new TextBox();
            label13 = new Label();
            txtShipCity = new TextBox();
            label12 = new Label();
            txtShipAddress = new TextBox();
            label11 = new Label();
            txtShipName = new TextBox();
            label10 = new Label();
            txtFreight = new TextBox();
            label9 = new Label();
            txtShipVia = new TextBox();
            label8 = new Label();
            dtpShippedDate = new DateTimePicker();
            label7 = new Label();
            dtpRequiredDate = new DateTimePicker();
            label6 = new Label();
            dtpOrderDate = new DateTimePicker();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label1 = new Label();
            panelP = new Panel();
            butRefrescarOrders = new Button();
            butBuscarOrders = new Button();
            boxBuscarOrders = new ComboBox();
            txtBuscarOrders = new TextBox();
            label17 = new Label();
            label16 = new Label();
            dataGridViewOrders = new DataGridView();
            menuStrip1 = new MenuStrip();
            archivoToolStripMenuItem = new ToolStripMenuItem();
            cerrarToolStripMenuItem = new ToolStripMenuItem();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            panelP.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewOrders).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = Color.LightSkyBlue;
            panel2.Controls.Add(boxEmployeeID);
            panel2.Controls.Add(boxCustomerID);
            panel2.Controls.Add(panel1);
            panel2.Controls.Add(butEliminarOrders);
            panel2.Controls.Add(butNuevoOrders);
            panel2.Controls.Add(butGuardarOrders);
            panel2.Controls.Add(txtShipCountry);
            panel2.Controls.Add(label15);
            panel2.Controls.Add(txtShipPostalCode);
            panel2.Controls.Add(label14);
            panel2.Controls.Add(txtShipRegion);
            panel2.Controls.Add(label13);
            panel2.Controls.Add(txtShipCity);
            panel2.Controls.Add(label12);
            panel2.Controls.Add(txtShipAddress);
            panel2.Controls.Add(label11);
            panel2.Controls.Add(txtShipName);
            panel2.Controls.Add(label10);
            panel2.Controls.Add(txtFreight);
            panel2.Controls.Add(label9);
            panel2.Controls.Add(txtShipVia);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(dtpShippedDate);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(dtpRequiredDate);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(dtpOrderDate);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label1);
            panel2.Location = new Point(12, 44);
            panel2.Name = "panel2";
            panel2.Size = new Size(414, 688);
            panel2.TabIndex = 44;
            // 
            // boxEmployeeID
            // 
            boxEmployeeID.BackColor = SystemColors.Menu;
            boxEmployeeID.FormattingEnabled = true;
            boxEmployeeID.Location = new Point(174, 145);
            boxEmployeeID.Name = "boxEmployeeID";
            boxEmployeeID.Size = new Size(220, 28);
            boxEmployeeID.TabIndex = 34;
            // 
            // boxCustomerID
            // 
            boxCustomerID.BackColor = SystemColors.Menu;
            boxCustomerID.FormattingEnabled = true;
            boxCustomerID.Location = new Point(174, 107);
            boxCustomerID.Name = "boxCustomerID";
            boxCustomerID.Size = new Size(220, 28);
            boxCustomerID.TabIndex = 33;
            // 
            // panel1
            // 
            panel1.BackColor = Color.SteelBlue;
            panel1.Controls.Add(txtOrderID);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(22, 44);
            panel1.Name = "panel1";
            panel1.Size = new Size(335, 59);
            panel1.TabIndex = 32;
            // 
            // txtOrderID
            // 
            txtOrderID.BackColor = SystemColors.Menu;
            txtOrderID.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtOrderID.Location = new Point(222, 14);
            txtOrderID.Name = "txtOrderID";
            txtOrderID.Size = new Size(84, 31);
            txtOrderID.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(15, 16);
            label2.Name = "label2";
            label2.Size = new Size(175, 25);
            label2.TabIndex = 1;
            label2.Text = " Seleccion OrderID:";
            // 
            // butEliminarOrders
            // 
            butEliminarOrders.BackColor = SystemColors.ButtonHighlight;
            butEliminarOrders.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            butEliminarOrders.Location = new Point(119, 634);
            butEliminarOrders.Name = "butEliminarOrders";
            butEliminarOrders.Size = new Size(148, 45);
            butEliminarOrders.TabIndex = 31;
            butEliminarOrders.Text = "Eliminar";
            butEliminarOrders.UseVisualStyleBackColor = false;
            butEliminarOrders.Click += butEliminarOrders_Click;
            // 
            // butNuevoOrders
            // 
            butNuevoOrders.BackColor = SystemColors.ButtonHighlight;
            butNuevoOrders.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            butNuevoOrders.Location = new Point(229, 583);
            butNuevoOrders.Name = "butNuevoOrders";
            butNuevoOrders.Size = new Size(148, 45);
            butNuevoOrders.TabIndex = 30;
            butNuevoOrders.Text = "Nuevo Registro";
            butNuevoOrders.UseVisualStyleBackColor = false;
            butNuevoOrders.Click += butNuevoOrders_Click;
            // 
            // butGuardarOrders
            // 
            butGuardarOrders.BackColor = SystemColors.ButtonHighlight;
            butGuardarOrders.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            butGuardarOrders.Location = new Point(22, 583);
            butGuardarOrders.Name = "butGuardarOrders";
            butGuardarOrders.Size = new Size(148, 45);
            butGuardarOrders.TabIndex = 29;
            butGuardarOrders.Text = "Guardar/Modificar";
            butGuardarOrders.UseVisualStyleBackColor = false;
            butGuardarOrders.Click += butGuardarOrders_Click;
            // 
            // txtShipCountry
            // 
            txtShipCountry.BackColor = SystemColors.Menu;
            txtShipCountry.Location = new Point(176, 543);
            txtShipCountry.Name = "txtShipCountry";
            txtShipCountry.Size = new Size(218, 27);
            txtShipCountry.TabIndex = 28;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label15.Location = new Point(22, 542);
            label15.Name = "label15";
            label15.Size = new Size(123, 25);
            label15.TabIndex = 27;
            label15.Text = "ShipCountry:";
            // 
            // txtShipPostalCode
            // 
            txtShipPostalCode.BackColor = SystemColors.Menu;
            txtShipPostalCode.Location = new Point(176, 507);
            txtShipPostalCode.Name = "txtShipPostalCode";
            txtShipPostalCode.Size = new Size(218, 27);
            txtShipPostalCode.TabIndex = 26;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label14.Location = new Point(22, 506);
            label14.Name = "label14";
            label14.Size = new Size(148, 25);
            label14.TabIndex = 25;
            label14.Text = "ShipPostalCode:";
            // 
            // txtShipRegion
            // 
            txtShipRegion.BackColor = SystemColors.Menu;
            txtShipRegion.Location = new Point(176, 471);
            txtShipRegion.Name = "txtShipRegion";
            txtShipRegion.Size = new Size(218, 27);
            txtShipRegion.TabIndex = 24;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label13.Location = new Point(22, 470);
            label13.Name = "label13";
            label13.Size = new Size(114, 25);
            label13.TabIndex = 23;
            label13.Text = "ShipRegion:";
            // 
            // txtShipCity
            // 
            txtShipCity.BackColor = SystemColors.Menu;
            txtShipCity.Location = new Point(176, 435);
            txtShipCity.Name = "txtShipCity";
            txtShipCity.Size = new Size(218, 27);
            txtShipCity.TabIndex = 22;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.Location = new Point(22, 434);
            label12.Name = "label12";
            label12.Size = new Size(87, 25);
            label12.TabIndex = 21;
            label12.Text = "ShipCity:";
            // 
            // txtShipAddress
            // 
            txtShipAddress.BackColor = SystemColors.Menu;
            txtShipAddress.Location = new Point(174, 396);
            txtShipAddress.Name = "txtShipAddress";
            txtShipAddress.Size = new Size(220, 27);
            txtShipAddress.TabIndex = 20;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.Location = new Point(20, 395);
            label11.Name = "label11";
            label11.Size = new Size(122, 25);
            label11.TabIndex = 19;
            label11.Text = "ShipAddress:";
            // 
            // txtShipName
            // 
            txtShipName.BackColor = SystemColors.Menu;
            txtShipName.Location = new Point(174, 360);
            txtShipName.Name = "txtShipName";
            txtShipName.Size = new Size(220, 27);
            txtShipName.TabIndex = 18;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.Location = new Point(20, 359);
            label10.Name = "label10";
            label10.Size = new Size(104, 25);
            label10.TabIndex = 17;
            label10.Text = "ShipName:";
            // 
            // txtFreight
            // 
            txtFreight.BackColor = SystemColors.Menu;
            txtFreight.Location = new Point(174, 324);
            txtFreight.Name = "txtFreight";
            txtFreight.Size = new Size(220, 27);
            txtFreight.TabIndex = 16;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(20, 323);
            label9.Name = "label9";
            label9.Size = new Size(77, 25);
            label9.TabIndex = 15;
            label9.Text = "Freight:";
            // 
            // txtShipVia
            // 
            txtShipVia.BackColor = SystemColors.Menu;
            txtShipVia.Location = new Point(174, 288);
            txtShipVia.Name = "txtShipVia";
            txtShipVia.Size = new Size(220, 27);
            txtShipVia.TabIndex = 14;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(20, 287);
            label8.Name = "label8";
            label8.Size = new Size(81, 25);
            label8.TabIndex = 13;
            label8.Text = "ShipVia:";
            // 
            // dtpShippedDate
            // 
            dtpShippedDate.CustomFormat = "yyyy-MM-dd";
            dtpShippedDate.Format = DateTimePickerFormat.Custom;
            dtpShippedDate.Location = new Point(176, 253);
            dtpShippedDate.Name = "dtpShippedDate";
            dtpShippedDate.Size = new Size(218, 27);
            dtpShippedDate.TabIndex = 12;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(20, 253);
            label7.Name = "label7";
            label7.Size = new Size(126, 25);
            label7.TabIndex = 11;
            label7.Text = "ShippedDate:";
            // 
            // dtpRequiredDate
            // 
            dtpRequiredDate.CustomFormat = "yyyy-MM-dd";
            dtpRequiredDate.Format = DateTimePickerFormat.Custom;
            dtpRequiredDate.Location = new Point(176, 217);
            dtpRequiredDate.Name = "dtpRequiredDate";
            dtpRequiredDate.Size = new Size(218, 27);
            dtpRequiredDate.TabIndex = 10;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(20, 217);
            label6.Name = "label6";
            label6.Size = new Size(134, 25);
            label6.TabIndex = 9;
            label6.Text = "RequiredDate:";
            // 
            // dtpOrderDate
            // 
            dtpOrderDate.CustomFormat = "yyyy-MM-dd";
            dtpOrderDate.Format = DateTimePickerFormat.Custom;
            dtpOrderDate.Location = new Point(176, 178);
            dtpOrderDate.Name = "dtpOrderDate";
            dtpOrderDate.Size = new Size(218, 27);
            dtpOrderDate.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(20, 181);
            label5.Name = "label5";
            label5.Size = new Size(106, 25);
            label5.TabIndex = 7;
            label5.Text = "OrderDate:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(22, 144);
            label4.Name = "label4";
            label4.Size = new Size(119, 25);
            label4.TabIndex = 5;
            label4.Text = "EmployeeID:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(22, 110);
            label3.Name = "label3";
            label3.Size = new Size(117, 25);
            label3.TabIndex = 3;
            label3.Text = "CustomerID:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Sitka Banner", 16.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(94, 2);
            label1.Name = "label1";
            label1.Size = new Size(189, 42);
            label1.TabIndex = 0;
            label1.Text = "Datos - Orders";
            // 
            // panelP
            // 
            panelP.BackColor = Color.LightSkyBlue;
            panelP.Controls.Add(butRefrescarOrders);
            panelP.Controls.Add(butBuscarOrders);
            panelP.Controls.Add(boxBuscarOrders);
            panelP.Controls.Add(txtBuscarOrders);
            panelP.Controls.Add(label17);
            panelP.Controls.Add(label16);
            panelP.Location = new Point(452, 44);
            panelP.Name = "panelP";
            panelP.Size = new Size(1030, 103);
            panelP.TabIndex = 43;
            // 
            // butRefrescarOrders
            // 
            butRefrescarOrders.BackColor = SystemColors.ButtonHighlight;
            butRefrescarOrders.BackgroundImage = Properties.Resources.refresh_16dp_000000_FILL0_wght500_GRAD_25_opsz20__1_;
            butRefrescarOrders.BackgroundImageLayout = ImageLayout.Zoom;
            butRefrescarOrders.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            butRefrescarOrders.Location = new Point(879, 28);
            butRefrescarOrders.Name = "butRefrescarOrders";
            butRefrescarOrders.Size = new Size(116, 61);
            butRefrescarOrders.TabIndex = 39;
            butRefrescarOrders.UseVisualStyleBackColor = false;
            butRefrescarOrders.Click += butRefrescarOrders_Click;
            // 
            // butBuscarOrders
            // 
            butBuscarOrders.BackColor = SystemColors.ButtonHighlight;
            butBuscarOrders.BackgroundImage = Properties.Resources.search_16dp_000000_FILL0_wght500_GRAD0_opsz20;
            butBuscarOrders.BackgroundImageLayout = ImageLayout.Zoom;
            butBuscarOrders.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            butBuscarOrders.Location = new Point(708, 28);
            butBuscarOrders.Name = "butBuscarOrders";
            butBuscarOrders.Size = new Size(116, 61);
            butBuscarOrders.TabIndex = 38;
            butBuscarOrders.UseVisualStyleBackColor = false;
            butBuscarOrders.Click += butBuscarOrders_Click;
            // 
            // boxBuscarOrders
            // 
            boxBuscarOrders.BackColor = SystemColors.Menu;
            boxBuscarOrders.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            boxBuscarOrders.FormattingEnabled = true;
            boxBuscarOrders.Items.AddRange(new object[] { "OrderID", "CustomerID", "EmployeeID", "OrderDate", "RequiredDate", "ShippedDate", "ShipVia", "Freight", "ShipName", "ShipAddress", "ShipCity", "ShipRegion", "ShipPostalCode", "ShipCountry", "CompanyName", "FirstName" });
            boxBuscarOrders.Location = new Point(147, 58);
            boxBuscarOrders.Name = "boxBuscarOrders";
            boxBuscarOrders.Size = new Size(232, 36);
            boxBuscarOrders.TabIndex = 37;
            boxBuscarOrders.SelectedIndexChanged += boxBuscarOrders_SelectedIndexChanged;
            // 
            // txtBuscarOrders
            // 
            txtBuscarOrders.BackColor = SystemColors.Menu;
            txtBuscarOrders.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtBuscarOrders.Location = new Point(406, 58);
            txtBuscarOrders.Name = "txtBuscarOrders";
            txtBuscarOrders.Size = new Size(218, 34);
            txtBuscarOrders.TabIndex = 35;
            txtBuscarOrders.Enter += txtBuscarOrders_Enter;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label17.Location = new Point(7, 58);
            label17.Name = "label17";
            label17.Size = new Size(134, 31);
            label17.TabIndex = 34;
            label17.Text = "Buscar Por:";
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
            // dataGridViewOrders
            // 
            dataGridViewOrders.BackgroundColor = SystemColors.ActiveCaption;
            dataGridViewOrders.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewOrders.Location = new Point(450, 172);
            dataGridViewOrders.Name = "dataGridViewOrders";
            dataGridViewOrders.RowHeadersWidth = 51;
            dataGridViewOrders.Size = new Size(1035, 560);
            dataGridViewOrders.TabIndex = 42;
            dataGridViewOrders.SelectionChanged += dataGridViewOrders_SelectionChanged;
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = SystemColors.GradientActiveCaption;
            menuStrip1.Font = new Font("Segoe UI Symbol", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { archivoToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1498, 36);
            menuStrip1.TabIndex = 45;
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
            // FormOrders
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(1498, 743);
            Controls.Add(panel2);
            Controls.Add(panelP);
            Controls.Add(dataGridViewOrders);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "FormOrders";
            Text = "|";
            Load += FormOrders_Load;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panelP.ResumeLayout(false);
            panelP.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewOrders).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel2;
        private Button butEliminarOrders;
        private Button butNuevoOrders;
        private Button butGuardarOrders;
        private TextBox txtShipCountry;
        private Label label15;
        private TextBox txtShipPostalCode;
        private Label label14;
        private TextBox txtShipRegion;
        private Label label13;
        private TextBox txtShipCity;
        private Label label12;
        private TextBox txtShipAddress;
        private Label label11;
        private TextBox txtShipName;
        private Label label10;
        private TextBox txtFreight;
        private Label label9;
        private TextBox txtShipVia;
        private Label label8;
        private DateTimePicker dtpShippedDate;
        private Label label7;
        private DateTimePicker dtpRequiredDate;
        private Label label6;
        private DateTimePicker dtpOrderDate;
        private Label label5;
        private Label label4;
        private Label label3;
        private TextBox txtOrderID;
        private Label label2;
        private Label label1;
        private Panel panelP;
        private Button butRefrescarOrders;
        private Button butBuscarOrders;
        private ComboBox boxBuscarOrders;
        private TextBox txtBuscarOrders;
        private Label label17;
        private Label label16;
        private DataGridView dataGridViewOrders;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem archivoToolStripMenuItem;
        private ToolStripMenuItem cerrarToolStripMenuItem;
        private Panel panel1;
        private ComboBox boxEmployeeID;
        private ComboBox boxCustomerID;
    }
}