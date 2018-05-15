using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility
{
    class Photographer : Employee
    {
        public Photographer (string surname)
        {
            this.Surname = surname;
        }

        public override void WykonajZadanie(Tasks task)
        {
            
            if (task == Tasks.Photo)
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
