using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace factory
{
    interface FactoryInterface
    {
        public string listItems();
        public string addItem();
        public string deleteItem();
    }
}
