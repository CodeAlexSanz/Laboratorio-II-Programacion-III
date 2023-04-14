using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio_II_Programación_III
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bienvenido a la aplicación");

            // Creamos un administrador por defecto
            Administrador admin = new Administrador("admin", "admin");

            // Login
            bool loginCorrecto = false;

            do
            {
                Console.WriteLine("Por favor, ingrese sus credenciales:");

                Console.Write("Username: ");
                string username = Console.ReadLine();

                Console.Write("Password: ");
                string password = Console.ReadLine();

                if (admin.Username == username && admin.Password == password)
                {
                    Console.WriteLine("Bienvenido, administrador");
                    loginCorrecto = true;
                }
                else if (Empleado.ExisteEmpleado(username, password))
                {
                    Empleado empleado = Empleado.GetEmpleado(username, password);
                    Console.WriteLine($"Bienvenido, {empleado.Nombre}");
                    loginCorrecto = true;

                    Console.WriteLine($"Bienvenido, {empleado.Nombre}");

                    // Agregar nueva área
                    Console.WriteLine("Agregando nueva área...");

                    Console.Write("Ingrese el nombre del área: ");
                    string nombreArea = Console.ReadLine();

                    empleado.AgregarArea(nombreArea);

                    Console.WriteLine("Área creada con éxito");

                    // Agregar nueva categoría
                    Console.WriteLine("Agregando nueva categoría...");

                    Console.Write("Ingrese el nombre de la categoría: ");
                    string nombreCategoria = Console.ReadLine();

                    empleado.AgregarCategoria(nombreCategoria);

                    Console.WriteLine("Categoría creada con éxito");
                }
                else
                {
                    Console.WriteLine("Credenciales incorrectas, intente nuevamente");
                }

            } while (!loginCorrecto);

            Console.WriteLine("¿Qué desea hacer?");

            // Menú de opciones
            bool salir = false;

            do
            {
                Console.WriteLine("1. Crear empleado");
                Console.WriteLine("3. Salir");

                string opcion = Console.ReadLine();

                switch (opcion)
                {
                    case "1":
                        Console.Write("Ingrese el nombre del empleado: ");
                        string nombre = Console.ReadLine();

                        Console.Write("Ingrese el username del empleado: ");
                        string username = Console.ReadLine();

                        Console.Write("Ingrese el password del empleado: ");
                        string password = Console.ReadLine();

                        Empleado empleado = admin.CrearEmpleado(nombre, username, password);

                        Console.WriteLine($"Empleado creado con éxito: {empleado.Nombre}");
                        break;

                    case "2":
                        Console.WriteLine("Adiós");
                        salir = true;
                        break;

                    default:
                        Console.WriteLine("Opción no válida");
                        break;
                }

            } while (!salir);

            Console.ReadLine();
        }
    }
}
