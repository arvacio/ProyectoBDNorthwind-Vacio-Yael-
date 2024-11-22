namespace ProyectoBDNorthwind_Vacio_Yael_
{
    partial class FormMenuEmpleado
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMenuEmpleado));
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
            customersToolStripMenuItem = new ToolStripMenuItem();
            ordersToolStripMenuItem = new ToolStripMenuItem();
            productsToolStripMenuItem = new ToolStripMenuItem();
            territoriesToolStripMenuItem = new ToolStripMenuItem();
            archivoToolStripMenuItem = new ToolStripMenuItem();
            cerrarSesionToolStripMenuItem = new ToolStripMenuItem();
            salirToolStripMenuItem = new ToolStripMenuItem();
            acercaDeToolStripMenuItem = new ToolStripMenuItem();
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
            tabControl1.Location = new Point(12, 133);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1140, 353);
            tabControl1.TabIndex = 8;
            // 
            // tabPage1
            // 
            tabPage1.BackColor = Color.AliceBlue;
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
            label3.Location = new Point(42, 129);
            label3.Name = "label3";
            label3.Size = new Size(1072, 99);
            label3.TabIndex = 1;
            label3.Text = resources.GetString("label3.Text");
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Sitka Display", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(370, 44);
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
            label14.Location = new Point(263, 239);
            label14.Name = "label14";
            label14.Size = new Size(788, 33);
            label14.TabIndex = 8;
            label14.Text = "Tiene acceso limitado a Clientes, Pedidos y Territorios relacionados con su asignación.\r\n";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Sitka Display", 16.1999989F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label13.Location = new Point(97, 234);
            label13.Name = "label13";
            label13.Size = new Size(160, 39);
            label13.TabIndex = 7;
            label13.Text = "- Empleado: ";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Sitka Display", 13.7999992F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label12.Location = new Point(238, 185);
            label12.Name = "label12";
            label12.Size = new Size(737, 33);
            label12.TabIndex = 6;
            label12.Text = "Puede acceder a Clientes, Pedidos, Productos, Territorios, Empleados y Regiones";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Sitka Display", 16.1999989F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.Location = new Point(97, 180);
            label11.Name = "label11";
            label11.Size = new Size(135, 39);
            label11.TabIndex = 5;
            label11.Text = "- Gerente: ";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Sitka Display", 13.7999992F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label10.Location = new Point(315, 132);
            label10.Name = "label10";
            label10.Size = new Size(696, 33);
            label10.TabIndex = 4;
            label10.Text = "Tiene acceso completo a todas las tablas para gestionar toda la información.\r\n";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Sitka Display", 16.1999989F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(97, 127);
            label9.Name = "label9";
            label9.Size = new Size(212, 39);
            label9.TabIndex = 3;
            label9.Text = "- Administrador: ";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Sitka Display", 13.7999992F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(60, 79);
            label8.Name = "label8";
            label8.Size = new Size(974, 33);
            label8.TabIndex = 2;
            label8.Text = "El programa CRUD permite gestionar diferentes tablas de la base de datos según el rol del usuario.\r\n";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Sitka Display", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(381, 23);
            label7.Name = "label7";
            label7.Size = new Size(359, 43);
            label7.TabIndex = 1;
            label7.Text = "Roles en NorthWind CRUD";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(463, 33);
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
            label16.Location = new Point(666, 43);
            label16.Name = "label16";
            label16.Size = new Size(421, 174);
            label16.TabIndex = 1;
            label16.Text = resources.GetString("label16.Text");
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Sitka Display", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label15.Location = new Point(30, 43);
            label15.Name = "label15";
            label15.Size = new Size(589, 203);
            label15.TabIndex = 0;
            label15.Text = resources.GetString("label15.Text");
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Sitka Small", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 44);
            label1.Name = "label1";
            label1.Size = new Size(519, 59);
            label1.TabIndex = 7;
            label1.Text = "Bienvenido EMPLEADO";
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = SystemColors.GradientActiveCaption;
            menuStrip1.Font = new Font("Segoe UI Historic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { tablasToolStripMenuItem, archivoToolStripMenuItem, acercaDeToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1158, 36);
            menuStrip1.TabIndex = 6;
            menuStrip1.Text = "menuStrip1";
            // 
            // tablasToolStripMenuItem
            // 
            tablasToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { customersToolStripMenuItem, ordersToolStripMenuItem, productsToolStripMenuItem, territoriesToolStripMenuItem });
            tablasToolStripMenuItem.Name = "tablasToolStripMenuItem";
            tablasToolStripMenuItem.Size = new Size(87, 32);
            tablasToolStripMenuItem.Text = "Tablas";
            // 
            // customersToolStripMenuItem
            // 
            customersToolStripMenuItem.Name = "customersToolStripMenuItem";
            customersToolStripMenuItem.Size = new Size(199, 32);
            customersToolStripMenuItem.Text = "Customers";
            customersToolStripMenuItem.Click += customersToolStripMenuItem_Click;
            // 
            // ordersToolStripMenuItem
            // 
            ordersToolStripMenuItem.Name = "ordersToolStripMenuItem";
            ordersToolStripMenuItem.Size = new Size(199, 32);
            ordersToolStripMenuItem.Text = "Orders";
            ordersToolStripMenuItem.Click += ordersToolStripMenuItem_Click;
            // 
            // productsToolStripMenuItem
            // 
            productsToolStripMenuItem.Name = "productsToolStripMenuItem";
            productsToolStripMenuItem.Size = new Size(199, 32);
            productsToolStripMenuItem.Text = "Products";
            productsToolStripMenuItem.Click += productsToolStripMenuItem_Click;
            // 
            // territoriesToolStripMenuItem
            // 
            territoriesToolStripMenuItem.Name = "territoriesToolStripMenuItem";
            territoriesToolStripMenuItem.Size = new Size(199, 32);
            territoriesToolStripMenuItem.Text = "Territories";
            territoriesToolStripMenuItem.Click += territoriesToolStripMenuItem_Click;
            // 
            // archivoToolStripMenuItem
            // 
            archivoToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { cerrarSesionToolStripMenuItem, salirToolStripMenuItem });
            archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            archivoToolStripMenuItem.Size = new Size(100, 32);
            archivoToolStripMenuItem.Text = "Archivo";
            // 
            // cerrarSesionToolStripMenuItem
            // 
            cerrarSesionToolStripMenuItem.Name = "cerrarSesionToolStripMenuItem";
            cerrarSesionToolStripMenuItem.Size = new Size(226, 32);
            cerrarSesionToolStripMenuItem.Text = "Cerrar Sesion";
            cerrarSesionToolStripMenuItem.Click += cerrarSesionToolStripMenuItem_Click;
            // 
            // salirToolStripMenuItem
            // 
            salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            salirToolStripMenuItem.Size = new Size(226, 32);
            salirToolStripMenuItem.Text = "Salir";
            salirToolStripMenuItem.Click += salirToolStripMenuItem_Click;
            // 
            // acercaDeToolStripMenuItem
            // 
            acercaDeToolStripMenuItem.Name = "acercaDeToolStripMenuItem";
            acercaDeToolStripMenuItem.Size = new Size(122, 32);
            acercaDeToolStripMenuItem.Text = "Acerca De";
            // 
            // FormMenuEmpleado
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(1158, 497);
            Controls.Add(tabControl1);
            Controls.Add(label1);
            Controls.Add(menuStrip1);
            Name = "FormMenuEmpleado";
            Text = "FormMenuEmpleado";
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
        private ToolStripMenuItem customersToolStripMenuItem;
        private ToolStripMenuItem ordersToolStripMenuItem;
        private ToolStripMenuItem productsToolStripMenuItem;
        private ToolStripMenuItem territoriesToolStripMenuItem;
        private ToolStripMenuItem archivoToolStripMenuItem;
        private ToolStripMenuItem cerrarSesionToolStripMenuItem;
        private ToolStripMenuItem salirToolStripMenuItem;
        private ToolStripMenuItem acercaDeToolStripMenuItem;
    }
}