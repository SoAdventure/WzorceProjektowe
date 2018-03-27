using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace factory
{
   public static class factoryPattern

    {
        public static FactoryInterface getObject(string className)
        {

            if (className.Equals("users"))
            
                return new users();

            if (className.Equals("products"))
                return new products();

            if (className.Equals("priviledges"))
                return new priviledges();

            throw new Exception("Nowy obiekt nie może zostać utworzony.");

        }
    }
}
