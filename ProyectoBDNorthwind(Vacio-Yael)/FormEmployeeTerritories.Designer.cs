﻿namespace ProyectoBDNorthwind_Vacio_Yael_
{
    partial class FormEmployeeTerritories
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
            label3 = new Label();
            panel1 = new Panel();
            boxTerritoryID = new ComboBox();
            boxEmployeeID = new ComboBox();
            label2 = new Label();
            label1 = new Label();
            label32 = new Label();
            butEliminar = new Button();
            butNuevo = new Button();
            butGuardar = new Button();
            label33 = new Label();
            butRefrescar = new Button();
            butBuscar = new Button();
            boxBuscar = new ComboBox();
            txtBuscarET = new TextBox();
            label35 = new Label();
            label36 = new Label();
            dataGridViewET = new DataGridView();
            menuStrip1 = new MenuStrip();
            archivoToolStripMenuItem = new ToolStripMenuItem();
            cerrarToolStripMenuItem = new ToolStripMenuItem();
            panel2 = new Panel();
            panel3.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewET).BeginInit();
            menuStrip1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel3
            // 
            panel3.BackColor = Color.LightSkyBlue;
            panel3.Controls.Add(label3);
            panel3.Controls.Add(panel1);
            panel3.Controls.Add(butEliminar);
            panel3.Controls.Add(butNuevo);
            panel3.Controls.Add(butGuardar);
            panel3.Controls.Add(label33);
            panel3.Location = new Point(12, 52);
            panel3.Name = "panel3";
            panel3.Size = new Size(445, 458);
            panel3.TabIndex = 55;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Sitka Banner", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(49, 54);
            label3.Name = "label3";
            label3.Size = new Size(360, 53);
            label3.TabIndex = 42;
            label3.Text = "Employee - Territories";
            // 
            // panel1
            // 
            panel1.BackColor = Color.SteelBlue;
            panel1.Controls.Add(boxTerritoryID);
            panel1.Controls.Add(boxEmployeeID);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label32);
            panel1.Location = new Point(44, 128);
            panel1.Name = "panel1";
            panel1.Size = new Size(362, 169);
            panel1.TabIndex = 41;
            // 
            // boxTerritoryID
            // 
            boxTerritoryID.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            boxTerritoryID.FormattingEnabled = true;
            boxTerritoryID.Location = new Point(221, 111);
            boxTerritoryID.Name = "boxTerritoryID";
            boxTerritoryID.Size = new Size(103, 36);
            boxTerritoryID.TabIndex = 42;
            // 
            // boxEmployeeID
            // 
            boxEmployeeID.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            boxEmployeeID.FormattingEnabled = true;
            boxEmployeeID.Location = new Point(221, 52);
            boxEmployeeID.Name = "boxEmployeeID";
            boxEmployeeID.Size = new Size(103, 36);
            boxEmployeeID.TabIndex = 41;
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
            label1.Size = new Size(137, 31);
            label1.TabIndex = 39;
            label1.Text = "TerritoryID:";
            // 
            // label32
            // 
            label32.AutoSize = true;
            label32.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label32.Location = new Point(46, 57);
            label32.Name = "label32";
            label32.Size = new Size(148, 31);
            label32.TabIndex = 1;
            label32.Text = "EmployeeID:";
            // 
            // butEliminar
            // 
            butEliminar.BackColor = SystemColors.ButtonHighlight;
            butEliminar.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            butEliminar.Location = new Point(148, 391);
            butEliminar.Name = "butEliminar";
            butEliminar.Size = new Size(148, 61);
            butEliminar.TabIndex = 31;
            butEliminar.Text = "Eliminar";
            butEliminar.UseVisualStyleBackColor = false;
            butEliminar.Click += butEliminar_Click;
            // 
            // butNuevo
            // 
            butNuevo.BackColor = SystemColors.ButtonHighlight;
            butNuevo.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            butNuevo.Location = new Point(256, 314);
            butNuevo.Name = "butNuevo";
            butNuevo.Size = new Size(148, 61);
            butNuevo.TabIndex = 30;
            butNuevo.Text = "Nuevo Registro";
            butNuevo.UseVisualStyleBackColor = false;
            butNuevo.Click += butNuevo_Click;
            // 
            // butGuardar
            // 
            butGuardar.BackColor = SystemColors.ButtonHighlight;
            butGuardar.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            butGuardar.Location = new Point(49, 314);
            butGuardar.Name = "butGuardar";
            butGuardar.Size = new Size(148, 61);
            butGuardar.TabIndex = 29;
            butGuardar.Text = "Guardar/Modificar";
            butGuardar.UseVisualStyleBackColor = false;
            butGuardar.Click += butGuardar_Click;
            // 
            // label33
            // 
            label33.AutoSize = true;
            label33.Font = new Font("Sitka Banner", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label33.Location = new Point(171, 11);
            label33.Name = "label33";
            label33.Size = new Size(108, 53);
            label33.TabIndex = 0;
            label33.Text = "Datos";
            // 
            // butRefrescar
            // 
            butRefrescar.BackColor = SystemColors.ButtonHighlight;
            butRefrescar.BackgroundImage = Properties.Resources.refresh_16dp_000000_FILL0_wght500_GRAD_25_opsz20__1_;
            butRefrescar.BackgroundImageLayout = ImageLayout.Zoom;
            butRefrescar.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            butRefrescar.Location = new Point(289, 187);
            butRefrescar.Name = "butRefrescar";
            butRefrescar.Size = new Size(117, 61);
            butRefrescar.TabIndex = 39;
            butRefrescar.UseVisualStyleBackColor = false;
            butRefrescar.Click += butRefrescar_Click;
            // 
            // butBuscar
            // 
            butBuscar.BackColor = SystemColors.ButtonHighlight;
            butBuscar.BackgroundImage = Properties.Resources.search_16dp_000000_FILL0_wght500_GRAD0_opsz20;
            butBuscar.BackgroundImageLayout = ImageLayout.Zoom;
            butBuscar.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            butBuscar.Location = new Point(40, 187);
            butBuscar.Name = "butBuscar";
            butBuscar.Size = new Size(117, 61);
            butBuscar.TabIndex = 38;
            butBuscar.UseVisualStyleBackColor = false;
            butBuscar.Click += butBuscar_Click;
            // 
            // boxBuscar
            // 
            boxBuscar.BackColor = SystemColors.Menu;
            boxBuscar.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            boxBuscar.FormattingEnabled = true;
            boxBuscar.Items.AddRange(new object[] { "EmployeeID", "TerritoryID", "FirstName", "TerritoryDescription" });
            boxBuscar.Location = new Point(181, 78);
            boxBuscar.Name = "boxBuscar";
            boxBuscar.Size = new Size(221, 36);
            boxBuscar.TabIndex = 37;
            boxBuscar.SelectedIndexChanged += boxBuscarET_SelectedIndexChanged;
            // 
            // txtBuscarET
            // 
            txtBuscarET.BackColor = SystemColors.Menu;
            txtBuscarET.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtBuscarET.Location = new Point(40, 133);
            txtBuscarET.Name = "txtBuscarET";
            txtBuscarET.Size = new Size(362, 34);
            txtBuscarET.TabIndex = 35;
            txtBuscarET.Enter += txtBuscarET_Enter;
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
            // label36
            // 
            label36.AutoSize = true;
            label36.Font = new Font("Sitka Banner", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label36.Location = new Point(70, 18);
            label36.Name = "label36";
            label36.Size = new Size(298, 43);
            label36.TabIndex = 33;
            label36.Text = "Busqueda De Registros";
            // 
            // dataGridViewET
            // 
            dataGridViewET.BackgroundColor = SystemColors.ActiveCaption;
            dataGridViewET.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewET.Location = new Point(469, 52);
            dataGridViewET.Name = "dataGridViewET";
            dataGridViewET.RowHeadersWidth = 51;
            dataGridViewET.Size = new Size(590, 730);
            dataGridViewET.TabIndex = 53;
            dataGridViewET.SelectionChanged += dataGridViewET_SelectionChanged;
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = SystemColors.GradientActiveCaption;
            menuStrip1.Font = new Font("Segoe UI Historic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { archivoToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1071, 36);
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
            // panel2
            // 
            panel2.BackColor = Color.LightSkyBlue;
            panel2.Controls.Add(butRefrescar);
            panel2.Controls.Add(label36);
            panel2.Controls.Add(butBuscar);
            panel2.Controls.Add(label35);
            panel2.Controls.Add(txtBuscarET);
            panel2.Controls.Add(boxBuscar);
            panel2.Location = new Point(12, 516);
            panel2.Name = "panel2";
            panel2.Size = new Size(445, 266);
            panel2.TabIndex = 56;
            // 
            // FormEmployeeTerritories
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            BackgroundImage = Properties.Resources.fondo_azul_para_textura;
            ClientSize = new Size(1071, 794);
            Controls.Add(panel2);
            Controls.Add(panel3);
            Controls.Add(dataGridViewET);
            Controls.Add(menuStrip1);
            Name = "FormEmployeeTerritories";
            Text = "FormEmployeeTerritories";
            Load += FormEmployeeTerritories_Load;
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewET).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel3;
        private Panel panel1;
        private Label label2;
        private Label label1;
        private Label label32;
        private Button butEliminar;
        private Button butNuevo;
        private Button butGuardar;
        private Label label33;
        private Button butRefrescar;
        private Button butBuscar;
        private ComboBox boxBuscar;
        private TextBox txtBuscarET;
        private Label label35;
        private Label label36;
        private DataGridView dataGridViewET;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem archivoToolStripMenuItem;
        private ToolStripMenuItem cerrarToolStripMenuItem;
        private Panel panel2;
        private Label label3;
        private ComboBox boxTerritoryID;
        private ComboBox boxEmployeeID;
    }
}