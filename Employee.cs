using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility
{
    abstract class Employee
    {
         
        
            public string Surname { get; set; }

            
            protected Employee next;

            
            
            public void UstawKolejnego(Employee employee)
            {
                next = employee;
            }

          
            public abstract void WykonajZadanie(Tasks task);
        
    }
}
