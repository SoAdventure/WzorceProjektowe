using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositePattern
{
    class Seba : Students
    {

        private string Imie, Nazwisko, Promile;
        private List<Students> students = new List<Students>();

        public Seba(string imie, string nazwisko, string promile)
        {
            Imie = imie;
            Nazwisko = nazwisko;
            Promile = promile;
        }

        public void DodajStudenta(Students student)
        {
            students.Add(student);
        }

        public void AboutStudent()
        {
            Console.WriteLine("Studenci: " + Imie + " " + Promile);
            foreach (Students student in students)
            {
                student.AboutStudent();
            }
        }
    }
}