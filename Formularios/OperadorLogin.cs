using AutomatizaciónDeTiendas.Estructuras;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoFinal2.Formularios
{
    public partial class OperadorLogin : Form
    {
        public OperadorLogin()
        {
            InitializeComponent();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtId.Text);
            string password = txtPassword.Text;

            if (OperadoresPredefinidos.VerificacionCredenciales(id, password))
            {
                InterfazOperador operador = new InterfazOperador();
                operador.Show();
                this.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
