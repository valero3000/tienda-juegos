using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prueba.Diseño
{
    internal class Boleta
    {
        private String id;
        private String id_pro;
        private String id_cliente;

        public string Id { get => id; set => id = value; }
        public string Id_pro { get => id_pro; set => id_pro = value; }
        public string Id_cliente { get => id_cliente; set => id_cliente = value; }

        public Boleta()
        {
        }

        public Boleta(string id, string id_pro, string id_cliente)
        {
            Id = id;
            Id_pro = id_pro;
            Id_cliente = id_cliente;
        }
    }
}
