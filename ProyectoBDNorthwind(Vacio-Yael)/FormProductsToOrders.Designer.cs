namespace ProyectoBDNorthwind_Vacio_Yael_
{
    partial class FormProductsToOrders
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
            button2 = new Button();
            lblContador = new Label();
            boxNumProducts = new ComboBox();
            label2 = new Label();
            button1 = new Button();
            boxProductID = new ComboBox();
            panel1 = new Panel();
            boxOrderID = new ComboBox();
            label32 = new Label();
            label1 = new Label();
            txtDiscount = new TextBox();
            label19 = new Label();
            butGuardarOrderDetails = new Button();
            txtQuantity = new TextBox();
            label30 = new Label();
            txtUnitPrice = new TextBox();
            label31 = new Label();
            label33 = new Label();
            menuStrip1 = new MenuStrip();
            archivoToolStripMenuItem = new ToolStripMenuItem();
            cerrarToolStripMenuItem = new ToolStripMenuItem();
            panel3.SuspendLayout();
            panel1.SuspendLayout();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // panel3
            // 
            panel3.BackColor = Color.LightSkyBlue;
            panel3.Controls.Add(button2);
            panel3.Controls.Add(lblContador);
            panel3.Controls.Add(boxNumProducts);
            panel3.Controls.Add(label2);
            panel3.Controls.Add(button1);
            panel3.Controls.Add(boxProductID);
            panel3.Controls.Add(panel1);
            panel3.Controls.Add(label1);
            panel3.Controls.Add(txtDiscount);
            panel3.Controls.Add(label19);
            panel3.Controls.Add(butGuardarOrderDetails);
            panel3.Controls.Add(txtQuantity);
            panel3.Controls.Add(label30);
            panel3.Controls.Add(txtUnitPrice);
            panel3.Controls.Add(label31);
            panel3.Controls.Add(label33);
            panel3.Location = new Point(12, 51);
            panel3.Name = "panel3";
            panel3.Size = new Size(445, 674);
            panel3.TabIndex = 55;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.ButtonHighlight;
            button2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.Location = new Point(288, 223);
            button2.Name = "button2";
            button2.Size = new Size(106, 38);
            button2.TabIndex = 46;
            button2.Text = "Seleecionar\r\n";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // lblContador
            // 
            lblContador.AutoSize = true;
            lblContador.Font = new Font("Sitka Small", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblContador.Location = new Point(76, 279);
            lblContador.Name = "lblContador";
            lblContador.Size = new Size(217, 44);
            lblContador.TabIndex = 45;
            lblContador.Text = "Producto = 1";
            // 
            // boxNumProducts
            // 
            boxNumProducts.BackColor = SystemColors.Menu;
            boxNumProducts.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            boxNumProducts.FormattingEnabled = true;
            boxNumProducts.Items.AddRange(new object[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10" });
            boxNumProducts.Location = new Point(207, 226);
            boxNumProducts.Name = "boxNumProducts";
            boxNumProducts.Size = new Size(75, 33);
            boxNumProducts.TabIndex = 44;
            boxNumProducts.Text = "1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(37, 226);
            label2.Name = "label2";
            label2.Size = new Size(157, 28);
            label2.TabIndex = 43;
            label2.Text = "Num. Products:";
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ButtonHighlight;
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            button1.Location = new Point(246, 595);
            button1.Name = "button1";
            button1.Size = new Size(148, 61);
            button1.TabIndex = 42;
            button1.Text = "Ver Order-Details";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // boxProductID
            // 
            boxProductID.BackColor = SystemColors.Menu;
            boxProductID.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            boxProductID.FormattingEnabled = true;
            boxProductID.Location = new Point(187, 343);
            boxProductID.Name = "boxProductID";
            boxProductID.Size = new Size(203, 39);
            boxProductID.TabIndex = 41;
            // 
            // panel1
            // 
            panel1.BackColor = Color.SteelBlue;
            panel1.Controls.Add(boxOrderID);
            panel1.Controls.Add(label32);
            panel1.Location = new Point(37, 108);
            panel1.Name = "panel1";
            panel1.Size = new Size(362, 105);
            panel1.TabIndex = 41;
            // 
            // boxOrderID
            // 
            boxOrderID.BackColor = SystemColors.Menu;
            boxOrderID.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            boxOrderID.FormattingEnabled = true;
            boxOrderID.Location = new Point(198, 35);
            boxOrderID.Name = "boxOrderID";
            boxOrderID.Size = new Size(135, 39);
            boxOrderID.TabIndex = 42;
            // 
            // label32
            // 
            label32.AutoSize = true;
            label32.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label32.Location = new Point(39, 33);
            label32.Name = "label32";
            label32.Size = new Size(130, 38);
            label32.TabIndex = 1;
            label32.Text = "OrderID:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(25, 344);
            label1.Name = "label1";
            label1.Size = new Size(128, 38);
            label1.TabIndex = 39;
            label1.Text = "Product:";
            // 
            // txtDiscount
            // 
            txtDiscount.BackColor = SystemColors.Menu;
            txtDiscount.Font = new Font("Segoe UI", 16.2F);
            txtDiscount.Location = new Point(187, 533);
            txtDiscount.Name = "txtDiscount";
            txtDiscount.Size = new Size(203, 43);
            txtDiscount.TabIndex = 33;
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold);
            label19.Location = new Point(25, 533);
            label19.Name = "label19";
            label19.Size = new Size(141, 38);
            label19.TabIndex = 32;
            label19.Text = "Discount:";
            // 
            // butGuardarOrderDetails
            // 
            butGuardarOrderDetails.BackColor = SystemColors.ButtonHighlight;
            butGuardarOrderDetails.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            butGuardarOrderDetails.Location = new Point(37, 595);
            butGuardarOrderDetails.Name = "butGuardarOrderDetails";
            butGuardarOrderDetails.Size = new Size(148, 61);
            butGuardarOrderDetails.TabIndex = 29;
            butGuardarOrderDetails.Text = "Agregar";
            butGuardarOrderDetails.UseVisualStyleBackColor = false;
            butGuardarOrderDetails.Click += butGuardarOrderDetails_Click;
            // 
            // txtQuantity
            // 
            txtQuantity.BackColor = SystemColors.Menu;
            txtQuantity.Font = new Font("Segoe UI", 16.2F);
            txtQuantity.Location = new Point(187, 468);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(203, 43);
            txtQuantity.TabIndex = 6;
            // 
            // label30
            // 
            label30.AutoSize = true;
            label30.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold);
            label30.Location = new Point(25, 468);
            label30.Name = "label30";
            label30.Size = new Size(140, 38);
            label30.TabIndex = 5;
            label30.Text = "Quantity:";
            // 
            // txtUnitPrice
            // 
            txtUnitPrice.BackColor = SystemColors.Menu;
            txtUnitPrice.Font = new Font("Segoe UI", 16.2F);
            txtUnitPrice.Location = new Point(187, 403);
            txtUnitPrice.Name = "txtUnitPrice";
            txtUnitPrice.Size = new Size(203, 43);
            txtUnitPrice.TabIndex = 4;
            // 
            // label31
            // 
            label31.AutoSize = true;
            label31.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold);
            label31.Location = new Point(25, 403);
            label31.Name = "label31";
            label31.Size = new Size(145, 38);
            label31.TabIndex = 3;
            label31.Text = "UnitPrice:";
            // 
            // label33
            // 
            label33.AutoSize = true;
            label33.Font = new Font("Sitka Banner", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label33.Location = new Point(12, 20);
            label33.Name = "label33";
            label33.Size = new Size(430, 53);
            label33.TabIndex = 0;
            label33.Text = "Agregar Productos a Orden\r\n";
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = SystemColors.GradientActiveCaption;
            menuStrip1.Font = new Font("Segoe UI Historic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { archivoToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(475, 36);
            menuStrip1.TabIndex = 56;
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
            // FormProductsToOrders
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            BackgroundImage = Properties.Resources.fondo_azul_para_textura;
            ClientSize = new Size(475, 738);
            Controls.Add(panel3);
            Controls.Add(menuStrip1);
            Name = "FormProductsToOrders";
            Text = "FormProductsToOrders";
            Load += FormProductsToOrders_Load;
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel3;
        private Button button1;
        private Panel panel1;
        private ComboBox boxOrderID;
        private ComboBox boxProductID;
        private Label label1;
        private Label label32;
        private TextBox txtDiscount;
        private Label label19;
        private Button butGuardarOrderDetails;
        private TextBox txtQuantity;
        private Label label30;
        private TextBox txtUnitPrice;
        private Label label31;
        private Label label33;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem archivoToolStripMenuItem;
        private ToolStripMenuItem cerrarToolStripMenuItem;
        private Label lblContador;
        private ComboBox boxNumProducts;
        private Label label2;
        private Button button2;
    }
}