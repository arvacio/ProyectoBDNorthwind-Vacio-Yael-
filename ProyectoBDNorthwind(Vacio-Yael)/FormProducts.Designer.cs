namespace ProyectoBDNorthwind_Vacio_Yael_
{
    partial class FormProducts
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
            panel3 = new Panel();
            boxCategoryID = new ComboBox();
            boxSupplierID = new ComboBox();
            BoxDiscontinued = new ComboBox();
            label25 = new Label();
            txtReorderLevel = new TextBox();
            label23 = new Label();
            txtUnitsOnOrder = new TextBox();
            label24 = new Label();
            txtUnitsInStock = new TextBox();
            label21 = new Label();
            txtUnitPrice = new TextBox();
            label22 = new Label();
            txtQuantityPerUnit = new TextBox();
            label20 = new Label();
            label19 = new Label();
            butEliminarProducts = new Button();
            butNuevoProducts = new Button();
            butGuardarProducts = new Button();
            label30 = new Label();
            txtProductName = new TextBox();
            label31 = new Label();
            txtProductID = new TextBox();
            label32 = new Label();
            label33 = new Label();
            panel4 = new Panel();
            butRefrescarProducts = new Button();
            butBuscarProducts = new Button();
            boxBuscarProducts = new ComboBox();
            txtBuscarProducts = new TextBox();
            label35 = new Label();
            label36 = new Label();
            dataGridViewProducts = new DataGridView();
            menuStrip1 = new MenuStrip();
            archivoToolStripMenuItem = new ToolStripMenuItem();
            cerrarToolStripMenuItem = new ToolStripMenuItem();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewProducts).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // panel3
            // 
            panel3.BackColor = Color.LightSkyBlue;
            panel3.Controls.Add(boxCategoryID);
            panel3.Controls.Add(boxSupplierID);
            panel3.Controls.Add(BoxDiscontinued);
            panel3.Controls.Add(label25);
            panel3.Controls.Add(txtReorderLevel);
            panel3.Controls.Add(label23);
            panel3.Controls.Add(txtUnitsOnOrder);
            panel3.Controls.Add(label24);
            panel3.Controls.Add(txtUnitsInStock);
            panel3.Controls.Add(label21);
            panel3.Controls.Add(txtUnitPrice);
            panel3.Controls.Add(label22);
            panel3.Controls.Add(txtQuantityPerUnit);
            panel3.Controls.Add(label20);
            panel3.Controls.Add(label19);
            panel3.Controls.Add(butEliminarProducts);
            panel3.Controls.Add(butNuevoProducts);
            panel3.Controls.Add(butGuardarProducts);
            panel3.Controls.Add(label30);
            panel3.Controls.Add(txtProductName);
            panel3.Controls.Add(label31);
            panel3.Controls.Add(txtProductID);
            panel3.Controls.Add(label32);
            panel3.Controls.Add(label33);
            panel3.Location = new Point(12, 42);
            panel3.Name = "panel3";
            panel3.Size = new Size(414, 709);
            panel3.TabIndex = 47;
            // 
            // boxCategoryID
            // 
            boxCategoryID.BackColor = SystemColors.Menu;
            boxCategoryID.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            boxCategoryID.FormattingEnabled = true;
            boxCategoryID.Location = new Point(193, 227);
            boxCategoryID.Name = "boxCategoryID";
            boxCategoryID.Size = new Size(203, 39);
            boxCategoryID.TabIndex = 48;
            // 
            // boxSupplierID
            // 
            boxSupplierID.BackColor = SystemColors.Menu;
            boxSupplierID.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            boxSupplierID.FormattingEnabled = true;
            boxSupplierID.Location = new Point(193, 182);
            boxSupplierID.Name = "boxSupplierID";
            boxSupplierID.Size = new Size(203, 39);
            boxSupplierID.TabIndex = 47;
            // 
            // BoxDiscontinued
            // 
            BoxDiscontinued.BackColor = SystemColors.Menu;
            BoxDiscontinued.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BoxDiscontinued.FormattingEnabled = true;
            BoxDiscontinued.Items.AddRange(new object[] { "Si", "No" });
            BoxDiscontinued.Location = new Point(190, 495);
            BoxDiscontinued.Name = "BoxDiscontinued";
            BoxDiscontinued.Size = new Size(206, 39);
            BoxDiscontinued.TabIndex = 46;
            // 
            // label25
            // 
            label25.AutoSize = true;
            label25.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label25.Location = new Point(13, 500);
            label25.Name = "label25";
            label25.Size = new Size(142, 28);
            label25.TabIndex = 44;
            label25.Text = "Discontinued:";
            // 
            // txtReorderLevel
            // 
            txtReorderLevel.BackColor = SystemColors.Menu;
            txtReorderLevel.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtReorderLevel.Location = new Point(193, 446);
            txtReorderLevel.Name = "txtReorderLevel";
            txtReorderLevel.Size = new Size(203, 38);
            txtReorderLevel.TabIndex = 43;
            // 
            // label23
            // 
            label23.AutoSize = true;
            label23.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label23.Location = new Point(13, 456);
            label23.Name = "label23";
            label23.Size = new Size(141, 28);
            label23.TabIndex = 42;
            label23.Text = "ReorderLevel:";
            // 
            // txtUnitsOnOrder
            // 
            txtUnitsOnOrder.BackColor = SystemColors.Menu;
            txtUnitsOnOrder.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtUnitsOnOrder.Location = new Point(193, 402);
            txtUnitsOnOrder.Name = "txtUnitsOnOrder";
            txtUnitsOnOrder.Size = new Size(203, 38);
            txtUnitsOnOrder.TabIndex = 41;
            // 
            // label24
            // 
            label24.AutoSize = true;
            label24.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label24.Location = new Point(13, 412);
            label24.Name = "label24";
            label24.Size = new Size(148, 28);
            label24.TabIndex = 40;
            label24.Text = "UnitsOnOrder:";
            // 
            // txtUnitsInStock
            // 
            txtUnitsInStock.BackColor = SystemColors.Menu;
            txtUnitsInStock.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtUnitsInStock.Location = new Point(193, 358);
            txtUnitsInStock.Name = "txtUnitsInStock";
            txtUnitsInStock.Size = new Size(203, 38);
            txtUnitsInStock.TabIndex = 39;
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label21.Location = new Point(13, 368);
            label21.Name = "label21";
            label21.Size = new Size(137, 28);
            label21.TabIndex = 38;
            label21.Text = "UnitsInStock:";
            // 
            // txtUnitPrice
            // 
            txtUnitPrice.BackColor = SystemColors.Menu;
            txtUnitPrice.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtUnitPrice.Location = new Point(193, 314);
            txtUnitPrice.Name = "txtUnitPrice";
            txtUnitPrice.Size = new Size(203, 38);
            txtUnitPrice.TabIndex = 37;
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label22.Location = new Point(13, 324);
            label22.Name = "label22";
            label22.Size = new Size(104, 28);
            label22.TabIndex = 36;
            label22.Text = "UnitPrice:";
            // 
            // txtQuantityPerUnit
            // 
            txtQuantityPerUnit.BackColor = SystemColors.Menu;
            txtQuantityPerUnit.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtQuantityPerUnit.Location = new Point(193, 270);
            txtQuantityPerUnit.Name = "txtQuantityPerUnit";
            txtQuantityPerUnit.Size = new Size(203, 38);
            txtQuantityPerUnit.TabIndex = 35;
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label20.Location = new Point(13, 280);
            label20.Name = "label20";
            label20.Size = new Size(170, 28);
            label20.TabIndex = 34;
            label20.Text = "QuantityPerUnit:";
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label19.Location = new Point(13, 236);
            label19.Name = "label19";
            label19.Size = new Size(124, 28);
            label19.TabIndex = 32;
            label19.Text = "CategoryID:";
            // 
            // butEliminarProducts
            // 
            butEliminarProducts.BackColor = SystemColors.ButtonHighlight;
            butEliminarProducts.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            butEliminarProducts.Location = new Point(117, 639);
            butEliminarProducts.Name = "butEliminarProducts";
            butEliminarProducts.Size = new Size(148, 61);
            butEliminarProducts.TabIndex = 31;
            butEliminarProducts.Text = "Eliminar";
            butEliminarProducts.UseVisualStyleBackColor = false;
            butEliminarProducts.Click += butEliminarProducts_Click;
            // 
            // butNuevoProducts
            // 
            butNuevoProducts.BackColor = SystemColors.ButtonHighlight;
            butNuevoProducts.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            butNuevoProducts.Location = new Point(229, 562);
            butNuevoProducts.Name = "butNuevoProducts";
            butNuevoProducts.Size = new Size(148, 61);
            butNuevoProducts.TabIndex = 30;
            butNuevoProducts.Text = "Nuevo Registro";
            butNuevoProducts.UseVisualStyleBackColor = false;
            butNuevoProducts.Click += butNuevoProducts_Click;
            // 
            // butGuardarProducts
            // 
            butGuardarProducts.BackColor = SystemColors.ButtonHighlight;
            butGuardarProducts.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            butGuardarProducts.Location = new Point(22, 562);
            butGuardarProducts.Name = "butGuardarProducts";
            butGuardarProducts.Size = new Size(148, 61);
            butGuardarProducts.TabIndex = 29;
            butGuardarProducts.Text = "Guardar/Modificar";
            butGuardarProducts.UseVisualStyleBackColor = false;
            butGuardarProducts.Click += butGuardarProducts_Click;
            // 
            // label30
            // 
            label30.AutoSize = true;
            label30.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label30.Location = new Point(13, 192);
            label30.Name = "label30";
            label30.Size = new Size(116, 28);
            label30.TabIndex = 5;
            label30.Text = "SupplierID:";
            // 
            // txtProductName
            // 
            txtProductName.BackColor = SystemColors.Menu;
            txtProductName.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtProductName.Location = new Point(193, 138);
            txtProductName.Name = "txtProductName";
            txtProductName.Size = new Size(203, 38);
            txtProductName.TabIndex = 4;
            // 
            // label31
            // 
            label31.AutoSize = true;
            label31.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label31.Location = new Point(13, 148);
            label31.Name = "label31";
            label31.Size = new Size(147, 28);
            label31.TabIndex = 3;
            label31.Text = "ProductName:";
            // 
            // txtProductID
            // 
            txtProductID.BackColor = SystemColors.Menu;
            txtProductID.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtProductID.Location = new Point(293, 85);
            txtProductID.Name = "txtProductID";
            txtProductID.Size = new Size(84, 38);
            txtProductID.TabIndex = 2;
            // 
            // label32
            // 
            label32.AutoSize = true;
            label32.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label32.Location = new Point(13, 95);
            label32.Name = "label32";
            label32.Size = new Size(242, 28);
            label32.TabIndex = 1;
            label32.Text = "ProductID Seleccionado:";
            // 
            // label33
            // 
            label33.AutoSize = true;
            label33.Font = new Font("Sitka Banner", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label33.Location = new Point(80, 12);
            label33.Name = "label33";
            label33.Size = new Size(252, 49);
            label33.TabIndex = 0;
            label33.Text = "Datos - Products";
            // 
            // panel4
            // 
            panel4.BackColor = Color.LightSkyBlue;
            panel4.Controls.Add(butRefrescarProducts);
            panel4.Controls.Add(butBuscarProducts);
            panel4.Controls.Add(boxBuscarProducts);
            panel4.Controls.Add(txtBuscarProducts);
            panel4.Controls.Add(label35);
            panel4.Controls.Add(label36);
            panel4.Location = new Point(452, 42);
            panel4.Name = "panel4";
            panel4.Size = new Size(1030, 103);
            panel4.TabIndex = 46;
            // 
            // butRefrescarProducts
            // 
            butRefrescarProducts.BackColor = SystemColors.ButtonHighlight;
            butRefrescarProducts.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            butRefrescarProducts.Image = Properties.Resources.refresh_16dp_000000_FILL0_wght500_GRAD_25_opsz20__1_;
            butRefrescarProducts.Location = new Point(845, 28);
            butRefrescarProducts.Name = "butRefrescarProducts";
            butRefrescarProducts.Size = new Size(138, 61);
            butRefrescarProducts.TabIndex = 39;
            butRefrescarProducts.UseVisualStyleBackColor = false;
            butRefrescarProducts.Click += butRefrescarProducts_Click;
            // 
            // butBuscarProducts
            // 
            butBuscarProducts.BackColor = SystemColors.ButtonHighlight;
            butBuscarProducts.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            butBuscarProducts.Image = Properties.Resources.search_16dp_000000_FILL0_wght500_GRAD_25_opsz20__1_;
            butBuscarProducts.Location = new Point(684, 28);
            butBuscarProducts.Name = "butBuscarProducts";
            butBuscarProducts.Size = new Size(138, 61);
            butBuscarProducts.TabIndex = 38;
            butBuscarProducts.UseVisualStyleBackColor = false;
            butBuscarProducts.Click += butBuscarProducts_Click;
            // 
            // boxBuscarProducts
            // 
            boxBuscarProducts.BackColor = SystemColors.Menu;
            boxBuscarProducts.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            boxBuscarProducts.FormattingEnabled = true;
            boxBuscarProducts.Items.AddRange(new object[] { "ProductID", "ProductName", "SupplierID", "CompanyName", "CategoryID", "CategoryName", "QuantityPerUnit", "UnitPrice", "UnitsInStock", "UnitsOnOrder", "ReorderLevel", "Discontinued", "No Discontinued" });
            boxBuscarProducts.Location = new Point(148, 57);
            boxBuscarProducts.Name = "boxBuscarProducts";
            boxBuscarProducts.Size = new Size(232, 36);
            boxBuscarProducts.TabIndex = 37;
            boxBuscarProducts.SelectedIndexChanged += boxBuscarProducts_SelectedIndexChanged;
            // 
            // txtBuscarProducts
            // 
            txtBuscarProducts.BackColor = SystemColors.Menu;
            txtBuscarProducts.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtBuscarProducts.Location = new Point(410, 59);
            txtBuscarProducts.Name = "txtBuscarProducts";
            txtBuscarProducts.Size = new Size(218, 34);
            txtBuscarProducts.TabIndex = 35;
            txtBuscarProducts.Enter += txtBuscarProducts_Enter;
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
            // dataGridViewProducts
            // 
            dataGridViewProducts.BackgroundColor = SystemColors.ActiveCaption;
            dataGridViewProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewProducts.Location = new Point(450, 170);
            dataGridViewProducts.Name = "dataGridViewProducts";
            dataGridViewProducts.RowHeadersWidth = 51;
            dataGridViewProducts.Size = new Size(1035, 581);
            dataGridViewProducts.TabIndex = 45;
            dataGridViewProducts.SelectionChanged += dataGridViewProducts_SelectionChanged;
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = SystemColors.GradientActiveCaption;
            menuStrip1.Font = new Font("Segoe UI Historic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { archivoToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1509, 36);
            menuStrip1.TabIndex = 48;
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
            // FormProducts
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(1509, 775);
            Controls.Add(panel3);
            Controls.Add(panel4);
            Controls.Add(dataGridViewProducts);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "FormProducts";
            Text = "FormProducts";
            Load += FormProducts_Load;
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewProducts).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel3;
        private Label label25;
        private TextBox txtReorderLevel;
        private Label label23;
        private TextBox txtUnitsOnOrder;
        private Label label24;
        private TextBox txtUnitsInStock;
        private Label label21;
        private TextBox txtUnitPrice;
        private Label label22;
        private TextBox txtQuantityPerUnit;
        private Label label20;
        private Label label19;
        private Button butEliminarProducts;
        private Button butNuevoProducts;
        private Button butGuardarProducts;
        private Label label30;
        private TextBox txtProductName;
        private Label label31;
        private TextBox txtProductID;
        private Label label32;
        private Label label33;
        private Panel panel4;
        private Button butRefrescarProducts;
        private Button butBuscarProducts;
        private ComboBox boxBuscarProducts;
        private TextBox txtBuscarProducts;
        private Label label35;
        private Label label36;
        private DataGridView dataGridViewProducts;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem archivoToolStripMenuItem;
        private ToolStripMenuItem cerrarToolStripMenuItem;
        private ComboBox BoxDiscontinued;
        private ComboBox boxCategoryID;
        private ComboBox boxSupplierID;
    }
}