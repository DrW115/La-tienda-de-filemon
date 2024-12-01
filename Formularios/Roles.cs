using ProyectoFinal2.Formularios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace ProyectoFinal2
{
    public partial class Roles : Form
    {
        public Roles()
        {
            InitializeComponent();
        }

        private void btnCliente_Click(object sender, EventArgs e)
        {
            ClienteLogin clienteLogin = new ClienteLogin();
            clienteLogin.Show();
        }

        private void btnOperador_Click(object sender, EventArgs e)
        {
            OperadorLogin operadorLogin = new OperadorLogin();
            operadorLogin.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           Application.Exit();
        }
    }
}
