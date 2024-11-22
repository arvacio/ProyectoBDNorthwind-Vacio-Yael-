namespace ProyectoBDNorthwind_Vacio_Yael_
{
    partial class FormCustomerCustomerDemo
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
            butRefrescar = new Button();
            label36 = new Label();
            butBuscar = new Button();
            label35 = new Label();
            txtBuscar = new TextBox();
            boxBuscar = new ComboBox();
            panel3 = new Panel();
            boxCustomerTypeID = new ComboBox();
            label3 = new Label();
            panel1 = new Panel();
            boxCustomerID = new ComboBox();
            label2 = new Label();
            label4 = new Label();
            label1 = new Label();
            butEliminar = new Button();
            butNuevo = new Button();
            butGuardar = new Button();
            label33 = new Label();
            dataGridViewCCD = new DataGridView();
            menuStrip1 = new MenuStrip();
            archivoToolStripMenuItem = new ToolStripMenuItem();
            cerrarToolStripMenuItem = new ToolStripMenuItem();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewCCD).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = Color.LightSkyBlue;
            panel2.Controls.Add(butRefrescar);
            panel2.Controls.Add(label36);
            panel2.Controls.Add(butBuscar);
            panel2.Controls.Add(label35);
            panel2.Controls.Add(txtBuscar);
            panel2.Controls.Add(boxBuscar);
            panel2.Location = new Point(12, 460);
            panel2.Name = "panel2";
            panel2.Size = new Size(514, 228);
            panel2.TabIndex = 71;
            // 
            // butRefrescar
            // 
            butRefrescar.BackColor = SystemColors.ButtonHighlight;
            butRefrescar.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            butRefrescar.Location = new Point(315, 167);
            butRefrescar.Name = "butRefrescar";
            butRefrescar.Size = new Size(117, 50);
            butRefrescar.TabIndex = 39;
            butRefrescar.Text = "Refrescar";
            butRefrescar.UseVisualStyleBackColor = false;
            butRefrescar.Click += butRefrescar_Click;
            // 
            // label36
            // 
            label36.AutoSize = true;
            label36.Font = new Font("Sitka Banner", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label36.Location = new Point(104, 0);
            label36.Name = "label36";
            label36.Size = new Size(298, 43);
            label36.TabIndex = 33;
            label36.Text = "Busqueda De Registros";
            // 
            // butBuscar
            // 
            butBuscar.BackColor = SystemColors.ButtonHighlight;
            butBuscar.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            butBuscar.Location = new Point(70, 167);
            butBuscar.Name = "butBuscar";
            butBuscar.Size = new Size(117, 50);
            butBuscar.TabIndex = 38;
            butBuscar.Text = "Buscar";
            butBuscar.UseVisualStyleBackColor = false;
            butBuscar.Click += butBuscar_Click;
            // 
            // label35
            // 
            label35.AutoSize = true;
            label35.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label35.Location = new Point(40, 58);
            label35.Name = "label35";
            label35.Size = new Size(135, 31);
            label35.TabIndex = 34;
            label35.Text = "Buscar por:";
            // 
            // txtBuscar
            // 
            txtBuscar.BackColor = SystemColors.Menu;
            txtBuscar.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtBuscar.Location = new Point(70, 113);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new Size(362, 34);
            txtBuscar.TabIndex = 35;
            txtBuscar.Enter += txtBuscar_Enter;
            // 
            // boxBuscar
            // 
            boxBuscar.BackColor = SystemColors.Menu;
            boxBuscar.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            boxBuscar.FormattingEnabled = true;
            boxBuscar.Items.AddRange(new object[] { "CustomerID", "CustomerTypeID" });
            boxBuscar.Location = new Point(216, 58);
            boxBuscar.Name = "boxBuscar";
            boxBuscar.Size = new Size(260, 36);
            boxBuscar.TabIndex = 37;
            boxBuscar.SelectedIndexChanged += boxBuscar_SelectedIndexChanged;
            // 
            // panel3
            // 
            panel3.BackColor = Color.LightSkyBlue;
            panel3.Controls.Add(boxCustomerTypeID);
            panel3.Controls.Add(label3);
            panel3.Controls.Add(panel1);
            panel3.Controls.Add(label1);
            panel3.Controls.Add(butEliminar);
            panel3.Controls.Add(butNuevo);
            panel3.Controls.Add(butGuardar);
            panel3.Controls.Add(label33);
            panel3.Location = new Point(12, 50);
            panel3.Name = "panel3";
            panel3.Size = new Size(514, 404);
            panel3.TabIndex = 70;
            // 
            // boxCustomerTypeID
            // 
            boxCustomerTypeID.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            boxCustomerTypeID.FormattingEnabled = true;
            boxCustomerTypeID.Location = new Point(286, 231);
            boxCustomerTypeID.Name = "boxCustomerTypeID";
            boxCustomerTypeID.Size = new Size(176, 36);
            boxCustomerTypeID.TabIndex = 46;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Sitka Banner", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(32, 58);
            label3.Name = "label3";
            label3.Size = new Size(444, 43);
            label3.TabIndex = 42;
            label3.Text = "Customer Customer Demographics";
            // 
            // panel1
            // 
            panel1.BackColor = Color.SteelBlue;
            panel1.Controls.Add(boxCustomerID);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label4);
            panel1.Location = new Point(32, 104);
            panel1.Name = "panel1";
            panel1.Size = new Size(449, 109);
            panel1.TabIndex = 41;
            // 
            // boxCustomerID
            // 
            boxCustomerID.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            boxCustomerID.FormattingEnabled = true;
            boxCustomerID.Location = new Point(254, 58);
            boxCustomerID.Name = "boxCustomerID";
            boxCustomerID.Size = new Size(176, 36);
            boxCustomerID.TabIndex = 45;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(152, 11);
            label2.Name = "label2";
            label2.Size = new Size(139, 38);
            label2.TabIndex = 40;
            label2.Text = "Selección";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(24, 54);
            label4.Name = "label4";
            label4.Size = new Size(181, 38);
            label4.TabIndex = 44;
            label4.Text = "CustomerID:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(40, 236);
            label1.Name = "label1";
            label1.Size = new Size(197, 31);
            label1.TabIndex = 39;
            label1.Text = "CustomerTypeID:";
            // 
            // butEliminar
            // 
            butEliminar.BackColor = SystemColors.ButtonHighlight;
            butEliminar.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            butEliminar.Location = new Point(194, 336);
            butEliminar.Name = "butEliminar";
            butEliminar.Size = new Size(148, 44);
            butEliminar.TabIndex = 31;
            butEliminar.Text = "Eliminar";
            butEliminar.UseVisualStyleBackColor = false;
            butEliminar.Click += butEliminar_Click;
            // 
            // butNuevo
            // 
            butNuevo.BackColor = SystemColors.ButtonHighlight;
            butNuevo.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            butNuevo.Location = new Point(301, 286);
            butNuevo.Name = "butNuevo";
            butNuevo.Size = new Size(148, 44);
            butNuevo.TabIndex = 30;
            butNuevo.Text = "Nuevo Registro";
            butNuevo.UseVisualStyleBackColor = false;
            butNuevo.Click += butNuevo_Click;
            // 
            // butGuardar
            // 
            butGuardar.BackColor = SystemColors.ButtonHighlight;
            butGuardar.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            butGuardar.Location = new Point(70, 286);
            butGuardar.Name = "butGuardar";
            butGuardar.Size = new Size(148, 44);
            butGuardar.TabIndex = 29;
            butGuardar.Text = "Guardar/Modificar";
            butGuardar.UseVisualStyleBackColor = false;
            butGuardar.Click += butGuardar_Click;
            // 
            // label33
            // 
            label33.AutoSize = true;
            label33.Font = new Font("Sitka Banner", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label33.Location = new Point(194, 9);
            label33.Name = "label33";
            label33.Size = new Size(102, 49);
            label33.TabIndex = 0;
            label33.Text = "Datos";
            // 
            // dataGridViewCCD
            // 
            dataGridViewCCD.BackgroundColor = SystemColors.ActiveCaption;
            dataGridViewCCD.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCCD.Location = new Point(532, 50);
            dataGridViewCCD.Name = "dataGridViewCCD";
            dataGridViewCCD.RowHeadersWidth = 51;
            dataGridViewCCD.Size = new Size(417, 638);
            dataGridViewCCD.TabIndex = 69;
            dataGridViewCCD.SelectionChanged += dataGridViewCCD_SelectionChanged;
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = SystemColors.GradientActiveCaption;
            menuStrip1.Font = new Font("Segoe UI Historic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { archivoToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(958, 36);
            menuStrip1.TabIndex = 72;
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
            // FormCustomerCustomerDemo
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(958, 696);
            Controls.Add(panel2);
            Controls.Add(panel3);
            Controls.Add(dataGridViewCCD);
            Controls.Add(menuStrip1);
            Name = "FormCustomerCustomerDemo";
            Text = "FormCustomerCustomerDemo";
            Load += FormCustomerCustomerDemo_Load;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewCCD).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel2;
        private Button butRefrescar;
        private Label label36;
        private Button butBuscar;
        private Label label35;
        private TextBox txtBuscar;
        private ComboBox boxBuscar;
        private Panel panel3;
        private Label label3;
        private Panel panel1;
        private Label label2;
        private Label label1;
        private Button butEliminar;
        private Button butNuevo;
        private Button butGuardar;
        private Label label33;
        private DataGridView dataGridViewCCD;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem archivoToolStripMenuItem;
        private ToolStripMenuItem cerrarToolStripMenuItem;
        private Label label4;
        private ComboBox boxCustomerID;
        private ComboBox boxCustomerTypeID;
    }
}