using factory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wzorzec_Factory
{ 
  
    public class Program
    {
       public static void Main(string[] args)
        {
            FactoryInterface ob = null;

            string nazwa;
            do
            {
                Console.WriteLine("Podaj nazwę klasy [users, products, priviledges] którą chcesz zobaczyć.");
                nazwa = Console.ReadLine();
            }
            while (nazwa != "products" && nazwa != "users" && nazwa != "priviledges");

            Console.WriteLine("Klasa: ", nazwa);

            if (nazwa == "users")
            {
                try
                {
                    ob = factoryPattern.getObject("users");
                    ob.addItem("Damian Fryta");
                    ob.addItem("Dominik Bulwa");
                    ob.addItem("Darek Pyra");
                    ob.addItem("Daniel Ziemniak");
                    Console.WriteLine(ob.listItems());
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Wystąpił błąd. lipa ;c");
                }
            }
            if (nazwa == "products")
            {
                try
                {
                    ob = factoryPattern.getObject("products");
                    ob.addItem("Frytki");
                    ob.addItem("Kopytka");
                    ob.addItem("Talarki");
                    ob.addItem("Kluski Śląskie");
                    Console.WriteLine(ob.listItems());
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Wystąpił błąd. lipa ;c);
                }
            }
            if (nazwa == "priviledges")
            {
                try
                {
                    ob = factoryPattern.getObject("priviledges");
                    ob.addItem("Pozwolenie na ziemniaka");
                    ob.addItem("Pozwolenie na fryki");
                    ob.addItem("Pozwolenie na kostkę masła do ziemniaka");
                    ob.addItem("Pozwolenie na najpierw ziemniaczki potem mięsko");
                    Console.WriteLine(ob.listItems());
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Wystąpił błąd.lipa ; c");
                }
            }
            Console.Read();
        }
    }
}