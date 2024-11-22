namespace ProyectoBDNorthwind_Vacio_Yael_
{
    partial class FormTerritories
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
            txtBuscarTerritory = new TextBox();
            boxBuscarTerritory = new ComboBox();
            panel3 = new Panel();
            txtRegionID = new TextBox();
            label3 = new Label();
            panel1 = new Panel();
            label2 = new Label();
            label1 = new Label();
            txtTerritoryID = new TextBox();
            butEliminar = new Button();
            txtTerritoryDes = new TextBox();
            butNuevo = new Button();
            label32 = new Label();
            butGuardar = new Button();
            label33 = new Label();
            dataGridViewTerritories = new DataGridView();
            menuStrip1 = new MenuStrip();
            archivoToolStripMenuItem = new ToolStripMenuItem();
            cerrarToolStripMenuItem = new ToolStripMenuItem();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewTerritories).BeginInit();
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
            panel2.Controls.Add(txtBuscarTerritory);
            panel2.Controls.Add(boxBuscarTerritory);
            panel2.Location = new Point(12, 512);
            panel2.Name = "panel2";
            panel2.Size = new Size(514, 266);
            panel2.TabIndex = 59;
            // 
            // butRefrescar
            // 
            butRefrescar.Location = new Point(315, 187);
            butRefrescar.Name = "butRefrescar";
            butRefrescar.Size = new Size(117, 61);
            butRefrescar.TabIndex = 39;
            butRefrescar.Text = "Refrescar";
            butRefrescar.UseVisualStyleBackColor = true;
            butRefrescar.Click += butRefrescar_Click;
            // 
            // label36
            // 
            label36.AutoSize = true;
            label36.Font = new Font("Sitka Banner", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label36.Location = new Point(104, 16);
            label36.Name = "label36";
            label36.Size = new Size(298, 43);
            label36.TabIndex = 33;
            label36.Text = "Busqueda De Registros";
            // 
            // butBuscar
            // 
            butBuscar.Location = new Point(70, 187);
            butBuscar.Name = "butBuscar";
            butBuscar.Size = new Size(117, 61);
            butBuscar.TabIndex = 38;
            butBuscar.Text = "Buscar";
            butBuscar.UseVisualStyleBackColor = true;
            butBuscar.Click += butBuscar_Click;
            // 
            // label35
            // 
            label35.AutoSize = true;
            label35.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label35.Location = new Point(40, 78);
            label35.Name = "label35";
            label35.Size = new Size(135, 31);
            label35.TabIndex = 34;
            label35.Text = "Buscar por:";
            // 
            // txtBuscarTerritory
            // 
            txtBuscarTerritory.BackColor = SystemColors.Menu;
            txtBuscarTerritory.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtBuscarTerritory.Location = new Point(70, 135);
            txtBuscarTerritory.Name = "txtBuscarTerritory";
            txtBuscarTerritory.Size = new Size(362, 34);
            txtBuscarTerritory.TabIndex = 35;
            txtBuscarTerritory.Enter += txtBuscarTerritory_Enter;
            // 
            // boxBuscarTerritory
            // 
            boxBuscarTerritory.BackColor = SystemColors.Menu;
            boxBuscarTerritory.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            boxBuscarTerritory.FormattingEnabled = true;
            boxBuscarTerritory.Items.AddRange(new object[] { "TerritoryID", "TerritoryDescription", "RegionID" });
            boxBuscarTerritory.Location = new Point(216, 78);
            boxBuscarTerritory.Name = "boxBuscarTerritory";
            boxBuscarTerritory.Size = new Size(260, 36);
            boxBuscarTerritory.TabIndex = 37;
            boxBuscarTerritory.SelectedIndexChanged += boxBuscarTerritory_SelectedIndexChanged;
            // 
            // panel3
            // 
            panel3.BackColor = Color.LightSkyBlue;
            panel3.Controls.Add(txtRegionID);
            panel3.Controls.Add(label3);
            panel3.Controls.Add(panel1);
            panel3.Controls.Add(butEliminar);
            panel3.Controls.Add(txtTerritoryDes);
            panel3.Controls.Add(butNuevo);
            panel3.Controls.Add(label32);
            panel3.Controls.Add(butGuardar);
            panel3.Controls.Add(label33);
            panel3.Location = new Point(12, 48);
            panel3.Name = "panel3";
            panel3.Size = new Size(514, 458);
            panel3.TabIndex = 58;
            // 
            // txtRegionID
            // 
            txtRegionID.BackColor = SystemColors.Menu;
            txtRegionID.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtRegionID.Location = new Point(289, 257);
            txtRegionID.Name = "txtRegionID";
            txtRegionID.Size = new Size(200, 38);
            txtRegionID.TabIndex = 43;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(40, 260);
            label3.Name = "label3";
            label3.Size = new Size(119, 31);
            label3.TabIndex = 42;
            label3.Text = "RegionID:";
            // 
            // panel1
            // 
            panel1.BackColor = Color.SteelBlue;
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(txtTerritoryID);
            panel1.Location = new Point(40, 81);
            panel1.Name = "panel1";
            panel1.Size = new Size(449, 109);
            panel1.TabIndex = 41;
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
            label1.Location = new Point(64, 52);
            label1.Name = "label1";
            label1.Size = new Size(168, 38);
            label1.TabIndex = 39;
            label1.Text = "TerritoryID:";
            // 
            // txtTerritoryID
            // 
            txtTerritoryID.BackColor = SystemColors.Menu;
            txtTerritoryID.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtTerritoryID.Location = new Point(257, 52);
            txtTerritoryID.Name = "txtTerritoryID";
            txtTerritoryID.Size = new Size(105, 38);
            txtTerritoryID.TabIndex = 38;
            // 
            // butEliminar
            // 
            butEliminar.Location = new Point(202, 391);
            butEliminar.Name = "butEliminar";
            butEliminar.Size = new Size(148, 61);
            butEliminar.TabIndex = 31;
            butEliminar.Text = "Eliminar";
            butEliminar.UseVisualStyleBackColor = true;
            butEliminar.Click += butEliminar_Click;
            // 
            // txtTerritoryDes
            // 
            txtTerritoryDes.BackColor = SystemColors.Menu;
            txtTerritoryDes.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtTerritoryDes.Location = new Point(289, 206);
            txtTerritoryDes.Name = "txtTerritoryDes";
            txtTerritoryDes.Size = new Size(200, 38);
            txtTerritoryDes.TabIndex = 2;
            // 
            // butNuevo
            // 
            butNuevo.Location = new Point(309, 324);
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
            label32.Location = new Point(40, 213);
            label32.Name = "label32";
            label32.Size = new Size(243, 31);
            label32.TabIndex = 1;
            label32.Text = "Territory Description:";
            // 
            // butGuardar
            // 
            butGuardar.Location = new Point(91, 324);
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
            label33.Location = new Point(117, 12);
            label33.Name = "label33";
            label33.Size = new Size(298, 53);
            label33.TabIndex = 0;
            label33.Text = "Datos - Territories";
            // 
            // dataGridViewTerritories
            // 
            dataGridViewTerritories.BackgroundColor = SystemColors.ActiveCaption;
            dataGridViewTerritories.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewTerritories.Location = new Point(532, 48);
            dataGridViewTerritories.Name = "dataGridViewTerritories";
            dataGridViewTerritories.RowHeadersWidth = 51;
            dataGridViewTerritories.Size = new Size(486, 730);
            dataGridViewTerritories.TabIndex = 57;
            dataGridViewTerritories.SelectionChanged += dataGridViewTerritory_SelectionChanged;
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = SystemColors.GradientActiveCaption;
            menuStrip1.Font = new Font("Segoe UI Historic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { archivoToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1030, 36);
            menuStrip1.TabIndex = 60;
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
            // FormTerritories
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1030, 787);
            Controls.Add(panel2);
            Controls.Add(panel3);
            Controls.Add(dataGridViewTerritories);
            Controls.Add(menuStrip1);
            Name = "FormTerritories";
            Text = "FormTerritories";
            Load += FormTerritories_Load;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewTerritories).EndInit();
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
        private TextBox txtBuscarTerritory;
        private ComboBox boxBuscarTerritory;
        private Panel panel3;
        private Panel panel1;
        private Label label2;
        private Label label1;
        private TextBox txtTerritoryID;
        private TextBox txtTerritoryDes;
        private Label label32;
        private Button butEliminar;
        private Button butNuevo;
        private Button butGuardar;
        private Label label33;
        private DataGridView dataGridViewTerritories;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem archivoToolStripMenuItem;
        private ToolStripMenuItem cerrarToolStripMenuItem;
        private TextBox txtRegionID;
        private Label label3;
    }
}