using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonApp
{
    class Program
    {
        static void Main(string[] args)
        {

            Singleton.addValue("a");
            Singleton.addValue("b");
            Singleton.addValue("c");
            Singleton.addValue("d");
            Singleton.getList();
            Console.WriteLine("###########");
            Singleton.remove(2);
            Singleton.getList();
        }
    }
}
