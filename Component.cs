using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositePattern
{
    interface Component
    {
        int Ocena { get; set; }
        string NazwaPrzedmiotu { get; set; }

        void Dodaj(Component ob);
        void Usun(Component ob);
        void Wyswietl(int nextOp);
    }
}
