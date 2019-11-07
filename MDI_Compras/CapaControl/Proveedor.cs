using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaControl
{
    class Proveedor
    {
        private int kidProveedor;
        private string nombre;
        private int telefono;
        private string direccion;
        private string pagina;
        private int estado;

        public int KidProveedor
        {
            set
            {
                kidProveedor = value;
            }
            get
            {
                return kidProveedor;
            }
        }

        public string Nombre
        {
            set
            {
                nombre = value;
            }
            get
            {
                return nombre;
            }
        }

        public int Telefono
        {
            set
            {
                telefono = value;
            }
            get
            {
                return telefono;
            }
        }

        public string Direccion
        {
            set
            {
                direccion = value;
            }
            get
            {
                return direccion;
            }
        }

        public string Pagina
        {
            set
            {
                pagina = value;
            }
            get
            {
                return pagina;
            }
        }

        public int Estado
        {
            set
            {
               estado = value;
            }
            get
            {
                return estado;
            }
        }
    }
}
