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
using System.Collections;


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
                    int cantidadADesear = 1; 
                    var productoEnCarrito = carrito.FirstOrDefault(p => p.Nombre == productoSeleccionado.Nombre);

                    if (productoEnCarrito != null)
                    {
                        if (productoSeleccionado.Stock >= productoEnCarrito.Cantidad + cantidadADesear)
                        {
                            productoEnCarrito.Cantidad += cantidadADesear;
                        }
                        else
                        {
                            MessageBox.Show($"No hay suficiente stock disponible para agregar más de {productoSeleccionado.Stock} unidades.");
                        }
                    }
                    else
                    {
                        if (productoSeleccionado.Stock >= cantidadADesear)
                        {
                            ProductoCarrito nuevoProductoCarrito = new ProductoCarrito
                            {
                                Nombre = productoSeleccionado.Nombre,
                                Precio = productoSeleccionado.Precio,
                                Cantidad = cantidadADesear
                            };
                            carrito.Add(nuevoProductoCarrito);
                        }
                        else
                        {
                            MessageBox.Show("No hay suficiente stock para este producto.");
                        }
                    }

                    ActualizarGridCarrito();
                }
            }
        }


        private void btnConfirmarCompra_Click(object sender, EventArgs e)
        {
            if (clienteLogueado != null)
            {
                List<Producto> productosComprados = new List<Producto>();
                foreach (var productoCarrito in carrito)
                {
                    Producto productoCompra = productos.FirstOrDefault(p => p.Nombre == productoCarrito.Nombre);
                    if (productoCompra != null && productoCompra.Stock >= productoCarrito.Cantidad)
                    {
                        productoCompra.Stock -= productoCarrito.Cantidad; 
                        Producto productoComprado = new Producto(
                            Id: productoCompra.Id,
                            Nombre: productoCompra.Nombre,
                            Stock: productoCarrito.Cantidad, 
                            Precio: productoCompra.Precio,
                            Proveedor: productoCompra.ProveedorId
                        );
                        productosComprados.Add( productoComprado);
                    }
                    else
                    {
                        MessageBox.Show($"No hay suficiente stock para el producto: {productoCarrito.Nombre}");
                        return;
                    }
                }

                if (clienteLogueado.productosComprados == null)
                {
                    clienteLogueado.productosComprados = new List<Producto>();
                }
                clienteLogueado.productosComprados.AddRange(productosComprados);

                gd.GuardarCliente(clientes);
                gd.GuardarProducto(productos);

                MessageBox.Show("Compra realizada con éxito");
                carrito.Clear();
                ActualizarGridCarrito();
                ActualizarGridProductos();

                if (chkReporte.Checked)
                {
                    ExportarAExcel();
                }
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

        private void tbpProductos_Click(object sender, EventArgs e)
        {

        }
    }
}
