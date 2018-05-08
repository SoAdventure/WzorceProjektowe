using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace facade
{
    class Fasada
    {
        public void ObliczPierWieomianu(double a, double b, double c)
        {
            ObliczanieDeltySoMach ob = new ObliczanieDeltySoMach();
            double delta = b * b - 4.0 * a * c;
            if (delta > 0)
            {
                ob.DeltaDod(a, b, c);
            }
            else if (delta == 0)
            {
                ob.DeltaZerowa(a, b, c);
            }
            else
            {
                ob.DeltaUj(a, b, c);
            }
        }
    }
}
