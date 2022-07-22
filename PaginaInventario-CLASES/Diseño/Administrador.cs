using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaginaTiendaJuego.Diseño
{
    internal class Administrador
    {
        private String Administrador_correo;
        private String Administrador_nombre;
        private String Administrador_password;

        public string administrador_correo { get => Administrador_correo; set => Administrador_correo = value; }
        public string administrador_nombre { get => Administrador_nombre; set => Administrador_nombre = value; }
        public string administrador_password { get => Administrador_password; set => Administrador_password = value; }

        public Administrador()
        {
        }

        public Administrador(string Administrador_correo, string Administrador_nombre, string Administrador_password)
        {
            Administrador_correo = Administrador_correo;
            Administrador_nombre = Administrador_nombre;
            Administrador_password = Administrador_password;
        }
    }
}