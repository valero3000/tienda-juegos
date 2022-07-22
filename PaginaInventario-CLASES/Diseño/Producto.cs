using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaginaTiendaJuego.Diseño
{
    internal class Producto
    {
        private String precio_pro;
        private String id_pro;
        private String nombre_pro;

        public string Precio_pro { get => precio_pro; set => precio_pro = value; }
        public string Id_pro { get => id_pro; set => id_pro = value; }
        public string Nombre_pro { get => nombre_pro; set => nombre_pro = value; }

        public Producto()
        {
        }

        public Producto(string precio_pro, string id_pro, string nombre_pro)
        {
            Precio_pro = precio_pro;
            Id_pro = id_pro;
            Nombre_pro = nombre_pro;
        }
    }
}
