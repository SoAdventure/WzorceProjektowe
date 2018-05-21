using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositePattern
{
    class Student : Students
    {
        private string Imie, Nazwisko, Promile;

        public Student(string imie, string nazwisko, string promile)
        {
            Imie = imie;
            Nazwisko = nazwisko;
            Promile = promile;
        }

        public void AboutStudent()  
        {
            Console.WriteLine("Studenci: " + Imie + " " + Nazwisko );
        }
    }
}