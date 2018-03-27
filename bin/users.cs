using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace factory
{
    class users : FactoryInterface
    {

        List<String> list;
        public users()
        {
            list = new List<string>();
        }

      
        string FactoryInterface.listItems()
        {
            foreach (object user in list)
                Console.WriteLine("Nazwa użytkownika: " + user);
            return "";
        }

        string FactoryInterface.addItem(String user)
        {
            list.Add(user);
            return "Użytkownik został dodany:  " + user;
        }


        string FactoryInterface.deleteItem(int number)
        {
            list.RemoveAt(number);
            return "Użytkownik nr" + number + " jest usuniety";
        }

        string FactoryInterface.sortItems()
        {
            return "Sortowanie zakończone.";
        }
    }
}
