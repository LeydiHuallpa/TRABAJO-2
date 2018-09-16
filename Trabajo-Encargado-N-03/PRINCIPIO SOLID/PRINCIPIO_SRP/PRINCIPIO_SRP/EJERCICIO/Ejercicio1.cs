using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRINCIPIO_SRP.EJERCICIO
{
    public class Ejercicio1
    {
        public double Sides { get; } = 4;
        public double Height { get; set; }
        public double Width { get; set; }

        //public class AreaOperations
        //{
        //    internal static object SumAreas(IEnumerable<Ejercicio1> rectangulos)
        //    {
        //        double area = 0;
        //        foreach (var rectangle in rectangulos)
        //            area += rectangle.Height * rectangle.Width;
        //        return area;
        //    }
        //}

        internal static object SumAreas(Ejercicio1[] rectangulos)
        {
            double area = 0;
            foreach (var rectangle in rectangulos)
                area += rectangle.Height * rectangle.Width;
            return area;
        }

        internal static object SumPerimeters(Ejercicio1[] rectangulos)
        {
            double perimeter = 0;
            foreach (var rectangle in rectangulos)
                perimeter += 2 * rectangle.Height + 2 * rectangle.Width;
            return perimeter;
        }

        //public class PerimeterOperations
        //{
        //    public double SumPerimeters(IEnumerable<Ejercicio1> rectangulos)
        //    {
        //        double perimeter = 0;
        //        foreach (var rectangle in rectangulos)
        //            perimeter += 2 * rectangle.Height + 2 * rectangle.Width;
        //        return perimeter;
        //  }
        //}
    }
}
