using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio_II_Programación_III
{
    public class Supermercado
    {
        public List<Area> Areas { get; set; }
        public List<Categoria> Categorias { get; set; }

        public Supermercado()
        {
            Areas = new List<Area>();
            Categorias = new List<Categoria>();
        }

        public void AgregarArea(string nombre)
        {
            Areas.Add(new Area(nombre));
            Console.WriteLine($"Área '{nombre}' agregada con éxito");
        }

        public void AgregarCategoria(string nombre)
        {
            Categorias.Add(new Categoria(nombre));
            Console.WriteLine($"Categoría '{nombre}' agregada con éxito");
        }
    }

}
