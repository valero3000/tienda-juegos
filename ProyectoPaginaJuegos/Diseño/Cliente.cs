using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prueba.Diseño
{
    internal class Cliente
    {
        private String cliente_run;
        private String cliente_nombre;
        private String cliente_password;
        private String cliente_email;
        private int id_cliente;
        private UInt32 cliente_numcelular;

        public string Cliente_run { get => cliente_run; set => cliente_run = value; }
        public string Cliente_nombre { get => cliente_nombre; set => cliente_nombre = value; }
        public string Cliente_password { get => cliente_password; set => cliente_password = value; }
        public string Cliente_email { get => cliente_email; set => cliente_email = value; }
        public int Id_cliente { get => id_cliente; set => id_cliente = value; }
        public uint Cliente_numcelular { get => cliente_numcelular; set => cliente_numcelular = value; }

        public Cliente()
        {
        }

        public Cliente(string cliente_run, string cliente_nombre, string cliente_password, string cliente_email, int id_cliente, uint cliente_numcelular)
        {
            Cliente_run = cliente_run;
            Cliente_nombre = cliente_nombre;
            Cliente_password = cliente_password;
            Cliente_email = cliente_email;
            Id_cliente = id_cliente;
            Cliente_numcelular = cliente_numcelular;          
        }
    }

}
