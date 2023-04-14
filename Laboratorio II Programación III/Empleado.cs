using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio_II_Programación_III
{
    public class Empleado
    {
        public string Nombre { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }

        public Empleado(string nombre, string username, string password)
        {
            Nombre = nombre;
            Username = username;
            Password = password;
        }

        public static Empleado GetEmpleado(string username, string password)
        {
            foreach (Empleado empleado in Empleados)
            {
                if (empleado.Username == username && empleado.Password == password)
                {
                    return empleado;
                }
            }

            return null;
        }

        public static bool ExisteEmpleado(string username, string password)
        {
            foreach (Empleado empleado in Empleados)
            {
                if (empleado.Username == username && empleado.Password == password)
                {
                    return true;
                }
            }

            return false;
        }

        private static List<Empleado> Empleados = new List<Empleado>();

        public static void AgregarEmpleado(Empleado empleado)
        {
            Empleados.Add(empleado);
        }

        public void AgregarArea(string nombreArea)
        {
            Area nuevaArea = new Area(nombreArea);

            Supermercado.AgregarArea(nuevaArea);
        }

        public void AgregarCategoria(string nombreCategoria)
        {
            Categoria nuevaCategoria = new Categoria(nombreCategoria);


            Supermercado.AgregarCategoria(nuevaCategoria);
        }

    }

}
