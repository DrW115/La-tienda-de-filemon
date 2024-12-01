using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomatizaciónDeTiendas.Estructuras
{
    [Serializable]
    public class Producto
    {
        public int Id { get; set; } 
        public string Nombre { get; set; }
        public int Stock { get; set; }
        public decimal Precio { get; set; }
        public int NivelStockMinimo { get; set; }
        public int ProveedorId { get; set; }

        public Producto(int Id, string Nombre, int Stock, decimal Precio, int Proveedor)
        {
            this.Id = Id;
            this.Nombre = Nombre;
            this.Stock = Stock;
            this.Precio = Precio;
            this.ProveedorId = Proveedor;
        }       
    } 
    public class ProductoVista
    {
        public int CantStock { get; set; }
        public string Nombre { get; set; }
        public decimal Precio { get; set; }
    }
    public class ProductoCarrito
    {
        public string Nombre { get; set; }
        public decimal Precio { set; get; }
    }
}
