using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaginaTiendaJuego.Diseño
{
    internal class Usuarios
    {
        private String nombre_usuarios;
        private String password_usuarios;
        private String correo_usuarios;

        public string Nombre_usuarios { get => nombre_usuarios; set => nombre_usuarios = value; }
        public string Password_usuarios { get => password_usuarios; set => password_usuarios = value; }
        public string Correo_usuarios { get => correo_usuarios; set => correo_usuarios = value; }

        public Usuarios()
        {
        }

        public Usuarios(string nombre_usuarios, string password_usuarios, string correo_usuarios)
        {
            Nombre_usuarios = nombre_usuarios;
            Password_usuarios = password_usuarios;
            Correo_usuarios = correo_usuarios;
        }
    }
}
