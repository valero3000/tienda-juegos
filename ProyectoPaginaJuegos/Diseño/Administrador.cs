using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoPaginaJuegos.Diseño
{
    internal class Administrador
    {
        private String administrador_correo;
        private String administrador_nombre;
        private String administrador_password;

        public string Administrador_correo { get => administrador_correo; set => administrador_correo = value; }
        public string Administrador_nombre { get => administrador_nombre; set => administrador_nombre = value; }
        public string Administrador_password { get => administrador_password; set => administrador_password = value; }

        public Administrador()
        {
        }

        public Administrador(string administrador_correo, string administrador_nombre, string administrador_password)
        {
            Administrador_correo = administrador_correo;
            Administrador_nombre = administrador_nombre;
            Administrador_password = administrador_password;
            
        }
    } 
}
