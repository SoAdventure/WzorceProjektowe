using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility
{
    class Program
    {
        static void Main(string[] args)
        {


            Employee menagerBruceLee = new Manager("Bruce Lee");
            Employee photographer = new Photographer("Chuck Norris");
            Employee videomaker = new Videomaker("Maciek z Klanu");


            menagerBruceLee.UstawKolejnego(photographer);
            photographer.UstawKolejnego(videomaker);


            List<Tasks> zadaniaNaDzis = new List<Tasks> {
                Tasks.Video,
                Tasks.Print,
                Tasks.Photo,
                Tasks.Other
            };


            foreach (var task in zadaniaNaDzis)
            {
                menagerBruceLee.WykonajZadanie(task);
            }

        }
    }
}