using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatosComp
{
    public class Proveedor
    {
        private int kidProveedor;
        private string nombre;
        private string telefono;
        private string direccion;
        private string pagina;
        private int estado;

        public int KidProveedor { get; set; }

        public string Nombre { get; set; }

        public string Telefono { get; set; }

        public string Direccion { get; set; }
        public string Pagina { get; set; }
        public int Estado { get; set; }

    }
}
