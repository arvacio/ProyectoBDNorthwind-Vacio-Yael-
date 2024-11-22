namespace ProyectoBDNorthwind_Vacio_Yael_
{
    partial class FormLOGIN
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
            txtUsuario = new MaskedTextBox();
            txtContraseña = new MaskedTextBox();
            label1 = new Label();
            label2 = new Label();
            button1 = new Button();
            button2 = new Button();
            label3 = new Label();
            SuspendLayout();
            // 
            // txtUsuario
            // 
            txtUsuario.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtUsuario.Location = new Point(32, 177);
            txtUsuario.Mask = "AAAAAAAAAA";
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(119, 43);
            txtUsuario.TabIndex = 0;
            // 
            // txtContraseña
            // 
            txtContraseña.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtContraseña.Location = new Point(32, 309);
            txtContraseña.Mask = "AAAA";
            txtContraseña.Name = "txtContraseña";
            txtContraseña.PasswordChar = '*';
            txtContraseña.Size = new Size(112, 43);
            txtContraseña.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(32, 115);
            label1.Name = "label1";
            label1.Size = new Size(148, 38);
            label1.TabIndex = 2;
            label1.Text = "USUARIO:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(32, 255);
            label2.Name = "label2";
            label2.Size = new Size(212, 38);
            label2.TabIndex = 3;
            label2.Text = "CONTRASEÑA:";
            // 
            // button1
            // 
            button1.Location = new Point(32, 399);
            button1.Name = "button1";
            button1.Size = new Size(94, 68);
            button1.TabIndex = 4;
            button1.Text = "Iniciar Sesion";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(160, 399);
            button2.Name = "button2";
            button2.Size = new Size(94, 68);
            button2.TabIndex = 5;
            button2.Text = "Salir";
            button2.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(32, 39);
            label3.Name = "label3";
            label3.Size = new Size(357, 54);
            label3.TabIndex = 6;
            label3.Text = "NorthWind CRUD";
            // 
            // FormLOGIN
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(460, 504);
            Controls.Add(label3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtContraseña);
            Controls.Add(txtUsuario);
            Name = "FormLOGIN";
            Text = "FormLOGIN";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MaskedTextBox txtUsuario;
        private MaskedTextBox txtContraseña;
        private Label label1;
        private Label label2;
        private Button button1;
        private Button button2;
        private Label label3;
    }
}