using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoPaginaJuegos.Diseño
{
    internal class Empleado
    {
        private String nombre_emp;
        private String password_emp;
        private String correo_emp;

        public string Nombre_emp { get => nombre_emp; set => nombre_emp = value; }
        public string Password_emp { get => password_emp; set => password_emp = value; }
        public string Correo_emp { get => correo_emp; set => correo_emp = value; }

        public Empleado()
        {
        }

        public Empleado(string nombre_emp, string password_emp, string correo_emp)
        {
            Nombre_emp = nombre_emp;
            Password_emp = password_emp;
            Correo_emp = correo_emp;          
        }
    }
}
