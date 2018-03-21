using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace factory
{

    interface IDoTask
    {
        void DoTaskOne();
    }
    
    public class AddItems : IDoTask
    {
        
        public void DoTaskOne()
        {
            Console.WriteLine("Dodaj");
        }
    }
    public class ListItems
    {
        private IDoTask task;
        public ListItems()
        {
            
        }
        
        public void EndTheIssue()
        {
            task.DoTaskOne();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World");
        }
    }
}
