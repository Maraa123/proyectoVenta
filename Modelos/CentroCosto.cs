using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelos
{
    public class CentroCosto
    {
        public int idCentro { get; set; }
        public string descripcion { get; set; }
        public int provincia { get; set; } // crear Enum con provincias 
        public CentroCosto() { }

        public CentroCosto(int idCentro, string descripcion, int provincia)
        {
            this.idCentro = idCentro;
            this.descripcion = descripcion;
            this.provincia = provincia;
        }
    }
}
