namespace ProyectoBDNorthwind_Vacio_Yael_
{
    partial class FormCategory
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
            menuStrip1 = new MenuStrip();
            archivoToolStripMenuItem = new ToolStripMenuItem();
            cerrarToolStripMenuItem = new ToolStripMenuItem();
            panel2 = new Panel();
            butRefrescar = new Button();
            label36 = new Label();
            butBuscar = new Button();
            label35 = new Label();
            txtBuscarCategories = new TextBox();
            BoxBuscarCategories = new ComboBox();
            panel3 = new Panel();
            butInsertarImagen = new Button();
            picCategoryPicture = new PictureBox();
            label3 = new Label();
            txtDescription = new TextBox();
            label1 = new Label();
            txtCategoryName = new TextBox();
            panel1 = new Panel();
            label2 = new Label();
            txtCategoryID = new TextBox();
            label32 = new Label();
            butEliminar = new Button();
            butNuevo = new Button();
            butGuardar = new Button();
            label33 = new Label();
            dataGridViewCategories = new DataGridView();
            menuStrip1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picCategoryPicture).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewCategories).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = SystemColors.GradientActiveCaption;
            menuStrip1.Font = new Font("Segoe UI Historic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { archivoToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1135, 36);
            menuStrip1.TabIndex = 64;
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
            panel2.Controls.Add(txtBuscarCategories);
            panel2.Controls.Add(BoxBuscarCategories);
            panel2.Location = new Point(472, 41);
            panel2.Name = "panel2";
            panel2.Size = new Size(657, 177);
            panel2.TabIndex = 63;
            // 
            // butRefrescar
            // 
            butRefrescar.BackColor = SystemColors.ButtonHighlight;
            butRefrescar.BackgroundImage = Properties.Resources.refresh_16dp_000000_FILL0_wght500_GRAD_25_opsz20__1_;
            butRefrescar.BackgroundImageLayout = ImageLayout.Center;
            butRefrescar.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Bold);
            butRefrescar.Location = new Point(463, 95);
            butRefrescar.Name = "butRefrescar";
            butRefrescar.Size = new Size(157, 64);
            butRefrescar.TabIndex = 39;
            butRefrescar.UseVisualStyleBackColor = false;
            butRefrescar.Click += butRefrescar_Click;
            // 
            // label36
            // 
            label36.AutoSize = true;
            label36.Font = new Font("Sitka Banner", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label36.Location = new Point(52, 12);
            label36.Name = "label36";
            label36.Size = new Size(342, 49);
            label36.TabIndex = 33;
            label36.Text = "Busqueda De Registros";
            // 
            // butBuscar
            // 
            butBuscar.BackColor = SystemColors.ButtonHighlight;
            butBuscar.BackgroundImage = Properties.Resources.search_16dp_000000_FILL0_wght500_GRAD0_opsz20;
            butBuscar.BackgroundImageLayout = ImageLayout.Center;
            butBuscar.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Bold);
            butBuscar.Location = new Point(463, 20);
            butBuscar.Name = "butBuscar";
            butBuscar.Size = new Size(157, 64);
            butBuscar.TabIndex = 38;
            butBuscar.UseVisualStyleBackColor = false;
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
            // txtBuscarCategories
            // 
            txtBuscarCategories.BackColor = SystemColors.Menu;
            txtBuscarCategories.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtBuscarCategories.Location = new Point(52, 123);
            txtBuscarCategories.Name = "txtBuscarCategories";
            txtBuscarCategories.Size = new Size(350, 34);
            txtBuscarCategories.TabIndex = 35;
            txtBuscarCategories.Enter += txtBuscarCategories_Enter;
            // 
            // BoxBuscarCategories
            // 
            BoxBuscarCategories.BackColor = SystemColors.Menu;
            BoxBuscarCategories.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BoxBuscarCategories.FormattingEnabled = true;
            BoxBuscarCategories.Items.AddRange(new object[] { "CategoryID", "CategoryName", "Description" });
            BoxBuscarCategories.Location = new Point(181, 78);
            BoxBuscarCategories.Name = "BoxBuscarCategories";
            BoxBuscarCategories.Size = new Size(221, 36);
            BoxBuscarCategories.TabIndex = 37;
            BoxBuscarCategories.SelectedIndexChanged += BoxBuscarCategories_SelectedIndexChanged;
            // 
            // panel3
            // 
            panel3.BackColor = Color.LightSkyBlue;
            panel3.Controls.Add(butInsertarImagen);
            panel3.Controls.Add(picCategoryPicture);
            panel3.Controls.Add(label3);
            panel3.Controls.Add(txtDescription);
            panel3.Controls.Add(label1);
            panel3.Controls.Add(txtCategoryName);
            panel3.Controls.Add(panel1);
            panel3.Controls.Add(butEliminar);
            panel3.Controls.Add(butNuevo);
            panel3.Controls.Add(butGuardar);
            panel3.Controls.Add(label33);
            panel3.Location = new Point(12, 41);
            panel3.Name = "panel3";
            panel3.Size = new Size(445, 708);
            panel3.TabIndex = 62;
            // 
            // butInsertarImagen
            // 
            butInsertarImagen.BackColor = SystemColors.ButtonHighlight;
            butInsertarImagen.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Bold);
            butInsertarImagen.Location = new Point(154, 372);
            butInsertarImagen.Name = "butInsertarImagen";
            butInsertarImagen.Size = new Size(125, 32);
            butInsertarImagen.TabIndex = 50;
            butInsertarImagen.Text = "Insertar Imagen";
            butInsertarImagen.UseVisualStyleBackColor = false;
            butInsertarImagen.Click += butInsertarImagen_Click;
            // 
            // picCategoryPicture
            // 
            picCategoryPicture.BackColor = SystemColors.ControlLight;
            picCategoryPicture.Location = new Point(90, 410);
            picCategoryPicture.Name = "picCategoryPicture";
            picCategoryPicture.Size = new Size(271, 134);
            picCategoryPicture.TabIndex = 49;
            picCategoryPicture.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(32, 320);
            label3.Name = "label3";
            label3.Size = new Size(144, 31);
            label3.TabIndex = 43;
            label3.Text = "Description:";
            // 
            // txtDescription
            // 
            txtDescription.BackColor = SystemColors.Menu;
            txtDescription.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtDescription.Location = new Point(218, 317);
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(193, 34);
            txtDescription.TabIndex = 42;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(32, 255);
            label1.Name = "label1";
            label1.Size = new Size(180, 31);
            label1.TabIndex = 39;
            label1.Text = "CategoryName:";
            // 
            // txtCategoryName
            // 
            txtCategoryName.BackColor = SystemColors.Menu;
            txtCategoryName.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtCategoryName.Location = new Point(218, 252);
            txtCategoryName.Name = "txtCategoryName";
            txtCategoryName.Size = new Size(193, 34);
            txtCategoryName.TabIndex = 38;
            // 
            // panel1
            // 
            panel1.BackColor = Color.SteelBlue;
            panel1.Controls.Add(label2);
            panel1.Controls.Add(txtCategoryID);
            panel1.Controls.Add(label32);
            panel1.Location = new Point(44, 113);
            panel1.Name = "panel1";
            panel1.Size = new Size(362, 112);
            panel1.TabIndex = 41;
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
            // txtCategoryID
            // 
            txtCategoryID.BackColor = SystemColors.Menu;
            txtCategoryID.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtCategoryID.Location = new Point(211, 54);
            txtCategoryID.Name = "txtCategoryID";
            txtCategoryID.Size = new Size(84, 38);
            txtCategoryID.TabIndex = 2;
            // 
            // label32
            // 
            label32.AutoSize = true;
            label32.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label32.Location = new Point(46, 57);
            label32.Name = "label32";
            label32.Size = new Size(141, 31);
            label32.TabIndex = 1;
            label32.Text = "CategoryID:";
            // 
            // butEliminar
            // 
            butEliminar.BackColor = SystemColors.ButtonHighlight;
            butEliminar.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Bold);
            butEliminar.Location = new Point(143, 632);
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
            butNuevo.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Bold);
            butNuevo.Location = new Point(251, 565);
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
            butGuardar.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Bold);
            butGuardar.Location = new Point(44, 565);
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
            label33.Location = new Point(90, 31);
            label33.Name = "label33";
            label33.Size = new Size(293, 53);
            label33.TabIndex = 0;
            label33.Text = "Datos - Categories";
            // 
            // dataGridViewCategories
            // 
            dataGridViewCategories.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCategories.BackgroundColor = SystemColors.ActiveCaption;
            dataGridViewCategories.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCategories.Location = new Point(472, 224);
            dataGridViewCategories.Name = "dataGridViewCategories";
            dataGridViewCategories.RowHeadersWidth = 51;
            dataGridViewCategories.Size = new Size(657, 525);
            dataGridViewCategories.TabIndex = 61;
            dataGridViewCategories.SelectionChanged += dataGridViewCategories_SelectionChanged;
            // 
            // FormCategory
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(1135, 755);
            Controls.Add(menuStrip1);
            Controls.Add(panel2);
            Controls.Add(panel3);
            Controls.Add(dataGridViewCategories);
            Name = "FormCategory";
            Text = "FormCategory";
            Load += FormCategory_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picCategoryPicture).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewCategories).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem archivoToolStripMenuItem;
        private ToolStripMenuItem cerrarToolStripMenuItem;
        private Panel panel2;
        private Button butRefrescar;
        private Label label36;
        private Button butBuscar;
        private Label label35;
        private TextBox txtBuscarCategories;
        private ComboBox BoxBuscarCategories;
        private Panel panel3;
        private Button butInsertarImagen;
        private PictureBox picCategoryPicture;
        private Label label3;
        private TextBox txtDescription;
        private Label label1;
        private TextBox txtCategoryName;
        private Panel panel1;
        private Label label2;
        private TextBox txtCategoryID;
        private Label label32;
        private Button butEliminar;
        private Button butNuevo;
        private Button butGuardar;
        private Label label33;
        private DataGridView dataGridViewCategories;
    }
}