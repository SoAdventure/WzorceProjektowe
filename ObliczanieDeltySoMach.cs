using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace facade
{
    class ObliczanieDeltySoMach
    {
        public void DeltaDod(double a, double b, double c)
        {
            double delta = b * b - 4.0 * a * c;
            Console.WriteLine("Pierwszy pierwiastek: {0}", (-b - delta) / (2 * a));
            Console.WriteLine("Drugi pierwiastek: {0}", (-b + delta) / (2 * a));
        }

        public void DeltaZerowa(double a, double b, double c)
        {
            Console.WriteLine("Pierwiastek: {0}", (-b) / (2 * a));
        }

        public void DeltaUj(double a, double b, double c)
        {
            Console.WriteLine("Brak pierwiastków wielomianu kwadratowego");
        }
    }
}
