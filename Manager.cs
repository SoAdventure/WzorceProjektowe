using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility
{
    class Manager : Employee
    { 
 
        public Manager(string surname)
       
        {
            this.Surname = surname;
        }

        public override void WykonajZadanie(Tasks task)
        {
            //sprawdzenie, czy ten obiekt powinien obsłużyć żądanie
            if (task == Tasks.Print)
            {
                Console.WriteLine("{0} o imieniu {1} obsługuje zadanie: {2}",
                    this.GetType().Name, Surname, task);
            }
            else if (task == Tasks.Other)
            {
                Console.WriteLine("{0} o imieniu {1} obsługuje zadanie: {2}",
                    this.GetType().Name, Surname, task);
            }
            else if (next != null)
            {
                next.WykonajZadanie(task);
            }

        }
    }
}
