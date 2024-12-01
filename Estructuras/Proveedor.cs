using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomatizaciónDeTiendas.Estructuras
{
    [Serializable]
    public class Proveedor
    {
        public int Id { get; set; } 
        public string Nombre { get; set; }
        public string Correo { get; set; }
        public List<Producto> Productos { get; set; }
        public Proveedor(int ProveedorId, string NombreProveedor, string ContactoProveedor)
        {
            this.Id = ProveedorId;
            this.Nombre = NombreProveedor;
            this.Correo = ContactoProveedor;
            Productos = new List<Producto>();
        }
    }
}
