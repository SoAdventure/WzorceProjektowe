using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    public class AdapterWiad : NowaWiadomosc
    {
        
        
            private readonly Wiadomosc _wiadomosc;

            public AdapterWiad(Wiadomosc wiadomosc)
            {
                _wiadomosc = wiadomosc;
            }

            public void Send(string wiad)
            {
               
                _wiadomosc.wysylanie(wiad);
            }
        
    }
}
