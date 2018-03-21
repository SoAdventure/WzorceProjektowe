using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonApp
{
    sealed class Singleton
    {

        private static readonly Singleton instance = new Singleton();
        static List<string> _list;
        private Singleton()
        {
            _list = new List<string>();
        }
        static Singleton()
        {
            
        }
        public static Singleton Instance
        {
            get {
                return instance;
            }
        }

        public static void addValue ( String value )
        {
            _list.Add(value);
        }
        
        public static void remove( int index)
        {
            _list.RemoveAt( index );
        }

        public static void getList()
        {
            foreach (var value in _list)
            {
                Console.WriteLine(value);
            }

        }

    }
}
