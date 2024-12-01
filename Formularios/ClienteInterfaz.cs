using AutomatizaciónDeTiendas.Estructuras;
using ProyectoFinal2.Estructuras;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using Excel = Microsoft.Office.Interop.Excel;


namespace ProyectoFinal2.Formularios
{
    public partial class ClienteInterfaz : Form
    {
        GuardarDatos gd = new GuardarDatos();
        List<Producto> productos = new List<Producto>();
        List<ProductoCarrito> carrito = new List<ProductoCarrito>();
        List<Cliente> clientes = new List<Cliente>();
        private Cliente clienteLogueado;
        public ClienteInterfaz(string correo)
        {
            InitializeComponent();
            ActualizarGridProductos();
            clientes = gd.CargarClientes();
            clienteLogueado = obtenerCliente(correo);
        }

        private void ActualizarGridProductos()
        {
            productos = gd.CargarProductos();
            var productosVista = productos.Select(p => new ProductoVista
            {
                CantStock = p.Stock,
                Nombre = p.Nombre,
                Precio = p.Precio
            }).ToList();

            dgvProductos.DataSource = null;
            dgvProductos.Rows.Clear();
            dgvProductos.DataSource = productosVista;
        }
        private void ActualizarGridCarrito()
        {
            dgvCarrito.DataSource = null;
            dgvCarrito.Rows.Clear();
            dgvCarrito.DataSource = carrito;
        }
        private void btnAgregarCarrito_Click(object sender, EventArgs e)
        {
            if (dgvProductos.SelectedRows.Count > 0)
            {
                DataGridViewRow filaSeleccionada = dgvProductos.SelectedRows[0];
                ProductoVista productoVistaSeleccionado = (ProductoVista)filaSeleccionada.DataBoundItem;
                Producto productoSeleccionado = productos.FirstOrDefault(p => p.Nombre == productoVistaSeleccionado.Nombre);

                if (productoSeleccionado != null)
                {
                    ProductoCarrito productoCarrito = new ProductoCarrito
                    {
                        Nombre = productoSeleccionado.Nombre,
                        Precio = productoSeleccionado.Precio
                    };

                    carrito.Add(productoCarrito);

                    ActualizarGridCarrito();
                }
            }
        }

        private void btnConfirmarCompra_Click(object sender, EventArgs e)
        {
            List<Producto> productosComprados = new List<Producto>();
            if (clienteLogueado != null)
            {
                foreach (var productoCarrito in carrito)
                {
                    Producto productoCompra = productos.FirstOrDefault(p => p.Nombre == productoCarrito.Nombre);
                    if (productoCompra != null)
                    {
                        productosComprados.Add(productoCompra);
                    }
                }

                if (clienteLogueado.productosComprados == null)
                {
                    clienteLogueado.productosComprados = new List<Producto>();
                }

                clienteLogueado.productosComprados.AddRange(productosComprados);


                clientes = gd.CargarClientes();  
                var clienteExistente = clientes.FirstOrDefault(c => c.correo == clienteLogueado.correo);
                if (clienteExistente != null)
                {
                    clienteExistente.productosComprados = clienteLogueado.productosComprados;
                }
                else
                {
                    clientes.Add(clienteLogueado);
                }

                gd.GuardarCliente(clientes);  
                MessageBox.Show("Compra realizada con éxito");
                carrito.Clear();
                ActualizarGridCarrito();
                ExportarAExcel();
            }
            else
            {
                MessageBox.Show("No hay cliente logueado");
            }
        }
        private void ExportarAExcel()
        {
            // Crear un objeto SaveFileDialog para permitir que el usuario elija la ubicación del archivo
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Archivos de Excel (*.xlsx)|*.xlsx|Todos los archivos (*.*)|*.*";
            saveFileDialog.DefaultExt = "xlsx";
            saveFileDialog.AddExtension = true;

            // Mostrar el diálogo y verificar si el usuario ha elegido una ruta
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Obtener la ruta seleccionada por el usuario
                string rutaArchivo = saveFileDialog.FileName;

                // Crear una nueva instancia de Excel
                Excel.Application excelApp = new Excel.Application();
                excelApp.Visible = false; // Puedes ponerlo en 'true' si deseas que Excel se muestre mientras se genera el reporte

                // Crear un libro de trabajo y obtener la primera hoja
                Excel.Workbook workBook = excelApp.Workbooks.Add();
                Excel.Worksheet workSheet = workBook.Sheets[1];

                // Escribir los encabezados de las columnas
                workSheet.Cells[1, 1] = "Nombre";
                workSheet.Cells[1, 2] = "Precio";

                // Escribir los datos de los productos comprados
                int row = 2; // Comienza en la segunda fila
                foreach (var producto in clienteLogueado.productosComprados)
                {
                    workSheet.Cells[row, 1] = producto.Nombre;
                    workSheet.Cells[row, 2] = producto.Precio;
                    row++;
                }

                // Guardar el archivo Excel en la ruta seleccionada por el usuario
                workBook.SaveAs(rutaArchivo);

                // Cerrar el libro y la aplicación de Excel
                workBook.Close(false);
                excelApp.Quit();

                // Liberar recursos de Excel
                System.Runtime.InteropServices.Marshal.ReleaseComObject(excelApp);

                MessageBox.Show($"Reporte exportado exitosamente a {rutaArchivo}");
            }
            else
            {
                MessageBox.Show("La operación fue cancelada. No se guardó el archivo.");
            }
        }
        private Cliente obtenerCliente(string correo)
        {
            return clientes.FirstOrDefault(x => x.correo == correo);
        }
    }
}
