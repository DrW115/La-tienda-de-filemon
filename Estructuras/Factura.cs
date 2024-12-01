using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomatizaciónDeTiendas.Estructuras
{
    public class Factura
    {
        public int FacturaID { get; set; } 
        public DateTime FechaVenta { get; set; }
        public int ClienteID { get; set; } 
        public string MetodoPago { get; set; }
        public decimal TotalVenta { get; set; }
        public Cliente Cliente { get; set; }

        public List<Producto> ProductosComprados { get; set; }

        public Factura()
        {
            ProductosComprados = new List<Producto>();
        }
    }

}
