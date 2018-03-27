using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace factory
{
   public class products : FactoryInterface

    {
        List<String> list;
        public products()
        {
            list = new List<string>();
        }

        string FactoryInterface.listItems()
        {
            foreach (object user in list)
                Console.WriteLine("Nazwa produktu: " + user);
            return "";
        }

        string FactoryInterface.sortItems()
        {
            return "Sortowanie zakończone ";
        }

        string FactoryInterface.addItem(String product)
        {
            list.Add(product);
            return "Dodano nowy produkt: " + product;
        }

         string FactoryInterface.deleteItem(int number)
        {
            list.RemoveAt(number);
            return "Produkt o numerze: " + number + " został usunięty.";
        }
    }
}
