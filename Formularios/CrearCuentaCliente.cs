using AutomatizaciónDeTiendas.Estructuras;
using ProyectoFinal2.Estructuras;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoFinal2.Formularios
{
    public partial class CrearCuentaCliente : Form
    {
        public List<Cliente> clientes = new List<Cliente>();
        GuardarDatos gd = new GuardarDatos();
        public CrearCuentaCliente()
        {
            InitializeComponent();
            clientes = gd.CargarClientes();
        }
        private bool VerificarCorreo(string correo)
        {
            try
            {
                var direccionCorreo = new MailAddress(correo);
                return true;
            }
            catch (FormatException)
            {
                return false;
            }
        }

        private void btnCrearCuenta_Click(object sender, EventArgs e)
        {
           if(string.IsNullOrEmpty(txtNombreUsuario.Text) ||
                string.IsNullOrEmpty(txtCorreoUsuario.Text) ||
                string.IsNullOrEmpty(txtPasswordUsuario.Text) ||
                string.IsNullOrEmpty(txtPasswordConfirmacion.Text))
            {
                MessageBox.Show("Complete los campos");
                return;
            }
            try
            {
                string nombre = txtNombreUsuario.Text;
                string correo = txtCorreoUsuario.Text;
                string password = txtPasswordUsuario.Text;
                string confirmPassword = txtPasswordConfirmacion.Text;

                if (!VerificarCorreo(correo))
                {
                    MessageBox.Show("Ingrese un correo válido");
                    return;
                }
                else if (password != confirmPassword)
                {
                    MessageBox.Show("Confirme su contraseña");
                    return;
                }
                Cliente cliente = new Cliente(correo, nombre, password);
                clientes.Add(cliente);
                gd.GuardarCliente(clientes);
                ClienteInterfaz clienteInterfaz = new ClienteInterfaz(cliente.correo);
                clienteInterfaz.Show();
            }
            catch (FormatException)
            {
                MessageBox.Show("Verifique que los campos tengan datos válidos");
            }           
        }
    }
}
