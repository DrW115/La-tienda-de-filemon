using AutomatizaciónDeTiendas.Estructuras;
using ProyectoFinal2.Estructuras;
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
    public partial class ClienteLogin : Form
    {
        List<Cliente> clientes = new List<Cliente>();
        GuardarDatos gd = new GuardarDatos();
        public ClienteLogin()
        {
            InitializeComponent();
            clientes = gd.CargarClientes();
        }
        


        private void btnLogin_Click(object sender, EventArgs e)
        {
            Cliente clienteExistente = clientes.Find(x => x.NombreDeUsuario == txtIdCliente.Text && x.Password == txtClientePassword.Text);
            if (clienteExistente != null)
            {
                ClienteInterfaz clienteInterfaz = new ClienteInterfaz(clienteExistente.correo);
                clienteInterfaz.Show();

            }
        }

        private void btnRegistrarse_Click(object sender, EventArgs e)
        {
            CrearCuentaCliente crearCuentaCliente = new CrearCuentaCliente();
            crearCuentaCliente.Show();
        }
    }
}
