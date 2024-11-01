using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelos
{
    public class Cliente
    {
        public int idCliente { get; set; }
        public string cuit { get; set; }
        public string nombre { get; set; }
        public int iva { get; set; }

        public Cliente() { }

        public Cliente(int idCliente, string cuit, string nombre, int iva) {
            this.idCliente = idCliente;
            this.cuit = cuit;
            this.nombre = nombre;
            this.iva = iva;
        
        }
    }
}
