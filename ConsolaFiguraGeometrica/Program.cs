using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsolaFiguraGeometrica.Interface;
using ConsolaFiguraGeometrica.Modelo;

namespace ConsolaFiguraGeometrica
{
    class Program
    {
        static void Main(string[] args)
        {
            var triangulo = new Triangulo(5, 5);
            mostrarInformacion(triangulo);
            Console.ReadKey();
        }

        static void mostrarInformacion(IFiguraGeometrica figura)
        {
            Console.WriteLine($"Nombre : {figura.ObtenerNombre()}");
            Console.WriteLine($"Area : {figura.CalcularArea()}");
            Console.WriteLine($"Perimetro : {figura.CalcularPerimetro()}");
        }
    }
}
