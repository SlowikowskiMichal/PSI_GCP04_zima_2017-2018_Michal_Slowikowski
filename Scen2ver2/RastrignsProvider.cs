using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scen2ver2
{
    class RastrignsProvider
    {
        public static double CalculateResult(double x, double y)
        {
            return 20 + Math.Pow(x,2) + Math.Pow(y,2) - 10 * (Math.Cos(2*Math.PI*x) + Math.Cos(2*Math.PI*y));
        }

        private RastrignsProvider()
        {

        }
    }
}
