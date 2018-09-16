using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRINCIPIO_SRP
{
    class Program
    {
        private static void Main(string[] args)
        {
            var rectangulos = new[]
{
    new EJERCICIO.Ejercicio1 {Width = 10, Height = 5},
    new EJERCICIO.Ejercicio1 {Width = 4, Height = 6},
    new EJERCICIO.Ejercicio1 {Width = 5, Height = 1},
    new EJERCICIO.Ejercicio1 {Width = 8, Height = 9}
};

            var sumaDeAreas = EJERCICIO.Ejercicio1.SumAreas(rectangulos);
            var sumaDePerimetros = EJERCICIO.Ejercicio1.SumPerimeters(rectangulos);

            Console.WriteLine($"AREA TOTAL: {sumaDeAreas}" + 
                                $"PERIMETRO TOTAL: {sumaDePerimetros}");
            Console.ReadKey();
            
        }
    }
}
