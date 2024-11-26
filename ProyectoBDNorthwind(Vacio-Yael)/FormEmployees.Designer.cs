namespace ProyectoBDNorthwind_Vacio_Yael_
{
    partial class FormEmployees
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
            pictureBoxPhoto = new PictureBox();
            label2 = new Label();
            menuStrip1 = new MenuStrip();
            archivoToolStripMenuItem = new ToolStripMenuItem();
            cerrarToolStripMenuItem = new ToolStripMenuItem();
            butInsertarImagen = new Button();
            label1 = new Label();
            txtEmployeeID = new TextBox();
            txtLastName = new TextBox();
            label3 = new Label();
            txtFirstName = new TextBox();
            label4 = new Label();
            txtTitle = new TextBox();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            dtpBirthDate = new DateTimePicker();
            dtpHireDate = new DateTimePicker();
            txtCountry = new TextBox();
            label9 = new Label();
            txtPostalCode = new TextBox();
            label10 = new Label();
            txtRegion = new TextBox();
            label11 = new Label();
            txtCity = new TextBox();
            label12 = new Label();
            txtReportsTo = new TextBox();
            label13 = new Label();
            txtNotes = new TextBox();
            label14 = new Label();
            txtExtension = new TextBox();
            label15 = new Label();
            txtHomePhone = new TextBox();
            label16 = new Label();
            txtAddress = new TextBox();
            label17 = new Label();
            txtPhotoPath = new TextBox();
            label18 = new Label();
            panel1 = new Panel();
            panel4 = new Panel();
            butEliminar = new Button();
            butNuevo = new Button();
            butAgregar = new Button();
            panel3 = new Panel();
            boxTitleOfCourtesy = new ComboBox();
            panel2 = new Panel();
            butRefrescar = new Button();
            butBuscar = new Button();
            txtBuscarEmployees = new TextBox();
            BoxBuscarEmployees = new ComboBox();
            label19 = new Label();
            dataGridViewEmployees = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)pictureBoxPhoto).BeginInit();
            menuStrip1.SuspendLayout();
            panel1.SuspendLayout();
            panel4.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewEmployees).BeginInit();
            SuspendLayout();
            // 
            // pictureBoxPhoto
            // 
            pictureBoxPhoto.BackColor = SystemColors.ControlLight;
            pictureBoxPhoto.Location = new Point(29, 46);
            pictureBoxPhoto.Name = "pictureBoxPhoto";
            pictureBoxPhoto.Size = new Size(192, 171);
            pictureBoxPhoto.TabIndex = 0;
            pictureBoxPhoto.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Sitka Display", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(16, 8);
            label2.Name = "label2";
            label2.Size = new Size(271, 49);
            label2.TabIndex = 1;
            label2.Text = "Datos - Employee";
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = SystemColors.GradientActiveCaption;
            menuStrip1.Font = new Font("Segoe UI Symbol", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { archivoToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1050, 36);
            menuStrip1.TabIndex = 46;
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
            // butInsertarImagen
            // 
            butInsertarImagen.BackColor = SystemColors.ButtonHighlight;
            butInsertarImagen.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            butInsertarImagen.Location = new Point(29, 8);
            butInsertarImagen.Name = "butInsertarImagen";
            butInsertarImagen.Size = new Size(192, 32);
            butInsertarImagen.TabIndex = 48;
            butInsertarImagen.Text = "Insertar Imagen";
            butInsertarImagen.UseVisualStyleBackColor = false;
            butInsertarImagen.Click += butInsertarImagen_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(16, 90);
            label1.Name = "label1";
            label1.Size = new Size(148, 31);
            label1.TabIndex = 49;
            label1.Text = "EmployeeID:";
            // 
            // txtEmployeeID
            // 
            txtEmployeeID.BackColor = SystemColors.ScrollBar;
            txtEmployeeID.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtEmployeeID.Location = new Point(179, 89);
            txtEmployeeID.Name = "txtEmployeeID";
            txtEmployeeID.Size = new Size(73, 38);
            txtEmployeeID.TabIndex = 50;
            // 
            // txtLastName
            // 
            txtLastName.BackColor = SystemColors.Menu;
            txtLastName.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtLastName.Location = new Point(29, 173);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(270, 27);
            txtLastName.TabIndex = 52;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(29, 147);
            label3.Name = "label3";
            label3.Size = new Size(99, 23);
            label3.TabIndex = 51;
            label3.Text = "Last Name:";
            // 
            // txtFirstName
            // 
            txtFirstName.BackColor = SystemColors.ButtonFace;
            txtFirstName.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtFirstName.Location = new Point(29, 229);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(270, 27);
            txtFirstName.TabIndex = 54;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(29, 203);
            label4.Name = "label4";
            label4.Size = new Size(102, 23);
            label4.TabIndex = 53;
            label4.Text = "First Name:";
            // 
            // txtTitle
            // 
            txtTitle.BackColor = SystemColors.ButtonFace;
            txtTitle.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtTitle.Location = new Point(29, 286);
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new Size(270, 27);
            txtTitle.TabIndex = 56;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(29, 260);
            label5.Name = "label5";
            label5.Size = new Size(51, 23);
            label5.TabIndex = 55;
            label5.Text = "Title:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(29, 316);
            label6.Name = "label6";
            label6.Size = new Size(151, 23);
            label6.TabIndex = 57;
            label6.Text = "Title Of Courtesy:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(29, 373);
            label7.Name = "label7";
            label7.Size = new Size(91, 23);
            label7.TabIndex = 59;
            label7.Text = "Birth Day:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(29, 431);
            label8.Name = "label8";
            label8.Size = new Size(92, 23);
            label8.TabIndex = 61;
            label8.Text = "Hire Date:";
            // 
            // dtpBirthDate
            // 
            dtpBirthDate.CustomFormat = "yyyy-MM-dd";
            dtpBirthDate.Format = DateTimePickerFormat.Custom;
            dtpBirthDate.Location = new Point(29, 401);
            dtpBirthDate.Name = "dtpBirthDate";
            dtpBirthDate.Size = new Size(270, 27);
            dtpBirthDate.TabIndex = 62;
            // 
            // dtpHireDate
            // 
            dtpHireDate.CustomFormat = "yyyy-MM-dd";
            dtpHireDate.Format = DateTimePickerFormat.Custom;
            dtpHireDate.Location = new Point(29, 457);
            dtpHireDate.Name = "dtpHireDate";
            dtpHireDate.Size = new Size(270, 27);
            dtpHireDate.TabIndex = 63;
            // 
            // txtCountry
            // 
            txtCountry.BackColor = SystemColors.ButtonFace;
            txtCountry.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtCountry.Location = new Point(384, 229);
            txtCountry.Name = "txtCountry";
            txtCountry.Size = new Size(270, 27);
            txtCountry.TabIndex = 71;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(384, 203);
            label9.Name = "label9";
            label9.Size = new Size(80, 23);
            label9.TabIndex = 70;
            label9.Text = "Country:";
            // 
            // txtPostalCode
            // 
            txtPostalCode.BackColor = SystemColors.ButtonFace;
            txtPostalCode.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPostalCode.Location = new Point(384, 173);
            txtPostalCode.Name = "txtPostalCode";
            txtPostalCode.Size = new Size(270, 27);
            txtPostalCode.TabIndex = 69;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.Location = new Point(384, 147);
            label10.Name = "label10";
            label10.Size = new Size(108, 23);
            label10.TabIndex = 68;
            label10.Text = "Postal Code:";
            // 
            // txtRegion
            // 
            txtRegion.BackColor = SystemColors.ButtonFace;
            txtRegion.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtRegion.Location = new Point(384, 116);
            txtRegion.Name = "txtRegion";
            txtRegion.Size = new Size(270, 27);
            txtRegion.TabIndex = 67;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.Location = new Point(384, 90);
            label11.Name = "label11";
            label11.Size = new Size(71, 23);
            label11.TabIndex = 66;
            label11.Text = "Region:";
            // 
            // txtCity
            // 
            txtCity.BackColor = SystemColors.ButtonFace;
            txtCity.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtCity.Location = new Point(384, 60);
            txtCity.Name = "txtCity";
            txtCity.Size = new Size(270, 27);
            txtCity.TabIndex = 65;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.Location = new Point(384, 34);
            label12.Name = "label12";
            label12.Size = new Size(47, 23);
            label12.TabIndex = 64;
            label12.Text = "City:";
            // 
            // txtReportsTo
            // 
            txtReportsTo.BackColor = SystemColors.ButtonFace;
            txtReportsTo.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtReportsTo.Location = new Point(384, 462);
            txtReportsTo.Name = "txtReportsTo";
            txtReportsTo.Size = new Size(270, 27);
            txtReportsTo.TabIndex = 79;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label13.Location = new Point(384, 436);
            label13.Name = "label13";
            label13.Size = new Size(100, 23);
            label13.TabIndex = 78;
            label13.Text = "Reports To:";
            // 
            // txtNotes
            // 
            txtNotes.BackColor = SystemColors.ButtonFace;
            txtNotes.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNotes.Location = new Point(384, 406);
            txtNotes.Name = "txtNotes";
            txtNotes.Size = new Size(270, 27);
            txtNotes.TabIndex = 77;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label14.Location = new Point(384, 380);
            label14.Name = "label14";
            label14.Size = new Size(61, 23);
            label14.TabIndex = 76;
            label14.Text = "Notes:";
            // 
            // txtExtension
            // 
            txtExtension.BackColor = SystemColors.ButtonFace;
            txtExtension.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtExtension.Location = new Point(384, 349);
            txtExtension.Name = "txtExtension";
            txtExtension.Size = new Size(270, 27);
            txtExtension.TabIndex = 75;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label15.Location = new Point(384, 323);
            label15.Name = "label15";
            label15.Size = new Size(91, 23);
            label15.TabIndex = 74;
            label15.Text = "Extension:";
            // 
            // txtHomePhone
            // 
            txtHomePhone.BackColor = SystemColors.ButtonFace;
            txtHomePhone.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtHomePhone.Location = new Point(384, 293);
            txtHomePhone.Name = "txtHomePhone";
            txtHomePhone.Size = new Size(270, 27);
            txtHomePhone.TabIndex = 73;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label16.Location = new Point(384, 267);
            label16.Name = "label16";
            label16.Size = new Size(117, 23);
            label16.TabIndex = 72;
            label16.Text = "Home Phone:";
            // 
            // txtAddress
            // 
            txtAddress.BackColor = SystemColors.ButtonFace;
            txtAddress.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtAddress.Location = new Point(29, 515);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(270, 27);
            txtAddress.TabIndex = 81;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label17.Location = new Point(29, 489);
            label17.Name = "label17";
            label17.Size = new Size(79, 23);
            label17.TabIndex = 80;
            label17.Text = "Address:";
            // 
            // txtPhotoPath
            // 
            txtPhotoPath.BackColor = SystemColors.ButtonFace;
            txtPhotoPath.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPhotoPath.Location = new Point(384, 522);
            txtPhotoPath.Name = "txtPhotoPath";
            txtPhotoPath.Size = new Size(270, 27);
            txtPhotoPath.TabIndex = 83;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label18.Location = new Point(384, 496);
            label18.Name = "label18";
            label18.Size = new Size(103, 23);
            label18.TabIndex = 82;
            label18.Text = "Photo Path:";
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(12, 39);
            panel1.Name = "panel1";
            panel1.Size = new Size(1016, 584);
            panel1.TabIndex = 84;
            // 
            // panel4
            // 
            panel4.BackColor = Color.LightSkyBlue;
            panel4.Controls.Add(butEliminar);
            panel4.Controls.Add(butNuevo);
            panel4.Controls.Add(butAgregar);
            panel4.Controls.Add(butInsertarImagen);
            panel4.Controls.Add(pictureBoxPhoto);
            panel4.Location = new Point(28, 11);
            panel4.Name = "panel4";
            panel4.Size = new Size(249, 362);
            panel4.TabIndex = 95;
            // 
            // butEliminar
            // 
            butEliminar.BackColor = SystemColors.ButtonHighlight;
            butEliminar.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            butEliminar.Location = new Point(29, 318);
            butEliminar.Name = "butEliminar";
            butEliminar.Size = new Size(192, 32);
            butEliminar.TabIndex = 86;
            butEliminar.Text = "Eliminar";
            butEliminar.UseVisualStyleBackColor = false;
            butEliminar.Click += butEliminar_Click;
            // 
            // butNuevo
            // 
            butNuevo.BackColor = SystemColors.ButtonHighlight;
            butNuevo.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            butNuevo.Location = new Point(29, 280);
            butNuevo.Name = "butNuevo";
            butNuevo.Size = new Size(192, 32);
            butNuevo.TabIndex = 85;
            butNuevo.Text = "Nuevo";
            butNuevo.UseVisualStyleBackColor = false;
            butNuevo.Click += butNuevo_Click;
            // 
            // butAgregar
            // 
            butAgregar.BackColor = SystemColors.ButtonHighlight;
            butAgregar.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            butAgregar.Location = new Point(29, 242);
            butAgregar.Name = "butAgregar";
            butAgregar.Size = new Size(192, 32);
            butAgregar.TabIndex = 84;
            butAgregar.Text = "Agregar / Modificar";
            butAgregar.UseVisualStyleBackColor = false;
            butAgregar.Click += butAgregar_Click;
            // 
            // panel3
            // 
            panel3.BackColor = Color.LightSkyBlue;
            panel3.Controls.Add(boxTitleOfCourtesy);
            panel3.Controls.Add(txtPhotoPath);
            panel3.Controls.Add(label18);
            panel3.Controls.Add(label2);
            panel3.Controls.Add(txtAddress);
            panel3.Controls.Add(label17);
            panel3.Controls.Add(txtReportsTo);
            panel3.Controls.Add(label13);
            panel3.Controls.Add(txtNotes);
            panel3.Controls.Add(label14);
            panel3.Controls.Add(txtExtension);
            panel3.Controls.Add(label15);
            panel3.Controls.Add(txtHomePhone);
            panel3.Controls.Add(label16);
            panel3.Controls.Add(txtCountry);
            panel3.Controls.Add(label9);
            panel3.Controls.Add(txtPostalCode);
            panel3.Controls.Add(label10);
            panel3.Controls.Add(txtRegion);
            panel3.Controls.Add(label11);
            panel3.Controls.Add(txtCity);
            panel3.Controls.Add(label12);
            panel3.Controls.Add(dtpHireDate);
            panel3.Controls.Add(dtpBirthDate);
            panel3.Controls.Add(label8);
            panel3.Controls.Add(label7);
            panel3.Controls.Add(label6);
            panel3.Controls.Add(txtTitle);
            panel3.Controls.Add(label5);
            panel3.Controls.Add(txtFirstName);
            panel3.Controls.Add(label4);
            panel3.Controls.Add(txtLastName);
            panel3.Controls.Add(label3);
            panel3.Controls.Add(txtEmployeeID);
            panel3.Controls.Add(label1);
            panel3.Location = new Point(301, 11);
            panel3.Name = "panel3";
            panel3.Size = new Size(685, 563);
            panel3.TabIndex = 94;
            // 
            // boxTitleOfCourtesy
            // 
            boxTitleOfCourtesy.BackColor = SystemColors.Menu;
            boxTitleOfCourtesy.FormattingEnabled = true;
            boxTitleOfCourtesy.Items.AddRange(new object[] { "Mr.", "Ms.", "Mrs.", "Dr.", "Prof.", "Sir." });
            boxTitleOfCourtesy.Location = new Point(29, 342);
            boxTitleOfCourtesy.Name = "boxTitleOfCourtesy";
            boxTitleOfCourtesy.Size = new Size(270, 28);
            boxTitleOfCourtesy.TabIndex = 92;
            // 
            // panel2
            // 
            panel2.BackColor = Color.LightSkyBlue;
            panel2.Controls.Add(butRefrescar);
            panel2.Controls.Add(butBuscar);
            panel2.Controls.Add(txtBuscarEmployees);
            panel2.Controls.Add(BoxBuscarEmployees);
            panel2.Controls.Add(label19);
            panel2.Location = new Point(28, 383);
            panel2.Name = "panel2";
            panel2.Size = new Size(249, 190);
            panel2.TabIndex = 93;
            // 
            // butRefrescar
            // 
            butRefrescar.BackColor = SystemColors.ButtonHighlight;
            butRefrescar.BackgroundImage = Properties.Resources.refresh_16dp_000000_FILL0_wght500_GRAD_25_opsz20__1_;
            butRefrescar.BackgroundImageLayout = ImageLayout.Zoom;
            butRefrescar.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            butRefrescar.Location = new Point(29, 149);
            butRefrescar.Name = "butRefrescar";
            butRefrescar.Size = new Size(192, 32);
            butRefrescar.TabIndex = 91;
            butRefrescar.UseVisualStyleBackColor = false;
            butRefrescar.Click += butRefrescar_Click;
            // 
            // butBuscar
            // 
            butBuscar.BackColor = SystemColors.ButtonHighlight;
            butBuscar.BackgroundImage = Properties.Resources.search_16dp_000000_FILL0_wght500_GRAD0_opsz20;
            butBuscar.BackgroundImageLayout = ImageLayout.Zoom;
            butBuscar.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            butBuscar.Location = new Point(29, 111);
            butBuscar.Name = "butBuscar";
            butBuscar.Size = new Size(192, 32);
            butBuscar.TabIndex = 90;
            butBuscar.UseVisualStyleBackColor = false;
            butBuscar.Click += butBuscar_Click;
            // 
            // txtBuscarEmployees
            // 
            txtBuscarEmployees.BackColor = SystemColors.Menu;
            txtBuscarEmployees.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtBuscarEmployees.Location = new Point(29, 78);
            txtBuscarEmployees.Name = "txtBuscarEmployees";
            txtBuscarEmployees.Size = new Size(192, 27);
            txtBuscarEmployees.TabIndex = 89;
            txtBuscarEmployees.Enter += txtBuscarEmployees_Enter;
            // 
            // BoxBuscarEmployees
            // 
            BoxBuscarEmployees.BackColor = SystemColors.Menu;
            BoxBuscarEmployees.FormattingEnabled = true;
            BoxBuscarEmployees.Items.AddRange(new object[] { "EmployeeID", "LastName", "FirstName", "Title", "BirthDate", "HireDate", "Address", "City", "Region", "PostalCode", "Country", "HomePhone", "Extension" });
            BoxBuscarEmployees.Location = new Point(29, 44);
            BoxBuscarEmployees.Name = "BoxBuscarEmployees";
            BoxBuscarEmployees.Size = new Size(192, 28);
            BoxBuscarEmployees.TabIndex = 88;
            BoxBuscarEmployees.SelectedIndexChanged += BoxBuscarEmployees_SelectedIndexChanged;
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label19.Location = new Point(29, 6);
            label19.Name = "label19";
            label19.Size = new Size(119, 28);
            label19.TabIndex = 87;
            label19.Text = "Buscar por:";
            // 
            // dataGridViewEmployees
            // 
            dataGridViewEmployees.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewEmployees.BackgroundColor = SystemColors.ActiveCaption;
            dataGridViewEmployees.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewEmployees.Location = new Point(12, 629);
            dataGridViewEmployees.Name = "dataGridViewEmployees";
            dataGridViewEmployees.RowHeadersWidth = 50;
            dataGridViewEmployees.Size = new Size(1016, 224);
            dataGridViewEmployees.TabIndex = 85;
            dataGridViewEmployees.SelectionChanged += dataGridViewEmployees_SelectionChanged;
            // 
            // FormEmployees
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            BackgroundImage = Properties.Resources.fondo_azul_para_textura;
            ClientSize = new Size(1050, 860);
            Controls.Add(dataGridViewEmployees);
            Controls.Add(panel1);
            Controls.Add(menuStrip1);
            Name = "FormEmployees";
            Text = "FormEmployees";
            Load += FormEmployees_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBoxPhoto).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            panel1.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewEmployees).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBoxPhoto;
        private Label label2;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem archivoToolStripMenuItem;
        private ToolStripMenuItem cerrarToolStripMenuItem;
        private Button butInsertarImagen;
        private Label label1;
        private TextBox txtEmployeeID;
        private TextBox txtLastName;
        private Label label3;
        private TextBox txtFirstName;
        private Label label4;
        private TextBox txtTitle;
        private Label label5;
        private TextBox txtTitleOfCourtesy;
        private Label label6;
        private Label label7;
        private Label label8;
        private DateTimePicker dtpBirthDate;
        private DateTimePicker dtpHireDate;
        private TextBox txtCountry;
        private TextBox textBox6;
        private Label label9;
        private TextBox txtPostalCode;
        private TextBox textBox7;
        private Label label10;
        private TextBox txtRegion;
        private TextBox textBox8;
        private Label label11;
        private TextBox txtCity;
        private TextBox textBox9;
        private Label label12;
        private TextBox txtReportsTo;
        private Label label13;
        private TextBox txtNotes;
        private TextBox textBox11;
        private Label label14;
        private TextBox txtExtension;
        private TextBox textBox12;
        private Label label15;
        private TextBox txtHomePhone;
        private Label label16;
        private TextBox txtAddress;
        private Label label17;
        private TextBox txtPhotoPath;
        private Label label18;
        private Panel panel1;
        private Button butAgregar;
        private Button butRefrescar;
        private Button butBuscar;
        private TextBox txtBuscarEmployees;
        private ComboBox BoxBuscarEmployees;
        private Label label19;
        private Button butEliminar;
        private Button butNuevo;
        private ComboBox boxTitleOfCourtesy;
        private DataGridView dataGridViewEmployees;
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
    }
}