using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositePattern
{
    class Program
    {
     
       static void Main(string[] args)
        {
            Seba seba= new Seba("Krzysiu", "Mazak", "0,5");
            seba.DodajStudenta(new Student("Adam", "Nizio", "3,5"));
            seba.DodajStudenta(new Student("Tomasz", "Problem", "3,14"));
            seba.AboutStudent();
            Console.ReadKey();
        }
    }
}