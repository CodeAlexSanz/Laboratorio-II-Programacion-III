using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio_II_Programación_III
{
    public class Administrador
    {
        public string Username { get; set; }
        public string Password { get; set; }

        public Administrador(string username, string password)
        {
            Username = username;
            Password = password;
        }

        public Empleado CrearEmpleado(string nombre, string username, string password)
        {
            return new Empleado(nombre, username, password);
        }
    }
}
