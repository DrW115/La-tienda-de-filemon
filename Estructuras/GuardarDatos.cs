using AutomatizaciónDeTiendas.Estructuras;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoFinal2.Estructuras
{
    public class GuardarDatos
    {
        private readonly string dataHandlerPath;

        public GuardarDatos()
        {
            string projectPath = Path.GetFullPath(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\"));
            dataHandlerPath = Path.Combine(projectPath, "DataHandler");

            if (!Directory.Exists(dataHandlerPath))
            {
                Directory.CreateDirectory(dataHandlerPath);
            }
        }


        public void GuardarProducto(List<Producto> productos)
        {
            string filePath = Path.Combine(dataHandlerPath, "productos.bin");
            using (FileStream fs = new FileStream(filePath, FileMode.Create))
            {
                BinaryFormatter bf = new BinaryFormatter();
                bf.Serialize(fs, productos);
            }
        }

        public List<Producto> CargarProductos()
        {
            string filePath = Path.Combine(dataHandlerPath, "productos.bin");
            if (File.Exists(filePath))
            {
                using (FileStream fs = new FileStream(filePath, FileMode.Open))
                {
                    BinaryFormatter bf = new BinaryFormatter();
                    return (List<Producto>)bf.Deserialize(fs);
                }
            }
            return new List<Producto>();
        }

        public void GuardarProveedores(List<Proveedor> proveedores)
        {
            string filePath = Path.Combine(dataHandlerPath, "proveedores.bin");
            using (FileStream fs = new FileStream(filePath, FileMode.Create))
            {
                BinaryFormatter formatter = new BinaryFormatter();
                formatter.Serialize(fs, proveedores);
            }
        }

        public List<Proveedor> CargarProveedores()
        {
            string filePath = Path.Combine(dataHandlerPath, "proveedores.bin");
            if (File.Exists(filePath))
            {
                using (FileStream fs = new FileStream(filePath, FileMode.Open))
                {
                    BinaryFormatter formatter = new BinaryFormatter();
                    return (List<Proveedor>)formatter.Deserialize(fs);
                }
            }
            return new List<Proveedor>();
        }

        public void GuardarCompra(List<Producto> productosComprados)
        {
            string filePath = Path.Combine(dataHandlerPath, "compras.bin");
            using (FileStream fs = new FileStream(filePath, FileMode.Create))
            {
                BinaryFormatter formatter = new BinaryFormatter();
                formatter.Serialize(fs, productosComprados);
            }
        }

        public List<Producto> CargarCompras()
        {
            string filePath = Path.Combine(dataHandlerPath, "compras.bin");
            if (File.Exists(filePath))
            {
                using (FileStream fs = new FileStream(filePath, FileMode.Open))
                {
                    BinaryFormatter formatter = new BinaryFormatter();
                    return (List<Producto>)formatter.Deserialize(fs);
                }
            }
            return new List<Producto>();
        }

        public void GuardarCliente(List<Cliente> cliente)
        {
            string filePath = Path.Combine(dataHandlerPath, "cliente.bin");
            using (FileStream fs = new FileStream(filePath, FileMode.Create))
            {
                BinaryFormatter formatter = new BinaryFormatter();
                formatter.Serialize(fs, cliente);
            }
        }

        public List<Cliente> CargarClientes()
        {
            string filePath = Path.Combine(dataHandlerPath, "cliente.bin");
            if (File.Exists(filePath))
            {
                using (FileStream fs = new FileStream(filePath, FileMode.Open))
                {
                    BinaryFormatter formatter = new BinaryFormatter();
                    return (List<Cliente>)formatter.Deserialize(fs);
                }
            }
            return new List<Cliente>();
        }
    }
}
