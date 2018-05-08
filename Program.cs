using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace facade
{
    class Program
    {
        static void Main(string[] args)
        {
            Fasada ob = new Fasada();

            int x, y, z;

            Console.WriteLine("Podaj stałe wielomianu:");
            Console.Write("a = ");
            x = int.Parse(Console.ReadLine());
            Console.Write("b = ");
            y = int.Parse(Console.ReadLine());
            Console.Write("c = ");
            z = int.Parse(Console.ReadLine());
            ob.ObliczPierWieomianu(x, y, z);
           
        }
    }
}
