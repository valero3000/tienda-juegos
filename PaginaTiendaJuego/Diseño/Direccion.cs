using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaginaTiendaJuego.Diseño
{
    internal class Direccion
    {
        private String nombredireccion;
        private String numerodomicilio;

        public string Nombredireccion { get => nombredireccion; set => nombredireccion = value; }
        public string Numerodomicilio { get => numerodomicilio; set => numerodomicilio = value; }

        public Direccion()
        {
        }

        public Direccion(string nombredireccion, string numerodomicilio)
        {
            Nombredireccion = nombredireccion;
            Numerodomicilio = numerodomicilio;
        }
    }
}
