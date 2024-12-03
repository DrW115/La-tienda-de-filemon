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
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using ProyectoFinal2.Estructuras;
using System.Net.Mail;

namespace ProyectoFinal2.Formularios
{
    public partial class InterfazOperador : Form
    {
        List<Proveedor> proveedores = new List<Proveedor>();
        List<Producto> productos = new List<Producto>();
        GuardarDatos gd = new GuardarDatos();
        List<Cliente> clientes = new List<Cliente>();
        List<Producto> productosComprados = new List<Producto>();
        public InterfazOperador()
        {
            InitializeComponent();
            proveedores = gd.CargarProveedores();
            productos = gd.CargarProductos();
            clientes = gd.CargarClientes();
            productosComprados = gd.CargarCompras();
            ActualizarGridProductos();
            ActualizarGridProveedores();
        }
        private void ActualizarGridProveedores()
        {
            dgvProveedores.DataSource = null;
            dgvProveedores.Rows.Clear();
            dgvProveedores.DataSource = proveedores;
        }

        private void LimpiarCampos()
        {
            txtPrecio.Clear();
            txtNombreProducto.Clear();
            txtCantInicial.Clear();
            txtProductoId.Clear();
        }
        private void btnVaciarCampos_Click(object sender, EventArgs e)
        {
            txtProveedorId.Clear();
            txtNombreProveedor.Clear();
            txtCorreoProveedor.Clear();
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
        private void txtProveedorId_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtProveedorId.Text))
            {
                lstProductos.Items.Clear();
                return;
            }
            try
            {
                int id = Convert.ToInt32(txtProveedorId.Text);
                var productosExistente = productos.Where(x => x.ProveedorId == id);
                lstProductos.Items.Clear();

                if (productosExistente.Any())
                {
                    foreach (var item in productosExistente)
                    {
                        lstProductos.Items.Add(item.Nombre);
                    }
                }
            }
            catch (FormatException)
            {
                lstProductos.Items.Clear();
            }
        }

        private void btnAgregarProveedor_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNombreProveedor.Text) ||
                string.IsNullOrEmpty(txtProveedorId.Text) ||
                string.IsNullOrEmpty(txtCorreoProveedor.Text))
            {
                MessageBox.Show("Por favor llene todos los campos");
                return;
            }

            int id = Convert.ToInt32(txtProveedorId.Text);
            Proveedor proveedorExistente = proveedores.Find(x => x.Id == id);

            if(proveedorExistente != null)
            {
                MessageBox.Show("El ID ingresado ya existe");
                return;
            }
            try
            {
                string nombreProveedor = txtNombreProveedor.Text;
                int proveedorId = Convert.ToInt32(txtProveedorId.Text);
                string correo = txtCorreoProveedor.Text;

                if (!VerificarCorreo(correo))
                {
                    MessageBox.Show("Ingrese un correo válido");
                    return;
                }

                Proveedor proveedor = new Proveedor(proveedorId, nombreProveedor, correo);
                proveedores.Add(proveedor);
                gd.GuardarProveedores(proveedores);
                gd.GuardarProducto(productos);
                ActualizarGridProveedores();
                ActualizarGridProductos();
            }
            catch (FormatException)
            {
                MessageBox.Show("Verifique que los campos tengan valores válidos");
            }
        }
        private void btnAgregarProducto_Click(object sender, EventArgs e)
        {


            if (string.IsNullOrEmpty(txtNombreProducto.Text) ||
                string.IsNullOrEmpty(txtProductoId.Text) ||
                string.IsNullOrEmpty(txtPrecio.Text) ||
                string.IsNullOrEmpty(txtCantInicial.Text))
            {
                MessageBox.Show("Por favor llene todos los campos");
                return;
            }
            try
            {
                string nombreProducto = txtNombreProducto.Text;
                int productoId = Convert.ToInt32(txtProductoId.Text);
                decimal precio = Convert.ToDecimal(txtPrecio.Text);
                int cantInicial = Convert.ToInt32(txtCantInicial.Text);

                Proveedor proveedorExistente = proveedores.Find(x => x.Id == Convert.ToInt32(txtProveedorId.Text));
                if (proveedorExistente != null)
                {
                    Producto producto = new Producto(productoId, nombreProducto, cantInicial, precio, proveedorExistente.Id);
                    productos.Add(producto);
                    lstProductos.Items.Add(producto.Nombre.ToString());
                    ActualizarGridProductos();
                    gd.GuardarProveedores(proveedores);
                    gd.GuardarProducto(productos);
                    LimpiarCampos();
                }
                else if (string.IsNullOrEmpty(txtProveedorId.Text) || proveedorExistente == null)
                {
                    MessageBox.Show("Verifique que el ID del proveedor sea el correcto");
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Verifique que los campos tengan valores válidos");
            }
        }


        private void btnActualizar_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtProveedorId.Text);

            Proveedor proveedorExistente = proveedores.Find(x => x.Id == id);

            if (proveedorExistente != null)
            {
                proveedorExistente.Nombre = !string.IsNullOrEmpty(txtNombreProveedor.Text) ? txtNombreProveedor.Text : proveedorExistente.Nombre;
                proveedorExistente.Correo = !string.IsNullOrEmpty(txtCorreoProveedor.Text) ? txtCorreoProveedor.Text : proveedorExistente.Correo;

                gd.GuardarProveedores(proveedores);
                gd.GuardarProducto(productos);
                ActualizarGridProveedores();
                LimpiarCampos();
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int id = int.TryParse(txtProveedorId.Text, out id) ? id : Convert.ToInt32(dgvProveedores.SelectedRows[0].Cells[0].Value);

            Proveedor proveedorExistente = proveedores.Find(x => x.Id == id);

            if (proveedorExistente != null)
            {
                proveedores.Remove(proveedorExistente);
                productos.RemoveAll(p => p.ProveedorId == id);
                gd.GuardarProveedores(proveedores);
                gd.GuardarProducto(productos);
                ActualizarGridProveedores();
                ActualizarGridProductos();
                LimpiarCampos();
            }
        }
        

        private void ActualizarGridProductos()
        {
            dgvProductos.DataSource = null;
            dgvProductos.Rows.Clear();
            dgvProductos.DataSource = productos;
        }

        private void btnActualizarProducto_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtIdProductoActualizar.Text))
            {
                MessageBox.Show("Ingrese el Id de un producto válido");
            }
            try
            {
                int id = Convert.ToInt32(txtIdProductoActualizar.Text);
         
                Producto productoExistente = productos.Find(x => x.Id == id);

                if (productoExistente != null)
                {
                    productoExistente.Nombre = !string.IsNullOrEmpty(txtNuevoNombre.Text) ? txtNuevoNombre.Text : productoExistente.Nombre;
                    productoExistente.Precio = decimal.TryParse(txtNuevoPrecio.Text, out decimal nuevoPrecio) ? nuevoPrecio : productoExistente.Precio;
                    productoExistente.Stock = int.TryParse(txtNuevaCant.Text, out int stock) ? stock : productoExistente.Stock;

                    gd.GuardarProveedores(proveedores);
                    gd.GuardarProducto(productos);
                    ActualizarGridProductos();
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Verifique que los campos tengan valores válidos");
            }
        }

        private void txtIdProductoActualizar_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtIdProductoActualizar.Text))
            {
                txtNuevaCant.Clear();
                return;
            }

            try
            {
                int id = Convert.ToInt32(txtIdProductoActualizar.Text);

                Producto productoExistente = productos.Find(x => x.Id == id);

                if (productoExistente != null)
                {
                    txtNuevaCant.Text = productoExistente.Stock.ToString();
                }
                else
                {
                    txtNuevaCant.Clear();
                }
            }
            catch (FormatException)
            {
                txtNuevaCant.Clear();
            }
        }

        private void btnSuma_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtIdProductoActualizar.Text))
            {
                MessageBox.Show("Ingrese el ID de un producto válido");
            }
            try
            {
                int id = Convert.ToInt32(txtIdProductoActualizar.Text);

                Producto productoExistente = productos.Find(x => x.Id == id);

                if (productoExistente != null)
                {
                    int nuevaCant = Convert.ToInt32(txtNuevaCant.Text);
                    nuevaCant += 1;
                    txtNuevaCant.Text = nuevaCant.ToString();
                }
                else
                {
                    MessageBox.Show("Ingrese el ID de un producto válido");
                    txtNuevaCant.Clear();
                }
            }
            catch (FormatException)
            {
                txtNuevaCant.Clear();
            }
        }

        private void btnResta_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtIdProductoActualizar.Text))
            {
                MessageBox.Show("Ingrese el ID de un producto válido");
            }
            try
            {
                int id = Convert.ToInt32(txtIdProductoActualizar.Text);

                Producto productoExistente = productos.Find(x => x.Id == id);

                if (productoExistente != null)
                {
                    int nuevaCant = Convert.ToInt32(txtNuevaCant.Text);
                    nuevaCant -= 1;
                    txtNuevaCant.Text = nuevaCant.ToString();
                }
                else
                {
                    MessageBox.Show("Ingrese el ID de un producto válido");
                    txtNuevaCant.Clear();
                }
            }
            catch (FormatException)
            {
                txtNuevaCant.Clear();
            }
        }

        private void btnActualizarProducto_Click_1(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtIdProductoActualizar.Text);

            Producto productoEncontrado = productos.Find(x => x.Id == id);

            if (productoEncontrado != null)
            {
                productoEncontrado.Nombre = txtNuevoNombre.Text;
                productoEncontrado.Precio = Convert.ToDecimal(txtNuevoPrecio.Text);
                productoEncontrado.Stock = Convert.ToInt32(txtNuevaCant.Text);

                gd.GuardarProveedores(proveedores);
                gd.GuardarProducto(productos);
                ActualizarGridProductos();
            }
            else
            {
                MessageBox.Show("Ingrese el ID de un producto válido");
            }
        }

        private void dgvProductos_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if(e.Button == MouseButtons.Right && e.RowIndex >= 0)
            {
                dgvProductos.ClearSelection();
                dgvProductos.Rows[e.RowIndex].Selected = true;
                dgvProductos.CurrentCell = dgvProductos.Rows[e.RowIndex].Cells[e.ColumnIndex];
                cmsOperadores.Show(Cursor.Position);
            }
        }

        private void dgvProveedores_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right && e.RowIndex >= 0)
            {
                dgvProveedores.ClearSelection();
                dgvProveedores.Rows[e.RowIndex].Selected = true;
                dgvProveedores.CurrentCell = dgvProveedores.Rows[e.RowIndex].Cells[e.ColumnIndex];
                cmsOperadores.Show(Cursor.Position);
            }
            else
            {
                cmsOperadores.Hide();
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string correo = txtCorreoCliente.Text;  

            Cliente clienteEncontrado = clientes.FirstOrDefault(c => c.correo == correo);

            if (clienteEncontrado != null && clienteEncontrado.productosComprados != null)
            {
                productosComprados = clienteEncontrado.productosComprados;

                GraficarProductosComprados(correo);
            }
            else
            {
                MessageBox.Show("No se encontraron productos comprados para este cliente.");
            }

        }
        private void GraficarProductosComprados(string correo)
        {
            Cliente cliente = clientes.FirstOrDefault(c => c.correo == correo);

            if (cliente == null)
            {
                MessageBox.Show("No se encontró un cliente con ese correo.", "Error");
                return;
            }

            if (cliente.productosComprados == null || cliente.productosComprados.Count == 0)
            {
                MessageBox.Show("Este cliente no tiene productos comprados registrados.", "Información");
                return;
            }

            var datosGrafico = cliente.productosComprados
                .GroupBy(p => p.Nombre)
                .Select(g => new
                {
                    NombreProducto = g.Key,
                    Cantidad = g.Sum(p => p.Stock)
                })
                .ToList();

            chartProductosComprados.Series.Clear();
            var serie = new System.Windows.Forms.DataVisualization.Charting.Series("Productos Comprados")
            {
                ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column
            };

            foreach (var dato in datosGrafico)
            {
                serie.Points.AddXY(dato.NombreProducto, dato.Cantidad);
            }

            chartProductosComprados.Series.Add(serie);
            chartProductosComprados.ChartAreas[0].AxisX.Title = "Productos";
            chartProductosComprados.ChartAreas[0].AxisY.Title = "Cantidad Comprada";
            chartProductosComprados.ChartAreas[0].RecalculateAxesScale();
        }

        private void btnEliminarProducto_Click(object sender, EventArgs e)
        {
            if (dgvProductos.SelectedRows.Count > 0)
            {
                DataGridViewRow filaSeleccionada = dgvProductos.SelectedRows[0];
                Producto productoCarritoSeleccionado = (Producto)filaSeleccionada.DataBoundItem;
                Producto productoSeleccionado = productos.FirstOrDefault(p => p.Nombre == productoCarritoSeleccionado.Nombre);

                if (productoSeleccionado != null)
                {
                    productos.Remove(productoSeleccionado);
                    ActualizarGridProductos();
                    gd.GuardarProducto(productos);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
           Application.Exit();
        }

        private void btnActualizarProducto_Click_2(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
