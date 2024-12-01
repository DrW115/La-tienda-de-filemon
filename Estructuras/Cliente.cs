using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomatizaciónDeTiendas.Estructuras
{
    [Serializable]
    public class Cliente
    {
        public string correo { get; set; } 
        public string NombreDeUsuario { get; set; }
        public string Password { get; set; }
        public List<Producto> productosComprados { get; set; }


        public Cliente(string correo, string NombreDeUsuario, string Password)
        {
            this.NombreDeUsuario = NombreDeUsuario;
            this.Password = Password;
            this.correo = correo;
            this.productosComprados = new List<Producto>();
        }
        public void agregarProducto(Producto producto)
        {
            productosComprados.Add(producto);
        }
    }
}
