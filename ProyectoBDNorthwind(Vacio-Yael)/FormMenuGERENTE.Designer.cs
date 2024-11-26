namespace ProyectoBDNorthwind_Vacio_Yael_
{
    partial class FormMenuGERENTE
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMenuGERENTE));
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            label3 = new Label();
            label2 = new Label();
            tabPage2 = new TabPage();
            label14 = new Label();
            label13 = new Label();
            label12 = new Label();
            label11 = new Label();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            tabPage3 = new TabPage();
            label16 = new Label();
            label15 = new Label();
            label1 = new Label();
            menuStrip1 = new MenuStrip();
            tablasToolStripMenuItem = new ToolStripMenuItem();
            ordersToolStripMenuItem = new ToolStripMenuItem();
            productsToolStripMenuItem = new ToolStripMenuItem();
            customersToolStripMenuItem = new ToolStripMenuItem();
            employeesToolStripMenuItem = new ToolStripMenuItem();
            shippersToolStripMenuItem = new ToolStripMenuItem();
            categoriesToolStripMenuItem = new ToolStripMenuItem();
            territoriesToolStripMenuItem = new ToolStripMenuItem();
            regionToolStripMenuItem = new ToolStripMenuItem();
            archivoToolStripMenuItem = new ToolStripMenuItem();
            cerrarSesionToolStripMenuItem = new ToolStripMenuItem();
            salirToolStripMenuItem1 = new ToolStripMenuItem();
            label5 = new Label();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            tabPage3.SuspendLayout();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Font = new Font("Sitka Display", 13.7999992F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tabControl1.Location = new Point(12, 134);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1140, 353);
            tabControl1.TabIndex = 5;
            // 
            // tabPage1
            // 
            tabPage1.BackColor = SystemColors.GradientInactiveCaption;
            tabPage1.Controls.Add(label3);
            tabPage1.Controls.Add(label2);
            tabPage1.Location = new Point(4, 42);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(1132, 307);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "   NorthWind CRUD   ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Sitka Display", 13.7999992F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(39, 126);
            label3.Name = "label3";
            label3.Size = new Size(1072, 99);
            label3.TabIndex = 1;
            label3.Text = resources.GetString("label3.Text");
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Sitka Display", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(367, 41);
            label2.Name = "label2";
            label2.Size = new Size(411, 49);
            label2.TabIndex = 0;
            label2.Text = "¿Qué es NorthWind CRUD?";
            // 
            // tabPage2
            // 
            tabPage2.BackColor = Color.AliceBlue;
            tabPage2.Controls.Add(label14);
            tabPage2.Controls.Add(label13);
            tabPage2.Controls.Add(label12);
            tabPage2.Controls.Add(label11);
            tabPage2.Controls.Add(label10);
            tabPage2.Controls.Add(label9);
            tabPage2.Controls.Add(label8);
            tabPage2.Controls.Add(label7);
            tabPage2.Controls.Add(label6);
            tabPage2.Location = new Point(4, 42);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(1132, 307);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "   Administracion   ";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Sitka Display", 13.7999992F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label14.Location = new Point(260, 236);
            label14.Name = "label14";
            label14.Size = new Size(788, 33);
            label14.TabIndex = 8;
            label14.Text = "Tiene acceso limitado a Clientes, Pedidos y Territorios relacionados con su asignación.\r\n";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Sitka Display", 16.1999989F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label13.Location = new Point(94, 231);
            label13.Name = "label13";
            label13.Size = new Size(160, 39);
            label13.TabIndex = 7;
            label13.Text = "- Empleado: ";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Sitka Display", 13.7999992F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label12.Location = new Point(235, 182);
            label12.Name = "label12";
            label12.Size = new Size(737, 33);
            label12.TabIndex = 6;
            label12.Text = "Puede acceder a Clientes, Pedidos, Productos, Territorios, Empleados y Regiones";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Sitka Display", 16.1999989F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.Location = new Point(94, 177);
            label11.Name = "label11";
            label11.Size = new Size(135, 39);
            label11.TabIndex = 5;
            label11.Text = "- Gerente: ";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Sitka Display", 13.7999992F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label10.Location = new Point(312, 129);
            label10.Name = "label10";
            label10.Size = new Size(696, 33);
            label10.TabIndex = 4;
            label10.Text = "Tiene acceso completo a todas las tablas para gestionar toda la información.\r\n";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Sitka Display", 16.1999989F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(94, 124);
            label9.Name = "label9";
            label9.Size = new Size(212, 39);
            label9.TabIndex = 3;
            label9.Text = "- Administrador: ";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Sitka Display", 13.7999992F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(57, 76);
            label8.Name = "label8";
            label8.Size = new Size(974, 33);
            label8.TabIndex = 2;
            label8.Text = "El programa CRUD permite gestionar diferentes tablas de la base de datos según el rol del usuario.\r\n";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Sitka Display", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(378, 20);
            label7.Name = "label7";
            label7.Size = new Size(359, 43);
            label7.TabIndex = 1;
            label7.Text = "Roles en NorthWind CRUD";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(460, 30);
            label6.Name = "label6";
            label6.Size = new Size(0, 33);
            label6.TabIndex = 0;
            // 
            // tabPage3
            // 
            tabPage3.BackColor = Color.AliceBlue;
            tabPage3.Controls.Add(label16);
            tabPage3.Controls.Add(label15);
            tabPage3.Location = new Point(4, 42);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(1132, 307);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "   Tablas   ";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Sitka Display", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label16.Location = new Point(663, 40);
            label16.Name = "label16";
            label16.Size = new Size(421, 174);
            label16.TabIndex = 1;
            label16.Text = resources.GetString("label16.Text");
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Sitka Display", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label15.Location = new Point(27, 40);
            label15.Name = "label15";
            label15.Size = new Size(589, 203);
            label15.TabIndex = 0;
            label15.Text = resources.GetString("label15.Text");
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Sitka Small", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(16, 51);
            label1.Name = "label1";
            label1.Size = new Size(517, 59);
            label1.TabIndex = 4;
            label1.Text = "¡Bienvenido GERENTE!";
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = SystemColors.GradientInactiveCaption;
            menuStrip1.Font = new Font("Segoe UI Historic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { tablasToolStripMenuItem, archivoToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1180, 36);
            menuStrip1.TabIndex = 3;
            menuStrip1.Text = "menuStrip1";
            // 
            // tablasToolStripMenuItem
            // 
            tablasToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { ordersToolStripMenuItem, productsToolStripMenuItem, customersToolStripMenuItem, employeesToolStripMenuItem, shippersToolStripMenuItem, categoriesToolStripMenuItem, territoriesToolStripMenuItem, regionToolStripMenuItem });
            tablasToolStripMenuItem.Name = "tablasToolStripMenuItem";
            tablasToolStripMenuItem.Size = new Size(87, 32);
            tablasToolStripMenuItem.Text = "Tablas";
            // 
            // ordersToolStripMenuItem
            // 
            ordersToolStripMenuItem.Image = Properties.Resources.WhatsApp_Image_2024_11_22_at_2_11_25_AM__7_;
            ordersToolStripMenuItem.Name = "ordersToolStripMenuItem";
            ordersToolStripMenuItem.Size = new Size(201, 32);
            ordersToolStripMenuItem.Text = "Orders";
            ordersToolStripMenuItem.Click += ordersToolStripMenuItem_Click;
            // 
            // productsToolStripMenuItem
            // 
            productsToolStripMenuItem.Image = Properties.Resources.WhatsApp_Image_2024_11_22_at_2_11_24_AM__5_;
            productsToolStripMenuItem.Name = "productsToolStripMenuItem";
            productsToolStripMenuItem.Size = new Size(201, 32);
            productsToolStripMenuItem.Text = "Products";
            productsToolStripMenuItem.Click += productsToolStripMenuItem_Click;
            // 
            // customersToolStripMenuItem
            // 
            customersToolStripMenuItem.Image = Properties.Resources.WhatsApp_Image_2024_11_22_at_2_11_25_AM__2_;
            customersToolStripMenuItem.Name = "customersToolStripMenuItem";
            customersToolStripMenuItem.Size = new Size(201, 32);
            customersToolStripMenuItem.Text = "Customers";
            customersToolStripMenuItem.Click += customersToolStripMenuItem_Click;
            // 
            // employeesToolStripMenuItem
            // 
            employeesToolStripMenuItem.Image = Properties.Resources.WhatsApp_Image_2024_11_22_at_2_11_25_AM__5_;
            employeesToolStripMenuItem.Name = "employeesToolStripMenuItem";
            employeesToolStripMenuItem.Size = new Size(201, 32);
            employeesToolStripMenuItem.Text = "Employees";
            employeesToolStripMenuItem.Click += employeesToolStripMenuItem_Click;
            // 
            // shippersToolStripMenuItem
            // 
            shippersToolStripMenuItem.Image = Properties.Resources.WhatsApp_Image_2024_11_22_at_2_11_24_AM__3_;
            shippersToolStripMenuItem.Name = "shippersToolStripMenuItem";
            shippersToolStripMenuItem.Size = new Size(201, 32);
            shippersToolStripMenuItem.Text = "Shippers";
            shippersToolStripMenuItem.Click += shippersToolStripMenuItem_Click;
            // 
            // categoriesToolStripMenuItem
            // 
            categoriesToolStripMenuItem.Image = Properties.Resources.WhatsApp_Image_2024_11_22_at_2_11_25_AM;
            categoriesToolStripMenuItem.Name = "categoriesToolStripMenuItem";
            categoriesToolStripMenuItem.Size = new Size(201, 32);
            categoriesToolStripMenuItem.Text = "Categories";
            categoriesToolStripMenuItem.Click += categoriesToolStripMenuItem_Click;
            // 
            // territoriesToolStripMenuItem
            // 
            territoriesToolStripMenuItem.Image = Properties.Resources.WhatsApp_Image_2024_11_22_at_2_11_24_AM__4_;
            territoriesToolStripMenuItem.Name = "territoriesToolStripMenuItem";
            territoriesToolStripMenuItem.Size = new Size(201, 32);
            territoriesToolStripMenuItem.Text = "Territories";
            territoriesToolStripMenuItem.Click += territoriesToolStripMenuItem_Click;
            // 
            // regionToolStripMenuItem
            // 
            regionToolStripMenuItem.Image = Properties.Resources.WhatsApp_Image_2024_11_22_at_2_11_24_AM__4_;
            regionToolStripMenuItem.Name = "regionToolStripMenuItem";
            regionToolStripMenuItem.Size = new Size(201, 32);
            regionToolStripMenuItem.Text = "Region";
            regionToolStripMenuItem.Click += regionToolStripMenuItem_Click;
            // 
            // archivoToolStripMenuItem
            // 
            archivoToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { cerrarSesionToolStripMenuItem, salirToolStripMenuItem1 });
            archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            archivoToolStripMenuItem.Size = new Size(100, 32);
            archivoToolStripMenuItem.Text = "Archivo";
            // 
            // cerrarSesionToolStripMenuItem
            // 
            cerrarSesionToolStripMenuItem.Image = Properties.Resources.WhatsApp_Image_2024_11_22_at_2_11_24_AM__2_;
            cerrarSesionToolStripMenuItem.Name = "cerrarSesionToolStripMenuItem";
            cerrarSesionToolStripMenuItem.Size = new Size(226, 32);
            cerrarSesionToolStripMenuItem.Text = "Cerrar Sesion";
            cerrarSesionToolStripMenuItem.Click += cerrarSesionToolStripMenuItem_Click;
            // 
            // salirToolStripMenuItem1
            // 
            salirToolStripMenuItem1.Image = Properties.Resources.WhatsApp_Image_2024_11_22_at_2_11_24_AM__1_;
            salirToolStripMenuItem1.Name = "salirToolStripMenuItem1";
            salirToolStripMenuItem1.Size = new Size(226, 32);
            salirToolStripMenuItem1.Text = "Salir";
            salirToolStripMenuItem1.Click += salirToolStripMenuItem1_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI", 60F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Image = Properties.Resources.person_apron_20dp_255290_FILL0_wght600_GRAD0_opsz20;
            label5.Location = new Point(1014, 36);
            label5.Name = "label5";
            label5.Size = new Size(138, 133);
            label5.TabIndex = 11;
            label5.Text = "   ";
            // 
            // FormMenuGERENTE
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            BackgroundImage = Properties.Resources.fondo_azul_para_textura;
            ClientSize = new Size(1180, 503);
            Controls.Add(label5);
            Controls.Add(tabControl1);
            Controls.Add(label1);
            Controls.Add(menuStrip1);
            Name = "FormMenuGERENTE";
            Text = "FormMenuGERENTE";
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            tabPage3.ResumeLayout(false);
            tabPage3.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private Label label3;
        private Label label2;
        private TabPage tabPage2;
        private Label label14;
        private Label label13;
        private Label label12;
        private Label label11;
        private Label label10;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private TabPage tabPage3;
        private Label label16;
        private Label label15;
        private Label label1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem tablasToolStripMenuItem;
        private ToolStripMenuItem productsToolStripMenuItem;
        private ToolStripMenuItem employeesToolStripMenuItem;
        private ToolStripMenuItem categoriesToolStripMenuItem;
        private ToolStripMenuItem territoriesToolStripMenuItem;
        private ToolStripMenuItem shippersToolStripMenuItem;
        private ToolStripMenuItem regionToolStripMenuItem;
        private ToolStripMenuItem archivoToolStripMenuItem;
        private ToolStripMenuItem ordersToolStripMenuItem;
        private ToolStripMenuItem customersToolStripMenuItem;
        private ToolStripMenuItem salirToolStripMenuItem1;
        private ToolStripMenuItem cerrarSesionToolStripMenuItem;
        private Label label5;
    }
}