using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace factory
{
     class priviledges : FactoryInterface
    {

      
        List<String> list;
        public priviledges()
        {
            list = new List<string>();
        }

        string FactoryInterface.listItems()
        {
            foreach (object user in list)
                Console.WriteLine("Przywilej: " + user);
            return "";
        }

        string FactoryInterface.addItem(String privilege)
        {
            list.Add(privilege);
            return "Przywilej dodany: " + privilege;
        }

        string FactoryInterface.deleteItem(int number)
        {
            list.RemoveAt(number);
            return "Przywilej nr  " + number + " został usunięty.";
        }
        string FactoryInterface.sortItems()
        {
            return "Posortowano.";
        }
    }
}
