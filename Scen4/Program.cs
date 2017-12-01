using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scen4
{
    class Program
    {
        static void Main(string[] args)
        {

            double[] inp = new double[4];
            inp = DataProvider.GetInput(0);

            foreach (double i in inp)
                Console.WriteLine(i);

            double[] exp = new double[3];
            exp = DataProvider.GetExpected(0);

            foreach (double i in exp)
                Console.WriteLine(i);

            Console.ReadLine();
        }
    }
}
