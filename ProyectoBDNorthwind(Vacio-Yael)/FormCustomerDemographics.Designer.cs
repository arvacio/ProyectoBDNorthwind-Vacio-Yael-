namespace ProyectoBDNorthwind_Vacio_Yael_
{
    partial class FormCustomerDemographics
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
            panel1 = new Panel();
            txtCTID = new TextBox();
            label2 = new Label();
            label1 = new Label();
            butEliminar = new Button();
            txtCDES = new TextBox();
            butNuevo = new Button();
            label32 = new Label();
            butGuardar = new Button();
            label33 = new Label();
            dataGridViewCD = new DataGridView();
            menuStrip1 = new MenuStrip();
            archivoToolStripMenuItem = new ToolStripMenuItem();
            cerrarToolStripMenuItem = new ToolStripMenuItem();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewCD).BeginInit();
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
            panel2.TabIndex = 67;
            // 
            // butRefrescar
            // 
            butRefrescar.Location = new Point(315, 167);
            butRefrescar.Name = "butRefrescar";
            butRefrescar.Size = new Size(117, 50);
            butRefrescar.TabIndex = 39;
            butRefrescar.Text = "Refrescar";
            butRefrescar.UseVisualStyleBackColor = true;
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
            butBuscar.Location = new Point(70, 167);
            butBuscar.Name = "butBuscar";
            butBuscar.Size = new Size(117, 50);
            butBuscar.TabIndex = 38;
            butBuscar.Text = "Buscar";
            butBuscar.UseVisualStyleBackColor = true;
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
            boxBuscar.Items.AddRange(new object[] { "CustomerTypeID", "CustomerDescription" });
            boxBuscar.Location = new Point(216, 58);
            boxBuscar.Name = "boxBuscar";
            boxBuscar.Size = new Size(260, 36);
            boxBuscar.TabIndex = 37;
            boxBuscar.SelectedIndexChanged += boxBuscar_SelectedIndexChanged;
            // 
            // panel3
            // 
            panel3.BackColor = Color.LightSkyBlue;
            panel3.Controls.Add(panel1);
            panel3.Controls.Add(butEliminar);
            panel3.Controls.Add(txtCDES);
            panel3.Controls.Add(butNuevo);
            panel3.Controls.Add(label32);
            panel3.Controls.Add(butGuardar);
            panel3.Controls.Add(label33);
            panel3.Location = new Point(12, 50);
            panel3.Name = "panel3";
            panel3.Size = new Size(514, 404);
            panel3.TabIndex = 66;
            // 
            // panel1
            // 
            panel1.BackColor = Color.SteelBlue;
            panel1.Controls.Add(txtCTID);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(40, 68);
            panel1.Name = "panel1";
            panel1.Size = new Size(449, 109);
            panel1.TabIndex = 41;
            // 
            // txtCTID
            // 
            txtCTID.BackColor = SystemColors.Menu;
            txtCTID.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtCTID.Location = new Point(261, 56);
            txtCTID.Name = "txtCTID";
            txtCTID.Size = new Size(176, 38);
            txtCTID.TabIndex = 43;
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
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 56);
            label1.Name = "label1";
            label1.Size = new Size(243, 38);
            label1.TabIndex = 39;
            label1.Text = "CustomerTypeID:";
            // 
            // butEliminar
            // 
            butEliminar.Location = new Point(194, 319);
            butEliminar.Name = "butEliminar";
            butEliminar.Size = new Size(148, 61);
            butEliminar.TabIndex = 31;
            butEliminar.Text = "Eliminar";
            butEliminar.UseVisualStyleBackColor = true;
            butEliminar.Click += butEliminar_Click;
            // 
            // txtCDES
            // 
            txtCDES.BackColor = SystemColors.Menu;
            txtCDES.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtCDES.Location = new Point(289, 194);
            txtCDES.Name = "txtCDES";
            txtCDES.Size = new Size(187, 38);
            txtCDES.TabIndex = 2;
            // 
            // butNuevo
            // 
            butNuevo.Location = new Point(301, 252);
            butNuevo.Name = "butNuevo";
            butNuevo.Size = new Size(148, 61);
            butNuevo.TabIndex = 30;
            butNuevo.Text = "Nuevo Registro";
            butNuevo.UseVisualStyleBackColor = true;
            butNuevo.Click += butNuevo_Click;
            // 
            // label32
            // 
            label32.AutoSize = true;
            label32.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label32.Location = new Point(30, 201);
            label32.Name = "label32";
            label32.Size = new Size(253, 31);
            label32.TabIndex = 1;
            label32.Text = "Customer Description:";
            // 
            // butGuardar
            // 
            butGuardar.Location = new Point(83, 252);
            butGuardar.Name = "butGuardar";
            butGuardar.Size = new Size(148, 61);
            butGuardar.TabIndex = 29;
            butGuardar.Text = "Guardar/Modificar";
            butGuardar.UseVisualStyleBackColor = true;
            butGuardar.Click += butGuardar_Click;
            // 
            // label33
            // 
            label33.AutoSize = true;
            label33.Font = new Font("Sitka Banner", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label33.Location = new Point(3, 12);
            label33.Name = "label33";
            label33.Size = new Size(505, 53);
            label33.TabIndex = 0;
            label33.Text = "Datos - Customer Demographics";
            // 
            // dataGridViewCD
            // 
            dataGridViewCD.BackgroundColor = SystemColors.ActiveCaption;
            dataGridViewCD.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCD.Location = new Point(532, 50);
            dataGridViewCD.Name = "dataGridViewCD";
            dataGridViewCD.RowHeadersWidth = 51;
            dataGridViewCD.Size = new Size(417, 638);
            dataGridViewCD.TabIndex = 65;
            dataGridViewCD.SelectionChanged += dataGridViewCD_SelectionChanged;
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = SystemColors.GradientActiveCaption;
            menuStrip1.Font = new Font("Segoe UI Historic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { archivoToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(962, 36);
            menuStrip1.TabIndex = 68;
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
            // FormCustomerDemographics
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(962, 696);
            Controls.Add(panel2);
            Controls.Add(panel3);
            Controls.Add(dataGridViewCD);
            Controls.Add(menuStrip1);
            Name = "FormCustomerDemographics";
            Text = "FormCustomerDemographics";
            Load += FormCustomerDemographics_Load;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewCD).EndInit();
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
        private Panel panel1;
        private TextBox txtCTID;
        private Label label2;
        private Label label1;
        private Button butEliminar;
        private TextBox txtCDES;
        private Button butNuevo;
        private Label label32;
        private Button butGuardar;
        private Label label33;
        private DataGridView dataGridViewCD;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem archivoToolStripMenuItem;
        private ToolStripMenuItem cerrarToolStripMenuItem;
    }
}