using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoBDNorthwind_Vacio_Yael_
{
    public partial class FormLOGIN : Form
    {
        public FormLOGIN()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "ADMIN" && txtContraseña.Text == "0000")
            {
                this.Hide();
                Form_Inicio_Admin form_Inicio_Admin = new Form_Inicio_Admin();
                form_Inicio_Admin.ShowDialog();
            }
            else if (txtUsuario.Text == "GERENTE" && txtContraseña.Text == "0000")
            {
                this.Hide();
                FormMenuGERENTE formMenuGerente = new FormMenuGERENTE();
                formMenuGerente.ShowDialog();
            }
            else if (txtUsuario.Text == "EMPLEADO" && txtContraseña.Text == "0000")
            {
                this.Hide();
                FormMenuEmpleado formMenuEmpleado = new FormMenuEmpleado();
                formMenuEmpleado.ShowDialog();
            }
            else
                MessageBox.Show("Usuario y/o Contraseña Incorrectos");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
