using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomatizaciónDeTiendas.Estructuras
{
    public class AlertaInventario
    {
        public int AlertaID { get; set; } 
        public int ProductoID { get; set; } 
        public int CantidadActual { get; set; }
        public DateTime FechaAlerta { get; set; }
        public Producto Producto { get; set; }
    }

}
